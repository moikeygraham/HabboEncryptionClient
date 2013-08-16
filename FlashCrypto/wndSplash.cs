using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FlashCrypto
{
    public partial class wndSplash : Form
    {
        int tickCount = 5;

        public wndSplash()
        {
            InitializeComponent();
        }

        private void wndSplash_Load(object sender, EventArgs e)
        {
            this.lblV.Text = LemonEnvironment.version;
        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            if (this.tickCount > 0)
            {
                this.cmdContinue.Text = (this.tickCount--).ToString();
            }
            else
            {
                this.cmdContinue.Text = "Continue";
                this.cmdContinue.Enabled = true;
                this.tmrCount.Enabled = false;
            }
        }

        private void cmdDonate_Click(object sender, EventArgs e)
        {
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=NVVWHXRDUZ9LC";
            browser.Start();
        }

        private void cmdContinue_Click(object sender, EventArgs e)
        {
            Program.checkHosts();
            Program.checkTrustedFlash();

            LemonEnvironment.proxy = new Habbo.Proxy.BannerProxy();
            LemonEnvironment.proxy.startup();

            new wndLogin().Show();
            this.Hide();
        }

        private void wndSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
