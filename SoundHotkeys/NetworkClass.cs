using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace SoundHotkeys
{
	static class NetworkClass
	{
		// egyszerre csak egy történhet, alapvetően a szál fogadja az adatokat (receive)
		// de ha küldeni akarunk akkor sending-be vált és küld, majd újra vissza receiveing-be
		// PUBLIC
		public enum NetworkState { Sending, Receiving, None };
		// PUBLIC
		public static IPAddress ownAddress; // amit a receive vizsgál
		// PUBLIC
		public static IPAddress dstToSendAddress; // ahova a send küld
		// PUBLIC
		public static int udpPort = 11000;
		// PUBLIC
		public static NetworkState CurrentState = NetworkState.None;
		// PUBLIC
		public static bool doNotReceive
		{
			get { return donotreceive; }
			set
			{
				bool temp = donotreceive;
				donotreceive = value;
				if (donotreceive)
				{
					if (udpClient != null)
						udpClient.Close();
					receiveThread.Abort();
				}
				else if(donotreceive == false && temp != donotreceive)
				{
					StartReceiving();
				}
			}
		}
		// PUBLIC
		public static bool ignoreBroadcast = false;
		// PUBLIC
		public static bool hardPlay = false;

		private  static bool donotreceive = false;

		// 500 [ms] => fél másodpercenként ellenőrzi, de egy üres kérés esetén blokkolódik a futás és vár hogy olvashasson
		// az eredmény így azt eredményezi, hogy egy gombnyomás után vár 500ms-ot
		private static int CheckTime = 500;

		private static bool initialized = false;

		private static UdpClient udpClient;

		private static Thread receiveThread = null;



		private static string ConvertFromIP(long param)
		{
			string returnvalue = "";
			long tmp;

			tmp = (param & 255);
			returnvalue = returnvalue + tmp + ".";
			tmp = (param & 65280) >> 8;
			returnvalue = returnvalue + tmp + ".";
			tmp = (param & 16711680) >> 16;
			returnvalue = returnvalue + tmp + ".";
			tmp = (param & 4278190080) >> 24;
			returnvalue = returnvalue + tmp;

			return returnvalue;
		}


		private static void Initialize()
		{
			if (Program.offline)
			{
				NetworkClass.dstToSendAddress = IPAddress.Parse("127.0.0.1");
				NetworkClass.ownAddress = IPAddress.Parse("127.0.0.1");

				initialized = true;
				return;
			}

			bool found = false;
			foreach (System.Net.NetworkInformation.NetworkInterface ni in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
			{
				if (!found)
					foreach (System.Net.NetworkInformation.UnicastIPAddressInformation uipi in ni.GetIPProperties().UnicastAddresses)
					{
						if (uipi.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
						{
							try
							{
								bool CanContinue = true;
								ownAddress = new IPAddress(uipi.Address.Address);

								try
								{
									if (Program.debugmode)
										Console.WriteLine("Testing mainAddress...");
									System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();
									bool throwexception = false;
									string status = "";
									try
									{
										System.Net.NetworkInformation.PingReply reply = pinger.Send(ownAddress, 50);
										if (reply.Status != System.Net.NetworkInformation.IPStatus.Success)
											throwexception = true;
										status = reply.Status.ToString();
									}
									catch
									{
										throw new System.Net.NetworkInformation.PingException("Not valid IP address: " + ConvertFromIP(ownAddress.Address));
									}
									if (throwexception)
										throw new System.Net.NetworkInformation.PingException("Not valid IP address: " + ConvertFromIP(ownAddress.Address) + " Ping reply status: " + status);
								}
								catch (System.Net.NetworkInformation.PingException e)
								{
									ownAddress = new IPAddress(0);
									CanContinue = false;
									if (Program.debugmode)
										Console.WriteLine(e.Message);
								}

								if (CanContinue)
								{
									if (Program.debugmode)
										Console.WriteLine("Testing result: mainAddress seems to be valid. Address is: " + ConvertFromIP(ownAddress.Address));
									found = true;
									initialized = true;
								}
							}
							catch (Exception e)
							{
								if (Program.debugmode)
									Console.WriteLine(e.Message);
							}
						}
					}
			}
		}


		#region RECEIVING

		// PUBLIC - creating new thread and starting the Receive method
		public static void StartReceiving()
		{
			if (!initialized)
				Initialize();

			if (initialized)
			{
				CurrentState = NetworkState.Receiving;

				if (receiveThread == null)
				{
					receiveThread = new Thread(new ThreadStart(Receive));
					receiveThread.IsBackground = true;
					receiveThread.Priority = ThreadPriority.Lowest;
					receiveThread.Start();
				}
				else
				{
					try
					{
						receiveThread.Resume();
					}
					catch
					{
						if (udpClient != null)
							udpClient.Close();
						receiveThread.Abort();
						receiveThread = null;

						StartReceiving();
					}
					
				}
			}
		}

		// the data receiver - watching incomming data in an infinite loop
		private static void Receive()
		{
			receiveThread = Thread.CurrentThread;
			try
			{
				udpClient = new UdpClient(udpPort);
			}
			catch (Exception)
			{
				string errorMsg = "";
				errorMsg += "Trying to create new UdpClient failed.\n";
				errorMsg += "Possibly not valid IP found during initialization.\n";
				errorMsg += "If you do not have a valid connection, please restart the program with the 'offline' switch!\n";
				errorMsg += "In command line eg.: SoundHotKeys.exe offline";

				if (Program.debugmode)
					Console.WriteLine(errorMsg);
				else
					MessageBox.Show(errorMsg);

				NetworkClass.dstToSendAddress = IPAddress.Parse("127.0.0.1");
				NetworkClass.ownAddress = IPAddress.Parse("127.0.0.1");
				Program.offline = true;
			}

			while (true)
			{
				if (ownAddress != null && CurrentState == NetworkState.Receiving && udpClient != null)
				{
					try
					{
						if (Program.debugmode)
							Console.WriteLine("Trying to read from remote IP...");
						IPEndPoint RemoteIpEndPoint = new IPEndPoint(ownAddress, udpPort);

						Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
						string returnData = Encoding.ASCII.GetString(receiveBytes);

						DataReceived(receiveBytes);

						if (Program.debugmode)
						{
							Console.WriteLine("This is the message you received :");
							Console.WriteLine(returnData.ToString());
							Console.WriteLine("This message was sent from :" + RemoteIpEndPoint.Address.ToString() + " on their port number :" + RemoteIpEndPoint.Port.ToString());
						}
					}
					catch (Exception e)
					{
						if (Program.debugmode)
							Console.WriteLine("Exception in: Receive(..)\n" + e.ToString());
						try
						{
							if (Program.debugmode)
								Console.WriteLine("Error in udpClient. Trying to make a new one.");
							udpClient = new UdpClient(udpPort);
						}
						catch (Exception)
						{
							if (Program.debugmode)
								Console.WriteLine("Exception in: Receive(..)\n" + e.ToString());
						}
					}
				}

				Thread.Sleep(CheckTime);
			}
		}

		// Data decoding
		private static void DataReceived(byte[] data)
		{
			int index = -1;
			if (data.Length >= 2)
			{
				String[] sData = Encoding.ASCII.GetString(data).Split(';');
				String playType = sData[0]; // Normal / Hard

				index = int.Parse(sData[1]); // should be a number

				if (index >= 0 && index < SoundClass.SoundsCount)
				{
					if (String.Compare(playType, "Normal") == 0)
						SoundClass.Play(index);
					else if (String.Compare(playType, "Hard") == 0)
						SoundClass.HardPlay(index);
				}
			}
		}

		#endregion


		#region SENDING

		public static void Send(String dataToSend)
		{
			if (!initialized)
				Initialize();

			if (initialized && SettingsForm.NetworkBit)
			{
				try
				{
					if (dstToSendAddress != null)
					{
						CurrentState = NetworkState.Sending;
						if (receiveThread != null)
						{
							receiveThread.Suspend();
						}
						if (udpClient != null)
						{
							udpClient.Close();
						}

						udpClient = new UdpClient(udpPort);

						if (hardPlay && Program.godmode)
							dataToSend = "Hard;" + dataToSend;
						else
							dataToSend = "Normal;" + dataToSend;

						Byte[] sendBytes = Encoding.ASCII.GetBytes(dataToSend.ToString());

						byte endDstIP = dstToSendAddress.GetAddressBytes()[3];
						byte broadcastEndIp = 255;
						if (endDstIP == broadcastEndIp && Program.godmode == false)
							return;

						if (Program.debugmode)
							Console.WriteLine("Sending \n" + dataToSend + "\n to " + ConvertFromIP(dstToSendAddress.Address) + "...");

						udpClient.Send(sendBytes, sendBytes.Length, new IPEndPoint(dstToSendAddress, udpPort));

						if (Program.debugmode)
							Console.WriteLine("Sent.");

						udpClient.Close();

						CurrentState = NetworkState.Receiving;
						StartReceiving();
					}
				}
				catch (Exception e)
				{
					if (Program.debugmode)
						Console.WriteLine("Exception in: Send(..)\n" + e.ToString());
				}
			}
		}

		#endregion

		private static void GetInformation()
		{

		}




		/*
		private static void test()
		{
			int port = udpPort;

			UdpClient client = new UdpClient();

			client.Client.EnableBroadcast = ignoreBroadcast;
			client.Client.Bind(new IPEndPoint(ownAddress, port));
			client.BeginReceive(_Callback, client);

			Socket sock = new Socket(AddressFamily.InterNetwork,
			SocketType.Dgram, ProtocolType.Udp);

			sock.EnableBroadcast = true;

			string strMessage;
			IPEndPoint epSend = new IPEndPoint(IPAddress.Broadcast,
			((IPEndPoint)client.Client.LocalEndPoint).Port);

			Console.WriteLine("Enter messages, one message per line (enter blank line to exit):");
			while ((strMessage = Console.ReadLine()) != "")
			{
				byte[] rgb = Encoding.UTF8.GetBytes(strMessage);

				Console.WriteLine("Sending: \"{0}\"", strMessage);
				sock.SendTo(rgb, epSend);
			}

			client.Close();
			sock.Close();

			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}

		static private void _Callback(IAsyncResult iar)
		{
			try
			{
				UdpClient client = (UdpClient)iar.AsyncState;

				client.BeginReceive(_Callback, client);

				IPEndPoint ipRemote = new IPEndPoint(IPAddress.Any, 0);

				byte[] rgb = client.EndReceive(iar, ref ipRemote);

				Console.WriteLine("Received {0} bytes: \"{1}\"",
				rgb.Length.ToString(), Encoding.UTF8.GetString(rgb));
			}
			catch (ObjectDisposedException)
			{
				Console.WriteLine("closing listening socket");
			}
			catch (Exception exc)
			{
				Console.WriteLine("Listening socket error: \"" +
				exc.Message + "\"");
			}

		}*/

	} // end of class
}
