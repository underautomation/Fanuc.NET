//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_PANEDAT_T
	/// </summary>
	public class UiPanedatVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PAGEURL
		/// </summary>
		public string Pageurl { get; }

		/// <summary>
		/// Value of variable $FRAME
		/// </summary>
		public string Frame { get; }

		/// <summary>
		/// Value of variable $HELPURL
		/// </summary>
		public string Helpurl { get; }

		/// <summary>
		/// Value of variable $PARAMETER1
		/// </summary>
		public string Parameter1 { get; }

		/// <summary>
		/// Value of variable $PARAMETER2
		/// </summary>
		public string Parameter2 { get; }

		/// <summary>
		/// Value of variable $PARAMETER3
		/// </summary>
		public string Parameter3 { get; }

		/// <summary>
		/// Value of variable $PARAMETER4
		/// </summary>
		public string Parameter4 { get; }

		/// <summary>
		/// Value of variable $PARAMETER5
		/// </summary>
		public string Parameter5 { get; }

		/// <summary>
		/// Value of variable $PARAMETER6
		/// </summary>
		public string Parameter6 { get; }

		/// <summary>
		/// Value of variable $PARAMETER7
		/// </summary>
		public string Parameter7 { get; }

		/// <summary>
		/// Value of variable $PARAMETER8
		/// </summary>
		public string Parameter8 { get; }

		/// <summary>
		/// Value of variable $INTERVAL
		/// </summary>
		public short Interval { get; }

		/// <summary>
		/// Value of variable $PANESTATE
		/// </summary>
		public byte Panestate { get; }

		/// <summary>
		/// Value of variable $DUMMY14
		/// </summary>
		public byte Dummy14 { get; }

		/// <summary>
		/// Value of variable $MOUSE
		/// </summary>
		public MouseVariableType Mouse { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
