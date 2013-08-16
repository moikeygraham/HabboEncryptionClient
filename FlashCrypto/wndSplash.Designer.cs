namespace FlashCrypto
{
    partial class wndSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndSplash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrCount = new System.Windows.Forms.Timer(this.components);
            this.cmdContinue = new System.Windows.Forms.Button();
            this.cmdDonate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(229, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Lemon Packetlogger";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblV.Location = new System.Drawing.Point(628, 168);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(26, 10);
            this.lblV.TabIndex = 2;
            this.lblV.Text = "1.1.0";
            this.lblV.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 87);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tmrCount
            // 
            this.tmrCount.Enabled = true;
            this.tmrCount.Interval = 1000;
            this.tmrCount.Tick += new System.EventHandler(this.tmrCount_Tick);
            // 
            // cmdContinue
            // 
            this.cmdContinue.Enabled = false;
            this.cmdContinue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdContinue.Location = new System.Drawing.Point(235, 133);
            this.cmdContinue.Name = "cmdContinue";
            this.cmdContinue.Size = new System.Drawing.Size(109, 35);
            this.cmdContinue.TabIndex = 4;
            this.cmdContinue.Text = "5";
            this.cmdContinue.UseVisualStyleBackColor = true;
            this.cmdContinue.Click += new System.EventHandler(this.cmdContinue_Click);
            // 
            // cmdDonate
            // 
            this.cmdDonate.Image = ((System.Drawing.Image)(resources.GetObject("cmdDonate.Image")));
            this.cmdDonate.Location = new System.Drawing.Point(445, 111);
            this.cmdDonate.Name = "cmdDonate";
            this.cmdDonate.Size = new System.Drawing.Size(177, 57);
            this.cmdDonate.TabIndex = 5;
            this.cmdDonate.UseVisualStyleBackColor = true;
            this.cmdDonate.Click += new System.EventHandler(this.cmdDonate_Click);
            // 
            // wndSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 180);
            this.Controls.Add(this.cmdDonate);
            this.Controls.Add(this.cmdContinue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wndSplash";
            this.Text = "Welcome!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wndSplash_FormClosing);
            this.Load += new System.EventHandler(this.wndSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrCount;
        private System.Windows.Forms.Button cmdContinue;
        private System.Windows.Forms.Button cmdDonate;
    }
}