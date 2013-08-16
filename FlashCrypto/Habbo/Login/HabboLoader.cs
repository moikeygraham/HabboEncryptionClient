using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace FlashCrypto.Habbo.Login
{
    public class HabboLoader
    {
        public static bool SplitLoader(string source)
        {
            LemonEnvironment.props = new PropBox();

            string tmp = "";
			
			tmp = source.Substring(source.IndexOf("\"connection.info.host\" : \"") + "\"connection.info.host\" : \"".Length);
			tmp = tmp.Split('\"')[0];
			LemonEnvironment.props.InfoHost = tmp;
			
			tmp = source.Substring(source.IndexOf("\"connection.info.port\" : \"") + "\"connection.info.port\" : \"".Length);
			tmp = tmp.Split('\"')[0];
			LemonEnvironment.props.InfoPort = int.Parse(tmp.Split(',')[0]);
			
			tmp = source.Substring(source.IndexOf("\"sso.ticket\" : \"") + "\"sso.ticket\" : \"".Length);
			tmp = tmp.Split('\"')[0];
			LemonEnvironment.props.SSOTicket = tmp;
            LemonEnvironment.mainWnd.SetSSOTicket(tmp);
			
			tmp = source.Substring(source.IndexOf("\"flash.client.url\" : \"") + "\"flash.client.url\" : \"".Length);
			tmp = tmp.Split('\"')[0];
			LemonEnvironment.props.FlashUrl = tmp;
            LemonEnvironment.mainWnd.SetFlashVersion(tmp);

            tmp = source.Substring(source.IndexOf("\"external.variables.txt\" : \"") + "\"external.variables.txt\" : \"".Length);
			tmp = tmp.Split('\"')[0];
			LemonEnvironment.props.ExternalVars = tmp;

            StreamWriter stream = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\client.html");
            
            source = source.Replace(LemonEnvironment.props.InfoHost, "game-xx.habbo.com");
            source = source.Replace("<meta http-equiv=\"refresh\" content=\"0;url=/client/nojs\" />", "");
            source = source.Replace("<p>If you are not automatically redirected, please <a href=\"/client/nojs\">click here</a></p>", "");
            stream.WriteLine(source);
            
            stream.Close();

            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = "file:///" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\client.html";
            browser.Start();

            LemonEnvironment.tcp = new Tcp.TcpManager();
            LemonEnvironment.tcp.init();

            return true;
        }
    }
}
