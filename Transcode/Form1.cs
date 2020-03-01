using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Transcode
{
    public partial class Form1 : Form
    {
        readonly string path = AppDomain.CurrentDomain.BaseDirectory;
        List<Video> videos = new List<Video>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog selPath = new OpenFileDialog
            {
                Title = "选择视频目录",
                InitialDirectory = "C:\\Users\\Masspoint\\Desktop\\",
                Filter = "视频文件|*.mp4;*.mkv;*.ts;*.flv"
            };
            //后期改成枚举+反射
            if (selPath.ShowDialog() == DialogResult.OK)
            {
                string p = Path.GetFullPath(selPath.FileName);
                textBox1.Text=Path.GetDirectoryName(selPath.FileName);
                listView1.Items.Add(p);
                GetInfo(p);
                listView1.Items[listView1.Items.Count - 1].Focused = true;
                listView1.Items[listView1.Items.Count - 1].Selected = true;
                btnStart.Enabled = true;
                btnPlay.Enabled = true;
                btnRemove.Enabled = true;
                cmbFomart.SelectedIndex = 0;
            }
        }
        public void GetInfo(string videoPath)
        {
            MediaInfo.MediaInfoWrapper mediaInfo = new MediaInfo.MediaInfoWrapper(videoPath);
            Video v = new Video
            {
                Path = videoPath,
                Bitrate = mediaInfo.VideoRate,
                Duration = mediaInfo.Duration,
                Framerate = mediaInfo.Framerate,
                Height = mediaInfo.Height,
                Width = mediaInfo.Width,
                Size = mediaInfo.Size,
                Format = mediaInfo.VideoCodec,
                Aspectratio = mediaInfo.AspectRatio,

                AudioChannels = mediaInfo.AudioChannelsFriendly,
                AudioCodec = mediaInfo.AudioCodec,
                AudioRate = mediaInfo.AudioRate,
                AudioSampleRate = mediaInfo.AudioSampleRate
            };
            videos.Add(v);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = listView1.FocusedItem.Index;
            videos.RemoveAt(i);
            listView1.FocusedItem.Remove();
            if (listView1.Items.Count == 0)
            {
                btnRemove.Enabled = false;
                btnStart.Enabled = false;
                btnEnd.Enabled = false;
                btnPlay.Enabled = false;
                btnPause.Enabled = false;
            }
        }

        string TimeCut()
        {
            if (chbTimeCut.Checked)
            {
                return $" -ss {txbFH}:{txbFM}:{txbFS} -to {txbTH}:{txbTM}:{txbTS}  -accurate_seek";
            }
            return "";
        }
        string Assemble()
        {
            if(checkBoxFast.Checked)
            {
                return "-c copy";
            }

            //视频部分
            StringBuilder sbCom = new StringBuilder("");
            sbCom.Append($" -f {cmbFomart.Text}");
            if (checkBoxHXW.Checked)
            {
                sbCom.Append($" -s {cmbHXW.Text}");
            }
            if (checkBoxGPU.Checked)
            {
                if (cmbFomart.Text == "mp4" | cmbFomart.Text == "mkv")
                {
                    if (cmbGPU.SelectedText == "Intel")
                        sbCom.Append($" -c:v h264_qsv");
                    if (cmbGPU.SelectedText == "AMD")
                        sbCom.Append($" -c:v h264_amf");
                    if (cmbGPU.SelectedText == "Nvidia")
                        sbCom.Append($" -c:v h264_nvenc");
                }

                if (cmbFomart.Text == "flv")
                {
                    if (cmbGPU.SelectedText == "Intel")
                        sbCom.Append($" -c:v flv_qsv");
                    if (cmbGPU.SelectedText == "AMD")
                        sbCom.Append($" -c:v flv_amf");
                    if (cmbGPU.SelectedText == "Nvidia")
                        sbCom.Append($" -c:v flv_nvenc");
                }
                if (cmbFomart.Text == "ts" | cmbFomart.Text == "mpeg2")
                {
                    if (cmbGPU.SelectedText == "Intel")
                        sbCom.Append($" -c:v mpeg2video_qsv");
                    if (cmbGPU.SelectedText == "AMD")
                        sbCom.Append($" -c:v mpeg2video_amf");
                    if (cmbGPU.SelectedText == "Nvidia")
                        sbCom.Append($" -c:v mpeg2video_nvenc");
                }
            }
            if (checkBoxBitrate.Checked && txbBitrate.Text!=null)
            {
                sbCom.Append($" -b:v {txbBitrate.Text}k");
            }
            if (checkBoxFramerate.Checked)
            {
                sbCom.Append($" -r {cmbFramerate.Text}");
            }


            //音频部分
            if (chbAuFomart.Checked)
            {
                sbCom.Append($" -c:a {cbxAuFormat.Text}");

                if (chbAuBit.Checked)
                {
                    sbCom.Append($" -b:a {txbAuBit.Text}k");
                }

                if (chbAuChannel.Checked)
                {
                    sbCom.Append($" -ac {cbxAuChannel.Text}");
                }

                if (chbSampleBits.Checked)
                {
                    sbCom.Append($" s{cbxSampleBits.Text}le");
                }

                if (chbSampleRate.Checked)
                {
                    sbCom.Append($" -ar {cbxSampleRate.Text}");
                }
            }
            return sbCom.ToString();
        }
        int ProcessID;
        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = (videos[listView1.FocusedItem.Index].Duration)/1000;
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnEnd.Enabled = true;
            Process p = new Process();          

            p.StartInfo.FileName = $"{path}ffmpeg.exe";
            p.StartInfo.UseShellExecute = false;
            //输入文件地址
            string srcFileName = $"\"{listView1.FocusedItem.Text}\"";

            //探测是否已经存在同名文件，存在则改名
            StringBuilder destFileTemp = new StringBuilder($"{textBox1.Text}\\{Path.GetFileNameWithoutExtension(listView1.FocusedItem.Text)}");
            for (; File.Exists($"{destFileTemp}.{cmbFomart.Text}"); )
                destFileTemp.Append("副本");
            destFileTemp.Append($".{cmbFomart.Text}\"");

            //生成输出文件地址
            string destFileName = $"\"{destFileTemp.ToString()}";

            p.StartInfo.Arguments = $"{TimeCut()} -i {srcFileName} {Assemble()} {destFileName}";    //执行参数

            p.StartInfo.UseShellExecute = false;  ////不使用系统外壳程序启动进程
            p.StartInfo.CreateNoWindow = true;  //不显示dos程序窗口

            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;//把外部程序错误输出写到StandardError流中
            
            p.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);

            p.StartInfo.UseShellExecute = false;
            //设置异步时允许使用Exited的时间
            p.EnableRaisingEvents = true;
            //更改使用Exited事件，不阻塞，保持窗口可响应。
            p.Exited += new EventHandler(p_Exited);

            p.Start();

            ProcessID = p.Id;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            
            p.BeginErrorReadLine();//开始异步读取
            
            //p.WaitForExit();//阻塞等待进程结束

            //p.Close();//关闭进程

            //p.Dispose();//释放资源

        }
        private void p_Exited(object sender, System.EventArgs e)
        {
            SetButton();
        }
        public delegate void SetButtonCallback();
        public void SetButton()
        {
            if (progressBar1.InvokeRequired)
            {
                SetButtonCallback d = SetButton;
                Invoke(d);
            }
            else
            {
                btnStart.Enabled = true;
                btnPause.Enabled = false;
                btnEnd.Enabled = false;
            }
        }
        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string s = e.Data;
            
            Regex regex = new Regex("time=(\\d*):(\\d*):(\\d*).", RegexOptions.Compiled);
            
            if (s != null)
            {
                Match m = regex.Match(s);
                if (m.Success)
                {
                    int time = (int.Parse(m.Groups[1].Value)) * 3600 + (int.Parse(m.Groups[2].Value)) * 60 +
                               (int.Parse(m.Groups[3].Value));
                    
                    SetProgress(time);
                }
            }
        }
        public delegate void SetProcessCallback(int time);
        public void SetProgress(int time)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProcessCallback d = SetProgress;
                Invoke(d, time);
            }
            else
            {
                progressBar1.Value = time;
            }
        }


        private static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择输出路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            if (listView1.FocusedItem.Focused)
            {
                textBox1.Text = Path.GetDirectoryName(listView1.FocusedItem.Text);
                int i = listView1.FocusedItem.Index;
                TreeNode mi = new TreeNode("媒体信息");
                TreeNode vi = new TreeNode("视频信息");
                TreeNode ai = new TreeNode("音频信息");
                vi.Nodes.Add($"编码器：{videos[i].Format}");
                vi.Nodes.Add($"大小：{videos[i].Size}");
                vi.Nodes.Add($"时长：{videos[i].Duration}");
                vi.Nodes.Add($"比特率：{(videos[i].Bitrate) / 1024} kbps");
                vi.Nodes.Add($"长度：{videos[i].Width}");
                vi.Nodes.Add($"宽度：{videos[i].Height}");
                vi.Nodes.Add($"长宽比：{videos[i].Aspectratio}");
                vi.Nodes.Add($"帧率：{videos[i].Framerate}");

                ai.Nodes.Add($"声道：{videos[i].AudioChannels}");
                ai.Nodes.Add($"编码器：{videos[i].AudioCodec}");
                ai.Nodes.Add($"码率：{videos[i].AudioRate}");
                ai.Nodes.Add($"采样率：{videos[i].AudioSampleRate}");

                mi.Nodes.Add(vi);
                mi.Nodes.Add(ai);
                treeView1.Nodes.Add(mi);
                treeView1.ExpandAll();
            }
        }
        private void SetSelectedIndex(CheckBox chbTmp,ComboBox cmbTmp)
        {           
            if (chbTmp == null || cmbTmp==null) return;
            if (chbTmp.Checked)
            {
                cmbTmp.SelectedIndex = 0;
            }
            else
            {
                cmbTmp.SelectedItem = null;
            }
        }
        private void checkBoxGPU_CheckedChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            ManagementObjectSearcher objvide = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject obj in objvide.Get())
            {
                sb.Append(obj["Name"]);
            }
            string gpu=sb.ToString();
            if (gpu.Contains("Intel"))
                cmbGPU.Items.Add("Intel");
            if (gpu.Contains("AMD"))
                cmbGPU.Items.Add("AMD");
            if (gpu.Contains("Nvidia"))
                cmbGPU.Items.Add("Nvidia");
            cmbGPU.Enabled = checkBoxGPU.Checked;
            SetSelectedIndex(checkBoxGPU,cmbGPU);
        }

        private void checkBoxHXW_CheckedChanged(object sender, EventArgs e)
        {
            cmbHXW.Enabled = checkBoxHXW.Checked;
            SetSelectedIndex(checkBoxHXW,cmbHXW);
        }

        private void checkBoxFast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFast.Checked)
            {
                cmbHXW.Enabled = false;
                cmbFramerate.Enabled = false;
                cmbGPU.Enabled = false;
                txbBitrate.Enabled = false;
                checkBoxHXW.Enabled = false;
                checkBoxBitrate.Enabled = false;
                checkBoxGPU.Enabled = false;
                checkBoxFramerate.Enabled = false;
            }
            else
            {
                cmbHXW.Enabled = true;
                cmbFramerate.Enabled = true;
                cmbGPU.Enabled = true;
                txbBitrate.Enabled = true;
                checkBoxHXW.Enabled = true;
                checkBoxBitrate.Enabled = true;
                checkBoxGPU.Enabled = true;
                checkBoxFramerate.Enabled = true;
            }
        }

        private void checkBoxFramerate_CheckedChanged(object sender, EventArgs e)
        {
            cmbFramerate.Enabled = checkBoxFramerate.Checked;
            SetSelectedIndex(checkBoxFramerate,cmbFramerate);
        }

        private void checkBoxBitrate_CheckedChanged(object sender, EventArgs e)
        {
            txbBitrate.Enabled = checkBoxBitrate.Checked;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form frmPlayer=new Form2(listView1.FocusedItem.Text);
            int i = listView1.FocusedItem.Index;
            frmPlayer.SetBounds(300,300,videos[i].Width+19, videos[i].Height+132);
            frmPlayer.Show();
        }

        private void chbAuFomart_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAuFomart.Checked)
            {
                chbAuChannel.Enabled = true;
                chbAuBit.Enabled = true;
                chbSampleBits.Enabled = true;
                chbSampleRate.Enabled = true;
                cbxAuFormat.Enabled = true;
                cbxAuFormat.SelectedIndex = 0;
            }
            else
            {
                chbAuChannel.Enabled = false;
                chbAuBit.Enabled = false;
                chbSampleBits.Enabled = false;
                chbSampleRate.Enabled = false;
                cbxAuFormat.Enabled = false;
                cbxAuFormat.SelectedItem = null;
            }
        }

        private void chbAuBit_CheckedChanged(object sender, EventArgs e)
        {
            txbAuBit.Enabled = chbAuBit.Checked;
        }

        private void chbAuChannel_CheckedChanged(object sender, EventArgs e)
        {
            cbxAuChannel.Enabled = chbAuChannel.Checked;
            SetSelectedIndex(chbAuChannel,cbxAuChannel);
        }

        private void chbSampleRate_CheckedChanged(object sender, EventArgs e)
        {
            cbxSampleRate.Enabled = chbSampleRate.Checked;
            SetSelectedIndex(chbSampleRate,cbxSampleRate);
        }

        private void chbSampleBits_CheckedChanged(object sender, EventArgs e)
        {
            cbxSampleBits.Enabled = chbSampleBits.Checked;
            SetSelectedIndex(chbSampleBits,cbxSampleBits);
        }

        private void chbTimeCut_CheckedChanged(object sender, EventArgs e)
        {
            txbFH.Enabled = chbTimeCut.Checked;
            txbFM.Enabled = chbTimeCut.Checked;
            txbFS.Enabled = chbTimeCut.Checked;
            txbTH.Enabled = chbTimeCut.Checked;
            txbTM.Enabled = chbTimeCut.Checked;
            txbTS.Enabled = chbTimeCut.Checked;
        }

        private void SetMaxValue(TextBox txtTmp)
        {
            int iMax = 59;//首先设置上限值
            if (txtTmp == null || string.IsNullOrEmpty(txtTmp.Text)) return;
            if (int.TryParse(txtTmp.Text, out int res))
            {
                if (res > iMax)
                    txtTmp.Text = iMax.ToString();
            }
            else
                txtTmp.Text = string.Empty;
        }
        private void txbFH_TextChanged(object sender, EventArgs e)
        {
            SetMaxValue(sender as TextBox);
        }

        private void txbFM_TextChanged(object sender, EventArgs e)
        {
            SetMaxValue(sender as TextBox);
        }

        private void txbFS_TextChanged(object sender, EventArgs e)
        {
            SetMaxValue(sender as TextBox);
        }

        private void txbTH_TextChanged(object sender, EventArgs e)
        {
            SetMaxValue(sender as TextBox);
        }

        private void txbTM_TextChanged(object sender, EventArgs e)
        {
            SetMaxValue(sender as TextBox);
        }

        private void txbTS_TextChanged(object sender, EventArgs e)
        {
            SetMaxValue(sender as TextBox);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Process p = Process.GetProcessById(ProcessID);
            if (btnPause.Text == "暂停")
            {
                ProcessMgr.SuspendProcess(p.Id);
                btnPause.Text = "继续";
            }
            else
            {
                ProcessMgr.ResumeProcess(p.Id);
                btnPause.Text = "暂停";
            }
        }
    

        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = Process.GetProcessById(ProcessID);
                p.Kill();
                p.Close();

                btnStart.Enabled = true;
                btnPause.Enabled = false;
                btnEnd.Enabled = false;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Process p = Process.GetProcessById(ProcessID);
                p.Kill();
                p.Close();
            }
            catch
            { }
        }

        private void SetBitrate(TextBox txtTmp,bool isVideo)
        {
            int iMax;
            if(isVideo)
                iMax = 20000;
            else
                iMax = 320;
            if (txtTmp == null || string.IsNullOrEmpty(txtTmp.Text)) return;
            if (int.TryParse(txtTmp.Text, out int res))
            {
                if (res > iMax)
                    txtTmp.Text = iMax.ToString();
            }
            else
                txtTmp.Text = string.Empty;
        }
        private void txbBitrate_TextChanged(object sender, EventArgs e)
        {
            SetBitrate(sender as TextBox,true);
        }

        private void txbAuBit_TextChanged(object sender, EventArgs e)
        {
            SetBitrate(sender as TextBox,false);
        }
    }
}
