using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShpilevayaAS.Sprint6.Task2.V22.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task2.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonInfo_SAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-1 Шпилевая Арина Станиславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SAS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SAS.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_SAS.Titles.Add("График функции");

                this.chartFunction_SAS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAS.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SAS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_SAS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_SAS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SAS.BackColor = Color.Red;
        }

        private void buttonDone_SAS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SAS.BackColor = Color.Green;
        }

        private void buttonDone_SAS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SAS.BackColor = Color.Blue;
        }
    }
}
