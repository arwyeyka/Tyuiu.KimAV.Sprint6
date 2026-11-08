using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KimAV.Sprint6.Task6.V6.Lib;
namespace Tyuiu.KimAV.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonHelpClick(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFileClick(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInPut.Text = File.ReadAllText(openFilePath);
            groupBoxInPut.Text = groupBoxInPut.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {
            textBoxOutPut.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}

