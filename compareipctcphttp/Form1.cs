using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Ipc;
using System.Diagnostics;
using RemotingObjects;

namespace compareipctcphttp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //使用Http信道
        public void Http()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //MyObject myObj = (MyObject)Activator.GetObject(typeof(MyObject), "http://localhost:9001/MyObject");
            IPerson obj = (IPerson)Activator.GetObject(typeof(RemotingObjects.IPerson), "http://localhost:9001/RemotingPersonService");
            // myObj.GetServerTime();
            obj.getName("wwwwwwwwwwwwwwwwwwwwwww");
            stopWatch.Stop();
            lsbHttp.Items.Add(stopWatch.ElapsedTicks);
        }
        //使用Tcp信道
        public void Tcp()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //MyObject myObj = (MyObject)Activator.GetObject(typeof(MyObject), "http://localhost:9001/MyObject");
            IPerson obj = (IPerson)Activator.GetObject(typeof(RemotingObjects.IPerson), "tcp://localhost:9002/RemotingPersonService");
            // myObj.GetServerTime();
            obj.getName("wwwwwwwwwwwwwwwwwwwwwww");
            stopWatch.Stop();
            lsbTcp.Items.Add(stopWatch.ElapsedTicks);
        }
        //使用Ipc信道
        public void Ipc()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            IPerson obj = (IPerson)Activator.GetObject(typeof(RemotingObjects.IPerson), "Ipc://MyHost/RemotingPersonService");
            obj.getName("wwwwwwwwwwwwwwwwwwwwwww");
            stopWatch.Stop();
            lsbIpc.Items.Add(stopWatch.ElapsedTicks);
        }

        //访问Web Service
        //public void WebService()
        //{
        //    Stopwatch stopWatch = new Stopwatch();
        //    stopWatch.Start();
        //    localhost.Service ws = new localhost.Service();
        //    ws.GetServerTime();
        //    stopWatch.Stop();
        //    lsbWeb.Items.Add(stopWatch.ElapsedTicks);
        //}
        private void btnHttp_Click(object sender, EventArgs e)
        {
            Http();
        }

        private void btnTcp_Click(object sender, EventArgs e)
        {
            Tcp();
        }

        //private void btnWebService_Click(object sender, EventArgs e)
        //{
        //    WebService();
        //}

        private void btnIpc_Click(object sender, EventArgs e)
        {
            Ipc();
        }

        //开始测试
        private void btnStat_Click(object sender, EventArgs e)
        {
            Int32 Times = int.Parse(txtTimes.Text);
            Int64 Sum = 0;
            double Ave = 0;
            lsbHttp.Items.Clear();
            lsbIpc.Items.Clear();
            lsbTcp.Items.Clear();
            //lsbWeb.Items.Clear();

            for (Int32 i = 0; i < Times; i++)
            {
                Http();
                Tcp();
                Ipc();
               // WebService();
            }
            //计算平均时间
            for (Int32 i = 0; i < Times; i++)
            {
                Sum += int.Parse(lsbHttp.Items[i].ToString());
            }
            Ave = Sum / Times;
            txtHttp.Text = Ave.ToString();

            Sum = 0;
            for (Int32 i = 0; i < Times; i++)
            {
                Sum += int.Parse(lsbTcp.Items[i].ToString());
            }
            Ave = Sum / Times;
            txtTcp.Text = Ave.ToString();

            Sum = 0;
            //for (Int32 i = 0; i < Times; i++)
            //{
            //    Sum += int.Parse(lsbWeb.Items[i].ToString());
            //}
            //Ave = Sum / Times;
            //txtWebService.Text = Ave.ToString();

            Sum = 0;
            for (Int32 i = 0; i < Times; i++)
            {
                Sum += int.Parse(lsbIpc.Items[i].ToString());
            }
            Ave = Sum / Times;
            txtIpc.Text = Ave.ToString();
        }
       
    }
}
