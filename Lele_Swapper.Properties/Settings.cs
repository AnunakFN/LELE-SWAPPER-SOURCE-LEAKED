using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lele_Swapper.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default => defaultInstance;

		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string PaksLocation
		{
			get
			{
				return (string)this["PaksLocation"];
			}
			set
			{
				this["PaksLocation"] = value;
			}
		}

		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string Themes
		{
			get
			{
				return (string)this["Themes"];
			}
			set
			{
				this["Themes"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string api_data
		{
			get
			{
				return (string)this["api_data"];
			}
			set
			{
				this["api_data"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string swap_item_data
		{
			get
			{
				return (string)this["swap_item_data"];
			}
			set
			{
				this["swap_item_data"] = value;
			}
		}

		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string CustomPaksPath
		{
			get
			{
				return (string)this["CustomPaksPath"];
			}
			set
			{
				this["CustomPaksPath"] = value;
			}
		}
	}
}
