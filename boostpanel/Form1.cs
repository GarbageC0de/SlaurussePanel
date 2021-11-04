using boostpanel.Utils;
using CSGSI;
using CSGSI.Nodes;
using Flurl.Http;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Management;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace boostpanel
{
    public partial class Form1 : Form
    {
        public struct POINT
        {
            public int X;

            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        public struct RECT
        {
            public int Left;

            public int Top;

            public int Right;

            public int Bottom;
        }

        private class User32
        {
            public struct Rect
            {
                public int left;

                public int top;

                public int right;

                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr parameter);

        private static string xuserx = "Slaurusse";

        private static string leader1 = "";

        private static string leader2 = "";

        private static readonly HttpClient client = new HttpClient();

        private static byte[] steamGuardCodeTranslations = new byte[26]
        {
            50,
            51,
            52,
            53,
            54,
            55,
            56,
            57,
            66,
            67,
            68,
            70,
            71,
            72,
            74,
            75,
            77,
            78,
            80,
            81,
            82,
            84,
            86,
            87,
            88,
            89
        };

        private static string username = "";

        private static bool testclick = false;

        private static string start_mysql1 = "";

        private static string start_mysql2 = "";

        private static string play_mysql1 = "";

        private static string play_mysql2 = "";

        private static string mycl = "";

        private static string accountname = "";

        private static string whichlobby = "";

        private static string password = "";

        private static string parameters = "";

        private static string SharedSecret = "";

        private static string acceptx = "";

        private static string accepty = "";

        private static string startx = "";

        private static string starty = "";

        private static string playx = "";

        private static string playy = "";

        private static string disable = "";

        private static string rank2x2 = "";

        private static string rank5x5 = "";

        private static string userid = "";

        private static string profile = "";

        private static string steampath = "";

        private static string csgopath = "";

        private static string color_start1 = "";

        private static string color_start2 = "";

        private static string color_play1 = "";

        private static string color_play2 = "";

        private static string ms1 = "16000";

        private static string ms2 = "20000";

        private static string typed = "1";

        private static bool denis_ver = false;

        private static string databasename = "panel";

        private static bool once = true;

        private static int status = 0;

        private static bool live = false;

        private static int team = 0;

        public static bool dostart = true;

        public static bool tryaccept = false;

        public static int scorect = 0;

        public static int scoret = 0;

        public static int scorect_s = 0;

        public static int scorect_sx = 0;

        public static int scoret_s = 0;

        public static int scorect_s1 = 0;

        public static int scoret_s1 = 0;

        public static bool warmpup = false;

        public static bool endgame = true;

        public static bool warmpup_s = false;

        public static bool endgame_s = true;

        public static bool fixing2 = true;

        public static int maxTime = 0;

        public static int maxTime_s = 0;

        public static bool joined = false;

        private static int rounds = 0;

        private static int rounds_s = 0;

        private static bool waitf = false;

        private static string ewhoisleader = "1";

        public static RoundPhase xhase = RoundPhase.Undefined;

        private static bool autobuy = true;

        private static bool disc15 = false;

        private static bool disc14 = false;

        private static bool changedswap = false;

        private static bool makz = false;

        private static bool alreadyboom = true;

        private static bool pmbomb = true;

        private static bool pmdefuse = true;

        private static bool hehgame = true;

        private static int mapnameid = 0;

        private BackgroundWorker backgroundWorker13371;

        private BackgroundWorker backgroundWorker1337;

        private BackgroundWorker loginintoaccount;

        private BackgroundWorker backgroundWorker;

        private BackgroundWorker backgroundWorker2;

        private BackgroundWorker backgroundWorker3;

        private BackgroundWorker backgroundWorker01;

        private BackgroundWorker backgroundWorker1;

        private static int tab = 0;

        private static string reconnect_1 = "0,0";

        private static string reconnect_2 = "0,0";

        private static string reconnect_3 = "0,0";

        private static string reconnect_4 = "0,0";

        private static string reconnect_5 = "0,0";

        private static string reconnect_6 = "0,0";

        private static string reconnect_7 = "0,0";

        private static string reconnect_8 = "0,0";

        private static string reconnect_9 = "0,0";

        private static string reconnect_10 = "0,0";

        private static string reconnect_color = "-11751600";

        private static string reconnect_win = "";

        private static string reconnect_lose = "-Steamos -nofriendsui -nochatui -single_core -window -w 640 -h 480 -novid -noshader -nofbo -nodcaudio -nomsaa -16bpp -nosound -high";

        private static string reconnect_mode = "0";

        private static string typed48 = "0";

        private static string leadertext0 = " | BOT";

        private static string leadertext1 = " | LEADER #1";

        private static string leadertext2 = " | LEADER #2";

        private static string totaltext = " | BOT";

        private static string winorlose1 = " WIN |";

        private static string winorlose2 = " LOSE |";

        private static string userid_l1 = "";

        private static string userid_l2 = "";

        private static bool valstart = false;

        private static bool valaccept = false;

        private static bool valswap = false;

        private static bool valswap1 = false;

        private static bool valswap12 = false;

        private const int MOUSEEVENTF_LEFTDOWN = 2;

        private const int MOUSEEVENTF_LEFTUP = 4;

        private const int MOUSEEVENTF_RIGHTDOWN = 8;

        private const int MOUSEEVENTF_RIGHTUP = 16;

        private const int MOUSEEVENTF_XUP = 256;

        private const int MOUSEEVENTF_XDOWN = 128;

        private const int XBUTTON1 = 1;

        private const int XBUTTON2 = 2;

        private const int MOUSEEVENTF_MIDDLEDOWN = 32;

        private const int MOUSEEVENTF_MIDDLEUP = 64;

        public static int timerval = 0;

        public static bool timeryes = false;

        public GameStateListener gsl;

        private static IntPtr WndHandle;

        private const int WM_KEYDOWN = 256;

        private const int WM_KEYUP = 257;

        private const int WM_CHAR = 261;

        private const int WM_SYSKEYDOWN = 260;

        private const int WM_SYSKEYUP = 261;

        private const int WM_LBUTTONDOWN = 513;

        private const int WM_LBUTTONUP = 514;

        private InputSimulator sim = new InputSimulator();

        public static List<string> fetchgu1 = new List<string>();

        public static List<string> fetchgu = new List<string>();

        public static List<string> to_win4 = new List<string>();

        public static List<string> to_lose4 = new List<string>();

        public static List<string> to_leader1 = new List<string>();

        public static List<string> to_leader2 = new List<string>();

        public static List<string> to_regex = new List<string>();

        public static List<string> all_accs = new List<string>();

        public static List<string> to_regex1 = new List<string>();

        public static List<string> all_accs1 = new List<string>();

        public static List<string> to_regex2 = new List<string>();

        public static List<string> all_accs2 = new List<string>();

        public static List<string> to_regex3 = new List<string>();

        public static List<string> all_accs3 = new List<string>();

        public static List<string> all_accs9 = new List<string>();

        public static List<string> to_regex5 = new List<string>();

        public static List<string> all_accs5 = new List<string>();

        public static List<string> to_regex4 = new List<string>();

        public static List<string> all_accs4 = new List<string>();

        public static List<string> to_regex7 = new List<string>();

        public static List<string> all_accs7 = new List<string>();

        public static List<string> to_regex8 = new List<string>();

        public static List<string> all_accs8 = new List<string>();

        public static List<string> points = new List<string>();

        public static List<string> points_va = new List<string>();

        public static List<string> TEST = new List<string>();

        public static int mins = 0;

        private static bool full_lobby1 = false;

        private static bool full_lobby2 = false;

        private static string nummachines1 = "0";

        private static string nummachines2 = "0";

        private static int mamax1 = 0;

        private static int mamax2 = 0;

        private static string lobby_leader1 = "";

        private static string lobby_leader2 = "";

        public static List<string> winparty = new List<string>();

        public static List<string> loseparty = new List<string>();

        private static int disconnectx_1 = 0;

        private static int disconnectx_2 = 0;

        private static int disconnectx_3 = 0;

        private static int disconnectx_4 = 0;

        private static int disconnectx_5 = 0;

        private static int disconnecty_1 = 0;

        private static int disconnecty_2 = 0;

        private static int disconnecty_3 = 0;

        private static int disconnecty_4 = 0;

        private static int disconnecty_5 = 0;

        private static int disconnectx_6 = 0;

        private static int disconnectx_7 = 0;

        private static int disconnectx_8 = 0;

        private static int disconnectx_9 = 0;

        private static int disconnectx_10 = 0;

        private static int disconnecty_6 = 0;

        private static int disconnecty_7 = 0;

        private static int disconnecty_8 = 0;

        private static int disconnecty_9 = 0;

        private static int disconnecty_10 = 0;

        private static bool clicked = false;

        private static bool pizdec = false;

        private static string fingerPrint = string.Empty;

        private static int currentbox = 0;

        private static bool disconnects_enabled = false;

        private static bool sort_mode = false;

        private static bool panelw = false;

        private static int howmuch = -1;

        private static int howmuch1 = 0;

        private static string mywins = "UNK";

        private static string mydate = "UNK";

        private static string mydateexp = "UNK";

        private static string SharedMy = "";

        private static string staticclick = "0";

        private static bool joinafter12345 = false;

        private static bool joinafter1234 = false;

        private static bool changed2 = false;

        private static bool spathochu = false;

        private static bool autoinvite = false;

        private static string logincount = "";

        private static bool timertest = false;


        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);

        public static string GenerateSteamGuardCode()
        {
            return GenerateSteamGuardCodeForTime(TimeAligner.GetSteamTime());
        }

        public static string GenerateSteamGuardCodeForTime(long time)
        {
            if (SharedMy == null || SharedMy.Length == 0)
            {
                return "";
            }
            byte[] key = Convert.FromBase64String(Regex.Unescape(SharedMy));
            byte[] array = new byte[8];
            time /= 30;
            for (int num = 8; num > 0; num--)
            {
                array[num - 1] = (byte)time;
                time >>= 8;
            }
            byte[] array2 = new HMACSHA1
            {
                Key = key
            }.ComputeHash(array);
            byte[] array3 = new byte[5];
            try
            {
                byte b = (byte)(array2[19] & 0xFu);
                int num2 = ((array2[b] & 0x7F) << 24) | ((array2[b + 1] & 0xFF) << 16) | ((array2[b + 2] & 0xFF) << 8) | (array2[b + 3] & 0xFF);
                for (int i = 0; i < 5; i++)
                {
                    array3[i] = steamGuardCodeTranslations[num2 % steamGuardCodeTranslations.Length];
                    num2 /= steamGuardCodeTranslations.Length;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return Encoding.UTF8.GetString(array3);
        }

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

        private async void DoSomething(string hwidid, string usernameid)
        {
            try
            {
                string text = await "http://vertigo-boost-panel.000webhostapp.com/info.php".PostUrlEncodedAsync(new
                {
                    hwid = hwidid,
                    username = usernameid
                }, default(CancellationToken), (HttpCompletionOption)0).ReceiveString();
                if (text == hwidid || text == hwidid + Environment.NewLine || text == null || text == "")
                {
                    Clipboard.SetText(hwidid);
                    Environment.Exit(0);
                }
                else
                {
                    username = text;
                    alerts.Show("Hello " + username, alerts.AlertType.success);
                    label2.Text = username;
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct License
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string signature;

            public long endDate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string nickname;
        }

        MemoryStream decrypt(byte[] cryptedData, string password, byte[] salt)
        {
            PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(password, salt);
            Aes aes = new AesManaged();
            aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
            aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(cryptedData, 0, cryptedData.Length);
            cryptoStream.Close();
            return memoryStream;
        }

        public static T GetStructByBytes<T>(byte[] arr) where T : struct
        {
            T str = new T();

            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            str = (T)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);

            return str;
        }

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool WaitNamedPipe(string name, int timeout);

        public static bool namedPipeExist(string pipeName)
        {
            if (pipeName != "")
            {
                try
                {
                    int timeout = 0;
                    if (!WaitNamedPipe(Path.GetFullPath($"\\\\.\\pipe\\{pipeName}"), timeout))
                    {
                        switch (Marshal.GetLastWin32Error())
                        {
                            case 0:
                                return false;
                            case 2:
                                return false;
                        }
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        private void pipe(string name, string command)
        {
            if (!(name != ""))
            {
                return;
            }
            using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", name, PipeDirection.InOut))
            {
                using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
                {
                    namedPipeClientStream.Connect();
                    streamWriter.Write(command);
                    streamWriter.Dispose();
                    namedPipeClientStream.Dispose();
                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Maximized;
        }

        private string requestx1y(string acclogin)
        {
            string text = "0,0";
            string str = "0";
            string str2 = "0";
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text3 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + acclogin + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    str = mySqlDataReader["shared_secret"].ToString();
                    str2 = mySqlDataReader["login"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return "0";
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
            text = str + "*" + str2;
            if (text == "0,0")
            {
                text = "0";
            }
            return text;
        }

        private string requestx1yxxx(string acclogin)
        {
            string text = "0,0";
            string text2 = "0";
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text4 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + acclogin + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    text2 = mySqlDataReader["shared_secret"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return "0";
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
            text = text2;
            if (text == "0,0")
            {
                text = "0";
            }
            return text;
        }

        private string requestx1yxxx12345(string acclogin)
        {
            string result = "0";
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + acclogin + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result = mySqlDataReader["login"].ToString();
                }
                mySqlDataReader.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return "0";
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
        }

        private string requestxy(string acclogin)
        {
            string str = "0";
            string str2 = "0";
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + acclogin + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    str = mySqlDataReader["x"].ToString();
                    str2 = mySqlDataReader["y"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return "0,0";
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
            return str + "," + str2;
        }

        private void fetchleader1()
        {
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM leaders where id='1';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    leader1 = mySqlDataReader["login"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
        }

        private void fetchsettings()
        {
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM settings where id='1';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    steampath = mySqlDataReader["steam"].ToString();
                    csgopath = mySqlDataReader["csgo"].ToString();
                    start_mysql1 = mySqlDataReader["start1"].ToString();
                    start_mysql2 = mySqlDataReader["start2"].ToString();
                    play_mysql1 = mySqlDataReader["play1"].ToString();
                    play_mysql2 = mySqlDataReader["play2"].ToString();
                    color_start1 = mySqlDataReader["color_start1"].ToString();
                    color_start2 = mySqlDataReader["color_start2"].ToString();
                    color_play1 = mySqlDataReader["color_play1"].ToString();
                    color_play2 = mySqlDataReader["color_play2"].ToString();
                    ms1 = mySqlDataReader["reconnect"].ToString();
                    ms2 = mySqlDataReader["disconnect"].ToString();
                    typed = mySqlDataReader["type"].ToString();
                    typed48 = mySqlDataReader["type48"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
        }

        [DllImport("user32.dll")]
        private static extern short VkKeyScan(char ch);

        private void fetchleader2()
        {
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM leaders where id='2';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    leader2 = mySqlDataReader["login"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = "";
            if (bunifuCustomDataGrid1.Rows.Count <= 0 || e.RowIndex < 0)
            {
                return;
            }
            string a = "";
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    a = mySqlDataReader["login"].ToString();
                    accountname = mySqlDataReader["login"].ToString();
                    s = mySqlDataReader["id"].ToString();
                    password = mySqlDataReader["password"].ToString();
                    whichlobby = mySqlDataReader["whichlobby"].ToString();
                    SharedSecret = mySqlDataReader["shared_secret"].ToString();
                    SharedMy = mySqlDataReader["ss"].ToString();
                    acceptx = mySqlDataReader["x"].ToString();
                    accepty = mySqlDataReader["y"].ToString();
                    mycl = mySqlDataReader["hello"].ToString();
                    mywins = mySqlDataReader["wins"].ToString();
                    mydate = mySqlDataReader["time"].ToString();
                    mydateexp = mySqlDataReader["exp"].ToString();
                    parameters = mySqlDataReader["parameters"].ToString();
                    rank5x5 = mySqlDataReader["5x5"].ToString();
                    rank2x2 = mySqlDataReader["2x2"].ToString();
                    profile = mySqlDataReader["profile"].ToString();
                    userid = mySqlDataReader["userid"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Unknown error with " + bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Error");
                bunifuCustomDataGrid1.ClearSelection();
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (a == "" || (tab == 0 && userid == "") || (tab == 0 && profile == ""))
                {
                    int result = 0;
                    int.TryParse(s, out result);
                    if (result > 5)
                    {
                        MessageBox.Show(bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.CurrentCell.RowIndex].Cells[0].Value.ToString() + " is not configured!", "Error");
                    }
                    bunifuCustomDataGrid1.ClearSelection();
                    bunifuCustomTextbox1.Text = "";
                    bunifuCustomTextbox2.Text = "";
                    bunifuCustomTextbox3.Text = "";
                    bunifuCustomTextbox4.Text = "-x 0 -y 0";
                    bunifuCustomTextbox5.Text = "0";
                    bunifuCustomTextbox6.Text = "0";
                    comboBox2.SelectedIndex = 0;
                    comboBox3.SelectedIndex = 0;
                    comboBox8.SelectedIndex = 0;
                    mycl = "";
                    accountname = "";
                    whichlobby = "";
                    rank5x5 = "";
                    rank2x2 = "";
                    profile = "";
                    userid = "";
                    SharedMy = "";
                    SharedSecret = "";
                    acceptx = "";
                    accepty = "";
                    disable = "";
                }
                else if (tab == 1)
                {
                    bunifuCustomTextbox1.Text = accountname;
                    bunifuCustomTextbox2.Text = password;
                    bunifuCustomTextbox3.Text = SharedSecret;
                    bunifuCustomTextbox4.Text = parameters;
                    bunifuCustomTextbox5.Text = acceptx;
                    bunifuCustomTextbox6.Text = accepty;
                    int result2 = 0;
                    int.TryParse(rank5x5, out result2);
                    comboBox2.SelectedIndex = result2;
                    int result3 = 0;
                    int.TryParse(rank2x2, out result3);
                    comboBox3.SelectedIndex = result3;
                    int result4 = 0;
                    int.TryParse(mycl, out result4);
                    comboBox8.SelectedIndex = result4;
                }
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            try
            {
                gsl.Stop();
            }
            catch
            {
            }
            SENDINFO("http://127.0.0.1/panel.php", "message=2");
        }

        private static string SENDINFO(string Url, string Data)
        {
            StreamReader streamReader = new StreamReader(WebRequest.Create(Url + "?" + Data).GetResponse().GetResponseStream());
            string result = streamReader.ReadToEnd();
            streamReader.Close();
            return result;
        }

        private void formloadnew(string notlobby)
        {
            if (denis_ver)
            {
                if (!(notlobby == "WIN"))
                {
                    return;
                }
                MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
                MySqlCommand mySqlCommand = new MySqlCommand();
                string commandText = "SELECT * FROM accounts ORDER BY id;";
                if (comboBox9.SelectedIndex == 2)
                {
                    commandText = "SELECT * FROM accounts WHERE id > 5 ORDER BY 5x5 DESC ;";
                }
                else if (comboBox9.SelectedIndex == 3)
                {
                    commandText = "SELECT * FROM accounts WHERE id > 5 ORDER BY 2x2 DESC ;";
                }
                else if (comboBox9.SelectedIndex == 0)
                {
                    commandText = "SELECT * FROM accounts WHERE id > 5 ORDER BY id;";
                }
                mySqlCommand.CommandText = commandText;
                mySqlCommand.Connection = connection;
                try
                {
                    mySqlCommand.Connection.Open();
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        mySqlDataReader["id"].ToString();
                        string filename = "ranks\\" + mySqlDataReader["5x5"].ToString() + ".png";
                        string filename2 = "ranks\\" + mySqlDataReader["2x2"].ToString() + ".png";
                        Bitmap imgToResize = new Bitmap(filename);
                        Bitmap imgToResize2 = new Bitmap(filename2);
                        bunifuCustomDataGrid1.Rows.Add(mySqlDataReader["login"].ToString());
                        comboBox1.Items.Add(mySqlDataReader["login"].ToString());
                        comboBox4.Items.Add(mySqlDataReader["login"].ToString());
                        string text = mySqlDataReader["login"].ToString();
                        string text2 = mySqlDataReader["hello"].ToString();
                        string value = mySqlDataReader["login"].ToString();
                        int num = -1;
                        foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
                        {
                            if (item.Cells[0].Value.ToString().Equals(value))
                            {
                                num = item.Index;
                                break;
                            }
                        }
                        if (num != -1)
                        {
                            bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuCustomDataGrid1.Rows[num].Cells[1].Value = resizeImage(imgToResize, new Size(60, 24));
                            bunifuCustomDataGrid1.Rows[num].Cells[2].Value = resizeImage(imgToResize2, new Size(60, 24));
                            bunifuCustomDataGrid1.Rows[num].Cells[3].Value = mySqlDataReader["whichlobby"].ToString();
                            bunifuCustomDataGrid1.Rows[num].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            switch (text2)
                            {
                                case "0":
                                    {
                                        string value3 = text;
                                        int num3 = -1;
                                        foreach (DataGridViewRow item2 in bunifuCustomDataGrid1.Rows)
                                        {
                                            if (item2.Cells[0].Value.ToString().Equals(value3))
                                            {
                                                num3 = item2.Index;
                                                break;
                                            }
                                        }
                                        if (num3 != -1)
                                        {
                                            bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                                            bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.BackColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.BackColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.BackColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.BackColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.ForeColor = Color.Black;
                                        }
                                        break;
                                    }
                                case "1":
                                    {
                                        string value7 = text;
                                        int num7 = -1;
                                        foreach (DataGridViewRow item3 in bunifuCustomDataGrid1.Rows)
                                        {
                                            if (item3.Cells[0].Value.ToString().Equals(value7))
                                            {
                                                num7 = item3.Index;
                                                break;
                                            }
                                        }
                                        if (num7 != -1)
                                        {
                                            bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                            bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.BackColor = Color.GreenYellow;
                                            bunifuCustomDataGrid1.Rows[num7].Cells[1].Style.BackColor = Color.GreenYellow;
                                            bunifuCustomDataGrid1.Rows[num7].Cells[2].Style.BackColor = Color.GreenYellow;
                                            bunifuCustomDataGrid1.Rows[num7].Cells[3].Style.BackColor = Color.GreenYellow;
                                            bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num7].Cells[1].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num7].Cells[2].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num7].Cells[3].Style.ForeColor = Color.Black;
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        string value4 = text;
                                        int num4 = -1;
                                        foreach (DataGridViewRow item4 in bunifuCustomDataGrid1.Rows)
                                        {
                                            if (item4.Cells[0].Value.ToString().Equals(value4))
                                            {
                                                num4 = item4.Index;
                                                break;
                                            }
                                        }
                                        if (num4 != -1)
                                        {
                                            bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                            bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.BackColor = Color.IndianRed;
                                            bunifuCustomDataGrid1.Rows[num4].Cells[1].Style.BackColor = Color.IndianRed;
                                            bunifuCustomDataGrid1.Rows[num4].Cells[2].Style.BackColor = Color.IndianRed;
                                            bunifuCustomDataGrid1.Rows[num4].Cells[3].Style.BackColor = Color.IndianRed;
                                            bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num4].Cells[1].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num4].Cells[2].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num4].Cells[3].Style.ForeColor = Color.White;
                                        }
                                        break;
                                    }
                                case "3":
                                    {
                                        string value6 = text;
                                        int num6 = -1;
                                        foreach (DataGridViewRow item5 in bunifuCustomDataGrid1.Rows)
                                        {
                                            if (item5.Cells[0].Value.ToString().Equals(value6))
                                            {
                                                num6 = item5.Index;
                                                break;
                                            }
                                        }
                                        if (num6 != -1)
                                        {
                                            Color backColor3 = ColorTranslator.FromHtml("#FF8C00");
                                            bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                            bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.BackColor = backColor3;
                                            bunifuCustomDataGrid1.Rows[num6].Cells[1].Style.BackColor = backColor3;
                                            bunifuCustomDataGrid1.Rows[num6].Cells[2].Style.BackColor = backColor3;
                                            bunifuCustomDataGrid1.Rows[num6].Cells[3].Style.BackColor = backColor3;
                                            bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num6].Cells[1].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num6].Cells[2].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num6].Cells[3].Style.ForeColor = Color.Black;
                                        }
                                        break;
                                    }
                                case "4":
                                    {
                                        string value8 = text;
                                        int num8 = -1;
                                        foreach (DataGridViewRow item6 in bunifuCustomDataGrid1.Rows)
                                        {
                                            if (item6.Cells[0].Value.ToString().Equals(value8))
                                            {
                                                num8 = item6.Index;
                                                break;
                                            }
                                        }
                                        if (num8 != -1)
                                        {
                                            Color backColor4 = ColorTranslator.FromHtml("#FFD700");
                                            bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                            bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.BackColor = backColor4;
                                            bunifuCustomDataGrid1.Rows[num8].Cells[1].Style.BackColor = backColor4;
                                            bunifuCustomDataGrid1.Rows[num8].Cells[2].Style.BackColor = backColor4;
                                            bunifuCustomDataGrid1.Rows[num8].Cells[3].Style.BackColor = backColor4;
                                            bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num8].Cells[1].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num8].Cells[2].Style.ForeColor = Color.Black;
                                            bunifuCustomDataGrid1.Rows[num8].Cells[3].Style.ForeColor = Color.Black;
                                        }
                                        break;
                                    }
                                case "5":
                                    {
                                        string value5 = text;
                                        int num5 = -1;
                                        foreach (DataGridViewRow item7 in bunifuCustomDataGrid1.Rows)
                                        {
                                            if (item7.Cells[0].Value.ToString().Equals(value5))
                                            {
                                                num5 = item7.Index;
                                                break;
                                            }
                                        }
                                        if (num5 != -1)
                                        {
                                            Color backColor2 = ColorTranslator.FromHtml("#6A5ACD");
                                            bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                            bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.BackColor = backColor2;
                                            bunifuCustomDataGrid1.Rows[num5].Cells[1].Style.BackColor = backColor2;
                                            bunifuCustomDataGrid1.Rows[num5].Cells[2].Style.BackColor = backColor2;
                                            bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.BackColor = backColor2;
                                            bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num5].Cells[1].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num5].Cells[2].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.ForeColor = Color.White;
                                        }
                                        break;
                                    }
                                case "6":
                                    {
                                        string value2 = text;
                                        int num2 = -1;
                                        foreach (DataGridViewRow item8 in bunifuCustomDataGrid1.Rows)
                                        {
                                            if (item8.Cells[0].Value.ToString().Equals(value2))
                                            {
                                                num2 = item8.Index;
                                                break;
                                            }
                                        }
                                        if (num2 != -1)
                                        {
                                            Color backColor = ColorTranslator.FromHtml("#000000");
                                            bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                            bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = backColor;
                                            bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = backColor;
                                            bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = backColor;
                                            bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = backColor;
                                            bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.White;
                                            bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.White;
                                        }
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unknown error", "Error");
                        }
                    }
                    mySqlDataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    Environment.Exit(0);
                }
                finally
                {
                    mySqlCommand.Connection.Close();
                }
                bool flag = true;
                if (flag)
                {
                    string value9 = leader1;
                    int num9 = -1;
                    foreach (DataGridViewRow item9 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item9.Cells[0].Value.ToString().Equals(value9))
                        {
                            num9 = item9.Index;
                            break;
                        }
                    }
                    if (num9 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num9].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num9].Cells[0].Style.BackColor = Color.Cyan;
                        bunifuCustomDataGrid1.Rows[num9].Cells[1].Style.BackColor = Color.Cyan;
                        bunifuCustomDataGrid1.Rows[num9].Cells[2].Style.BackColor = Color.Cyan;
                        bunifuCustomDataGrid1.Rows[num9].Cells[3].Style.BackColor = Color.Cyan;
                        comboBox1.SelectedIndex = comboBox1.Items.IndexOf(leader1);
                    }
                }
                if (flag)
                {
                    string value10 = leader2;
                    int num10 = -1;
                    foreach (DataGridViewRow item10 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item10.Cells[0].Value.ToString().Equals(value10))
                        {
                            num10 = item10.Index;
                            break;
                        }
                    }
                    if (num10 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num10].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num10].Cells[0].Style.BackColor = Color.MediumBlue;
                        bunifuCustomDataGrid1.Rows[num10].Cells[1].Style.BackColor = Color.MediumBlue;
                        bunifuCustomDataGrid1.Rows[num10].Cells[2].Style.BackColor = Color.MediumBlue;
                        bunifuCustomDataGrid1.Rows[num10].Cells[3].Style.BackColor = Color.MediumBlue;
                        bunifuCustomDataGrid1.Rows[num10].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num10].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num10].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num10].Cells[3].Style.ForeColor = Color.White;
                        comboBox4.SelectedIndex = comboBox4.Items.IndexOf(leader2);
                    }
                }
                bunifuCustomDataGrid1.ClearSelection();
                return;
            }
            MySqlConnection connection2 = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand2 = new MySqlCommand();
            string text4 = (mySqlCommand2.CommandText = "SELECT * FROM accounts WHERE whichlobby='" + notlobby + "' ORDER BY id;");
            mySqlCommand2.Connection = connection2;
            try
            {
                mySqlCommand2.Connection.Open();
                MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
                while (mySqlDataReader2.Read())
                {
                    mySqlDataReader2["id"].ToString();
                    string filename3 = "ranks\\" + mySqlDataReader2["5x5"].ToString() + ".png";
                    string filename4 = "ranks\\" + mySqlDataReader2["2x2"].ToString() + ".png";
                    Bitmap imgToResize3 = new Bitmap(filename3);
                    Bitmap imgToResize4 = new Bitmap(filename4);
                    bunifuCustomDataGrid1.Rows.Add(mySqlDataReader2["login"].ToString());
                    comboBox1.Items.Add(mySqlDataReader2["login"].ToString());
                    comboBox4.Items.Add(mySqlDataReader2["login"].ToString());
                    string text5 = mySqlDataReader2["login"].ToString();
                    string text6 = mySqlDataReader2["hello"].ToString();
                    string value11 = mySqlDataReader2["login"].ToString();
                    int num11 = -1;
                    foreach (DataGridViewRow item11 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item11.Cells[0].Value.ToString().Equals(value11))
                        {
                            num11 = item11.Index;
                            break;
                        }
                    }
                    if (num11 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num11].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        bunifuCustomDataGrid1.Rows[num11].Cells[1].Value = resizeImage(imgToResize3, new Size(60, 24));
                        bunifuCustomDataGrid1.Rows[num11].Cells[2].Value = resizeImage(imgToResize4, new Size(60, 24));
                        bunifuCustomDataGrid1.Rows[num11].Cells[3].Value = mySqlDataReader2["whichlobby"].ToString();
                        bunifuCustomDataGrid1.Rows[num11].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        switch (text6)
                        {
                            case "0":
                                {
                                    string value13 = text5;
                                    int num13 = -1;
                                    foreach (DataGridViewRow item12 in bunifuCustomDataGrid1.Rows)
                                    {
                                        if (item12.Cells[0].Value.ToString().Equals(value13))
                                        {
                                            num13 = item12.Index;
                                            break;
                                        }
                                    }
                                    if (num13 != -1)
                                    {
                                        bunifuCustomDataGrid1.Rows[num13].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                                        bunifuCustomDataGrid1.Rows[num13].Cells[0].Style.BackColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num13].Cells[1].Style.BackColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num13].Cells[2].Style.BackColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num13].Cells[3].Style.BackColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num13].Cells[0].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num13].Cells[1].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num13].Cells[2].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num13].Cells[3].Style.ForeColor = Color.Black;
                                    }
                                    break;
                                }
                            case "1":
                                {
                                    string value17 = text5;
                                    int num17 = -1;
                                    foreach (DataGridViewRow item13 in bunifuCustomDataGrid1.Rows)
                                    {
                                        if (item13.Cells[0].Value.ToString().Equals(value17))
                                        {
                                            num17 = item13.Index;
                                            break;
                                        }
                                    }
                                    if (num17 != -1)
                                    {
                                        bunifuCustomDataGrid1.Rows[num17].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                        bunifuCustomDataGrid1.Rows[num17].Cells[0].Style.BackColor = Color.GreenYellow;
                                        bunifuCustomDataGrid1.Rows[num17].Cells[1].Style.BackColor = Color.GreenYellow;
                                        bunifuCustomDataGrid1.Rows[num17].Cells[2].Style.BackColor = Color.GreenYellow;
                                        bunifuCustomDataGrid1.Rows[num17].Cells[3].Style.BackColor = Color.GreenYellow;
                                        bunifuCustomDataGrid1.Rows[num17].Cells[0].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num17].Cells[1].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num17].Cells[2].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num17].Cells[3].Style.ForeColor = Color.Black;
                                    }
                                    break;
                                }
                            case "2":
                                {
                                    string value14 = text5;
                                    int num14 = -1;
                                    foreach (DataGridViewRow item14 in bunifuCustomDataGrid1.Rows)
                                    {
                                        if (item14.Cells[0].Value.ToString().Equals(value14))
                                        {
                                            num14 = item14.Index;
                                            break;
                                        }
                                    }
                                    if (num14 != -1)
                                    {
                                        bunifuCustomDataGrid1.Rows[num14].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                        bunifuCustomDataGrid1.Rows[num14].Cells[0].Style.BackColor = Color.IndianRed;
                                        bunifuCustomDataGrid1.Rows[num14].Cells[1].Style.BackColor = Color.IndianRed;
                                        bunifuCustomDataGrid1.Rows[num14].Cells[2].Style.BackColor = Color.IndianRed;
                                        bunifuCustomDataGrid1.Rows[num14].Cells[3].Style.BackColor = Color.IndianRed;
                                        bunifuCustomDataGrid1.Rows[num14].Cells[0].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num14].Cells[1].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num14].Cells[2].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num14].Cells[3].Style.ForeColor = Color.White;
                                    }
                                    break;
                                }
                            case "3":
                                {
                                    string value16 = text5;
                                    int num16 = -1;
                                    foreach (DataGridViewRow item15 in bunifuCustomDataGrid1.Rows)
                                    {
                                        if (item15.Cells[0].Value.ToString().Equals(value16))
                                        {
                                            num16 = item15.Index;
                                            break;
                                        }
                                    }
                                    if (num16 != -1)
                                    {
                                        Color backColor7 = ColorTranslator.FromHtml("#FF8C00");
                                        bunifuCustomDataGrid1.Rows[num16].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                        bunifuCustomDataGrid1.Rows[num16].Cells[0].Style.BackColor = backColor7;
                                        bunifuCustomDataGrid1.Rows[num16].Cells[1].Style.BackColor = backColor7;
                                        bunifuCustomDataGrid1.Rows[num16].Cells[2].Style.BackColor = backColor7;
                                        bunifuCustomDataGrid1.Rows[num16].Cells[3].Style.BackColor = backColor7;
                                        bunifuCustomDataGrid1.Rows[num16].Cells[0].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num16].Cells[1].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num16].Cells[2].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num16].Cells[3].Style.ForeColor = Color.Black;
                                    }
                                    break;
                                }
                            case "4":
                                {
                                    string value18 = text5;
                                    int num18 = -1;
                                    foreach (DataGridViewRow item16 in bunifuCustomDataGrid1.Rows)
                                    {
                                        if (item16.Cells[0].Value.ToString().Equals(value18))
                                        {
                                            num18 = item16.Index;
                                            break;
                                        }
                                    }
                                    if (num18 != -1)
                                    {
                                        Color backColor8 = ColorTranslator.FromHtml("#FFD700");
                                        bunifuCustomDataGrid1.Rows[num18].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                        bunifuCustomDataGrid1.Rows[num18].Cells[0].Style.BackColor = backColor8;
                                        bunifuCustomDataGrid1.Rows[num18].Cells[1].Style.BackColor = backColor8;
                                        bunifuCustomDataGrid1.Rows[num18].Cells[2].Style.BackColor = backColor8;
                                        bunifuCustomDataGrid1.Rows[num18].Cells[3].Style.BackColor = backColor8;
                                        bunifuCustomDataGrid1.Rows[num18].Cells[0].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num18].Cells[1].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num18].Cells[2].Style.ForeColor = Color.Black;
                                        bunifuCustomDataGrid1.Rows[num18].Cells[3].Style.ForeColor = Color.Black;
                                    }
                                    break;
                                }
                            case "5":
                                {
                                    string value15 = text5;
                                    int num15 = -1;
                                    foreach (DataGridViewRow item17 in bunifuCustomDataGrid1.Rows)
                                    {
                                        if (item17.Cells[0].Value.ToString().Equals(value15))
                                        {
                                            num15 = item17.Index;
                                            break;
                                        }
                                    }
                                    if (num15 != -1)
                                    {
                                        Color backColor6 = ColorTranslator.FromHtml("#6A5ACD");
                                        bunifuCustomDataGrid1.Rows[num15].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                        bunifuCustomDataGrid1.Rows[num15].Cells[0].Style.BackColor = backColor6;
                                        bunifuCustomDataGrid1.Rows[num15].Cells[1].Style.BackColor = backColor6;
                                        bunifuCustomDataGrid1.Rows[num15].Cells[2].Style.BackColor = backColor6;
                                        bunifuCustomDataGrid1.Rows[num15].Cells[3].Style.BackColor = backColor6;
                                        bunifuCustomDataGrid1.Rows[num15].Cells[0].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num15].Cells[1].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num15].Cells[2].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num15].Cells[3].Style.ForeColor = Color.White;
                                    }
                                    break;
                                }
                            case "6":
                                {
                                    string value12 = text5;
                                    int num12 = -1;
                                    foreach (DataGridViewRow item18 in bunifuCustomDataGrid1.Rows)
                                    {
                                        if (item18.Cells[0].Value.ToString().Equals(value12))
                                        {
                                            num12 = item18.Index;
                                            break;
                                        }
                                    }
                                    if (num12 != -1)
                                    {
                                        Color backColor5 = ColorTranslator.FromHtml("#000000");
                                        bunifuCustomDataGrid1.Rows[num12].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                        bunifuCustomDataGrid1.Rows[num12].Cells[0].Style.BackColor = backColor5;
                                        bunifuCustomDataGrid1.Rows[num12].Cells[1].Style.BackColor = backColor5;
                                        bunifuCustomDataGrid1.Rows[num12].Cells[2].Style.BackColor = backColor5;
                                        bunifuCustomDataGrid1.Rows[num12].Cells[3].Style.BackColor = backColor5;
                                        bunifuCustomDataGrid1.Rows[num12].Cells[0].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num12].Cells[1].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num12].Cells[2].Style.ForeColor = Color.White;
                                        bunifuCustomDataGrid1.Rows[num12].Cells[3].Style.ForeColor = Color.White;
                                    }
                                    break;
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unknown error", "Error");
                    }
                }
                mySqlDataReader2.Close();
            }
            catch (MySqlException ex2)
            {
                MessageBox.Show(ex2.ToString());
                Environment.Exit(0);
            }
            finally
            {
                mySqlCommand2.Connection.Close();
            }
            bool flag2 = true;
            if (flag2)
            {
                string value19 = leader1;
                int num19 = -1;
                foreach (DataGridViewRow item19 in bunifuCustomDataGrid1.Rows)
                {
                    if (item19.Cells[0].Value.ToString().Equals(value19))
                    {
                        num19 = item19.Index;
                        break;
                    }
                }
                if (num19 != -1)
                {
                    bunifuCustomDataGrid1.Rows[num19].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num19].Cells[0].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num19].Cells[1].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num19].Cells[2].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num19].Cells[3].Style.BackColor = Color.Cyan;
                    comboBox1.SelectedIndex = comboBox1.Items.IndexOf(leader1);
                }
            }
            if (flag2)
            {
                string value20 = leader2;
                int num20 = -1;
                foreach (DataGridViewRow item20 in bunifuCustomDataGrid1.Rows)
                {
                    if (item20.Cells[0].Value.ToString().Equals(value20))
                    {
                        num20 = item20.Index;
                        break;
                    }
                }
                if (num20 != -1)
                {
                    bunifuCustomDataGrid1.Rows[num20].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num20].Cells[0].Style.BackColor = Color.MediumBlue;
                    bunifuCustomDataGrid1.Rows[num20].Cells[1].Style.BackColor = Color.MediumBlue;
                    bunifuCustomDataGrid1.Rows[num20].Cells[2].Style.BackColor = Color.MediumBlue;
                    bunifuCustomDataGrid1.Rows[num20].Cells[3].Style.BackColor = Color.MediumBlue;
                    bunifuCustomDataGrid1.Rows[num20].Cells[0].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num20].Cells[1].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num20].Cells[2].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num20].Cells[3].Style.ForeColor = Color.White;
                    comboBox4.SelectedIndex = comboBox4.Items.IndexOf(leader2);
                }
            }
            bunifuCustomDataGrid1.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            timer3.Stop();
            databasename = AppDomain.CurrentDomain.FriendlyName.Split('.')[0];
            SENDINFO("http://127.0.0.1/panel.php", "message=1");
            SENDINFO("http://127.0.0.1/panel.php", "message=5");
            Application.ApplicationExit += OnApplicationExit;
            username = "Slaurusse";
            label2.Text = "Slaurusse";
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox7.Visible = false;
            label42.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            bunifuCustomTextbox31.Visible = false;
            bunifuCustomTextbox30.Visible = false;
            bunifuThinButton21.Visible = true;
            bunifuThinButton22.Visible = true;
            bunifuThinButton23.Visible = true;
            bunifuThinButton24.Visible = true;
            bunifuThinButton25.Visible = true;
            bunifuThinButton26.Visible = true;
            bunifuThinButton27.Visible = true;
            bunifuThinButton28.Visible = true;
            bunifuThinButton29.Visible = true;
            bunifuCustomTextbox1.Visible = false;
            bunifuCustomTextbox2.Visible = false;
            bunifuCustomTextbox3.Visible = false;
            bunifuCustomTextbox4.Visible = false;
            bunifuCustomTextbox5.Visible = false;
            bunifuCustomTextbox6.Visible = false;
            bunifuThinButton212.Visible = false;
            bunifuThinButton211.Visible = false;
            bunifuThinButton210.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label25.Visible = false;
            label11.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label24.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            bunifuThinButton213.Visible = false;
            bunifuThinButton214.Visible = false;
            bunifuThinButton215.Visible = false;
            bunifuCustomTextbox17.Visible = false;
            bunifuCustomTextbox7.Visible = false;
            bunifuCustomTextbox8.Visible = false;
            bunifuCustomTextbox9.Visible = false;
            bunifuCustomTextbox10.Visible = false;
            bunifuCustomTextbox11.Visible = false;
            bunifuCustomTextbox12.Visible = false;
            bunifuCustomTextbox13.Visible = false;
            bunifuCustomTextbox14.Visible = false;
            bunifuCustomTextbox15.Visible = false;
            comboBox1.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox9.Visible = false;
            bunifuCustomTextbox16.Visible = false;
            bunifuCustomTextbox18.Visible = false;
            bunifuCustomTextbox19.Visible = false;
            bunifuCustomTextbox20.Visible = false;
            bunifuCustomTextbox21.Visible = false;
            bunifuCustomTextbox22.Visible = false;
            bunifuCustomTextbox23.Visible = false;
            bunifuCustomTextbox24.Visible = false;
            bunifuCustomTextbox25.Visible = false;
            bunifuCustomTextbox26.Visible = false;
            bunifuCustomTextbox27.Visible = false;
            bunifuCustomTextbox28.Visible = false;
            bunifuCustomTextbox29.Visible = false;
            bunifuCustomDataGrid1.Visible = true;
            bunifuCustomDataGrid1.Location = new Point(22, 15);
            base.Width = 1400;
            base.Height = 900;
            panel1.Width = 1024;
            panel1.Height = 674;
            base.Location = new Point(Screen.PrimaryScreen.Bounds.Size.Width / 2 - base.Size.Width / 2, Screen.PrimaryScreen.Bounds.Size.Height / 2 - base.Size.Height / 2);
            bunifuThinButton21.Location = new Point(674, 51);
            bunifuThinButton22.Location = new Point(674, 104);
            bunifuThinButton23.Location = new Point(674, 157);
            bunifuThinButton24.Location = new Point(674, 316);
            bunifuThinButton25.Location = new Point(674, 369);
            bunifuThinButton26.Location = new Point(674, 422);
            bunifuThinButton27.Location = new Point(674, 475);
            bunifuThinButton28.Location = new Point(674, 210);
            bunifuThinButton29.Location = new Point(674, 263);
            panel1.Location = new Point(28, 115);
            panel1.Visible = true;
            foreach (DataGridViewColumn column in bunifuCustomDataGrid1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            bunifuCustomDataGrid1.MultiSelect = false;
            bunifuCustomDataGrid1.RowTemplate.Height = 30;
            fetchleader1();
            fetchleader2();
            fetchsettings();
            formloadnew("WIN");
            formloadnew("LOSE");
            formloadnew("ONLY WIN");
            formloadnew("ONLY LOSE");
            formloadnew("UNK");
            updatedisconnects_mysql();
            bunifuCustomTextbox17.Text = steampath;
            bunifuCustomTextbox7.Text = csgopath;
            bunifuCustomTextbox8.Text = start_mysql1;
            bunifuCustomTextbox9.Text = start_mysql2;
            bunifuCustomTextbox10.Text = color_start1;
            bunifuCustomTextbox11.Text = color_start2;
            bunifuCustomTextbox12.Text = play_mysql1;
            bunifuCustomTextbox13.Text = play_mysql2;
            bunifuCustomTextbox14.Text = color_play1;
            bunifuCustomTextbox15.Text = color_play2;
            bunifuCustomTextbox30.Text = ms1;
            bunifuCustomTextbox31.Text = ms2;
            int result = 0;
            int.TryParse(typed, out result);
            comboBox7.SelectedIndex = result;
            comboBox8.SelectedIndex = 0;
            int result2 = 0;
            int.TryParse(typed48, out result2);
            comboBox9.SelectedIndex = result2;
            if (!Directory.Exists(csgopath + "csgo/log"))
            {
                Directory.CreateDirectory(csgopath + "csgo/log");
            }
            foreach (DataGridViewColumn column2 in bunifuCustomDataGrid1.Columns)
            {
                column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            bunifuCustomDataGrid1.ClearSelection();
        }

        public void OnNewGameState(GameState gs)
        {
            live = false;
            if (comboBox7.SelectedIndex == 1 && !disc15 && ((scoret_s1 == 15 && scorect_s1 == 0) || (scorect_s1 == 15 && scoret_s1 == 0)))
            {
                valswap = !valswap;
                if (!valswap)
                {
                    bunifuFlatButton8.Text = "      LEADER: #1";
                }
                else
                {
                    bunifuFlatButton8.Text = "      LEADER: #2";
                }
                disc15 = true;
            }
            if (comboBox7.SelectedIndex == 3 && !disc15 && ((scoret_s1 == 15 && scorect_s1 == 0) || (scorect_s1 == 15 && scoret_s1 == 0)))
            {
                valswap = !valswap;
                if (!valswap)
                {
                    KillMe();
                    bunifuFlatButton8.Text = "      LEADER: #1";
                }
                else
                {
                    KillMe();
                    bunifuFlatButton8.Text = "      LEADER: #2";
                }
                disc15 = true;
            }
            if (gs.Player.SteamID.ToString() == ewhoisleader && ewhoisleader != "1")
            {
                xhase = gs.Round.Phase;
                if (gs.Player.Team == PlayerTeam.Undefined)
                {
                    team = 0;
                }
                else if (gs.Player.Team == PlayerTeam.CT)
                {
                    team = 1;
                }
                else if (gs.Player.Team == PlayerTeam.T)
                {
                    team = 2;
                }
                else
                {
                    team = 0;
                }
                if (gs.Player.Team == PlayerTeam.Undefined)
                {
                    if (status != 2)
                    {
                        status = 0;
                    }
                    scorect_s1 = gs.Map.TeamCT.Score;
                    scoret_s1 = gs.Map.TeamT.Score;
                    scorect_s = gs.Map.TeamCT.Score;
                    scoret_s = gs.Map.TeamT.Score;
                    if ((scoret != scoret_s || scorect != scorect_s) && scoret_s != -1 && scorect_s != -1)
                    {
                        scoret = scoret_s;
                        scorect = scorect_s;
                        string text = "      SCORE: " + scorect + ":" + scoret;
                        bunifuFlatButton7.Text = text;
                    }
                }
                else if (gs.Player.Team == PlayerTeam.CT)
                {
                    scorect_s1 = gs.Map.TeamCT.Score;
                    scoret_s1 = gs.Map.TeamT.Score;
                    scorect_s = gs.Map.TeamCT.Score;
                    scoret_s = gs.Map.TeamT.Score;
                    if (comboBox7.SelectedIndex == 3)
                    {
                        if ((scoret_s1 == 15 && scorect_s1 == 0) || (scorect_s1 == 15 && scoret_s1 == 0))
                        {
                            scorect_sx = 0;
                        }
                        else
                        {
                            scorect_sx = gs.Map.TeamCT.Score;
                        }
                    }
                    if ((scoret != scoret_s || scorect != scorect_s) && scoret_s != -1 && scorect_s != -1)
                    {
                        scoret = scoret_s;
                        scorect = scorect_s;
                        string text2 = "      SCORE: " + scorect + ":" + scoret;
                        string text3 = "UNK";
                        if (team == 1)
                        {
                            text3 = "CT";
                        }
                        else if (team == 2)
                        {
                            text3 = "T";
                        }
                        if (scorect == 15)
                        {
                            text3 = "T";
                        }
                        if (gs.Map.Phase != MapPhase.GameOver)
                        {
                            changed2 = false;
                            if (gs.Round.Phase != RoundPhase.Over || scorect_s1 != 16)
                            {
                                SENDINFO("http://127.0.0.1/panel.php", "message=666&info=" + scorect_s1 + ":" + scoret_s1 + "&team=" + text3);
                            }
                        }
                        bunifuFlatButton7.Text = text2;
                    }
                    tryaccept = false;
                }
                else if (gs.Player.Team == PlayerTeam.T)
                {
                    scorect_s1 = gs.Map.TeamCT.Score;
                    scoret_s1 = gs.Map.TeamT.Score;
                    scorect_s = gs.Map.TeamT.Score;
                    scoret_s = gs.Map.TeamCT.Score;
                    if (comboBox7.SelectedIndex == 3 && ((scoret_s1 == 15 && scorect_s1 == 0) || (scorect_s1 == 15 && scoret_s1 == 0)))
                    {
                        scorect_sx = 0;
                    }
                    if ((scoret != scoret_s || scorect != scorect_s) && scoret_s != -1 && scorect_s != -1)
                    {
                        scoret = scoret_s;
                        scorect = scorect_s;
                        string text4 = "      SCORE: " + scorect + ":" + scoret;
                        string text5 = "UNK";
                        if (team == 1)
                        {
                            text5 = "CT";
                        }
                        else if (team == 2)
                        {
                            text5 = "T";
                        }
                        if (scoret == 15)
                        {
                            text5 = "CT";
                        }
                        if (gs.Map.Phase != MapPhase.GameOver && (gs.Round.Phase != RoundPhase.Over || scoret_s1 != 16))
                        {
                            SENDINFO("http://127.0.0.1/panel.php", "message=666&info=" + scorect_s1 + ":" + scoret_s1 + "&team=" + text5);
                        }
                        bunifuFlatButton7.Text = text4;
                    }
                    tryaccept = false;
                }
                if (gs.Round.Phase == RoundPhase.Over)
                {
                    changed2 = false;
                    if ((scorect_s1 == 15 && scoret_s1 == 0) || (scoret_s1 == 15 && scorect_s1 == 0))
                    {
                        joinafter1234 = true;
                        StartMe();
                    }
                    else
                    {
                        KillMe();
                    }
                    maxTime = 0;
                    maxTime_s = 0;
                    tryaccept = true;
                    if (status != 2)
                    {
                        status = 0;
                    }
                }
                if (gs.Map.Name == "")
                {
                    KillMe();
                    mapnameid = 0;
                    hehgame = true;
                    pmbomb = true;
                    pmdefuse = true;
                    alreadyboom = true;
                    autobuy = true;
                    string text6 = "      SCORE: 0:0";
                    maxTime = 0;
                    maxTime_s = 0;
                    changedswap = false;
                    bunifuFlatButton7.Text = text6;
                    tryaccept = true;
                    once = true;
                    if (status != 2)
                    {
                        status = 0;
                    }
                }
                if (gs.Map.Phase == MapPhase.Undefined)
                {
                    changedswap = false;
                    mapnameid = 0;
                    hehgame = true;
                    pmbomb = true;
                    pmdefuse = true;
                    alreadyboom = true;
                    autobuy = true;
                    maxTime = 0;
                    maxTime_s = 0;
                    endgame = true;
                    warmpup = false;
                    if (endgame_s != endgame)
                    {
                        endgame_s = endgame;
                        scoret = 0;
                        scorect = 0;
                        scoret_s = 0;
                        scorect_s = 0;
                        scoret_s1 = 0;
                        scorect_s1 = 0;
                        string text7 = "      SCORE: 0:0";
                        dostart = true;
                        bunifuFlatButton7.Text = text7;
                    }
                    fixing2 = true;
                    tryaccept = true;
                    once = true;
                    if (status != 2)
                    {
                        status = 0;
                    }
                }
                if (gs.Map.Phase == MapPhase.Warmup)
                {
                    spathochu = false;
                    joinafter12345 = false;
                    joinafter1234 = true;
                    if (valstart)
                    {
                        bunifuFlatButton5.Text = "      AUTO-START: DISABLED";
                        valstart = false;
                    }
                    if (comboBox7.SelectedIndex == 3)
                    {
                        if (gs.Player.Team == PlayerTeam.T)
                        {
                            if (scoret_s == 0 && scorect_s == 0 && !changedswap)
                            {
                                valswap = !valswap;
                                if (!valswap)
                                {
                                    bunifuFlatButton8.Text = "      LEADER: #1";
                                    ewhoisleader = reconnect_win.Split(',')[0];
                                }
                                else
                                {
                                    bunifuFlatButton8.Text = "      LEADER: #2";
                                    ewhoisleader = reconnect_win.Split(',')[1];
                                }
                                changedswap = true;
                            }
                        }
                        else if (gs.Player.Team == PlayerTeam.CT && scorect_s == 0 && scoret_s == 0 && !changedswap)
                        {
                            valswap = !valswap;
                            if (!valswap)
                            {
                                bunifuFlatButton8.Text = "      LEADER: #1";
                                ewhoisleader = reconnect_win.Split(',')[0];
                            }
                            else
                            {
                                bunifuFlatButton8.Text = "      LEADER: #2";
                                ewhoisleader = reconnect_win.Split(',')[1];
                            }
                            changedswap = true;
                        }
                    }
                    KillMe();
                    mapnameid = 0;
                    hehgame = true;
                    pmbomb = true;
                    pmdefuse = true;
                    alreadyboom = true;
                    makz = true;
                    disc15 = false;
                    autobuy = true;
                    rounds_s = 0;
                    maxTime = 0;
                    maxTime_s = 0;
                    scoret_s1 = 0;
                    scorect_s1 = 0;
                    endgame = false;
                    warmpup = true;
                    fixing2 = true;
                    if (warmpup != warmpup_s)
                    {
                        warmpup_s = warmpup;
                        string text8 = "      SCORE: 0:0";
                        dostart = false;
                        bunifuFlatButton7.Text = text8;
                    }
                    tryaccept = false;
                    if (status != 2)
                    {
                        status = 0;
                    }
                }
                _ = gs.Map.Phase;
                _ = 3;
                if (gs.Round.Phase == RoundPhase.Live)
                {
                    spathochu = false;
                    joinafter12345 = false;
                    joinafter1234 = true;
                    if (valstart)
                    {
                        bunifuFlatButton5.Text = "      AUTO-START: DISABLED";
                        valstart = false;
                    }
                    pmbomb = true;
                    pmdefuse = true;
                    changedswap = false;
                    hehgame = false;
                    if (comboBox7.SelectedIndex == 1 && gs.Player.Team == PlayerTeam.T && scoret_s == 0 && scorect_s == 0 && !changedswap)
                    {
                        valswap = !valswap;
                        if (!valswap)
                        {
                            bunifuFlatButton8.Text = "      LEADER: #1";
                            ewhoisleader = reconnect_win.Split(',')[0];
                        }
                        else
                        {
                            bunifuFlatButton8.Text = "      LEADER: #2";
                            ewhoisleader = reconnect_win.Split(',')[1];
                        }
                        changedswap = true;
                    }
                    if (comboBox7.SelectedIndex == 3 && gs.Player.Team == PlayerTeam.T && scoret_s == 0 && scorect_s == 0 && !changedswap)
                    {
                        valswap = !valswap;
                        if (!valswap)
                        {
                            bunifuFlatButton8.Text = "      LEADER: #1";
                            ewhoisleader = reconnect_win.Split(',')[0];
                        }
                        else
                        {
                            bunifuFlatButton8.Text = "      LEADER: #2";
                            ewhoisleader = reconnect_win.Split(',')[1];
                        }
                        changedswap = true;
                    }
                    disc14 = false;
                    if (autobuy && scoret_s == 0 && scorect_s == 0)
                    {
                        foreach (Process item in from pr in Process.GetProcesses()
                                                 where pr.ProcessName == "csgo"
                                                 select pr)
                        {
                            sendKey(item.MainWindowHandle, 118, extended: false);
                            sendKey(item.MainWindowHandle, 118, extended: false);
                            sendKey(item.MainWindowHandle, 118, extended: false);
                            Thread.Sleep(300);
                        }
                        autobuy = false;
                    }
                    if ((gs.Round.Bomb != BombState.Planted || !alreadyboom) && alreadyboom)
                    {
                        if (gs.Map.Mode == MapMode.Competitive)
                        {
                            maxTime = 115;
                        }
                        else
                        {
                            maxTime = 90;
                        }
                        if (maxTime_s == 0)
                        {
                            maxTime_s = maxTime;
                        }
                    }
                    warmpup = false;
                    if (warmpup != warmpup_s)
                    {
                        warmpup_s = warmpup;
                        endgame_s = false;
                    }
                    tryaccept = false;
                    if (!joined && status != 2)
                    {
                        if (gs.Map.Name != null && gs.Map.Name != "")
                        {
                            string a = gs.Map.Name.Split('_')[0];
                            if (a == "cs")
                            {
                                mapnameid = 1;
                            }
                            else if (a == "de")
                            {
                                mapnameid = 2;
                            }
                        }
                        if (comboBox7.SelectedIndex == 3)
                        {
                            if (gs.Player.Team == PlayerTeam.CT)
                            {
                                if (scorect_sx == 0 || scorect_sx == 2 || scorect_sx == 4 || scorect_sx == 6 || scorect_sx == 8 || scorect_sx == 10 || scorect_sx == 12 || scorect_sx == 14)
                                {
                                    if (scorect_sx != 15)
                                    {
                                        status = 1;
                                    }
                                }
                                else
                                {
                                    status = 0;
                                }
                            }
                        }
                        else if (gs.Player.Team == PlayerTeam.CT)
                        {
                            if (comboBox7.SelectedIndex == 2)
                            {
                                if (mapnameid == 2)
                                {
                                    if (scorect_s1 == 0 || scorect_s1 == 2 || scorect_s1 == 4 || scorect_s1 == 6 || scorect_s1 == 8 || scorect_s1 == 10 || scorect_s1 == 12 || scorect_s1 == 14)
                                    {
                                        status = 1;
                                    }
                                    else if (scorect_s1 == 15)
                                    {
                                        status = 1;
                                    }
                                    else
                                    {
                                        status = 0;
                                    }
                                }
                                else if (mapnameid == 1)
                                {
                                    if (scorect_s1 == 1 || scorect_s1 == 3 || scorect_s1 == 5 || scorect_s1 == 7 || scorect_s1 == 9 || scorect_s1 == 11 || scorect_s1 == 13)
                                    {
                                        status = 1;
                                    }
                                    else
                                    {
                                        status = 0;
                                    }
                                }
                                else if (scorect_s1 == 0 || scorect_s1 == 2 || scorect_s1 == 4 || scorect_s1 == 6 || scorect_s1 == 8 || scorect_s1 == 10 || scorect_s1 == 12 || scorect_s1 == 14)
                                {
                                    status = 1;
                                }
                                else if (scorect_s1 == 15)
                                {
                                    status = 1;
                                }
                                else
                                {
                                    status = 0;
                                }
                            }
                            else if (comboBox7.SelectedIndex == 5)
                            {
                                if (scorect_s1 == 0 || scorect_s1 == 2 || scorect_s1 == 4 || scorect_s1 == 6 || scorect_s1 == 8 || scorect_s1 == 10 || scorect_s1 == 12 || scorect_s1 == 14 || scorect_s1 == 15)
                                {
                                    status = 1;
                                }
                                else
                                {
                                    status = 0;
                                }
                            }
                            else if (scorect_s1 == 1 || scorect_s1 == 3 || scorect_s1 == 5 || scorect_s1 == 7 || scorect_s1 == 9 || scorect_s1 == 11 || scorect_s1 == 13 || scorect_s1 == 15)
                            {
                                if (scorect_s1 == 9)
                                {
                                    status = 1;
                                }
                                else
                                {
                                    status = 1;
                                }
                            }
                            else
                            {
                                status = 0;
                            }
                        }
                        else if (gs.Player.Team == PlayerTeam.T)
                        {
                            if (mapnameid == 2)
                            {
                                if (comboBox7.SelectedIndex == 2)
                                {
                                    if (scoret_s1 == 1 || scoret_s1 == 3 || scoret_s1 == 5 || scoret_s1 == 7 || scoret_s1 == 9 || scoret_s1 == 11 || scoret_s1 == 13 || scoret_s1 == 15)
                                    {
                                        if (scoret_s1 == 15)
                                        {
                                            status = 0;
                                        }
                                        else if (scoret_s1 == 9)
                                        {
                                            status = 1;
                                        }
                                        else
                                        {
                                            status = 1;
                                        }
                                    }
                                    else
                                    {
                                        status = 0;
                                    }
                                }
                                else if (comboBox7.SelectedIndex == 5)
                                {
                                    if (scoret_s1 == 0 || scoret_s1 == 2 || scoret_s1 == 4 || scoret_s1 == 6 || scoret_s1 == 8 || scoret_s1 == 10 || scoret_s1 == 12 || scoret_s1 == 14 || scoret_s1 == 15)
                                    {
                                        status = 1;
                                    }
                                    else
                                    {
                                        status = 0;
                                    }
                                }
                                else if (scoret_s1 == 1 || scoret_s1 == 3 || scoret_s1 == 5 || scoret_s1 == 7 || scoret_s1 == 9 || scoret_s1 == 11 || scoret_s1 == 13 || scoret_s1 == 15)
                                {
                                    if (scoret_s1 == 9)
                                    {
                                        status = 1;
                                    }
                                    else
                                    {
                                        status = 1;
                                    }
                                }
                                else
                                {
                                    status = 0;
                                }
                            }
                            else if (mapnameid == 1)
                            {
                                if (comboBox7.SelectedIndex == 2)
                                {
                                    if (scoret_s1 == 0 || scoret_s1 == 2 || scoret_s1 == 4 || scoret_s1 == 6 || scoret_s1 == 8 || scoret_s1 == 10 || scoret_s1 == 12 || scoret_s1 == 14 || scoret_s1 == 15)
                                    {
                                        status = 1;
                                    }
                                    else
                                    {
                                        status = 0;
                                    }
                                }
                                else if (scoret_s1 == 0 || scoret_s1 == 2 || scoret_s1 == 4 || scoret_s1 == 6 || scoret_s1 == 8 || scoret_s1 == 10 || scoret_s1 == 12 || scoret_s1 == 14 || scoret_s1 == 15)
                                {
                                    if (scoret_s1 == 9)
                                    {
                                        status = 1;
                                    }
                                    else
                                    {
                                        status = 1;
                                    }
                                }
                                else
                                {
                                    status = 0;
                                }
                            }
                            else if (scoret_s1 == 1 || scoret_s1 == 3 || scoret_s1 == 5 || scoret_s1 == 7 || scoret_s1 == 9 || scoret_s1 == 11 || scoret_s1 == 13 || scoret_s1 == 15)
                            {
                                if (comboBox7.SelectedIndex == 2)
                                {
                                    if (scoret_s1 == 15)
                                    {
                                        status = 0;
                                    }
                                    else if (scoret_s1 == 9)
                                    {
                                        status = 1;
                                    }
                                    else
                                    {
                                        status = 1;
                                    }
                                }
                                else if (scoret_s1 == 9)
                                {
                                    status = 1;
                                }
                                else
                                {
                                    status = 1;
                                }
                            }
                            else
                            {
                                status = 0;
                            }
                        }
                    }
                }
                live = true;
                waitf = true;
                if (gs.Round.Phase == RoundPhase.FreezeTime)
                {
                    if (!joinafter12345)
                    {
                        joinafter12345 = true;
                        joinafter1234 = true;
                    }
                    if (valstart)
                    {
                        bunifuFlatButton5.Text = "      AUTO-START: DISABLED";
                        valstart = false;
                    }
                    testclick = true;
                    if (comboBox7.SelectedIndex == 3)
                    {
                        if (scorect_sx == 0 || scorect_sx != 15)
                        {
                            StartMe();
                        }
                        else
                        {
                            KillMe();
                        }
                    }
                    else
                    {
                        StartMe();
                    }
                    pmbomb = true;
                    pmdefuse = true;
                    alreadyboom = true;
                    makz = true;
                    if (scoret_s == 0 && scorect_s == 0 && hehgame)
                    {
                        SENDINFO("http://127.0.0.1/panel.php", "message=15");
                        hehgame = false;
                    }
                }
                else
                {
                    if (comboBox7.SelectedIndex == 2)
                    {
                        if (scorect_s1 != 15)
                        {
                            testclick = false;
                        }
                        else
                        {
                            testclick = true;
                        }
                    }
                    else
                    {
                        testclick = false;
                    }
                    if (comboBox7.SelectedIndex == 3)
                    {
                        if (scorect_sx != 15)
                        {
                            testclick = false;
                        }
                        else
                        {
                            testclick = true;
                        }
                    }
                    else
                    {
                        testclick = false;
                    }
                }
                if (gs.Map.Phase == MapPhase.Live)
                {
                    spathochu = false;
                    hehgame = true;
                    KillMe();
                    if (gs.Round.Bomb == BombState.Planted && alreadyboom)
                    {
                        maxTime = Convert.ToInt32(41.071428571428577);
                        maxTime_s = maxTime;
                        if (maxTime_s == 0)
                        {
                            maxTime_s = maxTime;
                        }
                        SENDINFO("http://127.0.0.1/panel.php", "message=12");
                        alreadyboom = false;
                    }
                }
                if (gs.Map.Phase == MapPhase.GameOver)
                {
                    spathochu = false;
                    scorect_sx = 0;
                    joinafter12345 = true;
                    joinafter1234 = false;
                    KillMe();
                    mapnameid = 0;
                    hehgame = true;
                    pmbomb = true;
                    pmdefuse = true;
                    alreadyboom = true;
                    if (autoinvite)
                    {
                        try
                        {
                            if (backgroundWorker1337.IsBusy)
                            {
                                backgroundWorker1337.CancelAsync();
                                Thread.Sleep(3000);
                                backgroundWorker1337.RunWorkerAsync();
                            }
                            else
                            {
                                backgroundWorker1337.RunWorkerAsync();
                            }
                        }
                        catch
                        {
                        }
                    }
                    IEnumerable<Process> enumerable = from pr in Process.GetProcesses()
                                                      where pr.ProcessName == "csgo"
                                                      select pr;
                    KillMe();
                    foreach (Process item2 in enumerable)
                    {
                        sendKey(item2.MainWindowHandle, 114, extended: false);
                        sendKey(item2.MainWindowHandle, 114, extended: false);
                        sendKey(item2.MainWindowHandle, 114, extended: false);
                        Thread.Sleep(300);
                    }
                    KillMe();
                    autobuy = true;
                    scoret_s1 = 0;
                    scorect_s1 = 0;
                    if (comboBox7.SelectedIndex != 4 && !changedswap)
                    {
                        SENDINFO("http://127.0.0.1/panel.php", "message=10");
                        valswap = !valswap;
                        if (!valswap)
                        {
                            SENDINFO("http://127.0.0.1/panel.php", "message=5");
                            bunifuFlatButton8.Text = "      LEADER: #1";
                        }
                        else
                        {
                            SENDINFO("http://127.0.0.1/panel.php", "message=6");
                            bunifuFlatButton8.Text = "      LEADER: #2";
                        }
                        changedswap = true;
                    }
                }
                if (gs.Round.Phase == RoundPhase.Over)
                {
                    if (gs.Round.Bomb == BombState.Exploded && pmbomb)
                    {
                        SENDINFO("http://127.0.0.1/panel.php", "message=13");
                        pmbomb = false;
                    }
                    if (gs.Round.Bomb == BombState.Defused && pmdefuse)
                    {
                        SENDINFO("http://127.0.0.1/panel.php", "message=14");
                        pmdefuse = false;
                    }
                }
                xhase = gs.Round.Phase;
            }
            if (comboBox7.SelectedIndex != 3)
            {
                if (!valswap)
                {
                    ewhoisleader = reconnect_win.Split(',')[0];
                }
                else
                {
                    ewhoisleader = reconnect_win.Split(',')[1];
                }
            }
            else if (scorect_sx == 15)
            {
                if (!valswap)
                {
                    ewhoisleader = reconnect_win.Split(',')[0];
                }
                else
                {
                    ewhoisleader = reconnect_win.Split(',')[1];
                }
            }
            else if (team == 2)
            {
                if (!valswap)
                {
                    ewhoisleader = reconnect_win.Split(',')[0];
                }
                else
                {
                    ewhoisleader = reconnect_win.Split(',')[1];
                }
            }
            else if (ewhoisleader == "1")
            {
                if (!valswap)
                {
                    ewhoisleader = reconnect_win.Split(',')[0];
                }
                else
                {
                    ewhoisleader = reconnect_win.Split(',')[1];
                }
            }
        }

        private void autoinviteme()
        {
            pictureBox1_Click(null, new ImageClickEventArgs(0, 0));
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker.RunWorkerAsync(1);
        }

        private void worker_RunWorkerCompleted2(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker2.RunWorkerAsync(1);
        }

        private void worker_RunWorkerCompleted3(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker3.RunWorkerAsync(1);
        }

        private void worker_RunWorkerCompleted1(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(1);
        }

        private void worker_RunWorkerCompleted01(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!backgroundWorker01.IsBusy)
            {
                backgroundWorker01.RunWorkerAsync(1);
            }
        }

        private void worker_RunWorkerCompleted011(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (accountname != "")
            {
                Process.Start("https://steamcommunity.com/profiles/" + profile);
            }
            else
            {
                MessageBox.Show("First select an account", "Error");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
            bunifuThinButton21.Visible = true;
            bunifuThinButton22.Visible = true;
            bunifuThinButton23.Visible = true;
            label43.Visible = false;
            comboBox8.Visible = false;
            bunifuThinButton24.Visible = true;
            comboBox7.Visible = false;
            bunifuCustomTextbox31.Visible = false;
            bunifuCustomTextbox30.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            bunifuThinButton25.Visible = true;
            bunifuThinButton26.Visible = true;
            bunifuThinButton27.Visible = true;
            bunifuThinButton28.Visible = true;
            bunifuThinButton29.Visible = true;
            bunifuCustomTextbox1.Visible = false;
            bunifuCustomTextbox2.Visible = false;
            bunifuCustomTextbox3.Visible = false;
            bunifuCustomTextbox4.Visible = false;
            bunifuCustomTextbox5.Visible = false;
            bunifuCustomTextbox6.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            bunifuThinButton212.Visible = false;
            bunifuThinButton211.Visible = false;
            bunifuThinButton210.Visible = false;
            label3.Text = "ACCOUNTS MANAGER";
            bunifuCustomTextbox1.Text = "";
            bunifuCustomTextbox2.Text = "";
            bunifuCustomTextbox3.Text = "";
            bunifuCustomTextbox4.Text = "-x 0 -y 0";
            bunifuCustomTextbox5.Text = "0";
            bunifuCustomTextbox6.Text = "0";
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            label25.Visible = false;
            label11.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label24.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            bunifuThinButton213.Visible = false;
            bunifuThinButton214.Visible = false;
            bunifuThinButton215.Visible = false;
            bunifuCustomTextbox17.Visible = false;
            bunifuCustomTextbox7.Visible = false;
            bunifuCustomTextbox8.Visible = false;
            bunifuCustomTextbox9.Visible = false;
            bunifuCustomTextbox10.Visible = false;
            bunifuCustomTextbox11.Visible = false;
            bunifuCustomTextbox12.Visible = false;
            bunifuCustomTextbox13.Visible = false;
            bunifuCustomTextbox14.Visible = false;
            bunifuCustomTextbox15.Visible = false;
            comboBox1.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox9.Visible = false;
            bunifuCustomTextbox16.Visible = false;
            bunifuCustomTextbox18.Visible = false;
            bunifuCustomTextbox19.Visible = false;
            bunifuCustomTextbox20.Visible = false;
            bunifuCustomTextbox21.Visible = false;
            bunifuCustomTextbox22.Visible = false;
            bunifuCustomTextbox23.Visible = false;
            bunifuCustomTextbox24.Visible = false;
            bunifuCustomTextbox25.Visible = false;
            bunifuCustomTextbox26.Visible = false;
            bunifuCustomTextbox27.Visible = false;
            bunifuCustomTextbox28.Visible = false;
            bunifuCustomTextbox29.Visible = false;
            tab = 0;
            currentbox = 0;
            bunifuCustomDataGrid1.Visible = true;
            bunifuCustomDataGrid1.Location = new Point(22, 15);
            bunifuThinButton21.Location = new Point(674, 51);
            bunifuThinButton22.Location = new Point(674, 104);
            bunifuThinButton23.Location = new Point(674, 157);
            bunifuThinButton24.Location = new Point(674, 316);
            bunifuThinButton25.Location = new Point(674, 369);
            bunifuThinButton26.Location = new Point(674, 422);
            bunifuThinButton27.Location = new Point(674, 475);
            bunifuThinButton28.Location = new Point(674, 210);
            bunifuThinButton29.Location = new Point(674, 263);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
            bunifuThinButton21.Visible = false;
            label42.Visible = false;
            bunifuCustomTextbox31.Visible = false;
            bunifuCustomTextbox30.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label43.Visible = true;
            comboBox7.Visible = false;
            bunifuThinButton22.Visible = false;
            bunifuThinButton23.Visible = false;
            bunifuThinButton24.Visible = false;
            bunifuThinButton25.Visible = false;
            bunifuThinButton26.Visible = false;
            bunifuThinButton27.Visible = false;
            bunifuThinButton28.Visible = false;
            bunifuThinButton29.Visible = false;
            tab = 1;
            bunifuCustomTextbox1.Visible = true;
            bunifuCustomTextbox2.Visible = true;
            bunifuCustomTextbox3.Visible = true;
            bunifuCustomTextbox4.Visible = true;
            bunifuCustomTextbox5.Visible = true;
            bunifuCustomTextbox6.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox8.Visible = true;
            bunifuThinButton212.Visible = true;
            bunifuThinButton211.Visible = true;
            bunifuThinButton210.Visible = true;
            label3.Text = "ACCOUNTS DATABASE";
            bunifuCustomDataGrid1.Visible = true;
            bunifuCustomDataGrid1.Location = new Point(22, 15);
            bunifuCustomTextbox1.Text = "";
            bunifuCustomTextbox2.Text = "";
            bunifuCustomTextbox3.Text = "";
            bunifuCustomTextbox4.Text = "-x 0 -y 0";
            bunifuCustomTextbox5.Text = "0";
            bunifuCustomTextbox6.Text = "0";
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            label25.Visible = false;
            label11.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label24.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            bunifuThinButton213.Visible = false;
            bunifuThinButton214.Visible = false;
            bunifuThinButton215.Visible = false;
            bunifuCustomTextbox17.Visible = false;
            bunifuCustomTextbox7.Visible = false;
            bunifuCustomTextbox8.Visible = false;
            bunifuCustomTextbox9.Visible = false;
            bunifuCustomTextbox10.Visible = false;
            bunifuCustomTextbox11.Visible = false;
            bunifuCustomTextbox12.Visible = false;
            bunifuCustomTextbox13.Visible = false;
            bunifuCustomTextbox14.Visible = false;
            bunifuCustomTextbox15.Visible = false;
            comboBox1.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox9.Visible = false;
            bunifuCustomTextbox16.Visible = false;
            bunifuCustomTextbox18.Visible = false;
            bunifuCustomTextbox19.Visible = false;
            bunifuCustomTextbox20.Visible = false;
            bunifuCustomTextbox21.Visible = false;
            bunifuCustomTextbox22.Visible = false;
            bunifuCustomTextbox23.Visible = false;
            bunifuCustomTextbox24.Visible = false;
            bunifuCustomTextbox25.Visible = false;
            bunifuCustomTextbox26.Visible = false;
            bunifuCustomTextbox27.Visible = false;
            bunifuCustomTextbox28.Visible = false;
            bunifuCustomTextbox29.Visible = false;
            currentbox = 0;
            label5.Location = new Point(779, 31);
            label6.Location = new Point(762, 81);
            label7.Location = new Point(739, 131);
            label8.Location = new Point(750, 181);
            label9.Location = new Point(762, 231);
            label10.Location = new Point(762, 281);
            label12.Location = new Point(809, 331);
            label13.Location = new Point(809, 383);
            label43.Location = new Point(815, 435);
            bunifuCustomTextbox1.Location = new Point(674, 52);
            bunifuCustomTextbox2.Location = new Point(674, 102);
            bunifuCustomTextbox3.Location = new Point(674, 152);
            bunifuCustomTextbox4.Location = new Point(674, 202);
            bunifuCustomTextbox5.Location = new Point(674, 252);
            bunifuCustomTextbox6.Location = new Point(674, 302);
            comboBox2.Location = new Point(674, 352);
            comboBox3.Location = new Point(674, 404);
            comboBox8.Location = new Point(674, 456);
            bunifuThinButton212.Location = new Point(684, 504);
            bunifuThinButton211.Location = new Point(684, 557);
            bunifuThinButton210.Location = new Point(684, 610);
        }

        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(base.Handle, 274, 61458, 0);
        }

        private void updateaccount(string login)
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + login + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.CommandText = "UPDATE accounts SET password='" + bunifuCustomTextbox2.Text + "', parameters='" + bunifuCustomTextbox4.Text + "', x='" + bunifuCustomTextbox5.Text + "', y='" + bunifuCustomTextbox6.Text + "', shared_secret='" + bunifuCustomTextbox3.Text + "', 5x5='" + comboBox2.SelectedIndex + "', hello='" + comboBox8.SelectedIndex + "', 2x2='" + comboBox3.SelectedIndex + "' WHERE login='" + login + "'";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
                password = bunifuCustomTextbox2.Text;
                SharedSecret = bunifuCustomTextbox3.Text;
                acceptx = bunifuCustomTextbox5.Text;
                accepty = bunifuCustomTextbox6.Text;
                parameters = bunifuCustomTextbox4.Text;
                rank5x5 = comboBox2.SelectedIndex.ToString();
                rank2x2 = comboBox3.SelectedIndex.ToString();
                if (!(leader1 != login) || !(leader2 != login))
                {
                    return;
                }
                if (comboBox8.SelectedIndex == 0)
                {
                    int num2 = -1;
                    foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
                    {
                        if (item.Cells[0].Value.ToString().Equals(login))
                        {
                            num2 = item.Index;
                            break;
                        }
                    }
                    if (num2 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.Black;
                    }
                }
                else if (comboBox8.SelectedIndex == 1)
                {
                    int num3 = -1;
                    foreach (DataGridViewRow item2 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item2.Cells[0].Value.ToString().Equals(login))
                        {
                            num3 = item2.Index;
                            break;
                        }
                    }
                    if (num3 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.ForeColor = Color.Black;
                    }
                }
                else if (comboBox8.SelectedIndex == 2)
                {
                    int num4 = -1;
                    foreach (DataGridViewRow item3 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item3.Cells[0].Value.ToString().Equals(login))
                        {
                            num4 = item3.Index;
                            break;
                        }
                    }
                    if (num4 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num4].Cells[1].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num4].Cells[2].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num4].Cells[3].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num4].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num4].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num4].Cells[3].Style.ForeColor = Color.White;
                    }
                }
                else if (comboBox8.SelectedIndex == 3)
                {
                    int num5 = -1;
                    foreach (DataGridViewRow item4 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item4.Cells[0].Value.ToString().Equals(login))
                        {
                            num5 = item4.Index;
                            break;
                        }
                    }
                    if (num5 != -1)
                    {
                        Color backColor = ColorTranslator.FromHtml("#FF8C00");
                        bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.BackColor = backColor;
                        bunifuCustomDataGrid1.Rows[num5].Cells[1].Style.BackColor = backColor;
                        bunifuCustomDataGrid1.Rows[num5].Cells[2].Style.BackColor = backColor;
                        bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.BackColor = backColor;
                        bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num5].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num5].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.ForeColor = Color.Black;
                    }
                }
                else if (comboBox8.SelectedIndex == 4)
                {
                    int num6 = -1;
                    foreach (DataGridViewRow item5 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item5.Cells[0].Value.ToString().Equals(login))
                        {
                            num6 = item5.Index;
                            break;
                        }
                    }
                    if (num6 != -1)
                    {
                        Color backColor2 = ColorTranslator.FromHtml("#FFD700");
                        bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.BackColor = backColor2;
                        bunifuCustomDataGrid1.Rows[num6].Cells[1].Style.BackColor = backColor2;
                        bunifuCustomDataGrid1.Rows[num6].Cells[2].Style.BackColor = backColor2;
                        bunifuCustomDataGrid1.Rows[num6].Cells[3].Style.BackColor = backColor2;
                        bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num6].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num6].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num6].Cells[3].Style.ForeColor = Color.Black;
                    }
                }
                else if (comboBox8.SelectedIndex == 5)
                {
                    int num7 = -1;
                    foreach (DataGridViewRow item6 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item6.Cells[0].Value.ToString().Equals(login))
                        {
                            num7 = item6.Index;
                            break;
                        }
                    }
                    if (num7 != -1)
                    {
                        Color backColor3 = ColorTranslator.FromHtml("#6A5ACD");
                        bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.BackColor = backColor3;
                        bunifuCustomDataGrid1.Rows[num7].Cells[1].Style.BackColor = backColor3;
                        bunifuCustomDataGrid1.Rows[num7].Cells[2].Style.BackColor = backColor3;
                        bunifuCustomDataGrid1.Rows[num7].Cells[3].Style.BackColor = backColor3;
                        bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num7].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num7].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num7].Cells[3].Style.ForeColor = Color.White;
                    }
                }
                else
                {
                    if (comboBox8.SelectedIndex != 6)
                    {
                        return;
                    }
                    int num8 = -1;
                    foreach (DataGridViewRow item7 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item7.Cells[0].Value.ToString().Equals(login))
                        {
                            num8 = item7.Index;
                            break;
                        }
                    }
                    if (num8 != -1)
                    {
                        Color backColor4 = ColorTranslator.FromHtml("#000000");
                        bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.BackColor = backColor4;
                        bunifuCustomDataGrid1.Rows[num8].Cells[1].Style.BackColor = backColor4;
                        bunifuCustomDataGrid1.Rows[num8].Cells[2].Style.BackColor = backColor4;
                        bunifuCustomDataGrid1.Rows[num8].Cells[3].Style.BackColor = backColor4;
                        bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num8].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num8].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num8].Cells[3].Style.ForeColor = Color.White;
                    }
                    return;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num == 1)
                {
                    string filename = "ranks\\" + rank5x5 + ".png";
                    string filename2 = "ranks\\" + rank2x2 + ".png";
                    Bitmap imgToResize = new Bitmap(filename);
                    Bitmap imgToResize2 = new Bitmap(filename2);
                    string value = accountname;
                    int num9 = -1;
                    foreach (DataGridViewRow item8 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item8.Cells[0].Value.ToString().Equals(value))
                        {
                            num9 = item8.Index;
                            break;
                        }
                    }
                    if (num9 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num9].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        bunifuCustomDataGrid1.Rows[num9].Cells[1].Value = resizeImage(imgToResize, new Size(60, 24));
                        bunifuCustomDataGrid1.Rows[num9].Cells[2].Value = resizeImage(imgToResize2, new Size(60, 24));
                        bunifuCustomDataGrid1.Rows[num9].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }
                    alerts.Show("Successfully!", alerts.AlertType.success);
                }
                else
                {
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void newaccount()
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts ORDER BY id;");
            mySqlCommand.Connection = connection;
            try
            {
                string text4 = (mySqlCommand.CommandText = "insert into accounts(login,password,parameters,shared_secret,5x5,2x2,hello,x,y) values('" + bunifuCustomTextbox1.Text + "','" + bunifuCustomTextbox2.Text + "','" + bunifuCustomTextbox4.Text + "','" + bunifuCustomTextbox3.Text + "','" + comboBox2.SelectedIndex + "','" + comboBox3.SelectedIndex + "','" + comboBox8.SelectedIndex + "','" + bunifuCustomTextbox5.Text + "','" + bunifuCustomTextbox6.Text + "');");
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
                string filename = "ranks\\" + comboBox2.SelectedIndex + ".png";
                string filename2 = "ranks\\" + comboBox3.SelectedIndex + ".png";
                Bitmap imgToResize = new Bitmap(filename);
                Bitmap imgToResize2 = new Bitmap(filename2);
                bunifuCustomDataGrid1.Rows.Add(bunifuCustomTextbox1.Text);
                comboBox1.Items.Add(bunifuCustomTextbox1.Text);
                comboBox4.Items.Add(bunifuCustomTextbox1.Text);
                string text5 = bunifuCustomTextbox1.Text;
                int num2 = -1;
                foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
                {
                    if (item.Cells[0].Value.ToString().Equals(text5))
                    {
                        num2 = item.Index;
                        break;
                    }
                }
                if (num2 != -1)
                {
                    bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    bunifuCustomDataGrid1.Rows[num2].Cells[3].Value = "UNK";
                    bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    bunifuCustomDataGrid1.Rows[num2].Cells[1].Value = resizeImage(imgToResize, new Size(60, 24));
                    bunifuCustomDataGrid1.Rows[num2].Cells[2].Value = resizeImage(imgToResize2, new Size(60, 24));
                    if (comboBox8.SelectedIndex == 0)
                    {
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.Black;
                    }
                    if (comboBox8.SelectedIndex == 1)
                    {
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.Black;
                    }
                    if (comboBox8.SelectedIndex == 2)
                    {
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.White;
                    }
                    if (comboBox8.SelectedIndex == 3)
                    {
                        Color backColor = ColorTranslator.FromHtml("#FF8C00");
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = backColor;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = backColor;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = backColor;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = backColor;
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.Black;
                    }
                    if (comboBox8.SelectedIndex == 4)
                    {
                        Color backColor2 = ColorTranslator.FromHtml("#FFD700");
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = backColor2;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = backColor2;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = backColor2;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = backColor2;
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.Black;
                    }
                    if (comboBox8.SelectedIndex == 5)
                    {
                        Color backColor3 = ColorTranslator.FromHtml("#6A5ACD");
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = backColor3;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = backColor3;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = backColor3;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = backColor3;
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.White;
                    }
                    if (comboBox8.SelectedIndex == 6)
                    {
                        Color backColor4 = ColorTranslator.FromHtml("#000000");
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = backColor4;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = backColor4;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = backColor4;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = backColor4;
                        bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.White;
                    }
                }
                else
                {
                    MessageBox.Show("Unknown error", "Error");
                }
                if (comboBox8.SelectedIndex == 0)
                {
                    string text6 = bunifuCustomTextbox1.Text;
                    int num3 = -1;
                    foreach (DataGridViewRow item2 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item2.Cells[0].Value.ToString().Equals(text6))
                        {
                            num3 = item2.Index;
                            break;
                        }
                    }
                    if (num3 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.BackColor = Color.Gainsboro;
                        bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.BackColor = Color.Gainsboro;
                        bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.BackColor = Color.Gainsboro;
                        bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.BackColor = Color.Gainsboro;
                        bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.ForeColor = Color.Black;
                    }
                }
                else if (comboBox8.SelectedIndex == 1)
                {
                    string text7 = bunifuCustomTextbox1.Text;
                    int num4 = -1;
                    foreach (DataGridViewRow item3 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item3.Cells[0].Value.ToString().Equals(text7))
                        {
                            num4 = item3.Index;
                            break;
                        }
                    }
                    if (num4 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num4].Cells[1].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num4].Cells[2].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num4].Cells[3].Style.BackColor = Color.GreenYellow;
                        bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num4].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num4].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num4].Cells[3].Style.ForeColor = Color.Black;
                    }
                }
                else if (comboBox8.SelectedIndex == 2)
                {
                    string text8 = bunifuCustomTextbox1.Text;
                    int num5 = -1;
                    foreach (DataGridViewRow item4 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item4.Cells[0].Value.ToString().Equals(text8))
                        {
                            num5 = item4.Index;
                            break;
                        }
                    }
                    if (num5 != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num5].Cells[1].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num5].Cells[2].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.BackColor = Color.IndianRed;
                        bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num5].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num5].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.ForeColor = Color.White;
                    }
                }
                else if (comboBox8.SelectedIndex == 3)
                {
                    string text9 = bunifuCustomTextbox1.Text;
                    int num6 = -1;
                    foreach (DataGridViewRow item5 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item5.Cells[0].Value.ToString().Equals(text9))
                        {
                            num6 = item5.Index;
                            break;
                        }
                    }
                    if (num6 != -1)
                    {
                        Color backColor5 = ColorTranslator.FromHtml("#FF8C00");
                        bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.BackColor = backColor5;
                        bunifuCustomDataGrid1.Rows[num6].Cells[1].Style.BackColor = backColor5;
                        bunifuCustomDataGrid1.Rows[num6].Cells[2].Style.BackColor = backColor5;
                        bunifuCustomDataGrid1.Rows[num6].Cells[3].Style.BackColor = backColor5;
                        bunifuCustomDataGrid1.Rows[num6].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num6].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num6].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num6].Cells[3].Style.ForeColor = Color.Black;
                    }
                }
                else if (comboBox8.SelectedIndex == 4)
                {
                    string text10 = bunifuCustomTextbox1.Text;
                    int num7 = -1;
                    foreach (DataGridViewRow item6 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item6.Cells[0].Value.ToString().Equals(text10))
                        {
                            num7 = item6.Index;
                            break;
                        }
                    }
                    if (num7 != -1)
                    {
                        Color backColor6 = ColorTranslator.FromHtml("#FFD700");
                        bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.BackColor = backColor6;
                        bunifuCustomDataGrid1.Rows[num7].Cells[1].Style.BackColor = backColor6;
                        bunifuCustomDataGrid1.Rows[num7].Cells[2].Style.BackColor = backColor6;
                        bunifuCustomDataGrid1.Rows[num7].Cells[3].Style.BackColor = backColor6;
                        bunifuCustomDataGrid1.Rows[num7].Cells[0].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num7].Cells[1].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num7].Cells[2].Style.ForeColor = Color.Black;
                        bunifuCustomDataGrid1.Rows[num7].Cells[3].Style.ForeColor = Color.Black;
                    }
                }
                else if (comboBox8.SelectedIndex == 5)
                {
                    string text11 = bunifuCustomTextbox1.Text;
                    int num8 = -1;
                    foreach (DataGridViewRow item7 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item7.Cells[0].Value.ToString().Equals(text11))
                        {
                            num8 = item7.Index;
                            break;
                        }
                    }
                    if (num8 != -1)
                    {
                        Color backColor7 = ColorTranslator.FromHtml("#6A5ACD");
                        bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.BackColor = backColor7;
                        bunifuCustomDataGrid1.Rows[num8].Cells[1].Style.BackColor = backColor7;
                        bunifuCustomDataGrid1.Rows[num8].Cells[2].Style.BackColor = backColor7;
                        bunifuCustomDataGrid1.Rows[num8].Cells[3].Style.BackColor = backColor7;
                        bunifuCustomDataGrid1.Rows[num8].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num8].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num8].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num8].Cells[3].Style.ForeColor = Color.White;
                    }
                }
                else
                {
                    if (comboBox8.SelectedIndex != 6)
                    {
                        return;
                    }
                    string text12 = bunifuCustomTextbox1.Text;
                    int num9 = -1;
                    foreach (DataGridViewRow item8 in bunifuCustomDataGrid1.Rows)
                    {
                        if (item8.Cells[0].Value.ToString().Equals(text12))
                        {
                            num9 = item8.Index;
                            break;
                        }
                    }
                    if (num9 != -1)
                    {
                        Color backColor8 = ColorTranslator.FromHtml("#000000");
                        bunifuCustomDataGrid1.Rows[num9].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                        bunifuCustomDataGrid1.Rows[num9].Cells[0].Style.BackColor = backColor8;
                        bunifuCustomDataGrid1.Rows[num9].Cells[1].Style.BackColor = backColor8;
                        bunifuCustomDataGrid1.Rows[num9].Cells[2].Style.BackColor = backColor8;
                        bunifuCustomDataGrid1.Rows[num9].Cells[3].Style.BackColor = backColor8;
                        bunifuCustomDataGrid1.Rows[num9].Cells[0].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num9].Cells[1].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num9].Cells[2].Style.ForeColor = Color.White;
                        bunifuCustomDataGrid1.Rows[num9].Cells[3].Style.ForeColor = Color.White;
                    }
                    return;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num == 1)
                {
                    alerts.Show("Account added!", alerts.AlertType.success);
                }
                else
                {
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            bool flag = false;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + bunifuCustomTextbox1.Text + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    flag = true;
                    mySqlDataReader["id"].ToString();
                    string login = mySqlDataReader["login"].ToString();
                    updateaccount(login);
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
            bunifuCustomDataGrid1.ClearSelection();
            if (flag)
            {
                return;
            }
            newaccount();
            string filename = "ranks\\" + comboBox2.SelectedIndex + ".png";
            string filename2 = "ranks\\" + comboBox3.SelectedIndex + ".png";
            Bitmap imgToResize = new Bitmap(filename);
            Bitmap imgToResize2 = new Bitmap(filename2);
            string text3 = bunifuCustomTextbox1.Text;
            int num = -1;
            foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
            {
                if (item.Cells[0].Value.ToString().Equals(text3))
                {
                    num = item.Index;
                    break;
                }
            }
            if (num != -1)
            {
                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                bunifuCustomDataGrid1.Rows[num].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                bunifuCustomDataGrid1.Rows[num].Cells[1].Value = resizeImage(imgToResize, new Size(60, 24));
                bunifuCustomDataGrid1.Rows[num].Cells[2].Value = resizeImage(imgToResize2, new Size(60, 24));
                if (comboBox8.SelectedIndex == 0)
                {
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.Black;
                }
                if (comboBox8.SelectedIndex == 1)
                {
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = Color.GreenYellow;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = Color.GreenYellow;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = Color.GreenYellow;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = Color.GreenYellow;
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.Black;
                }
                if (comboBox8.SelectedIndex == 2)
                {
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = Color.IndianRed;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = Color.IndianRed;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = Color.IndianRed;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = Color.IndianRed;
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.White;
                }
                if (comboBox8.SelectedIndex == 3)
                {
                    Color backColor = ColorTranslator.FromHtml("#FF8C00");
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = backColor;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = backColor;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = backColor;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = backColor;
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.Black;
                }
                if (comboBox8.SelectedIndex == 4)
                {
                    Color backColor2 = ColorTranslator.FromHtml("#FFD700");
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = backColor2;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = backColor2;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = backColor2;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = backColor2;
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.Black;
                }
                if (comboBox8.SelectedIndex == 5)
                {
                    Color backColor3 = ColorTranslator.FromHtml("#6A5ACD");
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = backColor3;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = backColor3;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = backColor3;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = backColor3;
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.White;
                }
                if (comboBox8.SelectedIndex == 6)
                {
                    Color backColor4 = ColorTranslator.FromHtml("#000000");
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = backColor4;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = backColor4;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = backColor4;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = backColor4;
                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.White;
                }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
            comboBox7.Visible = true;
            label42.Visible = true;
            comboBox8.Visible = false;
            label43.Visible = false;
            bunifuThinButton21.Visible = false;
            bunifuThinButton22.Visible = false;
            bunifuThinButton23.Visible = false;
            bunifuThinButton24.Visible = false;
            bunifuThinButton25.Visible = false;
            bunifuThinButton26.Visible = false;
            bunifuThinButton27.Visible = false;
            bunifuThinButton28.Visible = false;
            bunifuThinButton29.Visible = false;
            label40.Visible = true;
            label41.Visible = true;
            bunifuCustomTextbox31.Visible = true;
            bunifuCustomTextbox30.Visible = true;
            bunifuCustomTextbox1.Visible = false;
            bunifuCustomTextbox2.Visible = false;
            bunifuCustomTextbox3.Visible = false;
            bunifuCustomTextbox4.Visible = false;
            bunifuCustomTextbox5.Visible = false;
            bunifuCustomTextbox6.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            bunifuThinButton212.Visible = false;
            bunifuThinButton211.Visible = false;
            bunifuThinButton210.Visible = false;
            label3.Text = "PANEL SETTINGS";
            bunifuCustomTextbox1.Text = "";
            bunifuCustomTextbox2.Text = "";
            bunifuCustomTextbox3.Text = "";
            bunifuCustomTextbox4.Text = "-x 0 -y 0";
            bunifuCustomTextbox5.Text = "0";
            bunifuCustomTextbox6.Text = "0";
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            bunifuCustomDataGrid1.Visible = false;
            label25.Visible = true;
            label11.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label24.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label37.Visible = true;
            label38.Visible = true;
            label39.Visible = true;
            bunifuThinButton213.Visible = true;
            bunifuThinButton214.Visible = true;
            bunifuThinButton215.Visible = true;
            bunifuCustomTextbox17.Visible = true;
            bunifuCustomTextbox7.Visible = true;
            bunifuCustomTextbox8.Visible = true;
            bunifuCustomTextbox9.Visible = true;
            bunifuCustomTextbox10.Visible = true;
            bunifuCustomTextbox11.Visible = true;
            bunifuCustomTextbox12.Visible = true;
            bunifuCustomTextbox13.Visible = true;
            bunifuCustomTextbox14.Visible = true;
            bunifuCustomTextbox15.Visible = true;
            comboBox1.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = false;
            comboBox9.Visible = true;
            bunifuCustomTextbox16.Visible = true;
            bunifuCustomTextbox18.Visible = true;
            bunifuCustomTextbox19.Visible = true;
            bunifuCustomTextbox20.Visible = true;
            bunifuCustomTextbox21.Visible = true;
            bunifuCustomTextbox22.Visible = true;
            bunifuCustomTextbox23.Visible = true;
            bunifuCustomTextbox24.Visible = true;
            bunifuCustomTextbox25.Visible = true;
            bunifuCustomTextbox26.Visible = true;
            bunifuCustomTextbox27.Visible = true;
            bunifuCustomTextbox28.Visible = true;
            bunifuCustomTextbox29.Visible = true;
            tab = 2;
            currentbox = 0;
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void updateleaders1()
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM leaders where id=1;");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.CommandText = "UPDATE leaders SET login='" + comboBox1.SelectedItem.ToString() + "' WHERE id=1";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num != 1)
                {
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void updateleaders2()
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM leaders where id=2;");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.CommandText = "UPDATE leaders SET login='" + comboBox4.SelectedItem.ToString() + "' WHERE id=2";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num != 1)
                {
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void updatedisconnects_mysql()
        {
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM disconnects WHERE id=1;");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    reconnect_1 = mySqlDataReader["rec1"].ToString();
                    reconnect_2 = mySqlDataReader["rec2"].ToString();
                    reconnect_3 = mySqlDataReader["rec3"].ToString();
                    reconnect_4 = mySqlDataReader["rec4"].ToString();
                    reconnect_5 = mySqlDataReader["rec5"].ToString();
                    reconnect_6 = mySqlDataReader["rec6"].ToString();
                    reconnect_7 = mySqlDataReader["rec7"].ToString();
                    reconnect_8 = mySqlDataReader["rec8"].ToString();
                    reconnect_9 = mySqlDataReader["rec9"].ToString();
                    reconnect_10 = mySqlDataReader["rec10"].ToString();
                    reconnect_color = mySqlDataReader["color"].ToString();
                    reconnect_mode = mySqlDataReader["mode"].ToString();
                    reconnect_win = mySqlDataReader["win"].ToString();
                    reconnect_lose = mySqlDataReader["lose"].ToString();
                    bool flag = true;
                    if (flag)
                    {
                        string s = reconnect_1.Split(',')[0];
                        string s2 = reconnect_1.Split(',')[1];
                        int.TryParse(s, out disconnectx_1);
                        int.TryParse(s2, out disconnecty_1);
                    }
                    if (flag)
                    {
                        string s3 = reconnect_2.Split(',')[0];
                        string s4 = reconnect_2.Split(',')[1];
                        int.TryParse(s3, out disconnectx_2);
                        int.TryParse(s4, out disconnecty_2);
                    }
                    if (flag)
                    {
                        string s5 = reconnect_3.Split(',')[0];
                        string s6 = reconnect_3.Split(',')[1];
                        int.TryParse(s5, out disconnectx_3);
                        int.TryParse(s6, out disconnecty_3);
                    }
                    if (flag)
                    {
                        string s7 = reconnect_4.Split(',')[0];
                        string s8 = reconnect_4.Split(',')[1];
                        int.TryParse(s7, out disconnectx_4);
                        int.TryParse(s8, out disconnecty_4);
                    }
                    if (flag)
                    {
                        string s9 = reconnect_5.Split(',')[0];
                        string s10 = reconnect_5.Split(',')[1];
                        int.TryParse(s9, out disconnectx_5);
                        int.TryParse(s10, out disconnecty_5);
                    }
                    if (flag)
                    {
                        string s11 = reconnect_6.Split(',')[0];
                        string s12 = reconnect_6.Split(',')[1];
                        int.TryParse(s11, out disconnectx_6);
                        int.TryParse(s12, out disconnecty_6);
                    }
                    if (flag)
                    {
                        string s13 = reconnect_7.Split(',')[0];
                        string s14 = reconnect_7.Split(',')[1];
                        int.TryParse(s13, out disconnectx_7);
                        int.TryParse(s14, out disconnecty_7);
                    }
                    if (flag)
                    {
                        string s15 = reconnect_8.Split(',')[0];
                        string s16 = reconnect_8.Split(',')[1];
                        int.TryParse(s15, out disconnectx_8);
                        int.TryParse(s16, out disconnecty_8);
                    }
                    if (flag)
                    {
                        string s17 = reconnect_9.Split(',')[0];
                        string s18 = reconnect_9.Split(',')[1];
                        int.TryParse(s17, out disconnectx_9);
                        int.TryParse(s18, out disconnecty_9);
                    }
                    if (flag)
                    {
                        string s19 = reconnect_10.Split(',')[0];
                        string s20 = reconnect_10.Split(',')[1];
                        int.TryParse(s19, out disconnectx_10);
                        int.TryParse(s20, out disconnecty_10);
                    }
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                bunifuCustomTextbox16.Text = reconnect_1;
                bunifuCustomTextbox18.Text = reconnect_2;
                bunifuCustomTextbox19.Text = reconnect_3;
                bunifuCustomTextbox20.Text = reconnect_4;
                bunifuCustomTextbox21.Text = reconnect_5;
                bunifuCustomTextbox22.Text = reconnect_6;
                bunifuCustomTextbox23.Text = reconnect_7;
                bunifuCustomTextbox24.Text = reconnect_8;
                bunifuCustomTextbox25.Text = reconnect_9;
                bunifuCustomTextbox26.Text = reconnect_10;
                bunifuCustomTextbox28.Text = reconnect_win;
                bunifuCustomTextbox29.Text = reconnect_lose;
                bunifuCustomTextbox27.Text = reconnect_color;
                int result = -1;
                int.TryParse(reconnect_mode, out result);
                comboBox5.SelectedIndex = result;
                mySqlCommand.Connection.Close();
            }
        }

        private void updatedisconnects()
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM disconnects where id=1;");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.CommandText = "UPDATE disconnects SET rec1='" + bunifuCustomTextbox16.Text + "', rec2='" + bunifuCustomTextbox18.Text + "', rec3='" + bunifuCustomTextbox19.Text + "', rec4='" + bunifuCustomTextbox20.Text + "', rec5='" + bunifuCustomTextbox21.Text + "', rec6='" + bunifuCustomTextbox22.Text + "', rec7='" + bunifuCustomTextbox23.Text + "', rec8='" + bunifuCustomTextbox24.Text + "', rec9='" + bunifuCustomTextbox25.Text + "', rec10='" + bunifuCustomTextbox26.Text + "', color='" + bunifuCustomTextbox27.Text + "', win='" + bunifuCustomTextbox28.Text + "', lose='" + bunifuCustomTextbox29.Text + "', mode='" + comboBox5.SelectedIndex + "' WHERE id=1";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num == 1)
                {
                    reconnect_1 = bunifuCustomTextbox16.Text;
                    reconnect_2 = bunifuCustomTextbox18.Text;
                    reconnect_3 = bunifuCustomTextbox19.Text;
                    reconnect_4 = bunifuCustomTextbox20.Text;
                    reconnect_5 = bunifuCustomTextbox21.Text;
                    reconnect_6 = bunifuCustomTextbox22.Text;
                    reconnect_7 = bunifuCustomTextbox23.Text;
                    reconnect_8 = bunifuCustomTextbox24.Text;
                    reconnect_9 = bunifuCustomTextbox25.Text;
                    reconnect_10 = bunifuCustomTextbox26.Text;
                    reconnect_color = bunifuCustomTextbox27.Text;
                    reconnect_win = bunifuCustomTextbox28.Text;
                    reconnect_lose = bunifuCustomTextbox29.Text;
                    reconnect_mode = comboBox5.SelectedIndex.ToString();
                    bool flag = true;
                    if (flag)
                    {
                        string s = reconnect_1.Split(',')[0];
                        string s2 = reconnect_1.Split(',')[1];
                        int.TryParse(s, out disconnectx_1);
                        int.TryParse(s2, out disconnecty_1);
                    }
                    if (flag)
                    {
                        string s3 = reconnect_2.Split(',')[0];
                        string s4 = reconnect_2.Split(',')[1];
                        int.TryParse(s3, out disconnectx_2);
                        int.TryParse(s4, out disconnecty_2);
                    }
                    if (flag)
                    {
                        string s5 = reconnect_3.Split(',')[0];
                        string s6 = reconnect_3.Split(',')[1];
                        int.TryParse(s5, out disconnectx_3);
                        int.TryParse(s6, out disconnecty_3);
                    }
                    if (flag)
                    {
                        string s7 = reconnect_4.Split(',')[0];
                        string s8 = reconnect_4.Split(',')[1];
                        int.TryParse(s7, out disconnectx_4);
                        int.TryParse(s8, out disconnecty_4);
                    }
                    if (flag)
                    {
                        string s9 = reconnect_5.Split(',')[0];
                        string s10 = reconnect_5.Split(',')[1];
                        int.TryParse(s9, out disconnectx_5);
                        int.TryParse(s10, out disconnecty_5);
                    }
                    if (flag)
                    {
                        string s11 = reconnect_6.Split(',')[0];
                        string s12 = reconnect_6.Split(',')[1];
                        int.TryParse(s11, out disconnectx_6);
                        int.TryParse(s12, out disconnecty_6);
                    }
                    if (flag)
                    {
                        string s13 = reconnect_7.Split(',')[0];
                        string s14 = reconnect_7.Split(',')[1];
                        int.TryParse(s13, out disconnectx_7);
                        int.TryParse(s14, out disconnecty_7);
                    }
                    if (flag)
                    {
                        string s15 = reconnect_8.Split(',')[0];
                        string s16 = reconnect_8.Split(',')[1];
                        int.TryParse(s15, out disconnectx_8);
                        int.TryParse(s16, out disconnecty_8);
                    }
                    if (flag)
                    {
                        string s17 = reconnect_9.Split(',')[0];
                        string s18 = reconnect_9.Split(',')[1];
                        int.TryParse(s17, out disconnectx_9);
                        int.TryParse(s18, out disconnecty_9);
                    }
                    if (flag)
                    {
                        string s19 = reconnect_10.Split(',')[0];
                        string s20 = reconnect_10.Split(',')[1];
                        int.TryParse(s19, out disconnectx_10);
                        int.TryParse(s20, out disconnecty_10);
                    }
                }
                else
                {
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void bunifuThinButton213_Click(object sender, EventArgs e)
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM settings where id=1;");
            mySqlCommand.Connection = connection;
            try
            {
                string text3 = bunifuCustomTextbox17.Text.Replace("\\", "\\\\");
                string text4 = bunifuCustomTextbox7.Text.Replace("\\", "\\\\");
                mySqlCommand.CommandText = "UPDATE settings SET steam='" + text3 + "', csgo='" + text4 + "', start1='" + bunifuCustomTextbox8.Text + "', start2='" + bunifuCustomTextbox9.Text + "', play1='" + bunifuCustomTextbox12.Text + "', play2='" + bunifuCustomTextbox13.Text + "', color_start1='" + bunifuCustomTextbox10.Text + "', color_start2='" + bunifuCustomTextbox11.Text + "', color_play1='" + bunifuCustomTextbox14.Text + "', reconnect='" + bunifuCustomTextbox30.Text + "', type='" + comboBox7.SelectedIndex + "', type48='" + comboBox9.SelectedIndex + "', disconnect='" + bunifuCustomTextbox31.Text + "', color_play2='" + bunifuCustomTextbox15.Text + "' WHERE id=1";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
                typed = comboBox7.SelectedIndex.ToString();
                typed48 = comboBox9.SelectedIndex.ToString();
                steampath = bunifuCustomTextbox17.Text;
                csgopath = bunifuCustomTextbox7.Text;
                start_mysql1 = bunifuCustomTextbox8.Text;
                start_mysql2 = bunifuCustomTextbox9.Text;
                color_start1 = bunifuCustomTextbox10.Text;
                color_start2 = bunifuCustomTextbox11.Text;
                play_mysql1 = bunifuCustomTextbox12.Text;
                play_mysql2 = bunifuCustomTextbox13.Text;
                color_play1 = bunifuCustomTextbox14.Text;
                color_play2 = bunifuCustomTextbox15.Text;
                ms1 = bunifuCustomTextbox30.Text;
                ms2 = bunifuCustomTextbox31.Text;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num == 1)
                {
                    alerts.Show("Successfully!", alerts.AlertType.success);
                    fetchleader1();
                    fetchleader2();
                    updatemeplz2();
                    updateleaders1();
                    updateleaders2();
                    fetchleader1();
                    fetchleader2();
                    updatemeplz1();
                }
                else
                {
                    MessageBox.Show("Unknown error!");
                }
            }
            bool flag = true;
            if (flag)
            {
                string value = leader1;
                int num2 = -1;
                foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
                {
                    if (item.Cells[0].Value.ToString().Equals(value))
                    {
                        num2 = item.Index;
                        break;
                    }
                }
                if (num2 != -1)
                {
                    bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.ForeColor = Color.Black;
                }
            }
            if (flag)
            {
                string value2 = leader2;
                int num3 = -1;
                foreach (DataGridViewRow item2 in bunifuCustomDataGrid1.Rows)
                {
                    if (item2.Cells[0].Value.ToString().Equals(value2))
                    {
                        num3 = item2.Index;
                        break;
                    }
                }
                if (num3 != -1)
                {
                    bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.BackColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.ForeColor = Color.Black;
                    bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.ForeColor = Color.Black;
                }
            }
            updateleaders1();
            updateleaders2();
            Thread.Sleep(1000);
            fetchleader1();
            fetchleader2();
            if (flag)
            {
                string value3 = leader1;
                int num4 = -1;
                foreach (DataGridViewRow item3 in bunifuCustomDataGrid1.Rows)
                {
                    if (item3.Cells[0].Value.ToString().Equals(value3))
                    {
                        num4 = item3.Index;
                        break;
                    }
                }
                if (num4 != -1)
                {
                    bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num4].Cells[0].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num4].Cells[1].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num4].Cells[2].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num4].Cells[3].Style.BackColor = Color.Cyan;
                    comboBox1.SelectedIndex = comboBox1.Items.IndexOf(leader1);
                }
            }
            if (flag)
            {
                string value4 = leader2;
                int num5 = -1;
                foreach (DataGridViewRow item4 in bunifuCustomDataGrid1.Rows)
                {
                    if (item4.Cells[0].Value.ToString().Equals(value4))
                    {
                        num5 = item4.Index;
                        break;
                    }
                }
                if (num5 != -1)
                {
                    bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.BackColor = Color.MediumBlue;
                    bunifuCustomDataGrid1.Rows[num5].Cells[1].Style.BackColor = Color.MediumBlue;
                    bunifuCustomDataGrid1.Rows[num5].Cells[2].Style.BackColor = Color.MediumBlue;
                    bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.BackColor = Color.MediumBlue;
                    bunifuCustomDataGrid1.Rows[num5].Cells[0].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num5].Cells[1].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num5].Cells[2].Style.ForeColor = Color.White;
                    bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.ForeColor = Color.White;
                    comboBox4.SelectedIndex = comboBox4.Items.IndexOf(leader2);
                }
            }
            if (flag)
            {
                fetchleader1_mysql();
                fetchleader2_mysql();
                int result = 0;
                int.TryParse(userid_l1, out result);
                int result2 = 0;
                int.TryParse(userid_l2, out result2);
                long num6 = result + 76561197960265728L;
                string text5 = string.Concat(str2: (result2 + 76561197960265728L).ToString(), str0: num6.ToString(), str1: ",");
                bunifuCustomTextbox28.Text = text5;
                reconnect_win = text5;
            }
            updatedisconnects();
        }

        private void refreshdata()
        {
            bunifuCustomDataGrid1.ClearSelection();
            bunifuCustomDataGrid1.Rows.Clear();
            comboBox1.Items.Clear();
            comboBox4.Items.Clear();
            foreach (DataGridViewColumn column in bunifuCustomDataGrid1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            bunifuCustomDataGrid1.MultiSelect = false;
            bunifuCustomDataGrid1.RowTemplate.Height = 30;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts ORDER BY id;");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    string text3 = mySqlDataReader["hello"].ToString();
                    mySqlDataReader["id"].ToString();
                    string filename = "ranks\\" + mySqlDataReader["5x5"].ToString() + ".png";
                    string filename2 = "ranks\\" + mySqlDataReader["2x2"].ToString() + ".png";
                    Bitmap imgToResize = new Bitmap(filename);
                    Bitmap imgToResize2 = new Bitmap(filename2);
                    bunifuCustomDataGrid1.Rows.Add(mySqlDataReader["login"].ToString());
                    comboBox1.Items.Add(mySqlDataReader["login"].ToString());
                    comboBox4.Items.Add(mySqlDataReader["login"].ToString());
                    string value = mySqlDataReader["login"].ToString();
                    int num = -1;
                    foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
                    {
                        if (item.Cells[0].Value.ToString().Equals(value))
                        {
                            num = item.Index;
                            break;
                        }
                    }
                    if (num != -1)
                    {
                        bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        bunifuCustomDataGrid1.Rows[num].Cells[1].Value = resizeImage(imgToResize, new Size(60, 24));
                        bunifuCustomDataGrid1.Rows[num].Cells[2].Value = resizeImage(imgToResize2, new Size(60, 24));
                        bunifuCustomDataGrid1.Rows[num].Cells[3].Value = mySqlDataReader["whichlobby"].ToString();
                        bunifuCustomDataGrid1.Rows[num].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        switch (text3)
                        {
                            case "0":
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = Color.White;
                                bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = Color.White;
                                bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = Color.White;
                                bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = Color.White;
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.Black;
                                bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.Black;
                                bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.Black;
                                bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.Black;
                                break;
                            case "1":
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = Color.GreenYellow;
                                bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = Color.GreenYellow;
                                bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = Color.GreenYellow;
                                bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = Color.GreenYellow;
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.Black;
                                bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.Black;
                                bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.Black;
                                bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.Black;
                                break;
                            case "2":
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = Color.IndianRed;
                                bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = Color.IndianRed;
                                bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = Color.IndianRed;
                                bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = Color.IndianRed;
                                bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.White;
                                bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.White;
                                bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.White;
                                bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.White;
                                break;
                            case "3":
                                {
                                    Color backColor4 = ColorTranslator.FromHtml("#FF8C00");
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = backColor4;
                                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = backColor4;
                                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = backColor4;
                                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = backColor4;
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.Black;
                                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.Black;
                                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.Black;
                                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.Black;
                                    break;
                                }
                            case "4":
                                {
                                    Color backColor3 = ColorTranslator.FromHtml("#FFD700");
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = backColor3;
                                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = backColor3;
                                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = backColor3;
                                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = backColor3;
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.Black;
                                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.Black;
                                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.Black;
                                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.Black;
                                    break;
                                }
                            case "5":
                                {
                                    Color backColor2 = ColorTranslator.FromHtml("#6A5ACD");
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = backColor2;
                                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = backColor2;
                                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = backColor2;
                                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = backColor2;
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.White;
                                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.White;
                                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.White;
                                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.White;
                                    break;
                                }
                            case "6":
                                {
                                    Color backColor = ColorTranslator.FromHtml("#000000");
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.BackColor = backColor;
                                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.BackColor = backColor;
                                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.BackColor = backColor;
                                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.BackColor = backColor;
                                    bunifuCustomDataGrid1.Rows[num].Cells[0].Style.ForeColor = Color.White;
                                    bunifuCustomDataGrid1.Rows[num].Cells[1].Style.ForeColor = Color.White;
                                    bunifuCustomDataGrid1.Rows[num].Cells[2].Style.ForeColor = Color.White;
                                    bunifuCustomDataGrid1.Rows[num].Cells[3].Style.ForeColor = Color.White;
                                    break;
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unknown error", "Error");
                    }
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                Environment.Exit(0);
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
            bunifuCustomDataGrid1.ClearSelection();
            fetchleader1();
            fetchleader2();
            fetchsettings();
            bool flag = true;
            if (flag)
            {
                string value2 = leader1;
                int num2 = -1;
                foreach (DataGridViewRow item2 in bunifuCustomDataGrid1.Rows)
                {
                    if (item2.Cells[0].Value.ToString().Equals(value2))
                    {
                        num2 = item2.Index;
                        break;
                    }
                }
                if (num2 != -1)
                {
                    bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                    bunifuCustomDataGrid1.Rows[num2].Cells[0].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num2].Cells[1].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num2].Cells[2].Style.BackColor = Color.Cyan;
                    bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.BackColor = Color.Cyan;
                    comboBox1.SelectedIndex = comboBox1.Items.IndexOf(leader1);
                }
            }
            if (!flag)
            {
                return;
            }
            string value3 = leader2;
            int num3 = -1;
            foreach (DataGridViewRow item3 in bunifuCustomDataGrid1.Rows)
            {
                if (item3.Cells[0].Value.ToString().Equals(value3))
                {
                    num3 = item3.Index;
                    break;
                }
            }
            if (num3 != -1)
            {
                bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
                bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.BackColor = Color.MediumBlue;
                bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.BackColor = Color.MediumBlue;
                bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.BackColor = Color.MediumBlue;
                bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.BackColor = Color.MediumBlue;
                bunifuCustomDataGrid1.Rows[num3].Cells[0].Style.ForeColor = Color.White;
                bunifuCustomDataGrid1.Rows[num3].Cells[1].Style.ForeColor = Color.White;
                bunifuCustomDataGrid1.Rows[num3].Cells[2].Style.ForeColor = Color.White;
                bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.ForeColor = Color.White;
                comboBox4.SelectedIndex = comboBox4.Items.IndexOf(leader2);
            }
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts ORDER BY id;");
            mySqlCommand.Connection = connection;
            try
            {
                string text4 = (mySqlCommand.CommandText = "DELETE FROM accounts WHERE login='" + bunifuCustomTextbox1.Text + "'");
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num == 1)
                {
                    bunifuCustomDataGrid1.ClearSelection();
                    bunifuCustomTextbox1.Text = "";
                    bunifuCustomTextbox2.Text = "";
                    bunifuCustomTextbox3.Text = "";
                    bunifuCustomTextbox4.Text = "-x 0 -y 0";
                    bunifuCustomTextbox5.Text = "0";
                    bunifuCustomTextbox6.Text = "0";
                    comboBox2.SelectedIndex = 0;
                    comboBox3.SelectedIndex = 0;
                    comboBox8.SelectedIndex = 0;
                    if (userid != "")
                    {
                        SetFileReadAccess(steampath + "userdata\\" + userid + "\\730\\local\\cfg\\config.cfg", SetReadOnly: false);
                        SetFileReadAccess(steampath + "userdata\\" + userid + "\\730\\local\\cfg\\video.txt", SetReadOnly: false);
                    }
                    accountname = "";
                    whichlobby = "";
                    rank5x5 = "";
                    rank2x2 = "";
                    profile = "";
                    userid = "";
                    SharedMy = "";
                    SharedSecret = "";
                    acceptx = "";
                    accepty = "";
                    disable = "";
                    alerts.Show("Account removed!", alerts.AlertType.success);
                    comboBox1.Items.Clear();
                    comboBox4.Items.Clear();
                    bunifuCustomDataGrid1.Rows.Clear();
                    bunifuCustomDataGrid1.Refresh();
                    formloadnew("WIN");
                    formloadnew("LOSE");
                    formloadnew("ONLY WIN");
                    formloadnew("ONLY LOSE");
                    formloadnew("UNK");
                    fetchleader1();
                    fetchleader2();
                    bunifuCustomDataGrid1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void copyDirectory(string strSource, string strDestination)
        {
            FileInfo[] files;
            DirectoryInfo[] directories;
            if (!Directory.Exists(strDestination))
            {
                Directory.CreateDirectory(strDestination);
                DirectoryInfo directoryInfo = new DirectoryInfo(strSource);
                files = directoryInfo.GetFiles();
                foreach (FileInfo fileInfo in files)
                {
                    fileInfo.CopyTo(Path.Combine(strDestination, fileInfo.Name));
                }
                directories = directoryInfo.GetDirectories();
                foreach (DirectoryInfo directoryInfo2 in directories)
                {
                    copyDirectory(Path.Combine(strSource, directoryInfo2.Name), Path.Combine(strDestination, directoryInfo2.Name));
                }
                return;
            }
            Directory.Delete(strDestination, recursive: true);
            Directory.CreateDirectory(strDestination);
            DirectoryInfo directoryInfo3 = new DirectoryInfo(strSource);
            files = directoryInfo3.GetFiles();
            foreach (FileInfo fileInfo2 in files)
            {
                fileInfo2.CopyTo(Path.Combine(strDestination, fileInfo2.Name));
            }
            directories = directoryInfo3.GetDirectories();
            foreach (DirectoryInfo directoryInfo4 in directories)
            {
                copyDirectory(Path.Combine(strSource, directoryInfo4.Name), Path.Combine(strDestination, directoryInfo4.Name));
            }
        }

        private static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] array = File.ReadAllLines(fileName);
            array[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, array);
        }

        public static void SetFileReadAccess(string FileName, bool SetReadOnly)
        {
            new FileInfo(FileName).IsReadOnly = SetReadOnly;
        }

        public static bool IsFileReadOnly(string FileName)
        {
            return new FileInfo(FileName).IsReadOnly;
        }

        public static void DeleteDirectory(string path)
        {
            string[] directories = Directory.GetDirectories(path);
            for (int i = 0; i < directories.Length; i++)
            {
                DeleteDirectory(directories[i]);
            }
            try
            {
                Directory.Delete(path, recursive: true);
            }
            catch (IOException)
            {
                Directory.Delete(path, recursive: true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, recursive: true);
            }
        }

        private void updatecurrentaccount(string accountlogin, string account64, string accountid)
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + accountlogin + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.CommandText = "UPDATE accounts SET userid='" + accountid + "', profile='" + account64 + "' WHERE login='" + accountlogin + "'";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
                userid = accountid;
                profile = account64;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num == 1)
                {
                    alerts.Show("Successfully!", alerts.AlertType.success);
                }
                else
                {
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void sendinfo(string mylogin, string mypassword, string shared)
        {
        }

        private void conf1()
        {
            if (!(accountname == "") || bunifuCustomDataGrid1.Rows.Count <= 0)
            {
                return;
            }
            foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
            {
                string text = item.Cells[0].Value.ToString();
                string text2 = getinfo(text);
                string shared = getinfo(text);
                if (!(text != "client") || !(text != "client1") || !(text != "client2") || !(text != "client3") || !(text != "client4") || !(text != "client5") || !(text != "client6") || !(text != "client7") || !(text != "client8") || !(text != "client9") || !(text != "client10") || !(text2 != "") || item.Index <= 5)
                {
                    continue;
                }
                sendinfo(text, text2, shared);
                if (Directory.Exists(steampath))
                {
                    string text3 = text;
                    text3 = text3.ToLower();
                    FileStream fileStream = new FileStream(steampath + "\\config\\loginusers.vdf", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    StreamReader streamReader = new StreamReader(fileStream);
                    string text4 = streamReader.ReadToEnd();
                    if (Regex.Match(text4, "AccountName\"\t\t\"" + text3 + "([^\n]+)").Groups[0].Value != "")
                    {
                        string[] array = text4.Split(new string[3]
                        {
                            "\r\n",
                            "\r",
                            "\n"
                        }, StringSplitOptions.None);
                        string value = "\t\t\"AccountName\"\t\t\"" + text3 + "\"";
                        int num = Array.IndexOf(array, value) - 2;
                        string value2 = Regex.Match(array[num], "\"([^\"]+)").Groups[1].Value;
                        if (value2 != "")
                        {
                            string text5 = value2;
                            if (long.TryParse(text5, out var result))
                            {
                                result -= 76561197960265728L;
                                if (result != 0L)
                                {
                                    string a = leader1;
                                    string a2 = leader2;
                                    string text6 = text;
                                    updatecurrentaccount(text6, text5, result.ToString());
                                    if (Directory.Exists(steampath))
                                    {
                                        if (File.Exists(steampath + "Steam.exe"))
                                        {
                                            if (!File.Exists(steampath + "Steam_" + result + ".exe"))
                                            {
                                                File.Copy(steampath + "Steam.exe", steampath + "Steam_" + result + ".exe");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Steam.exe not found!", "Error");
                                        }
                                        if (Directory.Exists(csgopath))
                                        {
                                            copyDirectory("data/game/", csgopath + "csgo_" + result);
                                            if (a == text6)
                                            {
                                                lineChanger("\tgame\t\"@ " + text6 + " | LEADER #1 @\"", csgopath + "csgo_" + result + "/gameinfo.txt", 3);
                                                lineChanger("con_logfile log/1.log", csgopath + "csgo_" + result + "/cfg/autoexec.cfg", 14);
                                                if (!File.Exists(csgopath + "csgo_" + result + "\\cfg\\gamestate_integration_boost.cfg"))
                                                {
                                                    new FileInfo(Directory.GetCurrentDirectory() + "\\data\\gsi\\gamestate_integration_boost.cfg").CopyTo(csgopath + "csgo_" + result + "\\cfg\\gamestate_integration_boost.cfg", overwrite: true);
                                                }
                                            }
                                            else if (a2 == text6)
                                            {
                                                lineChanger("\tgame\t\"@ " + text6 + " | LEADER #2 @\"", csgopath + "csgo_" + result + "/gameinfo.txt", 3);
                                                lineChanger("con_logfile log/2.log", csgopath + "csgo_" + result + "/cfg/autoexec.cfg", 14);
                                                if (!File.Exists(csgopath + "csgo_" + result + "\\cfg\\gamestate_integration_boost.cfg"))
                                                {
                                                    new FileInfo(Directory.GetCurrentDirectory() + "\\data\\gsi\\gamestate_integration_boost.cfg").CopyTo(csgopath + "csgo_" + result + "\\cfg\\gamestate_integration_boost.cfg", overwrite: true);
                                                }
                                            }
                                            else
                                            {
                                                lineChanger("\tgame\t\"@ " + text6 + " | BOT @\"", csgopath + "csgo_" + result + "/gameinfo.txt", 3);
                                                lineChanger("//con_logfile log/0.log", csgopath + "csgo_" + result + "/cfg/autoexec.cfg", 14);
                                            }
                                            if (!Directory.Exists(steampath + "userdata\\" + result + "\\"))
                                            {
                                                Directory.CreateDirectory(steampath + "userdata\\" + result + "\\");
                                            }
                                            if (!Directory.Exists(steampath + "userdata\\" + result + "\\730\\"))
                                            {
                                                Directory.CreateDirectory(steampath + "userdata\\" + result + "\\730\\");
                                            }
                                            if (!Directory.Exists(steampath + "userdata\\" + result + "\\730\\local\\"))
                                            {
                                                Directory.CreateDirectory(steampath + "userdata\\" + result + "\\730\\local\\");
                                            }
                                            if (!Directory.Exists(steampath + "userdata\\" + result + "\\730\\local\\cfg\\"))
                                            {
                                                Directory.CreateDirectory(steampath + "userdata\\" + result + "\\730\\local\\cfg\\");
                                            }
                                            bool num2 = File.Exists(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg");
                                            bool flag = File.Exists(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt");
                                            bool flag2 = File.Exists(steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt");
                                            if (num2)
                                            {
                                                if (!IsFileReadOnly(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg"))
                                                {
                                                    File.Copy("data/userdata/config.cfg", steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", overwrite: true);
                                                }
                                                else
                                                {
                                                    SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", SetReadOnly: false);
                                                    File.Copy("data/userdata/config.cfg", steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", overwrite: true);
                                                }
                                                SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", SetReadOnly: true);
                                            }
                                            else
                                            {
                                                File.Copy("data/userdata/config.cfg", steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", overwrite: true);
                                                SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", SetReadOnly: true);
                                            }
                                            if (flag)
                                            {
                                                if (!IsFileReadOnly(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt"))
                                                {
                                                    File.Copy("data/userdata/video.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", overwrite: true);
                                                }
                                                else
                                                {
                                                    SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", SetReadOnly: false);
                                                    File.Copy("data/userdata/video.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", overwrite: true);
                                                }
                                                SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", SetReadOnly: true);
                                            }
                                            else
                                            {
                                                File.Copy("data/userdata/video.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", overwrite: true);
                                                SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", SetReadOnly: true);
                                            }
                                            if (flag2)
                                            {
                                                if (!IsFileReadOnly(steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt"))
                                                {
                                                    File.Copy("data/userdata/videodefaults.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", overwrite: true);
                                                }
                                                else
                                                {
                                                    SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", SetReadOnly: false);
                                                    File.Copy("data/userdata/videodefaults.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", overwrite: true);
                                                }
                                            }
                                            else
                                            {
                                                File.Copy("data/userdata/videodefaults.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", overwrite: true);
                                                SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", SetReadOnly: true);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("csgo.exe not found!", "Error");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Steam.exe not found!", "Error");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Unknown error while getting STEAMID64", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Unknown error while getting STEAMID64", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unknown error while getting STEAMID64", "Error");
                        }
                    }
                    fileStream.Close();
                    streamReader.Close();
                }
                else
                {
                    MessageBox.Show("Steam.exe not found", "Error");
                }
            }
        }

        private void conf()
        {
            if (!(accountname != ""))
            {
                return;
            }
            sendinfo(accountname, password, SharedMy);
            if (Directory.Exists(steampath))
            {
                string text = accountname;
                _ = password;
                text = text.ToLower();
                FileStream fileStream = new FileStream(steampath + "\\config\\loginusers.vdf", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader streamReader = new StreamReader(fileStream);
                string text2 = streamReader.ReadToEnd();
                if (Regex.Match(text2, "AccountName\"\t\t\"" + text + "([^\n]+)").Groups[0].Value != "")
                {
                    string[] array = text2.Split(new string[3]
                    {
                        "\r\n",
                        "\r",
                        "\n"
                    }, StringSplitOptions.None);
                    string value = "\t\t\"AccountName\"\t\t\"" + text + "\"";
                    int num = Array.IndexOf(array, value) - 2;
                    string value2 = Regex.Match(array[num], "\"([^\"]+)").Groups[1].Value;
                    if (value2 != "")
                    {
                        string text3 = value2;
                        if (long.TryParse(text3, out var result))
                        {
                            result -= 76561197960265728L;
                            if (result != 0L)
                            {
                                string a = leader1;
                                string a2 = leader2;
                                string text4 = accountname;
                                updatecurrentaccount(text4, text3, result.ToString());
                                if (Directory.Exists(steampath))
                                {
                                    if (File.Exists(steampath + "Steam.exe"))
                                    {
                                        if (!File.Exists(steampath + "Steam_" + result + ".exe"))
                                        {
                                            File.Copy(steampath + "Steam.exe", steampath + "Steam_" + result + ".exe");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Steam.exe not found!", "Error");
                                    }
                                    if (Directory.Exists(csgopath))
                                    {
                                        copyDirectory("data/game/", csgopath + "csgo_" + result);
                                        if (a == text4)
                                        {
                                            lineChanger("\tgame\t\"@ " + text4 + " | LEADER #1 @\"", csgopath + "csgo_" + result + "/gameinfo.txt", 3);
                                            lineChanger("con_logfile log/1.log", csgopath + "csgo_" + result + "/cfg/autoexec.cfg", 14);
                                            if (!File.Exists(csgopath + "csgo_" + result + "\\cfg\\gamestate_integration_boost.cfg"))
                                            {
                                                new FileInfo(Directory.GetCurrentDirectory() + "\\data\\gsi\\gamestate_integration_boost.cfg").CopyTo(csgopath + "csgo_" + result + "\\cfg\\gamestate_integration_boost.cfg", overwrite: true);
                                            }
                                        }
                                        else if (a2 == text4)
                                        {
                                            lineChanger("\tgame\t\"@ " + text4 + " | LEADER #2 @\"", csgopath + "csgo_" + result + "/gameinfo.txt", 3);
                                            lineChanger("con_logfile log/2.log", csgopath + "csgo_" + result + "/cfg/autoexec.cfg", 14);
                                            if (!File.Exists(csgopath + "csgo_" + result + "\\cfg\\gamestate_integration_boost.cfg"))
                                            {
                                                new FileInfo(Directory.GetCurrentDirectory() + "\\data\\gsi\\gamestate_integration_boost.cfg").CopyTo(csgopath + "csgo_" + result + "\\cfg\\gamestate_integration_boost.cfg", overwrite: true);
                                            }
                                        }
                                        else
                                        {
                                            lineChanger("\tgame\t\"@ " + text4 + " | BOT @\"", csgopath + "csgo_" + result + "/gameinfo.txt", 3);
                                            lineChanger("//con_logfile log/0.log", csgopath + "csgo_" + result + "/cfg/autoexec.cfg", 14);
                                        }
                                        if (!Directory.Exists(steampath + "userdata\\" + result + "\\"))
                                        {
                                            Directory.CreateDirectory(steampath + "userdata\\" + result + "\\");
                                        }
                                        if (!Directory.Exists(steampath + "userdata\\" + result + "\\730\\"))
                                        {
                                            Directory.CreateDirectory(steampath + "userdata\\" + result + "\\730\\");
                                        }
                                        if (!Directory.Exists(steampath + "userdata\\" + result + "\\730\\local\\"))
                                        {
                                            Directory.CreateDirectory(steampath + "userdata\\" + result + "\\730\\local\\");
                                        }
                                        if (!Directory.Exists(steampath + "userdata\\" + result + "\\730\\local\\cfg\\"))
                                        {
                                            Directory.CreateDirectory(steampath + "userdata\\" + result + "\\730\\local\\cfg\\");
                                        }
                                        bool num2 = File.Exists(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg");
                                        bool flag = File.Exists(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt");
                                        bool flag2 = File.Exists(steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt");
                                        if (num2)
                                        {
                                            if (!IsFileReadOnly(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg"))
                                            {
                                                File.Copy("data/userdata/config.cfg", steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", overwrite: true);
                                            }
                                            else
                                            {
                                                SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", SetReadOnly: false);
                                                File.Copy("data/userdata/config.cfg", steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", overwrite: true);
                                            }
                                            SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", SetReadOnly: true);
                                        }
                                        else
                                        {
                                            File.Copy("data/userdata/config.cfg", steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", overwrite: true);
                                            SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\config.cfg", SetReadOnly: true);
                                        }
                                        if (flag)
                                        {
                                            if (!IsFileReadOnly(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt"))
                                            {
                                                File.Copy("data/userdata/video.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", overwrite: true);
                                            }
                                            else
                                            {
                                                SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", SetReadOnly: false);
                                                File.Copy("data/userdata/video.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", overwrite: true);
                                            }
                                            SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", SetReadOnly: true);
                                        }
                                        else
                                        {
                                            File.Copy("data/userdata/video.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", overwrite: true);
                                            SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\video.txt", SetReadOnly: true);
                                        }
                                        if (flag2)
                                        {
                                            if (!IsFileReadOnly(steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt"))
                                            {
                                                File.Copy("data/userdata/videodefaults.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", overwrite: true);
                                            }
                                            else
                                            {
                                                SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", SetReadOnly: false);
                                                File.Copy("data/userdata/videodefaults.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", overwrite: true);
                                            }
                                        }
                                        else
                                        {
                                            File.Copy("data/userdata/videodefaults.txt", steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", overwrite: true);
                                            SetFileReadAccess(steampath + "userdata\\" + result + "\\730\\local\\cfg\\videodefaults.txt", SetReadOnly: true);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("csgo.exe not found!", "Error");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Steam.exe not found!", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Unknown error while getting STEAMID64", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unknown error while getting STEAMID64", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unknown error while getting STEAMID64", "Error");
                    }
                }
                else
                {
                    Process process = new Process();
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    processStartInfo.FileName = "cmd.exe";
                    string text7 = (processStartInfo.Arguments = (processStartInfo.Arguments = "/C \"" + steampath + "Steam.exe\" + -login " + accountname + " " + password + " -no-browser -skipstreamingdrivers -vrdisable -nocrashdialog -nocrashmonitor -norepairfiles -noverifyfiles -nodircheck -nocache -noaafonts -silent"));
                    process.StartInfo = processStartInfo;
                    process.Start();
                    loginintoaccount.RunWorkerAsync(1);
                }
                fileStream.Close();
                streamReader.Close();
            }
            else
            {
                MessageBox.Show("Steam.exe not found", "Error");
            }
        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {
            if (accountname != "")
            {
                if (bunifuCustomDataGrid1.Rows.Count > 0 && bunifuCustomDataGrid1.CurrentCell.RowIndex > -1)
                {
                    conf();
                }
            }
            else
            {
                conf1();
            }
        }

        [DllImport("User32.dll")]
        public static extern bool SetWindowText(IntPtr hwnd, string title);

        private void testkill()
        {
            Thread.Sleep(15000);
            try
            {
                foreach (Process item in from pr in Process.GetProcesses()
                                         where pr.ProcessName == "steam"
                                         select pr)
                {
                    item.Kill();
                }
            }
            catch (Exception)
            {
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count <= 0 || bunifuCustomDataGrid1.CurrentCell.RowIndex <= -1)
            {
                return;
            }
            if (!namedPipeExist(accountname))
            {
                string text = Directory.GetCurrentDirectory() + "/launcher/SERVER.exe";
                Process process = new Process();
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "cmd.exe";
                processStartInfo.Arguments = "/C \"" + text + "\" " + accountname + " " + databasename;
                process.StartInfo = processStartInfo;
                process.Start();
                Thread.Sleep(1000);
                if (leader1 == accountname)
                {
                    totaltext = leadertext1;
                }
                else if (leader2 == accountname)
                {
                    totaltext = leadertext2;
                }
                else
                {
                    totaltext = leadertext0;
                }
                string text2 = "WIN";
                if (true)
                {
                    text2 = ((whichlobby == "WIN") ? "WIN" : ((whichlobby == "LOSE") ? "LOSE" : ((whichlobby == "ONLY LOSE") ? "ONLY LOSE" : ((whichlobby == "ONLY WIN") ? "ONLY WIN" : ((!(whichlobby == "UNK")) ? "CLIENT" : "UNK")))));
                }
                SetWindowText(process.MainWindowHandle, "@ ACCOUNT: " + text2 + " | LOGIN: " + accountname + totaltext);
            }
            else
            {
                pipe(accountname, "start");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > 0 && bunifuCustomDataGrid1.CurrentCell.RowIndex > -1)
            {
                if (namedPipeExist(accountname))
                {
                    pipe(accountname, "kill");
                }
                else
                {
                    MessageBox.Show("Accounts's server is not running right now", "Error");
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > 0 && bunifuCustomDataGrid1.CurrentCell.RowIndex > -1)
            {
                if (namedPipeExist(accountname))
                {
                    pipe(accountname, "restart");
                }
                else
                {
                    MessageBox.Show("Accounts's server is not running right now", "Error");
                }
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > 0 && bunifuCustomDataGrid1.CurrentCell.RowIndex > -1)
            {
                if (namedPipeExist(accountname))
                {
                    pipe(accountname, "quit");
                }
                else
                {
                    MessageBox.Show("Accounts's server is not running right now", "Error");
                }
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process item in from pr in Process.GetProcesses()
                                         where pr.ProcessName == "csgo"
                                         select pr)
                {
                    item.Kill();
                }
            }
            catch (Exception)
            {
            }
            try
            {
                (from x in Process.GetProcesses()
                 where x.ProcessName.StartsWith("Steam_")
                 select x).ToList().ForEach(delegate (Process x)
                 {
                     x.Kill();
                 });
            }
            catch (Exception)
            {
            }
            try
            {
                foreach (Process item2 in from pr in Process.GetProcesses()
                                          where pr.ProcessName == "SERVER"
                                          select pr)
                {
                    item2.Kill();
                }
            }
            catch (Exception)
            {
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > 0 && bunifuCustomDataGrid1.CurrentCell.RowIndex > -1)
            {
                if (namedPipeExist(accountname))
                {
                    pipe(accountname, "steam");
                }
                else
                {
                    MessageBox.Show("Accounts's server is not running right now", "Error");
                }
            }
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > 0 && bunifuCustomDataGrid1.CurrentCell.RowIndex > -1)
            {
                Process.Start("explorer.exe", steampath + "userdata\\" + userid + "\\730\\local\\cfg\\");
            }
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > 0 && bunifuCustomDataGrid1.CurrentCell.RowIndex > -1)
            {
                Process.Start("explorer.exe", csgopath + "csgo_" + userid + "\\");
            }
        }

        private string getinfo(string acx)
        {
            string result = "";
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + acx + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result = mySqlDataReader["password"].ToString();
                }
                mySqlDataReader.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
        }

        private string getinfo1(string acx)
        {
            string result = "";
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + acx + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result = mySqlDataReader["ss"].ToString();
                }
                mySqlDataReader.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
        }

        private void fetchleader1_mysql()
        {
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + leader1 + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    userid_l1 = mySqlDataReader["userid"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
        }

        private void fetchleader2_mysql()
        {
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + leader2 + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    userid_l2 = mySqlDataReader["userid"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }
        }

        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            fetchleader1_mysql();
            fetchleader2_mysql();
            string a = leader1;
            string a2 = leader2;
            if (comboBox1.Enabled && comboBox4.Enabled)
            {
                if (a != "")
                {
                    string text = csgopath;
                    if (Directory.Exists(text))
                    {
                        if (Directory.Exists(text + "csgo_" + userid_l1))
                        {
                            lineChanger("\tgame\t\"@ " + leader1 + " | LEADER #1 @\"", text + "csgo_" + userid_l1 + "/gameinfo.txt", 3);
                            lineChanger("con_logfile log/1.log", text + "csgo_" + userid_l1 + "/cfg/autoexec.cfg", 14);
                            if (!File.Exists(text + "csgo_" + userid_l1 + "\\cfg\\gamestate_integration_boost.cfg"))
                            {
                                new FileInfo(Directory.GetCurrentDirectory() + "\\data\\gsi\\gamestate_integration_boost.cfg").CopyTo(text + "csgo_" + userid_l1 + "\\cfg\\gamestate_integration_boost.cfg", overwrite: true);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please configure Leader #1", "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select Leader #1", "Error");
                }
                if (a2 != "")
                {
                    string text2 = csgopath;
                    if (Directory.Exists(text2))
                    {
                        if (Directory.Exists(text2 + "csgo_" + userid_l2))
                        {
                            lineChanger("\tgame\t\"@ " + leader2 + " | LEADER #2 @\"", text2 + "csgo_" + userid_l2 + "/gameinfo.txt", 3);
                            lineChanger("con_logfile log/2.log", text2 + "csgo_" + userid_l2 + "/cfg/autoexec.cfg", 14);
                            alerts.Show("Successfully!", alerts.AlertType.success);
                            if (!File.Exists(text2 + "csgo_" + userid_l2 + "\\cfg\\gamestate_integration_boost.cfg"))
                            {
                                new FileInfo(Directory.GetCurrentDirectory() + "\\data\\gsi\\gamestate_integration_boost.cfg").CopyTo(text2 + "csgo_" + userid_l2 + "\\cfg\\gamestate_integration_boost.cfg", overwrite: true);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please configure Leader #2", "Error");
                        }
                    }
                }
                if (a != "" && a2 != "")
                {
                    int result = 0;
                    int.TryParse(userid_l1, out result);
                    int result2 = 0;
                    int.TryParse(userid_l2, out result2);
                    long num = result + 76561197960265728L;
                    string text3 = string.Concat(str2: (result2 + 76561197960265728L).ToString(), str0: num.ToString(), str1: ",");
                    bunifuCustomTextbox28.Text = text3;
                    reconnect_win = text3;
                    int num2 = -1;
                    MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    string text5 = (mySqlCommand.CommandText = "SELECT * FROM disconnects where id='1';");
                    mySqlCommand.Connection = connection;
                    try
                    {
                        mySqlCommand.CommandText = "UPDATE disconnects SET win='" + text3 + "'";
                        mySqlCommand.Connection.Open();
                        num2 = mySqlCommand.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        mySqlCommand.Connection.Close();
                        if (num2 == 1)
                        {
                            fetchleader1();
                            fetchleader2();
                            updatemeplz2();
                            updateleaders1();
                            updateleaders2();
                            fetchleader1();
                            fetchleader2();
                            updatemeplz1();
                        }
                        else
                        {
                            MessageBox.Show("Unknown error!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select Leader #2", "Error");
                }
            }
            else
            {
                MessageBox.Show("You can configure as minimum 2 accounts", "Error");
            }
        }

        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            fetchleader1_mysql();
            fetchleader2_mysql();
            string a = leader1;
            string a2 = leader2;
            if (comboBox1.Enabled && comboBox4.Enabled)
            {
                if (a != "")
                {
                    string text = csgopath;
                    if (Directory.Exists(text))
                    {
                        if (Directory.Exists(text + "csgo_" + userid_l1))
                        {
                            lineChanger("\tgame\t\"@ " + leader1 + " | BOT\"", text + "csgo_" + userid_l1 + "/gameinfo.txt", 3);
                            lineChanger("//con_logfile log/0.log", text + "csgo_" + userid_l1 + "/cfg/autoexec.cfg", 14);
                            if (File.Exists(text + "csgo_" + userid_l1 + "\\cfg\\gamestate_integration_boost.cfg"))
                            {
                                File.Delete(text + "csgo_" + userid_l1 + "\\cfg\\gamestate_integration_boost.cfg");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please configure Leader #1", "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select Leader #1", "Error");
                }
                if (a2 != "")
                {
                    string text2 = csgopath;
                    if (Directory.Exists(text2))
                    {
                        if (Directory.Exists(text2 + "csgo_" + userid_l2))
                        {
                            lineChanger("\tgame\t\"@ " + leader2 + " | BOT @\"", text2 + "csgo_" + userid_l2 + "/gameinfo.txt", 3);
                            lineChanger("//con_logfile log/0.log", text2 + "csgo_" + userid_l2 + "/cfg/autoexec.cfg", 14);
                            alerts.Show("Successfully!", alerts.AlertType.success);
                            if (File.Exists(text2 + "csgo_" + userid_l2 + "\\cfg\\gamestate_integration_boost.cfg"))
                            {
                                File.Delete(text2 + "csgo_" + userid_l2 + "\\cfg\\gamestate_integration_boost.cfg");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please configure Leader #2", "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select Leader #2", "Error");
                }
                fetchleader1();
                fetchleader2();
                updatemeplz2();
                updateleaders1();
                updateleaders2();
                fetchleader1();
                fetchleader2();
                updatemeplz1();
            }
            else
            {
                MessageBox.Show("You can configure as minimum 2 accounts", "Error");
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            valstart = !valstart;
            if (!valstart)
            {
                bunifuFlatButton5.Text = "      AUTO-START: DISABLED";
            }
            else
            {
                bunifuFlatButton5.Text = "      AUTO-START: ENABLED";
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            valaccept = !valaccept;
            if (!valaccept)
            {
                bunifuFlatButton4.Text = "      AUTO-ACCEPT: DISABLED";
            }
            else
            {
                bunifuFlatButton4.Text = "      AUTO-ACCEPT: ENABLED";
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private void SetcurPos(int x, int y)
        {
            Thread.Sleep(50);
            SetCursorPos(x, y);
            Thread.Sleep(50);
        }

        private static void LeftClick()
        {
            mouse_event(2u, 0u, 0u, 0u, 0u);
            mouse_event(4u, 0u, 0u, 0u, 0u);
        }

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        public static void sendKey(IntPtr hwnd, int keyCode, bool extended)
        {
            uint num = MapVirtualKey((uint)keyCode, 0u);
            uint num2 = 1u | (num << 16);
            if (extended)
            {
                num2 |= 0x1000000u;
            }
            PostMessage(hwnd, 256u, (IntPtr)keyCode, (IntPtr)num2);
            PostMessage(hwnd, 257u, (IntPtr)keyCode, (IntPtr)num2);
        }

        private void presshis()
        {
            if (valswap1)
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.F7);
            }
        }

        private void worker_invite1(object sender, DoWorkEventArgs e)
        {
            SENDINFO("http://127.0.0.1/panel.php", "message=3");
            all_accs3.Clear();
            staticclick = "0";
            to_regex3.Clear();
            all_accs4.Clear();
            to_regex4.Clear();
            all_accs7.Clear();
            to_regex7.Clear();
            all_accs8.Clear();
            all_accs9.Clear();
            to_regex8.Clear();
            bool flag = true;
            try
            {
                if (flag)
                {
                    int num = 0;
                    foreach (Process item in from pr in Process.GetProcesses()
                                             where pr.ProcessName == "cmd"
                                             select pr)
                    {
                        if (item.MainWindowTitle.Contains("@ ACCOUNT: "))
                        {
                            to_regex3.Add(item.MainWindowTitle);
                            num++;
                        }
                    }
                    if (num > 0)
                    {
                        foreach (string item2 in to_regex3)
                        {
                            string response = Regex.Match(item2, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[3].Value;
                            string value = Regex.Match(item2, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[4].Value;
                            if (!(response != ""))
                            {
                                continue;
                            }
                            response = Regex.Match(response, ": ([^\\n]+)").Groups[1].Value;
                            if (!(response != ""))
                            {
                                continue;
                            }
                            response = response.Substring(0, response.Length - 1);
                            if (!(value == "| BOT"))
                            {
                                continue;
                            }
                            string text = requestx1y(response);
                            string text2 = text;
                            text = text.Split('*')[0];
                            if (!(text != "") || !(text != "0"))
                            {
                                continue;
                            }
                            string accept_mem1 = text2.Split('*')[1];
                            if (all_accs3.Any((string str) => str.Contains(response)))
                            {
                                continue;
                            }
                            all_accs3.Add(response + " ");
                            if (!all_accs9.Any((string str) => str.Contains(response)))
                            {
                                all_accs9.Add(response);
                            }
                            if (!valswap)
                            {
                                string text3 = winparty.FirstOrDefault((string stringToCheck) => stringToCheck.Contains(response));
                                if (text3 != null && !all_accs8.Any((string str) => str.Contains(accept_mem1 + " ")))
                                {
                                    all_accs7.Add(accept_mem1 + " ");
                                }
                                string text4 = loseparty.FirstOrDefault((string stringToCheck) => stringToCheck.Contains(response));
                                if (text4 != null && !all_accs7.Any((string str) => str.Contains(accept_mem1 + " ")))
                                {
                                    all_accs8.Add(accept_mem1 + " ");
                                }
                                if (!(text4 == text3))
                                {
                                    continue;
                                }
                                if (text4 == null && text3 == null)
                                {
                                    if (!all_accs8.Any((string str) => str.Contains(accept_mem1 + " ")))
                                    {
                                        all_accs7.Add(accept_mem1 + " ");
                                    }
                                    continue;
                                }
                                all_accs7.Remove(accept_mem1 + " ");
                                if (!all_accs7.Any((string str) => str.Contains(accept_mem1 + " ")))
                                {
                                    all_accs8.Add(accept_mem1 + " ");
                                }
                                continue;
                            }
                            string text5 = loseparty.FirstOrDefault((string stringToCheck) => stringToCheck.Contains(response));
                            if (text5 != null && !all_accs7.Any((string str) => str.Contains(accept_mem1 + " ")))
                            {
                                all_accs8.Add(accept_mem1 + " ");
                            }
                            string text6 = winparty.FirstOrDefault((string stringToCheck) => stringToCheck.Contains(response));
                            if (text6 != null && !all_accs8.Any((string str) => str.Contains(accept_mem1 + " ")))
                            {
                                all_accs7.Add(accept_mem1 + " ");
                            }
                            if (!(text5 == text6))
                            {
                                continue;
                            }
                            if (text5 == null && text6 == null)
                            {
                                if (!all_accs7.Any((string str) => str.Contains(accept_mem1 + " ")))
                                {
                                    all_accs8.Add(accept_mem1 + " ");
                                }
                                continue;
                            }
                            all_accs8.Remove(accept_mem1 + " ");
                            if (!all_accs8.Any((string str) => str.Contains(accept_mem1 + " ")))
                            {
                                all_accs7.Add(accept_mem1 + " ");
                            }
                        }
                    }
                }
                if (flag)
                {
                    int num2 = 0;
                    foreach (Process item3 in from pr in Process.GetProcesses()
                                              where pr.ProcessName == "cmd"
                                              select pr)
                    {
                        if (item3.MainWindowTitle.Contains("@ ACCOUNT: "))
                        {
                            to_regex4.Add(item3.MainWindowTitle);
                            num2++;
                        }
                    }
                    if (num2 > 0)
                    {
                        foreach (string item4 in to_regex4)
                        {
                            string value2 = Regex.Match(item4, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[3].Value;
                            string value3 = Regex.Match(item4, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[4].Value;
                            if (!(value2 != ""))
                            {
                                continue;
                            }
                            value2 = Regex.Match(value2, ": ([^\\n]+)").Groups[1].Value;
                            if (!(value2 != ""))
                            {
                                continue;
                            }
                            value2 = value2.Substring(0, value2.Length - 1);
                            if (!(value3 != "| BOT"))
                            {
                                continue;
                            }
                            string text7 = requestx1y(value2);
                            string text8 = text7.Split('*')[0];
                            text8 = "1";
                            if (!(text8 != "") || !(text8 != "0"))
                            {
                                continue;
                            }
                            string text9 = text7.Split('*')[0];
                            string b = text7.Split('*')[1];
                            if (leader1 == b)
                            {
                                foreach (Process item5 in from pr in Process.GetProcesses()
                                                          where pr.ProcessName == "csgo"
                                                          select pr)
                                {
                                    if (!item5.MainWindowTitle.Contains(leader1))
                                    {
                                        continue;
                                    }
                                    IntPtr mainWindowHandle = item5.MainWindowHandle;
                                    int value4 = LoadKeyboardLayout("00000409", 1u);
                                    PostMessage(mainWindowHandle, 80u, (IntPtr)0, (IntPtr)value4);
                                    PostMessage(mainWindowHandle, 81u, (IntPtr)0, (IntPtr)value4);
                                    Thread.Sleep(100);
                                    foreach (string item6 in all_accs7)
                                    {
                                        string obj = requestx1yxxx(item6).Split('|')[0];
                                        Thread.Sleep(100);
                                        string text10 = obj;
                                        _ = text9.Split('|')[0];
                                        int pointPtr = MAKELPARAM(386, 186);
                                        joinafter(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        Thread.Sleep(500);
                                        pointPtr = MAKELPARAM(388, 71);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        pointPtr = MAKELPARAM(307, 90);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        pointPtr = MAKELPARAM(158, 146);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(450);
                                        pointPtr = MAKELPARAM(158, 146);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        pointPtr = MAKELPARAM(182, 147);
                                        Thread.Sleep(1000);
                                        joinafter(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        for (int i = 0; i < text10.Length; i++)
                                        {
                                            short value5 = VkKeyScan(text10[i]);
                                            PostMessage(mainWindowHandle, 256u, (IntPtr)value5, (IntPtr)0);
                                            Thread.Sleep(15);
                                        }
                                        Thread.Sleep(500);
                                        pointPtr = MAKELPARAM(214, 147);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(750);
                                        pointPtr = MAKELPARAM(143, 154);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        pointPtr = MAKELPARAM(282, 145);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        pointPtr = MAKELPARAM(253, 182);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                    }
                                }
                            }
                            if (!(leader2 == b))
                            {
                                continue;
                            }
                            foreach (Process item7 in from pr in Process.GetProcesses()
                                                      where pr.ProcessName == "csgo"
                                                      select pr)
                            {
                                if (!item7.MainWindowTitle.Contains(leader2))
                                {
                                    continue;
                                }
                                IntPtr mainWindowHandle2 = item7.MainWindowHandle;
                                int value6 = LoadKeyboardLayout("00000409", 1u);
                                PostMessage(mainWindowHandle2, 80u, (IntPtr)0, (IntPtr)value6);
                                PostMessage(mainWindowHandle2, 81u, (IntPtr)0, (IntPtr)value6);
                                Thread.Sleep(100);
                                foreach (string item8 in all_accs8)
                                {
                                    string obj2 = requestx1yxxx(item8).Split('|')[0];
                                    Thread.Sleep(100);
                                    string text11 = obj2;
                                    _ = text9.Split('|')[0];
                                    int pointPtr2 = MAKELPARAM(386, 186);
                                    joinafter(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    Thread.Sleep(500);
                                    pointPtr2 = MAKELPARAM(388, 71);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    pointPtr2 = MAKELPARAM(307, 90);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    pointPtr2 = MAKELPARAM(158, 146);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(450);
                                    pointPtr2 = MAKELPARAM(158, 146);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    pointPtr2 = MAKELPARAM(182, 147);
                                    joinafter(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    for (int j = 0; j < text11.Length; j++)
                                    {
                                        short value7 = VkKeyScan(text11[j]);
                                        PostMessage(mainWindowHandle2, 256u, (IntPtr)value7, (IntPtr)0);
                                        Thread.Sleep(15);
                                    }
                                    Thread.Sleep(500);
                                    pointPtr2 = MAKELPARAM(214, 147);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(750);
                                    pointPtr2 = MAKELPARAM(143, 154);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    pointPtr2 = MAKELPARAM(282, 145);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    pointPtr2 = MAKELPARAM(253, 182);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                }
                            }
                        }
                    }
                }
                if (!flag)
                {
                    return;
                }
                Thread.Sleep(2000);
                foreach (string item9 in all_accs9)
                {
                    string accept_fix_mem123 = requestx1yxxx12345(item9);
                    string a = (staticclick = requestx1yxxx(item9));
                    if (!(a != "") || !(a != "0"))
                    {
                        continue;
                    }
                    foreach (Process processx in from pr in Process.GetProcesses()
                                                 where pr.ProcessName == "csgo"
                                                 select pr)
                    {
                        if (all_accs9.Any((string x) => processx.MainWindowTitle.Contains(accept_fix_mem123)))
                        {
                            Thread.Sleep(350);
                            IntPtr mainWindowHandle3 = processx.MainWindowHandle;
                            Thread.Sleep(100);
                            int pointPtr3 = MAKELPARAM(386, 186);
                            joinafter(mainWindowHandle3, pointPtr3, processx.MainWindowTitle);
                            Thread.Sleep(900);
                            pointPtr3 = MAKELPARAM(385, 75);
                            joinafter1(mainWindowHandle3, pointPtr3, processx.MainWindowTitle);
                            joinafter1(mainWindowHandle3, pointPtr3, processx.MainWindowTitle);
                            Thread.Sleep(200);
                        }
                    }
                }
            }
            catch (WebException)
            {
            }
        }

        private void worker_invite(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(60000);
            SENDINFO("http://127.0.0.1/panel.php", "message=3");
            all_accs3.Clear();
            staticclick = "0";
            to_regex3.Clear();
            all_accs4.Clear();
            to_regex4.Clear();
            all_accs7.Clear();
            to_regex7.Clear();
            all_accs8.Clear();
            all_accs9.Clear();
            to_regex8.Clear();
            bool flag = true;
            try
            {
                if (flag)
                {
                    int num = 0;
                    foreach (Process item in from pr in Process.GetProcesses()
                                             where pr.ProcessName == "cmd"
                                             select pr)
                    {
                        if (item.MainWindowTitle.Contains("@ ACCOUNT: "))
                        {
                            to_regex3.Add(item.MainWindowTitle);
                            num++;
                        }
                    }
                    if (num > 0)
                    {
                        foreach (string item2 in to_regex3)
                        {
                            string response = Regex.Match(item2, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[3].Value;
                            string value = Regex.Match(item2, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[4].Value;
                            if (!(response != ""))
                            {
                                continue;
                            }
                            response = Regex.Match(response, ": ([^\\n]+)").Groups[1].Value;
                            if (!(response != ""))
                            {
                                continue;
                            }
                            response = response.Substring(0, response.Length - 1);
                            if (!(value == "| BOT"))
                            {
                                continue;
                            }
                            string text = requestx1y(response);
                            string text2 = text;
                            text = text.Split('*')[0];
                            if (!(text != "") || !(text != "0"))
                            {
                                continue;
                            }
                            string accept_mem1 = text2.Split('*')[1];
                            if (all_accs3.Any((string str) => str.Contains(response)))
                            {
                                continue;
                            }
                            all_accs3.Add(response + " ");
                            if (!all_accs9.Any((string str) => str.Contains(response)))
                            {
                                all_accs9.Add(response);
                            }
                            if (!valswap)
                            {
                                string text3 = winparty.FirstOrDefault((string stringToCheck) => stringToCheck.Contains(response));
                                if (text3 != null && !all_accs8.Any((string str) => str.Contains(accept_mem1 + " ")))
                                {
                                    all_accs7.Add(accept_mem1 + " ");
                                }
                                string text4 = loseparty.FirstOrDefault((string stringToCheck) => stringToCheck.Contains(response));
                                if (text4 != null && !all_accs7.Any((string str) => str.Contains(accept_mem1 + " ")))
                                {
                                    all_accs8.Add(accept_mem1 + " ");
                                }
                                if (!(text4 == text3))
                                {
                                    continue;
                                }
                                if (text4 == null && text3 == null)
                                {
                                    if (!all_accs8.Any((string str) => str.Contains(accept_mem1 + " ")))
                                    {
                                        all_accs7.Add(accept_mem1 + " ");
                                    }
                                    continue;
                                }
                                all_accs7.Remove(accept_mem1 + " ");
                                if (!all_accs7.Any((string str) => str.Contains(accept_mem1 + " ")))
                                {
                                    all_accs8.Add(accept_mem1 + " ");
                                }
                                continue;
                            }
                            string text5 = loseparty.FirstOrDefault((string stringToCheck) => stringToCheck.Contains(response));
                            if (text5 != null && !all_accs7.Any((string str) => str.Contains(accept_mem1 + " ")))
                            {
                                all_accs8.Add(accept_mem1 + " ");
                            }
                            string text6 = winparty.FirstOrDefault((string stringToCheck) => stringToCheck.Contains(response));
                            if (text6 != null && !all_accs8.Any((string str) => str.Contains(accept_mem1 + " ")))
                            {
                                all_accs7.Add(accept_mem1 + " ");
                            }
                            if (!(text5 == text6))
                            {
                                continue;
                            }
                            if (text5 == null && text6 == null)
                            {
                                if (!all_accs7.Any((string str) => str.Contains(accept_mem1 + " ")))
                                {
                                    all_accs8.Add(accept_mem1 + " ");
                                }
                                continue;
                            }
                            all_accs8.Remove(accept_mem1 + " ");
                            if (!all_accs8.Any((string str) => str.Contains(accept_mem1 + " ")))
                            {
                                all_accs7.Add(accept_mem1 + " ");
                            }
                        }
                    }
                }
                if (flag)
                {
                    int num2 = 0;
                    foreach (Process item3 in from pr in Process.GetProcesses()
                                              where pr.ProcessName == "cmd"
                                              select pr)
                    {
                        if (item3.MainWindowTitle.Contains("@ ACCOUNT: "))
                        {
                            to_regex4.Add(item3.MainWindowTitle);
                            num2++;
                        }
                    }
                    if (num2 > 0)
                    {
                        foreach (string item4 in to_regex4)
                        {
                            string value2 = Regex.Match(item4, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[3].Value;
                            string value3 = Regex.Match(item4, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[4].Value;
                            if (!(value2 != ""))
                            {
                                continue;
                            }
                            value2 = Regex.Match(value2, ": ([^\\n]+)").Groups[1].Value;
                            if (!(value2 != ""))
                            {
                                continue;
                            }
                            value2 = value2.Substring(0, value2.Length - 1);
                            if (!(value3 != "| BOT"))
                            {
                                continue;
                            }
                            string text7 = requestx1y(value2);
                            string text8 = text7.Split('*')[0];
                            text8 = "1";
                            if (!(text8 != "") || !(text8 != "0"))
                            {
                                continue;
                            }
                            string text9 = text7.Split('*')[0];
                            string b = text7.Split('*')[1];
                            if (leader1 == b)
                            {
                                foreach (Process item5 in from pr in Process.GetProcesses()
                                                          where pr.ProcessName == "csgo"
                                                          select pr)
                                {
                                    if (!item5.MainWindowTitle.Contains(leader1))
                                    {
                                        continue;
                                    }
                                    IntPtr mainWindowHandle = item5.MainWindowHandle;
                                    int value4 = LoadKeyboardLayout("00000409", 1u);
                                    PostMessage(mainWindowHandle, 80u, (IntPtr)0, (IntPtr)value4);
                                    PostMessage(mainWindowHandle, 81u, (IntPtr)0, (IntPtr)value4);
                                    Thread.Sleep(100);
                                    foreach (string item6 in all_accs7)
                                    {
                                        string obj = requestx1yxxx(item6).Split('|')[0];
                                        Thread.Sleep(100);
                                        string text10 = obj;
                                        _ = text9.Split('|')[0];
                                        int pointPtr = MAKELPARAM(386, 186);
                                        joinafter(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        Thread.Sleep(500);
                                        pointPtr = MAKELPARAM(388, 71);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        pointPtr = MAKELPARAM(307, 90);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        pointPtr = MAKELPARAM(158, 146);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(450);
                                        pointPtr = MAKELPARAM(158, 146);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        pointPtr = MAKELPARAM(182, 147);
                                        Thread.Sleep(1000);
                                        joinafter(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        for (int i = 0; i < text10.Length; i++)
                                        {
                                            short value5 = VkKeyScan(text10[i]);
                                            PostMessage(mainWindowHandle, 256u, (IntPtr)value5, (IntPtr)0);
                                            Thread.Sleep(15);
                                        }
                                        Thread.Sleep(500);
                                        pointPtr = MAKELPARAM(214, 147);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(750);
                                        pointPtr = MAKELPARAM(143, 154);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        pointPtr = MAKELPARAM(282, 145);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                        pointPtr = MAKELPARAM(253, 182);
                                        joinafter1(mainWindowHandle, pointPtr, item5.MainWindowTitle);
                                        Thread.Sleep(350);
                                    }
                                }
                            }
                            if (!(leader2 == b))
                            {
                                continue;
                            }
                            foreach (Process item7 in from pr in Process.GetProcesses()
                                                      where pr.ProcessName == "csgo"
                                                      select pr)
                            {
                                if (!item7.MainWindowTitle.Contains(leader2))
                                {
                                    continue;
                                }
                                IntPtr mainWindowHandle2 = item7.MainWindowHandle;
                                int value6 = LoadKeyboardLayout("00000409", 1u);
                                PostMessage(mainWindowHandle2, 80u, (IntPtr)0, (IntPtr)value6);
                                PostMessage(mainWindowHandle2, 81u, (IntPtr)0, (IntPtr)value6);
                                Thread.Sleep(100);
                                foreach (string item8 in all_accs8)
                                {
                                    string obj2 = requestx1yxxx(item8).Split('|')[0];
                                    Thread.Sleep(100);
                                    string text11 = obj2;
                                    _ = text9.Split('|')[0];
                                    int pointPtr2 = MAKELPARAM(386, 186);
                                    joinafter(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    Thread.Sleep(500);
                                    pointPtr2 = MAKELPARAM(388, 71);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    pointPtr2 = MAKELPARAM(307, 90);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    pointPtr2 = MAKELPARAM(158, 146);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(450);
                                    pointPtr2 = MAKELPARAM(158, 146);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    pointPtr2 = MAKELPARAM(182, 147);
                                    joinafter(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    for (int j = 0; j < text11.Length; j++)
                                    {
                                        short value7 = VkKeyScan(text11[j]);
                                        PostMessage(mainWindowHandle2, 256u, (IntPtr)value7, (IntPtr)0);
                                        Thread.Sleep(15);
                                    }
                                    Thread.Sleep(500);
                                    pointPtr2 = MAKELPARAM(214, 147);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(750);
                                    pointPtr2 = MAKELPARAM(143, 154);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    pointPtr2 = MAKELPARAM(282, 145);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                    pointPtr2 = MAKELPARAM(253, 182);
                                    joinafter1(mainWindowHandle2, pointPtr2, item7.MainWindowTitle);
                                    Thread.Sleep(350);
                                }
                            }
                        }
                    }
                }
                if (flag)
                {
                    Thread.Sleep(2000);
                    foreach (string item9 in all_accs9)
                    {
                        string accept_fix_mem123 = requestx1yxxx12345(item9);
                        string a = (staticclick = requestx1yxxx(item9));
                        if (!(a != "") || !(a != "0"))
                        {
                            continue;
                        }
                        foreach (Process processx in from pr in Process.GetProcesses()
                                                     where pr.ProcessName == "csgo"
                                                     select pr)
                        {
                            if (all_accs9.Any((string x) => processx.MainWindowTitle.Contains(accept_fix_mem123)))
                            {
                                Thread.Sleep(350);
                                IntPtr mainWindowHandle3 = processx.MainWindowHandle;
                                Thread.Sleep(100);
                                int pointPtr3 = MAKELPARAM(386, 186);
                                joinafter(mainWindowHandle3, pointPtr3, processx.MainWindowTitle);
                                Thread.Sleep(900);
                                pointPtr3 = MAKELPARAM(385, 75);
                                joinafter1(mainWindowHandle3, pointPtr3, processx.MainWindowTitle);
                                joinafter1(mainWindowHandle3, pointPtr3, processx.MainWindowTitle);
                                Thread.Sleep(200);
                            }
                        }
                    }
                }
            }
            catch (WebException)
            {
                return;
            }
            if (backgroundWorker1337.IsBusy)
            {
                backgroundWorker1337.CancelAsync();
            }
        }

        [DllImport("user32.dll")]
        private static extern int LoadKeyboardLayout(string pwszKLID, uint Flags);

        private void worker_login(object sender, DoWorkEventArgs e)
        {
            testkill();
            bunifuThinButton211.Invoke((MethodInvoker)delegate
            {
                bunifuThinButton211_Click(null, null);
            });
        }

        private void worker_disconnects(object sender, DoWorkEventArgs e)
        {
            if (disconnects_enabled && status == 1)
            {
                if (valstart)
                {
                    SENDINFO("http://127.0.0.1/panel.php", "message=8");
                }
                valstart = false;
                bunifuFlatButton5.Text = "      AUTO-START: DISABLED";
                try
                {
                    int result = 0;
                    int.TryParse(ms2, out result);
                    clicked = false;
                    rounds = 1;
                    Thread.Sleep(result);
                    foreach (Process processx in from pr in Process.GetProcesses()
                                                 where pr.ProcessName == "csgo"
                                                 select pr)
                    {
                        if (valswap)
                        {
                            if (winparty.Any((string x) => processx.MainWindowTitle.Contains(x)))
                            {
                                sendKey(processx.MainWindowHandle, 114, extended: false);
                                sendKey(processx.MainWindowHandle, 114, extended: false);
                                sendKey(processx.MainWindowHandle, 114, extended: false);
                                Thread.Sleep(300);
                            }
                        }
                        else if (loseparty.Any((string x) => processx.MainWindowTitle.Contains(x)))
                        {
                            sendKey(processx.MainWindowHandle, 114, extended: false);
                            sendKey(processx.MainWindowHandle, 114, extended: false);
                            sendKey(processx.MainWindowHandle, 114, extended: false);
                            Thread.Sleep(300);
                        }
                    }
                    presshis();
                }
                catch (Exception)
                {
                }
            }
            Thread.Sleep(1000);
        }

        private void worker_timer(object sender, DoWorkEventArgs e)
        {
            if (maxTime_s > 0)
            {
                bunifuFlatButton6.Invoke((MethodInvoker)delegate
                {
                    maxTime_s--;
                    int num = maxTime_s / 60;
                    int num2 = maxTime_s - num * 60;
                    if (num2 == 45 && num == 0)
                    {
                        SENDINFO("http://127.0.0.1/panel.php", "message=11");
                    }
                    if (num2 < 10)
                    {
                        bunifuFlatButton6.Text = "      TIME: " + num + ":0" + num2;
                    }
                    else if (num2 != 0)
                    {
                        bunifuFlatButton6.Text = "      TIME: " + num + ":" + num2;
                    }
                    else
                    {
                        bunifuFlatButton6.Text = "      TIME: " + num + ":00";
                    }
                });
            }
            else
            {
                bunifuFlatButton6.Invoke((MethodInvoker)delegate
                {
                    bunifuFlatButton6.Text = "      TIME: 0:00";
                });
            }
            Thread.Sleep(1000);
        }

        private void worker_accept(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            int num = 0;
            GetCursorPos(out var _);
            string a = "0";
            string text = "1";
            all_accs.Clear();
            to_regex.Clear();
            all_accs1.Clear();
            to_regex1.Clear();
            all_accs2.Clear();
            to_regex2.Clear();
            FileStream fileStream = new FileStream(csgopath + "csgo/log/1.log", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader streamReader = new StreamReader(fileStream);
            string input = streamReader.ReadToEnd();
            string value = Regex.Match(input, "Received Steam datagram ticket for server steamid:([0-9]+) vport ([0-9]+). match_id=([0-9]+)").Groups[3].Value;
            string value2 = Regex.Match(input, "([^\\n]+) : ([^\\n]+)").Groups[1].Value;
            string value3 = Regex.Match(input, "([^\\n]+) : ([^\\n]+)").Groups[2].Value;
            lobby_leader1 = Regex.Match(input, "LobbySetData([:]) (['])members:numMachines([']) ([=]) (['])([0-5+])(['])").Groups[6].Value;
            FileStream fileStream2 = new FileStream(csgopath + "csgo/log/2.log", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader streamReader2 = new StreamReader(fileStream2);
            string input2 = streamReader2.ReadToEnd();
            string value4 = Regex.Match(input2, "Received Steam datagram ticket for server steamid:([0-9]+) vport ([0-9]+). match_id=([0-9]+)").Groups[3].Value;
            lobby_leader2 = Regex.Match(input2, "LobbySetData([:]) (['])members:numMachines([']) ([=]) (['])([0-5+])(['])").Groups[6].Value;
            if (autoinvite)
            {
                if (lobby_leader1 != "")
                {
                    int.TryParse(lobby_leader1, out mamax1);
                }
                if (lobby_leader2 != "")
                {
                    int.TryParse(lobby_leader2, out mamax2);
                }
                if (mamax1 == 5)
                {
                    full_lobby1 = true;
                }
                else if (mamax1 < 5 && mamax2 > 0)
                {
                    full_lobby1 = false;
                }
                if (mamax2 == 5)
                {
                    full_lobby2 = true;
                }
                else if (mamax2 < 5 && mamax2 > 0)
                {
                    full_lobby2 = false;
                }
            }
            if (value != "")
            {
                a = value;
            }
            if (value4 != "")
            {
                text = value4;
            }
            fileStream2.Close();
            FileStream fileStream3 = new FileStream(csgopath + "csgo/log/2.log", FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream3);
            streamWriter.Write("");
            streamWriter.Close();
            fileStream3.Close();
            streamReader2.Close();
            fileStream.Close();
            FileStream fileStream4 = new FileStream(csgopath + "csgo/log/1.log", FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter streamWriter2 = new StreamWriter(fileStream4);
            streamWriter2.Write("");
            streamWriter2.Close();
            fileStream4.Close();
            streamReader.Close();
            if (valaccept)
            {
                if (a == text)
                {
                    Thread.Sleep(5000);
                    foreach (Process item in from pr in Process.GetProcesses()
                                             where pr.ProcessName == "cmd"
                                             select pr)
                    {
                        if (item.MainWindowTitle.Contains("@ ACCOUNT: "))
                        {
                            to_regex.Add(item.MainWindowTitle);
                            num++;
                        }
                    }
                    if (num > 0)
                    {
                        foreach (string item2 in to_regex)
                        {
                            string value5 = Regex.Match(item2, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[3].Value;
                            if (value5 != "")
                            {
                                value5 = Regex.Match(value5, ": ([^\\n]+)").Groups[1].Value;
                                if (value5 != "")
                                {
                                    value5 = value5.Substring(0, value5.Length - 1);
                                    all_accs.Add(value5);
                                }
                            }
                        }
                        foreach (Process item3 in from pr in Process.GetProcesses()
                                                  where pr.ProcessName == "csgo"
                                                  select pr)
                        {
                            IntPtr mainWindowHandle = item3.MainWindowHandle;
                            int pointPtr = MAKELPARAM(201, 166);
                            joinafter1(mainWindowHandle, pointPtr, item3.MainWindowTitle);
                        }
                    }
                    if (howmuch != -1)
                    {
                        howmuch1++;
                        if (howmuch1 < howmuch)
                        {
                            bunifuFlatButton11.Invoke((MethodInvoker)delegate
                            {
                                bunifuFlatButton11.Text = "      GAMES COUNT: " + howmuch1 + "/" + howmuch;
                            });
                            SENDINFO("http://127.0.0.1/panel.php", "message=4&games=" + howmuch1 + "/" + howmuch);
                        }
                        else
                        {
                            SENDINFO("http://127.0.0.1/panel.php", "message=4&games=" + howmuch1 + "/" + howmuch);
                            howmuch = -1;
                            howmuch1 = 0;
                            autoinvite = false;
                            bunifuFlatButton11.Invoke((MethodInvoker)delegate
                            {
                                bunifuFlatButton11.Text = "      GAMES COUNT";
                            });
                            bunifuFlatButton13.Invoke((MethodInvoker)delegate
                            {
                                bunifuFlatButton13.Text = "      AUTO INVITE: OFF";
                            });
                        }
                    }
                    else
                    {
                        howmuch = -1;
                        howmuch1 = 0;
                        bunifuFlatButton11.Text = "      GAMES COUNT";
                        SENDINFO("http://127.0.0.1/panel.php", "message=4");
                    }
                    presshis();
                }
                else
                {
                    if (a != "0")
                    {
                        SENDINFO("http://127.0.0.1/panel.php", "message=9");
                    }
                    if (text != "1")
                    {
                        SENDINFO("http://127.0.0.1/panel.php", "message=9");
                    }
                }
            }
            if (value2 != "")
            {
                SENDINFO("http://127.0.0.1/panel.php", "message=6661&player=" + value2 + "&chat=" + value3);
            }
            if (!autoinvite)
            {
                return;
            }
            if (full_lobby1 && full_lobby2)
            {
                if (!valstart)
                {
                    valstart = !valstart;
                    bunifuFlatButton5.Text = "      AUTO-START: ENABLED";
                    if (!valaccept)
                    {
                        valaccept = !valaccept;
                        bunifuFlatButton4.Text = "      AUTO-ACCEPT: ENABLED";
                    }
                    full_lobby1 = false;
                    full_lobby2 = false;
                    mamax1 = 0;
                    mamax2 = 0;
                    lobby_leader1 = "";
                    lobby_leader2 = "";
                }
            }
            else if (valstart && ((mamax1 < 5 && mamax1 > 0) || (mamax2 < 5 && mamax2 > 0)))
            {
                valstart = !valstart;
                bunifuFlatButton5.Text = "      AUTO-START: DISABLED";
                if (valaccept)
                {
                    valaccept = !valaccept;
                    bunifuFlatButton4.Text = "      AUTO-ACCEPT: DISABLED";
                }
                if (mamax1 < 5 && mamax1 > 0)
                {
                    full_lobby1 = false;
                    mamax1 = 0;
                    lobby_leader1 = "";
                }
                if (mamax2 < 5 && mamax2 > 0)
                {
                    full_lobby2 = false;
                    mamax2 = 0;
                    lobby_leader2 = "";
                }
            }
        }

        private void coordsxy(string first, string second)
        {
            int result = 0;
            int result2 = 0;
            int.TryParse(first, out result);
            int.TryParse(second, out result2);
            SetcurPos(result, result2);
            Thread.Sleep(10);
            SetcurPos(result, result2);
            Thread.Sleep(10);
            LeftClick();
            Thread.Sleep(10);
            LeftClick();
            Thread.Sleep(10);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point point);

        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

        public Bitmap GetScreenshot(IntPtr ihandle)
        {
            User32.Rect rect = default(User32.Rect);
            User32.GetWindowRect(ihandle, ref rect);
            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                PrintWindow(ihandle, graphics.GetHdc(), 0u);
                graphics.Dispose();
            }
            return bitmap;
        }

        private void worker_start11(object sender, DoWorkEventArgs e)
        {
        }

        private void worker_start1(object sender, DoWorkEventArgs e)
        {
            bool flag = false;
            if (!timertest || !timertest)
            {
                try
                {
                    foreach (Process item in from pr in Process.GetProcesses()
                                             where pr.ProcessName == "csgo"
                                             select pr)
                    {
                        Bitmap screenshot = GetScreenshot(item.MainWindowHandle);
                        if (screenshot == null)
                        {
                            continue;
                        }
                        if (disconnects_enabled && scorect_s1 != 16 && scoret_s1 != 16)
                        {
                            if ((scorect_s1 == 15 && scoret_s1 == 0) || (scoret_s1 == 15 && scorect_s1 == 0))
                            {
                                Color pixel = screenshot.GetPixel(disconnectx_1, disconnecty_1);
                                screenshot.GetPixel(disconnectx_2, disconnecty_2);
                                if (pixel == Color.FromArgb(Convert.ToInt32(-11751600)) || pixel == Color.FromArgb(Convert.ToInt32(-10826914)))
                                {
                                    int pointPtr = MAKELPARAM(disconnectx_2, disconnecty_2);
                                    joinafter1(item.MainWindowHandle, pointPtr, item.MainWindowTitle);
                                    flag = true;
                                }
                                if (flag)
                                {
                                    clicked = true;
                                    pizdec = false;
                                    presshis();
                                }
                                else
                                {
                                    pizdec = true;
                                }
                            }
                            else if (comboBox7.SelectedIndex == 2)
                            {
                                bool flag2 = false;
                                if (mapnameid == 1)
                                {
                                    if (xhase == RoundPhase.FreezeTime && xhase != RoundPhase.Over && (scorect_s1 == 2 || scorect_s1 == 4 || scorect_s1 == 6 || scorect_s1 == 8 || scorect_s1 == 10 || scorect_s1 == 12 || scorect_s1 == 14 || scoret_s1 == 1 || scoret_s1 == 3 || scoret_s1 == 5 || scoret_s1 == 7 || scoret_s1 == 9 || scoret_s1 == 11 || scoret_s1 == 13 || scoret_s1 == 15))
                                    {
                                        flag2 = true;
                                    }
                                }
                                else if (mapnameid == 2 && xhase == RoundPhase.FreezeTime && xhase != RoundPhase.Over && (scorect_s1 == 1 || scorect_s1 == 3 || scorect_s1 == 5 || scorect_s1 == 7 || scorect_s1 == 9 || scorect_s1 == 11 || scorect_s1 == 13 || scoret_s1 == 2 || scoret_s1 == 4 || scoret_s1 == 6 || scoret_s1 == 8 || scoret_s1 == 10 || scoret_s1 == 12 || scoret_s1 == 14))
                                {
                                    flag2 = true;
                                }
                                if (scoret_s1 == 15 || scorect_s1 == 15)
                                {
                                    flag2 = true;
                                }
                                if (flag2)
                                {
                                    Color pixel2 = screenshot.GetPixel(disconnectx_1, disconnecty_1);
                                    screenshot.GetPixel(disconnectx_2, disconnecty_2);
                                    if (pixel2 == Color.FromArgb(Convert.ToInt32(-11751600)) || pixel2 == Color.FromArgb(Convert.ToInt32(-10826914)))
                                    {
                                        int pointPtr2 = MAKELPARAM(disconnectx_2, disconnecty_2);
                                        joinafter123(item.MainWindowHandle, pointPtr2, item.MainWindowTitle);
                                        flag = true;
                                    }
                                    if (flag)
                                    {
                                        clicked = true;
                                        pizdec = false;
                                        presshis();
                                    }
                                }
                            }
                            else if (comboBox7.SelectedIndex == 5)
                            {
                                if (xhase == RoundPhase.FreezeTime && mapnameid != 0 && xhase != RoundPhase.Over && (scorect_s1 == 1 || scorect_s1 == 3 || scorect_s1 == 5 || scorect_s1 == 7 || scorect_s1 == 9 || scorect_s1 == 11 || scorect_s1 == 13 || scoret_s1 == 1 || scoret_s1 == 3 || scoret_s1 == 5 || scoret_s1 == 7 || scoret_s1 == 9 || scoret_s1 == 11 || scoret_s1 == 13))
                                {
                                    Color pixel3 = screenshot.GetPixel(disconnectx_1, disconnecty_1);
                                    screenshot.GetPixel(disconnectx_2, disconnecty_2);
                                    if (pixel3 == Color.FromArgb(Convert.ToInt32(-11751600)) || pixel3 == Color.FromArgb(Convert.ToInt32(-10826914)))
                                    {
                                        int pointPtr3 = MAKELPARAM(disconnectx_2, disconnecty_2);
                                        joinafter123(item.MainWindowHandle, pointPtr3, item.MainWindowTitle);
                                        flag = true;
                                    }
                                    if (flag)
                                    {
                                        clicked = true;
                                        pizdec = false;
                                        presshis();
                                    }
                                }
                            }
                            else if (comboBox7.SelectedIndex == 3)
                            {
                                if (xhase == RoundPhase.FreezeTime && xhase != RoundPhase.Over && ((mapnameid != 0 && scorect_sx == 3) || scorect_sx == 5 || scorect_sx == 7 || scorect_sx == 9 || scorect_sx == 11 || scorect_sx == 13 || scorect_sx == 1))
                                {
                                    Color pixel4 = screenshot.GetPixel(disconnectx_1, disconnecty_1);
                                    screenshot.GetPixel(disconnectx_2, disconnecty_2);
                                    if (pixel4 == Color.FromArgb(Convert.ToInt32(-11751600)) || pixel4 == Color.FromArgb(Convert.ToInt32(-10826914)))
                                    {
                                        int pointPtr4 = MAKELPARAM(disconnectx_2, disconnecty_2);
                                        joinafter123(item.MainWindowHandle, pointPtr4, item.MainWindowTitle);
                                        flag = true;
                                    }
                                    if (flag)
                                    {
                                        clicked = true;
                                        pizdec = false;
                                        presshis();
                                    }
                                }
                            }
                            else if (xhase == RoundPhase.FreezeTime && mapnameid != 0 && xhase != RoundPhase.Over && (scorect_s1 == 2 || scorect_s1 == 4 || scorect_s1 == 6 || scorect_s1 == 8 || scorect_s1 == 10 || scorect_s1 == 12 || scorect_s1 == 14 || scoret_s1 == 2 || scoret_s1 == 4 || scoret_s1 == 6 || scoret_s1 == 8 || scoret_s1 == 10 || scoret_s1 == 12 || scoret_s1 == 14))
                            {
                                Color pixel5 = screenshot.GetPixel(disconnectx_1, disconnecty_1);
                                screenshot.GetPixel(disconnectx_2, disconnecty_2);
                                if (pixel5 == Color.FromArgb(Convert.ToInt32(-11751600)) || pixel5 == Color.FromArgb(Convert.ToInt32(-10826914)))
                                {
                                    int pointPtr5 = MAKELPARAM(disconnectx_2, disconnecty_2);
                                    joinafter123(item.MainWindowHandle, pointPtr5, item.MainWindowTitle);
                                    flag = true;
                                }
                                if (flag)
                                {
                                    clicked = true;
                                    pizdec = false;
                                    presshis();
                                }
                            }
                        }
                        screenshot.Dispose();
                    }
                }
                catch
                {
                }
            }
            Thread.Sleep(1000);
        }

        private void worker_start(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            try
            {
                foreach (Process item in from pr in Process.GetProcesses()
                                         where pr.ProcessName == "csgo"
                                         select pr)
                {
                    Bitmap screenshot = GetScreenshot(item.MainWindowHandle);
                    string value = Regex.Match(item.MainWindowTitle, "@ ([^ |]+)([^\\n]+)").Groups[1].Value;
                    if (value != "")
                    {
                        RECT lpRect = default(RECT);
                        GetWindowRect(item.MainWindowHandle, out lpRect);
                        string para = "-x " + lpRect.Left + " -y " + lpRect.Top;
                        deruale(para, value);
                    }
                    if (screenshot != null && valstart && start_mysql2 != "" && start_mysql1 != "" && color_start1 != "" && color_start2 != "" && play_mysql2 != "" && play_mysql1 != "" && color_play1 != "" && color_play2 != "" && status != 2 && (item.MainWindowTitle.Contains(leader2) || item.MainWindowTitle.Contains(leader1)))
                    {
                        int result = 0;
                        int result2 = 0;
                        int result3 = 0;
                        int result4 = 0;
                        int result5 = 0;
                        int result6 = 0;
                        int result7 = 0;
                        int result8 = 0;
                        string s = play_mysql1.Split(',')[0];
                        string s2 = play_mysql1.Split(',')[1];
                        string s3 = play_mysql2.Split(',')[0];
                        string s4 = play_mysql2.Split(',')[1];
                        int.TryParse(s, out result5);
                        int.TryParse(s2, out result6);
                        int.TryParse(s3, out result7);
                        int.TryParse(s4, out result8);
                        string s5 = start_mysql1.Split(',')[0];
                        string s6 = start_mysql1.Split(',')[1];
                        string s7 = start_mysql2.Split(',')[0];
                        string s8 = start_mysql2.Split(',')[1];
                        int.TryParse(s5, out result);
                        int.TryParse(s6, out result2);
                        int.TryParse(s7, out result3);
                        int.TryParse(s8, out result4);
                        Color pixel = screenshot.GetPixel(result, result2);
                        screenshot.GetPixel(result3, result4);
                        Color pixel2 = screenshot.GetPixel(result5, result6);
                        screenshot.GetPixel(result7, result8);
                        if (pixel2 == Color.FromArgb(Convert.ToInt32(color_play1)))
                        {
                            int pointPtr = MAKELPARAM(20, 40);
                            joinafter1(item.MainWindowHandle, pointPtr, item.MainWindowTitle);
                            Thread.Sleep(50);
                            Thread.Sleep(250);
                        }
                        if (pixel == Color.FromArgb(Convert.ToInt32(color_start1)))
                        {
                            int pointPtr2 = MAKELPARAM(278, 285);
                            joinafter1(item.MainWindowHandle, pointPtr2, item.MainWindowTitle);
                            Thread.Sleep(50);
                            Thread.Sleep(250);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void updateloser(int lobbyid)
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + accountname + "';");
            mySqlCommand.Connection = connection;
            string text3 = "WIN";
            switch (lobbyid)
            {
                case 1:
                    text3 = "WIN";
                    whichlobby = "WIN";
                    break;
                case 2:
                    text3 = "LOSE";
                    whichlobby = "LOSE";
                    break;
                case 3:
                    text3 = "ONLY LOSE";
                    whichlobby = "ONLY LOSE";
                    break;
                case 4:
                    text3 = "ONLY WIN";
                    whichlobby = "ONLY WIN";
                    break;
                case 5:
                    text3 = "UNK";
                    whichlobby = "UNK";
                    break;
            }
            try
            {
                mySqlCommand.CommandText = "UPDATE accounts SET whichlobby='" + text3 + "' WHERE login='" + accountname + "'";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num != 1)
                {
                    MessageBox.Show("Unknown error!");
                }
            }
            switch (lobbyid)
            {
                case 1:
                    {
                        alerts.Show("Win lobby", alerts.AlertType.success);
                        string value2 = accountname;
                        int num3 = -1;
                        foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
                        {
                            if (item.Cells[0].Value.ToString().Equals(value2))
                            {
                                num3 = item.Index;
                                break;
                            }
                        }
                        if (num3 != -1)
                        {
                            bunifuCustomDataGrid1.Rows[num3].Cells[3].Value = "WIN";
                            bunifuCustomDataGrid1.Rows[num3].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        }
                        break;
                    }
                case 2:
                    {
                        alerts.Show("Lose lobby", alerts.AlertType.error);
                        string value5 = accountname;
                        int num6 = -1;
                        foreach (DataGridViewRow item2 in bunifuCustomDataGrid1.Rows)
                        {
                            if (item2.Cells[0].Value.ToString().Equals(value5))
                            {
                                num6 = item2.Index;
                                break;
                            }
                        }
                        if (num6 != -1)
                        {
                            bunifuCustomDataGrid1.Rows[num6].Cells[3].Value = "LOSE";
                            bunifuCustomDataGrid1.Rows[num6].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        }
                        break;
                    }
                case 3:
                    {
                        alerts.Show("ONLY LOSE", alerts.AlertType.error);
                        string value3 = accountname;
                        int num4 = -1;
                        foreach (DataGridViewRow item3 in bunifuCustomDataGrid1.Rows)
                        {
                            if (item3.Cells[0].Value.ToString().Equals(value3))
                            {
                                num4 = item3.Index;
                                break;
                            }
                        }
                        if (num4 != -1)
                        {
                            bunifuCustomDataGrid1.Rows[num4].Cells[3].Value = "ONLY LOSE";
                            bunifuCustomDataGrid1.Rows[num4].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        }
                        break;
                    }
                case 4:
                    {
                        alerts.Show("ONLY WIN", alerts.AlertType.success);
                        string value4 = accountname;
                        int num5 = -1;
                        foreach (DataGridViewRow item4 in bunifuCustomDataGrid1.Rows)
                        {
                            if (item4.Cells[0].Value.ToString().Equals(value4))
                            {
                                num5 = item4.Index;
                                break;
                            }
                        }
                        if (num5 != -1)
                        {
                            bunifuCustomDataGrid1.Rows[num5].Cells[3].Value = "ONLY WIN";
                            bunifuCustomDataGrid1.Rows[num5].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        }
                        break;
                    }
                case 5:
                    {
                        alerts.Show("Unknown lobby", alerts.AlertType.success);
                        string value = accountname;
                        int num2 = -1;
                        foreach (DataGridViewRow item5 in bunifuCustomDataGrid1.Rows)
                        {
                            if (item5.Cells[0].Value.ToString().Equals(value))
                            {
                                num2 = item5.Index;
                                break;
                            }
                        }
                        if (num2 != -1)
                        {
                            bunifuCustomDataGrid1.Rows[num2].Cells[3].Value = "UNK";
                            bunifuCustomDataGrid1.Rows[num2].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        }
                        break;
                    }
            }
        }

        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = "";
            if (bunifuCustomDataGrid1.Rows.Count <= 0 || e.RowIndex < 0)
            {
                return;
            }
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    mySqlDataReader["login"].ToString();
                    s = mySqlDataReader["id"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Unknown error with " + bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Error");
                bunifuCustomDataGrid1.ClearSelection();
            }
            finally
            {
                mySqlCommand.Connection.Close();
                int result = 0;
                int.TryParse(s, out result);
                if (result > 5)
                {
                    switch (Interaction.InputBox("1. WIN (SWAP LOBBY)" + Environment.NewLine + "2. LOSE (SWAP LOBBY)" + Environment.NewLine + "3. ONLY LOSE LOBBY" + Environment.NewLine + "4. ONLY WIN LOBBY" + Environment.NewLine + "5. UNKNOWN (CLEAR)" + Environment.NewLine + "TYPE 1/2/3/4/5 FOR CHANGING" + Environment.NewLine + "CURRENT LOBBY: " + whichlobby, accountname))
                    {
                        case "1":
                            updateloser(1);
                            bunifuCustomDataGrid1.Rows.Clear();
                            bunifuCustomDataGrid1.Refresh();
                            comboBox1.Items.Clear();
                            comboBox4.Items.Clear();
                            formloadnew("WIN");
                            formloadnew("LOSE");
                            formloadnew("ONLY WIN");
                            formloadnew("ONLY LOSE");
                            formloadnew("UNK");
                            fetchleader1();
                            fetchleader2();
                            bunifuCustomDataGrid1.ClearSelection();
                            break;
                        case "2":
                            updateloser(2);
                            bunifuCustomDataGrid1.Rows.Clear();
                            bunifuCustomDataGrid1.Refresh();
                            comboBox1.Items.Clear();
                            comboBox4.Items.Clear();
                            formloadnew("WIN");
                            formloadnew("LOSE");
                            formloadnew("ONLY WIN");
                            formloadnew("ONLY LOSE");
                            formloadnew("UNK");
                            fetchleader1();
                            fetchleader2();
                            bunifuCustomDataGrid1.ClearSelection();
                            break;
                        case "3":
                            updateloser(3);
                            bunifuCustomDataGrid1.Rows.Clear();
                            bunifuCustomDataGrid1.Refresh();
                            comboBox1.Items.Clear();
                            comboBox4.Items.Clear();
                            formloadnew("WIN");
                            formloadnew("LOSE");
                            formloadnew("ONLY WIN");
                            formloadnew("ONLY LOSE");
                            formloadnew("UNK");
                            fetchleader1();
                            fetchleader2();
                            bunifuCustomDataGrid1.ClearSelection();
                            break;
                        case "4":
                            updateloser(4);
                            bunifuCustomDataGrid1.Rows.Clear();
                            bunifuCustomDataGrid1.Refresh();
                            comboBox1.Items.Clear();
                            comboBox4.Items.Clear();
                            formloadnew("WIN");
                            formloadnew("LOSE");
                            formloadnew("ONLY WIN");
                            formloadnew("ONLY LOSE");
                            formloadnew("UNK");
                            fetchleader1();
                            fetchleader2();
                            bunifuCustomDataGrid1.ClearSelection();
                            break;
                        case "5":
                            updateloser(5);
                            bunifuCustomDataGrid1.Rows.Clear();
                            bunifuCustomDataGrid1.Refresh();
                            comboBox1.Items.Clear();
                            comboBox4.Items.Clear();
                            formloadnew("WIN");
                            formloadnew("LOSE");
                            formloadnew("ONLY WIN");
                            formloadnew("ONLY LOSE");
                            formloadnew("UNK");
                            fetchleader1();
                            fetchleader2();
                            bunifuCustomDataGrid1.ClearSelection();
                            break;
                    }
                    updatemeplz();
                }
            }
        }

        public void updatemeplz()
        {
            bunifuFlatButton12_Click(this, EventArgs.Empty);
            if (leader1 == accountname)
            {
                totaltext = leadertext1;
            }
            else if (leader2 == accountname)
            {
                totaltext = leadertext2;
            }
            else
            {
                totaltext = leadertext0;
            }
            string text = "WIN";
            if (true)
            {
                text = ((whichlobby == "WIN") ? "WIN" : ((whichlobby == "LOSE") ? "LOSE" : ((whichlobby == "ONLY LOSE") ? "ONLY LOSE" : ((whichlobby == "ONLY WIN") ? "ONLY WIN" : ((!(whichlobby == "UNK")) ? "CLIENT" : "UNK")))));
            }
            IEnumerable<Process> enumerable = from pr in Process.GetProcesses()
                                              where pr.ProcessName == "cmd"
                                              select pr;
            try
            {
                foreach (Process processx in enumerable)
                {
                    if (winparty.Any((string x) => processx.MainWindowTitle.Contains(accountname)))
                    {
                        SetWindowText(processx.MainWindowHandle, "@ ACCOUNT: " + text + " | LOGIN: " + accountname + totaltext);
                        Thread.Sleep(300);
                    }
                    if (loseparty.Any((string x) => processx.MainWindowTitle.Contains(accountname)))
                    {
                        SetWindowText(processx.MainWindowHandle, "@ ACCOUNT: " + text + " | LOGIN: " + accountname + totaltext);
                        Thread.Sleep(300);
                    }
                }
            }
            catch
            {
            }
        }

        public void updatemeplz1()
        {
            IEnumerable<Process> enumerable = from pr in Process.GetProcesses()
                                              where pr.ProcessName == "cmd"
                                              select pr;
            try
            {
                foreach (Process item in enumerable)
                {
                    if (item.MainWindowTitle.Contains(leader1))
                    {
                        string text = "WIN";
                        SetWindowText(item.MainWindowHandle, "@ ACCOUNT: " + text + " | LOGIN: " + leader1 + leadertext1);
                    }
                    else if (item.MainWindowTitle.Contains(leader2))
                    {
                        string text2 = "LOSE";
                        SetWindowText(item.MainWindowHandle, "@ ACCOUNT: " + text2 + " | LOGIN: " + leader2 + leadertext2);
                    }
                }
            }
            catch
            {
            }
        }

        public void updatemeplz2()
        {
            IEnumerable<Process> enumerable = from pr in Process.GetProcesses()
                                              where pr.ProcessName == "cmd"
                                              select pr;
            try
            {
                foreach (Process item in enumerable)
                {
                    if (item.MainWindowTitle.Contains(leader1))
                    {
                        string text = "WIN";
                        SetWindowText(item.MainWindowHandle, "@ ACCOUNT: " + text + " | LOGIN: " + leader1 + leadertext0);
                    }
                    else if (item.MainWindowTitle.Contains(leader2))
                    {
                        string text2 = "LOSE";
                        SetWindowText(item.MainWindowHandle, "@ ACCOUNT: " + text2 + " | LOGIN: " + leader2 + leadertext0);
                    }
                }
            }
            catch
            {
            }
        }

        public static string Value()
        {
            if (string.IsNullOrEmpty(fingerPrint))
            {
                fingerPrint = GetHash("CPU >> " + cpuId() + "\nBIOS >> " + biosId() + "\nBASE >> " + baseId());
            }
            return fingerPrint;
        }

        private static string GetHash(string s)
        {
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] bytes = new ASCIIEncoding().GetBytes(s);
            return GetHexString(mD5CryptoServiceProvider.ComputeHash(bytes));
        }

        private static string GetHexString(byte[] bt)
        {
            string text = string.Empty;
            for (int i = 0; i < bt.Length; i++)
            {
                byte num = bt[i];
                int num2 = num & 0xF;
                int num3 = (num >> 4) & 0xF;
                text = ((num3 <= 9) ? (text + num3) : (text + (char)(num3 - 10 + 65)));
                text = ((num2 <= 9) ? (text + num2) : (text + (char)(num2 - 10 + 65)));
                if (i + 1 != bt.Length && (i + 1) % 2 == 0)
                {
                    text += "-";
                }
            }
            return text;
        }

        private static string identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string text = "";
            foreach (ManagementObject instance in new ManagementClass(wmiClass).GetInstances())
            {
                if (instance[wmiMustBeTrue].ToString() == "True" && text == "")
                {
                    try
                    {
                        text = instance[wmiProperty].ToString();
                        return text;
                    }
                    catch
                    {
                    }
                }
            }
            return text;
        }

        private static string identifier(string wmiClass, string wmiProperty)
        {
            string text = "";
            foreach (ManagementObject instance in new ManagementClass(wmiClass).GetInstances())
            {
                if (text == "")
                {
                    try
                    {
                        text = instance[wmiProperty].ToString();
                        return text;
                    }
                    catch
                    {
                    }
                }
            }
            return text;
        }

        private static string cpuId()
        {
            string text = identifier("Win32_Processor", "UniqueId");
            if (text == "")
            {
                text = identifier("Win32_Processor", "ProcessorId");
                if (text == "")
                {
                    text = identifier("Win32_Processor", "Name");
                    if (text == "")
                    {
                        text = identifier("Win32_Processor", "Manufacturer");
                    }
                    text += identifier("Win32_Processor", "MaxClockSpeed");
                }
            }
            return text;
        }

        private static string biosId()
        {
            return identifier("Win32_BIOS", "Manufacturer") + identifier("Win32_BIOS", "SMBIOSBIOSVersion") + identifier("Win32_BIOS", "IdentificationCode") + identifier("Win32_BIOS", "SerialNumber") + identifier("Win32_BIOS", "ReleaseDate") + identifier("Win32_BIOS", "Version");
        }

        private static string diskId()
        {
            return identifier("Win32_DiskDrive", "Model") + identifier("Win32_DiskDrive", "Manufacturer") + identifier("Win32_DiskDrive", "Signature") + identifier("Win32_DiskDrive", "TotalHeads");
        }

        private static string baseId()
        {
            return identifier("Win32_BaseBoard", "Model") + identifier("Win32_BaseBoard", "Manufacturer") + identifier("Win32_BaseBoard", "Name") + identifier("Win32_BaseBoard", "SerialNumber");
        }

        private static string videoId()
        {
            return identifier("Win32_VideoController", "DriverVersion") + identifier("Win32_VideoController", "Name");
        }

        private static string macId()
        {
            return identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
        }

        private void bunifuCustomTextbox8_Click(object sender, EventArgs e)
        {
            currentbox = 1;
        }

        private void bunifuCustomTextbox9_Click(object sender, EventArgs e)
        {
            currentbox = 2;
        }

        private void bunifuCustomTextbox12_Click(object sender, EventArgs e)
        {
            currentbox = 3;
        }

        private void bunifuCustomTextbox13_Click(object sender, EventArgs e)
        {
            currentbox = 4;
        }

        private void bunifuCustomTextbox5_Click(object sender, EventArgs e)
        {
            currentbox = 5;
        }

        private void bunifuCustomTextbox6_Click(object sender, EventArgs e)
        {
            currentbox = 6;
        }

        public void KillMe()
        {
            if (xhase != RoundPhase.Over || comboBox7.SelectedIndex == 1 || comboBox7.SelectedIndex == 0)
            {
                return;
            }
            if (comboBox7.SelectedIndex == 3)
            {
                if (backgroundWorker01.IsBusy)
                {
                    if (scorect_sx != 15)
                    {
                        if (scorect_sx != 0)
                        {
                            backgroundWorker01.CancelAsync();
                            timertest = false;
                            timer3.Interval = 2000;
                            timer3.Enabled = false;
                            timer3.Stop();
                        }
                        else
                        {
                            backgroundWorker01.CancelAsync();
                            timertest = false;
                            timer3.Interval = 5;
                            timer3.Enabled = false;
                            timer3.Stop();
                        }
                    }
                }
                else if (scorect_sx == 15)
                {
                    timertest = true;
                    timer3.Interval = 5;
                    if (!timer3.Enabled)
                    {
                        timer3.Enabled = true;
                        timer3.Start();
                    }
                }
            }
            else if (((scorect_s1 != 15 && team == 1) || (scoret_s1 != 15 && team == 2)) && backgroundWorker01.IsBusy)
            {
                backgroundWorker01.CancelAsync();
                timertest = false;
                timer3.Interval = 2000;
                timer3.Enabled = false;
                timer3.Stop();
            }
        }

        public void StartMe()
        {
            if (xhase == RoundPhase.FreezeTime)
            {
                if (scorect_s1 != 16 && scoret_s1 != 16 && !backgroundWorker01.IsBusy && !timer3.Enabled)
                {
                    timertest = true;
                    timer3.Interval = 5;
                    timer3.Enabled = true;
                    timer3.Start();
                }
            }
            else
            {
                if (((scorect_s1 != 15 || scoret_s1 != 0) && (scoret_s1 != 15 || scorect_s1 != 0)) || scorect_s1 == 16 || scoret_s1 == 16)
                {
                    return;
                }
                if (!backgroundWorker01.IsBusy)
                {
                    if (!timer3.Enabled)
                    {
                        timertest = true;
                        timer3.Interval = 2000;
                        timer3.Enabled = true;
                        timer3.Start();
                    }
                    else
                    {
                        timer3.Interval = 2000;
                    }
                }
                else
                {
                    backgroundWorker01.CancelAsync();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (username == "")
            {
                Clipboard.SetText(Value());
                try
                {
                    gsl.Stop();
                }
                catch
                {
                }
                Environment.Exit(0);
            }
            else
            {
                backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += worker_start;
                backgroundWorker.RunWorkerCompleted += worker_RunWorkerCompleted;
                backgroundWorker.RunWorkerAsync(1);
                backgroundWorker01 = new BackgroundWorker();
                backgroundWorker01.DoWork += worker_start1;
                backgroundWorker01.RunWorkerAsync(1);
                backgroundWorker01.WorkerSupportsCancellation = true;
                backgroundWorker1 = new BackgroundWorker();
                backgroundWorker1.DoWork += worker_accept;
                backgroundWorker1.RunWorkerCompleted += worker_RunWorkerCompleted1;
                backgroundWorker1.RunWorkerAsync(1);
                backgroundWorker2 = new BackgroundWorker();
                backgroundWorker2.DoWork += worker_timer;
                backgroundWorker2.RunWorkerCompleted += worker_RunWorkerCompleted2;
                backgroundWorker2.RunWorkerAsync(1);
                loginintoaccount = new BackgroundWorker();
                loginintoaccount.DoWork += worker_login;
                backgroundWorker3 = new BackgroundWorker();
                backgroundWorker3.DoWork += worker_disconnects;
                backgroundWorker3.RunWorkerCompleted += worker_RunWorkerCompleted3;
                backgroundWorker3.RunWorkerAsync(1);
                backgroundWorker1337 = new BackgroundWorker();
                backgroundWorker1337.DoWork += worker_invite;
                backgroundWorker1337.WorkerSupportsCancellation = true;
                backgroundWorker1337.CancelAsync();
                backgroundWorker13371 = new BackgroundWorker();
                backgroundWorker13371.DoWork += worker_invite1;
                backgroundWorker13371.WorkerSupportsCancellation = true;
                backgroundWorker13371.CancelAsync();
                gsl = new GameStateListener(3000);
                gsl.NewGameState += OnNewGameState;
                if (!gsl.Start())
                {
                    MessageBox.Show("Another panel already is started");
                    Environment.Exit(0);
                }
            }
            timer1.Enabled = false;
            timer1.Stop();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                disconnects_enabled = false;
                bunifuFlatButton10.Text = "      DISCONNECTS: OFF";
                valswap12 = false;
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                disconnects_enabled = true;
                bunifuFlatButton10.Text = "      DISCONNECTS: ON";
                valswap12 = true;
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            valswap = !valswap;
            if (!valswap)
            {
                SENDINFO("http://127.0.0.1/panel.php", "message=5");
                bunifuFlatButton8.Text = "      LEADER: #1";
            }
            else
            {
                SENDINFO("http://127.0.0.1/panel.php", "message=6");
                bunifuFlatButton8.Text = "      LEADER: #2";
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            valswap1 = !valswap1;
            if (!valswap1)
            {
                bunifuFlatButton9.Text = "      MEM REDUCT: OFF";
            }
            else
            {
                bunifuFlatButton9.Text = "      MEM REDUCT: ON";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelw = !panelw;
            if (!panelw)
            {
                Minimizar.Visible = true;
                Salir.Visible = true;
                MenuSidebar.Visible = true;
                label1.Visible = true;
                base.Width = 1400;
                base.Height = 900;
                MenuTop.Visible = true;
                bunifuFlatButton1.Visible = true;
                bunifuFlatButton2.Visible = true;
                bunifuFlatButton3.Visible = true;
                bunifuFlatButton4.Location = new Point(7, 224);
                bunifuFlatButton5.Location = new Point(7, 274);
                bunifuFlatButton6.Location = new Point(7, 324);
                bunifuFlatButton7.Location = new Point(7, 374);
                bunifuFlatButton8.Location = new Point(7, 424);
                bunifuFlatButton9.Location = new Point(7, 474);
                bunifuFlatButton10.Location = new Point(7, 524);
                bunifuFlatButton13.Location = new Point(7, 574);
                bunifuFlatButton11.Location = new Point(7, 624);
                bunifuFlatButton12.Location = new Point(7, 674);
            }
            else
            {
                Minimizar.Visible = false;
                Salir.Visible = false;
                MenuSidebar.Visible = false;
                label1.Visible = false;
                MenuTop.Visible = false;
                base.Width = 300;
                base.Height = 660;
                bunifuFlatButton1.Visible = false;
                bunifuFlatButton2.Visible = false;
                bunifuFlatButton3.Visible = false;
                bunifuFlatButton4.Location = new Point(7, 74);
                bunifuFlatButton5.Location = new Point(7, 124);
                bunifuFlatButton6.Location = new Point(7, 174);
                bunifuFlatButton7.Location = new Point(7, 224);
                bunifuFlatButton8.Location = new Point(7, 274);
                bunifuFlatButton9.Location = new Point(7, 324);
                bunifuFlatButton10.Location = new Point(7, 374);
                bunifuFlatButton13.Location = new Point(7, 424);
                bunifuFlatButton11.Location = new Point(7, 474);
                bunifuFlatButton12.Location = new Point(7, 524);
            }
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            valswap12 = !valswap12;
            if (!valswap12)
            {
                bunifuFlatButton10.Text = "      DISCONNECTS: OFF";
                disconnects_enabled = false;
                comboBox6.SelectedIndex = 0;
            }
            else
            {
                bunifuFlatButton10.Text = "      DISCONNECTS: ON";
                disconnects_enabled = true;
                comboBox6.SelectedIndex = 1;
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            if (!autoinvite)
            {
                MessageBox.Show("Auto Invite is disabled!");
                return;
            }
            string text = Interaction.InputBox("Count:");
            if (text == "")
            {
                alerts.Show("Games cleared!", alerts.AlertType.success);
                howmuch = -1;
                howmuch1 = 0;
                bunifuFlatButton11.Text = "      GAMES COUNT";
            }
            else
            {
                int result = 0;
                int.TryParse(text, out result);
                howmuch = result;
                bunifuFlatButton11.Text = "      GAMES COUNT: " + howmuch1 + "/" + howmuch;
            }
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            winparty.Clear();
            loseparty.Clear();
            to_win4.Clear();
            to_lose4.Clear();
            int num = 0;
            IEnumerable<Process> enumerable = from pr in Process.GetProcesses()
                                              where pr.ProcessName == "cmd"
                                              select pr;
            bool flag = true;
            if (flag)
            {
                foreach (Process item in enumerable)
                {
                    if (item.MainWindowTitle.Contains("@ ACCOUNT: "))
                    {
                        to_win4.Add(item.MainWindowTitle);
                        num++;
                    }
                }
                if (num > 0)
                {
                    foreach (string item2 in to_win4)
                    {
                        string text = Regex.Match(item2, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[3].Value;
                        string value = Regex.Match(item2, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[1].Value;
                        if (text != "")
                        {
                            if (value == " WIN ")
                            {
                                text = text.Split(':')[1];
                                text = text.Split(' ')[1];
                                winparty.Add(text + " ");
                            }
                            if (value == " ONLY LOSE ")
                            {
                                text = text.Split(':')[1];
                                text = text.Split(' ')[1];
                                loseparty.Add(text + " ");
                                winparty.Add(text + " ");
                            }
                            if (value == " ONLY WIN ")
                            {
                                text = text.Split(':')[1];
                                text = text.Split(' ')[1];
                            }
                            if (value == " UNK ")
                            {
                                text = text.Split(':')[1];
                                text = text.Split(' ')[1];
                            }
                        }
                    }
                }
            }
            int num2 = 0;
            if (flag)
            {
                foreach (Process item3 in enumerable)
                {
                    if (item3.MainWindowTitle.Contains("@ ACCOUNT: "))
                    {
                        to_lose4.Add(item3.MainWindowTitle);
                        num2++;
                    }
                }
                if (num2 > 0)
                {
                    foreach (string item4 in to_lose4)
                    {
                        string text2 = Regex.Match(item4, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[3].Value;
                        string value2 = Regex.Match(item4, "@ ACCOUNT:([^|]+)([^:]+)([^|]+)([^\\n]+)").Groups[1].Value;
                        if (text2 != "")
                        {
                            if (value2 == " LOSE ")
                            {
                                text2 = text2.Split(':')[1];
                                text2 = text2.Split(' ')[1];
                                loseparty.Add(text2 + " ");
                            }
                            if (value2 == " ONLY LOSE ")
                            {
                                text2 = text2.Split(':')[1];
                                text2 = text2.Split(' ')[1];
                                loseparty.Add(text2 + " ");
                                winparty.Add(text2 + " ");
                            }
                            if (value2 == " ONLY WIN ")
                            {
                                text2 = text2.Split(':')[1];
                                text2 = text2.Split(' ')[1];
                            }
                            if (value2 == " UNK ")
                            {
                                text2 = text2.Split(':')[1];
                                text2 = text2.Split(' ')[1];
                            }
                        }
                    }
                }
            }
            if (e != EventArgs.Empty)
            {
                alerts.Show("Accounts fetched!", alerts.AlertType.success);
            }
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {
        }

        private void deruale(string para, string title)
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + title + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    if (mySqlDataReader["parameters"].ToString() != para)
                    {
                        mySqlCommand.CommandText = "UPDATE accounts SET parameters='" + para + "' WHERE login='" + title + "'";
                    }
                }
                mySqlDataReader.Close();
                num = mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                _ = 1;
            }
        }

        private void updatess()
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + accountname + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.CommandText = "UPDATE accounts SET ss='" + SharedMy + "' WHERE login='" + accountname + "'";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num != 1)
                {
                    mywins = "UNK";
                    mydate = "UNK";
                    mydateexp = "UNK";
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void updatemywins()
        {
            int num = -1;
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + accountname + "';");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.CommandText = "UPDATE accounts SET wins='" + mywins + "', time='" + mydate + "', exp='" + mydateexp + "' WHERE login='" + accountname + "'";
                mySqlCommand.Connection.Open();
                num = mySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlCommand.Connection.Close();
                if (num != 1)
                {
                    mywins = "UNK";
                    mydate = "UNK";
                    mydateexp = "UNK";
                    MessageBox.Show("Unknown error!");
                }
            }
        }

        private void bunifuCustomDataGrid1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!(accountname != ""))
                {
                    return;
                }
                string text = "";
                if (mydate != "UNK" && mydateexp != "UNK")
                {
                    DateTime.Parse(mydate);
                    DateTime t = DateTime.Parse(mydateexp);
                    DateTime now = DateTime.Now;
                    text = ((t <= now) ? ((!(whichlobby != "LOSE") || !(whichlobby != "ONLY LOSE")) ? "UNK" : "Already") : ((!(whichlobby != "LOSE") || !(whichlobby != "ONLY LOSE")) ? "UNK" : t.ToString()));
                }
                else
                {
                    text = "UNK";
                }
                string prompt = "WINS: " + mywins + Environment.NewLine + "Updated: " + mydate + Environment.NewLine + "Expires: " + text;
                if (rank5x5 != "0")
                {
                    prompt = "GAMES: " + mywins + Environment.NewLine + "Updated: " + mydate;
                }
                string text2 = Interaction.InputBox(prompt, accountname);
                if (text2 == "")
                {
                    alerts.Show("Nothing changed", alerts.AlertType.error);
                    return;
                }
                int result = 0;
                int.TryParse(text2, out result);
                if (result < 10)
                {
                    alerts.Show("Wins updated!", alerts.AlertType.success);
                    mywins = text2;
                    mydate = DateTime.Now.ToString();
                    mydateexp = DateTime.Now.AddHours(21.0).ToString();
                    updatemywins();
                    return;
                }
                switch (result)
                {
                    case 10:
                        if (rank5x5 != "0")
                        {
                            alerts.Show("Games cleared!", alerts.AlertType.success);
                        }
                        else
                        {
                            alerts.Show("Wins cleared!", alerts.AlertType.success);
                        }
                        mywins = "UNK";
                        mydate = "UNK";
                        mydateexp = "UNK";
                        updatemywins();
                        return;
                    case 666:
                        if (rank5x5 != "0")
                        {
                            alerts.Show("Games cleared!", alerts.AlertType.success);
                            mywins = "UNK";
                            mydate = "UNK";
                            mydateexp = "UNK";
                            updatemywins();
                        }
                        return;
                }
                if (rank5x5 != "0")
                {
                    alerts.Show("Info updated!", alerts.AlertType.success);
                    mywins = text2;
                    mydate = DateTime.Now.ToString();
                    mydateexp = "UNK";
                    updatemywins();
                }
                else
                {
                    alerts.Show("Only lower than 10!", alerts.AlertType.error);
                    mywins = "UNK";
                    mydate = "UNK";
                    mydateexp = "UNK";
                }
            }
            else
            {
                if (e.Button != MouseButtons.Middle || !(accountname != ""))
                {
                    return;
                }
                if (SharedMy != "")
                {
                    Clipboard.SetText(GenerateSteamGuardCode());
                    return;
                }
                string text3 = Interaction.InputBox("Please enter yours Shared Secret code:", accountname);
                if (text3 != "")
                {
                    SharedMy = text3;
                    updatess();
                    alerts.Show("Saved!", alerts.AlertType.success);
                }
            }
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {
        }

        private void coordsx1y(string thebig)
        {
            string s = thebig.Split(',')[0];
            string s2 = thebig.Split(',')[1];
            int result = 0;
            int result2 = 0;
            int.TryParse(s, out result);
            int.TryParse(s2, out result2);
            SetcurPos(result, result2);
            Thread.Sleep(10);
            SetcurPos(result, result2);
            Thread.Sleep(10);
            LeftClick();
            Thread.Sleep(10);
        }

        private void coordsx1y1(string thebig)
        {
            string s = thebig.Split(',')[0];
            string s2 = thebig.Split(',')[1];
            int result = 0;
            int result2 = 0;
            int.TryParse(s, out result);
            int.TryParse(s2, out result2);
            SetcurPos(result, result2);
            Thread.Sleep(10);
            SetcurPos(result, result2);
            Thread.Sleep(10);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker13371.IsBusy)
            {
                backgroundWorker13371.CancelAsync();
                backgroundWorker13371.RunWorkerAsync();
            }
            else
            {
                backgroundWorker13371.RunWorkerAsync();
            }
        }

        private void joinafter(IntPtr childWindow, int pointPtr, string exname)
        {
            if (exname.Contains(" | BOT") || exname.Contains(" | LEADER #1") || exname.Contains(" | LEADER #2"))
            {
                PostMessage(childWindow, 512u, (IntPtr)0, (IntPtr)pointPtr);
            }
        }

        private void joinafter123(IntPtr childWindow, int pointPtr, string exname)
        {
            if (joinafter1234)
            {
                if (comboBox7.SelectedIndex == 3)
                {
                    if (xhase == RoundPhase.FreezeTime && xhase != RoundPhase.Over && !timertest)
                    {
                        joinafter1234 = false;
                        int result = 0;
                        int.TryParse(ms1, out result);
                        Thread.Sleep(result);
                    }
                }
                else if (xhase == RoundPhase.FreezeTime && !timertest)
                {
                    joinafter1234 = false;
                    int result2 = 0;
                    int.TryParse(ms1, out result2);
                    Thread.Sleep(result2);
                }
            }
            if (!joinafter1234 && (exname.Contains(" | BOT") || exname.Contains(" | LEADER #1") || exname.Contains(" | LEADER #2")))
            {
                PostMessage(childWindow, 512u, (IntPtr)0, (IntPtr)pointPtr);
                PostMessage(childWindow, 513u, (IntPtr)1, (IntPtr)pointPtr);
                PostMessage(childWindow, 514u, (IntPtr)0, (IntPtr)pointPtr);
            }
        }

        private void joinafter1(IntPtr childWindow, int pointPtr, string exname)
        {
            if (comboBox7.SelectedIndex == 3)
            {
                if (exname.Contains(" | BOT") || exname.Contains(" | LEADER #1") || exname.Contains(" | LEADER #2"))
                {
                    PostMessage(childWindow, 512u, (IntPtr)0, (IntPtr)pointPtr);
                    PostMessage(childWindow, 513u, (IntPtr)1, (IntPtr)pointPtr);
                    PostMessage(childWindow, 514u, (IntPtr)0, (IntPtr)pointPtr);
                }
            }
            else if (exname.Contains(" | BOT") || exname.Contains(" | LEADER #1") || exname.Contains(" | LEADER #2"))
            {
                PostMessage(childWindow, 512u, (IntPtr)0, (IntPtr)pointPtr);
                PostMessage(childWindow, 513u, (IntPtr)1, (IntPtr)pointPtr);
                PostMessage(childWindow, 514u, (IntPtr)0, (IntPtr)pointPtr);
            }
        }

        private void joinafter2(IntPtr childWindow, int pointPtr, string exname)
        {
            if (exname.Contains(" | BOT") || exname.Contains(" | LEADER #1") || exname.Contains(" | LEADER #2"))
            {
                PostMessage(childWindow, 512u, (IntPtr)0, (IntPtr)pointPtr);
                PostMessage(childWindow, 516u, (IntPtr)1, (IntPtr)pointPtr);
                PostMessage(childWindow, 517u, (IntPtr)0, (IntPtr)pointPtr);
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

        private int MAKELPARAM(int p, int p_2)
        {
            return (p_2 << 16) | (p & 0xFFFF);
        }

        private void bunifuFlatButton10_MouseUp(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            if (autoinvite)
            {
                autoinvite = !autoinvite;
                bunifuFlatButton13.Text = "      AUTO INVITE: OFF";
            }
            else
            {
                autoinvite = !autoinvite;
                bunifuFlatButton13.Text = "      AUTO INVITE: ON";
            }
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bunifuCustomDataGrid1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != bunifuCustomDataGrid1.Columns["Login"].Index || bunifuCustomDataGrid1.Rows.Count <= 0 || e.RowIndex < 0)
            {
                return;
            }
            string s = "";
            DataGridViewCell dataGridViewCell = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewCell dataGridViewCell2 = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells["Login"];
            logincount = dataGridViewCell2.ToString();
            if (dataGridViewCell2.Equals(logincount))
            {
                return;
            }
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts where login='" + bunifuCustomDataGrid1.Rows[e.RowIndex].Cells["Login"].Value.ToString() + "';");
            mySqlCommand.Connection = connection;
            string text3 = "UNK";
            string text4 = "UNK";
            string text5 = "UNK";
            string a = "0";
            string a2 = "UNK";
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    mySqlDataReader["login"].ToString();
                    logincount = mySqlDataReader["login"].ToString();
                    s = mySqlDataReader["id"].ToString();
                    text3 = mySqlDataReader["wins"].ToString();
                    text4 = mySqlDataReader["time"].ToString();
                    text5 = mySqlDataReader["exp"].ToString();
                    a = mySqlDataReader["5x5"].ToString();
                    a2 = mySqlDataReader["whichlobby"].ToString();
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Unknown error with " + bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Error");
                bunifuCustomDataGrid1.ClearSelection();
            }
            finally
            {
                mySqlCommand.Connection.Close();
                string text6 = "";
                if (a == "0")
                {
                    string text7 = "UNK";
                    if (text4 != "UNK" && text5 != "UNK")
                    {
                        DateTime.Parse(text4);
                        DateTime t = DateTime.Parse(text5);
                        DateTime now = DateTime.Now;
                        text7 = ((t <= now) ? ((!(a2 != "LOSE") || !(a2 != "ONLY LOSE")) ? "UNK" : "Already") : ((!(a2 != "LOSE") || !(a2 != "ONLY LOSE")) ? "UNK" : t.ToString()));
                    }
                    else
                    {
                        text7 = "UNK";
                    }
                    text6 = "Login: " + logincount + Environment.NewLine + "Wins: " + text3 + Environment.NewLine + "Updated: " + text4 + Environment.NewLine + "Expires: " + text7;
                }
                else
                {
                    text6 = "Login: " + logincount + Environment.NewLine + "Games: " + text3 + Environment.NewLine + "Updated: " + text4;
                }
                int result = 0;
                int.TryParse(s, out result);
                if (text6 != "" && result > 5)
                {
                    dataGridViewCell.ToolTipText = text6;
                }
            }
        }

        private void bunifuCustomDataGrid1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bunifuCustomDataGrid1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void bunifuCustomDataGrid1_MouseHover(object sender, EventArgs e)
        {
        }

        private static string ShowTimeSpanProperties(TimeSpan interval)
        {
            return interval.Hours.ToString();
        }

        private static string ShowTimeSpanProperties1(TimeSpan interval)
        {
            return interval.Minutes.ToString();
        }

        private void showthis()
        {
            MySqlConnection connection = new MySqlConnection("Database=" + databasename + ";Data Source=localhost;User Id=root;Password=");
            MySqlCommand mySqlCommand = new MySqlCommand();
            string text2 = (mySqlCommand.CommandText = "SELECT * FROM accounts WHERE exp <> 'UNK' AND 5x5='0' AND whichlobby <> 'LOSE' AND whichlobby <> 'ONLY LOSE' ORDER BY id;");
            mySqlCommand.Connection = connection;
            try
            {
                mySqlCommand.Connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    string text3 = mySqlDataReader["login"].ToString();
                    string s = mySqlDataReader["exp"].ToString();
                    string text4 = mySqlDataReader["wins"].ToString();
                    DateTime t = DateTime.Parse(s);
                    DateTime now = DateTime.Now;
                    if (t <= now)
                    {
                        string text5 = t.ToString("MM");
                        string text6 = t.ToString("dd");
                        string text7 = t.ToString("yyyy");
                        string text8 = text6 + "." + text5 + "." + text7;
                        fetchgu.Add(text3 + " | WINS: " + text4 + " | EXPIRED: " + text8);
                    }
                    else
                    {
                        DateTime dateTime = DateTime.Parse(s);
                        DateTime now2 = DateTime.Now;
                        TimeSpan interval = dateTime.Subtract(now2);
                        string text9 = ShowTimeSpanProperties(interval) + ":" + ShowTimeSpanProperties1(interval);
                        string item = text3 + " | WINS: " + text4 + " | EXPIRES AFTER: " + text9;
                        fetchgu1.Add(item);
                    }
                }
                mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                Environment.Exit(0);
            }
            finally
            {
                mySqlCommand.Connection.Close();
                string text10 = string.Join(Environment.NewLine, fetchgu);
                string text11 = string.Join(Environment.NewLine, fetchgu1);
                if (text10 != "")
                {
                    MessageBox.Show(text10, "Expired");
                }
                if (text11 != "")
                {
                    MessageBox.Show(text11, "Cooldown");
                }
                fetchgu.Clear();
                fetchgu1.Clear();
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            showthis();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            testkill();
            timer2.Enabled = false;
            timer2.Stop();
            bunifuThinButton211_Click(null, null);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (backgroundWorker01.IsBusy)
            {
                return;
            }
            if (timertest)
            {
                if ((scorect_s1 == 15 && scoret_s1 == 0) || (scoret_s1 == 15 && scorect_s1 == 0))
                {
                    Thread.Sleep(500);
                }
                backgroundWorker01.RunWorkerAsync(1);
                timertest = false;
                timer3.Enabled = false;
                timer3.Stop();
            }
            else if ((scorect_s1 == 15 && scoret_s1 == 0) || (scoret_s1 == 15 && scorect_s1 == 0))
            {
                Thread.Sleep(500);
                backgroundWorker01.RunWorkerAsync(1);
                timertest = false;
                timer3.Enabled = false;
                timer3.Stop();
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == 0)
            {
                denis_ver = true;
                bunifuCustomDataGrid1.Rows.Clear();
                bunifuCustomDataGrid1.Refresh();
                comboBox1.Items.Clear();
                comboBox4.Items.Clear();
                formloadnew("WIN");
                bunifuCustomDataGrid1.ClearSelection();
            }
            else if (comboBox9.SelectedIndex == 1)
            {
                denis_ver = false;
                bunifuCustomDataGrid1.Rows.Clear();
                bunifuCustomDataGrid1.Refresh();
                comboBox1.Items.Clear();
                comboBox4.Items.Clear();
                formloadnew("WIN");
                formloadnew("LOSE");
                formloadnew("ONLY WIN");
                formloadnew("ONLY LOSE");
                formloadnew("UNK");
                bunifuCustomDataGrid1.ClearSelection();
            }
            else if (comboBox9.SelectedIndex == 2)
            {
                denis_ver = true;
                bunifuCustomDataGrid1.Rows.Clear();
                bunifuCustomDataGrid1.Refresh();
                comboBox1.Items.Clear();
                comboBox4.Items.Clear();
                formloadnew("WIN");
                bunifuCustomDataGrid1.ClearSelection();
            }
            else if (comboBox9.SelectedIndex == 3)
            {
                denis_ver = true;
                bunifuCustomDataGrid1.Rows.Clear();
                bunifuCustomDataGrid1.Refresh();
                comboBox1.Items.Clear();
                comboBox4.Items.Clear();
                formloadnew("WIN");
                bunifuCustomDataGrid1.ClearSelection();
            }
        }
    }
}
