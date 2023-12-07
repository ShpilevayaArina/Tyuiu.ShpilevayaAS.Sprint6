
namespace Tyuiu.ShpilevayaAS.Sprint6.Task4.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SAS = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_SAS = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_SAS = new System.Windows.Forms.TextBox();
            this.labelStartStep_SAS = new System.Windows.Forms.Label();
            this.labelStopStep_SAS = new System.Windows.Forms.Label();
            this.groupBoxOutPut_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAS = new System.Windows.Forms.TextBox();
            this.chartFunction_SAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_SAS = new System.Windows.Forms.Button();
            this.buttonSave_SAS = new System.Windows.Forms.Button();
            this.buttonInfo_SAS = new System.Windows.Forms.Button();
            this.groupBoxCondition_SAS.SuspendLayout();
            this.groupBoxInPut_SAS.SuspendLayout();
            this.groupBoxOutPut_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAS
            // 
            this.groupBoxCondition_SAS.Controls.Add(this.textBoxCondition_SAS);
            this.groupBoxCondition_SAS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_SAS.Name = "groupBoxCondition_SAS";
            this.groupBoxCondition_SAS.Size = new System.Drawing.Size(544, 103);
            this.groupBoxCondition_SAS.TabIndex = 0;
            this.groupBoxCondition_SAS.TabStop = false;
            this.groupBoxCondition_SAS.Text = "Условие";
            // 
            // textBoxCondition_SAS
            // 
            this.textBoxCondition_SAS.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_SAS.Multiline = true;
            this.textBoxCondition_SAS.Name = "textBoxCondition_SAS";
            this.textBoxCondition_SAS.ReadOnly = true;
            this.textBoxCondition_SAS.Size = new System.Drawing.Size(531, 74);
            this.textBoxCondition_SAS.TabIndex = 0;
            this.textBoxCondition_SAS.Text = resources.GetString("textBoxCondition_SAS.Text");
            // 
            // groupBoxInPut_SAS
            // 
            this.groupBoxInPut_SAS.Controls.Add(this.labelStopStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.labelStartStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxStopStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxStartStep_SAS);
            this.groupBoxInPut_SAS.Location = new System.Drawing.Point(563, 14);
            this.groupBoxInPut_SAS.Name = "groupBoxInPut_SAS";
            this.groupBoxInPut_SAS.Size = new System.Drawing.Size(301, 103);
            this.groupBoxInPut_SAS.TabIndex = 1;
            this.groupBoxInPut_SAS.TabStop = false;
            this.groupBoxInPut_SAS.Text = "Ввод данных";
            // 
            // textBoxStartStep_SAS
            // 
            this.textBoxStartStep_SAS.Location = new System.Drawing.Point(7, 52);
            this.textBoxStartStep_SAS.Name = "textBoxStartStep_SAS";
            this.textBoxStartStep_SAS.Size = new System.Drawing.Size(138, 22);
            this.textBoxStartStep_SAS.TabIndex = 0;
            // 
            // textBoxStopStep_SAS
            // 
            this.textBoxStopStep_SAS.Location = new System.Drawing.Point(151, 52);
            this.textBoxStopStep_SAS.Name = "textBoxStopStep_SAS";
            this.textBoxStopStep_SAS.Size = new System.Drawing.Size(138, 22);
            this.textBoxStopStep_SAS.TabIndex = 0;
            // 
            // labelStartStep_SAS
            // 
            this.labelStartStep_SAS.AutoSize = true;
            this.labelStartStep_SAS.Location = new System.Drawing.Point(7, 29);
            this.labelStartStep_SAS.Name = "labelStartStep_SAS";
            this.labelStartStep_SAS.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_SAS.TabIndex = 1;
            this.labelStartStep_SAS.Text = "Старт шага:";
            // 
            // labelStopStep_SAS
            // 
            this.labelStopStep_SAS.AutoSize = true;
            this.labelStopStep_SAS.Location = new System.Drawing.Point(151, 32);
            this.labelStopStep_SAS.Name = "labelStopStep_SAS";
            this.labelStopStep_SAS.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_SAS.TabIndex = 1;
            this.labelStopStep_SAS.Text = "Конец шага:";
            // 
            // groupBoxOutPut_SAS
            // 
            this.groupBoxOutPut_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_SAS.Controls.Add(this.textBoxResult_SAS);
            this.groupBoxOutPut_SAS.Location = new System.Drawing.Point(13, 123);
            this.groupBoxOutPut_SAS.Name = "groupBoxOutPut_SAS";
            this.groupBoxOutPut_SAS.Size = new System.Drawing.Size(326, 574);
            this.groupBoxOutPut_SAS.TabIndex = 2;
            this.groupBoxOutPut_SAS.TabStop = false;
            this.groupBoxOutPut_SAS.Text = "Вывод:";
            // 
            // textBoxResult_SAS
            // 
            this.textBoxResult_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_SAS.Location = new System.Drawing.Point(7, 22);
            this.textBoxResult_SAS.Multiline = true;
            this.textBoxResult_SAS.Name = "textBoxResult_SAS";
            this.textBoxResult_SAS.ReadOnly = true;
            this.textBoxResult_SAS.Size = new System.Drawing.Size(313, 546);
            this.textBoxResult_SAS.TabIndex = 0;
            // 
            // chartFunction_SAS
            // 
            this.chartFunction_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartFunction_SAS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_SAS.Legends.Add(legend2);
            this.chartFunction_SAS.Location = new System.Drawing.Point(361, 123);
            this.chartFunction_SAS.Name = "chartFunction_SAS";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_SAS.Series.Add(series2);
            this.chartFunction_SAS.Size = new System.Drawing.Size(838, 574);
            this.chartFunction_SAS.TabIndex = 3;
            this.chartFunction_SAS.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.MediumBlue;
            title2.Name = "TitleCos";
            title2.Text = "График функции cos(x)";
            this.chartFunction_SAS.Titles.Add(title2);
            // 
            // buttonDone_SAS
            // 
            this.buttonDone_SAS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAS.Location = new System.Drawing.Point(870, 29);
            this.buttonDone_SAS.Name = "buttonDone_SAS";
            this.buttonDone_SAS.Size = new System.Drawing.Size(102, 80);
            this.buttonDone_SAS.TabIndex = 4;
            this.buttonDone_SAS.Text = "Выполнить";
            this.buttonDone_SAS.UseVisualStyleBackColor = false;
            this.buttonDone_SAS.Click += new System.EventHandler(this.buttonDone_SAS_Click);
            // 
            // buttonSave_SAS
            // 
            this.buttonSave_SAS.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_SAS.Location = new System.Drawing.Point(978, 29);
            this.buttonSave_SAS.Name = "buttonSave_SAS";
            this.buttonSave_SAS.Size = new System.Drawing.Size(102, 80);
            this.buttonSave_SAS.TabIndex = 4;
            this.buttonSave_SAS.Text = "Сохранить";
            this.buttonSave_SAS.UseVisualStyleBackColor = false;
            this.buttonSave_SAS.Click += new System.EventHandler(this.buttonSave_SAS_Click);
            // 
            // buttonInfo_SAS
            // 
            this.buttonInfo_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SAS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_SAS.Location = new System.Drawing.Point(1086, 29);
            this.buttonInfo_SAS.Name = "buttonInfo_SAS";
            this.buttonInfo_SAS.Size = new System.Drawing.Size(102, 80);
            this.buttonInfo_SAS.TabIndex = 4;
            this.buttonInfo_SAS.Text = "Справка";
            this.buttonInfo_SAS.UseVisualStyleBackColor = false;
            this.buttonInfo_SAS.Click += new System.EventHandler(this.buttonInfo_SAS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 709);
            this.Controls.Add(this.buttonInfo_SAS);
            this.Controls.Add(this.buttonSave_SAS);
            this.Controls.Add(this.buttonDone_SAS);
            this.Controls.Add(this.chartFunction_SAS);
            this.Controls.Add(this.groupBoxOutPut_SAS);
            this.Controls.Add(this.groupBoxInPut_SAS);
            this.Controls.Add(this.groupBoxCondition_SAS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 7 | Шпилевая А. С.";
            this.groupBoxCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.PerformLayout();
            this.groupBoxInPut_SAS.ResumeLayout(false);
            this.groupBoxInPut_SAS.PerformLayout();
            this.groupBoxOutPut_SAS.ResumeLayout(false);
            this.groupBoxOutPut_SAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAS;
        private System.Windows.Forms.TextBox textBoxCondition_SAS;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAS;
        private System.Windows.Forms.Label labelStopStep_SAS;
        private System.Windows.Forms.Label labelStartStep_SAS;
        private System.Windows.Forms.TextBox textBoxStopStep_SAS;
        private System.Windows.Forms.TextBox textBoxStartStep_SAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAS;
        private System.Windows.Forms.TextBox textBoxResult_SAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAS;
        private System.Windows.Forms.Button buttonDone_SAS;
        private System.Windows.Forms.Button buttonSave_SAS;
        private System.Windows.Forms.Button buttonInfo_SAS;
    }
}

