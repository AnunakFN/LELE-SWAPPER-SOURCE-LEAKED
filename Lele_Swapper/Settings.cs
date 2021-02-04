using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Lele_Swapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Lele_Swapper
{
	public class Settings : Form
	{
		private IContainer components = null;

		private Button button1;

		private Button button3;

		private Button button4;

		private Panel panel1;

		private Button button5;

		private Button button7;

		private Button button6;

		private Label label1;

		private Label label2;

		private Button openpaks;

		private Label label4;

		private Button button2;

		private Label label5;

		private FolderBrowserDialog folderBrowserDialog1;

		private RichTextBox customPaksPath;

		private RichTextBox MainPaksPath;

		public Settings()
		{
			InitializeComponent();
			switch (Lele_Swapper.Properties.Settings.Default.Themes)
			{
			case "Red":
				panel1.BackColor = Color.DarkRed;
				customPaksPath.BackColor = Color.DarkRed;
				MainPaksPath.BackColor = Color.DarkRed;
				break;
			case "Default":
				panel1.BackColor = Color.Teal;
				customPaksPath.BackColor = Color.Teal;
				MainPaksPath.BackColor = Color.Teal;
				break;
			case "Green":
				panel1.BackColor = Color.Green;
				customPaksPath.BackColor = Color.Green;
				MainPaksPath.BackColor = Color.Green;
				break;
			case "Purple":
				panel1.BackColor = Color.Purple;
				customPaksPath.BackColor = Color.Purple;
				MainPaksPath.BackColor = Color.Purple;
				break;
			}
			MainPaksPath.Text = Lele_Swapper.Properties.Settings.Default.PaksLocation.Replace("\\", "/");
			customPaksPath.Text = Lele_Swapper.Properties.Settings.Default.CustomPaksPath.Replace("\\", "/");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string path = Lele_Swapper.Properties.Settings.Default.PaksLocation + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_EAC.exe";
			if (File.Exists(path))
			{
				Process.Start(Lele_Swapper.Properties.Settings.Default.PaksLocation + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_EAC.exe");
				Process[] processesByName = Process.GetProcessesByName("Lele Swapper");
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
			}
			if (!File.Exists(path))
			{
				MessageBox.Show("Cannot find 'FortniteClient-Win64-Shipping_EAC' at " + Lele_Swapper.Properties.Settings.Default.PaksLocation + "/FortniteGame/Binaries/Win64/", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			processesByName = Process.GetProcessesByName("FortniteLauncher");
			for (int j = 0; j < processesByName.Length; j++)
			{
				processesByName[j].Kill();
			}
			processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_EAC");
			for (int k = 0; k < processesByName.Length; k++)
			{
				processesByName[k].Kill();
			}
			processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_BE");
			for (int l = 0; l < processesByName.Length; l++)
			{
				processesByName[l].Kill();
			}
			processesByName = Process.GetProcessesByName("FortniteLauncher");
			for (int m = 0; m < processesByName.Length; m++)
			{
				processesByName[m].Kill();
			}
			processesByName = Process.GetProcessesByName("umodel");
			for (int n = 0; n < processesByName.Length; n++)
			{
				processesByName[n].Kill();
			}
			processesByName = Process.GetProcessesByName("FModel");
			for (int num = 0; num < processesByName.Length; num++)
			{
				processesByName[num].Kill();
			}
			processesByName = Process.GetProcessesByName("Pro Swapper");
			for (int num2 = 0; num2 < processesByName.Length; num2++)
			{
				processesByName[num2].Kill();
			}
			processesByName = Process.GetProcessesByName("hxD");
			for (int num3 = 0; num3 < processesByName.Length; num3++)
			{
				processesByName[num3].Kill();
			}
			processesByName = Process.GetProcessesByName("EpicGamesLauncher");
			for (int num4 = 0; num4 < processesByName.Length; num4++)
			{
				processesByName[num4].Kill();
			}
			MessageBox.Show("Succesfully Closed Fortnite", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			Lele_Swapper.Properties.Settings.Default.Themes = "Purple";
			Lele_Swapper.Properties.Settings.Default.Save();
			panel1.BackColor = Color.Purple;
			customPaksPath.BackColor = Color.Purple;
			MainPaksPath.BackColor = Color.Purple;
			PatchNotes patchNotes = (PatchNotes)Application.OpenForms["PatchNotes"];
			patchNotes.panel2.BackColor = Color.FromArgb(192, 0, 192);
			patchNotes.BackColor = Color.Purple;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Lele_Swapper.Properties.Settings.Default.Themes = "Default";
			Lele_Swapper.Properties.Settings.Default.Save();
			panel1.BackColor = Color.Teal;
			customPaksPath.BackColor = Color.Teal;
			MainPaksPath.BackColor = Color.Teal;
			PatchNotes patchNotes = (PatchNotes)Application.OpenForms["PatchNotes"];
			patchNotes.panel2.BackColor = Color.FromArgb(0, 192, 192);
			patchNotes.BackColor = Color.Teal;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Lele_Swapper.Properties.Settings.Default.Themes = "Green";
			Lele_Swapper.Properties.Settings.Default.Save();
			panel1.BackColor = Color.Green;
			customPaksPath.BackColor = Color.Green;
			MainPaksPath.BackColor = Color.Green;
			PatchNotes patchNotes = (PatchNotes)Application.OpenForms["PatchNotes"];
			patchNotes.panel2.BackColor = Color.FromArgb(0, 192, 0);
			patchNotes.BackColor = Color.Green;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Lele_Swapper.Properties.Settings.Default.Themes = "Red";
			Lele_Swapper.Properties.Settings.Default.Save();
			panel1.BackColor = Color.DarkRed;
			customPaksPath.BackColor = Color.DarkRed;
			MainPaksPath.BackColor = Color.DarkRed;
			PatchNotes patchNotes = (PatchNotes)Application.OpenForms["PatchNotes"];
			patchNotes.panel2.BackColor = Color.FromArgb(192, 0, 0);
			patchNotes.BackColor = Color.DarkRed;
		}

		private void openpaks_Click(object sender, EventArgs e)
		{
			Process.Start(Lele_Swapper.Properties.Settings.Default.PaksLocation + "/FortniteGame/Content/Paks");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Invalid comparison between Unknown and I4
			CommonOpenFileDialog val = new CommonOpenFileDialog();
			((CommonFileDialog)val).set_InitialDirectory("C:\\");
			val.set_IsFolderPicker(true);
			if ((int)((CommonFileDialog)val).ShowDialog() == 1)
			{
				Lele_Swapper.Properties.Settings.Default.CustomPaksPath = ((CommonFileDialog)val).get_FileName();
				Lele_Swapper.Properties.Settings.Default.Save();
				customPaksPath.Text = ((CommonFileDialog)val).get_FileName();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lele_Swapper.Settings));
			button1 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			panel1 = new System.Windows.Forms.Panel();
			button2 = new System.Windows.Forms.Button();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			openpaks = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			button7 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			customPaksPath = new System.Windows.Forms.RichTextBox();
			MainPaksPath = new System.Windows.Forms.RichTextBox();
			panel1.SuspendLayout();
			SuspendLayout();
			button1.BackColor = System.Drawing.Color.Transparent;
			button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			button1.Cursor = System.Windows.Forms.Cursors.Hand;
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			button1.Location = new System.Drawing.Point(123, 246);
			button1.Name = "button1";
			button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			button1.Size = new System.Drawing.Size(177, 48);
			button1.TabIndex = 38;
			button1.Text = "Start FN";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			button3.BackColor = System.Drawing.Color.Transparent;
			button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			button3.Cursor = System.Windows.Forms.Cursors.Hand;
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button3.Location = new System.Drawing.Point(123, 300);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(177, 48);
			button3.TabIndex = 41;
			button3.Text = "Close FN";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click_1);
			button4.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
			button4.Cursor = System.Windows.Forms.Cursors.Hand;
			button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button4.Location = new System.Drawing.Point(529, 274);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(186, 66);
			button4.TabIndex = 42;
			button4.Text = "Purple";
			button4.UseMnemonic = false;
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click_1);
			panel1.BackColor = System.Drawing.Color.Teal;
			panel1.Controls.Add(MainPaksPath);
			panel1.Controls.Add(customPaksPath);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(openpaks);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button6);
			panel1.Controls.Add(button5);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button3);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(764, 575);
			panel1.TabIndex = 43;
			button2.BackColor = System.Drawing.Color.Transparent;
			button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			button2.Cursor = System.Windows.Forms.Cursors.Hand;
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button2.Location = new System.Drawing.Point(123, 408);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(177, 48);
			button2.TabIndex = 54;
			button2.Text = "Select v14.20 Paks";
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			label5.Location = new System.Drawing.Point(12, 75);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(173, 33);
			label5.TabIndex = 52;
			label5.Text = "Path 14.20:";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			label4.Location = new System.Drawing.Point(12, 9);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(87, 33);
			label4.TabIndex = 50;
			label4.Text = "Path:";
			openpaks.BackColor = System.Drawing.Color.Transparent;
			openpaks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			openpaks.Cursor = System.Windows.Forms.Cursors.Hand;
			openpaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			openpaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			openpaks.Location = new System.Drawing.Point(123, 354);
			openpaks.Name = "openpaks";
			openpaks.Size = new System.Drawing.Size(177, 48);
			openpaks.TabIndex = 49;
			openpaks.Text = "Open Paks";
			openpaks.UseVisualStyleBackColor = false;
			openpaks.Click += new System.EventHandler(openpaks_Click);
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			label2.Location = new System.Drawing.Point(118, 508);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(524, 58);
			label2.TabIndex = 47;
			label2.Text = "The Chance is 0.00000000001% = 0% for a ban!\r\nWe are not responsible for bans!";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			label1.Location = new System.Drawing.Point(523, 166);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(211, 33);
			label1.TabIndex = 46;
			label1.Text = "Color Themes";
			button7.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
			button7.Cursor = System.Windows.Forms.Cursors.Hand;
			button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button7.Location = new System.Drawing.Point(529, 418);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(186, 66);
			button7.TabIndex = 45;
			button7.Text = "Red";
			button7.UseMnemonic = false;
			button7.UseVisualStyleBackColor = false;
			button7.Click += new System.EventHandler(button7_Click);
			button6.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
			button6.Cursor = System.Windows.Forms.Cursors.Hand;
			button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button6.Location = new System.Drawing.Point(529, 346);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(186, 66);
			button6.TabIndex = 44;
			button6.Text = "Green";
			button6.UseMnemonic = false;
			button6.UseVisualStyleBackColor = false;
			button6.Click += new System.EventHandler(button6_Click);
			button5.BackColor = System.Drawing.Color.Teal;
			button5.Cursor = System.Windows.Forms.Cursors.Hand;
			button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button5.Location = new System.Drawing.Point(529, 202);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(186, 66);
			button5.TabIndex = 43;
			button5.Text = "Default";
			button5.UseMnemonic = false;
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			customPaksPath.BackColor = System.Drawing.Color.Teal;
			customPaksPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
			customPaksPath.Font = new System.Drawing.Font("Arial", 18f);
			customPaksPath.Location = new System.Drawing.Point(12, 111);
			customPaksPath.MaxLength = 0;
			customPaksPath.Multiline = false;
			customPaksPath.Name = "customPaksPath";
			customPaksPath.ReadOnly = true;
			customPaksPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			customPaksPath.Size = new System.Drawing.Size(740, 33);
			customPaksPath.TabIndex = 55;
			customPaksPath.Text = "";
			MainPaksPath.BackColor = System.Drawing.Color.Teal;
			MainPaksPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
			MainPaksPath.Font = new System.Drawing.Font("Arial", 18f);
			MainPaksPath.Location = new System.Drawing.Point(12, 39);
			MainPaksPath.MaxLength = 0;
			MainPaksPath.Multiline = false;
			MainPaksPath.Name = "MainPaksPath";
			MainPaksPath.ReadOnly = true;
			MainPaksPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			MainPaksPath.Size = new System.Drawing.Size(740, 33);
			MainPaksPath.TabIndex = 56;
			MainPaksPath.Text = "";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Teal;
			base.ClientSize = new System.Drawing.Size(764, 575);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Settings";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Lele Swapper - Settings";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
