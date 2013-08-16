using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlashCrypto.Habbo.Utils;

namespace FlashCrypto
{
    public partial class wndEncoders : Form
    {
        public wndEncoders()
        {
            InitializeComponent();
        }

        private void cmdB64Str_Click(object sender, EventArgs e)
        {
            string toEncode = this.txtB64Str.Text;

            this.txtB64Str.Text = MikeUtils.encodeB64(toEncode) + toEncode;
        }

        private void cmdB64Int_Click(object sender, EventArgs e)
        {
            try
            {
                int toEncode = int.Parse(this.txtB64Int.Text);
                this.txtB64Int.Text = MikeUtils.encodeB64(toEncode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid integer entered [" + ex.Message + "]");
            }
        }

        private void wndEncoders_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void cmdWiredIntEncode_Click(object sender, EventArgs e)
        {
            try
            {
                int toEncode = int.Parse(this.txtWiredInt.Text.ToString());
                this.txtWiredInt.Text = MikeUtils.encodeVL64(toEncode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmddecodeWiredStr_Click(object sender, EventArgs e)
        {
            string data = this.txtWiredStr.Text.Trim();
            StringBuilder sb = new StringBuilder();

            if (data != null || data != String.Empty)
            {
                try
                {
                    while (data.Length != 0)
                    {

                        int val = MikeUtils.decodeVL64(data);
                        string valStr = MikeUtils.encodeVL64(val);

                        sb.Append("[" + valStr + "=" + val.ToString() + "] ");

                        data = data.Substring(valStr.Length);
                    }

                    this.txtWiredStr.Text = sb.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error decoding vl64 string. " + ex.Message);
                }
            }
        }

        private void cmdB64DecodeStr_Click(object sender, EventArgs e)
        {
            string data = this.txtB64Str.Text.Trim();

            if (data.Length < 2) { return; }

            this.txtB64Str.Text = MikeUtils.decodeB64(data.Substring(0, 2)).ToString();
        }
    }
}
