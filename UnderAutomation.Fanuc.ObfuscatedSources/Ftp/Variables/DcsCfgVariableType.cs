//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCS_CFG_T
	/// </summary>
	public class DcsCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $DISP_MENU
		/// </summary>
		public int DispMenu { get; }

		/// <summary>
		/// Value of variable $LOG_ENB
		/// </summary>
		public int LogEnb { get; }

		/// <summary>
		/// Value of variable $LOG_LEN
		/// </summary>
		public int LogLen { get; }

		/// <summary>
		/// Value of variable $LOG_FILE
		/// </summary>
		public string LogFile { get; }

		/// <summary>
		/// Value of variable $LOG_ID
		/// </summary>
		public int LogId { get; }

		/// <summary>
		/// Value of variable $LOG_IDMAX
		/// </summary>
		public int LogIdmax { get; }

		/// <summary>
		/// Value of variable $LOG_DELAY
		/// </summary>
		public int LogDelay { get; }

		/// <summary>
		/// Value of variable $LOG_WRT
		/// </summary>
		public int LogWrt { get; }

		/// <summary>
		/// Value of variable $LOG_INTVL
		/// </summary>
		public int LogIntvl { get; }

		/// <summary>
		/// Value of variable $LOG_EVENT
		/// </summary>
		public int LogEvent { get; }

		/// <summary>
		/// Value of variable $LOG_SKIP
		/// </summary>
		public int LogSkip { get; }

		/// <summary>
		/// Value of variable $TEST_PARAM1
		/// </summary>
		public int TestParam1 { get; }

		/// <summary>
		/// Value of variable $TEST_PARAM2
		/// </summary>
		public int TestParam2 { get; }

		/// <summary>
		/// Value of variable $CHK_J_TOL
		/// </summary>
		public double ChkJTol { get; }

		/// <summary>
		/// Value of variable $CHK_C_TOL
		/// </summary>
		public double ChkCTol { get; }

		/// <summary>
		/// Value of variable $SAFE_SPD
		/// </summary>
		public double SafeSpd { get; }

		/// <summary>
		/// Value of variable $SAFE_SPD_SV
		/// </summary>
		public double SafeSpdSv { get; }

		/// <summary>
		/// Value of variable $EXCLUDE
		/// </summary>
		public int[] Exclude { get; }

		/// <summary>
		/// Value of variable $SPD_ONLY
		/// </summary>
		public int[] SpdOnly { get; }

		/// <summary>
		/// Value of variable $SYS_PARAM
		/// </summary>
		public int SysParam { get; }

		/// <summary>
		/// Value of variable $PROTECT
		/// </summary>
		public int Protect { get; }

		/// <summary>
		/// Value of variable $HI_VRC
		/// </summary>
		public int HiVrc { get; }

		/// <summary>
		/// Value of variable $APPLY_WARN
		/// </summary>
		public int ApplyWarn { get; }

		/// <summary>
		/// Value of variable $HIDE_MENU
		/// </summary>
		public int HideMenu { get; }

		/// <summary>
		/// Value of variable $HI_VRC_MLT
		/// </summary>
		public int[] HiVrcMlt { get; }

		/// <summary>
		/// Value of variable $VRFY_ALL
		/// </summary>
		public int VrfyAll { get; }

		/// <summary>
		/// Value of variable $HI_MATE
		/// </summary>
		public int HiMate { get; }

		/// <summary>
		/// Value of variable $IOC_PROT
		/// </summary>
		public int IocProt { get; }

		/// <summary>
		/// Value of variable $IOC_CRC1
		/// </summary>
		public int IocCrc1 { get; }

		/// <summary>
		/// Value of variable $IOC_CRC2
		/// </summary>
		public int IocCrc2 { get; }

		/// <summary>
		/// Value of variable $OPI_VRC
		/// </summary>
		public int OpiVrc { get; }

		/// <summary>
		/// Value of variable $LSR_TYP
		/// </summary>
		public byte LsrTyp { get; }

		/// <summary>
		/// Value of variable $DUMMY43
		/// </summary>
		public byte Dummy43 { get; }

		/// <summary>
		/// Value of variable $LSR_IDX
		/// </summary>
		public short LsrIdx { get; }

		/// <summary>
		/// Value of variable $SEL_TPMODE
		/// </summary>
		public int SelTpmode { get; }

		/// <summary>
		/// Value of variable $CNSTCY_PROT
		/// </summary>
		public int CnstcyProt { get; }

		/// <summary>
		/// Value of variable $AUTOCNF_TYP
		/// </summary>
		public int AutocnfTyp { get; }

		/// <summary>
		/// Value of variable $AUTOCNF_IDX
		/// </summary>
		public int AutocnfIdx { get; }

		/// <summary>
		/// Value of variable $TPMODE_OPT
		/// </summary>
		public int TpmodeOpt { get; }

		/// <summary>
		/// Value of variable $NUM_CHDG
		/// </summary>
		public int NumChdg { get; }

		/// <summary>
		/// Value of variable $DSBL_POSSPD
		/// </summary>
		public int DsblPosspd { get; }

		/// <summary>
		/// Value of variable $SAFIO_CPY
		/// </summary>
		public int SafioCpy { get; }

		/// <summary>
		/// Value of variable $TPMODE_T2
		/// </summary>
		public bool TpmodeT2 { get; }

		/// <summary>
		/// Value of variable $ENB_VALD
		/// </summary>
		public bool EnbVald { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
