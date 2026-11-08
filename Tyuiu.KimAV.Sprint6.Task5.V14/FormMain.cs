using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KimAV.Sprint6.Task5.V14.Lib;
namespace Tyuiu.KimAV.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V14.txt";

        private void buttonDoneClick(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.chartResult.ChartAreas[0].AxisX.Title = "Îñü Õ";
            this.chartResult.ChartAreas[0].AxisY.Title = "Îñü Y";

            chartResult.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonHelpClick(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 5 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏÁ-25-1 Äàíèëîâ Àëåêñàíäð Ñåðãååâè÷", "Ñïðàâêà");
        }

        private void buttonOpenFileClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
