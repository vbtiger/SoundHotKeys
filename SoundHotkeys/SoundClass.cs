using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Runtime.InteropServices;

namespace SoundHotkeys
{
	static class SoundClass
	{
		private static List<Hotkey> hotkeys = new List<Hotkey>();
		private static List<String> sounds = new List<String>();
		private static List<bool> pools = new List<bool>();

		private static List<String> hardSounds = new List<String>();
		private static bool initialized = false;

		private static SettingsForm formReference;


		public static void Play(int index)
		{
			String filename = "";

			if (index >= 0 && index < sounds.Count)
				filename = sounds.ElementAt(index);

			if (filename != null && filename != "")
			{
				if (System.IO.File.Exists(filename))
				{
					try
					{
						System.Media.SoundPlayer player = new SoundPlayer();

						player.SoundLocation = filename;
						int length = GetSoundLength(index);

						player.Play();

						formReference.play_timer.Interval = length;
						formReference.play_timer.Enabled = true;
						formReference.play_timer.Start();
						formReference.greenIcon = true;
						formReference.SetIcon(true, false);
					}
					catch (System.IO.FileNotFoundException) { return; }
					catch { return; }
				}
				else if (System.IO.Directory.Exists(filename))
				{
					String[] files = System.IO.Directory.GetFiles(filename);
					int randomIndex = new Random().Next(files.Length);

					////////////////////////////////////////////////////
					try
					{
						System.Media.SoundPlayer player = new SoundPlayer();

						player.SoundLocation = files[randomIndex];
						int length = GetSoundLength(index);

						player.Play();

						formReference.play_timer.Interval = length;
						formReference.play_timer.Enabled = true;
						formReference.play_timer.Start();
						formReference.greenIcon = true;
						formReference.SetIcon(true, false);
					}
					catch (System.IO.FileNotFoundException) { return; }
					catch { return; }
					////////////////////////////////////////////////////
				}
			}
		}

		public static void HardPlay(int index)
		{
			if (!initialized)
				Initialize();

			String filename = "";

			if (index >= 0 && index < hardSounds.Count)
				filename = hardSounds.ElementAt(index);

			if (filename != null && filename != "")
			{
				try
				{
					System.Media.SoundPlayer player = new SoundPlayer();

					player.SoundLocation = filename;
					int length = GetSoundLength(index);

					player.Play();

					formReference.play_timer.Interval = length;
					formReference.play_timer.Enabled = true;
					formReference.play_timer.Start();
					formReference.greenIcon = true;
					formReference.SetIcon(true, false);
				}
				catch (System.IO.FileNotFoundException) { return; }
				catch { return; }
			}
		}

		private static void Initialize()
		{
			String MediaFolder = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			MediaFolder += "\\Media\\";

			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");
			hardSounds.Add(MediaFolder + "tada.wav");

			initialized = true;
		}

		public static String GetPath(int index)
		{
			if (index >= 0 && index < sounds.Count)
				return sounds.ElementAt(index);
			else
				return null;
		}

		public static void SetPath(String newPath)
		{
			sounds.Add(newPath);
		}

		public static void SetPath(int index, String newPath)
		{
			if (index >= 0 && index < sounds.Count)
			{
				sounds.RemoveAt(index);
				sounds.Insert(index, newPath);
			}
		}

		public static Hotkey GetHotkey(int index)
		{
			if (index >= 0 && index < hotkeys.Count)
				return hotkeys.ElementAt(index);
			else
				return null;
		}

		public static void SetHotkey(Hotkey newHotkey)
		{
			hotkeys.Add(newHotkey);
		}

		public static void SetHotkey(int index, Hotkey newHotkey)
		{
			if (index >= 0 && index < hotkeys.Count)
			{
				hotkeys.RemoveAt(index);
				hotkeys.Insert(index, newHotkey);
			}
		}

		public static void ClearSounds()
		{
			sounds.Clear();
		}

		public static void ClearHotkeys()
		{
			hotkeys.Clear();
		}

		public static int HotkeyCount
		{
			get { return hotkeys.Count; }
		}

		public static int SoundsCount
		{
			get { return sounds.Count; }
		}

		public static SettingsForm Form
		{
			set { formReference = value; }
		}

		[DllImport("winmm.dll")]
		private static extern uint mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);
		
		private static int GetSoundLength(int index)
		{
			try
			{
				StringBuilder lengthBuf = new StringBuilder(32);

				mciSendString(string.Format("open \"{0}\" type waveaudio alias wave", sounds.ElementAt(index)), null, 0, IntPtr.Zero);
				mciSendString("status wave length", lengthBuf, lengthBuf.Capacity, IntPtr.Zero);
				mciSendString("close wave", null, 0, IntPtr.Zero);

				int length = 0;
				int.TryParse(lengthBuf.ToString(), out length);

				return length;
			}
			catch (Exception)
			{
				return 0;
			}
		}
	}
}
