﻿namespace ANHAdmin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteConnectionConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameplayConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWorldServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startZonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsAndCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSWGANHServerManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSWGANHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serverConfigurationToolStripMenuItem,
            this.serverManagementToolStripMenuItem,
            this.accountsAndCharactersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.remoteConnectionConfigurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // remoteConnectionConfigurationToolStripMenuItem
            // 
            this.remoteConnectionConfigurationToolStripMenuItem.Name = "remoteConnectionConfigurationToolStripMenuItem";
            this.remoteConnectionConfigurationToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.remoteConnectionConfigurationToolStripMenuItem.Text = "Remote Connection Config";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // serverConfigurationToolStripMenuItem
            // 
            this.serverConfigurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalConfigToolStripMenuItem,
            this.gameplayConfigToolStripMenuItem,
            this.zoneConfigToolStripMenuItem});
            this.serverConfigurationToolStripMenuItem.Name = "serverConfigurationToolStripMenuItem";
            this.serverConfigurationToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.serverConfigurationToolStripMenuItem.Text = "Server Configuration";
            // 
            // globalConfigToolStripMenuItem
            // 
            this.globalConfigToolStripMenuItem.Name = "globalConfigToolStripMenuItem";
            this.globalConfigToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.globalConfigToolStripMenuItem.Text = "Global Config";
            // 
            // gameplayConfigToolStripMenuItem
            // 
            this.gameplayConfigToolStripMenuItem.Name = "gameplayConfigToolStripMenuItem";
            this.gameplayConfigToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gameplayConfigToolStripMenuItem.Text = "Gameplay Config";
            // 
            // zoneConfigToolStripMenuItem
            // 
            this.zoneConfigToolStripMenuItem.Name = "zoneConfigToolStripMenuItem";
            this.zoneConfigToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoneConfigToolStripMenuItem.Text = "Zone Config";
            // 
            // serverManagementToolStripMenuItem
            // 
            this.serverManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWorldServersToolStripMenuItem,
            this.startZonesToolStripMenuItem});
            this.serverManagementToolStripMenuItem.Name = "serverManagementToolStripMenuItem";
            this.serverManagementToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.serverManagementToolStripMenuItem.Text = "Start / Stop Servers";
            // 
            // startWorldServersToolStripMenuItem
            // 
            this.startWorldServersToolStripMenuItem.Name = "startWorldServersToolStripMenuItem";
            this.startWorldServersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startWorldServersToolStripMenuItem.Text = "World Servers";
            this.startWorldServersToolStripMenuItem.Click += new System.EventHandler(this.startWorldServersToolStripMenuItem_Click);
            // 
            // startZonesToolStripMenuItem
            // 
            this.startZonesToolStripMenuItem.Name = "startZonesToolStripMenuItem";
            this.startZonesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startZonesToolStripMenuItem.Text = "Zone Servers";
            this.startZonesToolStripMenuItem.Click += new System.EventHandler(this.startZonesToolStripMenuItem_Click);
            // 
            // accountsAndCharactersToolStripMenuItem
            // 
            this.accountsAndCharactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountManagerToolStripMenuItem,
            this.characterManagerToolStripMenuItem});
            this.accountsAndCharactersToolStripMenuItem.Name = "accountsAndCharactersToolStripMenuItem";
            this.accountsAndCharactersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.accountsAndCharactersToolStripMenuItem.Text = "Users";
            // 
            // accountManagerToolStripMenuItem
            // 
            this.accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            this.accountManagerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.accountManagerToolStripMenuItem.Text = "Account Manager";
            this.accountManagerToolStripMenuItem.Click += new System.EventHandler(this.accountManagerToolStripMenuItem_Click);
            // 
            // characterManagerToolStripMenuItem
            // 
            this.characterManagerToolStripMenuItem.Name = "characterManagerToolStripMenuItem";
            this.characterManagerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.characterManagerToolStripMenuItem.Text = "Character Manager";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSWGANHServerManagerToolStripMenuItem,
            this.aboutSWGANHToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSWGANHServerManagerToolStripMenuItem
            // 
            this.aboutSWGANHServerManagerToolStripMenuItem.Name = "aboutSWGANHServerManagerToolStripMenuItem";
            this.aboutSWGANHServerManagerToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.aboutSWGANHServerManagerToolStripMenuItem.Text = "About SWG:ANH ServerManager";
            // 
            // aboutSWGANHToolStripMenuItem
            // 
            this.aboutSWGANHToolStripMenuItem.Name = "aboutSWGANHToolStripMenuItem";
            this.aboutSWGANHToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.aboutSWGANHToolStripMenuItem.Text = "About SWG:ANH";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SWG:ANH Server Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameplayConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWorldServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startZonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsAndCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteConnectionConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSWGANHServerManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSWGANHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

