//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_USRVIEW_T
	/// </summary>
	public class UiUsrviewVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MENU
		/// </summary>
		public string Menu { get; }

		/// <summary>
		/// Value of variable $CONFIG
		/// </summary>
		public string Config { get; }

		/// <summary>
		/// Value of variable $FOCUS
		/// </summary>
		public string Focus { get; }

		/// <summary>
		/// Value of variable $PRIM
		/// </summary>
		public string Prim { get; }

		/// <summary>
		/// Value of variable $DUAL
		/// </summary>
		public string Dual { get; }

		/// <summary>
		/// Value of variable $TRIPLE
		/// </summary>
		public string Triple { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
