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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.logger = new System.Windows.Forms.ListBox();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.waveViewer = new NAudio.Gui.WaveViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartFrequencyAmplitudes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAmplitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartColateral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewDatasetInfo = new System.Windows.Forms.DataGridView();
            this.SignalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoizeMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalNoiseRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTeach = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRecognizePath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyAmplitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColateral)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatasetInfo)).BeginInit();
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
            chartArea9.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartMain.Legends.Add(legend9);
            this.chartMain.Location = new System.Drawing.Point(6, 6);
            this.chartMain.Name = "chartMain";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartMain.Series.Add(series9);
            this.chartMain.Size = new System.Drawing.Size(613, 286);
            this.chartMain.TabIndex = 2;
            this.chartMain.Text = "chart1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage5);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(2, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1245, 614);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.waveViewer);
            this.tabPage3.Controls.Add(this.label3);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Представление звуковой волны";
            // 
            // waveViewer
            // 
            this.waveViewer.Location = new System.Drawing.Point(400, 20);
            this.waveViewer.Name = "waveViewer";
            this.waveViewer.SamplesPerPixel = 128;
            this.waveViewer.Size = new System.Drawing.Size(831, 561);
            this.waveViewer.StartPosition = ((long)(0));
            this.waveViewer.TabIndex = 14;
            this.waveViewer.WaveStream = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Путь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.AllowDrop = true;
            this.textBoxFilePath.Location = new System.Drawing.Point(9, 20);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(382, 20);
            this.textBoxFilePath.TabIndex = 8;
            this.textBoxFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFilePath_DragDrop);
            this.textBoxFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFilePath_DragEnter);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(9, 521);
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
            this.tabPage1.Text = "Анализ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartFrequencyAmplitudes
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFrequencyAmplitudes.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartFrequencyAmplitudes.Legends.Add(legend10);
            this.chartFrequencyAmplitudes.Location = new System.Drawing.Point(621, 6);
            this.chartFrequencyAmplitudes.Name = "chartFrequencyAmplitudes";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartFrequencyAmplitudes.Series.Add(series10);
            this.chartFrequencyAmplitudes.Size = new System.Drawing.Size(613, 286);
            this.chartFrequencyAmplitudes.TabIndex = 5;
            this.chartFrequencyAmplitudes.Text = "chart1";
            // 
            // chartAmplitude
            // 
            chartArea11.Name = "ChartArea1";
            this.chartAmplitude.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartAmplitude.Legends.Add(legend11);
            this.chartAmplitude.Location = new System.Drawing.Point(6, 295);
            this.chartAmplitude.Name = "chartAmplitude";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartAmplitude.Series.Add(series11);
            this.chartAmplitude.Size = new System.Drawing.Size(613, 286);
            this.chartAmplitude.TabIndex = 4;
            this.chartAmplitude.Text = "chart1";
            // 
            // chartColateral
            // 
            chartArea12.Name = "ChartArea1";
            this.chartColateral.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartColateral.Legends.Add(legend12);
            this.chartColateral.Location = new System.Drawing.Point(622, 295);
            this.chartColateral.Name = "chartColateral";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartColateral.Series.Add(series12);
            this.chartColateral.Size = new System.Drawing.Size(609, 286);
            this.chartColateral.TabIndex = 3;
            this.chartColateral.Text = "chart1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewDatasetInfo);
            this.tabPage5.Controls.Add(this.buttonTeach);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1237, 588);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Датасет";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDatasetInfo
            // 
            this.dataGridViewDatasetInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatasetInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SignalName,
            this.Frequency,
            this.NoizeMC,
            this.SignalPower,
            this.SignalNoiseRelation,
            this.Validity});
            this.dataGridViewDatasetInfo.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDatasetInfo.Name = "dataGridViewDatasetInfo";
            this.dataGridViewDatasetInfo.Size = new System.Drawing.Size(834, 575);
            this.dataGridViewDatasetInfo.TabIndex = 12;
            // 
            // SignalName
            // 
            this.SignalName.HeaderText = "Звуковой сигнал";
            this.SignalName.Name = "SignalName";
            this.SignalName.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Частотный диапазон (Гц)";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // NoizeMC
            // 
            this.NoizeMC.HeaderText = "Уровень шумов (дБ)";
            this.NoizeMC.Name = "NoizeMC";
            this.NoizeMC.ReadOnly = true;
            // 
            // SignalPower
            // 
            this.SignalPower.HeaderText = "Средняя мощность сигнала (Вт)";
            this.SignalPower.Name = "SignalPower";
            this.SignalPower.ReadOnly = true;
            // 
            // SignalNoiseRelation
            // 
            this.SignalNoiseRelation.HeaderText = "Соотношение сигнал/шум (дБ)";
            this.SignalNoiseRelation.Name = "SignalNoiseRelation";
            this.SignalNoiseRelation.ReadOnly = true;
            // 
            // Validity
            // 
            this.Validity.HeaderText = "Пригодность (%)";
            this.Validity.Name = "Validity";
            this.Validity.ReadOnly = true;
            // 
            // buttonTeach
            // 
            this.buttonTeach.Location = new System.Drawing.Point(846, 521);
            this.buttonTeach.Name = "buttonTeach";
            this.buttonTeach.Size = new System.Drawing.Size(382, 60);
            this.buttonTeach.TabIndex = 11;
            this.buttonTeach.Text = "Иницировать обучение";
            this.buttonTeach.UseVisualStyleBackColor = true;
            this.buttonTeach.Click += new System.EventHandler(this.buttonTeach_Click);
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
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "PS";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyAmplitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColateral)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatasetInfo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox logger;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColateral;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonRecognize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRecognizePath;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmplitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrequencyAmplitudes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label3;
        private NAudio.Gui.WaveViewer waveViewer;
        private System.Windows.Forms.Button buttonTeach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewDatasetInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoizeMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalNoiseRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validity;
    }
}

