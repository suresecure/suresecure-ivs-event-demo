using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using Suresecureivs;
using Grpc.Core;
using System.Threading;
using SRZNPlatTest.GRPCServ;
using System.Threading.Tasks;

namespace SRZNPlatTest
{
    public partial class Form1 : DevComponents.DotNetBar.OfficeForm
    {
        public Form1()
        {
            InitializeComponent();
            InitializeRPC();
        }

        #region 模拟设备发送报警事件
        DateTime dtStart = DateTime.Now;
        DateTime dtEnd = DateTime.Now;
        // RPC ChannelOption
        private List<ChannelOption> options = null;
        // RPC Channel
        private Channel channel = null;
        // pictureData
        private byte[] imgData = null;
        // 发送总量
        private int SendCnt = 0;
        //已发送
        private int sentCnt = 0;
        //已完成
        private int cplCnt = 0;
        //发送间隔
        private int interval = 500;
        private List<SendRecord> records = new List<SendRecord>();

        private void InitializeRPC()
        {
            options = new List<ChannelOption>() { new ChannelOption(ChannelOptions.MaxMessageLength, int.MaxValue) };
            channel = new Channel(ipiptServer.Text.Trim() + ":" + txtServerPort.Text.Trim(), ChannelCredentials.Insecure, options);
        }

        private void SendAlarm()
        {
            SendCnt = 1;
            sentCnt = 0;
            cplCnt = 0;
            labelX11.Text = "";
            lbSendStatus.Text = "";
            
            interval = 500;
            records.Clear();
            try
            {
                //发送数量
                SendCnt = Convert.ToInt32(txtSendCnt.Text);
                //发送间隔
                interval = Convert.ToInt32(txtInterval.Text);

                string svrIp = ipiptServer.Text.Trim();
                string svrPort = txtServerPort.Text.Trim();

                //读取图片数据
                string imageFullName = picImage.Tag.ToString();
                if (File.Exists(imageFullName))
                {
                    imgData = File.ReadAllBytes(imageFullName);
                }

                channel = new Channel(svrIp + ":" + svrPort, ChannelCredentials.Insecure, options);
                dtStart = DateTime.Now;
                btnDetail.Enabled = false;
                Thread th = new Thread(new ThreadStart(delegate () {
                    for (int i=0; i < SendCnt; i++)
                    {
                        Interlocked.Increment(ref sentCnt);
                        if ((interval < 100 && sentCnt % 10 == 0) || interval >= 100 || sentCnt == SendCnt)
                        {
                            this.Invoke(new Action(() =>
                            {
                                labelX11.Text = string.Format("已发送：{0}", sentCnt);
                            }));
                        }

                        Thread thsub = new Thread(new ThreadStart(SendAlarmSub));
                        thsub.Start();
                        Thread.Sleep(interval);
                    }
                    dtEnd = DateTime.Now;
                    channel.ShutdownAsync();
                }));
                th.Start();
            }
            catch (Exception exp)
            {
                Logger.AddLog(this.GetType(), "SendAlarm()", "", exp);
            }
        }

        private void SendAlarmSub()
        {
            try
            {
                SendRecord record = new SendRecord();
                record.GUID = Guid.NewGuid().ToString();
                record.BeginTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");

                var client = new SurvCenterService.SurvCenterServiceClient(channel);
                Event nevent = new Event();
                nevent.DeviceIdent = txtHostIdent.Text;
                nevent.VideoFilename = "testVideoFile.wav";
                nevent.Channel = Convert.ToInt32(txtChannel.Text);
                nevent.FrontendVersion = "Ver1.0";
                nevent.Guid = Guid.NewGuid().ToString();
                nevent.Hostaddress = ipIptHost.Text;
                nevent.MeterAreaNum = 1;
                nevent.PersonNum = Convert.ToInt32(txtPersonCnt.Text);
                nevent.Seconds = DateTimeToLong(DateTime.Now);
                nevent.Type = Convert.ToInt32(txtAlarmType.Text);
                nevent.Description = txtDescription.Text;

                AnnotatedImage anno_img = new AnnotatedImage();
                anno_img.Img = Google.Protobuf.ByteString.CopyFrom(imgData);

                nevent.AnnoImgs.Add(anno_img);
                var reply = client.ReportEvent(nevent);
                Interlocked.Increment(ref cplCnt);
                record.CompleteTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                record.Message = reply.Message;
                record.ErrCode = reply.ErrorCode;
                records.Add(record);

                if ((interval < 100 && cplCnt % 10 == 0) || interval >= 100 || cplCnt == SendCnt)
                {
                    this.Invoke(new Action(() =>
                    {
                        lbSendStatus.Text = string.Format("已完成：{0}", cplCnt);
                        if (cplCnt >= SendCnt)
                        {
                            btnDetail.Enabled = true;
                        }
                    }));
                }
            }
            catch (Exception exp)
            {
                Logger.AddLog(this.GetType(), "SendAlarmSub()", "", exp);
            }
        }

