using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace SoundHotkeys
{
	public partial class SettingsForm : Form
	{
		private static String regSoundsPath = "SOFTWARE\\Tiger Products\\SoundHotKey\\Sounds\\";
		private static String regSettingsPath = "SOFTWARE\\Tiger Products\\SoundHotKey\\Settings\\";

		public static bool justMinimize = false;
		public static bool autosave = true;
		public static bool animate = true;
		public static bool remoteControl = true;
		public static bool ignoreBroadcast = false;

		public static bool NetworkBit = Program.networkbit;
		public static bool ManageNetworkBit = Program.godmode;
		public static bool ToNetwork = false;

		public bool greenIcon = false;

		public Timer play_timer = new Timer();

		public static bool forceClose = false;

		private bool textChanged = false;

		private bool Initialized = false;

		// CONSTRUKTOR
		public SettingsForm()
		{
			InitializeComponent();

			if (!NetworkBit)
			{
				ipAddressTB.Visible = false;
				toNetworkCB.Visible = false;
			}
			if (!ManageNetworkBit)
			{
				remoteControlCB.Visible = false;
				ignoreBroadcastCB.Visible = false;
				remoteControl = true;
				ignoreBroadcast = false;
			}


			SoundClass.ClearHotkeys();
			for (int i = 0; i < 12; i++)
			{
				SoundClass.SetHotkey(new Hotkey("Control + Shift + F" + (i + 1)));
			}

			LoadSettings();

			SoundClass.Form = this;

			play_timer.Tick+= new EventHandler(play_timer_Tick);

			if (!Program.debugmode)
				this.WindowState = FormWindowState.Minimized;

			Initialized = true;

			SaveSettings(false);

			NetworkClass.StartReceiving();

			KeyWatcher.ButtonPushed += new KeyWatcher.ButtonPushedEventHandler(ButtonPushedEvent);
		}

		#region Load & Save
		
		private void SaveSettings(bool soundSave)
		{
			if (!Initialized)
				return;

			#region Sounds mentés
			if (soundSave)
			{
				try { Registry.CurrentUser.DeleteSubKey(regSoundsPath); }
				catch { }

				RegistryKey rSoundskey = Registry.CurrentUser.CreateSubKey(regSoundsPath);
				if (rSoundskey != null)
				{
					try
					{
						SoundClass.ClearSounds();
						SoundClass.SetPath(this.SoundTextBox1.Text);
						SoundClass.SetPath(this.SoundTextBox2.Text);
						SoundClass.SetPath(this.SoundTextBox3.Text);
						SoundClass.SetPath(this.SoundTextBox4.Text);
						SoundClass.SetPath(this.SoundTextBox5.Text);
						SoundClass.SetPath(this.SoundTextBox6.Text);
						SoundClass.SetPath(this.SoundTextBox7.Text);
						SoundClass.SetPath(this.SoundTextBox8.Text);
						SoundClass.SetPath(this.SoundTextBox9.Text);
						SoundClass.SetPath(this.SoundTextBox10.Text);
						SoundClass.SetPath(this.SoundTextBox11.Text);
						SoundClass.SetPath(this.SoundTextBox12.Text);

						for (int i = 0; i < SoundClass.SoundsCount; i++)
						{
							rSoundskey.SetValue("Sound_" + (i + 1), SoundClass.GetPath(i));
						}

						textChanged = false;
					}
					catch (Exception ex)
					{
						String message = "";
						message += "Error during saving!\n";
						message += "Exception caught! Exception Type: : \t" + ex.GetType().ToString() + "\n";
						message += "Exception message:\n";
						message += ex.Message;
						if (ex.InnerException != null)
						{
							message += "Inner Exception Type: : \t" + ex.InnerException.GetType().ToString() + "\n";
							message += "Inner Exception message:\n";
							message += ex.InnerException.Message;
						}
						MessageBox.Show(message);
					}
				}
			}
			#endregion

			#region Settings mentés
			try { Registry.CurrentUser.DeleteSubKey(regSettingsPath); }
			catch { }

			RegistryKey rSettingskey = Registry.CurrentUser.CreateSubKey(regSettingsPath);
			if (rSettingskey != null)
			{
				try
				{
					justMinimize = this.justMinimizeCb.Checked;
					autosave = this.AutoSaveCb.Checked;
					animate = this.AnimateCb.Checked;
					remoteControl = this.remoteControlCB.Checked;
					ignoreBroadcast = this.ignoreBroadcastCB.Checked;

					rSettingskey.SetValue("justMinimize", this.justMinimizeCb.Checked);
					rSettingskey.SetValue("AutoSave", this.AutoSaveCb.Checked);
					rSettingskey.SetValue("AutoStart", this.startupCb.Checked);
					rSettingskey.SetValue("AnimateSystemTray", this.AnimateCb.Checked);
					rSettingskey.SetValue("RemoteControl",this.remoteControlCB.Checked);
					rSettingskey.SetValue("IgnoreBroadcast",this.ignoreBroadcastCB.Checked);

					SoundClass.ClearHotkeys();
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB1.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB2.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB3.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB4.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB5.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB6.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB7.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB8.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB9.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB10.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB11.Text));
					SoundClass.SetHotkey(new Hotkey(keyCodeTextB12.Text));

					for (int i = 0; i < SoundClass.HotkeyCount; i++)
					{
						rSettingskey.SetValue("ShortcutKey_"+i,SoundClass.GetHotkey(i));
					}
				}
				catch (Exception ex)
				{
					String message = "";
					message += "Error during saving!\n";
					message += "Exception caught! Exception Type: : \t" + ex.GetType().ToString() + "\n";
					message += "Exception message:\n";
					message += ex.Message;
					if (ex.InnerException != null)
					{
						message += "Inner Exception Type: : \t" + ex.InnerException.GetType().ToString() + "\n";
						message += "Inner Exception message:\n";
						message += ex.InnerException.Message;
					}
					MessageBox.Show(message);
				}
			}
			#endregion
		}

		private void LoadSettings()
		{
			#region Sounds betöltés
			RegistryKey rSoundskey = Registry.CurrentUser.OpenSubKey(regSoundsPath);
			if (rSoundskey != null)
			{
				try
				{
					SoundClass.ClearSounds();
					for (int i = 0; i < 12; i++)
					{
						String tempValue = (String)rSoundskey.GetValue("Sound_" + (i + 1));
						SoundClass.SetPath(tempValue);
					}

					this.SoundTextBox1.Text = SoundClass.GetPath(0);
					this.SoundTextBox2.Text = SoundClass.GetPath(1);
					this.SoundTextBox3.Text = SoundClass.GetPath(2);
					this.SoundTextBox4.Text = SoundClass.GetPath(3);
					this.SoundTextBox5.Text = SoundClass.GetPath(4);
					this.SoundTextBox6.Text = SoundClass.GetPath(5);
					this.SoundTextBox7.Text = SoundClass.GetPath(6);
					this.SoundTextBox8.Text = SoundClass.GetPath(7);
					this.SoundTextBox9.Text = SoundClass.GetPath(8);
					this.SoundTextBox10.Text = SoundClass.GetPath(9);
					this.SoundTextBox11.Text = SoundClass.GetPath(10);
					this.SoundTextBox12.Text = SoundClass.GetPath(11);

					textChanged = false;
				}
				catch (Exception ex)
				{
					String message = "";
					message += "Error during loading sounds!\n";
					message += "Exception caught! Exception Type: : \t" + ex.GetType().ToString() + "\n";
					message += "Exception message:\n";
					message += ex.Message;
					if (ex.InnerException != null)
					{
						message += "Inner Exception Type: : \t" + ex.InnerException.GetType().ToString() + "\n";
						message += "Inner Exception message:\n";
						message += ex.InnerException.Message;
					}
					MessageBox.Show(message);
				}
			}
			#endregion

			#region Settings betöltés
			RegistryKey rSettingskey = Registry.CurrentUser.OpenSubKey(regSettingsPath);
			if (rSettingskey != null)
			{
				try
				{

					String check = (String)rSettingskey.GetValue("justMinimize");
					this.justMinimizeCb.Checked = bool.Parse(check);
					justMinimize = this.justMinimizeCb.Checked;

					check = (String)rSettingskey.GetValue("AutoSave");
					this.AutoSaveCb.Checked = bool.Parse(check);
					autosave = this.AutoSaveCb.Checked;

					check = (String)rSettingskey.GetValue("AutoStart");
					this.startupCb.Checked = bool.Parse(check);

					check = (String)rSettingskey.GetValue("AnimateSystemTray");
					this.AnimateCb.Checked = bool.Parse(check);
					animate = this.AnimateCb.Checked;

					check = (String)rSettingskey.GetValue("RemoteControl");
					this.remoteControlCB.Checked = bool.Parse(check);
					remoteControl = this.remoteControlCB.Checked;

					check = (String)rSettingskey.GetValue("IgnoreBroadcast");
					this.ignoreBroadcastCB.Checked = bool.Parse(check);
					ignoreBroadcast = this.ignoreBroadcastCB.Checked;


					String hotkey;
					SoundClass.ClearHotkeys();
					for (int i = 0; i < 12; i++)
					{
						hotkey = (String)rSettingskey.GetValue("ShortcutKey_" + i);
						if (hotkey != null)
							SoundClass.SetHotkey(new Hotkey(hotkey));
					}

					ChangeTextboxTexts();
				}
				catch (Exception ex)
				{
					String message = "";
					message += "Error during loading settings!\n";
					message += "Exception caught! Exception Type: : \t" + ex.GetType().ToString() + "\n";
					message += "Exception message:\n";
					message += ex.Message;
					if (ex.InnerException != null)
					{
						message += "Inner Exception Type: : \t" + ex.InnerException.GetType().ToString() + "\n";
						message += "Inner Exception message:\n";
						message += ex.InnerException.Message;
					}
					MessageBox.Show(message);
				}
			}
			#endregion
		}

		private void ChangeTextboxTexts()
		{
			keyCodeTextB1.Text = SoundClass.GetHotkey(0).ToString();
			keyCodeTextB2.Text = SoundClass.GetHotkey(1).ToString();
			keyCodeTextB3.Text = SoundClass.GetHotkey(2).ToString();
			keyCodeTextB4.Text = SoundClass.GetHotkey(3).ToString();
			keyCodeTextB5.Text = SoundClass.GetHotkey(4).ToString();
			keyCodeTextB6.Text = SoundClass.GetHotkey(5).ToString();
			keyCodeTextB7.Text = SoundClass.GetHotkey(6).ToString();
			keyCodeTextB8.Text = SoundClass.GetHotkey(7).ToString();
			keyCodeTextB9.Text = SoundClass.GetHotkey(8).ToString();
			keyCodeTextB10.Text = SoundClass.GetHotkey(9).ToString();
			keyCodeTextB11.Text = SoundClass.GetHotkey(10).ToString();
			keyCodeTextB12.Text = SoundClass.GetHotkey(11).ToString();
		}

		#endregion

		#region Form Events

		private void SettingsForm_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				if (!Program.debugmode)
					Hide();
			}
			else if (SoundClass.SoundsCount > 0 && SoundClass.SoundsCount <= 12)
			{
				this.SoundTextBox1.Text = SoundClass.GetPath(0);
				this.SoundTextBox2.Text = SoundClass.GetPath(1);
				this.SoundTextBox3.Text = SoundClass.GetPath(2);
				this.SoundTextBox4.Text = SoundClass.GetPath(3);
				this.SoundTextBox5.Text = SoundClass.GetPath(4);
				this.SoundTextBox6.Text = SoundClass.GetPath(5);
				this.SoundTextBox7.Text = SoundClass.GetPath(6);
				this.SoundTextBox8.Text = SoundClass.GetPath(7);
				this.SoundTextBox9.Text = SoundClass.GetPath(8);
				this.SoundTextBox10.Text = SoundClass.GetPath(9);
				this.SoundTextBox11.Text = SoundClass.GetPath(10);
				this.SoundTextBox12.Text = SoundClass.GetPath(11);
			}
		}

		private void SettingsForm_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				if (!Program.debugmode)
					Hide();
			}
			else
			{
				this.SoundTextBox1.Text = SoundClass.GetPath(0);
				this.SoundTextBox2.Text = SoundClass.GetPath(1);
				this.SoundTextBox3.Text = SoundClass.GetPath(2);
				this.SoundTextBox4.Text = SoundClass.GetPath(3);
				this.SoundTextBox5.Text = SoundClass.GetPath(4);
				this.SoundTextBox6.Text = SoundClass.GetPath(5);
				this.SoundTextBox7.Text = SoundClass.GetPath(6);
				this.SoundTextBox8.Text = SoundClass.GetPath(7);
				this.SoundTextBox9.Text = SoundClass.GetPath(8);
				this.SoundTextBox10.Text = SoundClass.GetPath(9);
				this.SoundTextBox11.Text = SoundClass.GetPath(10);
				this.SoundTextBox12.Text = SoundClass.GetPath(11);
			}
		}

		private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (textChanged)
			{
				DialogResult result = MessageBox.Show("Save the modifications?", "Save prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

				if (result == System.Windows.Forms.DialogResult.Yes)
					SaveSettings(true);
				else if (result == System.Windows.Forms.DialogResult.Cancel)
					e.Cancel = true;
			}

			if (this.justMinimizeCb.Checked == true && !forceClose)
			{
				this.WindowState = FormWindowState.Minimized;
				e.Cancel = true;
			}
		}

		#endregion

		#region GUI Events

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			SaveSettings(true);
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			LoadSettings();
		}

		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			textChanged = true;
			if (AutoSaveCb.Checked)
			{
				SaveSettings(true);
				textChanged = false;
			}
		}

		private void Checkbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSettings(false);

			if (AutoSaveCb.Checked)
			{
				autosaveLabel.Text = "AutoSave is enabled!";
				CancelBtn.Enabled = false;
			}
			else
			{
				autosaveLabel.Text = "AutoSave is disabled!";
				CancelBtn.Enabled = true;
			}

			if (remoteControlCB.Checked)
			{
				NetworkClass.CurrentState = NetworkClass.NetworkState.Receiving;
				NetworkClass.doNotReceive = false;
				ignoreBroadcastCB.Enabled = true;
			}
			else
			{
				NetworkClass.CurrentState = NetworkClass.NetworkState.None;
				NetworkClass.doNotReceive = true;
				ignoreBroadcastCB.Enabled = false;
			}

			NetworkClass.ignoreBroadcast = ignoreBroadcastCB.Checked;
		}

		private void startupCb_CheckedChanged(object sender, EventArgs e)
		{
			// HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run

			try
			{
				RegistryKey rkey = Registry.CurrentUser.OpenSubKey("\\Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				if (rkey != null)
				{
					// ha true akkor most kell beállítani
					if (startupCb.Checked)
					{

						rkey.SetValue("SoundHotkeys",Path.GetFullPath(Application.ExecutablePath));
					}
					// ha false akkor ki kell szedni
					else
					{
						rkey.SetValue("SoundHotkeys", "");
					}
				}
				else
					MessageBox.Show("null");
			}
			catch (Exception ex)
			{
				String message = "";
				message += "Error during saving!\n";
				message += "Exception caught! Exception Type: : \t" + ex.GetType().ToString() + "\n";
				message += "Exception message:\n";
				message += ex.Message;
				if (ex.InnerException != null)
				{
					message += "Inner Exception Type: : \t" + ex.InnerException.GetType().ToString() + "\n";
					message += "Inner Exception message:\n";
					message += ex.InnerException.Message;
				}
				MessageBox.Show(message);
			}
		}

		private void PlayBtn_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;

			String index_s = button.Name.Substring("PlayBtn".Length);
			int index = int.Parse(index_s);

			SoundClass.Play(index - 1);
		}

		private void HotKeyTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			Keys key = e.KeyCode;
			Hotkey pressedKeys = new Hotkey();

			if (e.Modifiers.ToString().Contains(Keys.Control.ToString()))
				pressedKeys.Add(Keys.Control);
			if (e.Modifiers.ToString().Contains(Keys.Shift.ToString()))
				pressedKeys.Add(Keys.Shift);
			if (e.Modifiers.ToString().Contains(Keys.Alt.ToString()))
				pressedKeys.Add(Keys.Alt);

			bool doNotAdd = false;

			if (key.ToString().Contains(Keys.Control.ToString()))
				doNotAdd = true;
			if (key.ToString().Contains(Keys.Shift.ToString()))
				doNotAdd = true;
			if (key.ToString().Contains(Keys.Alt.ToString()))
				doNotAdd = true;

			if (!doNotAdd)
				pressedKeys.Add(key);

			String name = ((TextBox)sender).Name;
			int hossz = "keyCodeTextB".Length;
			name = name.Substring(hossz);

			int id = 0;
			int.TryParse(name, out id);

			id--;

			if (id >= 0 && id <= SoundClass.HotkeyCount)
			{
				SoundClass.SetHotkey(id, pressedKeys);

				((TextBox)sender).Text = SoundClass.GetHotkey(id).ToString();
			}
			ChangeTextboxTexts();
		}

		private void HotKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			String name = ((TextBox)sender).Name;
			int hossz = "keyCodeTextB".Length;
			name = name.Substring(hossz);

			int id = 0;
			int.TryParse(name, out id);

			id--;

			if (id >= 0 && id < SoundClass.HotkeyCount)
			{
				((TextBox)sender).Text = SoundClass.GetHotkey(id).ToString();
			}

			textChanged = true;
			if (AutoSaveCb.Checked)
			{
				SaveSettings(true);
				textChanged = false;
			}
		}

		#endregion

		#region System Tray

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveSettings(true);
			forceClose = true;
			Application.Exit();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadSettings();
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void play_timer_Tick(object sender, EventArgs e)
		{
			if (greenIcon)
			{
				play_timer.Stop();
				SetIcon(false,true);
			}
		}

		public void SetIcon(bool toGreen, bool toRed)
		{
			if (AnimateCb.Checked)
			{
				if (toGreen && !toRed)
				{
					this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(IconResources.SoundHotKeys_icon_green));
					greenIcon = true;
				}
				else if (toRed && !toGreen)
				{
					this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(IconResources.SoundHotKeys_icon_red));
					greenIcon = false;
				}
			}
		}

		

		#endregion

		#region Network GUI

		private void ipAddressTB_TextChanged(object sender, EventArgs e)
		{
			Regex ipRegex = new Regex("[0-2]?[0-9]?[0-9]\\.[0-2]?[0-9]?[0-9]\\.[0-2]?[0-9]?[0-9]\\.[0-2]?[0-9]?[0-9]");

			if (ipRegex.IsMatch(ipAddressTB.Text))
			{
				System.Net.IPAddress newAddress = System.Net.IPAddress.Parse("0.0.0.0");

				bool success = false;
				try
				{
					success = System.Net.IPAddress.TryParse(ipAddressTB.Text, out newAddress);
				}
				catch
				{
					success = false;
				}
				
				if (!success)
				{
					MessageBox.Show("Not valid IP Address!");
				}

				if (newAddress != null && newAddress.Address != System.Net.IPAddress.Parse("0.0.0.0").Address)
				{
					NetworkClass.dstToSendAddress = newAddress;
				}
			}
		}

		private void toNetworkCB_CheckedChanged(object sender, EventArgs e)
		{
			if (Program.offline)
			{
				toNetworkCB.Enabled = false;
				toNetworkCB.Checked = false;
				ToNetwork = false;
				ipAddressTB.Enabled = false;
				//MessageBox.Show("You are in offline mode!");
			}
			else
			{
				ipAddressTB_TextChanged(sender, e);
				ToNetwork = toNetworkCB.Checked;
			}
		}

		#endregion

		private void ButtonPushedEvent(Hotkey keys)
		{
			 if (!Program.networkbit) // network bit should be enabled, or it returns and does nothing
				return;

			if (keys.Equals(new Hotkey(Keys.Capital.ToString())))
			{
				Keys networkKey = Keys.CapsLock;
				SettingsForm.ToNetwork = !Control.IsKeyLocked(networkKey);
				toNetworkCB.Checked = ToNetwork;
				if (Program.debugmode)
					Console.WriteLine("Network key (" + networkKey + ") state is " + ToNetwork);
			}

			if (keys.Equals(new Hotkey(Keys.Scroll.ToString())))
			{
				Keys hardPlayKey = Keys.Scroll;
				NetworkClass.hardPlay = !Control.IsKeyLocked(hardPlayKey);
				if (Program.debugmode)
					Console.WriteLine("Hard play key (" + hardPlayKey + ") state is " + NetworkClass.hardPlay);
			}
		}

		private void PoolCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox cb = sender as CheckBox;
			if (sender == null)
				return;
			

		}

	}// end of class

}// end of namespace
