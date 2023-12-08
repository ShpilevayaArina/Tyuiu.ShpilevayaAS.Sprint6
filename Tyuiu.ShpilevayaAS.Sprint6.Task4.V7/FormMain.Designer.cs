
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chartFunction_SAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCondition_SAS = new System.Windows.Forms.Panel();
            this.buttonInfo_SAS = new System.Windows.Forms.Button();
            this.buttonSave_SAS = new System.Windows.Forms.Button();
            this.buttonDone_SAS = new System.Windows.Forms.Button();
            this.groupBoxInPut_SAS = new System.Windows.Forms.GroupBox();
            this.labelStopStep_SAS = new System.Windows.Forms.Label();
            this.labelStartStep_SAS = new System.Windows.Forms.Label();
            this.textBoxStopStep_SAS = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SAS = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SAS = new System.Windows.Forms.TextBox();
            this.panelOutPut_SAS = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAS)).BeginInit();
            this.panelCondition_SAS.SuspendLayout();
            this.groupBoxInPut_SAS.SuspendLayout();
            this.groupBoxCondition_SAS.SuspendLayout();
            this.panelOutPut_SAS.SuspendLayout();
            this.groupBoxOutPut_SAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunction_SAS
            // 
            this.chartFunction_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SAS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SAS.Legends.Add(legend1);
            this.chartFunction_SAS.Location = new System.Drawing.Point(340, 117);
            this.chartFunction_SAS.Name = "chartFunction_SAS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SAS.Series.Add(series1);
            this.chartFunction_SAS.Size = new System.Drawing.Size(860, 589);
            this.chartFunction_SAS.TabIndex = 3;
            this.chartFunction_SAS.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.MediumBlue;
            title1.Name = "TitleCos";
            title1.Text = "График функции cos(x)";
            this.chartFunction_SAS.Titles.Add(title1);
            // 
            // panelCondition_SAS
            // 
            this.panelCondition_SAS.BackColor = System.Drawing.SystemColors.Control;
            this.panelCondition_SAS.Controls.Add(this.buttonInfo_SAS);
            this.panelCondition_SAS.Controls.Add(this.buttonSave_SAS);
            this.panelCondition_SAS.Controls.Add(this.buttonDone_SAS);
            this.panelCondition_SAS.Controls.Add(this.groupBoxInPut_SAS);
            this.panelCondition_SAS.Controls.Add(this.groupBoxCondition_SAS);
            this.panelCondition_SAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_SAS.Location = new System.Drawing.Point(0, 0);
            this.panelCondition_SAS.Name = "panelCondition_SAS";
            this.panelCondition_SAS.Size = new System.Drawing.Size(1200, 112);
            this.panelCondition_SAS.TabIndex = 5;
            // 
            // buttonInfo_SAS
            // 
            this.buttonInfo_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SAS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_SAS.Location = new System.Drawing.Point(1076, 19);
            this.buttonInfo_SAS.Name = "buttonInfo_SAS";
            this.buttonInfo_SAS.Size = new System.Drawing.Size(102, 80);
            this.buttonInfo_SAS.TabIndex = 7;
            this.buttonInfo_SAS.Text = "Справка";
            this.buttonInfo_SAS.UseVisualStyleBackColor = false;
           this.buttonInfo_SAS.Click += new System.EventHandler(this.buttonInfo_SAS_Click);
            // 
            // buttonSave_SAS
            // 
            this.buttonSave_SAS.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_SAS.Location = new System.Drawing.Point(968, 19);
            this.buttonSave_SAS.Name = "buttonSave_SAS";
            this.buttonSave_SAS.Size = new System.Drawing.Size(102, 80);
            this.buttonSave_SAS.TabIndex = 8;
            this.buttonSave_SAS.Text = "Сохранить";
            this.buttonSave_SAS.UseVisualStyleBackColor = false;
           this.buttonSave_SAS.Click += new System.EventHandler(this.buttonSave_SAS_Click);
            // 
            // buttonDone_SAS
            // 
            this.buttonDone_SAS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAS.Location = new System.Drawing.Point(860, 19);
            this.buttonDone_SAS.Name = "buttonDone_SAS";
            this.buttonDone_SAS.Size = new System.Drawing.Size(102, 80);
            this.buttonDone_SAS.TabIndex = 9;
            this.buttonDone_SAS.Text = "Выполнить";
            this.buttonDone_SAS.UseVisualStyleBackColor = false;
            this.buttonDone_SAS.Click += new System.EventHandler(this.buttonDone_SAS_Click);
            // 
            // groupBoxInPut_SAS
            // 
            this.groupBoxInPut_SAS.Controls.Add(this.labelStopStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.labelStartStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxStopStep_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxStartStep_SAS);
            this.groupBoxInPut_SAS.Location = new System.Drawing.Point(553, 4);
            this.groupBoxInPut_SAS.Name = "groupBoxInPut_SAS";
            this.groupBoxInPut_SAS.Size = new System.Drawing.Size(301, 103);
            this.groupBoxInPut_SAS.TabIndex = 6;
            this.groupBoxInPut_SAS.TabStop = false;
            this.groupBoxInPut_SAS.Text = "Ввод данных";
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
            // labelStartStep_SAS
            // 
            this.labelStartStep_SAS.AutoSize = true;
            this.labelStartStep_SAS.Location = new System.Drawing.Point(7, 29);
            this.labelStartStep_SAS.Name = "labelStartStep_SAS";
            this.labelStartStep_SAS.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_SAS.TabIndex = 1;
            this.labelStartStep_SAS.Text = "Старт шага:";
            // 
            // textBoxStopStep_SAS
            // 
            this.textBoxStopStep_SAS.Location = new System.Drawing.Point(151, 52);
            this.textBoxStopStep_SAS.Name = "textBoxStopStep_SAS";
            this.textBoxStopStep_SAS.Size = new System.Drawing.Size(138, 22);
            this.textBoxStopStep_SAS.TabIndex = 0;
            // 
            // textBoxStartStep_SAS
            // 
            this.textBoxStartStep_SAS.Location = new System.Drawing.Point(7, 52);
            this.textBoxStartStep_SAS.Name = "textBoxStartStep_SAS";
            this.textBoxStartStep_SAS.Size = new System.Drawing.Size(138, 22);
            this.textBoxStartStep_SAS.TabIndex = 0;
            // 
            // groupBoxCondition_SAS
            // 
            this.groupBoxCondition_SAS.Controls.Add(this.textBoxCondition_SAS);
            this.groupBoxCondition_SAS.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition_SAS.Name = "groupBoxCondition_SAS";
            this.groupBoxCondition_SAS.Size = new System.Drawing.Size(544, 103);
            this.groupBoxCondition_SAS.TabIndex = 5;
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
            // panelOutPut_SAS
            // 
            this.panelOutPut_SAS.BackColor = System.Drawing.SystemColors.Control;
            this.panelOutPut_SAS.Controls.Add(this.groupBoxOutPut_SAS);
            this.panelOutPut_SAS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_SAS.Location = new System.Drawing.Point(0, 112);
            this.panelOutPut_SAS.Name = "panelOutPut_SAS";
            this.panelOutPut_SAS.Size = new System.Drawing.Size(334, 597);
            this.panelOutPut_SAS.TabIndex = 6;
            // 
            // groupBoxOutPut_SAS
            // 
            this.groupBoxOutPut_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_SAS.Controls.Add(this.textBoxResult_SAS);
            this.groupBoxOutPut_SAS.Location = new System.Drawing.Point(3, 5);
            this.groupBoxOutPut_SAS.Name = "groupBoxOutPut_SAS";
            this.groupBoxOutPut_SAS.Size = new System.Drawing.Size(319, 589);
            this.groupBoxOutPut_SAS.TabIndex = 3;
            this.groupBoxOutPut_SAS.TabStop = false;
            this.groupBoxOutPut_SAS.Text = "Вывод:";
            // 
            // textBoxResult_SAS
            // 
            this.textBoxResult_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_SAS.Location = new System.Drawing.Point(7, 21);
            this.textBoxResult_SAS.Multiline = true;
            this.textBoxResult_SAS.Name = "textBoxResult_SAS";
            this.textBoxResult_SAS.ReadOnly = true;
            this.textBoxResult_SAS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAS.Size = new System.Drawing.Size(306, 562);
            this.textBoxResult_SAS.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 709);
            this.Controls.Add(this.panelOutPut_SAS);
            this.Controls.Add(this.panelCondition_SAS);
            this.Controls.Add(this.chartFunction_SAS);
            this.MinimumSize = new System.Drawing.Size(1218, 756);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 7 | Шпилевая А. С.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAS)).EndInit();
            this.panelCondition_SAS.ResumeLayout(false);
            this.groupBoxInPut_SAS.ResumeLayout(false);
            this.groupBoxInPut_SAS.PerformLayout();
            this.groupBoxCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.PerformLayout();
            this.panelOutPut_SAS.ResumeLayout(false);
            this.groupBoxOutPut_SAS.ResumeLayout(false);
            this.groupBoxOutPut_SAS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAS;
        private System.Windows.Forms.Panel panelCondition_SAS;
        private System.Windows.Forms.Button buttonInfo_SAS;
        private System.Windows.Forms.Button buttonSave_SAS;
        private System.Windows.Forms.Button buttonDone_SAS;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAS;
        private System.Windows.Forms.Label labelStopStep_SAS;
        private System.Windows.Forms.Label labelStartStep_SAS;
        private System.Windows.Forms.TextBox textBoxStopStep_SAS;
        private System.Windows.Forms.TextBox textBoxStartStep_SAS;
        private System.Windows.Forms.GroupBox groupBoxCondition_SAS;
        private System.Windows.Forms.TextBox textBoxCondition_SAS;
        private System.Windows.Forms.Panel panelOutPut_SAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAS;
        private System.Windows.Forms.TextBox textBoxResult_SAS;
    }
}

