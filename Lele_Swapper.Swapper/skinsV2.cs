using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Lele_Swapper.Properties;
using Newtonsoft.Json.Linq;

namespace Lele_Swapper.Swapper
{
	public class skinsV2 : Form
	{
		private bool showswaptime = true;

		private IContainer components = null;

		public skinsV2()
		{
			InitializeComponent();
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

		private void Image_Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
			JToken val2 = val.get_Item("v2").get_Item((object)"skins").get_Item((object)"items");
			string name = pictureBox.Name;
			string s = name.Replace("pictureBox", "");
			Lele_Swapper.Properties.Settings.Default.swap_item_data = ((object)val2.get_Item((object)int.Parse(s))).ToString();
			Lele_Swapper.Properties.Settings.Default.Save();
			(from form in Application.OpenForms.OfType<Form>()
				where string.Equals(form.Name, "CustomPaksTemplate")
				select form).ToList().ForEach(delegate(Form form)
			{
				form.Close();
			});
			(from form in Application.OpenForms.OfType<Form>()
				where string.Equals(form.Name, "skinsV2Template")
				select form).ToList().ForEach(delegate(Form form)
			{
				form.Close();
			});
			new skinsV2Template().Show();
			skinsV2Template skinsV2Template = (skinsV2Template)Application.OpenForms["skinsV2Template"];
			skinsV2Template.Text = ((object)val2.get_Item((object)int.Parse(s)).get_Item((object)"name")).ToString();
			WebRequest webRequest = WebRequest.Create(((object)val2.get_Item((object)int.Parse(s)).get_Item((object)"defaultIcon")).ToString());
			WebResponse response = webRequest.GetResponse();
			using (Stream stream = response.GetResponseStream())
			{
				skinsV2Template.pictureBox1.Image = Image.FromStream(stream);
			}
			WebRequest webRequest2 = WebRequest.Create(((object)val2.get_Item((object)int.Parse(s)).get_Item((object)"swappedIcon")).ToString());
			WebResponse response2 = webRequest2.GetResponse();
			using (Stream stream2 = response2.GetResponseStream())
			{
				skinsV2Template.pictureBox3.Image = Image.FromStream(stream2);
			}
			WebRequest webRequest3 = WebRequest.Create(((object)val.get_Item("icons").get_Item((object)"pfeil")).ToString());
			WebResponse response3 = webRequest3.GetResponse();
			using (Stream stream3 = response3.GetResponseStream())
			{
				skinsV2Template.showcase_to.Image = Image.FromStream(stream3);
			}
			if (((object)val2.get_Item((object)int.Parse(s)).get_Item((object)"note")).ToString() != "")
			{
				MessageBox.Show(((object)val2.get_Item((object)int.Parse(s)).get_Item((object)"note")).ToString(), "Lele Swapper");
			}
		}

		private void V2_Load(object sender, EventArgs e)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
			JToken val2 = val.get_Item("v2").get_Item((object)"skins").get_Item((object)"items");
			int num = 7;
			int num2 = 37;
			for (int i = 0; i < ((IEnumerable<JToken>)val2).ToArray().Length; i++)
			{
				PictureBox pictureBox = new PictureBox();
				pictureBox.Location = new Point(num, num2);
				pictureBox.Name = "pictureBox" + i;
				pictureBox.Cursor = Cursors.Hand;
				pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				pictureBox.Size = new Size(120, 120);
				pictureBox.Click += Image_Click;
				WebRequest webRequest = WebRequest.Create(((object)val2.get_Item((object)i).get_Item((object)"swappedIcon")).ToString());
				WebResponse response = webRequest.GetResponse();
				using (Stream stream = response.GetResponseStream())
				{
					pictureBox.Image = Image.FromStream(stream);
				}
				base.Controls.Add(pictureBox);
				num += 120;
				if (num > 700)
				{
					num2 += 120;
					num = 0;
				}
			}
			stopwatch.Stop();
			int num3 = (int)stopwatch.Elapsed.TotalMilliseconds;
			if (showswaptime)
			{
				MessageBox.Show("Succesfully Loaded in " + num3 + "ms");
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
			SuspendLayout();
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Teal;
			base.ClientSize = new System.Drawing.Size(764, 575);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "skinsV2";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "SkinsV2";
			base.Load += new System.EventHandler(V2_Load);
			ResumeLayout(false);
		}
	}
}
