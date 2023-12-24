using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BakhtiyarovDR.Sprint7.Project.V15.Lib;
namespace Tyuiu.BakhtiyarovDR.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_BDR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static string[,] arrayValues;
        string openFilePath;
        static int rows, colums;
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOut_BDR.ColumnCount = 7;
            dataGridViewOut_BDR.RowCount = 10;

            for (int i = 0; i < 7; i++)
            {
                dataGridViewOut_BDR.Columns[i].Width = 85;
                if(i >= 3)
                {
                    dataGridViewOut_BDR.Columns[i].Width = 105;
                }
            }
        }      

        private void buttonOpenFile_BDR_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_BDR.ShowDialog();
                openFilePath = openFileDialog_BDR.FileName;
                arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewOut_BDR.Rows.Clear();

                rows = arrayValues.GetUpperBound(0) + 1;
                colums = arrayValues.Length / rows;

                dataGridViewOut_BDR.ColumnCount = colums;
                dataGridViewOut_BDR.RowCount = rows;


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < colums; c++)
                    {
                        dataGridViewOut_BDR.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                dataGridViewOut_BDR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                buttonSaveFile_BDR.Enabled = true;
                buttonChange_BDR.Enabled = true;
                buttonReport_BDR.Enabled = true;
                buttonAdd_BDR.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_BDR_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogExcel_BDR.FileName = "FileTask7.csv";
                saveFileDialogExcel_BDR.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogExcel_BDR.ShowDialog();

                string path = saveFileDialogExcel_BDR.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewOut_BDR.RowCount;
                int columns = dataGridViewOut_BDR.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewOut_BDR.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut_BDR.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.Default);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChange_BDR_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridViewOut_BDR.ColumnCount - 1; i++)
            {
                dataGridViewOut_BDR.Columns[i].ReadOnly = false;
            }
        }

        private void buttonHelp_BDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAdd_BDR_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOut_BDR.RowCount += 1;
                string[] a = {dataGridViewOut_BDR.Rows[rows].Cells[0].Value.ToString(),
                              dataGridViewOut_BDR.Rows[rows].Cells[1].Value.ToString(),
                              dataGridViewOut_BDR.Rows[rows].Cells[2].Value.ToString(),
                              dataGridViewOut_BDR.Rows[rows].Cells[3].Value.ToString(),
                              dataGridViewOut_BDR.Rows[rows].Cells[4].Value.ToString(),
                              dataGridViewOut_BDR.Rows[rows].Cells[5].Value.ToString(),
                              dataGridViewOut_BDR.Rows[rows].Cells[6].Value.ToString() };
                dataGridViewOut_BDR.Rows[rows].Cells[0].Value = rows + 1;
                dataGridViewOut_BDR.Rows[rows].Cells[1].Value = textBoxAddName_BDR.Text;
                dataGridViewOut_BDR.Rows[rows].Cells[2].Value = textBoxAddAdress_BDR.Text;
                dataGridViewOut_BDR.Rows[rows].Cells[3].Value = textBoxAddPhon_BDR.Text;
                dataGridViewOut_BDR.Rows[rows].Cells[4].Value = textBoxAddStatus_BDR.Text;
                dataGridViewOut_BDR.Rows[rows].Cells[5].Value = textBoxAddSalary_BDR.Text;
                dataGridViewOut_BDR.Rows[rows].Cells[6].Value = textBoxAddSrok_BDR.Text;
                for (int i = 0; i < colums; i++)
                {
                    dataGridViewOut_BDR.Rows[rows - 1].Cells[i].Value = a[i];
                }
                rows++;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxIn_BDR_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewOut_BDR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonReport_BDR_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

       
    }
}
