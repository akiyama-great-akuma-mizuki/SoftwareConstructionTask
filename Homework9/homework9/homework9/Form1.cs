using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace homework9
{
    public partial class Form1 : Form
    {
        private crawer crawer;
        public Form1()
        {
            InitializeComponent();
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            if (urlText.Text == "")
            {
                MessageBox.Show("请输入正确网址", "通知", MessageBoxButtons.OK);
                return;
            }
            if (WebFiliterCheck.Checked)
                crawer = new crawer(urlText.Text, WebText.Text);
            crawer = new crawer(urlText.Text);
            crawer.CrawerStatusChanged += CrawerStatusTextChange;
            await Task.Run(() => crawer.CrawlAll());
        }


        private void CrawerStatusTextChange(String info)
        {
            if (info == null)
                return;
            if (this.InfoText.InvokeRequired)
            {
                Action<String> act = this.AddInfo;
                this.Invoke(act, new object[] { info });
            }
            else
            {
                this.InfoText.AppendText(info);
            }
        }
        private void AddInfo(String info)
        {
            this.InfoText.AppendText(info);
        }



        private void WebFiliterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WebFiliterCheck.Checked)
            {
                this.webLabel.Enabled = true;
                this.WebText.Enabled = true;
            }
            else
            {
                this.webLabel.Enabled = false;
                this.WebText.Enabled = false;
            }
        }
    }
}
