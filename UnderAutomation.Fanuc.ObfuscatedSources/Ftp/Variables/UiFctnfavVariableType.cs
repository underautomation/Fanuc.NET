//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_FCTNFAV_T
	/// </summary>
	public class UiFctnfavVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PWD_SPID
		/// </summary>
		public int PwdSpid { get; }

		/// <summary>
		/// Value of variable $PWD_SCID
		/// </summary>
		public int PwdScid { get; }

		/// <summary>
		/// Value of variable $PRESS_TEXT
		/// </summary>
		public string PressText { get; }

		/// <summary>
		/// Value of variable $PRESS_ICON
		/// </summary>
		public string PressIcon { get; }

		/// <summary>
		/// Value of variable $PRESS_PTR
		/// </summary>
		public int PressPtr { get; }

		/// <summary>
		/// Value of variable $RELEAS_TEXT
		/// </summary>
		public string ReleasText { get; }

		/// <summary>
		/// Value of variable $RELEAS_ICON
		/// </summary>
		public string ReleasIcon { get; }

		/// <summary>
		/// Value of variable $RELEAS_PTR
		/// </summary>
		public int ReleasPtr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