        #endregion

        #region 模拟客户端接收报警事件

        private Server server = null;

        /// <summary>
        /// 启动设备服务
        /// </summary>
        /// <returns></returns>
        public bool Start(int listenPort = 8000)
        {
            try
            {
                if (server == null)
                {
                    ImplSurvCenterService alarmEvtImpl = new ImplSurvCenterService();
                    alarmEvtImpl.OnNewEvent += AlarmEvtImpl_OnNewEvent;
                    alarmEvtImpl.OnHeartBeat += AlarmEvtImpl_OnHeartBeat;

                    server = new Server
                    {
                        Services = { SurvCenterService.BindService(alarmEvtImpl) },
                        Ports = { new ServerPort("0.0.0.0", listenPort, ServerCredentials.Insecure) }
                    };
                }
                server.Start();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        private void AlarmEvtImpl_OnNewEvent(Event obj)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (listView1.Items.Count > 500)
                    listView1.Items.RemoveAt(0);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = obj.Guid;
                lvi.SubItems.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                lvi.SubItems.Add(obj.Hostaddress);
                lvi.SubItems.Add(obj.Channel.ToString());
                lvi.SubItems.Add(obj.Type.ToString());
                listView1.Items.Add(lvi);
            }));
        }

        //心跳事件
        private async void AlarmEvtImpl_OnHeartBeat(HeartbeatRequest request)
        {
            try
            {
                
            }
            catch (Exception exp)
            {
            }
        }

        #endregion

        #region datetime<=>long  转换

        /// <summary>
        /// 毫秒转换成DateTime
        /// </summary>
        /// <param name="times"></param>
        /// <returns></returns>
        public static DateTime LongToDateTime(long times)
        {
            try
            {
                // 0001/1/1 0:0:0
                DateTime dt1 = new DateTime(1, 1, 1, 0, 0, 0);

                // 1970/1/1/ 0:0:0
                DateTime dt2 = new DateTime(1970, 1, 1, 0, 0, 0);
                TimeSpan span = dt2 - dt1;

                //计算1970/1/1 0:0:0 与 0001/1/1 0:0:0 之间相差多少个100纳秒
                long dtSpan = (long)span.TotalMilliseconds * 1000 * 1000 / 100;

                //计算1970/1/1 0:0:0 与 当前日期之间相差多少个100纳秒
                long ltime = times * 1000 * 1000 / 100;

                //转换后的最终时间
                DateTime dtTime = new DateTime(dtSpan + ltime);
                return dtTime;
            }
            catch
            {
                return default(DateTime);
            }
        }


        public static long DateTimeToLong(DateTime dt)
        {
            try
            {
                DateTime dt1 = new DateTime(1, 1, 1, 0, 0, 0);
                DateTime dt2 = new DateTime(1970, 1, 1, 0, 0, 0);
                long span1 = (long)((dt - dt1).TotalMilliseconds);
                long span2 = (long)((dt2 - dt1).TotalMilliseconds);
                long result = span1 - span2;
                return result;
            }
            catch
            {
                return 0;
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendAlarm();
        }

        private void btnRegist1_Click(object sender, EventArgs e)
        {
            Start(Convert.ToInt32(textBoxX1.Text));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.RestoreDirectory = true;
                dialog.Filter = "ALL|*.jpeg;*.jpg;*.bmp|JPEG|*.jpeg|JPG|*.jpg|BMP|*.bmp";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = dialog.FileName;
                    Image img = Image.FromFile(fileName);
                    picImage.Image = new Bitmap(img);
                    img.Dispose();
                    picImage.Tag = fileName;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message,"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        FormImage imgForm = null;
        private void dgvAlarms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (imgForm == null || imgForm.IsDisposed)
            {
                imgForm = new FormImage();
                imgForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            }
            imgForm.Show();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (imgForm == null || imgForm.IsDisposed)
            {
                imgForm = new FormImage();
            }
            imgForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FormDetail frmDetail = new FormDetail(dtStart,dtEnd, records);
            frmDetail.ShowDialog();
        }

        private void btnRegist2_Click(object sender, EventArgs e)
        {

        }
    }
}