using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SERVER
{
    class Program
    {
		private static string steampath_orig = "C:\\Program Files (x86)\\Steam\\";

		private static string steampath = "C:\\Program Files (x86)\\Steam\\";

		private const int SWP_NOSIZE = 1;

		private const int SWP_NOZORDER = 4;

		private const int SWP_SHOWWINDOW = 64;

		private static string account = "";

		private static string login = "";

		private static string leader1 = "";

		private static string leader2 = "";

		private static string password = "";

		private static string parameters = "";

		private static string accid = "";

		private static string whichlobby = "WIN";

		private static string pid64 = "";

		private static string leadertext0 = " | BOT";

		private static string leadertext1 = " | LEADER #1";

		private static string leadertext2 = " | LEADER #2";

		private static string totaltext = " | BOT";

		private static bool wh = false;

		private static string databasename = "panel";

		private const int SW_HIDE = 0;

		private const int SW_SHOW = 5;

		private const int SW_SHOWNORMAL = 1;

		private const int SW_SHOWMINIMIZED = 2;

		private const int SW_SHOWMAXIMIZED = 3;

		private static string parsnew = "";

		[DllImport("kernel32.dll")]
		private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);

		private List<string> GetKeys(string iniFile, string category)
		{
			byte[] array = new byte[2048];
			GetPrivateProfileSection(category, array, 2048, iniFile);
			string[] array2 = Encoding.ASCII.GetString(array).Trim(default(char)).Split(default(char));
			List<string> list = new List<string>();
			string[] array3 = array2;
			foreach (string text in array3)
			{
				list.Add(text.Substring(0, text.IndexOf("=")));
			}
			return list;
		}

		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

		public void IniWriteValue(string Section, string Key, string Value, string path)
		{
			WritePrivateProfileString(Section, Key, Value, path);
		}

		public static string IniReadValue(string Section, string Key, string path)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			GetPrivateProfileString(Section, Key, "", stringBuilder, 255, path);
			return stringBuilder.ToString();
		}

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

		public static void SetWindowPosition(Process p, int x, int y)
		{
			IntPtr mainWindowHandle = p.MainWindowHandle;
			if (mainWindowHandle != IntPtr.Zero)
			{
				SetWindowPos(mainWindowHandle, IntPtr.Zero, x, y, 0, 0, 69);
			}
		}

		private static bool getpath()
		{
			if (File.Exists(Directory.GetCurrentDirectory() + "/settings/main.ini"))
			{
				if (IniReadValue("SLAURUSSE", "STEAM", Directory.GetCurrentDirectory() + "/settings/main.ini") != "")
				{
					steampath_orig = IniReadValue("SLAURUSSE", "STEAM", Directory.GetCurrentDirectory() + "/settings/main.ini");
					return true;
				}
				return false;
			}
			return false;
		}

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		[DllImport("user32.dll")]
		private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

		private static void hide()
		{
			ShowWindowAsync(GetConsoleWindow(), 2);
		}

		private static void show()
		{
			ShowWindowAsync(GetConsoleWindow(), 1);
		}

		private static void fetchpars()
		{
			MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=127.0.0.1;User Id=root;Password=");
			MySqlCommand mySqlCommand = new MySqlCommand();
			string text2 = (mySqlCommand.CommandText = "SELECT * FROM disconnects WHERE id=1;");
			mySqlCommand.Connection = connection;
			try
			{
				mySqlCommand.Connection.Open();
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					parsnew = mySqlDataReader["lose"].ToString();
				}
			}
			catch (MySqlException)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear();
				Console.WriteLine("Unknown Error");
				Console.ReadKey();
				Environment.Exit(0);
			}
			finally
			{
				mySqlCommand.Connection.Close();
			}
		}

		private static string fetchleader1()
		{
			MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=127.0.0.1;User Id=root;Password=");
			MySqlCommand mySqlCommand = new MySqlCommand();
			string text2 = (mySqlCommand.CommandText = "SELECT * FROM leaders WHERE id=1;");
			mySqlCommand.Connection = connection;
			try
			{
				mySqlCommand.Connection.Open();
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					leader1 = mySqlDataReader["login"].ToString();
				}
			}
			catch (MySqlException)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear();
				Console.WriteLine("Unknown Error");
				Console.ReadKey();
				Environment.Exit(0);
			}
			finally
			{
				mySqlCommand.Connection.Close();
			}
			return leader1;
		}

		private static string fetchleader2()
		{
			MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=127.0.0.1;User Id=root;Password=");
			MySqlCommand mySqlCommand = new MySqlCommand();
			string text2 = (mySqlCommand.CommandText = "SELECT * FROM leaders WHERE id=2;");
			mySqlCommand.Connection = connection;
			try
			{
				mySqlCommand.Connection.Open();
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					leader2 = mySqlDataReader["login"].ToString();
				}
			}
			catch (MySqlException)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear();
				Console.WriteLine("Unknown Error");
				Console.ReadKey();
				Environment.Exit(0);
			}
			finally
			{
				mySqlCommand.Connection.Close();
			}
			return leader1;
		}

		private static void fetchinfo(string mylogin)
		{
			MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=127.0.0.1;User Id=root;Password=");
			MySqlCommand mySqlCommand = new MySqlCommand();
			string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts WHERE login='" + mylogin + "';");
			mySqlCommand.Connection = connection;
			try
			{
				mySqlCommand.Connection.Open();
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					login = mySqlDataReader["login"].ToString();
					password = mySqlDataReader["password"].ToString();
					parameters = mySqlDataReader["parameters"].ToString();
					pid64 = mySqlDataReader["profile"].ToString();
					accid = mySqlDataReader["userid"].ToString();
					whichlobby = mySqlDataReader["whichlobby"].ToString();
				}
			}
			catch (MySqlException)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear();
				Console.WriteLine("Unknown Error");
				Console.ReadKey();
				Environment.Exit(0);
			}
			finally
			{
				mySqlCommand.Connection.Close();
			}
		}

		private static void fetchsettings()
		{
			MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=127.0.0.1;User Id=root;Password=");
			MySqlCommand mySqlCommand = new MySqlCommand();
			string text2 = (mySqlCommand.CommandText = "SELECT * FROM settings WHERE id='1';");
			mySqlCommand.Connection = connection;
			try
			{
				mySqlCommand.Connection.Open();
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					steampath = mySqlDataReader["steam"].ToString();
					steampath_orig = steampath;
				}
			}
			catch (MySqlException)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear();
				Console.WriteLine("Unknown Error");
				Console.ReadKey();
				Environment.Exit(0);
			}
			finally
			{
				mySqlCommand.Connection.Close();
			}
		}

		[STAThread]
		private static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.WriteLine("HELLO!");
			Console.Title = "IT IS AVAST ACCOUNT LAUNCHER";
			Thread.Sleep(100);
			Thread.Sleep(300);
			Console.Title = "IT IS AVAST ACCOUNT LAUNCHER";
			Thread.Sleep(100);
			Console.Clear();
			if (args.Length == 0)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear();
				Console.WriteLine("ARGUMENTS DOESN'T EXISTS (ERROR CODE: 1)");
				Console.ReadKey();
				return;
			}
			account = args[0];
			databasename = args[1];
			if (account == "client" || account == "client1" || account == "client2" || account == "client3" || account == "client4" || account == "client5")
			{
				Console.Title = "@ ACCOUNT: invite | LOGIN: " + account + " | BOT";
				Console.WriteLine("[SYSTEM] INVITE CODE PARSED SUCCESSFULLY!");
				hide();
				Console.ReadKey();
				return;
			}
			fetchpars();
			fetchinfo(account);
			fetchsettings();
			fetchleader1();
			fetchleader2();
			if (Directory.Exists(steampath_orig) && File.Exists(steampath_orig + "Steam.exe"))
			{
				wh = false;
				steampath = steampath_orig + "Steam_" + accid + ".exe";
				if (leader1 == account)
				{
					totaltext = leadertext1;
				}
				else if (leader2 == account)
				{
					totaltext = leadertext2;
				}
				else
				{
					totaltext = leadertext0;
				}
				if (File.Exists(steampath))
				{
					Process process = new Process();
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.FileName = "cmd.exe";
					processStartInfo.Arguments = "/C \"" + steampath + "\" -login " + login + " " + password + "  -applaunch 730 -language " + accid + " -window -w 640 -h 480 " + parameters + " " + parsnew + " -language " + accid;
					process.StartInfo = processStartInfo;
					process.Start();
					using (NamedPipeServerStream namedPipeServerStream = new NamedPipeServerStream(login, PipeDirection.InOut))
                    {
						using (StreamReader streamReader = new StreamReader(namedPipeServerStream))
						{
							using (StreamWriter streamWriter = new StreamWriter(namedPipeServerStream))
							{
								Console.WriteLine("[SYSTEM] @ ACCOUNT: " + accid + " | LOGIN: " + login + totaltext);
								Console.Title = "@ ACCOUNT: " + whichlobby + " | LOGIN: " + login + totaltext;
								Console.WriteLine("[SYSTEM] SERVER IS RUNNING...");
								hide();
								while (true)
								{
									try
									{
										namedPipeServerStream.WaitForConnection();
										streamWriter.AutoFlush = true;
										string text;
										while ((text = streamReader.ReadLine()) != null)
										{
											switch (text)
											{
												case "kill":
													Console.WriteLine("[CLIENT] REQUEST: CLOSE ACCOUNT");
													try
													{
														foreach (Process item in from pr in Process.GetProcesses()
																				 where pr.ProcessName == "csgo"
																				 select pr)
														{
															if (item.MainWindowTitle.Contains("@ " + login + totaltext + " @"))
															{
																item.Kill();
															}
														}
													}
													catch (Exception)
													{
													}
													try
													{
														foreach (Process item2 in from pr in Process.GetProcesses()
																				  where pr.ProcessName == "Steam_" + accid
																				  select pr)
														{
															item2.Kill();
														}
													}
													catch (Exception)
													{
													}
													break;
												case "steam":
													{
														Console.WriteLine("[CLIENT] REQUEST: OPEN STEAM");
														Process process4 = new Process();
														process4.StartInfo = new ProcessStartInfo
														{
															WindowStyle = ProcessWindowStyle.Hidden,
															FileName = "cmd.exe",
															Arguments = "/C call \"" + steampath + "\" steam://open/games"
														};
														process4.Start();
														break;
													}
												case "quit":
													Console.WriteLine("[CLIENT] REQUEST: STOP SERVER");
													Console.WriteLine("[SYSTEM] STOPPING SERVER...");
													Thread.Sleep(5555);
													try
													{
														foreach (Process item3 in from pr in Process.GetProcesses()
																				  where pr.ProcessName == "csgo"
																				  select pr)
														{
															if (item3.MainWindowTitle.Contains("@ " + login + totaltext + " @"))
															{
																item3.Kill();
															}
														}
													}
													catch (Exception)
													{
													}
													try
													{
														foreach (Process item4 in from pr in Process.GetProcesses()
																				  where pr.ProcessName == "Steam_" + accid
																				  select pr)
														{
															item4.Kill();
														}
													}
													catch (Exception)
													{
													}
													Environment.Exit(0);
													break;
												case "hide":
													if (!wh)
													{
														Console.WriteLine("[CLIENT] REQUEST: HIDE CONSOLE");
														wh = true;
														hide();
													}
													break;
												case "clear":
													if (!wh)
													{
														Console.Clear();
														Console.WriteLine("[CLIENT] REQUEST: CLEAR CONSOLE");
													}
													break;
												case "show":
													if (wh)
													{
														Console.WriteLine("[CLIENT] REQUEST: SHOW CONSOLE");
														wh = false;
														show();
													}
													break;
												case "start":
													{
														Console.WriteLine("[CLIENT] REQUEST: START ACCOUNT");
														Process process3 = new Process();
														process3.StartInfo = processStartInfo;
														process3.Start();
														break;
													}
												case "restart":
													{
														Console.WriteLine("[CLIENT] REQUEST: RESTART ACCOUNT");
														try
														{
															foreach (Process item5 in from pr in Process.GetProcesses()
																					  where pr.ProcessName == "csgo"
																					  select pr)
															{
																if (item5.MainWindowTitle.Contains("@ " + login + totaltext + " @"))
																{
																	item5.Kill();
																}
															}
														}
														catch (Exception)
														{
														}
														try
														{
															foreach (Process item6 in from pr in Process.GetProcesses()
																					  where pr.ProcessName == "Steam_" + accid
																					  select pr)
															{
																item6.Kill();
															}
														}
														catch (Exception)
														{
														}
														Thread.Sleep(5555);
														Process process2 = new Process();
														process2.StartInfo = processStartInfo;
														process2.Start();
														break;
													}
												default:
													Console.WriteLine("[SYSTEM] REQUESTED UNKNOWN COMMAND (ERROR CODE: 0)");
													break;
											}
											streamReader.DiscardBufferedData();
											text = null;
										}
									}
									catch (Exception)
									{
										throw;
									}
									finally
									{
										namedPipeServerStream.Disconnect();
									}
								}
							}
						}
					}
					
				}
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear();
				Console.WriteLine("WRONG DIRECTORY (ERROR CODE: 5)");
				Console.ReadKey();
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear();
				Console.WriteLine("WRONG DIRECTORY (ERROR CODE: 3)");
				Console.ReadKey();
			}
		}
	}
}
