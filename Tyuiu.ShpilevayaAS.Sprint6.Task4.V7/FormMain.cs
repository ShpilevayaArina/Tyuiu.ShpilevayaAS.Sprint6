using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShpilevayaAS.Sprint6.Task4.V7.Lib;
using System.IO;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task4.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        //private void buttonDone_SAS_Click(object sender, EventArgs e)
        //{
        //}

        //private void buttonInfo_SAS_Click(object sender, EventArgs e)
        //{ 
        //}

        //private void buttonSave_SAS_Click(object sender, EventArgs e)
        //{
        //}

        private void buttonDone_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStartStep_SAS.Text);
                int StopStep = Convert.ToInt32(textBoxStopStep_SAS.Text);

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartStep, StopStep);

                this.chartFunction_SAS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SAS.Text = "";

                chartFunction_SAS.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_SAS.Series[0].Points.AddXY(StartStep, valueArray[i]);
                    textBoxResult_SAS.AppendText(valueArray[i] + Environment.NewLine);
                    StartStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V7.txt";
                File.WriteAllText(path, textBoxResult_SAS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-1 Шпилевая Арина Станиславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-1 Шпилевая Арина Станиславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
    }
}
