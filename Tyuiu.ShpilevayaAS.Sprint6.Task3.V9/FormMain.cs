using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShpilevayaAS.Sprint6.Task3.V9.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrx = new int[5,5]{ { -14, 25, 26, 18, 17 },
                                    { 28, 10, 6, -2, 4 },
                                    { 30, 25, -3, 11, -10 },
                                    { 11, 32, -5, -20, 25 },
                                    { 2, -18, 11, 8, -20 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrx.GetUpperBound(0) + 1;
            int columns = matrx.Length / rows;

            dataGridViewMatrix_SAS.ColumnCount = columns;
            dataGridViewMatrix_SAS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SAS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SAS.Rows[i].Cells[j].Value = Convert.ToString(matrx[i, j]);
                }
            }

        }

        private void buttonHelp_SAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-1 Шпилевая Арина Станиславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SAS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] matrx = new int[5, 5]{ { -14, 25, 26, 18, 17 },
                                    { 28, 10, 6, -2, 4 },
                                    { 30, 25, -3, 11, -10 },
                                    { 11, 32, -5, -20, 25 },
                                    { 2, -18, 11, 8, -20 } };
            int[,] mtrx = ds.Calculate(matrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_SAS.ColumnCount = columns;
            dataGridViewResult_SAS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_SAS.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SAS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        
    }
}
