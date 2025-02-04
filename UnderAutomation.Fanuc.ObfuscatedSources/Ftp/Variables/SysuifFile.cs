//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file sysuif.va
	/// </summary>
	public class SysuifFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $UI_CONFIG
		/// </summary>
		public UiConfigVariableType UiConfig { get; }

		/// <summary>
		/// Value of variable $UI_CUSTOM
		/// </summary>
		public UiCustomVariableType[] UiCustom { get; }

		/// <summary>
		/// Value of variable $UI_TOPMENU
		/// </summary>
		public UiTopmenuVariableType[] UiTopmenu { get; }

		/// <summary>
		/// Value of variable $UI_USERVIEW
		/// </summary>
		public UiUsrviewVariableType[] UiUserview { get; }
	}
}
