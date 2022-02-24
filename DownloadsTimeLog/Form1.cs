using System;
using System.Windows.Forms;
using DownloadsTimeLog.Class;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Globalization;

namespace DownloadsTimeLog
{
    public partial class Form1 : Form
    {
        private string url;
        private string fileName;
        private bool processFlag = false;
        private int counter;
        private int badLogTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counter = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(processFlag == true)
            {
                controlButton.Text = "Start";
                processFlag = false;
                mainTimer.Stop();
                counter = -1;
                timerCounter.Text = "process stoped";
                badLogTimeBox.Enabled = true;
                urlBox.Enabled = true;
                return;
            }
            badLogTime = Convert.ToInt32(badLogTimeBox.Text);
            errorLabel.Text = "";
            url = urlBox.Text.ToLower();
            fileName = "test.jpg";
            controlButton.Text = "Stop";
            processFlag = true;
            badLogTimeBox.Enabled = false;
            urlBox.Enabled = false;
            mainTimer.Start();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
                if (counter < 0)
                {
                    mainTimer.Stop();
                    Download(url, fileName);
                    counter = 30;
                    timerCounter.Text = counter.ToString();
                    return;
                }
                timerCounter.Text = counter.ToString();
                counter--;
        }

        private async void Download(string baseUrl, string fileName)
        {
            try
            {
                WebClient client = new WebClient();
                Stopwatch sWatch = new Stopwatch();
                sWatch.Start();
                await client.DownloadFileTaskAsync(new Uri(baseUrl), fileName);
                sWatch.Stop();
                if(sWatch.ElapsedMilliseconds > badLogTime)
                {
                    var path = Directory.GetCurrentDirectory();
                    Directory.CreateDirectory($"{path}/log/");
                    var log = new Logger($"{path}/log/badLog.txt");
                    log.Logging($"{DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} Downloaded file on" + " " + sWatch.ElapsedMilliseconds.ToString() + " ms");
                }
                else
                {
                    var path = Directory.GetCurrentDirectory();
                    var log = new Logger($"{path}/log/baseLog.txt");
                log.Logging($"{DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} Downloaded file on" + " " + sWatch.ElapsedMilliseconds.ToString() + " ms");
                }
                mainTimer.Start();
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                var path = Directory.GetCurrentDirectory();
                Directory.CreateDirectory($"{path}/log/");
                var log = new Logger($"{path}/log/errorLog.txt");
                log.Logging($"{DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} {ex.Message}");
                mainTimer.Start();
            }
        }
    }
}
