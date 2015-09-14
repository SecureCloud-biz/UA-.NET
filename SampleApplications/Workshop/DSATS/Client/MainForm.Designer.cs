/* ========================================================================
 * Copyright (c) 2005-2013 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

namespace DsatsDemoClient
{
    partial class MainForm
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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.ServerMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Server_DiscoverMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Server_ConnectMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Server_DisconnectMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ContentsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.MainPN = new System.Windows.Forms.Panel();
            this.LockMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Lock_RequestMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Lock_ReleaseMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Lock_ApproveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UserIdentityPN = new System.Windows.Forms.FlowLayoutPanel();
            this.UserNameLB = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ApplyBTN = new System.Windows.Forms.Button();
            this.EventsLV = new Opc.Ua.Client.Controls.EventListView();
            this.ConnectServerCTRL = new Opc.Ua.Client.Controls.ConnectServerCtrl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PhaseLB = new System.Windows.Forms.Label();
            this.PhaseCB = new System.Windows.Forms.ComboBox();
            this.ChangeBTN = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.MainPN.SuspendLayout();
            this.LockMenu.SuspendLayout();
            this.UserIdentityPN.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerMI,
            this.HelpMI});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(809, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // ServerMI
            // 
            this.ServerMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Server_DiscoverMI,
            this.Server_ConnectMI,
            this.Server_DisconnectMI});
            this.ServerMI.Name = "ServerMI";
            this.ServerMI.Size = new System.Drawing.Size(51, 20);
            this.ServerMI.Text = "Server";
            // 
            // Server_DiscoverMI
            // 
            this.Server_DiscoverMI.Name = "Server_DiscoverMI";
            this.Server_DiscoverMI.Size = new System.Drawing.Size(133, 22);
            this.Server_DiscoverMI.Text = "Discover...";
            this.Server_DiscoverMI.Click += new System.EventHandler(this.Server_DiscoverMI_Click);
            // 
            // Server_ConnectMI
            // 
            this.Server_ConnectMI.Name = "Server_ConnectMI";
            this.Server_ConnectMI.Size = new System.Drawing.Size(133, 22);
            this.Server_ConnectMI.Text = "Connect";
            this.Server_ConnectMI.Click += new System.EventHandler(this.Server_ConnectMI_Click);
            // 
            // Server_DisconnectMI
            // 
            this.Server_DisconnectMI.Name = "Server_DisconnectMI";
            this.Server_DisconnectMI.Size = new System.Drawing.Size(133, 22);
            this.Server_DisconnectMI.Text = "Disconnect";
            this.Server_DisconnectMI.Click += new System.EventHandler(this.Server_DisconnectMI_Click);
            // 
            // HelpMI
            // 
            this.HelpMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_ContentsMI});
            this.HelpMI.Name = "HelpMI";
            this.HelpMI.Size = new System.Drawing.Size(44, 20);
            this.HelpMI.Text = "Help";
            // 
            // Help_ContentsMI
            // 
            this.Help_ContentsMI.Name = "Help_ContentsMI";
            this.Help_ContentsMI.Size = new System.Drawing.Size(122, 22);
            this.Help_ContentsMI.Text = "Contents";
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 343);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(809, 22);
            this.StatusBar.TabIndex = 2;
            // 
            // MainPN
            // 
            this.MainPN.Controls.Add(this.EventsLV);
            this.MainPN.Controls.Add(this.flowLayoutPanel1);
            this.MainPN.Controls.Add(this.UserIdentityPN);
            this.MainPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPN.Location = new System.Drawing.Point(0, 47);
            this.MainPN.Name = "MainPN";
            this.MainPN.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.MainPN.Size = new System.Drawing.Size(809, 296);
            this.MainPN.TabIndex = 3;
            // 
            // LockMenu
            // 
            this.LockMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lock_RequestMI,
            this.Lock_ReleaseMI,
            this.Lock_ApproveMI});
            this.LockMenu.Name = "LockMenu";
            this.LockMenu.Size = new System.Drawing.Size(120, 70);
            // 
            // Lock_RequestMI
            // 
            this.Lock_RequestMI.Name = "Lock_RequestMI";
            this.Lock_RequestMI.Size = new System.Drawing.Size(119, 22);
            this.Lock_RequestMI.Text = "Request";
            this.Lock_RequestMI.Click += new System.EventHandler(this.Lock_RequestMI_Click);
            // 
            // Lock_ReleaseMI
            // 
            this.Lock_ReleaseMI.Name = "Lock_ReleaseMI";
            this.Lock_ReleaseMI.Size = new System.Drawing.Size(119, 22);
            this.Lock_ReleaseMI.Text = "Release";
            this.Lock_ReleaseMI.Click += new System.EventHandler(this.Lock_ReleaseMI_Click);
            // 
            // Lock_ApproveMI
            // 
            this.Lock_ApproveMI.Name = "Lock_ApproveMI";
            this.Lock_ApproveMI.Size = new System.Drawing.Size(119, 22);
            this.Lock_ApproveMI.Text = "Approve";
            this.Lock_ApproveMI.Click += new System.EventHandler(this.Lock_ApproveMI_Click);
            // 
            // UserIdentityPN
            // 
            this.UserIdentityPN.Controls.Add(this.UserNameLB);
            this.UserIdentityPN.Controls.Add(this.UserNameTB);
            this.UserIdentityPN.Controls.Add(this.PasswordLB);
            this.UserIdentityPN.Controls.Add(this.PasswordTB);
            this.UserIdentityPN.Controls.Add(this.ApplyBTN);
            this.UserIdentityPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserIdentityPN.Location = new System.Drawing.Point(2, 2);
            this.UserIdentityPN.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.UserIdentityPN.Name = "UserIdentityPN";
            this.UserIdentityPN.Size = new System.Drawing.Size(805, 27);
            this.UserIdentityPN.TabIndex = 3;
            // 
            // UserNameLB
            // 
            this.UserNameLB.Location = new System.Drawing.Point(0, 0);
            this.UserNameLB.Margin = new System.Windows.Forms.Padding(0);
            this.UserNameLB.Name = "UserNameLB";
            this.UserNameLB.Size = new System.Drawing.Size(60, 24);
            this.UserNameLB.TabIndex = 0;
            this.UserNameLB.Text = "User Name";
            this.UserNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(60, 2);
            this.UserNameTB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(173, 20);
            this.UserNameTB.TabIndex = 1;
            // 
            // PasswordLB
            // 
            this.PasswordLB.Location = new System.Drawing.Point(238, 0);
            this.PasswordLB.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(60, 24);
            this.PasswordLB.TabIndex = 2;
            this.PasswordLB.Text = "Password";
            this.PasswordLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(298, 2);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(175, 20);
            this.PasswordTB.TabIndex = 3;
            // 
            // ApplyBTN
            // 
            this.ApplyBTN.Location = new System.Drawing.Point(478, 0);
            this.ApplyBTN.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ApplyBTN.Name = "ApplyBTN";
            this.ApplyBTN.Size = new System.Drawing.Size(60, 24);
            this.ApplyBTN.TabIndex = 4;
            this.ApplyBTN.Text = "Apply";
            this.ApplyBTN.UseVisualStyleBackColor = true;
            this.ApplyBTN.Click += new System.EventHandler(this.ApplyBTN_Click);
            // 
            // EventsLV
            // 
            this.EventsLV.ContextMenuStrip = this.LockMenu;
            this.EventsLV.DisplayConditions = false;
            this.EventsLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsLV.IsSubscribed = false;
            this.EventsLV.Location = new System.Drawing.Point(2, 56);
            this.EventsLV.Name = "EventsLV";
            this.EventsLV.Size = new System.Drawing.Size(805, 240);
            this.EventsLV.TabIndex = 0;
            // 
            // ConnectServerCTRL
            // 
            this.ConnectServerCTRL.Configuration = null;
            this.ConnectServerCTRL.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectServerCTRL.Location = new System.Drawing.Point(0, 24);
            this.ConnectServerCTRL.MaximumSize = new System.Drawing.Size(2048, 23);
            this.ConnectServerCTRL.MinimumSize = new System.Drawing.Size(500, 23);
            this.ConnectServerCTRL.Name = "ConnectServerCTRL";
            this.ConnectServerCTRL.PreferredLocales = null;
            this.ConnectServerCTRL.ServerUrl = "";
            this.ConnectServerCTRL.SessionName = null;
            this.ConnectServerCTRL.Size = new System.Drawing.Size(809, 23);
            this.ConnectServerCTRL.StatusStrip = this.StatusBar;
            this.ConnectServerCTRL.TabIndex = 1;
            this.ConnectServerCTRL.UserIdentity = null;
            this.ConnectServerCTRL.UseSecurity = true;
            this.ConnectServerCTRL.ConnectComplete += new System.EventHandler(this.Server_ConnectComplete);
            this.ConnectServerCTRL.ReconnectStarting += new System.EventHandler(this.Server_ReconnectStarting);
            this.ConnectServerCTRL.ReconnectComplete += new System.EventHandler(this.Server_ReconnectComplete);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PhaseLB);
            this.flowLayoutPanel1.Controls.Add(this.PhaseCB);
            this.flowLayoutPanel1.Controls.Add(this.ChangeBTN);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(805, 27);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // PhaseLB
            // 
            this.PhaseLB.Location = new System.Drawing.Point(0, 0);
            this.PhaseLB.Margin = new System.Windows.Forms.Padding(0);
            this.PhaseLB.Name = "PhaseLB";
            this.PhaseLB.Size = new System.Drawing.Size(60, 24);
            this.PhaseLB.TabIndex = 1;
            this.PhaseLB.Text = "Phase";
            this.PhaseLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhaseCB
            // 
            this.PhaseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PhaseCB.FormattingEnabled = true;
            this.PhaseCB.Location = new System.Drawing.Point(60, 2);
            this.PhaseCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PhaseCB.Name = "PhaseCB";
            this.PhaseCB.Size = new System.Drawing.Size(173, 21);
            this.PhaseCB.TabIndex = 5;
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.Location = new System.Drawing.Point(238, 0);
            this.ChangeBTN.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ChangeBTN.Name = "ChangeBTN";
            this.ChangeBTN.Size = new System.Drawing.Size(60, 24);
            this.ChangeBTN.TabIndex = 6;
            this.ChangeBTN.Text = "Change";
            this.ChangeBTN.UseVisualStyleBackColor = true;
            this.ChangeBTN.Click += new System.EventHandler(this.ChangeBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 365);
            this.Controls.Add(this.MainPN);
            this.Controls.Add(this.ConnectServerCTRL);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainForm";
            this.Text = "DSATS Demo Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.MainPN.ResumeLayout(false);
            this.LockMenu.ResumeLayout(false);
            this.UserIdentityPN.ResumeLayout(false);
            this.UserIdentityPN.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripMenuItem ServerMI;
        private System.Windows.Forms.ToolStripMenuItem Server_DiscoverMI;
        private System.Windows.Forms.ToolStripMenuItem Server_ConnectMI;
        private System.Windows.Forms.ToolStripMenuItem Server_DisconnectMI;
        private System.Windows.Forms.ToolStripMenuItem HelpMI;
        private System.Windows.Forms.ToolStripMenuItem Help_ContentsMI;
        private Opc.Ua.Client.Controls.ConnectServerCtrl ConnectServerCTRL;
        private System.Windows.Forms.Panel MainPN;
        private System.Windows.Forms.ContextMenuStrip LockMenu;
        private System.Windows.Forms.ToolStripMenuItem Lock_RequestMI;
        private System.Windows.Forms.ToolStripMenuItem Lock_ReleaseMI;
        private Opc.Ua.Client.Controls.EventListView EventsLV;
        private System.Windows.Forms.ToolStripMenuItem Lock_ApproveMI;
        private System.Windows.Forms.FlowLayoutPanel UserIdentityPN;
        private System.Windows.Forms.Label UserNameLB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button ApplyBTN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label PhaseLB;
        private System.Windows.Forms.ComboBox PhaseCB;
        private System.Windows.Forms.Button ChangeBTN;
    }
}
