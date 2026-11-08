using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KimAV.Sprint6.Task0.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone = new System.Windows.Forms.Button();
            this.textBoxZagolovok = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxUSLOV = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxVivod = new System.Windows.Forms.TextBox();
            this.textBoxVVOd = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxInPutX = new System.Windows.Forms.TextBox();
            this.textBoxInPutY = new System.Windows.Forms.TextBox();
            this.textBoxResultShow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(426, 356);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(184, 57);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Расчитать";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // textBoxZagolovok
            // 
            this.textBoxZagolovok.BackColor = System.Drawing.Color.White;
            this.textBoxZagolovok.Location = new System.Drawing.Point(52, 54);
            this.textBoxZagolovok.Name = "textBoxZagolovok";
            this.textBoxZagolovok.Size = new System.Drawing.Size(178, 20);
            this.textBoxZagolovok.TabIndex = 2;
            this.textBoxZagolovok.Text = "Условия";
            this.textBoxZagolovok.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(426, 54);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(184, 83);
            this.pictureBoxFormula.TabIndex = 3;
            this.pictureBoxFormula.TabStop = false;
            // 
            // textBoxUSLOV
            // 
            this.textBoxUSLOV.Location = new System.Drawing.Point(52, 91);
            this.textBoxUSLOV.Multiline = true;
            this.textBoxUSLOV.Name = "textBoxUSLOV";
            this.textBoxUSLOV.Size = new System.Drawing.Size(224, 90);
            this.textBoxUSLOV.TabIndex = 4;
            this.textBoxUSLOV.Text = "Вычислить выражение по формуле ";
            this.textBoxUSLOV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(386, 261);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(224, 19);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.Text = "Результат";
            // 
            // textBoxVivod
            // 
            this.textBoxVivod.Location = new System.Drawing.Point(386, 236);
            this.textBoxVivod.Multiline = true;
            this.textBoxVivod.Name = "textBoxVivod";
            this.textBoxVivod.Size = new System.Drawing.Size(224, 19);
            this.textBoxVivod.TabIndex = 6;
            this.textBoxVivod.Text = "Вывод данных:";
            // 
            // textBoxVVOd
            // 
            this.textBoxVVOd.Location = new System.Drawing.Point(52, 236);
            this.textBoxVVOd.Multiline = true;
            this.textBoxVVOd.Name = "textBoxVVOd";
            this.textBoxVVOd.Size = new System.Drawing.Size(224, 19);
            this.textBoxVVOd.TabIndex = 7;
            this.textBoxVVOd.Text = "Ввод данных:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(193, 261);
            this.textBoxY.Multiline = true;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(154, 19);
            this.textBoxY.TabIndex = 8;
            this.textBoxY.Text = "Введите пременную Y:";
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(52, 261);
            this.textBoxX.Multiline = true;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(135, 19);
            this.textBoxX.TabIndex = 9;
            this.textBoxX.Text = "Введите переменную X:";
            // 
            // textBoxInPutX
            // 
            this.textBoxInPutX.Location = new System.Drawing.Point(52, 286);
            this.textBoxInPutX.Multiline = true;
            this.textBoxInPutX.Name = "textBoxInPutX";
            this.textBoxInPutX.Size = new System.Drawing.Size(135, 43);
            this.textBoxInPutX.TabIndex = 10;
            this.textBoxInPutX.Click += new System.EventHandler(this.textBoxInPutXKeyPress);
            // 
            // textBoxInPutY
            // 
            this.textBoxInPutY.Location = new System.Drawing.Point(193, 286);
            this.textBoxInPutY.Multiline = true;
            this.textBoxInPutY.Name = "textBoxInPutY";
            this.textBoxInPutY.Size = new System.Drawing.Size(154, 43);
            this.textBoxInPutY.TabIndex = 11;
            this.textBoxInPutY.Click += new System.EventHandler(this.textBoxInPutXKeyPress);
            // 
            // textBoxResultShow
            // 
            this.textBoxResultShow.Location = new System.Drawing.Point(386, 286);
            this.textBoxResultShow.Multiline = true;
            this.textBoxResultShow.Name = "textBoxResultShow";
            this.textBoxResultShow.Size = new System.Drawing.Size(224, 43);
            this.textBoxResultShow.TabIndex = 12;
            this.textBoxResultShow.Click += new System.EventHandler(this.textBoxInPutXKeyPress);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 447);
            this.Controls.Add(this.textBoxResultShow);
            this.Controls.Add(this.textBoxInPutY);
            this.Controls.Add(this.textBoxInPutX);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxVVOd);
            this.Controls.Add(this.textBoxVivod);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxUSLOV);
            this.Controls.Add(this.pictureBoxFormula);
            this.Controls.Add(this.textBoxZagolovok);
            this.Controls.Add(this.buttonDone);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 0 | Ким А.В";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button buttonDone;
        private TextBox textBoxZagolovok;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxUSLOV;
        private TextBox textBoxResult;
        private TextBox textBoxVivod;
        private TextBox textBoxVVOd;
        private TextBox textBoxY;
        private TextBox textBoxX;
        public TextBox textBoxInPutX;
        public TextBox textBoxInPutY;
        public TextBox textBoxResultShow;
    }
}

