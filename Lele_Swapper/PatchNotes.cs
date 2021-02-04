using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Events;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using Lele_Swapper.Properties;
using Lele_Swapper.Swapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lele_Swapper
{
	public class PatchNotes : Form
	{
		private bool drag = false;

		private Point start_point = new Point(0, 0);

		public DiscordRpcClient client;

		public Form activeForm = null;

		private IContainer components = null;

		private PictureBox SkinButton;

		private PictureBox SettingButton;

		public Panel panel2;

		private Panel FormPanel;

		private PictureBox pictureBox1;

		private Panel panel1;

		private PictureBox close;

		private PictureBox minimize;

		private Label username;

		private Timer timer1;

		private PictureBox leleswapper_logo;

		private PictureBox v14_20_items;

		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		public PatchNotes()
		{
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_039e: Expected O, but got Unknown
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Expected O, but got Unknown
			//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Expected O, but got Unknown
			//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Expected O, but got Unknown
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Unknown result type (might be due to invalid IL or missing references)
			//IL_046e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Unknown result type (might be due to invalid IL or missing references)
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Expected O, but got Unknown
			//IL_053b: Expected O, but got Unknown
			InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, base.Width, base.Height, 25, 25));
			Timer timer = new Timer();
			timer.Interval = 30000;
			timer.Tick += TimerEventProcessor;
			timer.Start();
			switch (Lele_Swapper.Properties.Settings.Default.Themes)
			{
			case "Red":
				BackColor = Color.DarkRed;
				panel2.BackColor = Color.FromArgb(192, 0, 0);
				break;
			case "Default":
				BackColor = Color.Teal;
				panel2.BackColor = Color.FromArgb(0, 192, 192);
				break;
			case "Green":
				BackColor = Color.Green;
				panel2.BackColor = Color.FromArgb(0, 192, 0);
				break;
			case "Purple":
				BackColor = Color.Purple;
				panel2.BackColor = Color.FromArgb(192, 0, 192);
				break;
			}
			username.Text = "User: " + Environment.UserName;
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
			WebRequest webRequest = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"close")).ToString());
			WebResponse response = webRequest.GetResponse();
			using (Stream stream = response.GetResponseStream())
			{
				close.Image = Image.FromStream(stream);
			}
			WebRequest webRequest2 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"minimize")).ToString());
			WebResponse response2 = webRequest2.GetResponse();
			using (Stream stream2 = response2.GetResponseStream())
			{
				minimize.Image = Image.FromStream(stream2);
			}
			WebRequest webRequest3 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"v2")).ToString());
			WebResponse response3 = webRequest3.GetResponse();
			using (Stream stream3 = response3.GetResponseStream())
			{
				SkinButton.Image = Image.FromStream(stream3);
			}
			WebRequest webRequest4 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"settings")).ToString());
			WebResponse response4 = webRequest4.GetResponse();
			using (Stream stream4 = response4.GetResponseStream())
			{
				SettingButton.Image = Image.FromStream(stream4);
			}
			WebRequest webRequest5 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"logo")).ToString());
			WebResponse response5 = webRequest5.GetResponse();
			using (Stream stream5 = response5.GetResponseStream())
			{
				leleswapper_logo.Image = Image.FromStream(stream5);
			}
			WebRequest webRequest6 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"paks")).ToString());
			WebResponse response6 = webRequest6.GetResponse();
			using (Stream stream6 = response6.GetResponseStream())
			{
				v14_20_items.Image = Image.FromStream(stream6);
			}
			openChildForm(new Credits());
			client = new DiscordRpcClient("745299590487474216");
			DiscordRpcClient obj = client;
			ConsoleLogger val2 = new ConsoleLogger();
			val2.set_Level((LogLevel)3);
			obj.set_Logger((ILogger)val2);
			DiscordRpcClient obj2 = client;
			object obj3 = _003C_003Ec._003C_003E9__3_0;
			if (obj3 == null)
			{
				OnReadyEvent val3 = delegate(object sender, ReadyMessage e)
				{
					Console.WriteLine("Received Ready from user {0}", e.get_User().get_Username());
				};
				obj3 = (object)val3;
				_003C_003Ec._003C_003E9__3_0 = val3;
			}
			obj2.add_OnReady((OnReadyEvent)obj3);
			DiscordRpcClient obj4 = client;
			object obj5 = _003C_003Ec._003C_003E9__3_1;
			if (obj5 == null)
			{
				OnPresenceUpdateEvent val4 = delegate(object sender, PresenceMessage e)
				{
					Console.WriteLine("Received Update! {0}", e.get_Presence());
				};
				obj5 = (object)val4;
				_003C_003Ec._003C_003E9__3_1 = val4;
			}
			obj4.add_OnPresenceUpdate((OnPresenceUpdateEvent)obj5);
			client.Initialize();
			DiscordRpcClient obj6 = client;
			RichPresence val5 = new RichPresence();
			val5.set_Details(((object)val.get_Item("status").get_Item((object)"version")).ToString() + " - " + ((object)val.get_Item("rpc").get_Item((object)"tabs").get_Item((object)"patchnotes")).ToString());
			val5.set_State("User: " + Environment.UserName);
			Assets val6 = new Assets();
			val6.set_LargeImageKey(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"bigicon")).ToString());
			val6.set_LargeImageText(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"bigtext")).ToString());
			val6.set_SmallImageKey(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"smallicon")).ToString());
			val6.set_SmallImageText(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"smalltext")).ToString());
			val5.set_Assets(val6);
			obj6.SetPresence(val5);
			try
			{
				LocateFortnitePath();
			}
			catch (Exception)
			{
				MessageBox.Show("Failed To Locate Installation Path", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		public void openChildForm(Form childForm)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			FormPanel.Controls.Add(childForm);
			FormPanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void SkinButton_Click(object sender, EventArgs e)
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected O, but got Unknown
			//IL_016b: Expected O, but got Unknown
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
			string a = ((object)val.get_Item("v2").get_Item((object)"skins").get_Item((object)"status")).ToString();
			if (a == "enabled")
			{
				DiscordRpcClient obj = client;
				RichPresence val2 = new RichPresence();
				val2.set_Details(((object)val.get_Item("status").get_Item((object)"version")).ToString() + " - " + ((object)val.get_Item("rpc").get_Item((object)"tabs").get_Item((object)"v2")).ToString());
				val2.set_State("User: " + Environment.UserName);
				Assets val3 = new Assets();
				val3.set_LargeImageKey(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"bigicon")).ToString());
				val3.set_LargeImageText(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"bigtext")).ToString());
				val3.set_SmallImageKey(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"smallicon")).ToString());
				val3.set_SmallImageText(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"smalltext")).ToString());
				val2.set_Assets(val3);
				obj.SetPresence(val2);
				openChildForm(new skinsV2());
			}
			else
			{
				MessageBox.Show("This Tab is currently disabled", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void PatchNotes_MouseDown(object sender, MouseEventArgs e)
		{
			drag = true;
			start_point = new Point(e.X, e.Y);
		}

		private void PatchNotes_MouseMove(object sender, MouseEventArgs e)
		{
			if (drag)
			{
				Point point = PointToScreen(e.Location);
				base.Location = new Point(point.X - start_point.X, point.Y - start_point.Y);
			}
		}

		private void PatchNotes_MouseUp(object sender, MouseEventArgs e)
		{
			drag = false;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("Lele Swapper");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		public static bool IsValidJson(string strInput)
		{
			strInput = strInput.Trim();
			if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || (strInput.StartsWith("[") && strInput.EndsWith("]")))
			{
				try
				{
					JToken.Parse(strInput);
					return true;
				}
				catch (Exception)
				{
					return false;
				}
			}
			return false;
		}

		public static string GetEpicDirectory()
		{
			return Directory.Exists("C:\\ProgramData\\Epic") ? "C:\\ProgramData\\Epic" : (Directory.Exists("D:\\ProgramData\\Epic") ? "D:\\ProgramData\\Epic" : (Directory.Exists("E:\\ProgramData\\Epic") ? "E:\\ProgramData\\Epic" : "F:\\ProgramData\\Epic"));
		}

		public static bool DatFileExists()
		{
			return File.Exists(GetEpicDirectory() + "\\UnrealEngineLauncher\\LauncherInstalled.dat");
		}

		public static void LocateFortnitePath()
		{
			if (!DatFileExists())
			{
				return;
			}
			string text = File.ReadAllText(GetEpicDirectory() + "\\UnrealEngineLauncher\\LauncherInstalled.dat");
			if (!IsValidJson(text))
			{
				return;
			}
			JToken val = JsonConvert.DeserializeObject<JToken>(text);
			if (val == null)
			{
				return;
			}
			JArray val2 = Extensions.Value<JArray>((IEnumerable<JToken>)val.get_Item((object)"InstallationList"));
			foreach (JToken item in val2)
			{
				if (string.Equals(Extensions.Value<string>((IEnumerable<JToken>)item.get_Item((object)"AppName")), "Fortnite"))
				{
					string paksLocation = Extensions.Value<string>((IEnumerable<JToken>)item.get_Item((object)"InstallLocation")) ?? "";
					Lele_Swapper.Properties.Settings.Default.PaksLocation = paksLocation;
					Lele_Swapper.Properties.Settings.Default.Save();
				}
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void SettingButton_Click(object sender, EventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_0136: Expected O, but got Unknown
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
			DiscordRpcClient obj = client;
			RichPresence val2 = new RichPresence();
			val2.set_Details(((object)val.get_Item("status").get_Item((object)"version")).ToString() + " - " + ((object)val.get_Item("rpc").get_Item((object)"tabs").get_Item((object)"settings")).ToString());
			val2.set_State("User: " + Environment.UserName);
			Assets val3 = new Assets();
			val3.set_LargeImageKey(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"bigicon")).ToString());
			val3.set_LargeImageText(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"bigtext")).ToString());
			val3.set_SmallImageKey(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"smallicon")).ToString());
			val3.set_SmallImageText(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"smalltext")).ToString());
			val2.set_Assets(val3);
			obj.SetPresence(val2);
			openChildForm(new Settings());
		}

		private void v14_20_items_Click(object sender, EventArgs e)
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Expected O, but got Unknown
			//IL_0169: Expected O, but got Unknown
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
			if (((object)val.get_Item("v2").get_Item((object)"paks").get_Item((object)"status")).ToString() == "enabled")
			{
				DiscordRpcClient obj = client;
				RichPresence val2 = new RichPresence();
				val2.set_Details(((object)val.get_Item("status").get_Item((object)"version")).ToString() + " - " + ((object)val.get_Item("rpc").get_Item((object)"tabs").get_Item((object)"14_20")).ToString());
				val2.set_State("User: " + Environment.UserName);
				Assets val3 = new Assets();
				val3.set_LargeImageKey(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"bigicon")).ToString());
				val3.set_LargeImageText(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"bigtext")).ToString());
				val3.set_SmallImageKey(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"smallicon")).ToString());
				val3.set_SmallImageText(((object)val.get_Item("rpc").get_Item((object)"general").get_Item((object)"smalltext")).ToString());
				val2.set_Assets(val3);
				obj.SetPresence(val2);
				openChildForm(new _14_20());
			}
			else
			{
				MessageBox.Show("This Tab is currently disabled", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void TimerEventProcessor(object sender, EventArgs e)
		{
			try
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://textbin.net/raw/RXGgQJrhTi");
				Lele_Swapper.Properties.Settings.Default.api_data = text.ToString();
				Lele_Swapper.Properties.Settings.Default.Save();
				Console.WriteLine("Updated API Cache for " + DateTime.UtcNow.ToString());
			}
			catch
			{
				MessageBox.Show("Failed To Update Cache", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lele_Swapper.PatchNotes));
			panel2 = new System.Windows.Forms.Panel();
			leleswapper_logo = new System.Windows.Forms.PictureBox();
			username = new System.Windows.Forms.Label();
			SkinButton = new System.Windows.Forms.PictureBox();
			SettingButton = new System.Windows.Forms.PictureBox();
			FormPanel = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			panel1 = new System.Windows.Forms.Panel();
			minimize = new System.Windows.Forms.PictureBox();
			close = new System.Windows.Forms.PictureBox();
			timer1 = new System.Windows.Forms.Timer(components);
			v14_20_items = new System.Windows.Forms.PictureBox();
			System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)leleswapper_logo).BeginInit();
			((System.ComponentModel.ISupportInitialize)SkinButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)SettingButton).BeginInit();
			FormPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
			((System.ComponentModel.ISupportInitialize)close).BeginInit();
			((System.ComponentModel.ISupportInitialize)v14_20_items).BeginInit();
			SuspendLayout();
			pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			pictureBox.Image = (System.Drawing.Image)resources.GetObject("MoveableImage.Image");
			pictureBox.Location = new System.Drawing.Point(-12, -17);
			pictureBox.Name = "MoveableImage";
			pictureBox.Size = new System.Drawing.Size(1001, 11);
			pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox.TabIndex = 55;
			pictureBox.TabStop = false;
			panel2.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
			panel2.Controls.Add(v14_20_items);
			panel2.Controls.Add(leleswapper_logo);
			panel2.Controls.Add(username);
			panel2.Controls.Add(pictureBox);
			panel2.Controls.Add(SkinButton);
			panel2.Controls.Add(SettingButton);
			panel2.Location = new System.Drawing.Point(12, 12);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(219, 600);
			panel2.TabIndex = 60;
			leleswapper_logo.Cursor = System.Windows.Forms.Cursors.Hand;
			leleswapper_logo.Location = new System.Drawing.Point(3, 0);
			leleswapper_logo.Name = "leleswapper_logo";
			leleswapper_logo.Size = new System.Drawing.Size(213, 64);
			leleswapper_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			leleswapper_logo.TabIndex = 105;
			leleswapper_logo.TabStop = false;
			username.AutoSize = true;
			username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			username.Location = new System.Drawing.Point(10, 570);
			username.Name = "username";
			username.Size = new System.Drawing.Size(100, 20);
			username.TabIndex = 104;
			username.Text = "{username}";
			SkinButton.Cursor = System.Windows.Forms.Cursors.Hand;
			SkinButton.Location = new System.Drawing.Point(10, 70);
			SkinButton.Name = "SkinButton";
			SkinButton.Size = new System.Drawing.Size(94, 94);
			SkinButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			SkinButton.TabIndex = 47;
			SkinButton.TabStop = false;
			SkinButton.Click += new System.EventHandler(SkinButton_Click);
			SettingButton.Cursor = System.Windows.Forms.Cursors.Hand;
			SettingButton.ErrorImage = null;
			SettingButton.InitialImage = null;
			SettingButton.Location = new System.Drawing.Point(10, 470);
			SettingButton.Name = "SettingButton";
			SettingButton.Size = new System.Drawing.Size(94, 94);
			SettingButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			SettingButton.TabIndex = 51;
			SettingButton.TabStop = false;
			SettingButton.Click += new System.EventHandler(SettingButton_Click);
			FormPanel.BackColor = System.Drawing.Color.Transparent;
			FormPanel.Controls.Add(pictureBox1);
			FormPanel.Location = new System.Drawing.Point(237, 37);
			FormPanel.Name = "FormPanel";
			FormPanel.Size = new System.Drawing.Size(764, 575);
			FormPanel.TabIndex = 61;
			pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(729, -35);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(32, 32);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 54;
			pictureBox1.TabStop = false;
			panel1.BackColor = System.Drawing.Color.Transparent;
			panel1.Controls.Add(minimize);
			panel1.Controls.Add(close);
			panel1.Location = new System.Drawing.Point(921, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(80, 35);
			panel1.TabIndex = 62;
			minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			minimize.Location = new System.Drawing.Point(10, 3);
			minimize.Name = "minimize";
			minimize.Size = new System.Drawing.Size(32, 32);
			minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			minimize.TabIndex = 55;
			minimize.TabStop = false;
			minimize.Click += new System.EventHandler(pictureBox4_Click);
			close.Cursor = System.Windows.Forms.Cursors.Hand;
			close.Location = new System.Drawing.Point(44, 3);
			close.Name = "close";
			close.Size = new System.Drawing.Size(32, 32);
			close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			close.TabIndex = 54;
			close.TabStop = false;
			close.Click += new System.EventHandler(pictureBox2_Click);
			v14_20_items.Cursor = System.Windows.Forms.Cursors.Hand;
			v14_20_items.Location = new System.Drawing.Point(10, 170);
			v14_20_items.Name = "v14_20_items";
			v14_20_items.Size = new System.Drawing.Size(94, 94);
			v14_20_items.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			v14_20_items.TabIndex = 106;
			v14_20_items.TabStop = false;
			v14_20_items.Click += new System.EventHandler(v14_20_items_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Teal;
			base.ClientSize = new System.Drawing.Size(1009, 624);
			base.Controls.Add(panel1);
			base.Controls.Add(FormPanel);
			base.Controls.Add(panel2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "PatchNotes";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Lele Swapper";
			base.MouseDown += new System.Windows.Forms.MouseEventHandler(PatchNotes_MouseDown);
			base.MouseMove += new System.Windows.Forms.MouseEventHandler(PatchNotes_MouseMove);
			base.MouseUp += new System.Windows.Forms.MouseEventHandler(PatchNotes_MouseUp);
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)leleswapper_logo).EndInit();
			((System.ComponentModel.ISupportInitialize)SkinButton).EndInit();
			((System.ComponentModel.ISupportInitialize)SettingButton).EndInit();
			FormPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)minimize).EndInit();
			((System.ComponentModel.ISupportInitialize)close).EndInit();
			((System.ComponentModel.ISupportInitialize)v14_20_items).EndInit();
			ResumeLayout(false);
		}
	}
}
