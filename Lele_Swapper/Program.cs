using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Lele_Swapper.Properties;
using Newtonsoft.Json.Linq;

namespace Lele_Swapper
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Process[] processesByName = Process.GetProcessesByName("Pro Swapper");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			Process[] processesByName2 = Process.GetProcessesByName("Justloop Swapper");
			for (int j = 0; j < processesByName2.Length; j++)
			{
				processesByName2[j].Kill();
			}
			try
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://textbin.net/raw/RXGgQJrhTi");
				JObject val = JObject.Parse(text);
				Lele_Swapper.Properties.Settings.Default.api_data = text.ToString();
				Lele_Swapper.Properties.Settings.Default.Save();
				string a = ((object)val.get_Item("status").get_Item((object)"id")).ToString();
				string text2 = ((object)val.get_Item("status").get_Item((object)"message")).ToString();
				string b = ((object)val.get_Item("status").get_Item((object)"version")).ToString();
				string fileName = ((object)val.get_Item("status").get_Item((object)"download")).ToString();
				string a2 = "0.60";
				if (a2 != b)
				{
					MessageBox.Show("You have an Outdated Swapper Version, Please Download The Newest Version!", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Process.Start(fileName);
				}
				else if (a == "up")
				{
					Application.Run(new PatchNotes());
				}
				else if (a == "down")
				{
					MessageBox.Show(text2, "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Error with connecting to the API", "Lele Swapper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
}
