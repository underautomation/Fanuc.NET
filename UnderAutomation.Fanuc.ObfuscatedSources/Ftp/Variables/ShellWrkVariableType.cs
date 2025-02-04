//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SHELL_WRK_T
	/// </summary>
	public class ShellWrkVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ROUT_NAME
		/// </summary>
		public string RoutName { get; }

		/// <summary>
		/// Value of variable $CURR_LINE
		/// </summary>
		public int CurrLine { get; }

		/// <summary>
		/// Value of variable $TASK_NUM
		/// </summary>
		public int TaskNum { get; }

		/// <summary>
		/// Value of variable $BY_MANUAL
		/// </summary>
		public bool ByManual { get; }

		/// <summary>
		/// Value of variable $WRK_BUSY
		/// </summary>
		public bool WrkBusy { get; }

		/// <summary>
		/// Value of variable $SHELL_START
		/// </summary>
		public bool ShellStart { get; }

		/// <summary>
		/// Value of variable $KAREL_UOP
		/// </summary>
		public bool KarelUop { get; }

		/// <summary>
		/// Value of variable $KAREL_SOP
		/// </summary>
		public bool KarelSop { get; }

		/// <summary>
		/// Value of variable $RSR_STAT_P
		/// </summary>
		public int RsrStatP { get; }

		/// <summary>
		/// Value of variable $ISOL_MODE
		/// </summary>
		public bool IsolMode { get; }

		/// <summary>
		/// Value of variable $CUR_STYLE
		/// </summary>
		public int CurStyle { get; }

		/// <summary>
		/// Value of variable $CUR_OPTION
		/// </summary>
		public int CurOption { get; }

		/// <summary>
		/// Value of variable $CUR_OPTA
		/// </summary>
		public int CurOpta { get; }

		/// <summary>
		/// Value of variable $CUR_OPTB
		/// </summary>
		public int CurOptb { get; }

		/// <summary>
		/// Value of variable $CUR_OPTC
		/// </summary>
		public int CurOptc { get; }

		/// <summary>
		/// Value of variable $CUR_DECSN
		/// </summary>
		public int CurDecsn { get; }

		/// <summary>
		/// Value of variable $MAN_STYLE
		/// </summary>
		public int ManStyle { get; }

		/// <summary>
		/// Value of variable $MAN_OPTION
		/// </summary>
		public int ManOption { get; }

		/// <summary>
		/// Value of variable $MAN_OPTA
		/// </summary>
		public int ManOpta { get; }

		/// <summary>
		/// Value of variable $MAN_OPTB
		/// </summary>
		public int ManOptb { get; }

		/// <summary>
		/// Value of variable $MAN_OPTC
		/// </summary>
		public int ManOptc { get; }

		/// <summary>
		/// Value of variable $MAN_DECSN
		/// </summary>
		public int ManDecsn { get; }

		/// <summary>
		/// Value of variable $CHK_RAW
		/// </summary>
		public int ChkRaw { get; }

		/// <summary>
		/// Value of variable $CHK_STAT
		/// </summary>
		public int ChkStat { get; }

		/// <summary>
		/// Value of variable $CHK_FORCE
		/// </summary>
		public int ChkForce { get; }

		/// <summary>
		/// Value of variable $CHK_IGNORE
		/// </summary>
		public int ChkIgnore { get; }

		/// <summary>
		/// Value of variable $KAREL_IOUOP
		/// </summary>
		public bool KarelIouop { get; }

		/// <summary>
		/// Value of variable $CUST_NAME
		/// </summary>
		public string CustName { get; }

		/// <summary>
		/// Value of variable $CELL_MODE
		/// </summary>
		public int CellMode { get; }

		/// <summary>
		/// Value of variable $TRYOUT_MODE
		/// </summary>
		public bool TryoutMode { get; }

		/// <summary>
		/// Value of variable $CUST_START
		/// </summary>
		public bool CustStart { get; }

		/// <summary>
		/// Value of variable $REMOTE_KEY
		/// </summary>
		public bool RemoteKey { get; }

		/// <summary>
		/// Value of variable $STRTCHK_EPT
		/// </summary>
		public short StrtchkEpt { get; }

		/// <summary>
		/// Value of variable $PS_STRTCHK_
		/// </summary>
		public short PsStrtchk { get; }

		/// <summary>
		/// Value of variable $STRTCHK_LIN
		/// </summary>
		public int StrtchkLin { get; }

		/// <summary>
		/// Value of variable $CYCTSK_NUM
		/// </summary>
		public int CyctskNum { get; }

		/// <summary>
		/// Value of variable $ACTIVEPROG
		/// </summary>
		public string Activeprog { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
