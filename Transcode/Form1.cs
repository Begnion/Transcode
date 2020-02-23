using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            }
        }
        public int GetInfo(string videoPath)
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
            //Process p = new Process();

            //p.StartInfo.FileName = path + "ffmpeg.exe";
            //p.StartInfo.UseShellExecute = false;
            //string srcFileName = listView1.FocusedItem.Text;

            //p.StartInfo.Arguments = "-i " + srcFileName;    //执行参数

            //p.StartInfo.UseShellExecute = false;  ////不使用系统外壳程序启动进程
            //p.StartInfo.CreateNoWindow = true;  //不显示dos程序窗口
            //p.StartInfo.RedirectStandardOutput = true;

            //p.Start();
            //p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //string output = p.StandardOutput.ReadToEnd();

            //p.WaitForExit();//阻塞等待进程结束
            //p.Close();//关闭进程
            //p.Dispose();//释放资源
            //try
            //{
            //    ProcessBuilder builder = new ProcessBuilder();
            //    builder.command(commands);
            //    final Processp = builder.start();

            //    //从输入流中读取视频信息  
            //    BufferedReader br = new BufferedReader(new InputStreamReader(p.getErrorStream()));
            //    StringBuffer sb = new StringBuffer();
            //    String line = "";
            //    while ((line = br.readLine()) != null)
            //    {
            //        sb.append(line);
            //    }
            //    br.close();

            //    //从视频信息中解析时长  
            //    String regexDuration = "Duration: (.*?), start: (.*?), bitrate: (\\d*) kb\\/s";
            //    Pattern pattern = Pattern.compile(regexDuration);
            //    Matcher m = pattern.matcher(sb.toString());
            //    if (m.find())
            //    {
            //        int time = getTimelen(m.group(1));
            //        log.info(video_path + ",视频时长：" + time + ", 开始时间：" + m.group(2) + ",比特率：" + m.group(3) + "kb/s");
            //        return time;
            //    }
            //}
            //catch (Exception e)
            //{
            //    e.printStackTrace();
            //}

            return 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
        }

        string Assembly()
        {
            string com = "";
            if(checkBoxFast.Checked)
            {
                return "-c copy";
            }
            else
            {
                if (checkBoxBitrate.Checked)
                {
                    com += $" -b:v {txbBitrate}k ";
                }
                if (checkBoxFramerate.Checked)
                {
                    com += $" -r {cmbFramerate} ";
                }
                if (checkBoxHXW.Checked)
                {
                    com += $" -r {cmbFramerate} ";
                }
                if (checkBoxGPU.Checked)
                {
                    com += $" -r {cmbFramerate} ";
                }
                return com;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = $"{path}ffmpeg.exe";
            p.StartInfo.UseShellExecute = false;
            string srcFileName = listView1.FocusedItem.Text;
            string destFileName = $"{textBox1.Text}{Path.GetFileNameWithoutExtension(listView1.FocusedItem.Text)}{cmbFomart.Text}";

            p.StartInfo.Arguments = $"-i {srcFileName} {Assembly()} {destFileName}";    //执行参数

            p.StartInfo.UseShellExecute = false;  ////不使用系统外壳程序启动进程
            p.StartInfo.CreateNoWindow = true;  //不显示dos程序窗口

            p.StartInfo.RedirectStandardInput = true;

            p.StartInfo.RedirectStandardOutput = true;

            p.StartInfo.RedirectStandardError = true;//把外部程序错误输出写到StandardError流中

            p.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);

            p.StartInfo.UseShellExecute = false;

            p.Start();

            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.BeginErrorReadLine();//开始异步读取

            p.WaitForExit();//阻塞等待进程结束

            p.Close();//关闭进程

            p.Dispose();//释放资源
        }
        private static void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
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
            textBox1.Text = Path.GetDirectoryName(listView1.FocusedItem.Text);
            int i = listView1.FocusedItem.Index;
            TreeNode mi = new TreeNode("媒体信息");
            TreeNode vi = new TreeNode("视频信息");
            TreeNode ai = new TreeNode("音频信息");
            vi.Nodes.Add($"编码器：{videos[i].Format}");
            vi.Nodes.Add($"大小：{videos[i].Size}");
            vi.Nodes.Add($"时长：{videos[i].Duration}");
            vi.Nodes.Add($"比特率：{videos[i].Bitrate}");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGPU.Checked)
                cmbGPU.Enabled = true;
            else
                cmbGPU.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHXW.Checked)
                cmbHXW.Enabled = true;
            else
                cmbHXW.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFast.Checked)
            {
                cmbHXW.Enabled = false;
                cmbFomart.Enabled = false;
                cmbFramerate.Enabled = false;
                cmbGPU.Enabled = false;
                txbBitrate.Enabled = false;
            }
            else
            {
                cmbHXW.Enabled = true;
                cmbFomart.Enabled = true;
                cmbFramerate.Enabled = true;
                cmbGPU.Enabled = true;
                txbBitrate.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFramerate.Checked)
                cmbFramerate.Enabled = true;
            else
                cmbFramerate.Enabled = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBitrate.Checked)
                txbBitrate.Enabled = true;
            else
                txbBitrate.Enabled = false;


        }
    }
}
