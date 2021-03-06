﻿namespace ANHAdmin
{
    partial class frmConServers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConServers));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPing = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.StartServers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnStopLogin = new System.Windows.Forms.Button();
            this.btnStopPing = new System.Windows.Forms.Button();
            this.btnStopChat = new System.Windows.Forms.Button();
            this.btnStopCon = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.txtConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(630, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtConnection
            // 
            this.txtConnection.BackColor = System.Drawing.Color.Teal;
            this.txtConnection.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnection.ForeColor = System.Drawing.Color.White;
            this.txtConnection.Location = new System.Drawing.Point(6, 7);
            this.txtConnection.Multiline = true;
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConnection.Size = new System.Drawing.Size(618, 419);
            this.txtConnection.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::ANHAdmin.Properties.Resources.newgui;
            this.tabPage2.Controls.Add(this.txtChat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(630, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chat Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.Color.Teal;
            this.txtChat.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.txtChat.ForeColor = System.Drawing.Color.White;
            this.txtChat.Location = new System.Drawing.Point(6, 7);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChat.Size = new System.Drawing.Size(617, 419);
            this.txtChat.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::ANHAdmin.Properties.Resources.newgui;
            this.tabPage3.Controls.Add(this.txtPing);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(630, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ping Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtPing
            // 
            this.txtPing.BackColor = System.Drawing.Color.Teal;
            this.txtPing.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.txtPing.ForeColor = System.Drawing.Color.White;
            this.txtPing.Location = new System.Drawing.Point(6, 7);
            this.txtPing.Multiline = true;
            this.txtPing.Name = "txtPing";
            this.txtPing.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPing.Size = new System.Drawing.Size(617, 419);
            this.txtPing.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::ANHAdmin.Properties.Resources.newgui;
            this.tabPage4.Controls.Add(this.txtLogin);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(630, 432);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Login Server";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Teal;
            this.txtLogin.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(6, 7);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogin.Size = new System.Drawing.Size(617, 419);
            this.txtLogin.TabIndex = 1;
            // 
            // StartServers
            // 
            this.StartServers.Location = new System.Drawing.Point(644, 25);
            this.StartServers.Name = "StartServers";
            this.StartServers.Size = new System.Drawing.Size(114, 23);
            this.StartServers.TabIndex = 1;
            this.StartServers.Text = "Start Connection";
            this.StartServers.UseVisualStyleBackColor = true;
            this.StartServers.Click += new System.EventHandler(this.StartServers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Chat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Start Ping";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(644, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Start Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStopLogin
            // 
            this.btnStopLogin.Location = new System.Drawing.Point(764, 112);
            this.btnStopLogin.Name = "btnStopLogin";
            this.btnStopLogin.Size = new System.Drawing.Size(114, 23);
            this.btnStopLogin.TabIndex = 8;
            this.btnStopLogin.Text = "Stop Login";
            this.btnStopLogin.UseVisualStyleBackColor = true;
            this.btnStopLogin.Click += new System.EventHandler(this.btnStopLogin_Click);
            // 
            // btnStopPing
            // 
            this.btnStopPing.Location = new System.Drawing.Point(764, 83);
            this.btnStopPing.Name = "btnStopPing";
            this.btnStopPing.Size = new System.Drawing.Size(114, 23);
            this.btnStopPing.TabIndex = 7;
            this.btnStopPing.Text = "Stop Ping";
            this.btnStopPing.UseVisualStyleBackColor = true;
            this.btnStopPing.Click += new System.EventHandler(this.btnStopPing_Click);
            // 
            // btnStopChat
            // 
            this.btnStopChat.Location = new System.Drawing.Point(764, 54);
            this.btnStopChat.Name = "btnStopChat";
            this.btnStopChat.Size = new System.Drawing.Size(114, 23);
            this.btnStopChat.TabIndex = 6;
            this.btnStopChat.Text = "Stop Chat";
            this.btnStopChat.UseVisualStyleBackColor = true;
            this.btnStopChat.Click += new System.EventHandler(this.btnStopChat_Click);
            // 
            // btnStopCon
            // 
            this.btnStopCon.Location = new System.Drawing.Point(764, 25);
            this.btnStopCon.Name = "btnStopCon";
            this.btnStopCon.Size = new System.Drawing.Size(114, 23);
            this.btnStopCon.TabIndex = 5;
            this.btnStopCon.Text = "Stop Connection";
            this.btnStopCon.UseVisualStyleBackColor = true;
            this.btnStopCon.Click += new System.EventHandler(this.btnStopCon_Click);
            // 
            // frmConServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 464);
            this.Controls.Add(this.btnStopLogin);
            this.Controls.Add(this.btnStopPing);
            this.Controls.Add(this.btnStopChat);
            this.Controls.Add(this.btnStopCon);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartServers);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmConServers";
            this.Text = "SWG:ANH World Servers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConServers_FormClosing);
            this.Load += new System.EventHandler(this.frmConServers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtPing;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button StartServers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStopLogin;
        private System.Windows.Forms.Button btnStopPing;
        private System.Windows.Forms.Button btnStopChat;
        private System.Windows.Forms.Button btnStopCon;
    }
}