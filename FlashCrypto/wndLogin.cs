using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace FlashCrypto
{
    public partial class wndLogin : Form
    {
        public delegate void _BoolToControl(bool val);

        public _BoolToControl EnableLoginButton;
        public _BoolToControl ShowMainWnd;

        public wndLogin()
        {
            InitializeComponent();

            LemonEnvironment.loginWnd = this;

            EnableLoginButton = new _BoolToControl(this.Enablelogin);
            ShowMainWnd = new _BoolToControl(this.showMainWnd);
        }

        private void showMainWnd(bool val)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(this.ShowMainWnd, val);
                }
                else
                {
                    LemonEnvironment.mainWnd.Show();
                    this.Hide();
                }
            }
            catch { }
        }

        private void Enablelogin(bool val)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(this.EnableLoginButton, val);
                }
                else
                {
                    this.cmdLogin.Enabled = val;
                }
            }
            catch { }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (LemonEnvironment.mainWnd == null)
            {
                LemonEnvironment.mainWnd = new wndMain();
            }

            // do some checks
            if (this.txtMail.Text == String.Empty || this.txtPass.Text == String.Empty || this.txtHotel.Text == String.Empty)
            {
                MessageBox.Show("Please fill out all appropriate fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.txtMail.Text.Contains("@"))
            {
                MessageBox.Show("Make sure email is correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.cmdLogin.Enabled = false;

            switch (this.txtHotel.Text)
            {
                case "com":
                    LemonEnvironment.hotel = "us";
                    break;

                case "com.br":
                    LemonEnvironment.hotel = "br";
                    break;

                default:
                    LemonEnvironment.hotel = this.txtHotel.Text;
                    break;
            }

            LemonEnvironment.loginInstance = new Habbo.Login.HabboLogin(this.txtHotel.Text, this.txtMail.Text, this.txtPass.Text);
            LemonEnvironment.mainWnd.SetHabboID(this.txtMail.Text);
        }

        private void wndLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LemonEnvironment.proxy.IsAttatched)
                LemonEnvironment.proxy.detatch();

            Environment.Exit(0);
        }
    }
}
