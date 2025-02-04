//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_TOPMENU_T
	/// </summary>
	public class UiTopmenuVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PWD_ACCESS
		/// </summary>
		public byte PwdAccess { get; }

		/// <summary>
		/// Value of variable $DUMMY8
		/// </summary>
		public byte Dummy8 { get; }

		/// <summary>
		/// Value of variable $DUMMY
		/// </summary>
		public int Dummy { get; }

		/// <summary>
		/// Value of variable $TITLE
		/// </summary>
		public string Title { get; }

		/// <summary>
		/// Value of variable $LABEL
		/// </summary>
		public string Label { get; }

		/// <summary>
		/// Value of variable $TEXT
		/// </summary>
		public string[] Text { get; }

		/// <summary>
		/// Value of variable $ICON
		/// </summary>
		public string[] Icon { get; }

		/// <summary>
		/// Value of variable $URL
		/// </summary>
		public string[] Url { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
