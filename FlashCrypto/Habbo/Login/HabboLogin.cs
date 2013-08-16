using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using FlashCrypto.Habbo.Utils;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Web;

namespace FlashCrypto.Habbo.Login
{
    public class HabboLogin
    {
        private string url = null;
        private string redirectUrl = null;
        private string hotel = null;

        private const string userAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";
        private const string acceptType = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        private const string contentType = "application/x-www-form-urlencoded";

        private string email = null;
        private string password = null;

        private string JSESSIONID = null;
        private string SETCOOKIE = null;

        private string clientSource = null;

        Thread loginThread;

        public HabboLogin(string hotel, string mail, string pass)
        {
            this.url = "https://www.habbo." + hotel + "/account/submit";
            this.redirectUrl = "https://www.habbo." + hotel + "/identity/useOrCreateAvatar";
            this.hotel = hotel;

            // Account for special characters (people with symbols, other charsets e.g spain!)
            this.email = HttpUtility.UrlEncodeUnicode(mail);
            this.password = HttpUtility.UrlEncodeUnicode(pass);

            this.JSESSIONID = MikeUtils.GenerateRandom() + ".resin-fe-6";   // hax

            this.loginThread = new Thread(new ThreadStart(this.start));
            this.loginThread.Start();
        }

        private void getRedirect()
        {
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.Cookie, SETCOOKIE);

            string result = wc.DownloadString(redirectUrl);

            if (result != null)
            {
                this.getClient();
            }
        }

        private void getClient()
        {
            // Time to get the client.
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.Cookie, SETCOOKIE);

            this.clientSource = wc.DownloadString("http://www.habbo." + this.hotel + "/client");

            while (this.clientSource == null) ;

            if (this.clientSource.Contains("sso.ticket"))
            {
                LemonEnvironment.loginWnd.ShowMainWnd(true);

                LemonEnvironment.clientSource = this.clientSource;
                HabboLoader.SplitLoader(clientSource);
            }
            else
            {
                MessageBox.Show("Login failed!", "Failed login attempt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LemonEnvironment.loginWnd.EnableLoginButton(true);
            }
        }

        public void start()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

            byte[] postData = Encoding.ASCII.GetBytes("credentials.username=" + this.email + "&credentials.password=" + this.password);

            request.Method = "POST";
            request.Accept = acceptType;
            request.ContentType = contentType;
            request.UserAgent = userAgent;
            request.ContentLength = postData.Length;
            request.AllowAutoRedirect = true;
            request.Headers.Add("Cookie: " + JSESSIONID);

            Stream dataWriter = request.GetRequestStream();
            dataWriter.Write(postData, 0, postData.Length);
            dataWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            
            string redirectPage = sr.ReadToEnd();

            SETCOOKIE = response.Headers["Set-Cookie"].ToString();

            response.Close();

            this.getRedirect();
        }
    }
}
