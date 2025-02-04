//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SHELL_CFG_T
	/// </summary>
	public class ShellCfgVariableType : GenericVariableType, IGenericVariableType {


		public ShellCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $JOB_BASE
		/// </summary>
		public int JobBase { get; }

		/// <summary>
		/// Value of variable $RSR_ENABLE
		/// </summary>
		public bool[] RsrEnable { get; }

		/// <summary>
		/// Value of variable $NUM_RSR
		/// </summary>
		public short[] NumRsr { get; }

		/// <summary>
		/// Value of variable $RSR1_NAME
		/// </summary>
		public string Rsr1Name { get; }

		/// <summary>
		/// Value of variable $RSR2_NAME
		/// </summary>
		public string Rsr2Name { get; }

		/// <summary>
		/// Value of variable $RSR3_NAME
		/// </summary>
		public string Rsr3Name { get; }

		/// <summary>
		/// Value of variable $RSR4_NAME
		/// </summary>
		public string Rsr4Name { get; }

		/// <summary>
		/// Value of variable $RSR5_NAME
		/// </summary>
		public string Rsr5Name { get; }

		/// <summary>
		/// Value of variable $RSR6_NAME
		/// </summary>
		public string Rsr6Name { get; }

		/// <summary>
		/// Value of variable $RSR7_NAME
		/// </summary>
		public string Rsr7Name { get; }

		/// <summary>
		/// Value of variable $RSR8_NAME
		/// </summary>
		public string Rsr8Name { get; }

		/// <summary>
		/// Value of variable $JOB_ROOT
		/// </summary>
		public string JobRoot { get; }

		/// <summary>
		/// Value of variable $CONT_ONLY
		/// </summary>
		public bool ContOnly { get; }

		/// <summary>
		/// Value of variable $USE_ABORT
		/// </summary>
		public bool UseAbort { get; }

		/// <summary>
		/// Value of variable $RSR_ACKENBL
		/// </summary>
		public bool RsrAckenbl { get; }

		/// <summary>
		/// Value of variable $INVERT_CHK
		/// </summary>
		public bool InvertChk { get; }

		/// <summary>
		/// Value of variable $UOP_SEL_STA
		/// </summary>
		public bool UopSelSta { get; }

		/// <summary>
		/// Value of variable $RSR_ACK_PUL
		/// </summary>
		public int RsrAckPul { get; }

		/// <summary>
		/// Value of variable $COM_TIMEOUT
		/// </summary>
		public int ComTimeout { get; }

		/// <summary>
		/// Value of variable $PNS_ENABLE
		/// </summary>
		public bool PnsEnable { get; }

		/// <summary>
		/// Value of variable $SHELL_NAME
		/// </summary>
		public string ShellName { get; }

		/// <summary>
		/// Value of variable $START_MODE
		/// </summary>
		public int StartMode { get; }

		/// <summary>
		/// Value of variable $TPFWD_KAREL
		/// </summary>
		public bool TpfwdKarel { get; }

		/// <summary>
		/// Value of variable $ERR_REPORT
		/// </summary>
		public bool ErrReport { get; }

		/// <summary>
		/// Value of variable $OPTIONS
		/// </summary>
		public int Options { get; }

		/// <summary>
		/// Value of variable $QUE_ENABLE
		/// </summary>
		public bool QueEnable { get; }

		/// <summary>
		/// Value of variable $PRODSTARTYP
		/// </summary>
		public int Prodstartyp { get; }

		/// <summary>
		/// Value of variable $CSTOPI_ALL
		/// </summary>
		public bool CstopiAll { get; }

		/// <summary>
		/// Value of variable $SHELL_EXT
		/// </summary>
		public bool ShellExt { get; }

		/// <summary>
		/// Value of variable $SEL_TYPE
		/// </summary>
		public int SelType { get; }

		/// <summary>
		/// Value of variable $EXT_SEM1
		/// </summary>
		public int ExtSem1 { get; }

		/// <summary>
		/// Value of variable $EXT_SEM2
		/// </summary>
		public int ExtSem2 { get; }

		/// <summary>
		/// Value of variable $MAINT_STYL
		/// </summary>
		public bool MaintStyl { get; }

		/// <summary>
		/// Value of variable $ISOL_ENB
		/// </summary>
		public bool IsolEnb { get; }

		/// <summary>
		/// Value of variable $DI_CHKTRIG
		/// </summary>
		public int DiChktrig { get; }

		/// <summary>
		/// Value of variable $PROD_MODE
		/// </summary>
		public int ProdMode { get; }

		/// <summary>
		/// Value of variable $INIT_TMO
		/// </summary>
		public int InitTmo { get; }

		/// <summary>
		/// Value of variable $MANRQ_TMO
		/// </summary>
		public int ManrqTmo { get; }

		/// <summary>
		/// Value of variable $EXTEND_ENB
		/// </summary>
		public int ExtendEnb { get; }

		/// <summary>
		/// Value of variable $KEYSWITCH
		/// </summary>
		public bool Keyswitch { get; }

		/// <summary>
		/// Value of variable $STARTCHKTYP
		/// </summary>
		public int Startchktyp { get; }

		/// <summary>
		/// Value of variable $HEARTBEATMS
		/// </summary>
		public int Heartbeatms { get; }

		/// <summary>
		/// Value of variable $PERM_LEVEL
		/// </summary>
		public int PermLevel { get; }

		/// <summary>
		/// Value of variable $TEMP_LEVEL
		/// </summary>
		public int TempLevel { get; }

		/// <summary>
		/// Value of variable $USTART_FT
		/// </summary>
		public bool UstartFt { get; }

		/// <summary>
		/// Value of variable $START_SIG
		/// </summary>
		public int StartSig { get; }

		/// <summary>
		/// Value of variable $DO_HOME_SOP
		/// </summary>
		public bool DoHomeSop { get; }

		/// <summary>
		/// Value of variable $REFPS_PR_ID
		/// </summary>
		public int RefpsPrId { get; }

		/// <summary>
		/// Value of variable $DIS_STRTCHK
		/// </summary>
		public bool DisStrtchk { get; }

		/// <summary>
		/// Value of variable $CUSTOM
		/// </summary>
		public int Custom { get; }

		/// <summary>
		/// Value of variable $E_RECOV_MSK
		/// </summary>
		public int ERecovMsk { get; }

		/// <summary>
		/// Value of variable $SET_IOCMNT
		/// </summary>
		public bool SetIocmnt { get; }

		/// <summary>
		/// Value of variable $CSTOPI_ALL2
		/// </summary>
		public bool CstopiAll2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
