namespace Tyuiu.KimAV.Sprint6.Task2.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxUslov = new System.Windows.Forms.TextBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.textBoxVvod = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxInPutX = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxInPutY = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.textBoxVivod = new System.Windows.Forms.TextBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.dataGridViewOutPutResult = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartOutPutResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutPutResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUslov
            // 
            this.textBoxUslov.Location = new System.Drawing.Point(30, 24);
            this.textBoxUslov.Name = "textBoxUslov";
            this.textBoxUslov.Size = new System.Drawing.Size(94, 20);
            this.textBoxUslov.TabIndex = 0;
            this.textBoxUslov.Text = "Условие";
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.Location = new System.Drawing.Point(30, 50);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.Size = new System.Drawing.Size(438, 235);
            this.textBoxUslovie.TabIndex = 1;
            this.textBoxUslovie.Text = "Протабулировать функцию на заданном диапазоне \r\n";
            // 
            // textBoxVvod
            // 
            this.textBoxVvod.Location = new System.Drawing.Point(30, 302);
            this.textBoxVvod.Name = "textBoxVvod";
            this.textBoxVvod.Size = new System.Drawing.Size(100, 20);
            this.textBoxVvod.TabIndex = 2;
            this.textBoxVvod.Text = "Ввод данных:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(30, 328);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 3;
            this.textBoxStart.Text = "Старт шага:";
            // 
            // textBoxInPutX
            // 
            this.textBoxInPutX.Location = new System.Drawing.Point(30, 354);
            this.textBoxInPutX.Name = "textBoxInPutX";
            this.textBoxInPutX.Size = new System.Drawing.Size(100, 20);
            this.textBoxInPutX.TabIndex = 4;
            this.textBoxInPutX.Click += new System.EventHandler(this.textBoxStartValueKeyPress);
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(162, 328);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 5;
            this.textBoxEnd.Text = "Конец шага:";
            // 
            // textBoxInPutY
            // 
            this.textBoxInPutY.Location = new System.Drawing.Point(162, 354);
            this.textBoxInPutY.Name = "textBoxInPutY";
            this.textBoxInPutY.Size = new System.Drawing.Size(100, 20);
            this.textBoxInPutY.TabIndex = 6;
            this.textBoxInPutY.Click += new System.EventHandler(this.textBoxStopValueKeyPress);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Location = new System.Drawing.Point(331, 302);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(137, 72);
            this.buttonDone.TabIndex = 7;
            this.buttonDone.Text = "Расчитать";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDoneClick);
            // 
            // textBoxVivod
            // 
            this.textBoxVivod.Location = new System.Drawing.Point(470, 24);
            this.textBoxVivod.Name = "textBoxVivod";
            this.textBoxVivod.Size = new System.Drawing.Size(100, 20);
            this.textBoxVivod.TabIndex = 8;
            this.textBoxVivod.Text = "Вывод данных:";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(470, 50);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(100, 20);
            this.textBoxRes.TabIndex = 9;
            this.textBoxRes.Text = "Результат:";
            // 
            // dataGridViewOutPutResult
            // 
            this.dataGridViewOutPutResult.AllowUserToOrderColumns = true;
            this.dataGridViewOutPutResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.FX});
            this.dataGridViewOutPutResult.Location = new System.Drawing.Point(470, 76);
            this.dataGridViewOutPutResult.Name = "dataGridViewOutPutResult";
            this.dataGridViewOutPutResult.RowHeadersVisible = false;
            this.dataGridViewOutPutResult.Size = new System.Drawing.Size(107, 269);
            this.dataGridViewOutPutResult.TabIndex = 10;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // FX
            // 
            this.FX.HeaderText = "FX";
            this.FX.Name = "FX";
            this.FX.Width = 50;
            // 
            // chartOutPutResult
            // 
            chartArea4.Name = "ChartArea1";
            this.chartOutPutResult.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartOutPutResult.Legends.Add(legend4);
            this.chartOutPutResult.Location = new System.Drawing.Point(650, 50);
            this.chartOutPutResult.Name = "chartOutPutResult";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartOutPutResult.Series.Add(series4);
            this.chartOutPutResult.Size = new System.Drawing.Size(386, 300);
            this.chartOutPutResult.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.chartOutPutResult);
            this.Controls.Add(this.dataGridViewOutPutResult);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.textBoxVivod);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxInPutY);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxInPutX);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.textBoxVvod);
            this.Controls.Add(this.textBoxUslovie);
            this.Controls.Add(this.textBoxUslov);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 25 | Ким А.В.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutPutResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUslov;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.TextBox textBoxVvod;
        private System.Windows.Forms.TextBox textBoxStart;
        public System.Windows.Forms.TextBox textBoxInPutX;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxInPutY;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBoxVivod;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.DataGridView dataGridViewOutPutResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn FX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutPutResult;
    }
}

