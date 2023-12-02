using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShpilevayaAS.Sprint6.Task1.V1.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_SAS.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_SAS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_SAS.Text = "";
                textBoxResult_SAS.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult_SAS.AppendText("|    X     +    f(x)   |" + Environment.NewLine);
                textBoxResult_SAS.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len -1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_SAS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_SAS.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-23-1 Шпилевая Арина Станиславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
