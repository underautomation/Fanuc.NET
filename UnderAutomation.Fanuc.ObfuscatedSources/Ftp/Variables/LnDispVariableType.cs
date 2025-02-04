//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type LN_DISP_T
	/// </summary>
	public class LnDispVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $HIDE_LINE_N
		/// </summary>
		public bool HideLineN { get; }

		/// <summary>
		/// Value of variable $DISP_MENU
		/// </summary>
		public bool DispMenu { get; }

		/// <summary>
		/// Value of variable $HIDE_PARLN
		/// </summary>
		public bool HideParln { get; }

		/// <summary>
		/// Value of variable $HIDE_DAULN
		/// </summary>
		public bool HideDauln { get; }

		/// <summary>
		/// Value of variable $HEAD_PARENT
		/// </summary>
		public string HeadParent { get; }

		/// <summary>
		/// Value of variable $HEAD_DAUGHT
		/// </summary>
		public string HeadDaught { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
