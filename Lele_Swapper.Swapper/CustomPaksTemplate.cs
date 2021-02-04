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
	public class CustomPaksTemplate : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label LOG;

		public PictureBox pictureBox1;

		public PictureBox showcase_to;

		private Button revert;

		private Button convert;

		public PictureBox pictureBox3;

		private BackgroundWorker backgroundWorker1;

		private BackgroundWorker backgroundWorker2;

		public CustomPaksTemplate()
		{
			InitializeComponent();
			switch (Lele_Swapper.Properties.Settings.Default.Themes)
			{
			case "Red":
				BackColor = Color.DarkRed;
				break;
			case "Default":
				BackColor = Color.Teal;
				break;
			case "Green":
				BackColor = Color.Green;
				break;
			case "Purple":
				BackColor = Color.Purple;
				break;
			}
		}

		private void convert_Click(object sender, EventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();
		}

		private void revert_Click(object sender, EventArgs e)
		{
			backgroundWorker2.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
				JObject val2 = JObject.Parse(Lele_Swapper.Properties.Settings.Default.swap_item_data);
				JToken val3 = val.get_Item("v2").get_Item((object)"paks").get_Item((object)"sig");
				JToken val4 = val.get_Item("v2").get_Item((object)"paks").get_Item((object)"fileName");
				JToken val5 = val2.get_Item("pak");
				WebClient webClient = new WebClient();
				webClient.DownloadFile(((object)val5).ToString(), Lele_Swapper.Properties.Settings.Default.CustomPaksPath + "/" + ((object)val4)?.ToString() + ".pak");
				LOG.Text = "[LOG] Downloaded .pak";
				WebClient webClient2 = new WebClient();
				webClient2.DownloadFile(((object)val3).ToString(), Lele_Swapper.Properties.Settings.Default.CustomPaksPath + "/" + ((object)val4)?.ToString() + ".sig");
				LOG.Text = "[LOG] Downloaded .sig";
				stopwatch.Stop();
				MessageBox.Show("Swapped in " + (int)stopwatch.Elapsed.TotalMilliseconds + "ms");
				LOG.Text = "[LOG] Finished!";
			}
			catch
			{
				MessageBox.Show("Error while downloading files", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			try
			{
				JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.api_data);
				JToken val2 = val.get_Item("v2").get_Item((object)"paks").get_Item((object)"fileName");
				string path = Lele_Swapper.Properties.Settings.Default.CustomPaksPath + "/" + ((object)val2)?.ToString() + ".sig";
				string path2 = Lele_Swapper.Properties.Settings.Default.CustomPaksPath + "/" + ((object)val2)?.ToString() + ".pak";
				if (File.Exists(path) || File.Exists(path2))
				{
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					if (File.Exists(path2))
					{
						File.Delete(path2);
						LOG.Text = "[LOG] Removed .pak";
					}
					if (File.Exists(path))
					{
						File.Delete(path);
						LOG.Text = "[LOG] Removed .sig";
					}
					stopwatch.Stop();
					MessageBox.Show("Reverted in " + (int)stopwatch.Elapsed.TotalMilliseconds + "ms");
					LOG.Text = "[LOG] Finished!";
				}
				if (!File.Exists(path) && !File.Exists(path2))
				{
					MessageBox.Show("No Files to remove found", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch
			{
				MessageBox.Show("Error while downloading files", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lele_Swapper.Swapper.CustomPaksTemplate));
			panel1 = new System.Windows.Forms.Panel();
			LOG = new System.Windows.Forms.Label();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			showcase_to = new System.Windows.Forms.PictureBox();
			revert = new System.Windows.Forms.Button();
			convert = new System.Windows.Forms.Button();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)showcase_to).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			panel1.Controls.Add(LOG);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(showcase_to);
			panel1.Controls.Add(revert);
			panel1.Controls.Add(convert);
			panel1.Controls.Add(pictureBox3);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(404, 259);
			panel1.TabIndex = 82;
			LOG.AutoSize = true;
			LOG.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			LOG.Location = new System.Drawing.Point(60, 214);
			LOG.Name = "LOG";
			LOG.Size = new System.Drawing.Size(61, 22);
			LOG.TabIndex = 69;
			LOG.Text = "[LOG]";
			LOG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			pictureBox1.Location = new System.Drawing.Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(128, 124);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 50;
			pictureBox1.TabStop = false;
			showcase_to.Location = new System.Drawing.Point(137, 3);
			showcase_to.Name = "showcase_to";
			showcase_to.Size = new System.Drawing.Size(128, 124);
			showcase_to.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			showcase_to.TabIndex = 52;
			showcase_to.TabStop = false;
			revert.Cursor = System.Windows.Forms.Cursors.Hand;
			revert.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			revert.Location = new System.Drawing.Point(211, 161);
			revert.Name = "revert";
			revert.Size = new System.Drawing.Size(135, 50);
			revert.TabIndex = 66;
			revert.Text = "Revert";
			revert.UseVisualStyleBackColor = true;
			revert.Click += new System.EventHandler(revert_Click);
			convert.Cursor = System.Windows.Forms.Cursors.Hand;
			convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			convert.Location = new System.Drawing.Point(56, 161);
			convert.Name = "convert";
			convert.Size = new System.Drawing.Size(135, 50);
			convert.TabIndex = 65;
			convert.Text = "Convert";
			convert.UseVisualStyleBackColor = true;
			convert.Click += new System.EventHandler(convert_Click);
			pictureBox3.BackColor = System.Drawing.Color.Transparent;
			pictureBox3.Location = new System.Drawing.Point(271, 3);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(128, 124);
			pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 53;
			pictureBox3.TabStop = false;
			backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker1_DoWork);
			backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker2_DoWork);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Teal;
			base.ClientSize = new System.Drawing.Size(405, 259);
			base.Controls.Add(panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MaximumSize = new System.Drawing.Size(421, 298);
			MinimumSize = new System.Drawing.Size(421, 298);
			base.Name = "CustomPaksTemplate";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "{name}";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)showcase_to).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
		}
	}
}
