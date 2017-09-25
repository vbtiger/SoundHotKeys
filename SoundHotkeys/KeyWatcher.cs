using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoundHotkeys
{
	public static class KeyWatcher
	{
		public delegate void ButtonPushedEventHandler(Hotkey keys);

		public static event ButtonPushedEventHandler ButtonPushed;

		public static void PushedButtons(int keyCode)
		{
			if (Program.debugmode)
			{
				String realPressed = "";
				realPressed += "vkCode: " + keyCode + " \n";
				realPressed += "Key: " + (Keys)keyCode + " \n";
				realPressed += "ModifierKeys: " + Control.ModifierKeys + " \n";
				Console.WriteLine(realPressed);
			}

			Keys key = (Keys)keyCode;
			Hotkey pressedKeys = new Hotkey();

			if (Control.ModifierKeys.ToString().Contains(Keys.Control.ToString()))
				pressedKeys.Add(Keys.Control);
			if (Control.ModifierKeys.ToString().Contains(Keys.Shift.ToString()))
				pressedKeys.Add(Keys.Shift);
			if (Control.ModifierKeys.ToString().Contains(Keys.Alt.ToString()))
				pressedKeys.Add(Keys.Alt);

			bool doNotAdd = false;

			if (key.ToString().Contains(Keys.Control.ToString()))
				doNotAdd = true;
			if (key.ToString().Contains(Keys.Shift.ToString()))
				doNotAdd = true;
			if (key.ToString().Contains(Keys.Alt.ToString()))
				doNotAdd = true;

			if(!doNotAdd)
				pressedKeys.Add(key);

			/* HARD CODED EXIT COMBO */
			Hotkey exitCombo = new Hotkey("Control + Shift + Alt + Delete");
			if (pressedKeys.Equals(exitCombo))
			{
				SettingsForm.forceClose = true;
				Application.Exit();
			}
			/* HARD CODED EXIT COMBO */

			ButtonPushed(pressedKeys);

			for (int i = 0; i < SoundClass.HotkeyCount; i++)
			{
				if (pressedKeys.Equals(SoundClass.GetHotkey(i)))
				{
					 if (SettingsForm.ToNetwork)
					{
						NetworkClass.Send(i.ToString());
					}
					else
					{
						if(NetworkClass.hardPlay && Program.godmode)
							SoundClass.HardPlay(i);
						else
							SoundClass.Play(i);
					}
				}
			}

			if (Program.debugmode)
				Console.WriteLine(pressedKeys.ToString());
		}
	} // end class

	public class Hotkey
	{
		private List<Keys> keys = new List<Keys>();

		private static int ID = 0;

		private int ownID = 0;

		public Hotkey()
		{
			ownID = ID;
			ID++;
		}

		public Hotkey(String unformattedText)
		{
			ownID = ID;
			ID++;

			this.AddUnformatted(unformattedText);
		}

		public int Count
		{
			get { return this.keys.Count; }
		}

		public void Add(Keys newKey)
		{
			this.keys.Add(newKey);
		}

		public void AddUnformatted(String unformattedText)
		{
			// szétszedjük
			String[] splitted = unformattedText.Split('+');

			// ha invalid akkor nem csinálunk semmit
			if (splitted.Length == 0 || (splitted.Length > 0 && splitted[0] == ""))
				return;

			// eltüntetjük belőle a szóközöket
			for (int i = 0; i < splitted.Length; i++)
			{ splitted[i] = splitted[i].Trim(); }

			KeysConverter converter = new KeysConverter();

			// megkeressük a gombokat és hozzáadjuk
			for (int i = 0; i < splitted.Length; i++)
			{
				try
				{
					Keys button = (Keys)converter.ConvertFromString(splitted[i]);
					this.Add(button);
				}
				catch (Exception ex)
				{
					String message = "";
					message += "Error during convert!\n";
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

		public Keys ElementAt(int index)
		{
			return this.keys.ElementAt(index);
		}

		public void Clear()
		{
			this.keys.Clear();
			
		}

		public override bool Equals(object obj)
		{
			Hotkey compareObject = (Hotkey)obj;

			if (this.Count != compareObject.Count)
				return false;
			else
			{
				bool match = true;
				for (int i = 0; i < this.Count; i++)
				{
					bool found = false;
					for (int j = 0; j < compareObject.Count; j++)
					{
						if (this.ElementAt(i) == compareObject.ElementAt(j))
							found = true;
						if (this.ElementAt(i) == Keys.None || compareObject.ElementAt(j) == Keys.None)
							return false;
					}
					match = match && found;
				}
				return match;
			}
		}

		public static bool operator ==(Hotkey left, Hotkey rigth)
		{
			return left.Equals(rigth);
		}

		public static bool operator !=(Hotkey left, Hotkey rigth)
		{
			return left.Equals(rigth);
		}

		public override int GetHashCode()
		{
			int hash = ownID;

			for (int i = 0; i < this.Count; i++)
			{
				hash += (int)this.ElementAt(i) * this.Count;
			}

			return hash;
		}

		public override string ToString()
		{
			String result = "";

			for (int i = 0; i < this.Count; i++)
			{
				result += this.ElementAt(i).ToString();
				if (i + 1 < this.Count)
					result += " + ";
			}

			return result;
		}

	} // end class
}
