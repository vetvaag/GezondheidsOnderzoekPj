namespace Gezondheid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabPageBewerken = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSelectDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewEntries = new System.Windows.Forms.DataGridView();
            this.tabPageStatistieken = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageDeelname = new System.Windows.Forms.TabPage();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxSport = new System.Windows.Forms.ComboBox();
            this.labelSport = new System.Windows.Forms.Label();
            this.groupBoxFruit = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelFruit = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabPageBewerken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).BeginInit();
            this.tabPageStatistieken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageDeelname.SuspendLayout();
            this.groupBoxFruit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Fredoka One", 18.25F);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(328, 30);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Gezondheids onderzoek Pj";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // tabPageBewerken
            // 
            this.tabPageBewerken.Controls.Add(this.btnCreate);
            this.tabPageBewerken.Controls.Add(this.btnRefresh);
            this.tabPageBewerken.Controls.Add(this.btnSelectDelete);
            this.tabPageBewerken.Controls.Add(this.buttonSave);
            this.tabPageBewerken.Controls.Add(this.dataGridViewEntries);
            this.tabPageBewerken.Location = new System.Drawing.Point(4, 22);
            this.tabPageBewerken.Name = "tabPageBewerken";
            this.tabPageBewerken.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBewerken.Size = new System.Drawing.Size(782, 330);
            this.tabPageBewerken.TabIndex = 3;
            this.tabPageBewerken.Text = "Bewerken";
            this.tabPageBewerken.UseVisualStyleBackColor = true;
            this.tabPageBewerken.Enter += new System.EventHandler(this.tabPageBewerken_Enter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(139, 267);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 51);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Verversen";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSelectDelete
            // 
            this.btnSelectDelete.Location = new System.Drawing.Point(275, 267);
            this.btnSelectDelete.Name = "btnSelectDelete";
            this.btnSelectDelete.Size = new System.Drawing.Size(123, 51);
            this.btnSelectDelete.TabIndex = 2;
            this.btnSelectDelete.Text = "Verwijder geselecteerd";
            this.btnSelectDelete.UseVisualStyleBackColor = true;
            this.btnSelectDelete.Click += new System.EventHandler(this.btnSelectDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(626, 267);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(137, 51);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Opslaan";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewEntries
            // 
            this.dataGridViewEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntries.Location = new System.Drawing.Point(10, 6);
            this.dataGridViewEntries.Name = "dataGridViewEntries";
            this.dataGridViewEntries.Size = new System.Drawing.Size(757, 255);
            this.dataGridViewEntries.TabIndex = 0;
            // 
            // tabPageStatistieken
            // 
            this.tabPageStatistieken.Controls.Add(this.btnPdf);
            this.tabPageStatistieken.Controls.Add(this.btnExcel);
            this.tabPageStatistieken.Controls.Add(this.chart1);
            this.tabPageStatistieken.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistieken.Name = "tabPageStatistieken";
            this.tabPageStatistieken.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistieken.Size = new System.Drawing.Size(782, 330);
            this.tabPageStatistieken.TabIndex = 2;
            this.tabPageStatistieken.Text = "Statistieken";
            this.tabPageStatistieken.UseVisualStyleBackColor = true;
            this.tabPageStatistieken.Enter += new System.EventHandler(this.tabPageStatistieken_Enter);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(35, 19);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(688, 229);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPageDeelname
            // 
            this.tabPageDeelname.Controls.Add(this.buttonSubmit);
            this.tabPageDeelname.Controls.Add(this.comboBoxSport);
            this.tabPageDeelname.Controls.Add(this.labelSport);
            this.tabPageDeelname.Controls.Add(this.groupBoxFruit);
            this.tabPageDeelname.Controls.Add(this.labelFruit);
            this.tabPageDeelname.Controls.Add(this.txtName);
            this.tabPageDeelname.Controls.Add(this.labelName);
            this.tabPageDeelname.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeelname.Name = "tabPageDeelname";
            this.tabPageDeelname.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeelname.Size = new System.Drawing.Size(782, 330);
            this.tabPageDeelname.TabIndex = 0;
            this.tabPageDeelname.Text = "Deelname";
            this.tabPageDeelname.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(451, 219);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(284, 61);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Deelnemen";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxSport
            // 
            this.comboBoxSport.FormattingEnabled = true;
            this.comboBoxSport.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxSport.Location = new System.Drawing.Point(451, 138);
            this.comboBoxSport.Name = "comboBoxSport";
            this.comboBoxSport.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSport.TabIndex = 5;
            this.comboBoxSport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Location = new System.Drawing.Point(144, 147);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(141, 13);
            this.labelSport.TabIndex = 4;
            this.labelSport.Text = "Hoevaak sport je per week?";
            // 
            // groupBoxFruit
            // 
            this.groupBoxFruit.Controls.Add(this.radioButton5);
            this.groupBoxFruit.Controls.Add(this.radioButton4);
            this.groupBoxFruit.Controls.Add(this.radioButton3);
            this.groupBoxFruit.Controls.Add(this.radioButton2);
            this.groupBoxFruit.Controls.Add(this.radioButton1);
            this.groupBoxFruit.Location = new System.Drawing.Point(451, 81);
            this.groupBoxFruit.Name = "groupBoxFruit";
            this.groupBoxFruit.Size = new System.Drawing.Size(200, 27);
            this.groupBoxFruit.TabIndex = 3;
            this.groupBoxFruit.TabStop = false;
            this.groupBoxFruit.UseCompatibleTextRendering = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(158, 9);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(120, 9);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(82, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelFruit
            // 
            this.labelFruit.AutoSize = true;
            this.labelFruit.Location = new System.Drawing.Point(144, 95);
            this.labelFruit.Name = "labelFruit";
            this.labelFruit.Size = new System.Drawing.Size(141, 13);
            this.labelFruit.TabIndex = 2;
            this.labelFruit.Text = "Hoeveel fruit eet je per dag?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(451, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(144, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Wat is je naam?";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDeelname);
            this.tabControl1.Controls.Add(this.tabPageStatistieken);
            this.tabControl1.Controls.Add(this.tabPageBewerken);
            this.tabControl1.Location = new System.Drawing.Point(-2, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(63, 284);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(275, 40);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Opslaan in excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(396, 284);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(289, 40);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "Opslaan in pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 267);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 51);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Creeren";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageBewerken.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).EndInit();
            this.tabPageStatistieken.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageDeelname.ResumeLayout(false);
            this.tabPageDeelname.PerformLayout();
            this.groupBoxFruit.ResumeLayout(false);
            this.groupBoxFruit.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabPage tabPageBewerken;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewEntries;
        private System.Windows.Forms.TabPage tabPageStatistieken;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPageDeelname;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboBoxSport;
        private System.Windows.Forms.Label labelSport;
        private System.Windows.Forms.GroupBox groupBoxFruit;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelFruit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnSelectDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnCreate;
    }
}

