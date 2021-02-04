using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Lele_Swapper.Properties;
using Newtonsoft.Json.Linq;

namespace Lele_Swapper.Swapper
{
	public class skinsV2Template : Form
	{
		private bool showswaptime = true;

		private IContainer components = null;

		private Panel panel1;

		private Label LOG;

		public PictureBox pictureBox1;

		private Button revert;

		private Button convert;

		public PictureBox pictureBox3;

		private BackgroundWorker backgroundWorker1;

		private BackgroundWorker backgroundWorker2;

		public PictureBox showcase_to;

		public skinsV2Template()
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

		public void ReplaceBytes(string path, byte[] search, byte[] replace, int offsetstart)
		{
			Stream stream = File.OpenRead(path);
			foreach (long item in researcher.FindPosition(stream, 0, offsetstart, search))
			{
				stream.Close();
				BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Open, FileAccess.ReadWrite));
				binaryWriter.BaseStream.Seek(item, SeekOrigin.Begin);
				binaryWriter.Write(replace);
				binaryWriter.Close();
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

		public static byte[] Combine(byte[] first, byte[] second)
		{
			byte[] array = new byte[first.Length + second.Length];
			Buffer.BlockCopy(first, 0, array, 0, first.Length);
			Buffer.BlockCopy(second, 0, array, first.Length, second.Length);
			return array;
		}

		private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			Control.CheckForIllegalCrossThreadCalls = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.swap_item_data);
			JToken val2 = val.get_Item("swaps");
			JArray val3 = (JArray)val2;
			int count = ((JContainer)val3).get_Count();
			for (int i = 0; i < count; i++)
			{
				string text = ((object)val2.get_Item((object)i).get_Item((object)"normal")).ToString();
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				string text2 = ((object)val2.get_Item((object)i).get_Item((object)"swaped")).ToString();
				byte[] array = Encoding.UTF8.GetBytes(text2);
				for (int num = text.Length - text2.Length; num > 0; num--)
				{
					byte[] second = new byte[1];
					array = Combine(array, second);
				}
				string str = ((object)val2.get_Item((object)i).get_Item((object)"file")).ToString();
				string str2 = ((object)val2.get_Item((object)i).get_Item((object)"log")).ToString();
				int offsetstart = int.Parse(((object)val2.get_Item((object)i).get_Item((object)"offset")).ToString());
				ReplaceBytes(Lele_Swapper.Properties.Settings.Default.PaksLocation + "/FortniteGame/Content/Paks/" + str, bytes, array, offsetstart);
				LOG.Text = "[LOG] Converted " + str2;
			}
			stopwatch.Stop();
			int num2 = (int)stopwatch.Elapsed.TotalMilliseconds;
			if (showswaptime)
			{
				MessageBox.Show("Swapped in " + num2 + "ms");
				LOG.Text = "[LOG] Finished!";
			}
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			Control.CheckForIllegalCrossThreadCalls = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			JObject val = JObject.Parse(Lele_Swapper.Properties.Settings.Default.swap_item_data);
			JToken val2 = val.get_Item("swaps");
			JArray val3 = (JArray)val2;
			int count = ((JContainer)val3).get_Count();
			for (int i = 0; i < count; i++)
			{
				string text = ((object)val2.get_Item((object)i).get_Item((object)"normal")).ToString();
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				string text2 = ((object)val2.get_Item((object)i).get_Item((object)"swaped")).ToString();
				byte[] array = Encoding.UTF8.GetBytes(text2);
				for (int num = text.Length - text2.Length; num > 0; num--)
				{
					byte[] second = new byte[1];
					array = Combine(array, second);
				}
				string str = ((object)val2.get_Item((object)i).get_Item((object)"file")).ToString();
				string str2 = ((object)val2.get_Item((object)i).get_Item((object)"log")).ToString();
				int offsetstart = int.Parse(((object)val2.get_Item((object)i).get_Item((object)"offset")).ToString());
				ReplaceBytes(Lele_Swapper.Properties.Settings.Default.PaksLocation + "/FortniteGame/Content/Paks/" + str, array, bytes, offsetstart);
				LOG.Text = "[LOG] Reverted " + str2;
			}
			stopwatch.Stop();
			int num2 = (int)stopwatch.Elapsed.TotalMilliseconds;
			if (showswaptime)
			{
				MessageBox.Show("Reverted in " + num2 + "ms");
				LOG.Text = "[LOG] Finished!";
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lele_Swapper.Swapper.skinsV2Template));
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
			panel1.TabIndex = 81;
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
			backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker1_DoWork_1);
			backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker2_DoWork);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Teal;
			base.ClientSize = new System.Drawing.Size(405, 259);
			base.Controls.Add(panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MaximumSize = new System.Drawing.Size(421, 298);
			MinimumSize = new System.Drawing.Size(421, 298);
			base.Name = "skinsV2Template";
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
