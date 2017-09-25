namespace SoundHotkeys
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.SystemTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SoundTextBox1 = new System.Windows.Forms.TextBox();
			this.SoundTextBox2 = new System.Windows.Forms.TextBox();
			this.SoundTextBox3 = new System.Windows.Forms.TextBox();
			this.SoundTextBox4 = new System.Windows.Forms.TextBox();
			this.SoundTextBox5 = new System.Windows.Forms.TextBox();
			this.SoundTextBox6 = new System.Windows.Forms.TextBox();
			this.SoundTextBox7 = new System.Windows.Forms.TextBox();
			this.SoundTextBox8 = new System.Windows.Forms.TextBox();
			this.SoundTextBox9 = new System.Windows.Forms.TextBox();
			this.SoundTextBox10 = new System.Windows.Forms.TextBox();
			this.SoundTextBox11 = new System.Windows.Forms.TextBox();
			this.SoundTextBox12 = new System.Windows.Forms.TextBox();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.SoundsTabPage = new System.Windows.Forms.TabPage();
			this.PlayBtn12 = new System.Windows.Forms.Button();
			this.PlayBtn11 = new System.Windows.Forms.Button();
			this.PlayBtn10 = new System.Windows.Forms.Button();
			this.PlayBtn9 = new System.Windows.Forms.Button();
			this.PlayBtn8 = new System.Windows.Forms.Button();
			this.PlayBtn7 = new System.Windows.Forms.Button();
			this.PlayBtn6 = new System.Windows.Forms.Button();
			this.PlayBtn5 = new System.Windows.Forms.Button();
			this.PlayBtn4 = new System.Windows.Forms.Button();
			this.PlayBtn3 = new System.Windows.Forms.Button();
			this.PlayBtn1 = new System.Windows.Forms.Button();
			this.PlayBtn2 = new System.Windows.Forms.Button();
			this.toNetworkCB = new System.Windows.Forms.CheckBox();
			this.ipAddressTB = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.keyCodeTextB12 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.keyCodeTextB11 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.keyCodeTextB10 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.keyCodeTextB9 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.keyCodeTextB8 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.keyCodeTextB7 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.keyCodeTextB6 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.keyCodeTextB5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.keyCodeTextB4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.keyCodeTextB3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.keyCodeTextB2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.keyCodeTextB1 = new System.Windows.Forms.TextBox();
			this.autosaveLabel = new System.Windows.Forms.Label();
			this.SettingsTabPage = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ignoreBroadcastCB = new System.Windows.Forms.CheckBox();
			this.remoteControlCB = new System.Windows.Forms.CheckBox();
			this.AnimateCb = new System.Windows.Forms.CheckBox();
			this.startupCb = new System.Windows.Forms.CheckBox();
			this.AutoSaveCb = new System.Windows.Forms.CheckBox();
			this.justMinimizeCb = new System.Windows.Forms.CheckBox();
			this.SystemTrayMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SoundsTabPage.SuspendLayout();
			this.SettingsTabPage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SystemTrayIcon
			// 
			this.SystemTrayIcon.ContextMenuStrip = this.SystemTrayMenu;
			this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
			this.SystemTrayIcon.Text = "SoundHotKeys";
			this.SystemTrayIcon.Visible = true;
			// 
			// SystemTrayMenu
			// 
			this.SystemTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.SystemTrayMenu.Name = "SystemTrayMenu";
			this.SystemTrayMenu.Size = new System.Drawing.Size(117, 48);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// SoundTextBox1
			// 
			this.SoundTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox1.Location = new System.Drawing.Point(214, 6);
			this.SoundTextBox1.Name = "SoundTextBox1";
			this.SoundTextBox1.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox1.TabIndex = 2;
			this.SoundTextBox1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox2
			// 
			this.SoundTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox2.Location = new System.Drawing.Point(214, 32);
			this.SoundTextBox2.Name = "SoundTextBox2";
			this.SoundTextBox2.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox2.TabIndex = 4;
			this.SoundTextBox2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox3
			// 
			this.SoundTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox3.Location = new System.Drawing.Point(214, 58);
			this.SoundTextBox3.Name = "SoundTextBox3";
			this.SoundTextBox3.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox3.TabIndex = 6;
			this.SoundTextBox3.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox4
			// 
			this.SoundTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox4.Location = new System.Drawing.Point(214, 84);
			this.SoundTextBox4.Name = "SoundTextBox4";
			this.SoundTextBox4.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox4.TabIndex = 8;
			this.SoundTextBox4.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox5
			// 
			this.SoundTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox5.Location = new System.Drawing.Point(214, 110);
			this.SoundTextBox5.Name = "SoundTextBox5";
			this.SoundTextBox5.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox5.TabIndex = 10;
			this.SoundTextBox5.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox6
			// 
			this.SoundTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox6.Location = new System.Drawing.Point(214, 136);
			this.SoundTextBox6.Name = "SoundTextBox6";
			this.SoundTextBox6.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox6.TabIndex = 12;
			this.SoundTextBox6.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox7
			// 
			this.SoundTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox7.Location = new System.Drawing.Point(214, 162);
			this.SoundTextBox7.Name = "SoundTextBox7";
			this.SoundTextBox7.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox7.TabIndex = 14;
			this.SoundTextBox7.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox8
			// 
			this.SoundTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox8.Location = new System.Drawing.Point(214, 188);
			this.SoundTextBox8.Name = "SoundTextBox8";
			this.SoundTextBox8.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox8.TabIndex = 16;
			this.SoundTextBox8.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox9
			// 
			this.SoundTextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox9.Location = new System.Drawing.Point(214, 214);
			this.SoundTextBox9.Name = "SoundTextBox9";
			this.SoundTextBox9.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox9.TabIndex = 18;
			this.SoundTextBox9.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox10
			// 
			this.SoundTextBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox10.Location = new System.Drawing.Point(214, 240);
			this.SoundTextBox10.Name = "SoundTextBox10";
			this.SoundTextBox10.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox10.TabIndex = 20;
			this.SoundTextBox10.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox11
			// 
			this.SoundTextBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox11.Location = new System.Drawing.Point(214, 266);
			this.SoundTextBox11.Name = "SoundTextBox11";
			this.SoundTextBox11.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox11.TabIndex = 22;
			this.SoundTextBox11.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SoundTextBox12
			// 
			this.SoundTextBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SoundTextBox12.Location = new System.Drawing.Point(214, 292);
			this.SoundTextBox12.Name = "SoundTextBox12";
			this.SoundTextBox12.Size = new System.Drawing.Size(218, 20);
			this.SoundTextBox12.TabIndex = 24;
			this.SoundTextBox12.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// SaveBtn
			// 
			this.SaveBtn.Location = new System.Drawing.Point(318, 318);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(50, 23);
			this.SaveBtn.TabIndex = 25;
			this.SaveBtn.Text = "Save";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Location = new System.Drawing.Point(374, 318);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(62, 23);
			this.CancelBtn.TabIndex = 27;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.SoundsTabPage);
			this.tabControl1.Controls.Add(this.SettingsTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(488, 372);
			this.tabControl1.TabIndex = 29;
			// 
			// SoundsTabPage
			// 
			this.SoundsTabPage.BackColor = System.Drawing.SystemColors.Control;
			this.SoundsTabPage.Controls.Add(this.PlayBtn12);
			this.SoundsTabPage.Controls.Add(this.PlayBtn11);
			this.SoundsTabPage.Controls.Add(this.PlayBtn10);
			this.SoundsTabPage.Controls.Add(this.PlayBtn9);
			this.SoundsTabPage.Controls.Add(this.PlayBtn8);
			this.SoundsTabPage.Controls.Add(this.PlayBtn7);
			this.SoundsTabPage.Controls.Add(this.PlayBtn6);
			this.SoundsTabPage.Controls.Add(this.PlayBtn5);
			this.SoundsTabPage.Controls.Add(this.PlayBtn4);
			this.SoundsTabPage.Controls.Add(this.PlayBtn3);
			this.SoundsTabPage.Controls.Add(this.PlayBtn1);
			this.SoundsTabPage.Controls.Add(this.PlayBtn2);
			this.SoundsTabPage.Controls.Add(this.toNetworkCB);
			this.SoundsTabPage.Controls.Add(this.ipAddressTB);
			this.SoundsTabPage.Controls.Add(this.label24);
			this.SoundsTabPage.Controls.Add(this.label25);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB12);
			this.SoundsTabPage.Controls.Add(this.label22);
			this.SoundsTabPage.Controls.Add(this.label23);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB11);
			this.SoundsTabPage.Controls.Add(this.label20);
			this.SoundsTabPage.Controls.Add(this.label21);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB10);
			this.SoundsTabPage.Controls.Add(this.label18);
			this.SoundsTabPage.Controls.Add(this.label19);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB9);
			this.SoundsTabPage.Controls.Add(this.label16);
			this.SoundsTabPage.Controls.Add(this.label17);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB8);
			this.SoundsTabPage.Controls.Add(this.label14);
			this.SoundsTabPage.Controls.Add(this.label15);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB7);
			this.SoundsTabPage.Controls.Add(this.label12);
			this.SoundsTabPage.Controls.Add(this.label13);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB6);
			this.SoundsTabPage.Controls.Add(this.label10);
			this.SoundsTabPage.Controls.Add(this.label11);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB5);
			this.SoundsTabPage.Controls.Add(this.label8);
			this.SoundsTabPage.Controls.Add(this.label9);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB4);
			this.SoundsTabPage.Controls.Add(this.label6);
			this.SoundsTabPage.Controls.Add(this.label7);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB3);
			this.SoundsTabPage.Controls.Add(this.label4);
			this.SoundsTabPage.Controls.Add(this.label5);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB2);
			this.SoundsTabPage.Controls.Add(this.label3);
			this.SoundsTabPage.Controls.Add(this.label2);
			this.SoundsTabPage.Controls.Add(this.keyCodeTextB1);
			this.SoundsTabPage.Controls.Add(this.autosaveLabel);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox1);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox2);
			this.SoundsTabPage.Controls.Add(this.CancelBtn);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox3);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox12);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox4);
			this.SoundsTabPage.Controls.Add(this.SaveBtn);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox5);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox11);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox6);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox10);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox7);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox9);
			this.SoundsTabPage.Controls.Add(this.SoundTextBox8);
			this.SoundsTabPage.Location = new System.Drawing.Point(4, 22);
			this.SoundsTabPage.Name = "SoundsTabPage";
			this.SoundsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.SoundsTabPage.Size = new System.Drawing.Size(480, 346);
			this.SoundsTabPage.TabIndex = 0;
			this.SoundsTabPage.Text = "Sounds";
			// 
			// PlayBtn12
			// 
			this.PlayBtn12.Location = new System.Drawing.Point(438, 290);
			this.PlayBtn12.Name = "PlayBtn12";
			this.PlayBtn12.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn12.TabIndex = 81;
			this.PlayBtn12.Text = "Play";
			this.PlayBtn12.UseVisualStyleBackColor = true;
			this.PlayBtn12.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn11
			// 
			this.PlayBtn11.Location = new System.Drawing.Point(438, 264);
			this.PlayBtn11.Name = "PlayBtn11";
			this.PlayBtn11.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn11.TabIndex = 80;
			this.PlayBtn11.Text = "Play";
			this.PlayBtn11.UseVisualStyleBackColor = true;
			this.PlayBtn11.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn10
			// 
			this.PlayBtn10.Location = new System.Drawing.Point(438, 238);
			this.PlayBtn10.Name = "PlayBtn10";
			this.PlayBtn10.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn10.TabIndex = 79;
			this.PlayBtn10.Text = "Play";
			this.PlayBtn10.UseVisualStyleBackColor = true;
			this.PlayBtn10.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn9
			// 
			this.PlayBtn9.Location = new System.Drawing.Point(438, 212);
			this.PlayBtn9.Name = "PlayBtn9";
			this.PlayBtn9.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn9.TabIndex = 78;
			this.PlayBtn9.Text = "Play";
			this.PlayBtn9.UseVisualStyleBackColor = true;
			this.PlayBtn9.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn8
			// 
			this.PlayBtn8.Location = new System.Drawing.Point(438, 186);
			this.PlayBtn8.Name = "PlayBtn8";
			this.PlayBtn8.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn8.TabIndex = 77;
			this.PlayBtn8.Text = "Play";
			this.PlayBtn8.UseVisualStyleBackColor = true;
			this.PlayBtn8.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn7
			// 
			this.PlayBtn7.Location = new System.Drawing.Point(438, 160);
			this.PlayBtn7.Name = "PlayBtn7";
			this.PlayBtn7.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn7.TabIndex = 76;
			this.PlayBtn7.Text = "Play";
			this.PlayBtn7.UseVisualStyleBackColor = true;
			this.PlayBtn7.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn6
			// 
			this.PlayBtn6.Location = new System.Drawing.Point(438, 134);
			this.PlayBtn6.Name = "PlayBtn6";
			this.PlayBtn6.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn6.TabIndex = 75;
			this.PlayBtn6.Text = "Play";
			this.PlayBtn6.UseVisualStyleBackColor = true;
			this.PlayBtn6.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn5
			// 
			this.PlayBtn5.Location = new System.Drawing.Point(438, 108);
			this.PlayBtn5.Name = "PlayBtn5";
			this.PlayBtn5.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn5.TabIndex = 74;
			this.PlayBtn5.Text = "Play";
			this.PlayBtn5.UseVisualStyleBackColor = true;
			this.PlayBtn5.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn4
			// 
			this.PlayBtn4.Location = new System.Drawing.Point(438, 82);
			this.PlayBtn4.Name = "PlayBtn4";
			this.PlayBtn4.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn4.TabIndex = 73;
			this.PlayBtn4.Text = "Play";
			this.PlayBtn4.UseVisualStyleBackColor = true;
			this.PlayBtn4.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn3
			// 
			this.PlayBtn3.Location = new System.Drawing.Point(438, 56);
			this.PlayBtn3.Name = "PlayBtn3";
			this.PlayBtn3.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn3.TabIndex = 72;
			this.PlayBtn3.Text = "Play";
			this.PlayBtn3.UseVisualStyleBackColor = true;
			this.PlayBtn3.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn1
			// 
			this.PlayBtn1.Location = new System.Drawing.Point(438, 4);
			this.PlayBtn1.Name = "PlayBtn1";
			this.PlayBtn1.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn1.TabIndex = 71;
			this.PlayBtn1.Text = "Play";
			this.PlayBtn1.UseVisualStyleBackColor = true;
			this.PlayBtn1.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayBtn2
			// 
			this.PlayBtn2.Location = new System.Drawing.Point(438, 30);
			this.PlayBtn2.Name = "PlayBtn2";
			this.PlayBtn2.Size = new System.Drawing.Size(37, 23);
			this.PlayBtn2.TabIndex = 70;
			this.PlayBtn2.Text = "Play";
			this.PlayBtn2.UseVisualStyleBackColor = true;
			this.PlayBtn2.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// toNetworkCB
			// 
			this.toNetworkCB.AutoSize = true;
			this.toNetworkCB.Location = new System.Drawing.Point(111, 322);
			this.toNetworkCB.Name = "toNetworkCB";
			this.toNetworkCB.Size = new System.Drawing.Size(78, 17);
			this.toNetworkCB.TabIndex = 68;
			this.toNetworkCB.Text = "to Network";
			this.toNetworkCB.UseVisualStyleBackColor = true;
			this.toNetworkCB.CheckedChanged += new System.EventHandler(this.toNetworkCB_CheckedChanged);
			this.toNetworkCB.Click += new System.EventHandler(this.toNetworkCB_CheckedChanged);
			// 
			// ipAddressTB
			// 
			this.ipAddressTB.Location = new System.Drawing.Point(8, 320);
			this.ipAddressTB.Name = "ipAddressTB";
			this.ipAddressTB.Size = new System.Drawing.Size(97, 20);
			this.ipAddressTB.TabIndex = 67;
			this.ipAddressTB.Text = "192.168.0.100";
			this.ipAddressTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ipAddressTB.Click += new System.EventHandler(this.toNetworkCB_CheckedChanged);
			this.ipAddressTB.TextChanged += new System.EventHandler(this.ipAddressTB_TextChanged);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(6, 295);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(44, 13);
			this.label24.TabIndex = 64;
			this.label24.Text = "Hotkey:";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(166, 295);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(41, 13);
			this.label25.TabIndex = 63;
			this.label25.Text = "Sound:";
			// 
			// keyCodeTextB12
			// 
			this.keyCodeTextB12.Location = new System.Drawing.Point(48, 292);
			this.keyCodeTextB12.Name = "keyCodeTextB12";
			this.keyCodeTextB12.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB12.TabIndex = 62;
			this.keyCodeTextB12.Text = "Control + Shift + F12";
			this.keyCodeTextB12.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(6, 269);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(44, 13);
			this.label22.TabIndex = 61;
			this.label22.Text = "Hotkey:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(166, 269);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(41, 13);
			this.label23.TabIndex = 60;
			this.label23.Text = "Sound:";
			// 
			// keyCodeTextB11
			// 
			this.keyCodeTextB11.Location = new System.Drawing.Point(48, 266);
			this.keyCodeTextB11.Name = "keyCodeTextB11";
			this.keyCodeTextB11.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB11.TabIndex = 59;
			this.keyCodeTextB11.Text = "Control + Shift + F11";
			this.keyCodeTextB11.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(6, 243);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(44, 13);
			this.label20.TabIndex = 58;
			this.label20.Text = "Hotkey:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(166, 243);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(41, 13);
			this.label21.TabIndex = 57;
			this.label21.Text = "Sound:";
			// 
			// keyCodeTextB10
			// 
			this.keyCodeTextB10.Location = new System.Drawing.Point(48, 240);
			this.keyCodeTextB10.Name = "keyCodeTextB10";
			this.keyCodeTextB10.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB10.TabIndex = 56;
			this.keyCodeTextB10.Text = "Control + Shift + F10";
			this.keyCodeTextB10.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 217);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(44, 13);
			this.label18.TabIndex = 55;
			this.label18.Text = "Hotkey:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(166, 217);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 13);
			this.label19.TabIndex = 54;
			this.label19.Text = "Sound:";
			// 
			// keyCodeTextB9
			// 
			this.keyCodeTextB9.Location = new System.Drawing.Point(48, 214);
			this.keyCodeTextB9.Name = "keyCodeTextB9";
			this.keyCodeTextB9.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB9.TabIndex = 53;
			this.keyCodeTextB9.Text = "Control + Shift + F9";
			this.keyCodeTextB9.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 191);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(44, 13);
			this.label16.TabIndex = 52;
			this.label16.Text = "Hotkey:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(166, 191);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(41, 13);
			this.label17.TabIndex = 51;
			this.label17.Text = "Sound:";
			// 
			// keyCodeTextB8
			// 
			this.keyCodeTextB8.Location = new System.Drawing.Point(48, 188);
			this.keyCodeTextB8.Name = "keyCodeTextB8";
			this.keyCodeTextB8.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB8.TabIndex = 50;
			this.keyCodeTextB8.Text = "Control + Shift + F8";
			this.keyCodeTextB8.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 165);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 13);
			this.label14.TabIndex = 49;
			this.label14.Text = "Hotkey:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(166, 165);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 13);
			this.label15.TabIndex = 48;
			this.label15.Text = "Sound:";
			// 
			// keyCodeTextB7
			// 
			this.keyCodeTextB7.Location = new System.Drawing.Point(48, 162);
			this.keyCodeTextB7.Name = "keyCodeTextB7";
			this.keyCodeTextB7.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB7.TabIndex = 47;
			this.keyCodeTextB7.Text = "Control + Shift + F7";
			this.keyCodeTextB7.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 139);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(44, 13);
			this.label12.TabIndex = 46;
			this.label12.Text = "Hotkey:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(166, 139);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(41, 13);
			this.label13.TabIndex = 45;
			this.label13.Text = "Sound:";
			// 
			// keyCodeTextB6
			// 
			this.keyCodeTextB6.Location = new System.Drawing.Point(48, 136);
			this.keyCodeTextB6.Name = "keyCodeTextB6";
			this.keyCodeTextB6.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB6.TabIndex = 44;
			this.keyCodeTextB6.Text = "Control + Shift + F6";
			this.keyCodeTextB6.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 113);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 13);
			this.label10.TabIndex = 43;
			this.label10.Text = "Hotkey:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(166, 113);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(41, 13);
			this.label11.TabIndex = 42;
			this.label11.Text = "Sound:";
			// 
			// keyCodeTextB5
			// 
			this.keyCodeTextB5.Location = new System.Drawing.Point(48, 110);
			this.keyCodeTextB5.Name = "keyCodeTextB5";
			this.keyCodeTextB5.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB5.TabIndex = 41;
			this.keyCodeTextB5.Text = "Control + Shift + F5";
			this.keyCodeTextB5.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 13);
			this.label8.TabIndex = 40;
			this.label8.Text = "Hotkey:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(166, 87);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 13);
			this.label9.TabIndex = 39;
			this.label9.Text = "Sound:";
			// 
			// keyCodeTextB4
			// 
			this.keyCodeTextB4.Location = new System.Drawing.Point(48, 84);
			this.keyCodeTextB4.Name = "keyCodeTextB4";
			this.keyCodeTextB4.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB4.TabIndex = 38;
			this.keyCodeTextB4.Text = "Control + Shift + F4";
			this.keyCodeTextB4.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 37;
			this.label6.Text = "Hotkey:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(166, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 36;
			this.label7.Text = "Sound:";
			// 
			// keyCodeTextB3
			// 
			this.keyCodeTextB3.Location = new System.Drawing.Point(48, 58);
			this.keyCodeTextB3.Name = "keyCodeTextB3";
			this.keyCodeTextB3.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB3.TabIndex = 35;
			this.keyCodeTextB3.Text = "Control + Shift + F3";
			this.keyCodeTextB3.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "Hotkey:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(166, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 33;
			this.label5.Text = "Sound:";
			// 
			// keyCodeTextB2
			// 
			this.keyCodeTextB2.Location = new System.Drawing.Point(48, 32);
			this.keyCodeTextB2.Name = "keyCodeTextB2";
			this.keyCodeTextB2.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB2.TabIndex = 32;
			this.keyCodeTextB2.Text = "Control + Shift + F2";
			this.keyCodeTextB2.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "Hotkey:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(166, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 30;
			this.label2.Text = "Sound:";
			// 
			// keyCodeTextB1
			// 
			this.keyCodeTextB1.Location = new System.Drawing.Point(48, 6);
			this.keyCodeTextB1.Name = "keyCodeTextB1";
			this.keyCodeTextB1.Size = new System.Drawing.Size(112, 20);
			this.keyCodeTextB1.TabIndex = 29;
			this.keyCodeTextB1.Text = "Control + Shift + F1";
			this.keyCodeTextB1.TextChanged += new System.EventHandler(this.HotKeyTextBox_TextChanged);
			this.keyCodeTextB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
			// 
			// autosaveLabel
			// 
			this.autosaveLabel.AutoSize = true;
			this.autosaveLabel.Location = new System.Drawing.Point(204, 323);
			this.autosaveLabel.Name = "autosaveLabel";
			this.autosaveLabel.Size = new System.Drawing.Size(108, 13);
			this.autosaveLabel.TabIndex = 28;
			this.autosaveLabel.Text = "AutoSave is enabled!";
			this.autosaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SettingsTabPage
			// 
			this.SettingsTabPage.BackColor = System.Drawing.SystemColors.Control;
			this.SettingsTabPage.Controls.Add(this.groupBox1);
			this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
			this.SettingsTabPage.Name = "SettingsTabPage";
			this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.SettingsTabPage.Size = new System.Drawing.Size(503, 346);
			this.SettingsTabPage.TabIndex = 1;
			this.SettingsTabPage.Text = "Settings";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ignoreBroadcastCB);
			this.groupBox1.Controls.Add(this.remoteControlCB);
			this.groupBox1.Controls.Add(this.AnimateCb);
			this.groupBox1.Controls.Add(this.startupCb);
			this.groupBox1.Controls.Add(this.AutoSaveCb);
			this.groupBox1.Controls.Add(this.justMinimizeCb);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 340);
			this.groupBox1.TabIndex = 39;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Main Settings";
			// 
			// ignoreBroadcastCB
			// 
			this.ignoreBroadcastCB.AutoSize = true;
			this.ignoreBroadcastCB.Location = new System.Drawing.Point(5, 124);
			this.ignoreBroadcastCB.Name = "ignoreBroadcastCB";
			this.ignoreBroadcastCB.Size = new System.Drawing.Size(160, 17);
			this.ignoreBroadcastCB.TabIndex = 34;
			this.ignoreBroadcastCB.Text = "Ignore Broadcast messages.";
			this.ignoreBroadcastCB.UseVisualStyleBackColor = true;
			this.ignoreBroadcastCB.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
			// 
			// remoteControlCB
			// 
			this.remoteControlCB.AutoSize = true;
			this.remoteControlCB.Checked = true;
			this.remoteControlCB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.remoteControlCB.Location = new System.Drawing.Point(5, 101);
			this.remoteControlCB.Name = "remoteControlCB";
			this.remoteControlCB.Size = new System.Drawing.Size(124, 17);
			this.remoteControlCB.TabIndex = 33;
			this.remoteControlCB.Text = "Allow remote control.";
			this.remoteControlCB.UseVisualStyleBackColor = true;
			this.remoteControlCB.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
			// 
			// AnimateCb
			// 
			this.AnimateCb.AutoSize = true;
			this.AnimateCb.Checked = true;
			this.AnimateCb.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AnimateCb.Location = new System.Drawing.Point(5, 78);
			this.AnimateCb.Name = "AnimateCb";
			this.AnimateCb.Size = new System.Drawing.Size(205, 17);
			this.AnimateCb.TabIndex = 32;
			this.AnimateCb.Text = "Animated system tray icon during play.";
			this.AnimateCb.UseVisualStyleBackColor = true;
			this.AnimateCb.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
			// 
			// startupCb
			// 
			this.startupCb.AutoSize = true;
			this.startupCb.Enabled = false;
			this.startupCb.Location = new System.Drawing.Point(6, 317);
			this.startupCb.Name = "startupCb";
			this.startupCb.Size = new System.Drawing.Size(136, 17);
			this.startupCb.TabIndex = 31;
			this.startupCb.Text = "Start on system startup.";
			this.startupCb.UseVisualStyleBackColor = true;
			this.startupCb.Visible = false;
			this.startupCb.CheckedChanged += new System.EventHandler(this.startupCb_CheckedChanged);
			// 
			// AutoSaveCb
			// 
			this.AutoSaveCb.AutoSize = true;
			this.AutoSaveCb.Checked = true;
			this.AutoSaveCb.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoSaveCb.Location = new System.Drawing.Point(5, 42);
			this.AutoSaveCb.Name = "AutoSaveCb";
			this.AutoSaveCb.Size = new System.Drawing.Size(298, 30);
			this.AutoSaveCb.TabIndex = 30;
			this.AutoSaveCb.Text = "Auto save every modification.\r\n(only effect Sounds tab, Settings tab is autosaved" +
    " always)";
			this.AutoSaveCb.UseVisualStyleBackColor = true;
			this.AutoSaveCb.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
			// 
			// justMinimizeCb
			// 
			this.justMinimizeCb.AutoSize = true;
			this.justMinimizeCb.Location = new System.Drawing.Point(6, 19);
			this.justMinimizeCb.Name = "justMinimizeCb";
			this.justMinimizeCb.Size = new System.Drawing.Size(206, 17);
			this.justMinimizeCb.TabIndex = 29;
			this.justMinimizeCb.Text = "Close button just minimize the window.";
			this.justMinimizeCb.UseVisualStyleBackColor = true;
			this.justMinimizeCb.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 372);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "SoundHotKeys";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
			this.Shown += new System.EventHandler(this.SettingsForm_Shown);
			this.Resize += new System.EventHandler(this.SettingsForm_Resize);
			this.SystemTrayMenu.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.SoundsTabPage.ResumeLayout(false);
			this.SoundsTabPage.PerformLayout();
			this.SettingsTabPage.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon SystemTrayIcon;
		private System.Windows.Forms.ContextMenuStrip SystemTrayMenu;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TextBox SoundTextBox1;
		private System.Windows.Forms.TextBox SoundTextBox2;
		private System.Windows.Forms.TextBox SoundTextBox3;
		private System.Windows.Forms.TextBox SoundTextBox4;
		private System.Windows.Forms.TextBox SoundTextBox5;
		private System.Windows.Forms.TextBox SoundTextBox6;
		private System.Windows.Forms.TextBox SoundTextBox7;
		private System.Windows.Forms.TextBox SoundTextBox8;
		private System.Windows.Forms.TextBox SoundTextBox9;
		private System.Windows.Forms.TextBox SoundTextBox10;
		private System.Windows.Forms.TextBox SoundTextBox11;
		private System.Windows.Forms.TextBox SoundTextBox12;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage SoundsTabPage;
		private System.Windows.Forms.TabPage SettingsTabPage;
		private System.Windows.Forms.CheckBox AutoSaveCb;
		private System.Windows.Forms.CheckBox justMinimizeCb;
		private System.Windows.Forms.Label autosaveLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox startupCb;
		private System.Windows.Forms.CheckBox AnimateCb;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox keyCodeTextB12;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox keyCodeTextB11;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox keyCodeTextB10;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox keyCodeTextB9;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox keyCodeTextB8;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox keyCodeTextB7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox keyCodeTextB6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox keyCodeTextB5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox keyCodeTextB4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox keyCodeTextB3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox keyCodeTextB2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox keyCodeTextB1;
		private System.Windows.Forms.TextBox ipAddressTB;
		private System.Windows.Forms.CheckBox toNetworkCB;
		private System.Windows.Forms.Button PlayBtn2;
		private System.Windows.Forms.Button PlayBtn1;
		private System.Windows.Forms.Button PlayBtn11;
		private System.Windows.Forms.Button PlayBtn10;
		private System.Windows.Forms.Button PlayBtn9;
		private System.Windows.Forms.Button PlayBtn8;
		private System.Windows.Forms.Button PlayBtn7;
		private System.Windows.Forms.Button PlayBtn6;
		private System.Windows.Forms.Button PlayBtn5;
		private System.Windows.Forms.Button PlayBtn4;
		private System.Windows.Forms.Button PlayBtn3;
		private System.Windows.Forms.Button PlayBtn12;
		private System.Windows.Forms.CheckBox remoteControlCB;
		private System.Windows.Forms.CheckBox ignoreBroadcastCB;

	}
}