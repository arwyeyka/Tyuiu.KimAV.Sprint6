namespace Tyuiu.KimAV.Sprint6.Task3.V7
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
            this.textBoxUslov = new System.Windows.Forms.TextBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.textBoxVivod = new System.Windows.Forms.TextBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUslov
            // 
            this.textBoxUslov.Location = new System.Drawing.Point(38, 31);
            this.textBoxUslov.Name = "textBoxUslov";
            this.textBoxUslov.Size = new System.Drawing.Size(100, 20);
            this.textBoxUslov.TabIndex = 0;
            this.textBoxUslov.Text = "Условие";
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.Location = new System.Drawing.Point(38, 57);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.Size = new System.Drawing.Size(232, 140);
            this.textBoxUslovie.TabIndex = 1;
            this.textBoxUslovie.Text = "Дана матрица 5 на 5\r\nПосчитать количество \r\n";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(293, 57);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(301, 294);
            this.dataGridViewMatrix.TabIndex = 2;
            // 
            // textBoxVivod
            // 
            this.textBoxVivod.Location = new System.Drawing.Point(607, 31);
            this.textBoxVivod.Name = "textBoxVivod";
            this.textBoxVivod.Size = new System.Drawing.Size(100, 20);
            this.textBoxVivod.TabIndex = 3;
            this.textBoxVivod.Text = "Вывод данных:";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(607, 57);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(100, 20);
            this.textBoxRes.TabIndex = 4;
            this.textBoxRes.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(607, 83);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(169, 92);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Location = new System.Drawing.Point(661, 294);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(115, 57);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Расчитать";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDoneClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.textBoxVivod);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.textBoxUslovie);
            this.Controls.Add(this.textBoxUslov);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 7 | Ким А.В.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUslov;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.TextBox textBoxVivod;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonDone;
    }
}

