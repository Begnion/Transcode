namespace Transcode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.labPath = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnInfo = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBitrate = new System.Windows.Forms.CheckBox();
            this.checkBoxFramerate = new System.Windows.Forms.CheckBox();
            this.cmbHXW = new System.Windows.Forms.ComboBox();
            this.checkBoxHXW = new System.Windows.Forms.CheckBox();
            this.checkBoxFast = new System.Windows.Forms.CheckBox();
            this.cmbGPU = new System.Windows.Forms.ComboBox();
            this.checkBoxGPU = new System.Windows.Forms.CheckBox();
            this.cmbFramerate = new System.Windows.Forms.ComboBox();
            this.cmbFomart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBitrate = new System.Windows.Forms.TextBox();
            this.tabAudio = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbAuFomart = new System.Windows.Forms.CheckBox();
            this.cbxSampleBits = new System.Windows.Forms.ComboBox();
            this.chbSampleBits = new System.Windows.Forms.CheckBox();
            this.cbxSampleRate = new System.Windows.Forms.ComboBox();
            this.chbSampleRate = new System.Windows.Forms.CheckBox();
            this.cbxAuChannel = new System.Windows.Forms.ComboBox();
            this.chbAuChannel = new System.Windows.Forms.CheckBox();
            this.cbxAuFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAuBit = new System.Windows.Forms.TextBox();
            this.chbAuBit = new System.Windows.Forms.CheckBox();
            this.tabTime = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txbTS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTH = new System.Windows.Forms.TextBox();
            this.txbFS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbFM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbFH = new System.Windows.Forms.TextBox();
            this.chbTimeCut = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.tabAudio.SuspendLayout();
            this.tabTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(79, 13);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 60);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "移除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(145, 13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 60);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(211, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 60);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(277, 13);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(60, 60);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // labPath
            // 
            this.labPath.AutoSize = true;
            this.labPath.Location = new System.Drawing.Point(442, 13);
            this.labPath.Name = "labPath";
            this.labPath.Size = new System.Drawing.Size(82, 15);
            this.labPath.TabIndex = 5;
            this.labPath.Text = "输出路径：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 25);
            this.textBox1.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(764, 32);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 25);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 94);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 346);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(555, 94);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(269, 23);
            this.btnInfo.TabIndex = 9;
            this.btnInfo.Text = "文件信息";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(555, 124);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(269, 316);
            this.treeView1.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVideo);
            this.tabControl1.Controls.Add(this.tabAudio);
            this.tabControl1.Controls.Add(this.tabTime);
            this.tabControl1.Location = new System.Drawing.Point(13, 511);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 199);
            this.tabControl1.TabIndex = 11;
            // 
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.label1);
            this.tabVideo.Controls.Add(this.checkBoxBitrate);
            this.tabVideo.Controls.Add(this.checkBoxFramerate);
            this.tabVideo.Controls.Add(this.cmbHXW);
            this.tabVideo.Controls.Add(this.checkBoxHXW);
            this.tabVideo.Controls.Add(this.checkBoxFast);
            this.tabVideo.Controls.Add(this.cmbGPU);
            this.tabVideo.Controls.Add(this.checkBoxGPU);
            this.tabVideo.Controls.Add(this.cmbFramerate);
            this.tabVideo.Controls.Add(this.cmbFomart);
            this.tabVideo.Controls.Add(this.label2);
            this.tabVideo.Controls.Add(this.txbBitrate);
            this.tabVideo.Location = new System.Drawing.Point(4, 25);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(803, 170);
            this.tabVideo.TabIndex = 0;
            this.tabVideo.Text = "视频";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "kbps";
            // 
            // checkBoxBitrate
            // 
            this.checkBoxBitrate.AutoSize = true;
            this.checkBoxBitrate.Location = new System.Drawing.Point(90, 15);
            this.checkBoxBitrate.Name = "checkBoxBitrate";
            this.checkBoxBitrate.Size = new System.Drawing.Size(104, 19);
            this.checkBoxBitrate.TabIndex = 13;
            this.checkBoxBitrate.Text = "视频码率：";
            this.checkBoxBitrate.UseVisualStyleBackColor = true;
            this.checkBoxBitrate.CheckedChanged += new System.EventHandler(this.checkBoxBitrate_CheckedChanged);
            // 
            // checkBoxFramerate
            // 
            this.checkBoxFramerate.AutoSize = true;
            this.checkBoxFramerate.Location = new System.Drawing.Point(90, 123);
            this.checkBoxFramerate.Name = "checkBoxFramerate";
            this.checkBoxFramerate.Size = new System.Drawing.Size(74, 19);
            this.checkBoxFramerate.TabIndex = 12;
            this.checkBoxFramerate.Text = "帧率：";
            this.checkBoxFramerate.UseVisualStyleBackColor = true;
            this.checkBoxFramerate.CheckedChanged += new System.EventHandler(this.checkBoxFramerate_CheckedChanged);
            // 
            // cmbHXW
            // 
            this.cmbHXW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHXW.Enabled = false;
            this.cmbHXW.FormattingEnabled = true;
            this.cmbHXW.Items.AddRange(new object[] {
            "2560x1440",
            "1920x1080",
            "1600x900",
            "1440x900",
            "1366x768",
            "1280x900",
            "1280x720",
            "1080x576",
            "720x576",
            "720x480",
            "640x480",
            "640x360",
            ""});
            this.cmbHXW.Location = new System.Drawing.Point(538, 14);
            this.cmbHXW.Name = "cmbHXW";
            this.cmbHXW.Size = new System.Drawing.Size(131, 23);
            this.cmbHXW.TabIndex = 11;
            // 
            // checkBoxHXW
            // 
            this.checkBoxHXW.AutoSize = true;
            this.checkBoxHXW.Location = new System.Drawing.Point(428, 16);
            this.checkBoxHXW.Name = "checkBoxHXW";
            this.checkBoxHXW.Size = new System.Drawing.Size(104, 19);
            this.checkBoxHXW.TabIndex = 10;
            this.checkBoxHXW.Text = "更改分辨率";
            this.checkBoxHXW.UseVisualStyleBackColor = true;
            this.checkBoxHXW.CheckedChanged += new System.EventHandler(this.checkBoxHXW_CheckedChanged);
            // 
            // checkBoxFast
            // 
            this.checkBoxFast.AutoSize = true;
            this.checkBoxFast.Location = new System.Drawing.Point(428, 120);
            this.checkBoxFast.Name = "checkBoxFast";
            this.checkBoxFast.Size = new System.Drawing.Size(180, 19);
            this.checkBoxFast.TabIndex = 9;
            this.checkBoxFast.Text = "极速模式(复制视频流)";
            this.checkBoxFast.UseVisualStyleBackColor = true;
            this.checkBoxFast.CheckedChanged += new System.EventHandler(this.checkBoxFast_CheckedChanged);
            // 
            // cmbGPU
            // 
            this.cmbGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGPU.Enabled = false;
            this.cmbGPU.FormattingEnabled = true;
            this.cmbGPU.Location = new System.Drawing.Point(517, 65);
            this.cmbGPU.Name = "cmbGPU";
            this.cmbGPU.Size = new System.Drawing.Size(152, 23);
            this.cmbGPU.TabIndex = 8;
            // 
            // checkBoxGPU
            // 
            this.checkBoxGPU.AutoSize = true;
            this.checkBoxGPU.Location = new System.Drawing.Point(428, 68);
            this.checkBoxGPU.Name = "checkBoxGPU";
            this.checkBoxGPU.Size = new System.Drawing.Size(83, 19);
            this.checkBoxGPU.TabIndex = 6;
            this.checkBoxGPU.Text = "GPU加速";
            this.checkBoxGPU.UseVisualStyleBackColor = true;
            this.checkBoxGPU.CheckedChanged += new System.EventHandler(this.checkBoxGPU_CheckedChanged);
            // 
            // cmbFramerate
            // 
            this.cmbFramerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFramerate.Enabled = false;
            this.cmbFramerate.FormattingEnabled = true;
            this.cmbFramerate.Items.AddRange(new object[] {
            "25",
            "30",
            "50",
            "60",
            "90",
            "120",
            "144"});
            this.cmbFramerate.Location = new System.Drawing.Point(194, 121);
            this.cmbFramerate.Name = "cmbFramerate";
            this.cmbFramerate.Size = new System.Drawing.Size(128, 23);
            this.cmbFramerate.TabIndex = 5;
            // 
            // cmbFomart
            // 
            this.cmbFomart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFomart.FormattingEnabled = true;
            this.cmbFomart.Items.AddRange(new object[] {
            "mp4",
            "ts",
            "mkv",
            "flv",
            "mpeg2",
            "wmv"});
            this.cmbFomart.Location = new System.Drawing.Point(194, 65);
            this.cmbFomart.Name = "cmbFomart";
            this.cmbFomart.Size = new System.Drawing.Size(128, 23);
            this.cmbFomart.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "格式：";
            // 
            // txbBitrate
            // 
            this.txbBitrate.Enabled = false;
            this.txbBitrate.Location = new System.Drawing.Point(216, 13);
            this.txbBitrate.Name = "txbBitrate";
            this.txbBitrate.Size = new System.Drawing.Size(75, 25);
            this.txbBitrate.TabIndex = 1;
            this.txbBitrate.TextChanged += new System.EventHandler(this.txbBitrate_TextChanged);
            // 
            // tabAudio
            // 
            this.tabAudio.Controls.Add(this.label6);
            this.tabAudio.Controls.Add(this.label5);
            this.tabAudio.Controls.Add(this.chbAuFomart);
            this.tabAudio.Controls.Add(this.cbxSampleBits);
            this.tabAudio.Controls.Add(this.chbSampleBits);
            this.tabAudio.Controls.Add(this.cbxSampleRate);
            this.tabAudio.Controls.Add(this.chbSampleRate);
            this.tabAudio.Controls.Add(this.cbxAuChannel);
            this.tabAudio.Controls.Add(this.chbAuChannel);
            this.tabAudio.Controls.Add(this.cbxAuFormat);
            this.tabAudio.Controls.Add(this.label3);
            this.tabAudio.Controls.Add(this.txbAuBit);
            this.tabAudio.Controls.Add(this.chbAuBit);
            this.tabAudio.Location = new System.Drawing.Point(4, 25);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabAudio.Size = new System.Drawing.Size(803, 170);
            this.tabAudio.TabIndex = 1;
            this.tabAudio.Text = "音频";
            this.tabAudio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hz";
            // 
            // chbAuFomart
            // 
            this.chbAuFomart.AutoSize = true;
            this.chbAuFomart.Location = new System.Drawing.Point(113, 77);
            this.chbAuFomart.Name = "chbAuFomart";
            this.chbAuFomart.Size = new System.Drawing.Size(59, 19);
            this.chbAuFomart.TabIndex = 11;
            this.chbAuFomart.Text = "格式";
            this.chbAuFomart.UseVisualStyleBackColor = true;
            this.chbAuFomart.CheckedChanged += new System.EventHandler(this.chbAuFomart_CheckedChanged);
            // 
            // cbxSampleBits
            // 
            this.cbxSampleBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSampleBits.Enabled = false;
            this.cbxSampleBits.FormattingEnabled = true;
            this.cbxSampleBits.Items.AddRange(new object[] {
            "u8",
            "s16",
            "s32",
            "u8p",
            "s16p",
            "s32p",
            "s64",
            "s64p"});
            this.cbxSampleBits.Location = new System.Drawing.Point(538, 77);
            this.cbxSampleBits.Name = "cbxSampleBits";
            this.cbxSampleBits.Size = new System.Drawing.Size(121, 23);
            this.cbxSampleBits.TabIndex = 10;
            // 
            // chbSampleBits
            // 
            this.chbSampleBits.AutoSize = true;
            this.chbSampleBits.Enabled = false;
            this.chbSampleBits.Location = new System.Drawing.Point(439, 77);
            this.chbSampleBits.Name = "chbSampleBits";
            this.chbSampleBits.Size = new System.Drawing.Size(89, 19);
            this.chbSampleBits.TabIndex = 9;
            this.chbSampleBits.Text = "样本位数";
            this.chbSampleBits.UseVisualStyleBackColor = true;
            this.chbSampleBits.CheckedChanged += new System.EventHandler(this.chbSampleBits_CheckedChanged);
            // 
            // cbxSampleRate
            // 
            this.cbxSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSampleRate.Enabled = false;
            this.cbxSampleRate.FormattingEnabled = true;
            this.cbxSampleRate.Items.AddRange(new object[] {
            "8000",
            "11025",
            "16000",
            "22050",
            "24000",
            "32000",
            "44100",
            "48000"});
            this.cbxSampleRate.Location = new System.Drawing.Point(538, 30);
            this.cbxSampleRate.Name = "cbxSampleRate";
            this.cbxSampleRate.Size = new System.Drawing.Size(121, 23);
            this.cbxSampleRate.TabIndex = 8;
            // 
            // chbSampleRate
            // 
            this.chbSampleRate.AutoSize = true;
            this.chbSampleRate.Enabled = false;
            this.chbSampleRate.Location = new System.Drawing.Point(439, 32);
            this.chbSampleRate.Name = "chbSampleRate";
            this.chbSampleRate.Size = new System.Drawing.Size(74, 19);
            this.chbSampleRate.TabIndex = 7;
            this.chbSampleRate.Text = "重采样";
            this.chbSampleRate.UseVisualStyleBackColor = true;
            this.chbSampleRate.CheckedChanged += new System.EventHandler(this.chbSampleRate_CheckedChanged);
            // 
            // cbxAuChannel
            // 
            this.cbxAuChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuChannel.Enabled = false;
            this.cbxAuChannel.FormattingEnabled = true;
            this.cbxAuChannel.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "6"});
            this.cbxAuChannel.Location = new System.Drawing.Point(206, 118);
            this.cbxAuChannel.Name = "cbxAuChannel";
            this.cbxAuChannel.Size = new System.Drawing.Size(121, 23);
            this.cbxAuChannel.TabIndex = 6;
            // 
            // chbAuChannel
            // 
            this.chbAuChannel.AutoSize = true;
            this.chbAuChannel.Enabled = false;
            this.chbAuChannel.Location = new System.Drawing.Point(113, 120);
            this.chbAuChannel.Name = "chbAuChannel";
            this.chbAuChannel.Size = new System.Drawing.Size(59, 19);
            this.chbAuChannel.TabIndex = 5;
            this.chbAuChannel.Text = "声道";
            this.chbAuChannel.UseVisualStyleBackColor = true;
            this.chbAuChannel.CheckedChanged += new System.EventHandler(this.chbAuChannel_CheckedChanged);
            // 
            // cbxAuFormat
            // 
            this.cbxAuFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuFormat.Enabled = false;
            this.cbxAuFormat.FormattingEnabled = true;
            this.cbxAuFormat.Items.AddRange(new object[] {
            "libmp3lame",
            "aac",
            "mp2",
            "ac3",
            "alac",
            "pcm_s16le"});
            this.cbxAuFormat.Location = new System.Drawing.Point(206, 74);
            this.cbxAuFormat.Name = "cbxAuFormat";
            this.cbxAuFormat.Size = new System.Drawing.Size(121, 23);
            this.cbxAuFormat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "kbps";
            // 
            // txbAuBit
            // 
            this.txbAuBit.Enabled = false;
            this.txbAuBit.Location = new System.Drawing.Point(227, 30);
            this.txbAuBit.Name = "txbAuBit";
            this.txbAuBit.Size = new System.Drawing.Size(100, 25);
            this.txbAuBit.TabIndex = 1;
            this.txbAuBit.TextChanged += new System.EventHandler(this.txbAuBit_TextChanged);
            // 
            // chbAuBit
            // 
            this.chbAuBit.AutoSize = true;
            this.chbAuBit.Enabled = false;
            this.chbAuBit.Location = new System.Drawing.Point(113, 32);
            this.chbAuBit.Name = "chbAuBit";
            this.chbAuBit.Size = new System.Drawing.Size(89, 19);
            this.chbAuBit.TabIndex = 0;
            this.chbAuBit.Text = "音频码率";
            this.chbAuBit.UseVisualStyleBackColor = true;
            this.chbAuBit.CheckedChanged += new System.EventHandler(this.chbAuBit_CheckedChanged);
            // 
            // tabTime
            // 
            this.tabTime.Controls.Add(this.label11);
            this.tabTime.Controls.Add(this.txbTS);
            this.tabTime.Controls.Add(this.label9);
            this.tabTime.Controls.Add(this.txbTM);
            this.tabTime.Controls.Add(this.label10);
            this.tabTime.Controls.Add(this.txbTH);
            this.tabTime.Controls.Add(this.txbFS);
            this.tabTime.Controls.Add(this.label8);
            this.tabTime.Controls.Add(this.txbFM);
            this.tabTime.Controls.Add(this.label7);
            this.tabTime.Controls.Add(this.txbFH);
            this.tabTime.Controls.Add(this.chbTimeCut);
            this.tabTime.Location = new System.Drawing.Point(4, 25);
            this.tabTime.Name = "tabTime";
            this.tabTime.Size = new System.Drawing.Size(803, 170);
            this.tabTime.TabIndex = 2;
            this.tabTime.Text = "剪切";
            this.tabTime.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "到";
            // 
            // txbTS
            // 
            this.txbTS.Location = new System.Drawing.Point(546, 71);
            this.txbTS.Name = "txbTS";
            this.txbTS.Size = new System.Drawing.Size(30, 25);
            this.txbTS.TabIndex = 10;
            this.txbTS.Text = "00";
            this.txbTS.TextChanged += new System.EventHandler(this.txbTS_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = ":";
            // 
            // txbTM
            // 
            this.txbTM.Location = new System.Drawing.Point(489, 71);
            this.txbTM.Name = "txbTM";
            this.txbTM.Size = new System.Drawing.Size(30, 25);
            this.txbTM.TabIndex = 8;
            this.txbTM.Text = "00";
            this.txbTM.TextChanged += new System.EventHandler(this.txbTM_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = ":";
            // 
            // txbTH
            // 
            this.txbTH.Location = new System.Drawing.Point(432, 71);
            this.txbTH.Name = "txbTH";
            this.txbTH.Size = new System.Drawing.Size(30, 25);
            this.txbTH.TabIndex = 6;
            this.txbTH.Text = "00";
            this.txbTH.TextChanged += new System.EventHandler(this.txbTH_TextChanged);
            // 
            // txbFS
            // 
            this.txbFS.Location = new System.Drawing.Point(303, 71);
            this.txbFS.Name = "txbFS";
            this.txbFS.Size = new System.Drawing.Size(30, 25);
            this.txbFS.TabIndex = 5;
            this.txbFS.Text = "00";
            this.txbFS.TextChanged += new System.EventHandler(this.txbFS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = ":";
            // 
            // txbFM
            // 
            this.txbFM.Location = new System.Drawing.Point(246, 71);
            this.txbFM.Name = "txbFM";
            this.txbFM.Size = new System.Drawing.Size(30, 25);
            this.txbFM.TabIndex = 3;
            this.txbFM.Text = "00";
            this.txbFM.TextChanged += new System.EventHandler(this.txbFM_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = ":";
            // 
            // txbFH
            // 
            this.txbFH.Location = new System.Drawing.Point(189, 71);
            this.txbFH.Name = "txbFH";
            this.txbFH.Size = new System.Drawing.Size(30, 25);
            this.txbFH.TabIndex = 1;
            this.txbFH.Text = "00";
            this.txbFH.TextChanged += new System.EventHandler(this.txbFH_TextChanged);
            // 
            // chbTimeCut
            // 
            this.chbTimeCut.AutoSize = true;
            this.chbTimeCut.Location = new System.Drawing.Point(79, 75);
            this.chbTimeCut.Name = "chbTimeCut";
            this.chbTimeCut.Size = new System.Drawing.Size(104, 19);
            this.chbTimeCut.TabIndex = 0;
            this.chbTimeCut.Text = "截取时间：";
            this.chbTimeCut.UseVisualStyleBackColor = true;
            this.chbTimeCut.CheckedChanged += new System.EventHandler(this.chbTimeCut_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(113, 463);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(707, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "当前任务进度";
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(343, 13);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(60, 60);
            this.btnEnd.TabIndex = 15;
            this.btnEnd.Text = "终止";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 725);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labPath);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "视频转换";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabVideo.ResumeLayout(false);
            this.tabVideo.PerformLayout();
            this.tabAudio.ResumeLayout(false);
            this.tabAudio.PerformLayout();
            this.tabTime.ResumeLayout(false);
            this.tabTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label labPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.TabPage tabAudio;
        private System.Windows.Forms.TabPage tabTime;
        private System.Windows.Forms.CheckBox checkBoxFast;
        private System.Windows.Forms.ComboBox cmbGPU;
        private System.Windows.Forms.CheckBox checkBoxGPU;
        private System.Windows.Forms.ComboBox cmbFramerate;
        private System.Windows.Forms.ComboBox cmbFomart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBitrate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxHXW;
        private System.Windows.Forms.ComboBox cmbHXW;
        private System.Windows.Forms.CheckBox checkBoxFramerate;
        private System.Windows.Forms.CheckBox checkBoxBitrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAuFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAuBit;
        private System.Windows.Forms.CheckBox chbAuBit;
        private System.Windows.Forms.ComboBox cbxAuChannel;
        private System.Windows.Forms.CheckBox chbAuChannel;
        private System.Windows.Forms.ComboBox cbxSampleBits;
        private System.Windows.Forms.CheckBox chbSampleBits;
        private System.Windows.Forms.ComboBox cbxSampleRate;
        private System.Windows.Forms.CheckBox chbSampleRate;
        private System.Windows.Forms.CheckBox chbAuFomart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbTS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbTH;
        private System.Windows.Forms.TextBox txbFS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbFM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbFH;
        private System.Windows.Forms.CheckBox chbTimeCut;
        private System.Windows.Forms.Button btnEnd;
    }
}

