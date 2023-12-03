
namespace Tyuiu.ShpilevayaAS.Sprint6.Task2.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SAS = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_SAS = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_SAS = new System.Windows.Forms.TextBox();
            this.labelSartStep_SAS = new System.Windows.Forms.Label();
            this.labelStopStep_SAS = new System.Windows.Forms.Label();
            this.buttonDone_SAS = new System.Windows.Forms.Button();
            this.buttonInfo_SAS = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SAS = new System.Windows.Forms.GroupBox();
            this.labelResult_SAS = new System.Windows.Forms.Label();
            this.chartFunction_SAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_SAS = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_SAS.SuspendLayout();
            this.groupBoxInPut_SAS.SuspendLayout();
            this.groupBoxOutPut_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAS
            // 
            this.groupBoxCondition_SAS.Controls.Add(this.textBoxCondition_SAS);
            this.groupBoxCondition_SAS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_SAS.Name = "groupBoxCondition_SAS";
            this.groupBoxCondition_SAS.Size = new System.Drawing.Size(603, 319);
            this.groupBoxCondition_SAS.TabIndex = 0;
            this.groupBoxCondition_SAS.TabStop = false;
            this.groupBoxCondition_SAS.Text = "Условие";
            // 
            // textBoxCondition_SAS
            // 
            this.textBoxCondition_SAS.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_SAS.Multiline = true;
            this.textBoxCondition_SAS.Name = "textBoxCondition_SAS";
            this.textBoxCondition_SAS.ReadOnly = true;
            this.textBoxCondition_SAS.Size = new System.Drawing.Size(591, 265);
            this.textBoxCondition_SAS.TabIndex = 1;
            this.textBoxCondition_SAS.Text = "Протабулировать функцию F(x) = cos(2x) + (sin(x)) /( x + 2,5) + 2 * x  на заданно" +
    "м диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxInPut_SAS
            // 
            this.groupBoxInPut_SAS.Controls.Add(this.labelStopStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.labelSartStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxStopStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxStartStep_SAS);
            this.groupBoxInPut_SAS.Location = new System.Drawing.Point(13, 338);
            this.groupBoxInPut_SAS.Name = "groupBoxInPut_SAS";
            this.groupBoxInPut_SAS.Size = new System.Drawing.Size(357, 81);
            this.groupBoxInPut_SAS.TabIndex = 1;
            this.groupBoxInPut_SAS.TabStop = false;
            this.groupBoxInPut_SAS.Text = "Ввод данных";
            // 
            // textBoxStartStep_SAS
            // 
            this.textBoxStartStep_SAS.Location = new System.Drawing.Point(7, 45);
            this.textBoxStartStep_SAS.Name = "textBoxStartStep_SAS";
            this.textBoxStartStep_SAS.Size = new System.Drawing.Size(144, 22);
            this.textBoxStartStep_SAS.TabIndex = 0;
            // 
            // textBoxStopStep_SAS
            // 
            this.textBoxStopStep_SAS.Location = new System.Drawing.Point(196, 45);
            this.textBoxStopStep_SAS.Name = "textBoxStopStep_SAS";
            this.textBoxStopStep_SAS.Size = new System.Drawing.Size(144, 22);
            this.textBoxStopStep_SAS.TabIndex = 0;
            // 
            // labelSartStep_SAS
            // 
            this.labelSartStep_SAS.AutoSize = true;
            this.labelSartStep_SAS.Location = new System.Drawing.Point(7, 22);
            this.labelSartStep_SAS.Name = "labelSartStep_SAS";
            this.labelSartStep_SAS.Size = new System.Drawing.Size(87, 17);
            this.labelSartStep_SAS.TabIndex = 1;
            this.labelSartStep_SAS.Text = "Старт шага:";
            // 
            // labelStopStep_SAS
            // 
            this.labelStopStep_SAS.AutoSize = true;
            this.labelStopStep_SAS.Location = new System.Drawing.Point(193, 25);
            this.labelStopStep_SAS.Name = "labelStopStep_SAS";
            this.labelStopStep_SAS.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_SAS.TabIndex = 1;
            this.labelStopStep_SAS.Text = "Конец шага:";
            // 
            // buttonDone_SAS
            // 
            this.buttonDone_SAS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAS.Location = new System.Drawing.Point(471, 347);
            this.buttonDone_SAS.Name = "buttonDone_SAS";
            this.buttonDone_SAS.Size = new System.Drawing.Size(145, 72);
            this.buttonDone_SAS.TabIndex = 6;
            this.buttonDone_SAS.Text = "Выполнить";
            this.buttonDone_SAS.UseVisualStyleBackColor = false;
            this.buttonDone_SAS.Click += new System.EventHandler(this.buttonDone_SAS_Click);
            this.buttonDone_SAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SAS_MouseDown);
            this.buttonDone_SAS.MouseEnter += new System.EventHandler(this.buttonDone_SAS_MouseEnter);
            this.buttonDone_SAS.MouseLeave += new System.EventHandler(this.buttonDone_SAS_MouseLeave);
            // 
            // buttonInfo_SAS
            // 
            this.buttonInfo_SAS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_SAS.Location = new System.Drawing.Point(376, 347);
            this.buttonInfo_SAS.Name = "buttonInfo_SAS";
            this.buttonInfo_SAS.Size = new System.Drawing.Size(89, 72);
            this.buttonInfo_SAS.TabIndex = 5;
            this.buttonInfo_SAS.Text = "Справка";
            this.buttonInfo_SAS.UseVisualStyleBackColor = false;
            this.buttonInfo_SAS.Click += new System.EventHandler(this.buttonInfo_SAS_Click);
            // 
            // groupBoxOutPut_SAS
            // 
            this.groupBoxOutPut_SAS.Controls.Add(this.dataGridViewFunction_SAS);
            this.groupBoxOutPut_SAS.Controls.Add(this.chartFunction_SAS);
            this.groupBoxOutPut_SAS.Controls.Add(this.labelResult_SAS);
            this.groupBoxOutPut_SAS.Location = new System.Drawing.Point(623, 13);
            this.groupBoxOutPut_SAS.Name = "groupBoxOutPut_SAS";
            this.groupBoxOutPut_SAS.Size = new System.Drawing.Size(661, 406);
            this.groupBoxOutPut_SAS.TabIndex = 7;
            this.groupBoxOutPut_SAS.TabStop = false;
            this.groupBoxOutPut_SAS.Text = "Вывод данных";
            // 
            // labelResult_SAS
            // 
            this.labelResult_SAS.AutoSize = true;
            this.labelResult_SAS.Location = new System.Drawing.Point(7, 22);
            this.labelResult_SAS.Name = "labelResult_SAS";
            this.labelResult_SAS.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SAS.TabIndex = 0;
            this.labelResult_SAS.Text = "Результат:";
            // 
            // chartFunction_SAS
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_SAS.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction_SAS.Legends.Add(legend4);
            this.chartFunction_SAS.Location = new System.Drawing.Point(175, 43);
            this.chartFunction_SAS.Name = "chartFunction_SAS";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_SAS.Series.Add(series4);
            this.chartFunction_SAS.Size = new System.Drawing.Size(480, 352);
            this.chartFunction_SAS.TabIndex = 1;
            this.chartFunction_SAS.Text = "chart1";
            // 
            // dataGridViewFunction_SAS
            // 
            this.dataGridViewFunction_SAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_SAS.Location = new System.Drawing.Point(10, 43);
            this.dataGridViewFunction_SAS.Name = "dataGridViewFunction_SAS";
            this.dataGridViewFunction_SAS.RowHeadersVisible = false;
            this.dataGridViewFunction_SAS.RowTemplate.Height = 24;
            this.dataGridViewFunction_SAS.Size = new System.Drawing.Size(159, 349);
            this.dataGridViewFunction_SAS.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 450);
            this.Controls.Add(this.groupBoxOutPut_SAS);
            this.Controls.Add(this.buttonDone_SAS);
            this.Controls.Add(this.buttonInfo_SAS);
            this.Controls.Add(this.groupBoxInPut_SAS);
            this.Controls.Add(this.groupBoxCondition_SAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 22 | Шпилевая А. С.";
            this.groupBoxCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.PerformLayout();
            this.groupBoxInPut_SAS.ResumeLayout(false);
            this.groupBoxInPut_SAS.PerformLayout();
            this.groupBoxOutPut_SAS.ResumeLayout(false);
            this.groupBoxOutPut_SAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAS;
        private System.Windows.Forms.TextBox textBoxCondition_SAS;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAS;
        private System.Windows.Forms.Label labelStopStep_SAS;
        private System.Windows.Forms.Label labelSartStep_SAS;
        private System.Windows.Forms.TextBox textBoxStopStep_SAS;
        private System.Windows.Forms.TextBox textBoxStartStep_SAS;
        private System.Windows.Forms.Button buttonDone_SAS;
        private System.Windows.Forms.Button buttonInfo_SAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAS;
        private System.Windows.Forms.Label labelResult_SAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAS;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

