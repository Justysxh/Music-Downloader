﻿using System;
using System.Windows.Forms;
namespace Music_Downloader
{
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About(string version, string latestversion)
        {
            InitializeComponent();
            linkLabel4.Text = "当前版本：" + version;
            linkLabel5.Text = "最新版本：" + latestversion;
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("1024028162");
        }
    }
}
