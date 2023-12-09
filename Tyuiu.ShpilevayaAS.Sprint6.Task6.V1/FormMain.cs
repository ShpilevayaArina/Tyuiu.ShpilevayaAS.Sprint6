using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShpilevayaAS.Sprint6.Task6.V1.Lib;
using System.IO;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task6.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_SAS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAS.ShowDialog();
            openFilePath = openFileDialogTask_SAS.FileName;
            textBoxInPut_SAS.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_SAS.Text = groupBoxInPut_SAS.Text + " " + openFileDialogTask_SAS.FileName;
            buttonDone_SAS.Enabled = true;
        }

        private void buttonDone_SAS_Click(object sender, EventArgs e)
        {
            textBoxOutPut_SAS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SAS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void textBoxOutPut_SAS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
