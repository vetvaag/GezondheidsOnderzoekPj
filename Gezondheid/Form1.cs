using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Gezondheid
{
    public partial class Form1 : Form
    {

        private string connectionString = "Server=LAPTOP-HMD6TF9K\\SQLExpress;Database=gezondheidDB;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string naam = txtName.Text.Trim();
            int fruitPerDag = 0;
            int sportPerWeek = 0;

            if (radioButton1.Checked)
                fruitPerDag = 1;
            else if (radioButton2.Checked)
                fruitPerDag = 2;
            else if (radioButton3.Checked)
                fruitPerDag = 3;
            else if (radioButton4.Checked)
                fruitPerDag = 4;
            else if (radioButton5.Checked)
                fruitPerDag = 5;

            // Validate the inputs
            if (string.IsNullOrEmpty(naam))
            {
                MessageBox.Show("Vul je naam in.");
                return;
            }
            if (fruitPerDag == 0)
            {
                MessageBox.Show("Selecteer hoeveel fruit je per dag eet.");
                return;
            }
            if (comboBoxSport.SelectedItem == null)
            {
                MessageBox.Show("Selecteer hoe vaak je per week sport.");
                return;
            }
            else
            {
                sportPerWeek = int.Parse(comboBoxSport.SelectedItem.ToString());
            }

            // Insert data into the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Participants (Name, FruitPerDay, SportPerWeek) VALUES (@Naam, @FruitPerDag, @SportPerWeek)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Naam", naam);
                cmd.Parameters.AddWithValue("@FruitPerDag", fruitPerDag);
                cmd.Parameters.AddWithValue("@SportPerWeek", sportPerWeek);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gegevens opgeslagen!");
                    // Optionally, clear the input fields
                    txtName.Text = "";
                    comboBoxSport.SelectedIndex = -1;
                    foreach (RadioButton rb in groupBoxFruit.Controls.OfType<RadioButton>())
                    {
                        rb.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij het opslaan van gegevens: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void tabPageStatistieken_Enter(object sender, EventArgs e)
        {
            // Clear previous series
            chart1.Series.Clear();

            // Create new series for average fruit and sport
            Series fruitSeries = new Series("Gemiddeld Fruit Per Dag")
            {
                ChartType = SeriesChartType.Column
            };
            Series sportSeries = new Series("Gemiddeld Sport Per Week")
            {
                ChartType = SeriesChartType.Column
            };

            // Add series to the chart
            chart1.Series.Add(fruitSeries);
            chart1.Series.Add(sportSeries);

            // Configure chart area (optional but recommended)
            chart1.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Categorie"; // Add X Axis Title
            chartArea.AxisY.Title = "Gemiddelde"; // Add Y Axis Title
            chart1.ChartAreas.Add(chartArea);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AVG(FruitPerDay) AS AvgFruit, AVG(SportPerWeek) AS AvgSport FROM Participants";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        decimal avgFruit = reader["AvgFruit"] != DBNull.Value ? Convert.ToDecimal(reader["AvgFruit"]) : 0;
                        decimal avgSport = reader["AvgSport"] != DBNull.Value ? Convert.ToDecimal(reader["AvgSport"]) : 0;

                        // Debug messages
                        Console.WriteLine($"AvgFruit: {avgFruit}, AvgSport: {avgSport}");

                        // Add points to the series
                        fruitSeries.Points.AddY(avgFruit);
                        sportSeries.Points.AddY(avgSport);
                    }
                    else
                    {
                        MessageBox.Show("Geen gegevens beschikbaar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij het ophalen van statistieken: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            // Refresh the chart
            chart1.Invalidate();
        }



        private void tabPageBewerken_Enter(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Participants";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    dataGridViewEntries.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij het laden van gegevens: " + ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            btnRefresh_Click(sender, e);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Participants", conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable dt = (DataTable)dataGridViewEntries.DataSource;
                    adapter.Update(dt);

                    MessageBox.Show("Gegevens bijgewerkt!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij het opslaan van wijzigingen: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Re-fetch the data from the database and bind it to the DataGridView
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Participants";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    dataGridViewEntries.DataSource = dt;  // Bind the data to the DataGridView
                    MessageBox.Show("Gegevens vernieuwd!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij het vernieuwen van de gegevens: " + ex.Message);
                }
            }
        }


        private void btnSelectDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntries.SelectedRows.Count > 0)  // Ensure a row is selected
            {
                // Get the ID of the selected row (assuming the ID column is the first column)
                int selectedRowId = Convert.ToInt32(dataGridViewEntries.SelectedRows[0].Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Participants WHERE Id = @Id";  // Assuming 'Id' is the primary key
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", selectedRowId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Optionally, remove the row from DataGridView after deletion
                        dataGridViewEntries.Rows.RemoveAt(dataGridViewEntries.SelectedRows[0].Index);

                        MessageBox.Show("Gegevens verwijderd!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fout bij het verwijderen van de gegevens: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecteer een rij om te verwijderen.");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Check if DataGridView has data (ignore new row placeholder)
            bool hasData = false;

            // Loop through all rows and check if at least one row has data
            foreach (DataGridViewRow row in dataGridViewEntries.Rows)
            {
                // If the row is not the new row placeholder and contains data
                if (!row.IsNewRow && row.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null && c.Value.ToString() != string.Empty))
                {
                    hasData = true;
                    break; // Exit the loop as soon as we find a row with data
                }
            }

            if (hasData)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.Sheets[1];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Deelnemers Data";

                try
                {
                    // Add headers to Excel file
                    for (int i = 1; i < dataGridViewEntries.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridViewEntries.Columns[i - 1].HeaderText;
                    }

                    // Add data to Excel file
                    int rowIndex = 2; // Start at row 2 because row 1 is for headers
                    foreach (DataGridViewRow row in dataGridViewEntries.Rows)
                    {
                        // Skip the new row placeholder and empty rows
                        if (!row.IsNewRow && row.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null && c.Value.ToString() != string.Empty))
                        {
                            for (int j = 0; j < dataGridViewEntries.Columns.Count; j++)
                            {
                                worksheet.Cells[rowIndex, j + 1] = row.Cells[j].Value?.ToString();
                            }
                            rowIndex++; // Move to the next row in Excel
                        }
                    }

                    // Save Excel file
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        FileName = "Gezondheidscheck.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Data geexporteerd naar Excel");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Excel: " + ex.Message);
                }
                finally
                {
                    workbook.Close();
                    excelApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Geen data om te exporteren");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = "Gezondheidsonderzoek.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Create PDF document
                    Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    // Add Title
                    pdfDoc.Add(new Paragraph("Deelnemers Data\n\n"));

                    // Add DataGridView Data
                    PdfPTable pdfTable = new PdfPTable(dataGridViewEntries.Columns.Count);

                    // Add headers
                    foreach (DataGridViewColumn column in dataGridViewEntries.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }

                    // Add rows
                    foreach (DataGridViewRow row in dataGridViewEntries.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                    }

                    pdfDoc.Add(pdfTable);

                    // Add Chart
                    var chartImage = new MemoryStream();
                    chart1.SaveImage(chartImage, ChartImageFormat.Png);
                    iTextSharp.text.Image pdfChart = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());
                    pdfChart.ScaleToFit(500f, 300f); // Scale chart size
                    pdfDoc.Add(new Paragraph("\n\nCrafiekt: Gemiddeld Fruit & Sport Per Week\n\n"));
                    pdfDoc.Add(pdfChart);

                    pdfDoc.Close();
                    writer.Close();
                    MessageBox.Show("Data geexporteerd naar PDF.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error PDF: " + ex.Message);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
    }
}
