
namespace Tyuiu.ShpilevayaAS.Sprint6.Task1.V1
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
            this.groupBoxCondition_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SAS = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SAS = new System.Windows.Forms.GroupBox();
            this.labelStartValue_SAS = new System.Windows.Forms.Label();
            this.labelStopValue_SAS = new System.Windows.Forms.Label();
            this.textBoxStartValue_SAS = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_SAS = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SAS = new System.Windows.Forms.GroupBox();
            this.labelResult_SAS = new System.Windows.Forms.Label();
            this.textBoxResult_SAS = new System.Windows.Forms.TextBox();
            this.buttonInfo_SAS = new System.Windows.Forms.Button();
            this.buttonDone_SAS = new System.Windows.Forms.Button();
            this.groupBoxCondition_SAS.SuspendLayout();
            this.groupBoxInPut_SAS.SuspendLayout();
            this.groupBoxOutPut_SAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAS
            // 
            this.groupBoxCondition_SAS.Controls.Add(this.textBoxCondition_SAS);
            this.groupBoxCondition_SAS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_SAS.Name = "groupBoxCondition_SAS";
            this.groupBoxCondition_SAS.Size = new System.Drawing.Size(634, 293);
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
            this.textBoxCondition_SAS.Size = new System.Drawing.Size(621, 265);
            this.textBoxCondition_SAS.TabIndex = 0;
            this.textBoxCondition_SAS.Text = "Протабулировать функцию F(x) = cos(2x) + (sin(x)) /( x + 2,5) + 2 * x  на заданно" +
    "м диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxInPut_SAS
            // 
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxStopValue_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxStartValue_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.labelStopValue_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.labelStartValue_SAS);
            this.groupBoxInPut_SAS.Location = new System.Drawing.Point(13, 313);
            this.groupBoxInPut_SAS.Name = "groupBoxInPut_SAS";
            this.groupBoxInPut_SAS.Size = new System.Drawing.Size(382, 78);
            this.groupBoxInPut_SAS.TabIndex = 1;
            this.groupBoxInPut_SAS.TabStop = false;
            this.groupBoxInPut_SAS.Text = "Ввод данных";
            // 
            // labelStartValue_SAS
            // 
            this.labelStartValue_SAS.AutoSize = true;
            this.labelStartValue_SAS.Location = new System.Drawing.Point(7, 22);
            this.labelStartValue_SAS.Name = "labelStartValue_SAS";
            this.labelStartValue_SAS.Size = new System.Drawing.Size(87, 17);
            this.labelStartValue_SAS.TabIndex = 0;
            this.labelStartValue_SAS.Text = "Старт шага:";
            // 
            // labelStopValue_SAS
            // 
            this.labelStopValue_SAS.AutoSize = true;
            this.labelStopValue_SAS.Location = new System.Drawing.Point(208, 22);
            this.labelStopValue_SAS.Name = "labelStopValue_SAS";
            this.labelStopValue_SAS.Size = new System.Drawing.Size(89, 17);
            this.labelStopValue_SAS.TabIndex = 1;
            this.labelStopValue_SAS.Text = "Конец шага:";
            // 
            // textBoxStartValue_SAS
            // 
            this.textBoxStartValue_SAS.Location = new System.Drawing.Point(10, 42);
            this.textBoxStartValue_SAS.Name = "textBoxStartValue_SAS";
            this.textBoxStartValue_SAS.Size = new System.Drawing.Size(165, 22);
            this.textBoxStartValue_SAS.TabIndex = 2;
            // 
            // textBoxStopValue_SAS
            // 
            this.textBoxStopValue_SAS.Location = new System.Drawing.Point(211, 42);
            this.textBoxStopValue_SAS.Name = "textBoxStopValue_SAS";
            this.textBoxStopValue_SAS.Size = new System.Drawing.Size(165, 22);
            this.textBoxStopValue_SAS.TabIndex = 3;
            // 
            // groupBoxOutPut_SAS
            // 
            this.groupBoxOutPut_SAS.Controls.Add(this.textBoxResult_SAS);
            this.groupBoxOutPut_SAS.Controls.Add(this.labelResult_SAS);
            this.groupBoxOutPut_SAS.Location = new System.Drawing.Point(654, 35);
            this.groupBoxOutPut_SAS.Name = "groupBoxOutPut_SAS";
            this.groupBoxOutPut_SAS.Size = new System.Drawing.Size(316, 356);
            this.groupBoxOutPut_SAS.TabIndex = 2;
            this.groupBoxOutPut_SAS.TabStop = false;
            this.groupBoxOutPut_SAS.Text = "Вывод данных";
            // 
            // labelResult_SAS
            // 
            this.labelResult_SAS.AutoSize = true;
            this.labelResult_SAS.Location = new System.Drawing.Point(6, 18);
            this.labelResult_SAS.Name = "labelResult_SAS";
            this.labelResult_SAS.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SAS.TabIndex = 1;
            this.labelResult_SAS.Text = "Результат:";
            // 
            // textBoxResult_SAS
            // 
            this.textBoxResult_SAS.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SAS.Location = new System.Drawing.Point(9, 39);
            this.textBoxResult_SAS.Multiline = true;
            this.textBoxResult_SAS.Name = "textBoxResult_SAS";
            this.textBoxResult_SAS.ReadOnly = true;
            this.textBoxResult_SAS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAS.Size = new System.Drawing.Size(301, 311);
            this.textBoxResult_SAS.TabIndex = 2;
            // 
            // buttonInfo_SAS
            // 
            this.buttonInfo_SAS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_SAS.Location = new System.Drawing.Point(401, 319);
            this.buttonInfo_SAS.Name = "buttonInfo_SAS";
            this.buttonInfo_SAS.Size = new System.Drawing.Size(89, 72);
            this.buttonInfo_SAS.TabIndex = 3;
            this.buttonInfo_SAS.Text = "Справка";
            this.buttonInfo_SAS.UseVisualStyleBackColor = false;
            this.buttonInfo_SAS.Click += new System.EventHandler(this.buttonInfo_SAS_Click);
            // 
            // buttonDone_SAS
            // 
            this.buttonDone_SAS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAS.Location = new System.Drawing.Point(496, 319);
            this.buttonDone_SAS.Name = "buttonDone_SAS";
            this.buttonDone_SAS.Size = new System.Drawing.Size(145, 72);
            this.buttonDone_SAS.TabIndex = 4;
            this.buttonDone_SAS.Text = "Выполнить";
            this.buttonDone_SAS.UseVisualStyleBackColor = false;
            this.buttonDone_SAS.Click += new System.EventHandler(this.buttonDone_SAS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 420);
            this.Controls.Add(this.buttonDone_SAS);
            this.Controls.Add(this.buttonInfo_SAS);
            this.Controls.Add(this.groupBoxOutPut_SAS);
            this.Controls.Add(this.groupBoxInPut_SAS);
            this.Controls.Add(this.groupBoxCondition_SAS);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 1 | Шпилевая А. С.";
            this.groupBoxCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.PerformLayout();
            this.groupBoxInPut_SAS.ResumeLayout(false);
            this.groupBoxInPut_SAS.PerformLayout();
            this.groupBoxOutPut_SAS.ResumeLayout(false);
            this.groupBoxOutPut_SAS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAS;
        private System.Windows.Forms.TextBox textBoxCondition_SAS;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAS;
        private System.Windows.Forms.TextBox textBoxStopValue_SAS;
        private System.Windows.Forms.TextBox textBoxStartValue_SAS;
        private System.Windows.Forms.Label labelStopValue_SAS;
        private System.Windows.Forms.Label labelStartValue_SAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAS;
        private System.Windows.Forms.TextBox textBoxResult_SAS;
        private System.Windows.Forms.Label labelResult_SAS;
        private System.Windows.Forms.Button buttonInfo_SAS;
        private System.Windows.Forms.Button buttonDone_SAS;
    }
}

