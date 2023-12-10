
namespace Tyuiu.ShpilevayaAS.Sprint6.Task7.V2
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
            this.buttonClose_SAS = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SAS = new System.Windows.Forms.PictureBox();
            this.labelInfo_SAS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose_SAS
            // 
            this.buttonClose_SAS.Location = new System.Drawing.Point(462, 187);
            this.buttonClose_SAS.Name = "buttonClose_SAS";
            this.buttonClose_SAS.Size = new System.Drawing.Size(111, 23);
            this.buttonClose_SAS.TabIndex = 5;
            this.buttonClose_SAS.Text = "Ок";
            this.buttonClose_SAS.UseVisualStyleBackColor = true;
            this.buttonClose_SAS.Click += new System.EventHandler(this.buttonClose_SAS_Click);
            // 
            // pictureBoxAvatar_SAS
            // 
            this.pictureBoxAvatar_SAS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SAS.Image")));
            this.pictureBoxAvatar_SAS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SAS.Name = "pictureBoxAvatar_SAS";
            this.pictureBoxAvatar_SAS.Size = new System.Drawing.Size(189, 198);
            this.pictureBoxAvatar_SAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_SAS.TabIndex = 4;
            this.pictureBoxAvatar_SAS.TabStop = false;
            // 
            // labelInfo_SAS
            // 
            this.labelInfo_SAS.AutoSize = true;
            this.labelInfo_SAS.Location = new System.Drawing.Point(207, 12);
            this.labelInfo_SAS.Name = "labelInfo_SAS";
            this.labelInfo_SAS.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_SAS.TabIndex = 3;
            this.labelInfo_SAS.Text = resources.GetString("labelInfo_SAS.Text");
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

        private System.Windows.Forms.Button buttonClose_SAS;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SAS;
        private System.Windows.Forms.Label labelInfo_SAS;
    }
}