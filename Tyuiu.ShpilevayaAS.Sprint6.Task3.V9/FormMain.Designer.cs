
namespace Tyuiu.ShpilevayaAS.Sprint6.Task3.V9
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
            this.dataGridViewMatrix_SAS = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut_SAS = new System.Windows.Forms.GroupBox();
            this.buttonDone_SAS = new System.Windows.Forms.Button();
            this.buttonHelp_SAS = new System.Windows.Forms.Button();
            this.labelResult_SAS = new System.Windows.Forms.Label();
            this.dataGridViewResult_SAS = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAS)).BeginInit();
            this.groupBoxOutPut_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAS
            // 
            this.groupBoxCondition_SAS.Controls.Add(this.dataGridViewMatrix_SAS);
            this.groupBoxCondition_SAS.Controls.Add(this.textBoxCondition_SAS);
            this.groupBoxCondition_SAS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_SAS.Name = "groupBoxCondition_SAS";
            this.groupBoxCondition_SAS.Size = new System.Drawing.Size(814, 425);
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
            this.textBoxCondition_SAS.Size = new System.Drawing.Size(436, 397);
            this.textBoxCondition_SAS.TabIndex = 0;
            this.textBoxCondition_SAS.Text = "Дана матрица 5 на 5\r\n-14   25  26  18  17\r\n 28   10    6   -2   4\r\n 30   25  -3  " +
    " 11   -10\r\n 11   32  -5   -20  25\r\n  2  -18   11   8    -20\r\nвыполнить сортировк" +
    "у по возрастанию в пятом столбце";
            // 
            // dataGridViewMatrix_SAS
            // 
            this.dataGridViewMatrix_SAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SAS.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SAS.Location = new System.Drawing.Point(450, 22);
            this.dataGridViewMatrix_SAS.Name = "dataGridViewMatrix_SAS";
            this.dataGridViewMatrix_SAS.RowHeadersVisible = false;
            this.dataGridViewMatrix_SAS.RowHeadersWidth = 51;
            this.dataGridViewMatrix_SAS.RowTemplate.Height = 24;
            this.dataGridViewMatrix_SAS.Size = new System.Drawing.Size(345, 265);
            this.dataGridViewMatrix_SAS.TabIndex = 1;
            // 
            // groupBoxOutPut_SAS
            // 
            this.groupBoxOutPut_SAS.Controls.Add(this.dataGridViewResult_SAS);
            this.groupBoxOutPut_SAS.Controls.Add(this.labelResult_SAS);
            this.groupBoxOutPut_SAS.Location = new System.Drawing.Point(833, 13);
            this.groupBoxOutPut_SAS.Name = "groupBoxOutPut_SAS";
            this.groupBoxOutPut_SAS.Size = new System.Drawing.Size(251, 323);
            this.groupBoxOutPut_SAS.TabIndex = 1;
            this.groupBoxOutPut_SAS.TabStop = false;
            this.groupBoxOutPut_SAS.Text = "Вывод данных";
            // 
            // buttonDone_SAS
            // 
            this.buttonDone_SAS.Location = new System.Drawing.Point(983, 411);
            this.buttonDone_SAS.Name = "buttonDone_SAS";
            this.buttonDone_SAS.Size = new System.Drawing.Size(101, 27);
            this.buttonDone_SAS.TabIndex = 2;
            this.buttonDone_SAS.Text = "Выполнить";
            this.buttonDone_SAS.UseVisualStyleBackColor = true;
            this.buttonDone_SAS.Click += new System.EventHandler(this.buttonDone_SAS_Click);
            // 
            // buttonHelp_SAS
            // 
            this.buttonHelp_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAS.Location = new System.Drawing.Point(932, 411);
            this.buttonHelp_SAS.Name = "buttonHelp_SAS";
            this.buttonHelp_SAS.Size = new System.Drawing.Size(32, 27);
            this.buttonHelp_SAS.TabIndex = 3;
            this.buttonHelp_SAS.Text = "?";
            this.buttonHelp_SAS.UseVisualStyleBackColor = true;
            this.buttonHelp_SAS.Click += new System.EventHandler(this.buttonHelp_SAS_Click);
            // 
            // labelResult_SAS
            // 
            this.labelResult_SAS.AutoSize = true;
            this.labelResult_SAS.Location = new System.Drawing.Point(7, 22);
            this.labelResult_SAS.Name = "labelResult_SAS";
            this.labelResult_SAS.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SAS.TabIndex = 1;
            this.labelResult_SAS.Text = "Результат:";
            // 
            // dataGridViewResult_SAS
            // 
            this.dataGridViewResult_SAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAS.ColumnHeadersVisible = false;
            this.dataGridViewResult_SAS.Location = new System.Drawing.Point(10, 43);
            this.dataGridViewResult_SAS.Name = "dataGridViewResult_SAS";
            this.dataGridViewResult_SAS.ReadOnly = true;
            this.dataGridViewResult_SAS.RowHeadersVisible = false;
            this.dataGridViewResult_SAS.RowHeadersWidth = 51;
            this.dataGridViewResult_SAS.RowTemplate.Height = 24;
            this.dataGridViewResult_SAS.Size = new System.Drawing.Size(240, 244);
            this.dataGridViewResult_SAS.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.buttonHelp_SAS);
            this.Controls.Add(this.buttonDone_SAS);
            this.Controls.Add(this.groupBoxOutPut_SAS);
            this.Controls.Add(this.groupBoxCondition_SAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 9 | Шпилевая А. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAS)).EndInit();
            this.groupBoxOutPut_SAS.ResumeLayout(false);
            this.groupBoxOutPut_SAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAS;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SAS;
        private System.Windows.Forms.TextBox textBoxCondition_SAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAS;
        private System.Windows.Forms.Button buttonDone_SAS;
        private System.Windows.Forms.Button buttonHelp_SAS;
        private System.Windows.Forms.Label labelResult_SAS;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAS;
    }
}

