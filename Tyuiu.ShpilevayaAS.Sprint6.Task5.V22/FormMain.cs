using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShpilevayaAS.Sprint6.Task5.V22.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint6\Tyuiu.ShpilevayaAS.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";


        private void buttonDone_SAS_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_SAS.ColumnCount = 2;
            dataGridViewOutPut_SAS.Columns[0].Width = 20;
            dataGridViewOutPut_SAS.Columns[1].Width = 50;

            this.chartDiag_SAS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SAS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_SAS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_SAS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SAS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonHelp_SAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-1 Шпилевая Арина Станиславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_SAS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
