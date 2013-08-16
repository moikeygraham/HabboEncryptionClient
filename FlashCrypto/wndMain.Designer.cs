namespace FlashCrypto
{
    partial class wndMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.windowPacketloggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCrypto = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblClientConnected = new System.Windows.Forms.Label();
            this.lblServerConnected = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSSO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSWFVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDonate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdEncoders = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.cmdSendClient = new System.Windows.Forms.Button();
            this.cmdSendServer = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmdClientClear = new System.Windows.Forms.Button();
            this.chkClientPause = new System.Windows.Forms.CheckBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdServerClear = new System.Windows.Forms.Button();
            this.chkServerPause = new System.Windows.Forms.CheckBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.haxMovie = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.diagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.haxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosticsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stayOnTopToolStripMenuItem,
            this.toolStripMenuItem1,
            this.windowPacketloggerToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // stayOnTopToolStripMenuItem
            // 
            this.stayOnTopToolStripMenuItem.CheckOnClick = true;
            this.stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            this.stayOnTopToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.stayOnTopToolStripMenuItem.Text = "Stay on top";
            this.stayOnTopToolStripMenuItem.Click += new System.EventHandler(this.stayOnTopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // windowPacketloggerToolStripMenuItem
            // 
            this.windowPacketloggerToolStripMenuItem.Enabled = false;
            this.windowPacketloggerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("windowPacketloggerToolStripMenuItem.Image")));
            this.windowPacketloggerToolStripMenuItem.Name = "windowPacketloggerToolStripMenuItem";
            this.windowPacketloggerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.windowPacketloggerToolStripMenuItem.Text = "Window Packetlogger";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 402);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCrypto);
            this.groupBox3.Controls.Add(this.lblOut);
            this.groupBox3.Controls.Add(this.lblIn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblClientConnected);
            this.groupBox3.Controls.Add(this.lblServerConnected);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(369, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Socket Info";
            // 
            // lblCrypto
            // 
            this.lblCrypto.AutoSize = true;
            this.lblCrypto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrypto.ForeColor = System.Drawing.Color.Black;
            this.lblCrypto.Location = new System.Drawing.Point(67, 112);
            this.lblCrypto.Name = "lblCrypto";
            this.lblCrypto.Size = new System.Drawing.Size(22, 13);
            this.lblCrypto.TabIndex = 10;
            this.lblCrypto.Text = "off";
            // 
            // lblOut
            // 
            this.lblOut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.ForeColor = System.Drawing.Color.Black;
            this.lblOut.Location = new System.Drawing.Point(46, 90);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(90, 13);
            this.lblOut.TabIndex = 9;
            this.lblOut.Text = "0 k/b";
            // 
            // lblIn
            // 
            this.lblIn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.ForeColor = System.Drawing.Color.Black;
            this.lblIn.Location = new System.Drawing.Point(46, 71);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(90, 13);
            this.lblIn.TabIndex = 8;
            this.lblIn.Text = "0 k/b";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Crypto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Out:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "In:";
            // 
            // lblClientConnected
            // 
            this.lblClientConnected.AutoSize = true;
            this.lblClientConnected.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientConnected.ForeColor = System.Drawing.Color.DarkRed;
            this.lblClientConnected.Location = new System.Drawing.Point(63, 21);
            this.lblClientConnected.Name = "lblClientConnected";
            this.lblClientConnected.Size = new System.Drawing.Size(72, 12);
            this.lblClientConnected.TabIndex = 4;
            this.lblClientConnected.Text = "disconnected";
            // 
            // lblServerConnected
            // 
            this.lblServerConnected.AutoSize = true;
            this.lblServerConnected.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerConnected.ForeColor = System.Drawing.Color.DarkRed;
            this.lblServerConnected.Location = new System.Drawing.Point(63, 43);
            this.lblServerConnected.Name = "lblServerConnected";
            this.lblServerConnected.Size = new System.Drawing.Size(72, 12);
            this.lblServerConnected.TabIndex = 3;
            this.lblServerConnected.Text = "disconnected";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(5, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 2);
            this.label7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Server:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Client:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSSO);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSWFVersion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(9, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session info:";
            // 
            // txtSSO
            // 
            this.txtSSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSO.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSO.Location = new System.Drawing.Point(86, 61);
            this.txtSSO.Name = "txtSSO";
            this.txtSSO.ReadOnly = true;
            this.txtSSO.Size = new System.Drawing.Size(261, 21);
            this.txtSSO.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SSOTicket:";
            // 
            // txtSWFVersion
            // 
            this.txtSWFVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWFVersion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSWFVersion.Location = new System.Drawing.Point(86, 90);
            this.txtSWFVersion.Name = "txtSWFVersion";
            this.txtSWFVersion.ReadOnly = true;
            this.txtSWFVersion.Size = new System.Drawing.Size(261, 21);
            this.txtSWFVersion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SWF Ver:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(86, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(261, 21);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "HabboID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDonate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please consider donating!!";
            // 
            // cmdDonate
            // 
            this.cmdDonate.Image = ((System.Drawing.Image)(resources.GetObject("cmdDonate.Image")));
            this.cmdDonate.Location = new System.Drawing.Point(158, 160);
            this.cmdDonate.Name = "cmdDonate";
            this.cmdDonate.Size = new System.Drawing.Size(177, 57);
            this.cmdDonate.TabIndex = 1;
            this.cmdDonate.UseVisualStyleBackColor = true;
            this.cmdDonate.Click += new System.EventHandler(this.cmdDonate_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 142);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdEncoders);
            this.tabPage2.Controls.Add(this.txtSend);
            this.tabPage2.Controls.Add(this.cmdSendClient);
            this.tabPage2.Controls.Add(this.cmdSendServer);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Packets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdEncoders
            // 
            this.cmdEncoders.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncoders.Location = new System.Drawing.Point(428, 347);
            this.cmdEncoders.Name = "cmdEncoders";
            this.cmdEncoders.Size = new System.Drawing.Size(85, 23);
            this.cmdEncoders.TabIndex = 6;
            this.cmdEncoders.Text = "Encoders";
            this.cmdEncoders.UseVisualStyleBackColor = true;
            this.cmdEncoders.Click += new System.EventHandler(this.cmdEncoders_Click);
            // 
            // txtSend
            // 
            this.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(108, 313);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(313, 57);
            this.txtSend.TabIndex = 4;
            this.txtSend.Text = "@t@mwww.script-o-matic.net - be generous; DONATE!I";
            // 
            // cmdSendClient
            // 
            this.cmdSendClient.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSendClient.Location = new System.Drawing.Point(8, 342);
            this.cmdSendClient.Name = "cmdSendClient";
            this.cmdSendClient.Size = new System.Drawing.Size(95, 28);
            this.cmdSendClient.TabIndex = 3;
            this.cmdSendClient.Text = "Send to Client";
            this.cmdSendClient.UseVisualStyleBackColor = true;
            this.cmdSendClient.Click += new System.EventHandler(this.cmdSendClient_Click);
            // 
            // cmdSendServer
            // 
            this.cmdSendServer.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSendServer.Location = new System.Drawing.Point(8, 313);
            this.cmdSendServer.Name = "cmdSendServer";
            this.cmdSendServer.Size = new System.Drawing.Size(95, 30);
            this.cmdSendServer.TabIndex = 2;
            this.cmdSendServer.Text = "Send to Server";
            this.cmdSendServer.UseVisualStyleBackColor = true;
            this.cmdSendServer.Click += new System.EventHandler(this.cmdSendServer_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmdClientClear);
            this.groupBox5.Controls.Add(this.chkClientPause);
            this.groupBox5.Controls.Add(this.txtClient);
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(265, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 301);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Client";
            // 
            // cmdClientClear
            // 
            this.cmdClientClear.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientClear.Location = new System.Drawing.Point(167, 274);
            this.cmdClientClear.Name = "cmdClientClear";
            this.cmdClientClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClientClear.TabIndex = 3;
            this.cmdClientClear.Text = "Clear";
            this.cmdClientClear.UseVisualStyleBackColor = true;
            this.cmdClientClear.Click += new System.EventHandler(this.cmdClientClear_Click);
            // 
            // chkClientPause
            // 
            this.chkClientPause.AutoSize = true;
            this.chkClientPause.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClientPause.Location = new System.Drawing.Point(7, 278);
            this.chkClientPause.Name = "chkClientPause";
            this.chkClientPause.Size = new System.Drawing.Size(55, 16);
            this.chkClientPause.TabIndex = 2;
            this.chkClientPause.Text = "Pause";
            this.chkClientPause.UseVisualStyleBackColor = true;
            // 
            // txtClient
            // 
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(6, 20);
            this.txtClient.Multiline = true;
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtClient.Size = new System.Drawing.Size(236, 252);
            this.txtClient.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdServerClear);
            this.groupBox4.Controls.Add(this.chkServerPause);
            this.groupBox4.Controls.Add(this.txtServer);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 301);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server";
            // 
            // cmdServerClear
            // 
            this.cmdServerClear.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdServerClear.Location = new System.Drawing.Point(167, 274);
            this.cmdServerClear.Name = "cmdServerClear";
            this.cmdServerClear.Size = new System.Drawing.Size(75, 23);
            this.cmdServerClear.TabIndex = 4;
            this.cmdServerClear.Text = "Clear";
            this.cmdServerClear.UseVisualStyleBackColor = true;
            this.cmdServerClear.Click += new System.EventHandler(this.cmdServerClear_Click);
            // 
            // chkServerPause
            // 
            this.chkServerPause.AutoSize = true;
            this.chkServerPause.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkServerPause.Location = new System.Drawing.Point(6, 278);
            this.chkServerPause.Name = "chkServerPause";
            this.chkServerPause.Size = new System.Drawing.Size(55, 16);
            this.chkServerPause.TabIndex = 3;
            this.chkServerPause.Text = "Pause";
            this.chkServerPause.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServer.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(6, 20);
            this.txtServer.Multiline = true;
            this.txtServer.Name = "txtServer";
            this.txtServer.ReadOnly = true;
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtServer.Size = new System.Drawing.Size(236, 252);
            this.txtServer.TabIndex = 0;
            // 
            // haxMovie
            // 
            this.haxMovie.Enabled = true;
            this.haxMovie.Location = new System.Drawing.Point(573, 159);
            this.haxMovie.Name = "haxMovie";
            this.haxMovie.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("haxMovie.OcxState")));
            this.haxMovie.Size = new System.Drawing.Size(192, 192);
            this.haxMovie.TabIndex = 2;
            this.haxMovie.FlashCall += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEventHandler(this.haxMovie_FlashCall);
            // 
            // diagnosticsToolStripMenuItem
            // 
            this.diagnosticsToolStripMenuItem.Name = "diagnosticsToolStripMenuItem";
            this.diagnosticsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diagnosticsToolStripMenuItem.Text = "Diagnostics";
            this.diagnosticsToolStripMenuItem.Click += new System.EventHandler(this.diagnosticsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // wndMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 428);
            this.Controls.Add(this.haxMovie);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "wndMain";
            this.Text = "Lemon Packetlogger -> Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.wndMain_FormClosed);
            this.Load += new System.EventHandler(this.wndMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.haxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowPacketloggerToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdDonate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblClientConnected;
        private System.Windows.Forms.Label lblServerConnected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSSO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSWFVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrypto;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdEncoders;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button cmdSendClient;
        private System.Windows.Forms.Button cmdSendServer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private AxShockwaveFlashObjects.AxShockwaveFlash haxMovie;
        private System.Windows.Forms.ToolStripMenuItem stayOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button cmdClientClear;
        private System.Windows.Forms.Button cmdServerClear;
        public System.Windows.Forms.CheckBox chkClientPause;
        public System.Windows.Forms.CheckBox chkServerPause;
        private System.Windows.Forms.ToolStripMenuItem diagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}