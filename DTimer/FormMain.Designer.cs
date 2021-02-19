
namespace DTimer
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.labelDateTime = new System.Windows.Forms.Label();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.textBoxMusicFilePath = new System.Windows.Forms.TextBox();
            this.buttonFindMusicFile = new System.Windows.Forms.Button();
            this.numericUpDownSecond = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.progressBarTimer = new System.Windows.Forms.ProgressBar();
            this.labelTimerCounter = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxCurrentMusicPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerMain
            // 
            this.TimerMain.Enabled = true;
            this.TimerMain.Interval = 1000;
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(6, 12);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(53, 12);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "현재시간";
            // 
            // textBoxDateTime
            // 
            this.textBoxDateTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxDateTime.Location = new System.Drawing.Point(65, 9);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.ReadOnly = true;
            this.textBoxDateTime.Size = new System.Drawing.Size(138, 21);
            this.textBoxDateTime.TabIndex = 2;
            this.textBoxDateTime.TabStop = false;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMain.Location = new System.Drawing.Point(548, 9);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowTemplate.Height = 23;
            this.dataGridViewMain.Size = new System.Drawing.Size(240, 429);
            this.dataGridViewMain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "타이머 추가";
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(208, 53);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(60, 21);
            this.numericUpDownMinute.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "분";
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.DefaultExt = "csv";
            this.openFileDialogMain.FileName = "openFileDialog1";
            // 
            // textBoxMusicFilePath
            // 
            this.textBoxMusicFilePath.Location = new System.Drawing.Point(12, 80);
            this.textBoxMusicFilePath.Name = "textBoxMusicFilePath";
            this.textBoxMusicFilePath.ReadOnly = true;
            this.textBoxMusicFilePath.Size = new System.Drawing.Size(530, 21);
            this.textBoxMusicFilePath.TabIndex = 8;
            this.textBoxMusicFilePath.TabStop = false;
            // 
            // buttonFindMusicFile
            // 
            this.buttonFindMusicFile.Location = new System.Drawing.Point(12, 104);
            this.buttonFindMusicFile.Name = "buttonFindMusicFile";
            this.buttonFindMusicFile.Size = new System.Drawing.Size(110, 23);
            this.buttonFindMusicFile.TabIndex = 9;
            this.buttonFindMusicFile.Text = "재생음악 찾기";
            this.buttonFindMusicFile.UseVisualStyleBackColor = true;
            this.buttonFindMusicFile.Click += new System.EventHandler(this.buttonFindMusicFile_Click);
            // 
            // numericUpDownSecond
            // 
            this.numericUpDownSecond.Location = new System.Drawing.Point(299, 53);
            this.numericUpDownSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSecond.Name = "numericUpDownSecond";
            this.numericUpDownSecond.Size = new System.Drawing.Size(60, 21);
            this.numericUpDownSecond.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "초";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(98, 51);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(60, 21);
            this.numericUpDownHour.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "시간";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(442, 50);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Location = new System.Drawing.Point(8, 371);
            this.progressBarTimer.Name = "progressBarTimer";
            this.progressBarTimer.Size = new System.Drawing.Size(534, 23);
            this.progressBarTimer.TabIndex = 15;
            // 
            // labelTimerCounter
            // 
            this.labelTimerCounter.AutoSize = true;
            this.labelTimerCounter.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTimerCounter.Location = new System.Drawing.Point(46, 180);
            this.labelTimerCounter.Name = "labelTimerCounter";
            this.labelTimerCounter.Size = new System.Drawing.Size(455, 110);
            this.labelTimerCounter.TabIndex = 16;
            this.labelTimerCounter.Text = "00:00:00";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(225, 311);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 23);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "타이머 시작";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxCurrentMusicPath
            // 
            this.textBoxCurrentMusicPath.Location = new System.Drawing.Point(12, 340);
            this.textBoxCurrentMusicPath.Name = "textBoxCurrentMusicPath";
            this.textBoxCurrentMusicPath.ReadOnly = true;
            this.textBoxCurrentMusicPath.Size = new System.Drawing.Size(530, 21);
            this.textBoxCurrentMusicPath.TabIndex = 18;
            this.textBoxCurrentMusicPath.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCurrentMusicPath);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTimerCounter);
            this.Controls.Add(this.progressBarTimer);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSecond);
            this.Controls.Add(this.buttonFindMusicFile);
            this.Controls.Add(this.textBoxMusicFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.textBoxDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Name = "FormMain";
            this.Text = "DTimer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.TextBox textBoxDateTime;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.TextBox textBoxMusicFilePath;
        private System.Windows.Forms.Button buttonFindMusicFile;
        private System.Windows.Forms.NumericUpDown numericUpDownSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ProgressBar progressBarTimer;
        private System.Windows.Forms.Label labelTimerCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxCurrentMusicPath;
    }
}

