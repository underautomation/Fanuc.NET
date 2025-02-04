//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file synosave.va
	/// </summary>
	public class SynosaveFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public SynosaveFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $AAVM_GRP
		/// </summary>
		public AavmGrpVariableType[] AavmGrp { get; }

		/// <summary>
		/// Value of variable $AIMAGE_BACK
		/// </summary>
		public int AimageBack { get; }

		/// <summary>
		/// Value of variable $AUTOUPDT_ST
		/// </summary>
		public int AutoupdtSt { get; }

		/// <summary>
		/// Value of variable $BLT
		/// </summary>
		public int Blt { get; }

		/// <summary>
		/// Value of variable $DAQ_GFD_USE
		/// </summary>
		public int DaqGfdUse { get; }

		/// <summary>
		/// Value of variable $DBWORK
		/// </summary>
		public DbworkVariableType[] Dbwork { get; }

		/// <summary>
		/// Value of variable $DEVICE
		/// </summary>
		public string Device { get; }

		/// <summary>
		/// Value of variable $DFMTN0_NO
		/// </summary>
		public int Dfmtn0No { get; }

		/// <summary>
		/// Value of variable $DHCP_INT
		/// </summary>
		public DhcpIntVariableType[] DhcpInt { get; }

		/// <summary>
		/// Value of variable $DISTBF_DATA
		/// </summary>
		public int DistbfData { get; }

		/// <summary>
		/// Value of variable $FAST_CLOCK
		/// </summary>
		public int FastClock { get; }

		/// <summary>
		/// Value of variable $FILECONFIG
		/// </summary>
		public FileconfigVariableType Fileconfig { get; }

		/// <summary>
		/// Value of variable $FILESETUP
		/// </summary>
		public FileSetupVariableType Filesetup { get; }

		/// <summary>
		/// Value of variable $FILE_BASEPT
		/// </summary>
		public int FileBasept { get; }

		/// <summary>
		/// Value of variable $FILE_ERRBCK
		/// </summary>
		public FileBackVariableType[] FileErrbck { get; }

		/// <summary>
		/// Value of variable $FILE_MAXSEC
		/// </summary>
		public int FileMaxsec { get; }

		/// <summary>
		/// Value of variable $FILE_SYSBCK
		/// </summary>
		public FileBackVariableType[] FileSysbck { get; }

		/// <summary>
		/// Value of variable $GLOFATT
		/// </summary>
		public GlofattVariableType[] Glofatt { get; }

		/// <summary>
		/// Value of variable $GLOFSET
		/// </summary>
		public GlofsetVariableType Glofset { get; }

		/// <summary>
		/// Value of variable $IMSAVE_DONE
		/// </summary>
		public bool ImsaveDone { get; }

		/// <summary>
		/// Value of variable $KCL_RPCOUT
		/// </summary>
		public string KclRpcout { get; }

		/// <summary>
		/// Value of variable $LASTPAUSPOS
		/// </summary>
		public JointPositionVariable[] Lastpauspos { get; }

		/// <summary>
		/// Value of variable $MASTER_ENB
		/// </summary>
		public int MasterEnb { get; }

		/// <summary>
		/// Value of variable $MEMO
		/// </summary>
		public MemoMemoVariableType Memo { get; }

		/// <summary>
		/// Value of variable $MOPTIMIZ
		/// </summary>
		public MoptimizVariableType Moptimiz { get; }

		/// <summary>
		/// Value of variable $NULL_CYCLE
		/// </summary>
		public int NullCycle { get; }

		/// <summary>
		/// Value of variable $OPT_STATE
		/// </summary>
		public OptstateVariableType OptState { get; }

		/// <summary>
		/// Value of variable $PADJ_SCHNUM
		/// </summary>
		public int PadjSchnum { get; }

		/// <summary>
		/// Value of variable $PG_MAX_SPED
		/// </summary>
		public PgmaxspdVariableType[] PgMaxSped { get; }

		/// <summary>
		/// Value of variable $PRGADJ_SCH
		/// </summary>
		public PrgadjSchVariableType[] PrgadjSch { get; }

		/// <summary>
		/// Value of variable $SHELL_WRK
		/// </summary>
		public ShellWrkVariableType ShellWrk { get; }

		/// <summary>
		/// Value of variable $SMH_MADE
		/// </summary>
		public SmhMadeVariableType SmhMade { get; }

		/// <summary>
		/// Value of variable $STARTUP_DBG
		/// </summary>
		public int StartupDbg { get; }

		/// <summary>
		/// Value of variable $SYS_CONFIG
		/// </summary>
		public SscbkVariableType SysConfig { get; }

		/// <summary>
		/// Value of variable $SYS_TIME
		/// </summary>
		public SysTimeVariableType SysTime { get; }

		/// <summary>
		/// Value of variable $TICK_RATE
		/// </summary>
		public int TickRate { get; }

		/// <summary>
		/// Value of variable $TP_CURSCRN
		/// </summary>
		public TpCurscrnVariableType[] TpCurscrn { get; }

		/// <summary>
		/// Value of variable $TX
		/// </summary>
		public TxVariableType Tx { get; }

		/// <summary>
		/// Value of variable $TXRAM
		/// </summary>
		public TxramVariableType Txram { get; }

		/// <summary>
		/// Value of variable $UI_CURSCRN
		/// </summary>
		public TpCurscrnVariableType[,] UiCurscrn { get; }

		/// <summary>
		/// Value of variable $UI_FCTNFAV
		/// </summary>
		public UiFctnfavVariableType[] UiFctnfav { get; }

		/// <summary>
		/// Value of variable $UI_PANELINK
		/// </summary>
		public UiPanelnkVariableType[] UiPanelink { get; }

		/// <summary>
		/// Value of variable $UMR
		/// </summary>
		public UmrVariableType Umr { get; }

		/// <summary>
		/// Value of variable $VCRSM_CFG
		/// </summary>
		public VcrsmCfgVariableType VcrsmCfg { get; }

		/// <summary>
		/// Value of variable $VCWM_CFG
		/// </summary>
		public VcwmCfgVariableType VcwmCfg { get; }

		/// <summary>
		/// Value of variable $VCWM_GRP
		/// </summary>
		public VcwmGrpVariableType[] VcwmGrp { get; }

		/// <summary>
		/// Value of variable $VDATE
		/// </summary>
		public string Vdate { get; }

		/// <summary>
		/// Value of variable $VERSION
		/// </summary>
		public string Version { get; }

		/// <summary>
		/// Value of variable $VSMO_TMP
		/// </summary>
		public VsmoTmpVariableType VsmoTmp { get; }

		/// <summary>
		/// Value of variable $VSMO_VAL
		/// </summary>
		public VsmoValVariableType VsmoVal { get; }
	}
}
