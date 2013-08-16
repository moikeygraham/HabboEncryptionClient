namespace FlashCrypto
{
    partial class wndEncoders
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdB64DecodeStr = new System.Windows.Forms.Button();
            this.cmdB64Str = new System.Windows.Forms.Button();
            this.cmdB64Int = new System.Windows.Forms.Button();
            this.txtB64Int = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB64Str = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdWiredIntEncode = new System.Windows.Forms.Button();
            this.txtWiredInt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmddecodeWiredStr = new System.Windows.Forms.Button();
            this.txtWiredStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdB64DecodeStr);
            this.groupBox1.Controls.Add(this.cmdB64Str);
            this.groupBox1.Controls.Add(this.cmdB64Int);
            this.groupBox1.Controls.Add(this.txtB64Int);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtB64Str);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "B64 Encoding";
            // 
            // cmdB64DecodeStr
            // 
            this.cmdB64DecodeStr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB64DecodeStr.ForeColor = System.Drawing.Color.Black;
            this.cmdB64DecodeStr.Location = new System.Drawing.Point(121, 94);
            this.cmdB64DecodeStr.Name = "cmdB64DecodeStr";
            this.cmdB64DecodeStr.Size = new System.Drawing.Size(104, 25);
            this.cmdB64DecodeStr.TabIndex = 6;
            this.cmdB64DecodeStr.Text = "Decode String";
            this.cmdB64DecodeStr.UseVisualStyleBackColor = true;
            this.cmdB64DecodeStr.Click += new System.EventHandler(this.cmdB64DecodeStr_Click);
            // 
            // cmdB64Str
            // 
            this.cmdB64Str.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB64Str.ForeColor = System.Drawing.Color.Black;
            this.cmdB64Str.Location = new System.Drawing.Point(231, 94);
            this.cmdB64Str.Name = "cmdB64Str";
            this.cmdB64Str.Size = new System.Drawing.Size(104, 25);
            this.cmdB64Str.TabIndex = 5;
            this.cmdB64Str.Text = "Encode String";
            this.cmdB64Str.UseVisualStyleBackColor = true;
            this.cmdB64Str.Click += new System.EventHandler(this.cmdB64Str_Click);
            // 
            // cmdB64Int
            // 
            this.cmdB64Int.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB64Int.ForeColor = System.Drawing.Color.Black;
            this.cmdB64Int.Location = new System.Drawing.Point(144, 131);
            this.cmdB64Int.Name = "cmdB64Int";
            this.cmdB64Int.Size = new System.Drawing.Size(88, 21);
            this.cmdB64Int.TabIndex = 4;
            this.cmdB64Int.Text = "Encode Int";
            this.cmdB64Int.UseVisualStyleBackColor = true;
            this.cmdB64Int.Click += new System.EventHandler(this.cmdB64Int_Click);
            // 
            // txtB64Int
            // 
            this.txtB64Int.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB64Int.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB64Int.Location = new System.Drawing.Point(72, 131);
            this.txtB64Int.Name = "txtB64Int";
            this.txtB64Int.Size = new System.Drawing.Size(66, 21);
            this.txtB64Int.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Integer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String:";
            // 
            // txtB64Str
            // 
            this.txtB64Str.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB64Str.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB64Str.Location = new System.Drawing.Point(72, 25);
            this.txtB64Str.Multiline = true;
            this.txtB64Str.Name = "txtB64Str";
            this.txtB64Str.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtB64Str.Size = new System.Drawing.Size(263, 63);
            this.txtB64Str.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdWiredIntEncode);
            this.groupBox2.Controls.Add(this.txtWiredInt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmddecodeWiredStr);
            this.groupBox2.Controls.Add(this.txtWiredStr);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(7, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wired (VL64)";
            // 
            // cmdWiredIntEncode
            // 
            this.cmdWiredIntEncode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWiredIntEncode.ForeColor = System.Drawing.Color.Black;
            this.cmdWiredIntEncode.Location = new System.Drawing.Point(116, 142);
            this.cmdWiredIntEncode.Name = "cmdWiredIntEncode";
            this.cmdWiredIntEncode.Size = new System.Drawing.Size(75, 23);
            this.cmdWiredIntEncode.TabIndex = 6;
            this.cmdWiredIntEncode.Text = "Encode";
            this.cmdWiredIntEncode.UseVisualStyleBackColor = true;
            this.cmdWiredIntEncode.Click += new System.EventHandler(this.cmdWiredIntEncode_Click);
            // 
            // txtWiredInt
            // 
            this.txtWiredInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWiredInt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWiredInt.Location = new System.Drawing.Point(91, 115);
            this.txtWiredInt.Name = "txtWiredInt";
            this.txtWiredInt.Size = new System.Drawing.Size(100, 21);
            this.txtWiredInt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Encode int:";
            // 
            // cmddecodeWiredStr
            // 
            this.cmddecodeWiredStr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmddecodeWiredStr.ForeColor = System.Drawing.Color.Black;
            this.cmddecodeWiredStr.Location = new System.Drawing.Point(265, 108);
            this.cmddecodeWiredStr.Name = "cmddecodeWiredStr";
            this.cmddecodeWiredStr.Size = new System.Drawing.Size(75, 23);
            this.cmddecodeWiredStr.TabIndex = 3;
            this.cmddecodeWiredStr.Text = "Decode";
            this.cmddecodeWiredStr.UseVisualStyleBackColor = true;
            this.cmddecodeWiredStr.Click += new System.EventHandler(this.cmddecodeWiredStr_Click);
            // 
            // txtWiredStr
            // 
            this.txtWiredStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWiredStr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWiredStr.Location = new System.Drawing.Point(7, 44);
            this.txtWiredStr.Multiline = true;
            this.txtWiredStr.Name = "txtWiredStr";
            this.txtWiredStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWiredStr.Size = new System.Drawing.Size(333, 58);
            this.txtWiredStr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Decode string:";
            // 
            // wndEncoders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "wndEncoders";
            this.Text = "Wired/B64 Encoders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wndEncoders_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB64Str;
        private System.Windows.Forms.Button cmdB64Str;
        private System.Windows.Forms.Button cmdB64Int;
        private System.Windows.Forms.TextBox txtB64Int;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdB64DecodeStr;
        private System.Windows.Forms.Button cmddecodeWiredStr;
        private System.Windows.Forms.TextBox txtWiredStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdWiredIntEncode;
        private System.Windows.Forms.TextBox txtWiredInt;
        private System.Windows.Forms.Label label5;
    }
}