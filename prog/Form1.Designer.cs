namespace prog
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.startidx_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.symbols_tbx = new System.Windows.Forms.TextBox();
            this.serverurl_tbx = new System.Windows.Forms.TextBox();
            this.path_tbx = new System.Windows.Forms.TextBox();
            this.OpenFile_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filter_cBx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseFolder_btn = new System.Windows.Forms.Button();
            this.folder_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.DarkOrange;
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(274, 339);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 32);
            this.Start.TabIndex = 0;
            this.Start.Text = "Старт";
            this.Start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // startidx_tbx
            // 
            this.startidx_tbx.Location = new System.Drawing.Point(146, 60);
            this.startidx_tbx.Name = "startidx_tbx";
            this.startidx_tbx.Size = new System.Drawing.Size(72, 20);
            this.startidx_tbx.TabIndex = 1;
            this.toolTip1.SetToolTip(this.startidx_tbx, "Укажите номер столбца с которого начать заполнение.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заполнять начиная с:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            // 
            // symbols_tbx
            // 
            this.symbols_tbx.Location = new System.Drawing.Point(131, 93);
            this.symbols_tbx.Name = "symbols_tbx";
            this.symbols_tbx.Size = new System.Drawing.Size(40, 20);
            this.symbols_tbx.TabIndex = 5;
            this.toolTip1.SetToolTip(this.symbols_tbx, "Если указать \"0\" то будет вся ячейка проверяться.");
            // 
            // serverurl_tbx
            // 
            this.serverurl_tbx.Location = new System.Drawing.Point(26, 251);
            this.serverurl_tbx.Name = "serverurl_tbx";
            this.serverurl_tbx.Size = new System.Drawing.Size(204, 20);
            this.serverurl_tbx.TabIndex = 13;
            this.toolTip1.SetToolTip(this.serverurl_tbx, "Указывайте с последним слэшем");
            // 
            // path_tbx
            // 
            this.path_tbx.Location = new System.Drawing.Point(97, 12);
            this.path_tbx.Name = "path_tbx";
            this.path_tbx.ReadOnly = true;
            this.path_tbx.Size = new System.Drawing.Size(161, 20);
            this.path_tbx.TabIndex = 3;
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.Location = new System.Drawing.Point(264, 12);
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(75, 23);
            this.OpenFile_btn.TabIndex = 4;
            this.OpenFile_btn.Text = "обзор";
            this.OpenFile_btn.UseVisualStyleBackColor = true;
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Проверять первые";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Искать совпадение в имени файла:";
            // 
            // filter_cBx
            // 
            this.filter_cBx.FormattingEnabled = true;
            this.filter_cBx.Items.AddRange(new object[] {
            "в начале",
            "в середине",
            "везде"});
            this.filter_cBx.Location = new System.Drawing.Point(209, 135);
            this.filter_cBx.Name = "filter_cBx";
            this.filter_cBx.Size = new System.Drawing.Size(121, 21);
            this.filter_cBx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Путь к excel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Путь к фоткам:";
            // 
            // chooseFolder_btn
            // 
            this.chooseFolder_btn.Location = new System.Drawing.Point(236, 185);
            this.chooseFolder_btn.Name = "chooseFolder_btn";
            this.chooseFolder_btn.Size = new System.Drawing.Size(117, 23);
            this.chooseFolder_btn.TabIndex = 11;
            this.chooseFolder_btn.Text = "Выбрать папку";
            this.chooseFolder_btn.UseVisualStyleBackColor = true;
            this.chooseFolder_btn.Click += new System.EventHandler(this.chooseFolder_btn_Click);
            // 
            // folder_tbx
            // 
            this.folder_tbx.Location = new System.Drawing.Point(26, 186);
            this.folder_tbx.Name = "folder_tbx";
            this.folder_tbx.ReadOnly = true;
            this.folder_tbx.Size = new System.Drawing.Size(204, 20);
            this.folder_tbx.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Начало ссылки на сервере:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "символов на совпадение";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(274, 306);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 17;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 383);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serverurl_tbx);
            this.Controls.Add(this.folder_tbx);
            this.Controls.Add(this.chooseFolder_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filter_cBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.symbols_tbx);
            this.Controls.Add(this.OpenFile_btn);
            this.Controls.Add(this.path_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startidx_tbx);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "PhotoLinksToExcel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox startidx_tbx;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path_tbx;
        private System.Windows.Forms.Button OpenFile_btn;
        private System.Windows.Forms.TextBox symbols_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filter_cBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button chooseFolder_btn;
        private System.Windows.Forms.TextBox folder_tbx;
        private System.Windows.Forms.TextBox serverurl_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label8;
    }
}

