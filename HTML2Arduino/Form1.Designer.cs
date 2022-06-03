namespace HTML2Arduino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_secureServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_insecureServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Source = new System.Windows.Forms.TextBox();
            this.button_SourceBrowse = new System.Windows.Forms.Button();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_secureServer
            // 
            this.textBox_secureServer.Location = new System.Drawing.Point(121, 13);
            this.textBox_secureServer.Name = "textBox_secureServer";
            this.textBox_secureServer.Size = new System.Drawing.Size(184, 23);
            this.textBox_secureServer.TabIndex = 0;
            this.textBox_secureServer.Text = "secureServer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Secure Server Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insecure Server Class";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_insecureServer
            // 
            this.textBox_insecureServer.Location = new System.Drawing.Point(130, 51);
            this.textBox_insecureServer.Name = "textBox_insecureServer";
            this.textBox_insecureServer.Size = new System.Drawing.Size(175, 23);
            this.textBox_insecureServer.TabIndex = 2;
            this.textBox_insecureServer.Text = "insecureServer";
            this.textBox_insecureServer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Source HTML";
            // 
            // textBox_Source
            // 
            this.textBox_Source.Location = new System.Drawing.Point(94, 117);
            this.textBox_Source.Name = "textBox_Source";
            this.textBox_Source.ReadOnly = true;
            this.textBox_Source.Size = new System.Drawing.Size(313, 23);
            this.textBox_Source.TabIndex = 5;
            // 
            // button_SourceBrowse
            // 
            this.button_SourceBrowse.Location = new System.Drawing.Point(413, 116);
            this.button_SourceBrowse.Name = "button_SourceBrowse";
            this.button_SourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.button_SourceBrowse.TabIndex = 6;
            this.button_SourceBrowse.Text = "Browse";
            this.button_SourceBrowse.UseVisualStyleBackColor = true;
            this.button_SourceBrowse.Click += new System.EventHandler(this.button_SourceBrowse_Click);
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(69, 80);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(236, 23);
            this.textBox_URL.TabIndex = 8;
            this.textBox_URL.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "URL Path";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 256);
            this.textBox1.TabIndex = 10;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(204, 153);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 11;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_SourceBrowse);
            this.Controls.Add(this.textBox_Source);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_insecureServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_secureServer);
            this.Name = "Form1";
            this.Text = "HTML2Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_secureServer;
        private Label label1;
        private Label label2;
        private TextBox textBox_insecureServer;
        private Label label3;
        private TextBox textBox_Source;
        private Button button_SourceBrowse;
        private TextBox textBox_URL;
        private Label label4;
        private TextBox textBox1;
        private Button button_Start;
    }
}