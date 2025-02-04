//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type APCUREQ_T
	/// </summary>
	public class ApcureqVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SOFTPART_ID
		/// </summary>
		public int SoftpartId { get; }

		/// <summary>
		/// Value of variable $TOTAL_EQ
		/// </summary>
		public byte TotalEq { get; }

		/// <summary>
		/// Value of variable $CUR_EQNO
		/// </summary>
		public byte CurEqno { get; }

		/// <summary>
		/// Value of variable $SPI_INDEX
		/// </summary>
		public int SpiIndex { get; }

		/// <summary>
		/// Value of variable $SCREEN_NAME
		/// </summary>
		public string ScreenName { get; }

		/// <summary>
		/// Value of variable $APP_SIGN
		/// </summary>
		public string AppSign { get; }

		/// <summary>
		/// Value of variable $APP_PROCES0
		/// </summary>
		public int AppProces0 { get; }

		/// <summary>
		/// Value of variable $APP_PROCES1
		/// </summary>
		public int AppProces1 { get; }

		/// <summary>
		/// Value of variable $TOPK_FILE
		/// </summary>
		public string TopkFile { get; }

		/// <summary>
		/// Value of variable $THKY_FILE
		/// </summary>
		public string ThkyFile { get; }

		/// <summary>
		/// Value of variable $PANE_EQNO
		/// </summary>
		public byte[] PaneEqno { get; }

		/// <summary>
		/// Value of variable $DUMMY12
		/// </summary>
		public byte Dummy12 { get; }

		/// <summary>
		/// Value of variable $DUMMY13
		/// </summary>
		public byte Dummy13 { get; }

		/// <summary>
		/// Value of variable $DUMMY14
		/// </summary>
		public byte Dummy14 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
