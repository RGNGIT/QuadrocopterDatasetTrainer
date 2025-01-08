namespace QuadrocopterDatasetTrainer
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.logger = new System.Windows.Forms.ListBox();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonTeach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartFrequencyAmplitudes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAmplitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartColateral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRecognizePath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyAmplitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColateral)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logger
            // 
            this.logger.FormattingEnabled = true;
            this.logger.Location = new System.Drawing.Point(6, 6);
            this.logger.Name = "logger";
            this.logger.Size = new System.Drawing.Size(1225, 576);
            this.logger.TabIndex = 0;
            // 
            // chartMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(6, 6);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(613, 286);
            this.chartMain.TabIndex = 2;
            this.chartMain.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1245, 614);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonTeach);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxFilePath);
            this.tabPage3.Controls.Add(this.buttonRun);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1237, 588);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Главная";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonTeach
            // 
            this.buttonTeach.Location = new System.Drawing.Point(6, 112);
            this.buttonTeach.Name = "buttonTeach";
            this.buttonTeach.Size = new System.Drawing.Size(382, 60);
            this.buttonTeach.TabIndex = 10;
            this.buttonTeach.Text = "Иницировать обучение";
            this.buttonTeach.UseVisualStyleBackColor = true;
            this.buttonTeach.Click += new System.EventHandler(this.buttonTeach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Путь";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(9, 20);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(379, 20);
            this.textBoxFilePath.TabIndex = 8;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(6, 46);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(382, 60);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "Загрузить аудио";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartFrequencyAmplitudes);
            this.tabPage1.Controls.Add(this.chartAmplitude);
            this.tabPage1.Controls.Add(this.chartColateral);
            this.tabPage1.Controls.Add(this.chartMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1237, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аудио. Результирующая функция Фурье";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartFrequencyAmplitudes
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFrequencyAmplitudes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFrequencyAmplitudes.Legends.Add(legend2);
            this.chartFrequencyAmplitudes.Location = new System.Drawing.Point(621, 6);
            this.chartFrequencyAmplitudes.Name = "chartFrequencyAmplitudes";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFrequencyAmplitudes.Series.Add(series2);
            this.chartFrequencyAmplitudes.Size = new System.Drawing.Size(613, 286);
            this.chartFrequencyAmplitudes.TabIndex = 5;
            this.chartFrequencyAmplitudes.Text = "chart1";
            // 
            // chartAmplitude
            // 
            chartArea3.Name = "ChartArea1";
            this.chartAmplitude.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartAmplitude.Legends.Add(legend3);
            this.chartAmplitude.Location = new System.Drawing.Point(6, 295);
            this.chartAmplitude.Name = "chartAmplitude";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartAmplitude.Series.Add(series3);
            this.chartAmplitude.Size = new System.Drawing.Size(613, 286);
            this.chartAmplitude.TabIndex = 4;
            this.chartAmplitude.Text = "chart1";
            // 
            // chartColateral
            // 
            chartArea4.Name = "ChartArea1";
            this.chartColateral.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartColateral.Legends.Add(legend4);
            this.chartColateral.Location = new System.Drawing.Point(622, 295);
            this.chartColateral.Name = "chartColateral";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartColateral.Series.Add(series4);
            this.chartColateral.Size = new System.Drawing.Size(609, 286);
            this.chartColateral.TabIndex = 3;
            this.chartColateral.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonRecognize);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.textBoxRecognizePath);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1237, 588);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Тест распознавания";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Location = new System.Drawing.Point(6, 46);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(382, 60);
            this.buttonRecognize.TabIndex = 12;
            this.buttonRecognize.Text = "Опознать";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            this.buttonRecognize.Click += new System.EventHandler(this.buttonRecognize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Путь";
            // 
            // textBoxRecognizePath
            // 
            this.textBoxRecognizePath.Location = new System.Drawing.Point(6, 20);
            this.textBoxRecognizePath.Name = "textBoxRecognizePath";
            this.textBoxRecognizePath.Size = new System.Drawing.Size(382, 20);
            this.textBoxRecognizePath.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.logger);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1237, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Логгер";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 617);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "PS";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyAmplitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColateral)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox logger;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColateral;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonTeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonRecognize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRecognizePath;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmplitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrequencyAmplitudes;
    }
}

