
namespace Tyuiu.ShpilevayaAS.Sprint6.Task7.V2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_SAS = new System.Windows.Forms.Panel();
            this.buttonOpenFile_SAS = new System.Windows.Forms.Button();
            this.buttonDone_SAS = new System.Windows.Forms.Button();
            this.buttonSaveFile_SAS = new System.Windows.Forms.Button();
            this.buttonHelp_SAS = new System.Windows.Forms.Button();
            this.panelCondition_SAS = new System.Windows.Forms.Panel();
            this.groupBoxCondition_SAS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SAS = new System.Windows.Forms.TextBox();
            this.panelInPut_SAS = new System.Windows.Forms.Panel();
            this.splitterInPut_SAS = new System.Windows.Forms.Splitter();
            this.groupBoxInPut_SAS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_SAS = new System.Windows.Forms.DataGridView();
            this.panelOutPut_SAS = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SAS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_SAS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_SAS = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_SAS = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SAS = new System.Windows.Forms.SaveFileDialog();
            this.splitterOutPut_SAS = new System.Windows.Forms.Splitter();
            this.panelButtons_SAS.SuspendLayout();
            this.panelCondition_SAS.SuspendLayout();
            this.groupBoxCondition_SAS.SuspendLayout();
            this.panelInPut_SAS.SuspendLayout();
            this.groupBoxInPut_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SAS)).BeginInit();
            this.panelOutPut_SAS.SuspendLayout();
            this.groupBoxOutPut_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_SAS
            // 
            this.panelButtons_SAS.Controls.Add(this.buttonHelp_SAS);
            this.panelButtons_SAS.Controls.Add(this.buttonSaveFile_SAS);
            this.panelButtons_SAS.Controls.Add(this.buttonDone_SAS);
            this.panelButtons_SAS.Controls.Add(this.buttonOpenFile_SAS);
            this.panelButtons_SAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_SAS.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_SAS.Name = "panelButtons_SAS";
            this.panelButtons_SAS.Size = new System.Drawing.Size(1175, 88);
            this.panelButtons_SAS.TabIndex = 0;
            // 
            // buttonOpenFile_SAS
            // 
            this.buttonOpenFile_SAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SAS.Image")));
            this.buttonOpenFile_SAS.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_SAS.Name = "buttonOpenFile_SAS";
            this.buttonOpenFile_SAS.Size = new System.Drawing.Size(90, 72);
            this.buttonOpenFile_SAS.TabIndex = 0;
            this.toolTipButton_SAS.SetToolTip(this.buttonOpenFile_SAS, "Выберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SAS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SAS.Click += new System.EventHandler(this.buttonOpenFile_SAS_Click);
            this.buttonOpenFile_SAS.MouseEnter += new System.EventHandler(this.buttonOpenFile_SAS_MouseEnter);
            // 
            // buttonDone_SAS
            // 
            this.buttonDone_SAS.Enabled = false;
            this.buttonDone_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SAS.Image")));
            this.buttonDone_SAS.Location = new System.Drawing.Point(109, 13);
            this.buttonDone_SAS.Name = "buttonDone_SAS";
            this.buttonDone_SAS.Size = new System.Drawing.Size(90, 72);
            this.buttonDone_SAS.TabIndex = 0;
            this.toolTipButton_SAS.SetToolTip(this.buttonDone_SAS, "Меняет во второй строке четные числа на 555\r\n");
            this.buttonDone_SAS.UseVisualStyleBackColor = true;
            this.buttonDone_SAS.Click += new System.EventHandler(this.buttonDone_SAS_Click);
            this.buttonDone_SAS.MouseEnter += new System.EventHandler(this.buttonDone_SAS_MouseEnter);
            // 
            // buttonSaveFile_SAS
            // 
            this.buttonSaveFile_SAS.Enabled = false;
            this.buttonSaveFile_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_SAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_SAS.Image")));
            this.buttonSaveFile_SAS.Location = new System.Drawing.Point(205, 13);
            this.buttonSaveFile_SAS.Name = "buttonSaveFile_SAS";
            this.buttonSaveFile_SAS.Size = new System.Drawing.Size(90, 72);
            this.buttonSaveFile_SAS.TabIndex = 0;
            this.toolTipButton_SAS.SetToolTip(this.buttonSaveFile_SAS, "Сохранит результат в файле OutPutFileTask7.csv\r\n\r\n");
            this.buttonSaveFile_SAS.UseVisualStyleBackColor = true;
            this.buttonSaveFile_SAS.Click += new System.EventHandler(this.buttonSaveFile_SAS_Click);
            this.buttonSaveFile_SAS.MouseEnter += new System.EventHandler(this.buttonSaveFile_SAS_MouseEnter);
            // 
            // buttonHelp_SAS
            // 
            this.buttonHelp_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAS.Image")));
            this.buttonHelp_SAS.Location = new System.Drawing.Point(1082, 13);
            this.buttonHelp_SAS.Name = "buttonHelp_SAS";
            this.buttonHelp_SAS.Size = new System.Drawing.Size(90, 72);
            this.buttonHelp_SAS.TabIndex = 0;
            this.toolTipButton_SAS.SetToolTip(this.buttonHelp_SAS, "Сведение о программе\r\n");
            this.buttonHelp_SAS.UseVisualStyleBackColor = true;
            this.buttonHelp_SAS.Click += new System.EventHandler(this.buttonHelp_SAS_Click);
            this.buttonHelp_SAS.MouseEnter += new System.EventHandler(this.buttonHelp_SAS_MouseEnter);
            // 
            // panelCondition_SAS
            // 
            this.panelCondition_SAS.Controls.Add(this.groupBoxCondition_SAS);
            this.panelCondition_SAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_SAS.Location = new System.Drawing.Point(0, 88);
            this.panelCondition_SAS.Name = "panelCondition_SAS";
            this.panelCondition_SAS.Size = new System.Drawing.Size(1175, 92);
            this.panelCondition_SAS.TabIndex = 1;
            // 
            // groupBoxCondition_SAS
            // 
            this.groupBoxCondition_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCondition_SAS.Controls.Add(this.textBoxCondition_SAS);
            this.groupBoxCondition_SAS.Location = new System.Drawing.Point(13, 7);
            this.groupBoxCondition_SAS.Name = "groupBoxCondition_SAS";
            this.groupBoxCondition_SAS.Size = new System.Drawing.Size(1150, 82);
            this.groupBoxCondition_SAS.TabIndex = 0;
            this.groupBoxCondition_SAS.TabStop = false;
            this.groupBoxCondition_SAS.Text = "Условие:";
            // 
            // textBoxCondition_SAS
            // 
            this.textBoxCondition_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCondition_SAS.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_SAS.Multiline = true;
            this.textBoxCondition_SAS.Name = "textBoxCondition_SAS";
            this.textBoxCondition_SAS.ReadOnly = true;
            this.textBoxCondition_SAS.Size = new System.Drawing.Size(1137, 60);
            this.textBoxCondition_SAS.TabIndex = 0;
            this.textBoxCondition_SAS.Text = resources.GetString("textBoxCondition_SAS.Text");
            // 
            // panelInPut_SAS
            // 
            this.panelInPut_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInPut_SAS.Controls.Add(this.groupBoxInPut_SAS);
            this.panelInPut_SAS.Controls.Add(this.splitterInPut_SAS);
            this.panelInPut_SAS.Location = new System.Drawing.Point(0, 187);
            this.panelInPut_SAS.Name = "panelInPut_SAS";
            this.panelInPut_SAS.Size = new System.Drawing.Size(580, 350);
            this.panelInPut_SAS.TabIndex = 2;
            // 
            // splitterInPut_SAS
            // 
            this.splitterInPut_SAS.Location = new System.Drawing.Point(0, 0);
            this.splitterInPut_SAS.Name = "splitterInPut_SAS";
            this.splitterInPut_SAS.Size = new System.Drawing.Size(3, 350);
            this.splitterInPut_SAS.TabIndex = 0;
            this.splitterInPut_SAS.TabStop = false;
            // 
            // groupBoxInPut_SAS
            // 
            this.groupBoxInPut_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInPut_SAS.Controls.Add(this.dataGridViewInPut_SAS);
            this.groupBoxInPut_SAS.Location = new System.Drawing.Point(20, 7);
            this.groupBoxInPut_SAS.Name = "groupBoxInPut_SAS";
            this.groupBoxInPut_SAS.Size = new System.Drawing.Size(557, 340);
            this.groupBoxInPut_SAS.TabIndex = 1;
            this.groupBoxInPut_SAS.TabStop = false;
            this.groupBoxInPut_SAS.Text = "Ввод:";
            // 
            // dataGridViewInPut_SAS
            // 
            this.dataGridViewInPut_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInPut_SAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_SAS.ColumnHeadersVisible = false;
            this.dataGridViewInPut_SAS.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewInPut_SAS.Name = "dataGridViewInPut_SAS";
            this.dataGridViewInPut_SAS.ReadOnly = true;
            this.dataGridViewInPut_SAS.RowHeadersVisible = false;
            this.dataGridViewInPut_SAS.RowHeadersWidth = 51;
            this.dataGridViewInPut_SAS.RowTemplate.Height = 24;
            this.dataGridViewInPut_SAS.Size = new System.Drawing.Size(550, 318);
            this.dataGridViewInPut_SAS.TabIndex = 0;
            // 
            // panelOutPut_SAS
            // 
            this.panelOutPut_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutPut_SAS.Controls.Add(this.splitterOutPut_SAS);
            this.panelOutPut_SAS.Controls.Add(this.groupBoxOutPut_SAS);
            this.panelOutPut_SAS.Location = new System.Drawing.Point(583, 184);
            this.panelOutPut_SAS.Name = "panelOutPut_SAS";
            this.panelOutPut_SAS.Size = new System.Drawing.Size(592, 364);
            this.panelOutPut_SAS.TabIndex = 3;
            // 
            // groupBoxOutPut_SAS
            // 
            this.groupBoxOutPut_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_SAS.Controls.Add(this.dataGridViewOutPut_SAS);
            this.groupBoxOutPut_SAS.Location = new System.Drawing.Point(4, 7);
            this.groupBoxOutPut_SAS.Name = "groupBoxOutPut_SAS";
            this.groupBoxOutPut_SAS.Size = new System.Drawing.Size(588, 354);
            this.groupBoxOutPut_SAS.TabIndex = 0;
            this.groupBoxOutPut_SAS.TabStop = false;
            this.groupBoxOutPut_SAS.Text = "Вывод:";
            // 
            // dataGridViewOutPut_SAS
            // 
            this.dataGridViewOutPut_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutPut_SAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SAS.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_SAS.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewOutPut_SAS.Name = "dataGridViewOutPut_SAS";
            this.dataGridViewOutPut_SAS.ReadOnly = true;
            this.dataGridViewOutPut_SAS.RowHeadersVisible = false;
            this.dataGridViewOutPut_SAS.RowHeadersWidth = 51;
            this.dataGridViewOutPut_SAS.RowTemplate.Height = 24;
            this.dataGridViewOutPut_SAS.Size = new System.Drawing.Size(581, 321);
            this.dataGridViewOutPut_SAS.TabIndex = 0;
            // 
            // openFileDialogTask_SAS
            // 
            this.openFileDialogTask_SAS.FileName = "openFileDialogTask_SAS";
            // 
            // toolTipButton_SAS
            // 
            this.toolTipButton_SAS.IsBalloon = true;
            this.toolTipButton_SAS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SAS.ToolTipTitle = "Подсказка";
            // 
            // splitterOutPut_SAS
            // 
            this.splitterOutPut_SAS.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPut_SAS.Name = "splitterOutPut_SAS";
            this.splitterOutPut_SAS.Size = new System.Drawing.Size(3, 364);
            this.splitterOutPut_SAS.TabIndex = 1;
            this.splitterOutPut_SAS.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 539);
            this.Controls.Add(this.panelOutPut_SAS);
            this.Controls.Add(this.panelInPut_SAS);
            this.Controls.Add(this.panelCondition_SAS);
            this.Controls.Add(this.panelButtons_SAS);
            this.MinimumSize = new System.Drawing.Size(1193, 586);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 2 | Шпилевая А. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_SAS.ResumeLayout(false);
            this.panelCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.ResumeLayout(false);
            this.groupBoxCondition_SAS.PerformLayout();
            this.panelInPut_SAS.ResumeLayout(false);
            this.groupBoxInPut_SAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SAS)).EndInit();
            this.panelOutPut_SAS.ResumeLayout(false);
            this.groupBoxOutPut_SAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SAS;
        private System.Windows.Forms.Button buttonOpenFile_SAS;
        private System.Windows.Forms.Button buttonHelp_SAS;
        private System.Windows.Forms.Button buttonSaveFile_SAS;
        private System.Windows.Forms.Button buttonDone_SAS;
        private System.Windows.Forms.Panel panelCondition_SAS;
        private System.Windows.Forms.GroupBox groupBoxCondition_SAS;
        private System.Windows.Forms.TextBox textBoxCondition_SAS;
        private System.Windows.Forms.Panel panelInPut_SAS;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAS;
        private System.Windows.Forms.DataGridView dataGridViewInPut_SAS;
        private System.Windows.Forms.Splitter splitterInPut_SAS;
        private System.Windows.Forms.Panel panelOutPut_SAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAS;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SAS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SAS;
        private System.Windows.Forms.ToolTip toolTipButton_SAS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SAS;
        private System.Windows.Forms.Splitter splitterOutPut_SAS;
    }
}

