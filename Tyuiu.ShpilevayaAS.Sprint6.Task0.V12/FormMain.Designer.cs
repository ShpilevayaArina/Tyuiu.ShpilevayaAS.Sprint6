
namespace Tyuiu.ShpilevayaAS.Sprint6.Task0.V12
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
            this.groupBoxCondition_SAS = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SAS = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SAS = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInPut_SAS = new System.Windows.Forms.GroupBox();
            this.labelVarX_SAS = new System.Windows.Forms.Label();
            this.textBoxVarX_SAS = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SAS = new System.Windows.Forms.GroupBox();
            this.labelResult_SAS = new System.Windows.Forms.Label();
            this.textBoxResult_SAS = new System.Windows.Forms.TextBox();
            this.buttonDone_SAS = new System.Windows.Forms.Button();
            this.buttonHelp_SAS = new System.Windows.Forms.Button();
            this.groupBoxCondition_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAS)).BeginInit();
            this.groupBoxInPut_SAS.SuspendLayout();
            this.groupBoxOutPut_SAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAS
            // 
            this.groupBoxCondition_SAS.Controls.Add(this.pictureBoxFormula_SAS);
            this.groupBoxCondition_SAS.Controls.Add(this.textBoxTask_SAS);
            this.groupBoxCondition_SAS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SAS.Name = "groupBoxCondition_SAS";
            this.groupBoxCondition_SAS.Size = new System.Drawing.Size(598, 188);
            this.groupBoxCondition_SAS.TabIndex = 0;
            this.groupBoxCondition_SAS.TabStop = false;
            this.groupBoxCondition_SAS.Text = "Условие";
            // 
            // pictureBoxFormula_SAS
            // 
            this.pictureBoxFormula_SAS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SAS.Image")));
            this.pictureBoxFormula_SAS.Location = new System.Drawing.Point(374, 22);
            this.pictureBoxFormula_SAS.Name = "pictureBoxFormula_SAS";
            this.pictureBoxFormula_SAS.Size = new System.Drawing.Size(218, 119);
            this.pictureBoxFormula_SAS.TabIndex = 1;
            this.pictureBoxFormula_SAS.TabStop = false;
            // 
            // textBoxTask_SAS
            // 
            this.textBoxTask_SAS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SAS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAS.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_SAS.Multiline = true;
            this.textBoxTask_SAS.Name = "textBoxTask_SAS";
            this.textBoxTask_SAS.ReadOnly = true;
            this.textBoxTask_SAS.Size = new System.Drawing.Size(374, 160);
            this.textBoxTask_SAS.TabIndex = 0;
            this.textBoxTask_SAS.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInPut_SAS
            // 
            this.groupBoxInPut_SAS.Controls.Add(this.labelVarX_SAS);
            this.groupBoxInPut_SAS.Controls.Add(this.textBoxVarX_SAS);
            this.groupBoxInPut_SAS.Location = new System.Drawing.Point(12, 207);
            this.groupBoxInPut_SAS.Name = "groupBoxInPut_SAS";
            this.groupBoxInPut_SAS.Size = new System.Drawing.Size(297, 124);
            this.groupBoxInPut_SAS.TabIndex = 1;
            this.groupBoxInPut_SAS.TabStop = false;
            this.groupBoxInPut_SAS.Text = "Ввод данных";
            // 
            // labelVarX_SAS
            // 
            this.labelVarX_SAS.AutoSize = true;
            this.labelVarX_SAS.Location = new System.Drawing.Point(17, 28);
            this.labelVarX_SAS.Name = "labelVarX_SAS";
            this.labelVarX_SAS.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_SAS.TabIndex = 1;
            this.labelVarX_SAS.Text = "Переменная X:";
            // 
            // textBoxVarX_SAS
            // 
            this.textBoxVarX_SAS.Location = new System.Drawing.Point(20, 61);
            this.textBoxVarX_SAS.Name = "textBoxVarX_SAS";
            this.textBoxVarX_SAS.Size = new System.Drawing.Size(105, 22);
            this.textBoxVarX_SAS.TabIndex = 0;
            this.textBoxVarX_SAS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_SAS_KeyPress);
            // 
            // groupBoxOutPut_SAS
            // 
            this.groupBoxOutPut_SAS.Controls.Add(this.labelResult_SAS);
            this.groupBoxOutPut_SAS.Controls.Add(this.textBoxResult_SAS);
            this.groupBoxOutPut_SAS.Location = new System.Drawing.Point(315, 207);
            this.groupBoxOutPut_SAS.Name = "groupBoxOutPut_SAS";
            this.groupBoxOutPut_SAS.Size = new System.Drawing.Size(297, 124);
            this.groupBoxOutPut_SAS.TabIndex = 2;
            this.groupBoxOutPut_SAS.TabStop = false;
            this.groupBoxOutPut_SAS.Text = "Вывод данных";
            // 
            // labelResult_SAS
            // 
            this.labelResult_SAS.AutoSize = true;
            this.labelResult_SAS.Location = new System.Drawing.Point(17, 28);
            this.labelResult_SAS.Name = "labelResult_SAS";
            this.labelResult_SAS.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SAS.TabIndex = 1;
            this.labelResult_SAS.Text = "Результат:";
            // 
            // textBoxResult_SAS
            // 
            this.textBoxResult_SAS.Location = new System.Drawing.Point(20, 61);
            this.textBoxResult_SAS.Name = "textBoxResult_SAS";
            this.textBoxResult_SAS.ReadOnly = true;
            this.textBoxResult_SAS.Size = new System.Drawing.Size(105, 22);
            this.textBoxResult_SAS.TabIndex = 0;
            // 
            // buttonDone_SAS
            // 
            this.buttonDone_SAS.Location = new System.Drawing.Point(501, 337);
            this.buttonDone_SAS.Name = "buttonDone_SAS";
            this.buttonDone_SAS.Size = new System.Drawing.Size(111, 37);
            this.buttonDone_SAS.TabIndex = 3;
            this.buttonDone_SAS.Text = "Выполнить";
            this.buttonDone_SAS.UseVisualStyleBackColor = true;
            this.buttonDone_SAS.Click += new System.EventHandler(this.buttonDone_SAS_Click);
            // 
            // buttonHelp_SAS
            // 
            this.buttonHelp_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAS.Location = new System.Drawing.Point(456, 337);
            this.buttonHelp_SAS.Name = "buttonHelp_SAS";
            this.buttonHelp_SAS.Size = new System.Drawing.Size(39, 37);
            this.buttonHelp_SAS.TabIndex = 4;
            this.buttonHelp_SAS.Text = "?";
            this.buttonHelp_SAS.UseVisualStyleBackColor = true;
            this.buttonHelp_SAS.Click += new System.EventHandler(this.buttonHelp_SAS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 386);
            this.Controls.Add(this.buttonHelp_SAS);
            this.Controls.Add(this.buttonDone_SAS);
            this.Controls.Add(this.groupBoxOutPut_SAS);
            this.Controls.Add(this.groupBoxInPut_SAS);
            this.Controls.Add(this.groupBoxCondition_SAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 12 | Шпилевая А. С.";
            this.groupBoxCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAS)).EndInit();
            this.groupBoxInPut_SAS.ResumeLayout(false);
            this.groupBoxInPut_SAS.PerformLayout();
            this.groupBoxOutPut_SAS.ResumeLayout(false);
            this.groupBoxOutPut_SAS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAS;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SAS;
        private System.Windows.Forms.TextBox textBoxTask_SAS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAS;
        private System.Windows.Forms.Label labelVarX_SAS;
        private System.Windows.Forms.TextBox textBoxVarX_SAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAS;
        private System.Windows.Forms.Label labelResult_SAS;
        private System.Windows.Forms.TextBox textBoxResult_SAS;
        private System.Windows.Forms.Button buttonDone_SAS;
        private System.Windows.Forms.Button buttonHelp_SAS;
    }
}

