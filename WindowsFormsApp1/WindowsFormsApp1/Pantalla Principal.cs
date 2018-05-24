using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lenguajesTableAdapter.Fill(this.lenguajesDataSet.Lenguajes);
            comboBox1.SelectedIndex = 0;
            chart1.Series[0].Enabled = true;
            chart1.Series[1].Enabled = false;
            chart1.Series[2].Enabled = false;
            colorDialog1.Color = Color.FromArgb(255);
            chart1.ChartAreas[0].BackColor = Color.FromArgb(255);

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
                if (chart1.ChartAreas.Count > 1)
                {
                    chart1.ChartAreas[1].Area3DStyle.Enable3D = false;
                    chart1.ChartAreas[2].Area3DStyle.Enable3D = false;
                }
               
            }
            else
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                if (chart1.ChartAreas.Count > 1)
                {
                    chart1.ChartAreas[1].Area3DStyle.Enable3D = true;
                    chart1.ChartAreas[2].Area3DStyle.Enable3D = true;
                }
                
            }

        }
        ChartArea Area2 = new ChartArea("Area2");

        ChartArea Area3 = new ChartArea("Area3");
        


        private void cbEstiloGraf_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEstiloGraf.SelectedIndex)
            {
                case 0:
                    if (chart1.ChartAreas.Count > 2)
                    {
                        chart1.ChartAreas.Remove(chart1.ChartAreas.FindByName("Area2"));
                        chart1.ChartAreas.Remove(chart1.ChartAreas.FindByName("Area3"));
                        chart1.Series[1].ChartArea = chart1.ChartAreas[0].Name;
                        chart1.Series[2].ChartArea = chart1.ChartAreas[0].Name;
                    }
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 1:
                    if (chart1.ChartAreas.Count > 2)
                    {
                        chart1.ChartAreas.Remove(chart1.ChartAreas.FindByName("Area2"));
                        chart1.ChartAreas.Remove(chart1.ChartAreas.FindByName("Area3"));
                        chart1.Series[1].ChartArea = chart1.ChartAreas[0].Name;
                        chart1.Series[2].ChartArea = chart1.ChartAreas[0].Name;
                    }
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    break;
                case 2:
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    chart1.ChartAreas.Add(Area2);
                    chart1.Series[1].ChartArea = "Area2";
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    chart1.ChartAreas.Add(Area3);
                    chart1.Series[2].ChartArea = "Area3";
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    break;
                case 3:
                    if (chart1.ChartAreas.Count > 2)
                    {
                        chart1.ChartAreas.Remove(chart1.ChartAreas.FindByName("Area2"));
                        chart1.ChartAreas.Remove(chart1.ChartAreas.FindByName("Area3"));
                        chart1.Series[1].ChartArea = chart1.ChartAreas[0].Name;
                        chart1.Series[2].ChartArea = chart1.ChartAreas[0].Name;
                    }

                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    break;
                case 4:
                    if (chart1.ChartAreas.Count > 2)
                    {
                        chart1.ChartAreas.Remove(chart1.ChartAreas.FindByName("Area2"));
                        chart1.ChartAreas.Remove(chart1.ChartAreas.FindByName("Area3"));
                        chart1.Series[1].ChartArea = chart1.ChartAreas[0].Name;
                        chart1.Series[2].ChartArea = chart1.ChartAreas[0].Name;
                    }
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    break;
                default:
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnColorSerie_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[0].Color = colorDialog1.Color;
            }
        }

        private void btnSerie2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[1].Color = colorDialog1.Color;
            }
        }

        private void btnSerie3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[2].Color = colorDialog1.Color;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIluminacion.SelectedItem)
            {
                case "Ninguno":
                    chart1.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.None;
                    if (chart1.ChartAreas.Count > 1)
                    {
                        chart1.ChartAreas[1].Area3DStyle.LightStyle = LightStyle.None;
                        chart1.ChartAreas[2].Area3DStyle.LightStyle = LightStyle.None;
                        
                    }
                    break;
                case "Simplista":
                    chart1.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.Simplistic;
                    if (chart1.ChartAreas.Count > 1)
                    {
                        chart1.ChartAreas[1].Area3DStyle.LightStyle = LightStyle.Simplistic;
                        chart1.ChartAreas[2].Area3DStyle.LightStyle = LightStyle.Simplistic;
                    }
                    break;
                case "Realista":
                    chart1.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.Realistic;
                    if (chart1.ChartAreas.Count > 1)
                    {
                        chart1.ChartAreas[1].Area3DStyle.LightStyle = LightStyle.Realistic;
                        chart1.ChartAreas[2].Area3DStyle.LightStyle = LightStyle.Realistic;
                    }
                    break;
                default:
                    chart1.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.Simplistic;
                    if (chart1.ChartAreas.Count > 1)
                    {
                        chart1.ChartAreas[1].Area3DStyle.LightStyle = LightStyle.Simplistic;
                        chart1.ChartAreas[2].Area3DStyle.LightStyle = LightStyle.Simplistic;
                    }
                    break;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.ChartAreas[0].BackColor = colorDialog1.Color;

                if (chart1.ChartAreas.Count > 1)
                {
                    chart1.ChartAreas[1].BackColor = colorDialog1.Color;
                    chart1.ChartAreas[2].BackColor = colorDialog1.Color;
                }

            }
        }

        private void cbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbSeries.SelectedIndex)
            {
                case 0:
                    chart1.Series[0].Enabled = true;
                    chart1.Series[1].Enabled = false;
                    chart1.Series[2].Enabled = false;
                    break;
                case 1:
                    chart1.Series[0].Enabled = false;
                    chart1.Series[1].Enabled = true;
                    chart1.Series[2].Enabled = false;
                    break;
                case 2:
                    chart1.Series[0].Enabled = false;
                    chart1.Series[1].Enabled = false;
                    chart1.Series[2].Enabled = true;
                    break;
                default:
                    chart1.Series[0].Enabled = true;
                    chart1.Series[1].Enabled = false;
                    chart1.Series[2].Enabled = false;
                    break;
            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Enabled = true;
            chart1.Series[1].Enabled = true;
            chart1.Series[2].Enabled = true;
        }

        private void btnImagenFondo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.ChartAreas[0].BackImage = openFileDialog1.FileName;
                if (chart1.ChartAreas.Count > 1)
                {
                    chart1.ChartAreas[1].BackImage = openFileDialog1.FileName;
                    chart1.ChartAreas[2].BackImage = openFileDialog1.FileName;
                }
            }
            
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[0].Font = fontDialog1.Font;
                chart1.Series[1].Font = fontDialog1.Font;
                chart1.Series[2].Font = fontDialog1.Font;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Fuente_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    chart1.Palette = ChartColorPalette.None;
                    break;
                case 1:
                    chart1.Palette = ChartColorPalette.Bright;    
                    break;
                case 2:
                    chart1.Palette = ChartColorPalette.Grayscale;
                    break;
                case 3:
                    chart1.Palette = ChartColorPalette.Excel;
                    break;
                case 4:
                    chart1.Palette = ChartColorPalette.Light;
                    break;
                case 5:
                    chart1.Palette = ChartColorPalette.Pastel;
                    break;
                case 6:
                    chart1.Palette = ChartColorPalette.EarthTones;
                    break;
                case 7:
                    chart1.Palette = ChartColorPalette.SemiTransparent;                 
                    break;
                case 8:
                    chart1.Palette = ChartColorPalette.Berry;
                    break;
            }
        }
    }
}
