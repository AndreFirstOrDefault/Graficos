using System.Drawing;
using System.Windows.Forms;

namespace Graficos.Net4._8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValorX = new System.Windows.Forms.TextBox();
            this.textBoxValorY = new System.Windows.Forms.TextBox();
            this.buttonInserirValores = new System.Windows.Forms.Button();
            this.dataGridViewValores = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.comboBoxTipoGrafico = new System.Windows.Forms.ComboBox();
            this.comboBoxPalleteCor = new System.Windows.Forms.ComboBox();
            this.checkBoxGrafico3D = new System.Windows.Forms.CheckBox();
            this.buttonAleatorio = new System.Windows.Forms.Button();
            this.chartGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gráfico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(175, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de Y";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxValorX
            // 
            this.textBoxValorX.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxValorX.Location = new System.Drawing.Point(10, 65);
            this.textBoxValorX.Name = "textBoxValorX";
            this.textBoxValorX.Size = new System.Drawing.Size(147, 33);
            this.textBoxValorX.TabIndex = 3;
            this.textBoxValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorX_KeyPress);
            // 
            // textBoxValorY
            // 
            this.textBoxValorY.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxValorY.Location = new System.Drawing.Point(163, 65);
            this.textBoxValorY.Name = "textBoxValorY";
            this.textBoxValorY.Size = new System.Drawing.Size(142, 33);
            this.textBoxValorY.TabIndex = 4;
            this.textBoxValorY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorY_KeyPress);
            // 
            // buttonInserirValores
            // 
            this.buttonInserirValores.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonInserirValores.Location = new System.Drawing.Point(10, 104);
            this.buttonInserirValores.Name = "buttonInserirValores";
            this.buttonInserirValores.Size = new System.Drawing.Size(295, 41);
            this.buttonInserirValores.TabIndex = 5;
            this.buttonInserirValores.Text = "Inserir Valores no Gráfico";
            this.buttonInserirValores.UseVisualStyleBackColor = true;
            this.buttonInserirValores.Click += new System.EventHandler(this.buttonInserirValores_Click);
            // 
            // dataGridViewValores
            // 
            this.dataGridViewValores.AllowUserToAddRows = false;
            this.dataGridViewValores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewValores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewValores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewValores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridViewValores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewValores.Location = new System.Drawing.Point(10, 157);
            this.dataGridViewValores.MultiSelect = false;
            this.dataGridViewValores.Name = "dataGridViewValores";
            this.dataGridViewValores.ReadOnly = true;
            this.dataGridViewValores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewValores.RowHeadersVisible = false;
            this.dataGridViewValores.RowHeadersWidth = 50;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewValores.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewValores.RowTemplate.Height = 25;
            this.dataGridViewValores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValores.Size = new System.Drawing.Size(295, 226);
            this.dataGridViewValores.TabIndex = 6;
            this.dataGridViewValores.SelectionChanged += new System.EventHandler(this.dataGridViewValores_SelectionChanged);
            // 
            // x
            // 
            this.x.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x.DividerWidth = 1;
            this.x.HeaderText = "Eixo X";
            this.x.MinimumWidth = 145;
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // y
            // 
            this.y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.y.DividerWidth = 1;
            this.y.HeaderText = "Eixo Y";
            this.y.MinimumWidth = 145;
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLimpar.Location = new System.Drawing.Point(12, 398);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(293, 41);
            this.buttonLimpar.TabIndex = 7;
            this.buttonLimpar.Text = "Limpar Gráfico";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // comboBoxTipoGrafico
            // 
            this.comboBoxTipoGrafico.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxTipoGrafico.FormattingEnabled = true;
            this.comboBoxTipoGrafico.Location = new System.Drawing.Point(13, 454);
            this.comboBoxTipoGrafico.Name = "comboBoxTipoGrafico";
            this.comboBoxTipoGrafico.Size = new System.Drawing.Size(292, 29);
            this.comboBoxTipoGrafico.TabIndex = 8;
            this.comboBoxTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoGrafico_SelectedIndexChanged);
            // 
            // comboBoxPalleteCor
            // 
            this.comboBoxPalleteCor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxPalleteCor.FormattingEnabled = true;
            this.comboBoxPalleteCor.Location = new System.Drawing.Point(311, 454);
            this.comboBoxPalleteCor.Name = "comboBoxPalleteCor";
            this.comboBoxPalleteCor.Size = new System.Drawing.Size(293, 29);
            this.comboBoxPalleteCor.TabIndex = 9;
            this.comboBoxPalleteCor.SelectedIndexChanged += new System.EventHandler(this.comboBoxPalleteCor_SelectedIndexChanged);
            // 
            // checkBoxGrafico3D
            // 
            this.checkBoxGrafico3D.AutoSize = true;
            this.checkBoxGrafico3D.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkBoxGrafico3D.Location = new System.Drawing.Point(610, 456);
            this.checkBoxGrafico3D.Name = "checkBoxGrafico3D";
            this.checkBoxGrafico3D.Size = new System.Drawing.Size(103, 25);
            this.checkBoxGrafico3D.TabIndex = 10;
            this.checkBoxGrafico3D.Text = "Gráfico 3D";
            this.checkBoxGrafico3D.UseVisualStyleBackColor = true;
            this.checkBoxGrafico3D.CheckedChanged += new System.EventHandler(this.checkBoxGrafico3D_CheckedChanged);
            // 
            // buttonAleatorio
            // 
            this.buttonAleatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAleatorio.Location = new System.Drawing.Point(739, 448);
            this.buttonAleatorio.Name = "buttonAleatorio";
            this.buttonAleatorio.Size = new System.Drawing.Size(233, 42);
            this.buttonAleatorio.TabIndex = 11;
            this.buttonAleatorio.Text = "Inserir Valores Aleatórios";
            this.buttonAleatorio.UseVisualStyleBackColor = true;
            this.buttonAleatorio.Click += new System.EventHandler(this.buttonAleatorio_Click);
            // 
            // chartGrafico
            // 
            chartArea4.Name = "ChartArea1";
            this.chartGrafico.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGrafico.Legends.Add(legend4);
            this.chartGrafico.Location = new System.Drawing.Point(311, 12);
            this.chartGrafico.Name = "chartGrafico";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "X vs Y";
            this.chartGrafico.Series.Add(series4);
            this.chartGrafico.Size = new System.Drawing.Size(661, 427);
            this.chartGrafico.TabIndex = 12;
            this.chartGrafico.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 501);
            this.Controls.Add(this.chartGrafico);
            this.Controls.Add(this.buttonAleatorio);
            this.Controls.Add(this.checkBoxGrafico3D);
            this.Controls.Add(this.comboBoxPalleteCor);
            this.Controls.Add(this.comboBoxTipoGrafico);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.dataGridViewValores);
            this.Controls.Add(this.buttonInserirValores);
            this.Controls.Add(this.textBoxValorY);
            this.Controls.Add(this.textBoxValorX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gráfico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxValorX;
        private TextBox textBoxValorY;
        private Button buttonInserirValores;
        private DataGridView dataGridViewValores;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private Button buttonLimpar;
        private ComboBox comboBoxTipoGrafico;
        private ComboBox comboBoxPalleteCor;
        private CheckBox checkBoxGrafico3D;
        private Button buttonAleatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafico;
        private Timer timer;
    }
}

