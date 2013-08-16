using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlashCrypto.Habbo.Login;
using FlashCrypto.Habbo.Tcp;
using System.Threading;
using FlashCrypto.Habbo.Crypto;
using FlashCrypto.Habbo.Proxy;

namespace FlashCrypto
{
    public static class LemonEnvironment
    {
        public static string version = "1.1.0";

        public static HabboLogin loginInstance;
        public static PropBox props;
        public static TcpManager tcp;
        public static BannerProxy proxy;

        public static wndLogin loginWnd;
        public static wndMain mainWnd;
        public static wndEncoders encodersWnd;

        public static string clientSource = null;
        public static string habboID = null;
        public static string hotel = null;

        public static bool cryptoActive = false;

        public static string token = null;

        public static string serverKey = null;
        public static string clientKey = null;

        public static string decPublicKey = null;
        public static string encPublicKey = null;

        public static string sharedKeyEnc = null;
        public static string sharedKeyDec = null;

        public static bool proxiedBanner = false;
        public static string bannerDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("\\", "\\\\") + "\\banner.png";

        public static MikeCrypto RC4D = null;
        public static MikeCrypto RC4E = null;

        public static PaddingGenerator padding1;
        public static PaddingGenerator padding2;
    }
}
