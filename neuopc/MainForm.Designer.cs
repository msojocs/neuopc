﻿
namespace neuopc
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            DAStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            UAStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            NotifyIcon = new System.Windows.Forms.NotifyIcon(components);
            TabPageAbout = new System.Windows.Forms.TabPage();
            AboutRichTextBox = new System.Windows.Forms.RichTextBox();
            TabPageLog = new System.Windows.Forms.TabPage();
            LogRichTextBox = new System.Windows.Forms.RichTextBox();
            TabPageData = new System.Windows.Forms.TabPage();
            MainListView = new System.Windows.Forms.ListView();
            name = new System.Windows.Forms.ColumnHeader();
            type = new System.Windows.Forms.ColumnHeader();
            rights = new System.Windows.Forms.ColumnHeader();
            value = new System.Windows.Forms.ColumnHeader();
            quality = new System.Windows.Forms.ColumnHeader();
            error = new System.Windows.Forms.ColumnHeader();
            timestamp = new System.Windows.Forms.ColumnHeader();
            handle = new System.Windows.Forms.ColumnHeader();
            TagContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            addTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            deleteTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            TabPageSetting = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            UAMessageMode = new System.Windows.Forms.ComboBox();
            UASecurityPolicy = new System.Windows.Forms.ComboBox();
            UAIsAllowAnonymous = new System.Windows.Forms.CheckBox();
            label14 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            SaveButton = new System.Windows.Forms.Button();
            DALabel = new System.Windows.Forms.Label();
            CheckBox = new System.Windows.Forms.CheckBox();
            SwitchButton = new System.Windows.Forms.Button();
            UAPasswordTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            UAUrlTextBox = new System.Windows.Forms.TextBox();
            UAUserTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            DAHostComboBox = new System.Windows.Forms.ComboBox();
            DAServerComboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            TestButton = new System.Windows.Forms.Button();
            TabControl = new System.Windows.Forms.TabControl();
            statusStrip1.SuspendLayout();
            TabPageAbout.SuspendLayout();
            TabPageLog.SuspendLayout();
            TabPageData.SuspendLayout();
            TagContextMenuStrip.SuspendLayout();
            TabPageSetting.SuspendLayout();
            groupBox1.SuspendLayout();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { DAStatusLabel, UAStatusLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 788);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            statusStrip1.Size = new System.Drawing.Size(1333, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // DAStatusLabel
            // 
            DAStatusLabel.Name = "DAStatusLabel";
            DAStatusLabel.Size = new System.Drawing.Size(0, 13);
            // 
            // UAStatusLabel
            // 
            UAStatusLabel.Name = "UAStatusLabel";
            UAStatusLabel.Size = new System.Drawing.Size(0, 13);
            // 
            // NotifyIcon
            // 
            NotifyIcon.Text = "neuopc";
            NotifyIcon.Visible = true;
            NotifyIcon.Click += NotifyIcon_Click;
            // 
            // TabPageAbout
            // 
            TabPageAbout.Controls.Add(AboutRichTextBox);
            TabPageAbout.Location = new System.Drawing.Point(4, 36);
            TabPageAbout.Margin = new System.Windows.Forms.Padding(4);
            TabPageAbout.Name = "TabPageAbout";
            TabPageAbout.Padding = new System.Windows.Forms.Padding(4);
            TabPageAbout.Size = new System.Drawing.Size(1325, 748);
            TabPageAbout.TabIndex = 2;
            TabPageAbout.Text = "About";
            TabPageAbout.UseVisualStyleBackColor = true;
            // 
            // AboutRichTextBox
            // 
            AboutRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            AboutRichTextBox.Location = new System.Drawing.Point(4, 4);
            AboutRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            AboutRichTextBox.Name = "AboutRichTextBox";
            AboutRichTextBox.ReadOnly = true;
            AboutRichTextBox.Size = new System.Drawing.Size(1317, 740);
            AboutRichTextBox.TabIndex = 0;
            AboutRichTextBox.Text = "";
            // 
            // TabPageLog
            // 
            TabPageLog.Controls.Add(LogRichTextBox);
            TabPageLog.Location = new System.Drawing.Point(4, 36);
            TabPageLog.Margin = new System.Windows.Forms.Padding(4);
            TabPageLog.Name = "TabPageLog";
            TabPageLog.Size = new System.Drawing.Size(1325, 748);
            TabPageLog.TabIndex = 3;
            TabPageLog.Text = "Log";
            TabPageLog.UseVisualStyleBackColor = true;
            // 
            // LogRichTextBox
            // 
            LogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            LogRichTextBox.Location = new System.Drawing.Point(0, 0);
            LogRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            LogRichTextBox.Name = "LogRichTextBox";
            LogRichTextBox.ReadOnly = true;
            LogRichTextBox.Size = new System.Drawing.Size(1325, 748);
            LogRichTextBox.TabIndex = 0;
            LogRichTextBox.Text = "";
            // 
            // TabPageData
            // 
            TabPageData.Controls.Add(MainListView);
            TabPageData.Location = new System.Drawing.Point(4, 36);
            TabPageData.Margin = new System.Windows.Forms.Padding(4);
            TabPageData.Name = "TabPageData";
            TabPageData.Padding = new System.Windows.Forms.Padding(4);
            TabPageData.Size = new System.Drawing.Size(1325, 748);
            TabPageData.TabIndex = 1;
            TabPageData.Text = "Tags";
            TabPageData.UseVisualStyleBackColor = true;
            // 
            // MainListView
            // 
            MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { name, type, rights, value, quality, error, timestamp, handle });
            MainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            MainListView.Location = new System.Drawing.Point(4, 4);
            MainListView.Margin = new System.Windows.Forms.Padding(4);
            MainListView.Name = "MainListView";
            MainListView.Size = new System.Drawing.Size(1317, 740);
            MainListView.TabIndex = 7;
            MainListView.UseCompatibleStateImageBehavior = false;
            MainListView.View = System.Windows.Forms.View.Details;
            MainListView.SelectedIndexChanged += MainListView_SelectedIndexChanged;
            MainListView.MouseDoubleClick += MainListView_MouseDoubleClick;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 300;
            // 
            // type
            // 
            type.Text = "Type";
            type.Width = 200;
            // 
            // rights
            // 
            rights.Text = "Rights";
            rights.Width = 0;
            // 
            // value
            // 
            value.Text = "Value";
            value.Width = 250;
            // 
            // quality
            // 
            quality.Text = "Quality";
            quality.Width = 120;
            // 
            // error
            // 
            error.Text = "Error";
            error.Width = 0;
            // 
            // timestamp
            // 
            timestamp.Text = "Timestamp";
            timestamp.Width = 200;
            // 
            // handle
            // 
            handle.Text = "Index";
            handle.Width = 0;
            // 
            // TagContextMenuStrip
            // 
            TagContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            TagContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { addTagToolStripMenuItem, toolStripSeparator2, deleteTagToolStripMenuItem });
            TagContextMenuStrip.Name = "contextMenuStrip1";
            TagContextMenuStrip.Size = new System.Drawing.Size(194, 78);
            // 
            // addTagToolStripMenuItem
            // 
            addTagToolStripMenuItem.Name = "addTagToolStripMenuItem";
            addTagToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            addTagToolStripMenuItem.Text = "Add Tag";
            addTagToolStripMenuItem.Click += addTagToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // deleteTagToolStripMenuItem
            // 
            deleteTagToolStripMenuItem.Name = "deleteTagToolStripMenuItem";
            deleteTagToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            deleteTagToolStripMenuItem.Text = "Delete Tag";
            // 
            // TabPageSetting
            // 
            TabPageSetting.Controls.Add(groupBox1);
            TabPageSetting.Location = new System.Drawing.Point(4, 36);
            TabPageSetting.Margin = new System.Windows.Forms.Padding(4);
            TabPageSetting.Name = "TabPageSetting";
            TabPageSetting.Padding = new System.Windows.Forms.Padding(4);
            TabPageSetting.Size = new System.Drawing.Size(1325, 748);
            TabPageSetting.TabIndex = 0;
            TabPageSetting.Text = "Setting";
            TabPageSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(UAMessageMode);
            groupBox1.Controls.Add(UASecurityPolicy);
            groupBox1.Controls.Add(UAIsAllowAnonymous);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(DALabel);
            groupBox1.Controls.Add(CheckBox);
            groupBox1.Controls.Add(SwitchButton);
            groupBox1.Controls.Add(UAPasswordTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(UAUrlTextBox);
            groupBox1.Controls.Add(UAUserTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DAHostComboBox);
            groupBox1.Controls.Add(DAServerComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TestButton);
            groupBox1.Location = new System.Drawing.Point(11, 8);
            groupBox1.Margin = new System.Windows.Forms.Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(5);
            groupBox1.Size = new System.Drawing.Size(1308, 725);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(464, 453);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(167, 28);
            label9.TabIndex = 52;
            label9.Text = "Message Mode";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(472, 398);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(159, 28);
            label8.TabIndex = 51;
            label8.Text = "Security Policy";
            // 
            // UAMessageMode
            // 
            UAMessageMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            UAMessageMode.FormattingEnabled = true;
            UAMessageMode.Items.AddRange(new object[] { "None", "Sign", "Sign & Encrypt" });
            UAMessageMode.Location = new System.Drawing.Point(643, 450);
            UAMessageMode.Name = "UAMessageMode";
            UAMessageMode.Size = new System.Drawing.Size(212, 35);
            UAMessageMode.TabIndex = 50;
            UAMessageMode.Text = "None";
            UAMessageMode.SelectedIndexChanged += UAMessageMode_SelectedIndexChanged;
            // 
            // UASecurityPolicy
            // 
            UASecurityPolicy.FormattingEnabled = true;
            UASecurityPolicy.Items.AddRange(new object[] { "None", "Basic256", "Basic256Sha256" });
            UASecurityPolicy.Location = new System.Drawing.Point(644, 395);
            UASecurityPolicy.Name = "UASecurityPolicy";
            UASecurityPolicy.Size = new System.Drawing.Size(212, 36);
            UASecurityPolicy.TabIndex = 49;
            UASecurityPolicy.Text = "None";
            UASecurityPolicy.SelectedIndexChanged += UASecurityPolicy_SelectedIndexChanged;
            // 
            // UAIsAllowAnonymous
            // 
            UAIsAllowAnonymous.AutoSize = true;
            UAIsAllowAnonymous.Location = new System.Drawing.Point(237, 349);
            UAIsAllowAnonymous.Name = "UAIsAllowAnonymous";
            UAIsAllowAnonymous.Size = new System.Drawing.Size(222, 32);
            UAIsAllowAnonymous.TabIndex = 48;
            UAIsAllowAnonymous.Text = "Allow Anonymous";
            UAIsAllowAnonymous.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label14.Location = new System.Drawing.Point(863, 286);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(22, 28);
            label14.TabIndex = 47;
            label14.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label7.Location = new System.Drawing.Point(863, 113);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(22, 28);
            label7.TabIndex = 37;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label6.Location = new System.Drawing.Point(863, 64);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(22, 28);
            label6.TabIndex = 36;
            label6.Text = "*";
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(667, 510);
            SaveButton.Margin = new System.Windows.Forms.Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(189, 40);
            SaveButton.TabIndex = 35;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DALabel
            // 
            DALabel.AutoSize = true;
            DALabel.Location = new System.Drawing.Point(267, 159);
            DALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DALabel.Name = "DALabel";
            DALabel.Size = new System.Drawing.Size(0, 28);
            DALabel.TabIndex = 34;
            // 
            // CheckBox
            // 
            CheckBox.AutoSize = true;
            CheckBox.Location = new System.Drawing.Point(247, 514);
            CheckBox.Margin = new System.Windows.Forms.Padding(4);
            CheckBox.Name = "CheckBox";
            CheckBox.Size = new System.Drawing.Size(206, 32);
            CheckBox.TabIndex = 33;
            CheckBox.Text = "Auto connection";
            CheckBox.UseVisualStyleBackColor = true;
            // 
            // SwitchButton
            // 
            SwitchButton.Location = new System.Drawing.Point(464, 510);
            SwitchButton.Margin = new System.Windows.Forms.Padding(4);
            SwitchButton.Name = "SwitchButton";
            SwitchButton.Size = new System.Drawing.Size(189, 40);
            SwitchButton.TabIndex = 32;
            SwitchButton.Text = "Start";
            SwitchButton.UseVisualStyleBackColor = true;
            SwitchButton.Click += SwitchButton_Click;
            // 
            // UAPasswordTextBox
            // 
            UAPasswordTextBox.Location = new System.Drawing.Point(263, 447);
            UAPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            UAPasswordTextBox.Name = "UAPasswordTextBox";
            UAPasswordTextBox.Size = new System.Drawing.Size(157, 34);
            UAPasswordTextBox.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(60, 450);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(195, 28);
            label5.TabIndex = 30;
            label5.Text = "OPC UA Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(66, 289);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(190, 28);
            label3.TabIndex = 27;
            label3.Text = "OPC UA Endpoint";
            // 
            // UAUrlTextBox
            // 
            UAUrlTextBox.Location = new System.Drawing.Point(267, 286);
            UAUrlTextBox.Margin = new System.Windows.Forms.Padding(2);
            UAUrlTextBox.Name = "UAUrlTextBox";
            UAUrlTextBox.Size = new System.Drawing.Size(588, 34);
            UAUrlTextBox.TabIndex = 25;
            // 
            // UAUserTextBox
            // 
            UAUserTextBox.Location = new System.Drawing.Point(263, 400);
            UAUserTextBox.Margin = new System.Windows.Forms.Padding(4);
            UAUserTextBox.Name = "UAUserTextBox";
            UAUserTextBox.Size = new System.Drawing.Size(157, 34);
            UAUserTextBox.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(111, 403);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(145, 28);
            label4.TabIndex = 28;
            label4.Text = "OPC UA User";
            // 
            // DAHostComboBox
            // 
            DAHostComboBox.FormattingEnabled = true;
            DAHostComboBox.Location = new System.Drawing.Point(267, 61);
            DAHostComboBox.Margin = new System.Windows.Forms.Padding(4);
            DAHostComboBox.Name = "DAHostComboBox";
            DAHostComboBox.Size = new System.Drawing.Size(588, 36);
            DAHostComboBox.TabIndex = 0;
            DAHostComboBox.DropDown += DAHostComboBox_DropDown;
            // 
            // DAServerComboBox
            // 
            DAServerComboBox.FormattingEnabled = true;
            DAServerComboBox.Location = new System.Drawing.Point(267, 110);
            DAServerComboBox.Margin = new System.Windows.Forms.Padding(4);
            DAServerComboBox.Name = "DAServerComboBox";
            DAServerComboBox.Size = new System.Drawing.Size(588, 36);
            DAServerComboBox.TabIndex = 1;
            DAServerComboBox.DropDown += DAServerComboBox_DropDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(96, 113);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 28);
            label2.TabIndex = 6;
            label2.Text = "OPC DA Server";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(111, 65);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 28);
            label1.TabIndex = 3;
            label1.Text = "OPC DA Host";
            // 
            // TestButton
            // 
            TestButton.Location = new System.Drawing.Point(667, 159);
            TestButton.Margin = new System.Windows.Forms.Padding(2);
            TestButton.Name = "TestButton";
            TestButton.Size = new System.Drawing.Size(189, 40);
            TestButton.TabIndex = 2;
            TestButton.Text = "Connection Test";
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Click += TestButton_Click;
            // 
            // TabControl
            // 
            TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            TabControl.Controls.Add(TabPageSetting);
            TabControl.Controls.Add(TabPageData);
            TabControl.Controls.Add(TabPageLog);
            TabControl.Controls.Add(TabPageAbout);
            TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            TabControl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TabControl.ItemSize = new System.Drawing.Size(74, 32);
            TabControl.Location = new System.Drawing.Point(0, 0);
            TabControl.Margin = new System.Windows.Forms.Padding(4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new System.Drawing.Size(1333, 788);
            TabControl.TabIndex = 8;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1333, 810);
            Controls.Add(TabControl);
            Controls.Add(statusStrip1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NeuOPC";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            TabPageAbout.ResumeLayout(false);
            TabPageLog.ResumeLayout(false);
            TabPageData.ResumeLayout(false);
            TagContextMenuStrip.ResumeLayout(false);
            TabPageSetting.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel DAStatusLabel;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripStatusLabel UAStatusLabel;
        private System.Windows.Forms.TabPage TabPageAbout;
        private System.Windows.Forms.TabPage TabPageLog;
        private System.Windows.Forms.RichTextBox LogRichTextBox;
        private System.Windows.Forms.TabPage TabPageData;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader rights;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.ColumnHeader quality;
        private System.Windows.Forms.ColumnHeader error;
        private System.Windows.Forms.ColumnHeader timestamp;
        private System.Windows.Forms.ColumnHeader handle;
        private System.Windows.Forms.TabPage TabPageSetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DALabel;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.TextBox UAPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UAUrlTextBox;
        private System.Windows.Forms.TextBox UAUserTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DAHostComboBox;
        private System.Windows.Forms.ComboBox DAServerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.RichTextBox AboutRichTextBox;
        private System.Windows.Forms.ContextMenuStrip TagContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.CheckBox UAIsAllowAnonymous;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox UAMessageMode;
        private System.Windows.Forms.ComboBox UASecurityPolicy;
        private System.Windows.Forms.Label label9;
    }
}

