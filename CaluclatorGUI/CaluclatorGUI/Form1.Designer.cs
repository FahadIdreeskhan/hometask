namespace CaluclatorGUI
{
    partial class Calculator
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
            this.txtbox = new System.Windows.Forms.TextBox();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmdequal = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdmultiply = new System.Windows.Forms.Button();
            this.cmdplus = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmdivide = new System.Windows.Forms.Button();
            this.buttonsubtract = new System.Windows.Forms.Button();
            this.cmdtan = new System.Windows.Forms.Button();
            this.cmdsin = new System.Windows.Forms.Button();
            this.cmdcos = new System.Windows.Forms.Button();
            this.cmdsqrt = new System.Windows.Forms.Button();
            this.cmdsquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(12, 12);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(362, 20);
            this.txtbox.TabIndex = 0;
            this.txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_KeyPress);
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(12, 41);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(52, 23);
            this.cmd0.TabIndex = 1;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(63, 41);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(52, 23);
            this.cmd1.TabIndex = 2;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(114, 41);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(61, 23);
            this.cmd2.TabIndex = 3;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(174, 42);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(52, 23);
            this.cmd3.TabIndex = 4;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(225, 42);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(52, 23);
            this.cmd4.TabIndex = 5;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmdequal
            // 
            this.cmdequal.Location = new System.Drawing.Point(276, 42);
            this.cmdequal.Name = "cmdequal";
            this.cmdequal.Size = new System.Drawing.Size(52, 23);
            this.cmdequal.TabIndex = 6;
            this.cmdequal.Text = "=";
            this.cmdequal.UseVisualStyleBackColor = true;
            this.cmdequal.Click += new System.EventHandler(this.cmdequal_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(326, 42);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(52, 23);
            this.cmdclear.TabIndex = 7;
            this.cmdclear.Text = "C";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdmultiply
            // 
            this.cmdmultiply.Location = new System.Drawing.Point(326, 71);
            this.cmdmultiply.Name = "cmdmultiply";
            this.cmdmultiply.Size = new System.Drawing.Size(52, 23);
            this.cmdmultiply.TabIndex = 14;
            this.cmdmultiply.Text = "*";
            this.cmdmultiply.UseVisualStyleBackColor = true;
            this.cmdmultiply.Click += new System.EventHandler(this.cmdmultiply_Click);
            // 
            // cmdplus
            // 
            this.cmdplus.Location = new System.Drawing.Point(276, 71);
            this.cmdplus.Name = "cmdplus";
            this.cmdplus.Size = new System.Drawing.Size(52, 23);
            this.cmdplus.TabIndex = 13;
            this.cmdplus.Text = "+";
            this.cmdplus.UseVisualStyleBackColor = true;
            this.cmdplus.Click += new System.EventHandler(this.cmdplus_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(225, 71);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(52, 23);
            this.cmd9.TabIndex = 12;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(174, 71);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(52, 23);
            this.cmd8.TabIndex = 11;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(114, 70);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(61, 23);
            this.cmd7.TabIndex = 10;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.button12_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(63, 70);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(52, 23);
            this.cmd6.TabIndex = 9;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(12, 70);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(52, 23);
            this.cmd5.TabIndex = 8;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmdivide
            // 
            this.cmdivide.Location = new System.Drawing.Point(326, 99);
            this.cmdivide.Name = "cmdivide";
            this.cmdivide.Size = new System.Drawing.Size(52, 23);
            this.cmdivide.TabIndex = 21;
            this.cmdivide.Text = "/";
            this.cmdivide.UseVisualStyleBackColor = true;
            this.cmdivide.Click += new System.EventHandler(this.button15_Click);
            // 
            // buttonsubtract
            // 
            this.buttonsubtract.Location = new System.Drawing.Point(276, 99);
            this.buttonsubtract.Name = "buttonsubtract";
            this.buttonsubtract.Size = new System.Drawing.Size(52, 23);
            this.buttonsubtract.TabIndex = 20;
            this.buttonsubtract.Text = "-";
            this.buttonsubtract.UseVisualStyleBackColor = true;
            this.buttonsubtract.Click += new System.EventHandler(this.buttonsubtract_Click);
            // 
            // cmdtan
            // 
            this.cmdtan.Location = new System.Drawing.Point(225, 99);
            this.cmdtan.Name = "cmdtan";
            this.cmdtan.Size = new System.Drawing.Size(52, 23);
            this.cmdtan.TabIndex = 19;
            this.cmdtan.Text = "tan";
            this.cmdtan.UseVisualStyleBackColor = true;
            this.cmdtan.Click += new System.EventHandler(this.cmdtan_Click);
            // 
            // cmdsin
            // 
            this.cmdsin.Location = new System.Drawing.Point(174, 99);
            this.cmdsin.Name = "cmdsin";
            this.cmdsin.Size = new System.Drawing.Size(52, 23);
            this.cmdsin.TabIndex = 18;
            this.cmdsin.Text = "sin";
            this.cmdsin.UseVisualStyleBackColor = true;
            this.cmdsin.Click += new System.EventHandler(this.button18_Click);
            // 
            // cmdcos
            // 
            this.cmdcos.Location = new System.Drawing.Point(114, 98);
            this.cmdcos.Name = "cmdcos";
            this.cmdcos.Size = new System.Drawing.Size(61, 23);
            this.cmdcos.TabIndex = 17;
            this.cmdcos.Text = "cos";
            this.cmdcos.UseVisualStyleBackColor = true;
            this.cmdcos.Click += new System.EventHandler(this.cmdcos_Click);
            // 
            // cmdsqrt
            // 
            this.cmdsqrt.Location = new System.Drawing.Point(63, 98);
            this.cmdsqrt.Name = "cmdsqrt";
            this.cmdsqrt.Size = new System.Drawing.Size(52, 23);
            this.cmdsqrt.TabIndex = 16;
            this.cmdsqrt.Text = "sqrt";
            this.cmdsqrt.UseVisualStyleBackColor = true;
            this.cmdsqrt.Click += new System.EventHandler(this.cmdsqrt_Click);
            // 
            // cmdsquare
            // 
            this.cmdsquare.Location = new System.Drawing.Point(12, 98);
            this.cmdsquare.Name = "cmdsquare";
            this.cmdsquare.Size = new System.Drawing.Size(52, 23);
            this.cmdsquare.TabIndex = 15;
            this.cmdsquare.Text = "x2";
            this.cmdsquare.UseVisualStyleBackColor = true;
            this.cmdsquare.Click += new System.EventHandler(this.cmdsquare_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 173);
            this.Controls.Add(this.cmdivide);
            this.Controls.Add(this.buttonsubtract);
            this.Controls.Add(this.cmdtan);
            this.Controls.Add(this.cmdsin);
            this.Controls.Add(this.cmdcos);
            this.Controls.Add(this.cmdsqrt);
            this.Controls.Add(this.cmdsquare);
            this.Controls.Add(this.cmdmultiply);
            this.Controls.Add(this.cmdplus);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdequal);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.txtbox);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmdequal;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdmultiply;
        private System.Windows.Forms.Button cmdplus;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmdivide;
        private System.Windows.Forms.Button buttonsubtract;
        private System.Windows.Forms.Button cmdtan;
        private System.Windows.Forms.Button cmdsin;
        private System.Windows.Forms.Button cmdcos;
        private System.Windows.Forms.Button cmdsqrt;
        private System.Windows.Forms.Button cmdsquare;
    }
}

