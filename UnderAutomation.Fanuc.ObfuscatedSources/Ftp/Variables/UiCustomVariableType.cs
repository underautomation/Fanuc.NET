//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_CUSTOM_T
	/// </summary>
	public class UiCustomVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $START_SPID
		/// </summary>
		public int StartSpid { get; }

		/// <summary>
		/// Value of variable $START_SCID
		/// </summary>
		public int StartScid { get; }

		/// <summary>
		/// Value of variable $CONFIG_PAGE
		/// </summary>
		public string[] ConfigPage { get; }

		/// <summary>
		/// Value of variable $DEVICE_PAGE
		/// </summary>
		public string[] DevicePage { get; }

		/// <summary>
		/// Value of variable $SCREEN_DEF
		/// </summary>
		public byte[] ScreenDef { get; }

		/// <summary>
		/// Value of variable $CONFIG_PANE
		/// </summary>
		public byte[] ConfigPane { get; }

		/// <summary>
		/// Value of variable $FLAGS
		/// </summary>
		public byte[] Flags { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
