//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MEMO_MEMO_T
	/// </summary>
	public class MemoMemoVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TPE_AREA
		/// </summary>
		public int TpeArea { get; }

		/// <summary>
		/// Value of variable $TSKWRK_AREA
		/// </summary>
		public int TskwrkArea { get; }

		/// <summary>
		/// Value of variable $WRK_BUF_SIZ
		/// </summary>
		public int WrkBufSiz { get; }

		/// <summary>
		/// Value of variable $PRC_TBL_SIZ
		/// </summary>
		public int PrcTblSiz { get; }

		/// <summary>
		/// Value of variable $TMP_ALC_SUM
		/// </summary>
		public int TmpAlcSum { get; }

		/// <summary>
		/// Value of variable $OPEN_SIZE
		/// </summary>
		public short OpenSize { get; }

		/// <summary>
		/// Value of variable $REVIVE_PROG
		/// </summary>
		public string ReviveProg { get; }

		/// <summary>
		/// Value of variable $MM_DSBL_MSK
		/// </summary>
		public int MmDsblMsk { get; }

		/// <summary>
		/// Value of variable $RECV_MODE
		/// </summary>
		public int RecvMode { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
