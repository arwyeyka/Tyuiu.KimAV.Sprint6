namespace Tyuiu.KimAV.Sprint6.Task1.V14
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxVvod = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxInPutX = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxInPutY = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.textBoxVvod2 = new System.Windows.Forms.TextBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.Location = new System.Drawing.Point(32, 31);
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.Size = new System.Drawing.Size(125, 20);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.Text = "Условие";
            this.textBoxUslovie.TextChanged += new System.EventHandler(this.textBoxUslovie_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 107);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Протабулировать функцию на заданном диапозоне \r\nРезультат вывести в виде таблицы " +
    "\r\n\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxVvod
            // 
            this.textBoxVvod.Location = new System.Drawing.Point(32, 366);
            this.textBoxVvod.Name = "textBoxVvod";
            this.textBoxVvod.Size = new System.Drawing.Size(100, 20);
            this.textBoxVvod.TabIndex = 2;
            this.textBoxVvod.Text = "Ввод данных:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(32, 392);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 3;
            this.textBoxStart.Text = "Старт шага:";
            // 
            // textBoxInPutX
            // 
            this.textBoxInPutX.Location = new System.Drawing.Point(32, 418);
            this.textBoxInPutX.Name = "textBoxInPutX";
            this.textBoxInPutX.Size = new System.Drawing.Size(100, 20);
            this.textBoxInPutX.TabIndex = 4;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(138, 392);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 5;
            this.textBoxEnd.Text = "Конец шага:";
            // 
            // textBoxInPutY
            // 
            this.textBoxInPutY.Location = new System.Drawing.Point(138, 418);
            this.textBoxInPutY.Name = "textBoxInPutY";
            this.textBoxInPutY.Size = new System.Drawing.Size(100, 20);
            this.textBoxInPutY.TabIndex = 6;
            this.textBoxInPutY.TextChanged += new System.EventHandler(this.textBoxInPutY_TextChanged);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Lime;
            this.buttonDone.Location = new System.Drawing.Point(333, 358);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(118, 80);
            this.buttonDone.TabIndex = 7;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonResultClick);
            // 
            // textBoxVvod2
            // 
            this.textBoxVvod2.Location = new System.Drawing.Point(493, 44);
            this.textBoxVvod2.Name = "textBoxVvod2";
            this.textBoxVvod2.Size = new System.Drawing.Size(100, 20);
            this.textBoxVvod2.TabIndex = 8;
            this.textBoxVvod2.Text = "Ввод данных:";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(493, 70);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(96, 20);
            this.textBoxRes.TabIndex = 9;
            this.textBoxRes.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(493, 96);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(295, 342);
            this.textBoxResult.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.textBoxVvod2);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxInPutY);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxInPutX);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.textBoxVvod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxUslovie);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 14 | Ким А.В.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxVvod;
        private System.Windows.Forms.TextBox textBoxStart;
        public System.Windows.Forms.TextBox textBoxInPutX;
        private System.Windows.Forms.TextBox textBoxEnd;
        public System.Windows.Forms.TextBox textBoxInPutY;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBoxVvod2;
        private System.Windows.Forms.TextBox textBoxRes;
        public System.Windows.Forms.TextBox textBoxResult;
    }
}

