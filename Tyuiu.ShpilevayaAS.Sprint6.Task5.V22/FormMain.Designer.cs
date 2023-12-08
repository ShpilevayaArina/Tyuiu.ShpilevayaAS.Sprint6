
namespace Tyuiu.ShpilevayaAS.Sprint6.Task5.V22
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCondition_SAS = new System.Windows.Forms.Panel();
            this.panelOutPut_SAS = new System.Windows.Forms.Panel();
            this.groupBoxCondition_SAS = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SAS = new System.Windows.Forms.TextBox();
            this.dataGridViewOutPut_SAS = new System.Windows.Forms.DataGridView();
            this.chartDiag_SAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_SAS = new System.Windows.Forms.Button();
            this.buttonOpenFile_SAS = new System.Windows.Forms.Button();
            this.buttonHelp_SAS = new System.Windows.Forms.Button();
            this.panelCondition_SAS.SuspendLayout();
            this.panelOutPut_SAS.SuspendLayout();
            this.groupBoxCondition_SAS.SuspendLayout();
            this.groupBoxOutPut_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCondition_SAS
            // 
            this.panelCondition_SAS.BackColor = System.Drawing.SystemColors.Control;
            this.panelCondition_SAS.Controls.Add(this.buttonHelp_SAS);
            this.panelCondition_SAS.Controls.Add(this.buttonOpenFile_SAS);
            this.panelCondition_SAS.Controls.Add(this.buttonDone_SAS);
            this.panelCondition_SAS.Controls.Add(this.groupBoxCondition_SAS);
            this.panelCondition_SAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_SAS.Location = new System.Drawing.Point(0, 0);
            this.panelCondition_SAS.MinimumSize = new System.Drawing.Size(958, 109);
            this.panelCondition_SAS.Name = "panelCondition_SAS";
            this.panelCondition_SAS.Size = new System.Drawing.Size(958, 109);
            this.panelCondition_SAS.TabIndex = 0;
            // 
            // panelOutPut_SAS
            // 
            this.panelOutPut_SAS.Controls.Add(this.groupBoxOutPut_SAS);
            this.panelOutPut_SAS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_SAS.Location = new System.Drawing.Point(0, 109);
            this.panelOutPut_SAS.Name = "panelOutPut_SAS";
            this.panelOutPut_SAS.Size = new System.Drawing.Size(235, 496);
            this.panelOutPut_SAS.TabIndex = 1;
            // 
            // groupBoxCondition_SAS
            // 
            this.groupBoxCondition_SAS.Controls.Add(this.textBoxCondition_SAS);
            this.groupBoxCondition_SAS.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCondition_SAS.Name = "groupBoxCondition_SAS";
            this.groupBoxCondition_SAS.Size = new System.Drawing.Size(547, 100);
            this.groupBoxCondition_SAS.TabIndex = 0;
            this.groupBoxCondition_SAS.TabStop = false;
            this.groupBoxCondition_SAS.Text = "Условие:";
            // 
            // groupBoxOutPut_SAS
            // 
            this.groupBoxOutPut_SAS.Controls.Add(this.dataGridViewOutPut_SAS);
            this.groupBoxOutPut_SAS.Location = new System.Drawing.Point(4, 6);
            this.groupBoxOutPut_SAS.Name = "groupBoxOutPut_SAS";
            this.groupBoxOutPut_SAS.Size = new System.Drawing.Size(228, 486);
            this.groupBoxOutPut_SAS.TabIndex = 0;
            this.groupBoxOutPut_SAS.TabStop = false;
            this.groupBoxOutPut_SAS.Text = "Вывод данных:";
            // 
            // textBoxCondition_SAS
            // 
            this.textBoxCondition_SAS.Location = new System.Drawing.Point(9, 22);
            this.textBoxCondition_SAS.Multiline = true;
            this.textBoxCondition_SAS.Name = "textBoxCondition_SAS";
            this.textBoxCondition_SAS.ReadOnly = true;
            this.textBoxCondition_SAS.Size = new System.Drawing.Size(532, 72);
            this.textBoxCondition_SAS.TabIndex = 0;
            this.textBoxCondition_SAS.Text = "Прочитать данные из файла InPutFileTask5V22.txt. Вывести в dataGridView числа, ко" +
    "торые больше 5. Построить диаграмму по этим значениям.";
            // 
            // dataGridViewOutPut_SAS
            // 
            this.dataGridViewOutPut_SAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SAS.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_SAS.Location = new System.Drawing.Point(9, 22);
            this.dataGridViewOutPut_SAS.Name = "dataGridViewOutPut_SAS";
            this.dataGridViewOutPut_SAS.RowHeadersVisible = false;
            this.dataGridViewOutPut_SAS.RowHeadersWidth = 51;
            this.dataGridViewOutPut_SAS.RowTemplate.Height = 24;
            this.dataGridViewOutPut_SAS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_SAS.Size = new System.Drawing.Size(213, 458);
            this.dataGridViewOutPut_SAS.TabIndex = 0;
            // 
            // chartDiag_SAS
            // 
            this.chartDiag_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chartDiag_SAS.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartDiag_SAS.Legends.Add(legend5);
            this.chartDiag_SAS.Location = new System.Drawing.Point(242, 116);
            this.chartDiag_SAS.Name = "chartDiag_SAS";
            this.chartDiag_SAS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartDiag_SAS.Series.Add(series5);
            this.chartDiag_SAS.Size = new System.Drawing.Size(704, 485);
            this.chartDiag_SAS.TabIndex = 2;
            this.chartDiag_SAS.Text = "chart1";
            // 
            // buttonDone_SAS
            // 
            this.buttonDone_SAS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAS.Location = new System.Drawing.Point(573, 26);
            this.buttonDone_SAS.Name = "buttonDone_SAS";
            this.buttonDone_SAS.Size = new System.Drawing.Size(103, 69);
            this.buttonDone_SAS.TabIndex = 1;
            this.buttonDone_SAS.Text = "Выполнить";
            this.buttonDone_SAS.UseVisualStyleBackColor = false;
            this.buttonDone_SAS.Click += new System.EventHandler(this.buttonDone_SAS_Click);
            // 
            // buttonOpenFile_SAS
            // 
            this.buttonOpenFile_SAS.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_SAS.Location = new System.Drawing.Point(709, 26);
            this.buttonOpenFile_SAS.Name = "buttonOpenFile_SAS";
            this.buttonOpenFile_SAS.Size = new System.Drawing.Size(103, 69);
            this.buttonOpenFile_SAS.TabIndex = 1;
            this.buttonOpenFile_SAS.Text = "Открыть файл";
            this.buttonOpenFile_SAS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SAS.Click += new System.EventHandler(this.buttonOpenFile_SAS_Click);
            // 
            // buttonHelp_SAS
            // 
            this.buttonHelp_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAS.Location = new System.Drawing.Point(843, 26);
            this.buttonHelp_SAS.Name = "buttonHelp_SAS";
            this.buttonHelp_SAS.Size = new System.Drawing.Size(103, 69);
            this.buttonHelp_SAS.TabIndex = 1;
            this.buttonHelp_SAS.Text = "Справка";
            this.buttonHelp_SAS.UseVisualStyleBackColor = false;
            this.buttonHelp_SAS.Click += new System.EventHandler(this.buttonHelp_SAS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 605);
            this.Controls.Add(this.chartDiag_SAS);
            this.Controls.Add(this.panelOutPut_SAS);
            this.Controls.Add(this.panelCondition_SAS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 22 | Шпилевая А. С.";
            this.panelCondition_SAS.ResumeLayout(false);
            this.panelOutPut_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.PerformLayout();
            this.groupBoxOutPut_SAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCondition_SAS;
        private System.Windows.Forms.GroupBox groupBoxCondition_SAS;
        private System.Windows.Forms.TextBox textBoxCondition_SAS;
        private System.Windows.Forms.Panel panelOutPut_SAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAS;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SAS;
        private System.Windows.Forms.Button buttonHelp_SAS;
        private System.Windows.Forms.Button buttonOpenFile_SAS;
        private System.Windows.Forms.Button buttonDone_SAS;
    }
}

