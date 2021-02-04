using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Lele_Swapper.Properties;
using Newtonsoft.Json.Linq;

namespace Lele_Swapper.Swapper
{
	public class Credits : Form
	{
		private IContainer components = null;

		private Panel FormPanel;

		private PictureBox discord;

		private PictureBox twitter;

		private PictureBox instagram;

		private PictureBox tiktok;

		private PictureBox youtube;

		private Label text;

		private Label label_0;

		private Panel panel1;

		public Credits()
		{
			InitializeComponent();
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
			string text = ((object)val.get_Item("news").get_Item((object)"header")).ToString();
			string text2 = ((object)val.get_Item("news").get_Item((object)"body")).ToString();
			label_0.Text = text;
			this.text.Text = text2;
			WebRequest webRequest = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"discord")).ToString());
			WebResponse response = webRequest.GetResponse();
			using (Stream stream = response.GetResponseStream())
			{
				discord.Image = Image.FromStream(stream);
			}
			WebRequest webRequest2 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"tiktok")).ToString());
			WebResponse response2 = webRequest2.GetResponse();
			using (Stream stream2 = response2.GetResponseStream())
			{
				tiktok.Image = Image.FromStream(stream2);
			}
			WebRequest webRequest3 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"youtube")).ToString());
			WebResponse response3 = webRequest3.GetResponse();
			using (Stream stream3 = response3.GetResponseStream())
			{
				youtube.Image = Image.FromStream(stream3);
			}
			WebRequest webRequest4 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"instagram")).ToString());
			WebResponse response4 = webRequest4.GetResponse();
			using (Stream stream4 = response4.GetResponseStream())
			{
				instagram.Image = Image.FromStream(stream4);
			}
			WebRequest webRequest5 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"twitter")).ToString());
			WebResponse response5 = webRequest5.GetResponse();
			using (Stream stream5 = response5.GetResponseStream())
			{
				twitter.Image = Image.FromStream(stream5);
			}
			if (Lele_Swapper.Properties.Settings.Default.Themes == "Purple")
			{
				BackColor = Color.Purple;
			}
			if (Lele_Swapper.Properties.Settings.Default.Themes == "Green")
			{
				BackColor = Color.Green;
			}
			if (Lele_Swapper.Properties.Settings.Default.Themes == "Default")
			{
				BackColor = Color.Teal;
			}
			if (Lele_Swapper.Properties.Settings.Default.Themes == "Red")
			{
				BackColor = Color.DarkRed;
			}
		}

		private void pictureBox5_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/MpJVfFg");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/wdpw5sM");
		}

		private void pictureBox10_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.tiktok.com/@leleswapper");
		}

		private void pictureBox8_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/c/LeleDerGrasshalm");
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/realgrasshalm/");
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			Process.Start("https://twitter.com/RealGrasshalm2");
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
			FormPanel = new System.Windows.Forms.Panel();
			panel1 = new System.Windows.Forms.Panel();
			label_0 = new System.Windows.Forms.Label();
			text = new System.Windows.Forms.Label();
			discord = new System.Windows.Forms.PictureBox();
			twitter = new System.Windows.Forms.PictureBox();
			instagram = new System.Windows.Forms.PictureBox();
			tiktok = new System.Windows.Forms.PictureBox();
			youtube = new System.Windows.Forms.PictureBox();
			FormPanel.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)discord).BeginInit();
			((System.ComponentModel.ISupportInitialize)twitter).BeginInit();
			((System.ComponentModel.ISupportInitialize)instagram).BeginInit();
			((System.ComponentModel.ISupportInitialize)tiktok).BeginInit();
			((System.ComponentModel.ISupportInitialize)youtube).BeginInit();
			SuspendLayout();
			FormPanel.BackColor = System.Drawing.Color.Transparent;
			FormPanel.Controls.Add(panel1);
			FormPanel.Controls.Add(discord);
			FormPanel.Controls.Add(twitter);
			FormPanel.Controls.Add(instagram);
			FormPanel.Controls.Add(tiktok);
			FormPanel.Controls.Add(youtube);
			FormPanel.Location = new System.Drawing.Point(0, 0);
			FormPanel.Name = "FormPanel";
			FormPanel.Size = new System.Drawing.Size(764, 575);
			FormPanel.TabIndex = 62;
			panel1.AutoScroll = true;
			panel1.Controls.Add(label_0);
			panel1.Controls.Add(text);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(752, 487);
			panel1.TabIndex = 34;
			label_0.AutoSize = true;
			label_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label_0.Location = new System.Drawing.Point(3, 9);
			label_0.Name = "überschrift";
			label_0.Size = new System.Drawing.Size(106, 42);
			label_0.TabIndex = 32;
			label_0.Text = "{title}";
			label_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			text.AutoSize = true;
			text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			text.Location = new System.Drawing.Point(3, 51);
			text.Name = "text";
			text.Size = new System.Drawing.Size(91, 31);
			text.TabIndex = 33;
			text.Text = "{body}";
			text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			discord.Cursor = System.Windows.Forms.Cursors.Hand;
			discord.Location = new System.Drawing.Point(12, 505);
			discord.Name = "discord";
			discord.Size = new System.Drawing.Size(70, 70);
			discord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			discord.TabIndex = 29;
			discord.TabStop = false;
			discord.Click += new System.EventHandler(pictureBox1_Click);
			twitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			twitter.Cursor = System.Windows.Forms.Cursors.Hand;
			twitter.Location = new System.Drawing.Point(316, 505);
			twitter.Name = "twitter";
			twitter.Size = new System.Drawing.Size(70, 70);
			twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			twitter.TabIndex = 25;
			twitter.TabStop = false;
			twitter.Click += new System.EventHandler(pictureBox9_Click);
			instagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			instagram.Cursor = System.Windows.Forms.Cursors.Hand;
			instagram.Location = new System.Drawing.Point(240, 505);
			instagram.Name = "instagram";
			instagram.Size = new System.Drawing.Size(70, 70);
			instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			instagram.TabIndex = 28;
			instagram.TabStop = false;
			instagram.Click += new System.EventHandler(pictureBox11_Click);
			tiktok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			tiktok.Cursor = System.Windows.Forms.Cursors.Hand;
			tiktok.Location = new System.Drawing.Point(88, 505);
			tiktok.Name = "tiktok";
			tiktok.Size = new System.Drawing.Size(70, 70);
			tiktok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			tiktok.TabIndex = 27;
			tiktok.TabStop = false;
			tiktok.Click += new System.EventHandler(pictureBox10_Click_1);
			youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			youtube.Cursor = System.Windows.Forms.Cursors.Hand;
			youtube.Location = new System.Drawing.Point(164, 505);
			youtube.Name = "youtube";
			youtube.Size = new System.Drawing.Size(70, 70);
			youtube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			youtube.TabIndex = 26;
			youtube.TabStop = false;
			youtube.Click += new System.EventHandler(pictureBox8_Click_1);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Teal;
			base.ClientSize = new System.Drawing.Size(764, 575);
			base.Controls.Add(FormPanel);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Credits";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Credits";
			FormPanel.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)discord).EndInit();
			((System.ComponentModel.ISupportInitialize)twitter).EndInit();
			((System.ComponentModel.ISupportInitialize)instagram).EndInit();
			((System.ComponentModel.ISupportInitialize)tiktok).EndInit();
			((System.ComponentModel.ISupportInitialize)youtube).EndInit();
			ResumeLayout(false);
		}
	}
}
