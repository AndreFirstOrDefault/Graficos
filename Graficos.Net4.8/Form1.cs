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

namespace Graficos.Net4._8
{
    public partial class Form1 : Form
    {
        Dictionary<double, double> valores;
        int contadorX = 0;

        public Form1()
        {
            InitializeComponent();
            valores = new Dictionary<double, double>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxValorX.Focus();
            
            for(int i = 0; i < 35; i++)
            {
                comboBoxTipoGrafico.Items.Add((SeriesChartType)i);
            }

            for (int i = 0; i < 13; i++)
            {
                comboBoxPalleteCor.Items.Add((ChartColorPalette)i);
            }
        }

        private void buttonInserirValores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxValorX.Text) || string.IsNullOrEmpty(textBoxValorY.Text))
            {
                MessageBox.Show("Os dois valores são obrigatórios");
                return;
            }

            if (valores.ContainsKey(double.Parse(textBoxValorX.Text)))
            {
                // Acessa o indice que contem o X e altera só o Y
                valores[double.Parse(textBoxValorX.Text)] = double.Parse(textBoxValorY.Text);
            }
            else
            {
                // Adiciona os dois
                valores.Add(double.Parse(textBoxValorX.Text), double.Parse(textBoxValorY.Text));
            }

            var items = from valor in valores orderby valor.Key ascending select valor;

            dataGridViewValores.Rows.Clear();
            chartGrafico.Series[0].Points.Clear();

            foreach (var item in items)
            {
                dataGridViewValores.Rows.Add(item.Key, item.Value);
                chartGrafico.Series[0].Points.AddXY(item.Key, item.Value);
            }

            chartGrafico.Update();

            textBoxValorX.Text = "";
            textBoxValorY.Text = "";
            textBoxValorX.Focus();
        }

        private void dataGridViewValores_SelectionChanged(object sender, EventArgs e)
        {
            textBoxValorX.Text = dataGridViewValores.Rows[dataGridViewValores.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxValorY.Text = dataGridViewValores.Rows[dataGridViewValores.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            valores.Clear();
            chartGrafico.Series[0].Points.Clear();
            dataGridViewValores.Rows.Clear();
            contadorX = 0;
            textBoxValorX.Text = "";
            textBoxValorY.Text = "";
            textBoxValorX.Focus();
        }

        private void comboBoxTipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartGrafico.Series[0].ChartType = (SeriesChartType)comboBoxTipoGrafico.SelectedItem;
        }

        private void comboBoxPalleteCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartGrafico.Palette = (ChartColorPalette)comboBoxPalleteCor.SelectedItem;
        }

        private void checkBoxGrafico3D_CheckedChanged(object sender, EventArgs e)
        {
            chartGrafico.ChartAreas[0].Area3DStyle.Enable3D = checkBoxGrafico3D.Checked;
        }

        private void buttonAleatorio_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void textBoxValorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) ||
                (textBoxValorX.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void textBoxValorY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) ||
                (textBoxValorY.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (chartGrafico.Series[0].Points.Count() > 10) 
            {
                chartGrafico.Series[0].Points.RemoveAt(0);
                chartGrafico.Update();
            }

            double y = (double) new Random((int)DateTime.Now.Ticks).Next(1000);

            chartGrafico.Series[0].Points.AddXY(contadorX++, y);
            dataGridViewValores.Rows.Add(contadorX, y);
            dataGridViewValores.CurrentCell = dataGridViewValores.Rows[dataGridViewValores.Rows.Count - 1].Cells[0];
        }
    }
}
