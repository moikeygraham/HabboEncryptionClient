using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;

namespace FlashCrypto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new wndLogin());
            Application.Run(new wndSplash());
        }

        public static void checkTrustedFlash()
        {
            string flashPlayerDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + '\\' + "Macromedia" + '\\' + "Flash Player";

            if (!Directory.Exists(flashPlayerDir))
            {
                MessageBox.Show("You don't have flash installed on your system, or you are not running a recent Operating System.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }

            flashPlayerDir += '\\' + "#Security" + '\\' + "FlashPlayerTrust";

            if (!Directory.Exists(flashPlayerDir)) { Directory.CreateDirectory(flashPlayerDir); }

            flashPlayerDir += '\\' + "crypto.trust.cfg";

            if (File.Exists(flashPlayerDir)) { return; }

            using (StreamWriter sw = new StreamWriter(flashPlayerDir))
            {
                sw.Write(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }

            MessageBox.Show("If your default browser is open, please close it as the FlashPlayerTrust file has been modified to allow launching of client.html locally. (If you get a security sandbox violation it means you havn't restarted your browser!)");
        }

        public static void checkHosts()
        {
            // check hosts file
            string hostsFile = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\system32\\drivers\\etc\\hosts";

            foreach (string line in File.ReadAllLines(hostsFile))
            {
                if (line.Contains("game-xx.habbo.com"))
                {
                    return;
                }
            }

            DialogResult userInput = MessageBox.Show("We need to add a hosts entry to your hosts file ('" + hostsFile + "'). If you don't have enough system priviledges, this will fail; resulting in the application not functioning. Okay to proceed?", "The journey begins...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (userInput == DialogResult.No)
            {
                Environment.Exit(0);
            }

            File.AppendAllText(hostsFile, "\r\n127.0.0.1\tgame-xx.habbo.com");
        }
    }
}
