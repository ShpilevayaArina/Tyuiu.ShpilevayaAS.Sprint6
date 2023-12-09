
namespace Tyuiu.ShpilevayaAS.Sprint6.Task6.V1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_SAS = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_SAS = new System.Windows.Forms.PictureBox();
            this.buttonClose_SAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_SAS
            // 
            this.labelInfo_SAS.AutoSize = true;
            this.labelInfo_SAS.Location = new System.Drawing.Point(207, 13);
            this.labelInfo_SAS.Name = "labelInfo_SAS";
            this.labelInfo_SAS.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_SAS.TabIndex = 0;
            this.labelInfo_SAS.Text = resources.GetString("labelInfo_SAS.Text");
            this.labelInfo_SAS.Click += new System.EventHandler(this.labelInfo_SAS_Click);
            // 
            // pictureBoxAvatar_SAS
            // 
            this.pictureBoxAvatar_SAS.Image = global::Tyuiu.ShpilevayaAS.Sprint6.Task6.V1.Properties.Resources.фото_портрет;
            this.pictureBoxAvatar_SAS.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxAvatar_SAS.Name = "pictureBoxAvatar_SAS";
            this.pictureBoxAvatar_SAS.Size = new System.Drawing.Size(189, 198);
            this.pictureBoxAvatar_SAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_SAS.TabIndex = 1;
            this.pictureBoxAvatar_SAS.TabStop = false;
            // 
            // buttonClose_SAS
            // 
            this.buttonClose_SAS.Location = new System.Drawing.Point(462, 188);
            this.buttonClose_SAS.Name = "buttonClose_SAS";
            this.buttonClose_SAS.Size = new System.Drawing.Size(111, 23);
            this.buttonClose_SAS.TabIndex = 2;
            this.buttonClose_SAS.Text = "Ок";
            this.buttonClose_SAS.UseVisualStyleBackColor = true;
            this.buttonClose_SAS.Click += new System.EventHandler(this.buttonClose_SAS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 223);
            this.Controls.Add(this.buttonClose_SAS);
            this.Controls.Add(this.pictureBoxAvatar_SAS);
            this.Controls.Add(this.labelInfo_SAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_SAS;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SAS;
        private System.Windows.Forms.Button buttonClose_SAS;
    }
}