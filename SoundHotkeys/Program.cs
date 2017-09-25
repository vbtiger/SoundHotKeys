using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SoundHotkeys
{
	internal static class NativeMethods
	{
		[DllImport("kernel32.dll")]
		internal static extern Boolean AllocConsole();
	}
	static class Program
	{
		public static bool debugmode = false;
		public static bool networkbit = false;
		public static bool godmode = false;
		public static bool offline = false;

		private const int WH_KEYBOARD_LL = 13;
		private const int WM_KEYDOWN = 0x0100;
		private const int WM_SYSKEYDOWN = 0x0104;
		private static LowLevelKeyboardProc _proc = HookCallback;
		private static IntPtr _hookID = IntPtr.Zero;

		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length > 0)
			{
				for (int i = 0; i < args.Length; i++)
				{
					if (String.Compare(args[i].ToLower(), "debug") == 0)
						Program.debugmode = true;

					if (String.Compare(args[i].ToLower(), "network") == 0)
						Program.networkbit = true;

					if (String.Compare(args[i].ToLower(), "offline") == 0)
						Program.offline = true;

					if (String.Compare(args[i].ToLower(), "g") == 0)
						Program.godmode = true;

					String TimePassword = DateTime.Now.Day + "" + DateTime.Now.Hour;
					if (String.Compare(args[i].ToLower(), TimePassword) == 0)
						Program.godmode = true;
				}
			}

			if (Program.debugmode)
				NativeMethods.AllocConsole();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			SettingsForm SForm = new SettingsForm();
			
			_hookID = SetHook(_proc);

			Application.Run(SForm);
			
			UnhookWindowsHookEx(_hookID);
		}

		private static IntPtr SetHook(LowLevelKeyboardProc proc)
		{
			using (Process curProcess = Process.GetCurrentProcess())
			using (ProcessModule curModule = curProcess.MainModule)
			{
				return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
			}
		}

		private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

		private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		
		{
			 if (nCode >= 0 && ( wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN ) )
			{
				int vkCode = Marshal.ReadInt32(lParam);

				KeyWatcher.PushedButtons(vkCode);

			}
			return CallNextHookEx(_hookID, nCode, wParam, lParam);
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);
	}
}
