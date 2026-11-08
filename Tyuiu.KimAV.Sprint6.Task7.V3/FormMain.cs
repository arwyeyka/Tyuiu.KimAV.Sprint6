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
using Tyuiu.KimAV.Sprint6.Task7.V3.Lib;
namespace Tyuiu.KimAV.Sprint6.Task7.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonHelpClick(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFileClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut.RowCount = rows;
            dataGridViewInPut.ColumnCount = columns;
            dataGridViewOutPut.RowCount = rows;
            dataGridViewOutPut.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut.Columns[i].Width = 50;
                dataGridViewOutPut.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonDoneClick(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSaveClick(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "OutPutFileTask7V3.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut.RowCount;
            int columns = dataGridViewOutPut.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutPut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut.Rows[i].Cells[j].Value;
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }
    }
}