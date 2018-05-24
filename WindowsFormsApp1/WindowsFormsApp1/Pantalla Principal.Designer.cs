namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lenguajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lenguajesDataSet = new WindowsFormsApp1.LenguajesDataSet();
            this.lenguajes2010BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lenguajesTableAdapter = new WindowsFormsApp1.LenguajesDataSetTableAdapters.LenguajesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbEstiloGraf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fuente = new System.Windows.Forms.Label();
            this.btnFuente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImagenFondo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSerie3 = new System.Windows.Forms.Button();
            this.btnSerie2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColorSerie = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIluminacion = new System.Windows.Forms.ComboBox();
            this.btnTodas = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbSeries = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajes2010BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.lenguajesBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 53);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "2018";
            series1.XValueMember = "Lenguaje";
            series1.YValueMembers = "Popularidad";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "2010";
            series2.XValueMember = "Lenguaje";
            series2.YValueMembers = "Popularidad2010";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "2000";
            series3.XValueMember = "Lenguaje";
            series3.YValueMembers = "Popularidad2000";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(502, 423);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lenguajesBindingSource
            // 
            this.lenguajesBindingSource.DataMember = "Lenguajes";
            this.lenguajesBindingSource.DataSource = this.lenguajesDataSet;
            // 
            // lenguajesDataSet
            // 
            this.lenguajesDataSet.DataSetName = "LenguajesDataSet";
            this.lenguajesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lenguajes2010BindingSource
            // 
            this.lenguajes2010BindingSource.DataMember = "Lenguajes2010";
            // 
            // lenguajesTableAdapter
            // 
            this.lenguajesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.comboBox1.Location = new System.Drawing.Point(716, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbEstiloGraf
            // 
            this.cbEstiloGraf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstiloGraf.FormattingEnabled = true;
            this.cbEstiloGraf.Items.AddRange(new object[] {
            "Columna",
            "Barra",
            "Pie",
            "Linea ",
            "Area"});
            this.cbEstiloGraf.Location = new System.Drawing.Point(716, 87);
            this.cbEstiloGraf.Name = "cbEstiloGraf";
            this.cbEstiloGraf.Size = new System.Drawing.Size(121, 21);
            this.cbEstiloGraf.TabIndex = 2;
            this.cbEstiloGraf.SelectedIndexChanged += new System.EventHandler(this.cbEstiloGraf_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo Grafico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estilo Grafico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Fuente);
            this.groupBox1.Controls.Add(this.btnFuente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnImagenFondo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBackColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbIluminacion);
            this.groupBox1.Location = new System.Drawing.Point(541, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 288);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra";
            // 
            // Fuente
            // 
            this.Fuente.AutoSize = true;
            this.Fuente.Location = new System.Drawing.Point(98, 222);
            this.Fuente.Name = "Fuente";
            this.Fuente.Size = new System.Drawing.Size(40, 13);
            this.Fuente.TabIndex = 21;
            this.Fuente.Text = "Fuente";
            // 
            // btnFuente
            // 
            this.btnFuente.Location = new System.Drawing.Point(171, 222);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(121, 23);
            this.btnFuente.TabIndex = 20;
            this.btnFuente.Text = "Fuente";
            this.btnFuente.UseVisualStyleBackColor = true;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Imagen de fondo";
            // 
            // btnImagenFondo
            // 
            this.btnImagenFondo.Location = new System.Drawing.Point(170, 193);
            this.btnImagenFondo.Name = "btnImagenFondo";
            this.btnImagenFondo.Size = new System.Drawing.Size(122, 23);
            this.btnImagenFondo.TabIndex = 18;
            this.btnImagenFondo.Text = "Abrir";
            this.btnImagenFondo.UseVisualStyleBackColor = true;
            this.btnImagenFondo.Click += new System.EventHandler(this.btnImagenFondo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSerie3);
            this.groupBox2.Controls.Add(this.btnSerie2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnColorSerie);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(57, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 117);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Series";
            // 
            // btnSerie3
            // 
            this.btnSerie3.Location = new System.Drawing.Point(113, 83);
            this.btnSerie3.Name = "btnSerie3";
            this.btnSerie3.Size = new System.Drawing.Size(121, 23);
            this.btnSerie3.TabIndex = 16;
            this.btnSerie3.Text = "Color";
            this.btnSerie3.UseVisualStyleBackColor = true;
            this.btnSerie3.Click += new System.EventHandler(this.btnSerie3_Click);
            // 
            // btnSerie2
            // 
            this.btnSerie2.Location = new System.Drawing.Point(114, 53);
            this.btnSerie2.Name = "btnSerie2";
            this.btnSerie2.Size = new System.Drawing.Size(121, 23);
            this.btnSerie2.TabIndex = 14;
            this.btnSerie2.Text = "Color";
            this.btnSerie2.UseVisualStyleBackColor = true;
            this.btnSerie2.Click += new System.EventHandler(this.btnSerie2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Serie 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serie 1";
            // 
            // btnColorSerie
            // 
            this.btnColorSerie.Location = new System.Drawing.Point(114, 24);
            this.btnColorSerie.Name = "btnColorSerie";
            this.btnColorSerie.Size = new System.Drawing.Size(121, 23);
            this.btnColorSerie.TabIndex = 9;
            this.btnColorSerie.Text = "Color";
            this.btnColorSerie.UseVisualStyleBackColor = true;
            this.btnColorSerie.Click += new System.EventHandler(this.btnColorSerie_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Serie 2";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(170, 164);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(122, 23);
            this.btnBackColor.TabIndex = 11;
            this.btnBackColor.Text = "Color";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color de fondo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iluminación";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbIluminacion
            // 
            this.cbIluminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIluminacion.FormattingEnabled = true;
            this.cbIluminacion.Items.AddRange(new object[] {
            "Ninguno",
            "Simplista",
            "Realista"});
            this.cbIluminacion.Location = new System.Drawing.Point(171, 137);
            this.cbIluminacion.Name = "cbIluminacion";
            this.cbIluminacion.Size = new System.Drawing.Size(121, 21);
            this.cbIluminacion.TabIndex = 6;
            this.cbIluminacion.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(648, 159);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(189, 23);
            this.btnTodas.TabIndex = 12;
            this.btnTodas.Text = "Mostrar todas las series";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // cbSeries
            // 
            this.cbSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeries.FormattingEnabled = true;
            this.cbSeries.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSeries.Location = new System.Drawing.Point(716, 124);
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Size = new System.Drawing.Size(121, 21);
            this.cbSeries.TabIndex = 6;
            this.cbSeries.SelectedIndexChanged += new System.EventHandler(this.cbSeries_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Series";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.cbSeries);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEstiloGraf);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajes2010BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private LenguajesDataSet lenguajesDataSet;
        private System.Windows.Forms.BindingSource lenguajesBindingSource;
        private LenguajesDataSetTableAdapters.LenguajesTableAdapter lenguajesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbEstiloGraf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIluminacion;
        private System.Windows.Forms.Button btnColorSerie;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.BindingSource lenguajes2010BindingSource;
        private System.Windows.Forms.ComboBox cbSeries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Button btnSerie3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSerie2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImagenFondo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Fuente;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

