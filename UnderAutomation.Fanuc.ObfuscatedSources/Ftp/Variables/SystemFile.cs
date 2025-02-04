//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file system.va
	/// </summary>
	public class SystemFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $AAVM_WRK
		/// </summary>
		public AavmWrkVariableType[] AavmWrk { get; }

		/// <summary>
		/// Value of variable $ABSPOS_GRP
		/// </summary>
		public AbsposGrpVariableType[] AbsposGrp { get; }

		/// <summary>
		/// Value of variable $ACC_MAXLMT
		/// </summary>
		public int AccMaxlmt { get; }

		/// <summary>
		/// Value of variable $ACC_MINLMT
		/// </summary>
		public int AccMinlmt { get; }

		/// <summary>
		/// Value of variable $ACC_PRE_EXE
		/// </summary>
		public int AccPreExe { get; }

		/// <summary>
		/// Value of variable $AC_UPDATE
		/// </summary>
		public int AcUpdate { get; }

		/// <summary>
		/// Value of variable $AIOCNV_NUM
		/// </summary>
		public int AiocnvNum { get; }

		/// <summary>
		/// Value of variable $AIOCNV_USE
		/// </summary>
		public int AiocnvUse { get; }

		/// <summary>
		/// Value of variable $AIO_CNV
		/// </summary>
		public AioCnvVariableType[] AioCnv { get; }

		/// <summary>
		/// Value of variable $ALMDG
		/// </summary>
		public AlmdgVariableType Almdg { get; }

		/// <summary>
		/// Value of variable $ALM_IF
		/// </summary>
		public AlmIfVariableType AlmIf { get; }

		/// <summary>
		/// Value of variable $ANGTOL
		/// </summary>
		public double[] Angtol { get; }

		/// <summary>
		/// Value of variable $APPINFO
		/// </summary>
		public AppinfoVariableType Appinfo { get; }

		/// <summary>
		/// Value of variable $APPLICATION
		/// </summary>
		public string[] Application { get; }

		/// <summary>
		/// Value of variable $AP_ACTIVE
		/// </summary>
		public int ApActive { get; }

		/// <summary>
		/// Value of variable $AP_AUTOMODE
		/// </summary>
		public bool ApAutomode { get; }

		/// <summary>
		/// Value of variable $AP_CHGAPONL
		/// </summary>
		public bool ApChgaponl { get; }

		/// <summary>
		/// Value of variable $AP_COUPLED
		/// </summary>
		public ApcoupledVariableType[] ApCoupled { get; }

		/// <summary>
		/// Value of variable $AP_CUREQ
		/// </summary>
		public ApcureqVariableType[] ApCureq { get; }

		/// <summary>
		/// Value of variable $AP_CURTOOL
		/// </summary>
		public int ApCurtool { get; }

		/// <summary>
		/// Value of variable $AP_DO_CLEAN
		/// </summary>
		public bool ApDoClean { get; }

		/// <summary>
		/// Value of variable $AP_DO_CLENM
		/// </summary>
		public bool[] ApDoClenm { get; }

		/// <summary>
		/// Value of variable $AP_DSPDRYRN
		/// </summary>
		public bool ApDspdryrn { get; }

		/// <summary>
		/// Value of variable $AP_HIDE
		/// </summary>
		public bool[] ApHide { get; }

		/// <summary>
		/// Value of variable $AP_MAXAPP
		/// </summary>
		public int ApMaxapp { get; }

		/// <summary>
		/// Value of variable $AP_MAXAX
		/// </summary>
		public int ApMaxax { get; }

		/// <summary>
		/// Value of variable $AP_PLUGGED
		/// </summary>
		public int ApPlugged { get; }

		/// <summary>
		/// Value of variable $AP_PRC_DSBM
		/// </summary>
		public int[] ApPrcDsbm { get; }

		/// <summary>
		/// Value of variable $AP_PROC_DSB
		/// </summary>
		public bool ApProcDsb { get; }

		/// <summary>
		/// Value of variable $AP_SEGF_CHK
		/// </summary>
		public bool ApSegfChk { get; }

		/// <summary>
		/// Value of variable $AP_SEG_CHKM
		/// </summary>
		public bool[] ApSegChkm { get; }

		/// <summary>
		/// Value of variable $AP_SELAP
		/// </summary>
		public bool[] ApSelap { get; }

		/// <summary>
		/// Value of variable $AP_TOTALAX
		/// </summary>
		public int ApTotalax { get; }

		/// <summary>
		/// Value of variable $AP_USENUM
		/// </summary>
		public byte[] ApUsenum { get; }

		/// <summary>
		/// Value of variable $ARGDISPMMCK
		/// </summary>
		public double Argdispmmck { get; }

		/// <summary>
		/// Value of variable $ARGDISPMODE
		/// </summary>
		public int Argdispmode { get; }

		/// <summary>
		/// Value of variable $ARG_STRING
		/// </summary>
		public ArgStrVariableType[] ArgString { get; }

		/// <summary>
		/// Value of variable $ARG_WORD
		/// </summary>
		public string[] ArgWord { get; }

		/// <summary>
		/// Value of variable $ASBN_CONFIG
		/// </summary>
		public AsbnCfgVariableType AsbnConfig { get; }

		/// <summary>
		/// Value of variable $ATCELLSETUP
		/// </summary>
		public AtCellsetupVariableType Atcellsetup { get; }

		/// <summary>
		/// Value of variable $AUTOBACKUP
		/// </summary>
		public AutobackupVariableType Autobackup { get; }

		/// <summary>
		/// Value of variable $AUTOINIT
		/// </summary>
		public int Autoinit { get; }

		/// <summary>
		/// Value of variable $AUTOMESSAGE
		/// </summary>
		public int Automessage { get; }

		/// <summary>
		/// Value of variable $AUTOMODE_DO
		/// </summary>
		public bool AutomodeDo { get; }

		/// <summary>
		/// Value of variable $AUTOMODE_OV
		/// </summary>
		public bool AutomodeOv { get; }

		/// <summary>
		/// Value of variable $AUTOPAUSPOS
		/// </summary>
		public JointPositionVariable[] Autopauspos { get; }

		/// <summary>
		/// Value of variable $AUTOPPOSTSK
		/// </summary>
		public int[] Autoppostsk { get; }

		/// <summary>
		/// Value of variable $AUTOUPDTMOD
		/// </summary>
		public int Autoupdtmod { get; }

		/// <summary>
		/// Value of variable $AUXWZD_ENB
		/// </summary>
		public int AuxwzdEnb { get; }

		/// <summary>
		/// Value of variable $AUXWZD_STAT
		/// </summary>
		public int AuxwzdStat { get; }

		/// <summary>
		/// Value of variable $AXSCRDCFG
		/// </summary>
		public AxscrdcfgVariableType[] Axscrdcfg { get; }

		/// <summary>
		/// Value of variable $BACKGROUND
		/// </summary>
		public bool Background { get; }

		/// <summary>
		/// Value of variable $BACKUP_NAME
		/// </summary>
		public string BackupName { get; }

		/// <summary>
		/// Value of variable $BACK_EDIT
		/// </summary>
		public BackEditVariableType[] BackEdit { get; }

		/// <summary>
		/// Value of variable $BCK_NO_DEL
		/// </summary>
		public bool BckNoDel { get; }

		/// <summary>
		/// Value of variable $BGE_UNUSEND
		/// </summary>
		public bool BgeUnusend { get; }

		/// <summary>
		/// Value of variable $BIGALLOW
		/// </summary>
		public BigallowVariableType[] Bigallow { get; }

		/// <summary>
		/// Value of variable $BLAL_OUT
		/// </summary>
		public BlalOutVariableType BlalOut { get; }

		/// <summary>
		/// Value of variable $BWD_ABORT
		/// </summary>
		public bool BwdAbort { get; }

		/// <summary>
		/// Value of variable $BWD_ITR_RTN
		/// </summary>
		public int BwdItrRtn { get; }

		/// <summary>
		/// Value of variable $BWD_NONSTOP
		/// </summary>
		public int BwdNonstop { get; }

		/// <summary>
		/// Value of variable $CE_OPTION
		/// </summary>
		public int CeOption { get; }

		/// <summary>
		/// Value of variable $CE_RIA_ID
		/// </summary>
		public int CeRiaId { get; }

		/// <summary>
		/// Value of variable $CFCFG
		/// </summary>
		public CfcfgVariableType Cfcfg { get; }

		/// <summary>
		/// Value of variable $CHECKCONFIG
		/// </summary>
		public bool Checkconfig { get; }

		/// <summary>
		/// Value of variable $CHG_PRI
		/// </summary>
		public ChgPriVariableType[] ChgPri { get; }

		/// <summary>
		/// Value of variable $CHKPAUSPOS
		/// </summary>
		public ChkposVariableType[] Chkpauspos { get; }

		/// <summary>
		/// Value of variable $CMD_INFO
		/// </summary>
		public CmdInfoVariableType[] CmdInfo { get; }

		/// <summary>
		/// Value of variable $COCFG
		/// </summary>
		public CocfgVariableType Cocfg { get; }

		/// <summary>
		/// Value of variable $COLLECT_CFG
		/// </summary>
		public CollectVariableType CollectCfg { get; }

		/// <summary>
		/// Value of variable $COLLECT_ENB
		/// </summary>
		public int CollectEnb { get; }

		/// <summary>
		/// Value of variable $CONDET_CFG
		/// </summary>
		public CondetCfgVariableType CondetCfg { get; }

		/// <summary>
		/// Value of variable $CONDET_GRP
		/// </summary>
		public CondetGrpVariableType[] CondetGrp { get; }

		/// <summary>
		/// Value of variable $CONDET_IO
		/// </summary>
		public CondetIoVariableType CondetIo { get; }

		/// <summary>
		/// Value of variable $CONDET_TRGP
		/// </summary>
		public CondetTrgpVariableType[] CondetTrgp { get; }

		/// <summary>
		/// Value of variable $CONDET_TRIG
		/// </summary>
		public CondetTrigVariableType CondetTrig { get; }

		/// <summary>
		/// Value of variable $CO_MORGRP
		/// </summary>
		public CoMorgrpVariableType[] CoMorgrp { get; }

		/// <summary>
		/// Value of variable $CO_PARAMGRP
		/// </summary>
		public CoParamgpVariableType[] CoParamgrp { get; }

		/// <summary>
		/// Value of variable $CPCFG
		/// </summary>
		public CpcfgVariableType Cpcfg { get; }

		/// <summary>
		/// Value of variable $CPDBG
		/// </summary>
		public CpdbgVariableType Cpdbg { get; }

		/// <summary>
		/// Value of variable $CP_MCRGRP
		/// </summary>
		public CpMcrgrpVariableType[] CpMcrgrp { get; }

		/// <summary>
		/// Value of variable $CP_MORGRP
		/// </summary>
		public CpMorgrpVariableType[] CpMorgrp { get; }

		/// <summary>
		/// Value of variable $CP_PARAMGRP
		/// </summary>
		public CpParamgpVariableType[] CpParamgrp { get; }

		/// <summary>
		/// Value of variable $CP_T1_GRP
		/// </summary>
		public CpT1GrpVariableType[] CpT1Grp { get; }

		/// <summary>
		/// Value of variable $CP_T1_MODE
		/// </summary>
		public CpT1ModeVariableType CpT1Mode { get; }

		/// <summary>
		/// Value of variable $CRT_DEFPROG
		/// </summary>
		public string CrtDefprog { get; }

		/// <summary>
		/// Value of variable $CRT_INUSER
		/// </summary>
		public bool CrtInuser { get; }

		/// <summary>
		/// Value of variable $CRT_KEY_TBL
		/// </summary>
		public byte[] CrtKeyTbl { get; }

		/// <summary>
		/// Value of variable $CRT_LCKUSER
		/// </summary>
		public bool CrtLckuser { get; }

		/// <summary>
		/// Value of variable $CRT_USESTAT
		/// </summary>
		public bool CrtUsestat { get; }

		/// <summary>
		/// Value of variable $CR_AUTO_DO
		/// </summary>
		public int CrAutoDo { get; }

		/// <summary>
		/// Value of variable $CR_INDT_ENB
		/// </summary>
		public bool CrIndtEnb { get; }

		/// <summary>
		/// Value of variable $CR_T1_DO
		/// </summary>
		public int CrT1Do { get; }

		/// <summary>
		/// Value of variable $CR_T2_DO
		/// </summary>
		public int CrT2Do { get; }

		/// <summary>
		/// Value of variable $CSTOP
		/// </summary>
		public bool Cstop { get; }

		/// <summary>
		/// Value of variable $CTRL_DELETE
		/// </summary>
		public int CtrlDelete { get; }

		/// <summary>
		/// Value of variable $CT_SCREEN
		/// </summary>
		public string CtScreen { get; }

		/// <summary>
		/// Value of variable $CUSTOMMENU
		/// </summary>
		public CustommenuVariableType[] Custommenu { get; }

		/// <summary>
		/// Value of variable $CUST_MANUAL
		/// </summary>
		public bool CustManual { get; }

		/// <summary>
		/// Value of variable $DBCONDTRIG
		/// </summary>
		public int Dbcondtrig { get; }

		/// <summary>
		/// Value of variable $DBG_ERRLOG
		/// </summary>
		public DbgErrlogVariableType DbgErrlog { get; }

		/// <summary>
		/// Value of variable $DBNUMLIM
		/// </summary>
		public int Dbnumlim { get; }

		/// <summary>
		/// Value of variable $DBPXWORK
		/// </summary>
		public DbpxworkVariableType[] Dbpxwork { get; }

		/// <summary>
		/// Value of variable $DBTB_CTRL
		/// </summary>
		public DbtbCtrlVariableType DbtbCtrl { get; }

		/// <summary>
		/// Value of variable $DB_AWAYTRIG
		/// </summary>
		public double DbAwaytrig { get; }

		/// <summary>
		/// Value of variable $DB_AWAY_ALM
		/// </summary>
		public bool DbAwayAlm { get; }

		/// <summary>
		/// Value of variable $DB_CONDTYP
		/// </summary>
		public int DbCondtyp { get; }

		/// <summary>
		/// Value of variable $DB_DBG
		/// </summary>
		public DbDbgVariableType[] DbDbg { get; }

		/// <summary>
		/// Value of variable $DB_MINDIST
		/// </summary>
		public double DbMindist { get; }

		/// <summary>
		/// Value of variable $DB_MONTIME
		/// </summary>
		public int DbMontime { get; }

		/// <summary>
		/// Value of variable $DB_MONTYP
		/// </summary>
		public int DbMontyp { get; }

		/// <summary>
		/// Value of variable $DB_MOTNEND
		/// </summary>
		public bool DbMotnend { get; }

		/// <summary>
		/// Value of variable $DB_RECORD
		/// </summary>
		public DbRecordVariableType[] DbRecord { get; }

		/// <summary>
		/// Value of variable $DB_TOLERENC
		/// </summary>
		public double DbTolerenc { get; }

		/// <summary>
		/// Value of variable $DCSS_CNSTCY
		/// </summary>
		public DcssCnstcyVariableType[] DcssCnstcy { get; }

		/// <summary>
		/// Value of variable $DCSS_DEVICE
		/// </summary>
		public DcssDeviceVariableType[] DcssDevice { get; }

		/// <summary>
		/// Value of variable $DCSS_HNDGD
		/// </summary>
		public DcssHndgdVariableType DcssHndgd { get; }

		/// <summary>
		/// Value of variable $DCSS_LS
		/// </summary>
		public DcssLsVariableType[] DcssLs { get; }

		/// <summary>
		/// Value of variable $DCSS_PARAM
		/// </summary>
		public DcssParamVariableType DcssParam { get; }

		/// <summary>
		/// Value of variable $DCSS_SLAVE
		/// </summary>
		public DcssSlaveVariableType DcssSlave { get; }

		/// <summary>
		/// Value of variable $DCS_CFG
		/// </summary>
		public DcsCfgVariableType DcsCfg { get; }

		/// <summary>
		/// Value of variable $DCS_CRC_OUT
		/// </summary>
		public DcsCrcOutVariableType DcsCrcOut { get; }

		/// <summary>
		/// Value of variable $DCS_NOCODE
		/// </summary>
		public DcsNocodeVariableType DcsNocode { get; }

		/// <summary>
		/// Value of variable $DCS_SGN
		/// </summary>
		public DcsSgnVariableType DcsSgn { get; }

		/// <summary>
		/// Value of variable $DCS_VERSION
		/// </summary>
		public string DcsVersion { get; }

		/// <summary>
		/// Value of variable $DEFLOGIC
		/// </summary>
		public DeflogicVariableType[] Deflogic { get; }

		/// <summary>
		/// Value of variable $DEFPROG_ENB
		/// </summary>
		public bool DefprogEnb { get; }

		/// <summary>
		/// Value of variable $DEFPULSE
		/// </summary>
		public int Defpulse { get; }

		/// <summary>
		/// Value of variable $DEF_ACCLIM
		/// </summary>
		public int DefAcclim { get; }

		/// <summary>
		/// Value of variable $DEF_WRSTJNT
		/// </summary>
		public int DefWrstjnt { get; }

		/// <summary>
		/// Value of variable $DEMO_INIT
		/// </summary>
		public DemoInitVariableType DemoInit { get; }

		/// <summary>
		/// Value of variable $DEV_INDEX
		/// </summary>
		public int DevIndex { get; }

		/// <summary>
		/// Value of variable $DEV_PATH
		/// </summary>
		public string DevPath { get; }

		/// <summary>
		/// Value of variable $DHCP_CLNTID
		/// </summary>
		public string[] DhcpClntid { get; }

		/// <summary>
		/// Value of variable $DIAG_GRP
		/// </summary>
		public DiagGrpVariableType[] DiagGrp { get; }

		/// <summary>
		/// Value of variable $DICT_CONFIG
		/// </summary>
		public DictCfgVariableType DictConfig { get; }

		/// <summary>
		/// Value of variable $DISTBF_TTS
		/// </summary>
		public int DistbfTts { get; }

		/// <summary>
		/// Value of variable $DISTBF_VER
		/// </summary>
		public int DistbfVer { get; }

		/// <summary>
		/// Value of variable $DMAURST
		/// </summary>
		public bool Dmaurst { get; }

		/// <summary>
		/// Value of variable $DMSW_CFG
		/// </summary>
		public DmswCfgVariableType DmswCfg { get; }

		/// <summary>
		/// Value of variable $DOCVIEWER
		/// </summary>
		public DocviewerVariableType Docviewer { get; }

		/// <summary>
		/// Value of variable $DRC_CFG
		/// </summary>
		public DrcCfgVariableType DrcCfg { get; }

		/// <summary>
		/// Value of variable $DSBL_FAULT
		/// </summary>
		public DsblFaultVariableType DsblFault { get; }

		/// <summary>
		/// Value of variable $DSBL_GPMSK
		/// </summary>
		public int DsblGpmsk { get; }

		/// <summary>
		/// Value of variable $DTDIAG
		/// </summary>
		public DtrecVariableType Dtdiag { get; }

		/// <summary>
		/// Value of variable $DTRECP
		/// </summary>
		public DtrecVariableType Dtrecp { get; }

		/// <summary>
		/// Value of variable $DUMP_OPTION
		/// </summary>
		public int DumpOption { get; }

		/// <summary>
		/// Value of variable $DUTR_CFG
		/// </summary>
		public int DutrCfg { get; }

		/// <summary>
		/// Value of variable $DUTR_CPMES
		/// </summary>
		public int DutrCpmes { get; }

		/// <summary>
		/// Value of variable $DUTY_TEMP
		/// </summary>
		public double DutyTemp { get; }

		/// <summary>
		/// Value of variable $DUTY_UNIT
		/// </summary>
		public int DutyUnit { get; }

		/// <summary>
		/// Value of variable $DYN_BRK
		/// </summary>
		public DynBrkVariableType DynBrk { get; }

		/// <summary>
		/// Value of variable $EDITOR_OPTN
		/// </summary>
		public int EditorOptn { get; }

		/// <summary>
		/// Value of variable $EDIT_RECENT
		/// </summary>
		public EdtRecentVariableType[] EditRecent { get; }

		/// <summary>
		/// Value of variable $EMGDI_STAT
		/// </summary>
		public int EmgdiStat { get; }

		/// <summary>
		/// Value of variable $ENC_INFO
		/// </summary>
		public EncInfoVariableType[] EncInfo { get; }

		/// <summary>
		/// Value of variable $ENETMODE
		/// </summary>
		public EnetmodeVariableType[] Enetmode { get; }

		/// <summary>
		/// Value of variable $EOATCFG
		/// </summary>
		public EoatcfgVariableType Eoatcfg { get; }

		/// <summary>
		/// Value of variable $EOATDATA
		/// </summary>
		public EoatdataVariableType[] Eoatdata { get; }

		/// <summary>
		/// Value of variable $ERPOST_LOG
		/// </summary>
		public ErpostLogVariableType ErpostLog { get; }

		/// <summary>
		/// Value of variable $ERROR_PROG
		/// </summary>
		public string ErrorProg { get; }

		/// <summary>
		/// Value of variable $ERROR_TABLE
		/// </summary>
		public int[] ErrorTable { get; }

		/// <summary>
		/// Value of variable $ERRSEV_NUM
		/// </summary>
		public int ErrsevNum { get; }

		/// <summary>
		/// Value of variable $ER_AUTO_ENB
		/// </summary>
		public bool ErAutoEnb { get; }

		/// <summary>
		/// Value of variable $ER_NOAUTO
		/// </summary>
		public ErNoautoVariableType ErNoauto { get; }

		/// <summary>
		/// Value of variable $ER_NOFLTR
		/// </summary>
		public bool ErNofltr { get; }

		/// <summary>
		/// Value of variable $ER_NOHIS
		/// </summary>
		public int ErNohis { get; }

		/// <summary>
		/// Value of variable $ER_NO_ALM
		/// </summary>
		public ErNoalmVariableType[] ErNoAlm { get; }

		/// <summary>
		/// Value of variable $ER_SEV_NOAU
		/// </summary>
		public bool[] ErSevNoau { get; }

		/// <summary>
		/// Value of variable $ETCP_VER
		/// </summary>
		public string EtcpVer { get; }

		/// <summary>
		/// Value of variable $EXTLOG_REQ
		/// </summary>
		public int ExtlogReq { get; }

		/// <summary>
		/// Value of variable $EXTLOG_SIZ
		/// </summary>
		public int ExtlogSiz { get; }

		/// <summary>
		/// Value of variable $EXTSTKSIZ
		/// </summary>
		public int Extstksiz { get; }

		/// <summary>
		/// Value of variable $EXTTOL
		/// </summary>
		public double Exttol { get; }

		/// <summary>
		/// Value of variable $EXT_BWD_SEL
		/// </summary>
		public bool ExtBwdSel { get; }

		/// <summary>
		/// Value of variable $EXT_DI_BWD
		/// </summary>
		public ExtSetVariableType ExtDiBwd { get; }

		/// <summary>
		/// Value of variable $EXT_DI_STEP
		/// </summary>
		public ExtSetVariableType ExtDiStep { get; }

		/// <summary>
		/// Value of variable $E_STOP_DO
		/// </summary>
		public int EStopDo { get; }

		/// <summary>
		/// Value of variable $FACTORY_TUN
		/// </summary>
		public int FactoryTun { get; }

		/// <summary>
		/// Value of variable $FDR_GRP
		/// </summary>
		public FdrGrpVariableType[] FdrGrp { get; }

		/// <summary>
		/// Value of variable $FEATURE
		/// </summary>
		public FeatureVariableType Feature { get; }

		/// <summary>
		/// Value of variable $FEAT_ADD
		/// </summary>
		public string[] FeatAdd { get; }

		/// <summary>
		/// Value of variable $FEAT_DEMO
		/// </summary>
		public FeatureVariableType FeatDemo { get; }

		/// <summary>
		/// Value of variable $FEAT_DEMOIN
		/// </summary>
		public int FeatDemoin { get; }

		/// <summary>
		/// Value of variable $FEAT_INDEX
		/// </summary>
		public int FeatIndex { get; }

		/// <summary>
		/// Value of variable $FILECOMP
		/// </summary>
		public FilecompVariableType Filecomp { get; }

		/// <summary>
		/// Value of variable $FILESETUP2
		/// </summary>
		public FileSetup2VariableType Filesetup2 { get; }

		/// <summary>
		/// Value of variable $FILE_AP2BCK
		/// </summary>
		public FileBackVariableType[] FileAp2bck { get; }

		/// <summary>
		/// Value of variable $FILE_APPBCK
		/// </summary>
		public FileBackVariableType[] FileAppbck { get; }

		/// <summary>
		/// Value of variable $FILE_DGBCK
		/// </summary>
		public FileBackVariableType[] FileDgbck { get; }

		/// <summary>
		/// Value of variable $FILE_FRSPRT
		/// </summary>
		public bool FileFrsprt { get; }

		/// <summary>
		/// Value of variable $FILE_VISBCK
		/// </summary>
		public FileBackVariableType[] FileVisbck { get; }

		/// <summary>
		/// Value of variable $FLUI_CONFIG
		/// </summary>
		public FluiCfgVariableType FluiConfig { get; }

		/// <summary>
		/// Value of variable $FLUI_DATA
		/// </summary>
		public FluiDataVariableType FluiData { get; }

		/// <summary>
		/// Value of variable $FLUI_RESULT
		/// </summary>
		public FluiResVariableType[] FluiResult { get; }

		/// <summary>
		/// Value of variable $FMR_CFG
		/// </summary>
		public FmrCfgVariableType FmrCfg { get; }

		/// <summary>
		/// Value of variable $FNO
		/// </summary>
		public string Fno { get; }

		/// <summary>
		/// Value of variable $FRM_CHKTYP
		/// </summary>
		public int FrmChktyp { get; }

		/// <summary>
		/// Value of variable $FROMCHK_MIN
		/// </summary>
		public int FromchkMin { get; }

		/// <summary>
		/// Value of variable $FSSB_CFG
		/// </summary>
		public FssbCfgVariableType FssbCfg { get; }

		/// <summary>
		/// Value of variable $FTP_DEF_OW
		/// </summary>
		public bool FtpDefOw { get; }

		/// <summary>
		/// Value of variable $FTP_DIRCOMP
		/// </summary>
		public bool FtpDircomp { get; }

		/// <summary>
		/// Value of variable $GENOV_ENB
		/// </summary>
		public bool GenovEnb { get; }

		/// <summary>
		/// Value of variable $GRAVC_GRP
		/// </summary>
		public GravcGrpVariableType[] GravcGrp { get; }

		/// <summary>
		/// Value of variable $GRSMT_GRP
		/// </summary>
		public GrsmtGrpVariableType[] GrsmtGrp { get; }

		/// <summary>
		/// Value of variable $HOSTC_CFG
		/// </summary>
		public HostCfgVariableType[] HostcCfg { get; }

		/// <summary>
		/// Value of variable $HOSTENT
		/// </summary>
		public HostentVariableType[] Hostent { get; }

		/// <summary>
		/// Value of variable $HOSTNAME
		/// </summary>
		public string Hostname { get; }

		/// <summary>
		/// Value of variable $HOSTS_CFG
		/// </summary>
		public HostCfgVariableType[] HostsCfg { get; }

		/// <summary>
		/// Value of variable $HOST_ERR
		/// </summary>
		public ErrMaskVariableType HostErr { get; }

		/// <summary>
		/// Value of variable $HOST_PDUSIZ
		/// </summary>
		public int HostPdusiz { get; }

		/// <summary>
		/// Value of variable $HSCDMNGRP
		/// </summary>
		public HscdMngVariableType[] Hscdmngrp { get; }

		/// <summary>
		/// Value of variable $HSCD_QUPD
		/// </summary>
		public bool HscdQupd { get; }

		/// <summary>
		/// Value of variable $HSCD_UPDTYP
		/// </summary>
		public int HscdUpdtyp { get; }

		/// <summary>
		/// Value of variable $HTTP_AUTH
		/// </summary>
		public HttpAuthVariableType[] HttpAuth { get; }

		/// <summary>
		/// Value of variable $HTTP_CTRL
		/// </summary>
		public HttpVariableType HttpCtrl { get; }

		/// <summary>
		/// Value of variable $HWR_CONFIG
		/// </summary>
		public HwrConfigVariableType HwrConfig { get; }

		/// <summary>
		/// Value of variable $IDL_CPU_PCT
		/// </summary>
		public double IdlCpuPct { get; }

		/// <summary>
		/// Value of variable $IDL_MIN_PCT
		/// </summary>
		public double IdlMinPct { get; }

		/// <summary>
		/// Value of variable $IGNR_IOERR
		/// </summary>
		public int IgnrIoerr { get; }

		/// <summary>
		/// Value of variable $INPT_SIM_DO
		/// </summary>
		public int InptSimDo { get; }

		/// <summary>
		/// Value of variable $INSTAL_SCRN
		/// </summary>
		public int InstalScrn { get; }

		/// <summary>
		/// Value of variable $INTPMODNTOL
		/// </summary>
		public int Intpmodntol { get; }

		/// <summary>
		/// Value of variable $INTP_PRTY
		/// </summary>
		public int IntpPrty { get; }

		/// <summary>
		/// Value of variable $INVISTP_ENB
		/// </summary>
		public int InvistpEnb { get; }

		/// <summary>
		/// Value of variable $IOLNK
		/// </summary>
		public IolnkVariableType[] Iolnk { get; }

		/// <summary>
		/// Value of variable $IOMASTER
		/// </summary>
		public bool Iomaster { get; }

		/// <summary>
		/// Value of variable $IOSLAVE
		/// </summary>
		public IoslaveVariableType Ioslave { get; }

		/// <summary>
		/// Value of variable $IOSRAMCACHE
		/// </summary>
		public bool Iosramcache { get; }

		/// <summary>
		/// Value of variable $IO_AUTO_CFG
		/// </summary>
		public bool IoAutoCfg { get; }

		/// <summary>
		/// Value of variable $IO_AUTO_UOP
		/// </summary>
		public bool IoAutoUop { get; }

		/// <summary>
		/// Value of variable $IO_CMT_OPT
		/// </summary>
		public int IoCmtOpt { get; }

		/// <summary>
		/// Value of variable $IO_CYCLE
		/// </summary>
		public bool IoCycle { get; }

		/// <summary>
		/// Value of variable $IO_DEF_ASG
		/// </summary>
		public IoDefAsgVariableType[] IoDefAsg { get; }

		/// <summary>
		/// Value of variable $IO_DEF_NUM
		/// </summary>
		public int IoDefNum { get; }

		/// <summary>
		/// Value of variable $IO_IPCHE
		/// </summary>
		public bool IoIpche { get; }

		/// <summary>
		/// Value of variable $IO_RTRY_CNT
		/// </summary>
		public int IoRtryCnt { get; }

		/// <summary>
		/// Value of variable $IO_SCRN_UPD
		/// </summary>
		public int IoScrnUpd { get; }

		/// <summary>
		/// Value of variable $IO_UOP_CFG
		/// </summary>
		public IoUopCfgVariableType IoUopCfg { get; }

		/// <summary>
		/// Value of variable $IRCA_ACC
		/// </summary>
		public ItemAccVariableType[] IrcaAcc { get; }

		/// <summary>
		/// Value of variable $IRCA_BUF001
		/// </summary>
		public ItemBuffElVariableType[] IrcaBuf001 { get; }

		/// <summary>
		/// Value of variable $IRCA_BUF002
		/// </summary>
		public ItemBuffElVariableType[] IrcaBuf002 { get; }

		/// <summary>
		/// Value of variable $IRCA_BUF003
		/// </summary>
		public ItemBuffElVariableType[] IrcaBuf003 { get; }

		/// <summary>
		/// Value of variable $IRCA_CFG
		/// </summary>
		public IrcaCnfVariableType[] IrcaCfg { get; }

		/// <summary>
		/// Value of variable $IRCA_HIS001
		/// </summary>
		public HistDayVariableType[] IrcaHis001 { get; }

		/// <summary>
		/// Value of variable $IRCA_HIS002
		/// </summary>
		public HistDayVariableType[] IrcaHis002 { get; }

		/// <summary>
		/// Value of variable $IRCA_HIS003
		/// </summary>
		public HistDayVariableType[] IrcaHis003 { get; }

		/// <summary>
		/// Value of variable $IRCA_I_CFG
		/// </summary>
		public ItemNameVariableType[] IrcaICfg { get; }

		/// <summary>
		/// Value of variable $IRPROG_CFG
		/// </summary>
		public IrprogCfgVariableType IrprogCfg { get; }

		/// <summary>
		/// Value of variable $ISDT_ISOLC
		/// </summary>
		public int[] IsdtIsolc { get; }

		/// <summary>
		/// Value of variable $J23_DSP_ENB
		/// </summary>
		public bool J23DspEnb { get; }

		/// <summary>
		/// Value of variable $JINC
		/// </summary>
		public JincVariableType Jinc { get; }

		/// <summary>
		/// Value of variable $JOBPROC_ENB
		/// </summary>
		public int JobprocEnb { get; }

		/// <summary>
		/// Value of variable $JOG_IN_AUTO
		/// </summary>
		public int JogInAuto { get; }

		/// <summary>
		/// Value of variable $JPOSREC_ENB
		/// </summary>
		public int JposrecEnb { get; }

		/// <summary>
		/// Value of variable $KANJI_MASK
		/// </summary>
		public int KanjiMask { get; }

		/// <summary>
		/// Value of variable $KARELMON
		/// </summary>
		public KarelmonVariableType Karelmon { get; }

		/// <summary>
		/// Value of variable $KAREL_CFG
		/// </summary>
		public KarelCfgVariableType KarelCfg { get; }

		/// <summary>
		/// Value of variable $KAREL_ENB
		/// </summary>
		public int KarelEnb { get; }

		/// <summary>
		/// Value of variable $KCL_LIN_NUM
		/// </summary>
		public bool KclLinNum { get; }

		/// <summary>
		/// Value of variable $KEYLOGGING
		/// </summary>
		public int Keylogging { get; }

		/// <summary>
		/// Value of variable $LANGUAGE
		/// </summary>
		public string Language { get; }

		/// <summary>
		/// Value of variable $LGCFG
		/// </summary>
		public LgcfgVariableType Lgcfg { get; }

		/// <summary>
		/// Value of variable $LN_DISP
		/// </summary>
		public LnDispVariableType LnDisp { get; }

		/// <summary>
		/// Value of variable $LOCTOL
		/// </summary>
		public double Loctol { get; }

		/// <summary>
		/// Value of variable $LOGBOOK
		/// </summary>
		public LogbookVariableType Logbook { get; }

		/// <summary>
		/// Value of variable $LOG_BUFF
		/// </summary>
		public LogBuffVariableType[] LogBuff { get; }

		/// <summary>
		/// Value of variable $LOG_DCS
		/// </summary>
		public LogDcsVariableType LogDcs { get; }

		/// <summary>
		/// Value of variable $LOG_DIO
		/// </summary>
		public LogDioVariableType[] LogDio { get; }

		/// <summary>
		/// Value of variable $LOG_ER_ITM
		/// </summary>
		public int[] LogErItm { get; }

		/// <summary>
		/// Value of variable $LOG_ER_SEV
		/// </summary>
		public int LogErSev { get; }

		/// <summary>
		/// Value of variable $LOG_ER_TYP
		/// </summary>
		public int[] LogErTyp { get; }

		/// <summary>
		/// Value of variable $LOG_REC_RST
		/// </summary>
		public bool LogRecRst { get; }

		/// <summary>
		/// Value of variable $LOG_SCRN_FL
		/// </summary>
		public LogScrnFlVariableType[] LogScrnFl { get; }

		/// <summary>
		/// Value of variable $LOG_TPKEY
		/// </summary>
		public int[] LogTpkey { get; }

		/// <summary>
		/// Value of variable $LONGNAM_ENB
		/// </summary>
		public bool LongnamEnb { get; }

		/// <summary>
		/// Value of variable $LUPS_DIGIT
		/// </summary>
		public int LupsDigit { get; }

		/// <summary>
		/// Value of variable $LU_LOADPROG
		/// </summary>
		public string LuLoadprog { get; }

		/// <summary>
		/// Value of variable $MAXUALRMNUM
		/// </summary>
		public int Maxualrmnum { get; }

		/// <summary>
		/// Value of variable $MAX_DIG_PRT
		/// </summary>
		public int MaxDigPrt { get; }

		/// <summary>
		/// Value of variable $MCSP
		/// </summary>
		public McspVariableType Mcsp { get; }

		/// <summary>
		/// Value of variable $MCSP_GRP
		/// </summary>
		public McspGrpVariableType[] McspGrp { get; }

		/// <summary>
		/// Value of variable $MD_LDXDISAB
		/// </summary>
		public int MdLdxdisab { get; }

		/// <summary>
		/// Value of variable $MEMO_APNAME
		/// </summary>
		public string[] MemoApname { get; }

		/// <summary>
		/// Value of variable $MFRQ_CFG
		/// </summary>
		public MfrqCfgVariableType MfrqCfg { get; }

		/// <summary>
		/// Value of variable $MFRQ_GRP
		/// </summary>
		public MfrqGrpVariableType[] MfrqGrp { get; }

		/// <summary>
		/// Value of variable $MISC_MSTR
		/// </summary>
		public MiscMstrVariableType MiscMstr { get; }

		/// <summary>
		/// Value of variable $MISC_SCD
		/// </summary>
		public MiscScdVariableType[] MiscScd { get; }

		/// <summary>
		/// Value of variable $MKCFG
		/// </summary>
		public MkcfgVariableType Mkcfg { get; }

		/// <summary>
		/// Value of variable $MLTARM_CFG
		/// </summary>
		public MltarmCfgVariableType MltarmCfg { get; }

		/// <summary>
		/// Value of variable $MMETPU
		/// </summary>
		public int Mmetpu { get; }

		/// <summary>
		/// Value of variable $MNDSP_ADCOL
		/// </summary>
		public int MndspAdcol { get; }

		/// <summary>
		/// Value of variable $MNDSP_CMNT
		/// </summary>
		public int MndspCmnt { get; }

		/// <summary>
		/// Value of variable $MNDSP_FNCMN
		/// </summary>
		public int MndspFncmn { get; }

		/// <summary>
		/// Value of variable $MNDSP_FSTLI
		/// </summary>
		public int MndspFstli { get; }

		/// <summary>
		/// Value of variable $MNDSP_MST
		/// </summary>
		public MndspMstVariableType MndspMst { get; }

		/// <summary>
		/// Value of variable $MNDSP_POSCF
		/// </summary>
		public int MndspPoscf { get; }

		/// <summary>
		/// Value of variable $MNDSP_PRPMT
		/// </summary>
		public int MndspPrpmt { get; }

		/// <summary>
		/// Value of variable $MNDSP_PSTOL
		/// </summary>
		public MndsppstlVariableType[] MndspPstol { get; }

		/// <summary>
		/// Value of variable $MNSING_CHK
		/// </summary>
		public bool MnsingChk { get; }

		/// <summary>
		/// Value of variable $MODAQ_CFG
		/// </summary>
		public ModaqCfgVariableType ModaqCfg { get; }

		/// <summary>
		/// Value of variable $MODAQ_DEV
		/// </summary>
		public string ModaqDev { get; }

		/// <summary>
		/// Value of variable $MODAQ_HSIZE
		/// </summary>
		public int ModaqHsize { get; }

		/// <summary>
		/// Value of variable $MODAQ_TASK
		/// </summary>
		public string ModaqTask { get; }

		/// <summary>
		/// Value of variable $MODAQ_TRIG
		/// </summary>
		public FxTriggerVariableType[] ModaqTrig { get; }

		/// <summary>
		/// Value of variable $MODAQ_TYPE
		/// </summary>
		public int ModaqType { get; }

		/// <summary>
		/// Value of variable $MODEM_INF
		/// </summary>
		public ModemInfVariableType[] ModemInf { get; }

		/// <summary>
		/// Value of variable $MONITOR_MSG
		/// </summary>
		public string[] MonitorMsg { get; }

		/// <summary>
		/// Value of variable $MOR_GRP_SV
		/// </summary>
		public MorGrpSvVariableType[] MorGrpSv { get; }

		/// <summary>
		/// Value of variable $MOTION_DBG
		/// </summary>
		public MotionDbgVariableType MotionDbg { get; }

		/// <summary>
		/// Value of variable $MPL_NAME
		/// </summary>
		public string MplName { get; }

		/// <summary>
		/// Value of variable $MR_HIST
		/// </summary>
		public MrHistVariableType[] MrHist { get; }

		/// <summary>
		/// Value of variable $MSKCFMAP
		/// </summary>
		public int[] Mskcfmap { get; }

		/// <summary>
		/// Value of variable $MSKCONREL
		/// </summary>
		public int Mskconrel { get; }

		/// <summary>
		/// Value of variable $MSKEXCFENB
		/// </summary>
		public int Mskexcfenb { get; }

		/// <summary>
		/// Value of variable $MSKEXCFFNC
		/// </summary>
		public int Mskexcffnc { get; }

		/// <summary>
		/// Value of variable $MSKJOGOVLIM
		/// </summary>
		public int Mskjogovlim { get; }

		/// <summary>
		/// Value of variable $MSKKEY
		/// </summary>
		public int Mskkey { get; }

		/// <summary>
		/// Value of variable $MSKKEY_PANL
		/// </summary>
		public int MskkeyPanl { get; }

		/// <summary>
		/// Value of variable $MSKRUNOVLIM
		/// </summary>
		public int Mskrunovlim { get; }

		/// <summary>
		/// Value of variable $MSKSFSPDTYP
		/// </summary>
		public int Msksfspdtyp { get; }

		/// <summary>
		/// Value of variable $MSKSIGN
		/// </summary>
		public int Msksign { get; }

		/// <summary>
		/// Value of variable $MSKT1MOTLIM
		/// </summary>
		public int Mskt1motlim { get; }

		/// <summary>
		/// Value of variable $MSK_CE_GRP
		/// </summary>
		public MskCeGrpVariableType[] MskCeGrp { get; }

		/// <summary>
		/// Value of variable $MSQZ_EDIT
		/// </summary>
		public int MsqzEdit { get; }

		/// <summary>
		/// Value of variable $MTCOM_CFG
		/// </summary>
		public MtcomCfgVariableType[] MtcomCfg { get; }

		/// <summary>
		/// Value of variable $MT_ARC_ENB
		/// </summary>
		public bool MtArcEnb { get; }

		/// <summary>
		/// Value of variable $MT_MN_MODE
		/// </summary>
		public int MtMnMode { get; }

		/// <summary>
		/// Value of variable $MT_SPL_ENB
		/// </summary>
		public bool MtSplEnb { get; }

		/// <summary>
		/// Value of variable $MUAP_CPLENB
		/// </summary>
		public bool MuapCplenb { get; }

		/// <summary>
		/// Value of variable $NOCHECK
		/// </summary>
		public string[] Nocheck { get; }

		/// <summary>
		/// Value of variable $NO_WAIT_LN
		/// </summary>
		public int NoWaitLn { get; }

		/// <summary>
		/// Value of variable $NUM_RSPACE
		/// </summary>
		public int[] NumRspace { get; }

		/// <summary>
		/// Value of variable $ODRDSP_ENB
		/// </summary>
		public int OdrdspEnb { get; }

		/// <summary>
		/// Value of variable $OFFSET_CART
		/// </summary>
		public bool OffsetCart { get; }

		/// <summary>
		/// Value of variable $OFFSET_DIS
		/// </summary>
		public bool OffsetDis { get; }

		/// <summary>
		/// Value of variable $OFS_AT_MARK
		/// </summary>
		public int OfsAtMark { get; }

		/// <summary>
		/// Value of variable $OPEN_FILES
		/// </summary>
		public int OpenFiles { get; }

		/// <summary>
		/// Value of variable $OPTION_IO
		/// </summary>
		public int OptionIo { get; }

		/// <summary>
		/// Value of variable $OPTM_PRG
		/// </summary>
		public string OptmPrg { get; }

		/// <summary>
		/// Value of variable $OPWORK
		/// </summary>
		public OpworkVariableType Opwork { get; }

		/// <summary>
		/// Value of variable $ORG_DSBL
		/// </summary>
		public byte[] OrgDsbl { get; }

		/// <summary>
		/// Value of variable $ORIENTTOL
		/// </summary>
		public double Orienttol { get; }

		/// <summary>
		/// Value of variable $OUT_SIM_DO
		/// </summary>
		public int OutSimDo { get; }

		/// <summary>
		/// Value of variable $OVRDSLCT
		/// </summary>
		public OvrdslctVariableType Ovrdslct { get; }

		/// <summary>
		/// Value of variable $OVRD_PEXE
		/// </summary>
		public bool OvrdPexe { get; }

		/// <summary>
		/// Value of variable $OVRD_RATE
		/// </summary>
		public int OvrdRate { get; }

		/// <summary>
		/// Value of variable $OVRD_SETUP
		/// </summary>
		public OvrdSetupVariableType OvrdSetup { get; }

		/// <summary>
		/// Value of variable $PALCFG
		/// </summary>
		public PlcfgVariableType Palcfg { get; }

		/// <summary>
		/// Value of variable $PAL_POS_CHK
		/// </summary>
		public bool PalPosChk { get; }

		/// <summary>
		/// Value of variable $PARAM_MENU
		/// </summary>
		public string[] ParamMenu { get; }

		/// <summary>
		/// Value of variable $PAUSE_PROG
		/// </summary>
		public string PauseProg { get; }

		/// <summary>
		/// Value of variable $PCCRT
		/// </summary>
		public int Pccrt { get; }

		/// <summary>
		/// Value of variable $PCCRT_HOST
		/// </summary>
		public string PccrtHost { get; }

		/// <summary>
		/// Value of variable $PCTP
		/// </summary>
		public int Pctp { get; }

		/// <summary>
		/// Value of variable $PCTP_HOST
		/// </summary>
		public string PctpHost { get; }

		/// <summary>
		/// Value of variable $PC_TIMEOUT
		/// </summary>
		public int PcTimeout { get; }

		/// <summary>
		/// Value of variable $PGDEBUG
		/// </summary>
		public int Pgdebug { get; }

		/// <summary>
		/// Value of variable $PGINP_FLMSK
		/// </summary>
		public int PginpFlmsk { get; }

		/// <summary>
		/// Value of variable $PGINP_FLTR
		/// </summary>
		public int PginpFltr { get; }

		/// <summary>
		/// Value of variable $PGINP_PGATR
		/// </summary>
		public int[] PginpPgatr { get; }

		/// <summary>
		/// Value of variable $PGINP_PGCHK
		/// </summary>
		public int PginpPgchk { get; }

		/// <summary>
		/// Value of variable $PGINP_TYPE
		/// </summary>
		public string[] PginpType { get; }

		/// <summary>
		/// Value of variable $PGINP_WORD
		/// </summary>
		public string[] PginpWord { get; }

		/// <summary>
		/// Value of variable $PGLOG
		/// </summary>
		public int Pglog { get; }

		/// <summary>
		/// Value of variable $PGTRACECTL
		/// </summary>
		public TracectlVariableType[] Pgtracectl { get; }

		/// <summary>
		/// Value of variable $PGTRACEDT
		/// </summary>
		public TracedtVariableType[,] Pgtracedt { get; }

		/// <summary>
		/// Value of variable $PGTRACELEN
		/// </summary>
		public int Pgtracelen { get; }

		/// <summary>
		/// Value of variable $PGTRACE_UP
		/// </summary>
		public TraceupVariableType PgtraceUp { get; }

		/// <summary>
		/// Value of variable $PG_CFG
		/// </summary>
		public PgCfgVariableType PgCfg { get; }

		/// <summary>
		/// Value of variable $PG_DEFSPD
		/// </summary>
		public PgDefspdVariableType PgDefspd { get; }

		/// <summary>
		/// Value of variable $PING_CTRL
		/// </summary>
		public PingVariableType PingCtrl { get; }

		/// <summary>
		/// Value of variable $PIPE_CONFIG
		/// </summary>
		public PipeCfgVariableType PipeConfig { get; }

		/// <summary>
		/// Value of variable $PLID_CFG
		/// </summary>
		public PlidCfgVariableType PlidCfg { get; }

		/// <summary>
		/// Value of variable $PLID_CLLB
		/// </summary>
		public PlidCllbVariableType[] PlidCllb { get; }

		/// <summary>
		/// Value of variable $PLID_KNOW_M
		/// </summary>
		public bool PlidKnowM { get; }

		/// <summary>
		/// Value of variable $PLIM_GRP
		/// </summary>
		public PlimGrpVariableType[] PlimGrp { get; }

		/// <summary>
		/// Value of variable $PLMR_GRP
		/// </summary>
		public PlmrGrpVariableType[] PlmrGrp { get; }

		/// <summary>
		/// Value of variable $PLOADBANFWD
		/// </summary>
		public bool Ploadbanfwd { get; }

		/// <summary>
		/// Value of variable $PLST_GRP6
		/// </summary>
		public PlstGrpVariableType[] PlstGrp6 { get; }

		/// <summary>
		/// Value of variable $PLST_GRP7
		/// </summary>
		public PlstGrpVariableType[] PlstGrp7 { get; }

		/// <summary>
		/// Value of variable $PLST_GRP8
		/// </summary>
		public PlstGrpVariableType[] PlstGrp8 { get; }

		/// <summary>
		/// Value of variable $PLST_OVLD
		/// </summary>
		public bool[] PlstOvld { get; }

		/// <summary>
		/// Value of variable $PLS_CMP_LIM
		/// </summary>
		public int PlsCmpLim { get; }

		/// <summary>
		/// Value of variable $PLS_ER_CHK
		/// </summary>
		public int PlsErChk { get; }

		/// <summary>
		/// Value of variable $PLS_ER_LIM
		/// </summary>
		public int PlsErLim { get; }

		/// <summary>
		/// Value of variable $PLS_ER_RST
		/// </summary>
		public bool PlsErRst { get; }

		/// <summary>
		/// Value of variable $PL_MOD
		/// </summary>
		public bool PlMod { get; }

		/// <summary>
		/// Value of variable $PL_MOD_ST
		/// </summary>
		public bool PlModSt { get; }

		/// <summary>
		/// Value of variable $PL_RES_G1
		/// </summary>
		public PlResGVariableType[] PlResG1 { get; }

		/// <summary>
		/// Value of variable $PL_RES_G2
		/// </summary>
		public PlResGVariableType[] PlResG2 { get; }

		/// <summary>
		/// Value of variable $PL_RES_G3
		/// </summary>
		public PlResGVariableType[] PlResG3 { get; }

		/// <summary>
		/// Value of variable $PL_RES_G4
		/// </summary>
		public PlResGVariableType[] PlResG4 { get; }

		/// <summary>
		/// Value of variable $PL_RES_G5
		/// </summary>
		public PlResGVariableType[] PlResG5 { get; }

		/// <summary>
		/// Value of variable $PL_RES_G6
		/// </summary>
		public PlResGVariableType[] PlResG6 { get; }

		/// <summary>
		/// Value of variable $PL_RES_G7
		/// </summary>
		public PlResGVariableType[] PlResG7 { get; }

		/// <summary>
		/// Value of variable $PL_RES_G8
		/// </summary>
		public PlResGVariableType[] PlResG8 { get; }

		/// <summary>
		/// Value of variable $PL_THR_INRT
		/// </summary>
		public int PlThrInrt { get; }

		/// <summary>
		/// Value of variable $PL_THR_MASS
		/// </summary>
		public int PlThrMass { get; }

		/// <summary>
		/// Value of variable $PL_THR_MMNT
		/// </summary>
		public int PlThrMmnt { get; }

		/// <summary>
		/// Value of variable $PMON_QUEUE
		/// </summary>
		public PmonQueVariableType PmonQueue { get; }

		/// <summary>
		/// Value of variable $PNS_CUR_LIN
		/// </summary>
		public int PnsCurLin { get; }

		/// <summary>
		/// Value of variable $PNS_END_CUR
		/// </summary>
		public bool PnsEndCur { get; }

		/// <summary>
		/// Value of variable $PNS_END_EXE
		/// </summary>
		public bool PnsEndExe { get; }

		/// <summary>
		/// Value of variable $PNS_NUMBER
		/// </summary>
		public int PnsNumber { get; }

		/// <summary>
		/// Value of variable $PNS_OPTION
		/// </summary>
		public int PnsOption { get; }

		/// <summary>
		/// Value of variable $PNS_PROGRAM
		/// </summary>
		public string PnsProgram { get; }

		/// <summary>
		/// Value of variable $PNS_TASK_ID
		/// </summary>
		public int PnsTaskId { get; }

		/// <summary>
		/// Value of variable $POCFG
		/// </summary>
		public PocfgVariableType Pocfg { get; }

		/// <summary>
		/// Value of variable $POS_EDIT
		/// </summary>
		public PosEditVariableType PosEdit { get; }

		/// <summary>
		/// Value of variable $PRGADJ
		/// </summary>
		public PrgadjVariableType Prgadj { get; }

		/// <summary>
		/// Value of variable $PRGNS_CFG
		/// </summary>
		public PrgnsCfgVariableType PrgnsCfg { get; }

		/// <summary>
		/// Value of variable $PRGNS_GRP
		/// </summary>
		public PrgnsGrpVariableType[] PrgnsGrp { get; }

		/// <summary>
		/// Value of variable $PRGNS_PREF
		/// </summary>
		public PrgnsPrefVariableType PrgnsPref { get; }

		/// <summary>
		/// Value of variable $PRIORITY
		/// </summary>
		public int Priority { get; }

		/// <summary>
		/// Value of variable $PRODUCT_ID
		/// </summary>
		public string ProductId { get; }

		/// <summary>
		/// Value of variable $PROGGRP_TGL
		/// </summary>
		public int ProggrpTgl { get; }

		/// <summary>
		/// Value of variable $PROHIBIT_DO
		/// </summary>
		public bool ProhibitDo { get; }

		/// <summary>
		/// Value of variable $PROTOENT
		/// </summary>
		public ProtoentVariableType[] Protoent { get; }

		/// <summary>
		/// Value of variable $PROXY_CFG
		/// </summary>
		public ProxyCfgVariableType ProxyCfg { get; }

		/// <summary>
		/// Value of variable $PRO_CFG
		/// </summary>
		public PfCfgVariableType ProCfg { get; }

		/// <summary>
		/// Value of variable $PRO_ENHANCE
		/// </summary>
		public PfEnhanceVariableType ProEnhance { get; }

		/// <summary>
		/// Value of variable $PRO_PREF
		/// </summary>
		public PfPrefVariableType ProPref { get; }

		/// <summary>
		/// Value of variable $PRPORT_NUM
		/// </summary>
		public int PrportNum { get; }

		/// <summary>
		/// Value of variable $PR_CARTREP
		/// </summary>
		public bool PrCartrep { get; }

		/// <summary>
		/// Value of variable $PSKSTAT
		/// </summary>
		public int Pskstat { get; }

		/// <summary>
		/// Value of variable $PSLGSET
		/// </summary>
		public PslgsetVariableType Pslgset { get; }

		/// <summary>
		/// Value of variable $PSLGTEMP
		/// </summary>
		public PslgtempVariableType Pslgtemp { get; }

		/// <summary>
		/// Value of variable $PSLGVERSION
		/// </summary>
		public string Pslgversion { get; }

		/// <summary>
		/// Value of variable $PSSAVE
		/// </summary>
		public PssaveVariableType Pssave { get; }

		/// <summary>
		/// Value of variable $PURGE_ENBL
		/// </summary>
		public bool PurgeEnbl { get; }

		/// <summary>
		/// Value of variable $PWF_IO
		/// </summary>
		public int PwfIo { get; }

		/// <summary>
		/// Value of variable $PWRUP_DELAY
		/// </summary>
		public PwrupDlyVariableType PwrupDelay { get; }

		/// <summary>
		/// Value of variable $PWR_NORMAL
		/// </summary>
		public string PwrNormal { get; }

		/// <summary>
		/// Value of variable $PWR_SEMI
		/// </summary>
		public string PwrSemi { get; }

		/// <summary>
		/// Value of variable $QSKIP_GRP
		/// </summary>
		public QskipGrpVariableType[] QskipGrp { get; }

		/// <summary>
		/// Value of variable $RBTIF
		/// </summary>
		public int Rbtif { get; }

		/// <summary>
		/// Value of variable $RCVTMOUT
		/// </summary>
		public int Rcvtmout { get; }

		/// <summary>
		/// Value of variable $RDCR_GRP
		/// </summary>
		public RdcrGrpVariableType[] RdcrGrp { get; }

		/// <summary>
		/// Value of variable $RDIO_TYPE
		/// </summary>
		public int[] RdioType { get; }

		/// <summary>
		/// Value of variable $REDPROT_CFG
		/// </summary>
		public RedprotCfgVariableType RedprotCfg { get; }

		/// <summary>
		/// Value of variable $REDPROT_GRP
		/// </summary>
		public RedprotGrpVariableType[] RedprotGrp { get; }

		/// <summary>
		/// Value of variable $REFPOS1
		/// </summary>
		public Refpos11VariableType[] Refpos1 { get; }

		/// <summary>
		/// Value of variable $REFPOS2
		/// </summary>
		public Refpos21VariableType[] Refpos2 { get; }

		/// <summary>
		/// Value of variable $REFPOS3
		/// </summary>
		public Refpos31VariableType[] Refpos3 { get; }

		/// <summary>
		/// Value of variable $REFPOS4
		/// </summary>
		public Refpos41VariableType[] Refpos4 { get; }

		/// <summary>
		/// Value of variable $REFPOS5
		/// </summary>
		public Refpos51VariableType[] Refpos5 { get; }

		/// <summary>
		/// Value of variable $REFPOS6
		/// </summary>
		public Refpos61VariableType[] Refpos6 { get; }

		/// <summary>
		/// Value of variable $REFPOS7
		/// </summary>
		public Refpos71VariableType[] Refpos7 { get; }

		/// <summary>
		/// Value of variable $REFPOS8
		/// </summary>
		public Refpos81VariableType[] Refpos8 { get; }

		/// <summary>
		/// Value of variable $REFPOSMASK
		/// </summary>
		public RefpsmskVariableType[] Refposmask { get; }

		/// <summary>
		/// Value of variable $REFPOSMAXNO
		/// </summary>
		public int[] Refposmaxno { get; }

		/// <summary>
		/// Value of variable $REMOTE
		/// </summary>
		public int Remote { get; }

		/// <summary>
		/// Value of variable $REMOTE_CFG
		/// </summary>
		public RemoteCfgVariableType RemoteCfg { get; }

		/// <summary>
		/// Value of variable $REPL_RANGE
		/// </summary>
		public int ReplRange { get; }

		/// <summary>
		/// Value of variable $REPOWER
		/// </summary>
		public RepowerVariableType Repower { get; }

		/// <summary>
		/// Value of variable $RESM_DRYPRG
		/// </summary>
		public string ResmDryprg { get; }

		/// <summary>
		/// Value of variable $RESTART
		/// </summary>
		public RestartVariableType Restart { get; }

		/// <summary>
		/// Value of variable $RESUME_PROG
		/// </summary>
		public string ResumeProg { get; }

		/// <summary>
		/// Value of variable $RE_EXEC_ENB
		/// </summary>
		public bool ReExecEnb { get; }

		/// <summary>
		/// Value of variable $RGSPD_PREXE
		/// </summary>
		public bool RgspdPrexe { get; }

		/// <summary>
		/// Value of variable $RGTDB_PREXE
		/// </summary>
		public bool RgtdbPrexe { get; }

		/// <summary>
		/// Value of variable $RGTRM_PREXE
		/// </summary>
		public bool RgtrmPrexe { get; }

		/// <summary>
		/// Value of variable $RI_AIRPURGE
		/// </summary>
		public bool[] RiAirpurge { get; }

		/// <summary>
		/// Value of variable $RMT_MASTER
		/// </summary>
		public int RmtMaster { get; }

		/// <summary>
		/// Value of variable $ROBOT_ISOLC
		/// </summary>
		public int[] RobotIsolc { get; }

		/// <summary>
		/// Value of variable $ROBOT_NAME
		/// </summary>
		public string RobotName { get; }

		/// <summary>
		/// Value of variable $ROB_CATEG
		/// </summary>
		public int[] RobCateg { get; }

		/// <summary>
		/// Value of variable $ROB_ORD_NUM
		/// </summary>
		public string[] RobOrdNum { get; }

		/// <summary>
		/// Value of variable $RPC_TIMEOUT
		/// </summary>
		public int RpcTimeout { get; }

		/// <summary>
		/// Value of variable $RS232_CFG
		/// </summary>
		public Rs232CfgVariableType[] Rs232Cfg { get; }

		/// <summary>
		/// Value of variable $RS232_NPORT
		/// </summary>
		public int Rs232Nport { get; }

		/// <summary>
		/// Value of variable $RSCH_LOG
		/// </summary>
		public RschVariableType RschLog { get; }

		/// <summary>
		/// Value of variable $RSMAVAILNUM
		/// </summary>
		public int Rsmavailnum { get; }

		/// <summary>
		/// Value of variable $RSPACE1
		/// </summary>
		public RspaceVariableType[] Rspace1 { get; }

		/// <summary>
		/// Value of variable $RSPACE2
		/// </summary>
		public RspaceVariableType[] Rspace2 { get; }

		/// <summary>
		/// Value of variable $RSPACE3
		/// </summary>
		public RspaceVariableType[] Rspace3 { get; }

		/// <summary>
		/// Value of variable $RSPACE4
		/// </summary>
		public RspaceVariableType[] Rspace4 { get; }

		/// <summary>
		/// Value of variable $RSPACE5
		/// </summary>
		public RspaceVariableType[] Rspace5 { get; }

		/// <summary>
		/// Value of variable $RSPACE6
		/// </summary>
		public RspaceVariableType[] Rspace6 { get; }

		/// <summary>
		/// Value of variable $RSPACE7
		/// </summary>
		public RspaceVariableType[] Rspace7 { get; }

		/// <summary>
		/// Value of variable $RSPACE8
		/// </summary>
		public RspaceVariableType[] Rspace8 { get; }

		/// <summary>
		/// Value of variable $RSPACEG
		/// </summary>
		public RspacegVariableType Rspaceg { get; }

		/// <summary>
		/// Value of variable $RSPACE_MODE
		/// </summary>
		public int RspaceMode { get; }

		/// <summary>
		/// Value of variable $RSPACE_S
		/// </summary>
		public RspacesrVariableType RspaceS { get; }

		/// <summary>
		/// Value of variable $RSPCWORK_AD
		/// </summary>
		public int RspcworkAd { get; }

		/// <summary>
		/// Value of variable $RSR
		/// </summary>
		public byte[] Rsr { get; }

		/// <summary>
		/// Value of variable $RSR_INTVAL
		/// </summary>
		public int RsrIntval { get; }

		/// <summary>
		/// Value of variable $RSR_OPTION
		/// </summary>
		public int RsrOption { get; }

		/// <summary>
		/// Value of variable $SAF_DO_PULS
		/// </summary>
		public int SafDoPuls { get; }

		/// <summary>
		/// Value of variable $SCAN_TIME
		/// </summary>
		public int ScanTime { get; }

		/// <summary>
		/// Value of variable $SEL_DEFAULT
		/// </summary>
		public int SelDefault { get; }

		/// <summary>
		/// Value of variable $SEL_HOTSTRT
		/// </summary>
		public int SelHotstrt { get; }

		/// <summary>
		/// Value of variable $SEMIPOWERFL
		/// </summary>
		public bool Semipowerfl { get; }

		/// <summary>
		/// Value of variable $SEMIPWFDO
		/// </summary>
		public int Semipwfdo { get; }

		/// <summary>
		/// Value of variable $SERVENT
		/// </summary>
		public ServentVariableType[] Servent { get; }

		/// <summary>
		/// Value of variable $SERVICE_KL
		/// </summary>
		public string[] ServiceKl { get; }

		/// <summary>
		/// Value of variable $SERVICE_PRG
		/// </summary>
		public string[] ServicePrg { get; }

		/// <summary>
		/// Value of variable $SERV_DEV
		/// </summary>
		public string ServDev { get; }

		/// <summary>
		/// Value of variable $SERV_MAIL
		/// </summary>
		public int ServMail { get; }

		/// <summary>
		/// Value of variable $SERV_OUTPUT
		/// </summary>
		public int ServOutput { get; }

		/// <summary>
		/// Value of variable $SERV_SAVE
		/// </summary>
		public int ServSave { get; }

		/// <summary>
		/// Value of variable $SERV_TYPE
		/// </summary>
		public int ServType { get; }

		/// <summary>
		/// Value of variable $SFZN_CFG
		/// </summary>
		public SfznCfgVariableType SfznCfg { get; }

		/// <summary>
		/// Value of variable $SFZN_GRP
		/// </summary>
		public SfznGrpVariableType[] SfznGrp { get; }

		/// <summary>
		/// Value of variable $SHELL_CFG
		/// </summary>
		public ShellCfgVariableType ShellCfg { get; }

		/// <summary>
		/// Value of variable $SHELL_CHK
		/// </summary>
		public ShellChkVariableType[] ShellChk { get; }

		/// <summary>
		/// Value of variable $SHELL_COMM
		/// </summary>
		public ShellCommVariableType ShellComm { get; }

		/// <summary>
		/// Value of variable $SHFTOV_ENB
		/// </summary>
		public int ShftovEnb { get; }

		/// <summary>
		/// Value of variable $SHOW_REG_UI
		/// </summary>
		public int ShowRegUi { get; }

		/// <summary>
		/// Value of variable $SIMIOFWDLM
		/// </summary>
		public SimiofwdlmVariableType Simiofwdlm { get; }

		/// <summary>
		/// Value of variable $SI_UNIT_ENB
		/// </summary>
		public bool SiUnitEnb { get; }

		/// <summary>
		/// Value of variable $SLC_RETRY
		/// </summary>
		public int SlcRetry { get; }

		/// <summary>
		/// Value of variable $SMON_ALIAS
		/// </summary>
		public string[] SmonAlias { get; }

		/// <summary>
		/// Value of variable $SMON_DEFPROG
		/// </summary>
		public string SmonDefprog { get; }

		/// <summary>
		/// Value of variable $SMON_RECALL
		/// </summary>
		public string[] SmonRecall { get; }

		/// <summary>
		/// Value of variable $SNPX_ASG
		/// </summary>
		public SnpxAsgVariableType[] SnpxAsg { get; }

		/// <summary>
		/// Value of variable $SNPX_PARAM
		/// </summary>
		public SnpxParamVariableType SnpxParam { get; }

		/// <summary>
		/// Value of variable $SOFT_KB_CFG
		/// </summary>
		public int SoftKbCfg { get; }

		/// <summary>
		/// Value of variable $SOPIN_SIM
		/// </summary>
		public int[] SopinSim { get; }

		/// <summary>
		/// Value of variable $SRVNORDY_DO
		/// </summary>
		public bool SrvnordyDo { get; }

		/// <summary>
		/// Value of variable $SRVQSTP_DSB
		/// </summary>
		public int[] SrvqstpDsb { get; }

		/// <summary>
		/// Value of variable $SSR
		/// </summary>
		public SsrVariableType Ssr { get; }

		/// <summary>
		/// Value of variable $STOP_ON_ERR
		/// </summary>
		public bool StopOnErr { get; }

		/// <summary>
		/// Value of variable $STOP_PTN
		/// </summary>
		public string StopPtn { get; }

		/// <summary>
		/// Value of variable $STRING_PRM
		/// </summary>
		public bool StringPrm { get; }

		/// <summary>
		/// Value of variable $SVDT_GRP
		/// </summary>
		public SvdtGrpVariableType[] SvdtGrp { get; }

		/// <summary>
		/// Value of variable $SVPRG_COUNT
		/// </summary>
		public int SvprgCount { get; }

		/// <summary>
		/// Value of variable $SVPRG_ENB
		/// </summary>
		public bool SvprgEnb { get; }

		/// <summary>
		/// Value of variable $SVPRM_ENB
		/// </summary>
		public int SvprmEnb { get; }

		/// <summary>
		/// Value of variable $SVPRM_UPD
		/// </summary>
		public SvprmUpdVariableType[] SvprmUpd { get; }

		/// <summary>
		/// Value of variable $SV_INFO
		/// </summary>
		public SvInfoVariableType[] SvInfo { get; }

		/// <summary>
		/// Value of variable $SYSDEBUG
		/// </summary>
		public int Sysdebug { get; }

		/// <summary>
		/// Value of variable $SYSDSP_PASS
		/// </summary>
		public int SysdspPass { get; }

		/// <summary>
		/// Value of variable $SYSLOG
		/// </summary>
		public SyslogVariableType Syslog { get; }

		/// <summary>
		/// Value of variable $SYSLOG_MPC
		/// </summary>
		public SyslogVariableType SyslogMpc { get; }

		/// <summary>
		/// Value of variable $SYSLOG_SAV
		/// </summary>
		public SyslogSavVariableType SyslogSav { get; }

		/// <summary>
		/// Value of variable $SYSTEM_TIME
		/// </summary>
		public SystemTimerVariableType[] SystemTime { get; }

		/// <summary>
		/// Value of variable $SYSTSKMEM
		/// </summary>
		public short[] Systskmem { get; }

		/// <summary>
		/// Value of variable $T1SVGUNSPD
		/// </summary>
		public int T1svgunspd { get; }

		/// <summary>
		/// Value of variable $T2MODE_LIM
		/// </summary>
		public T2modeLimVariableType T2modeLim { get; }

		/// <summary>
		/// Value of variable $T2SPDLIM
		/// </summary>
		public T2spdlimVariableType T2spdlim { get; }

		/// <summary>
		/// Value of variable $TA_DISP_ENB
		/// </summary>
		public bool TaDispEnb { get; }

		/// <summary>
		/// Value of variable $TBC2_GRP
		/// </summary>
		public Tbc2GrpVariableType[] Tbc2Grp { get; }

		/// <summary>
		/// Value of variable $TBCSG_GRP
		/// </summary>
		public TbcsgGrpVariableType[] TbcsgGrp { get; }

		/// <summary>
		/// Value of variable $TBJ2_GRP
		/// </summary>
		public Tbj2GrpVariableType[] Tbj2Grp { get; }

		/// <summary>
		/// Value of variable $TBJOP_GRP
		/// </summary>
		public TbjopGrpVariableType[] TbjopGrp { get; }

		/// <summary>
		/// Value of variable $THRESTABLE
		/// </summary>
		public TpThrTableVariableType[] Threstable { get; }

		/// <summary>
		/// Value of variable $THRRDITABLE
		/// </summary>
		public TpThrTableVariableType[] Thrrditable { get; }

		/// <summary>
		/// Value of variable $THRRDOTABLE
		/// </summary>
		public TpThrTableVariableType[] Thrrdotable { get; }

		/// <summary>
		/// Value of variable $THRSDITABLE
		/// </summary>
		public TpThrTableVariableType[] Thrsditable { get; }

		/// <summary>
		/// Value of variable $THRSITABLE
		/// </summary>
		public TpThrTableVariableType[] Thrsitable { get; }

		/// <summary>
		/// Value of variable $THRTABLENUM
		/// </summary>
		public short[] Thrtablenum { get; }

		/// <summary>
		/// Value of variable $THR_CFG
		/// </summary>
		public ThrCfgVariableType ThrCfg { get; }

		/// <summary>
		/// Value of variable $TIMEBF_TTS
		/// </summary>
		public int TimebfTts { get; }

		/// <summary>
		/// Value of variable $TIMEBF_VER
		/// </summary>
		public int TimebfVer { get; }

		/// <summary>
		/// Value of variable $TIMER
		/// </summary>
		public TimerVariableType[] Timer { get; }

		/// <summary>
		/// Value of variable $TIMER_NUM
		/// </summary>
		public int TimerNum { get; }

		/// <summary>
		/// Value of variable $TMI_CHAN
		/// </summary>
		public int TmiChan { get; }

		/// <summary>
		/// Value of variable $TMI_DBGLVL
		/// </summary>
		public int TmiDbglvl { get; }

		/// <summary>
		/// Value of variable $TMI_ETHERAD
		/// </summary>
		public string[] TmiEtherad { get; }

		/// <summary>
		/// Value of variable $TMI_ROUTER
		/// </summary>
		public string TmiRouter { get; }

		/// <summary>
		/// Value of variable $TMI_SNMASK
		/// </summary>
		public string[] TmiSnmask { get; }

		/// <summary>
		/// Value of variable $TOOLOFS_DIS
		/// </summary>
		public bool ToolofsDis { get; }

		/// <summary>
		/// Value of variable $TPE_DETAIL
		/// </summary>
		public int TpeDetail { get; }

		/// <summary>
		/// Value of variable $TPGL_CONFIG
		/// </summary>
		public TpglConfVariableType TpglConfig { get; }

		/// <summary>
		/// Value of variable $TPGL_OUTPUT
		/// </summary>
		public TpglOutVariableType TpglOutput { get; }

		/// <summary>
		/// Value of variable $TPOFF_LIM
		/// </summary>
		public int TpoffLim { get; }

		/// <summary>
		/// Value of variable $TPON_SVOFF
		/// </summary>
		public bool TponSvoff { get; }

		/// <summary>
		/// Value of variable $TPP_MON
		/// </summary>
		public TppMonVariableType TppMon { get; }

		/// <summary>
		/// Value of variable $TPSTRTCHK
		/// </summary>
		public TpstrtchkVariableType Tpstrtchk { get; }

		/// <summary>
		/// Value of variable $TPVTCOMPAT
		/// </summary>
		public bool Tpvtcompat { get; }

		/// <summary>
		/// Value of variable $TPVWVAR
		/// </summary>
		public TpvwvarVariableType Tpvwvar { get; }

		/// <summary>
		/// Value of variable $TP_DEFPROG
		/// </summary>
		public string TpDefprog { get; }

		/// <summary>
		/// Value of variable $TP_DISPLAY
		/// </summary>
		public int TpDisplay { get; }

		/// <summary>
		/// Value of variable $TP_INST_MSK
		/// </summary>
		public int[] TpInstMsk { get; }

		/// <summary>
		/// Value of variable $TP_INUSER
		/// </summary>
		public bool TpInuser { get; }

		/// <summary>
		/// Value of variable $TP_LCKUSER
		/// </summary>
		public bool TpLckuser { get; }

		/// <summary>
		/// Value of variable $TP_QUICKMEN
		/// </summary>
		public bool TpQuickmen { get; }

		/// <summary>
		/// Value of variable $TP_SCREEN
		/// </summary>
		public string TpScreen { get; }

		/// <summary>
		/// Value of variable $TP_USERSCRN
		/// </summary>
		public string TpUserscrn { get; }

		/// <summary>
		/// Value of variable $TP_USESTAT
		/// </summary>
		public bool TpUsestat { get; }

		/// <summary>
		/// Value of variable $TRACE_CFG
		/// </summary>
		public TraceCfgVariableType TraceCfg { get; }

		/// <summary>
		/// Value of variable $TRACE_CHNL
		/// </summary>
		public TraceChnlVariableType[] TraceChnl { get; }

		/// <summary>
		/// Value of variable $TRACE_ITEM
		/// </summary>
		public TraceItemVariableType[] TraceItem { get; }

		/// <summary>
		/// Value of variable $TSCFG
		/// </summary>
		public TscfgVariableType Tscfg { get; }

		/// <summary>
		/// Value of variable $TSSCB
		/// </summary>
		public TsscbVariableType[] Tsscb { get; }

		/// <summary>
		/// Value of variable $TUTORIAL
		/// </summary>
		public TutorialVariableType Tutorial { get; }

		/// <summary>
		/// Value of variable $TV_CONFIG
		/// </summary>
		public TvConfigVariableType TvConfig { get; }

		/// <summary>
		/// Value of variable $TV_OUTPUT
		/// </summary>
		public TvOutputVariableType TvOutput { get; }

		/// <summary>
		/// Value of variable $TX_SCREEN
		/// </summary>
		public TxscreenVariableType[] TxScreen { get; }

		/// <summary>
		/// Value of variable $UALRM_MSG
		/// </summary>
		public string[] UalrmMsg { get; }

		/// <summary>
		/// Value of variable $UALRM_SEV
		/// </summary>
		public byte[] UalrmSev { get; }

		/// <summary>
		/// Value of variable $UECFG
		/// </summary>
		public UecfgVariableType Uecfg { get; }

		/// <summary>
		/// Value of variable $UEGRP
		/// </summary>
		public UegrpVariableType[] Uegrp { get; }

		/// <summary>
		/// Value of variable $UI_BBL_NOTE
		/// </summary>
		public BblNtWndVariableType UiBblNote { get; }

		/// <summary>
		/// Value of variable $UI_DEFPROG
		/// </summary>
		public string[] UiDefprog { get; }

		/// <summary>
		/// Value of variable $UI_FKEYDATA
		/// </summary>
		public UiFkeydatVariableType[] UiFkeydata { get; }

		/// <summary>
		/// Value of variable $UI_INUSER
		/// </summary>
		public bool[] UiInuser { get; }

		/// <summary>
		/// Value of variable $UI_MENHIST
		/// </summary>
		public UiMenhisVariableType[] UiMenhist { get; }

		/// <summary>
		/// Value of variable $UI_PANEDATA
		/// </summary>
		public UiPanedatVariableType[] UiPanedata { get; }

		/// <summary>
		/// Value of variable $UI_POSTYPE
		/// </summary>
		public int[] UiPostype { get; }

		/// <summary>
		/// Value of variable $UI_QUICKMEN
		/// </summary>
		public bool[] UiQuickmen { get; }

		/// <summary>
		/// Value of variable $UI_RESTORE
		/// </summary>
		public UiUsrviewVariableType[] UiRestore { get; }

		/// <summary>
		/// Value of variable $UI_SCREEN
		/// </summary>
		public string[] UiScreen { get; }

		/// <summary>
		/// Value of variable $UI_STATE
		/// </summary>
		public int[] UiState { get; }

		/// <summary>
		/// Value of variable $UI_USERSCRN
		/// </summary>
		public string[] UiUserscrn { get; }

		/// <summary>
		/// Value of variable $UNDO_CFG
		/// </summary>
		public UndoCfgVariableType UndoCfg { get; }

		/// <summary>
		/// Value of variable $UOP_CRM5
		/// </summary>
		public bool UopCrm5 { get; }

		/// <summary>
		/// Value of variable $UPDATE
		/// </summary>
		public string Update { get; }

		/// <summary>
		/// Value of variable $USER_INFO
		/// </summary>
		public UserInfoVariableType[] UserInfo { get; }

		/// <summary>
		/// Value of variable $USER_OFFSET
		/// </summary>
		public UserOffstVariableType UserOffset { get; }

		/// <summary>
		/// Value of variable $USER_WORK
		/// </summary>
		public UserWorkVariableType UserWork { get; }

		/// <summary>
		/// Value of variable $USEUFRAME
		/// </summary>
		public bool Useuframe { get; }

		/// <summary>
		/// Value of variable $USRTOL_ABRT
		/// </summary>
		public bool UsrtolAbrt { get; }

		/// <summary>
		/// Value of variable $USRTOL_ENB
		/// </summary>
		public bool UsrtolEnb { get; }

		/// <summary>
		/// Value of variable $USRTOL_GRP
		/// </summary>
		public UsrtolGrpVariableType[] UsrtolGrp { get; }

		/// <summary>
		/// Value of variable $USRTOL_MSK
		/// </summary>
		public int UsrtolMsk { get; }

		/// <summary>
		/// Value of variable $USRTOL_NAME
		/// </summary>
		public string UsrtolName { get; }

		/// <summary>
		/// Value of variable $USR_EVNT
		/// </summary>
		public int UsrEvnt { get; }

		/// <summary>
		/// Value of variable $USR_EV_CFG
		/// </summary>
		public UsrEvCfgVariableType[] UsrEvCfg { get; }

		/// <summary>
		/// Value of variable $USR_EV_WRK
		/// </summary>
		public UsrEvWrkVariableType[] UsrEvWrk { get; }

		/// <summary>
		/// Value of variable $VARS_CONFIG
		/// </summary>
		public VarsConfigVariableType VarsConfig { get; }

		/// <summary>
		/// Value of variable $VCMR_GRP
		/// </summary>
		public VcmrGrpVariableType[] VcmrGrp { get; }

		/// <summary>
		/// Value of variable $VIA_WORK
		/// </summary>
		public ViaWorkVariableType ViaWork { get; }

		/// <summary>
		/// Value of variable $VISIONTMOUT
		/// </summary>
		public int Visiontmout { get; }

		/// <summary>
		/// Value of variable $VISION_CFG
		/// </summary>
		public VisionCfgVariableType VisionCfg { get; }

		/// <summary>
		/// Value of variable $VISION_GRP
		/// </summary>
		public VisionGrpVariableType[] VisionGrp { get; }

		/// <summary>
		/// Value of variable $VIS_GE_CFG
		/// </summary>
		public VisGeCfgVariableType VisGeCfg { get; }

		/// <summary>
		/// Value of variable $VIS_LOGREG
		/// </summary>
		public VisLogregVariableType VisLogreg { get; }

		/// <summary>
		/// Value of variable $VLEXE_CFG
		/// </summary>
		public VlexeCfgVariableType VlexeCfg { get; }

		/// <summary>
		/// Value of variable $VRTD_FILTER
		/// </summary>
		public VrtdFiltVariableType[] VrtdFilter { get; }

		/// <summary>
		/// Value of variable $VSHIFTMENU
		/// </summary>
		public CustommenuVariableType[] Vshiftmenu { get; }

		/// <summary>
		/// Value of variable $VSHIFT_CFG
		/// </summary>
		public VsftCfgVariableType VshiftCfg { get; }

		/// <summary>
		/// Value of variable $VSMO_CFG
		/// </summary>
		public VsmoCfgVariableType VsmoCfg { get; }

		/// <summary>
		/// Value of variable $VZDT_CFG
		/// </summary>
		public VzdtCfgVariableType VzdtCfg { get; }

		/// <summary>
		/// Value of variable $WAITRELEASE
		/// </summary>
		public bool Waitrelease { get; }

		/// <summary>
		/// Value of variable $WAITTMOUT
		/// </summary>
		public int Waittmout { get; }

		/// <summary>
		/// Value of variable $WAIT_ACTIVE
		/// </summary>
		public bool WaitActive { get; }

		/// <summary>
		/// Value of variable $WAIT_DATA
		/// </summary>
		public WaitDataVariableType WaitData { get; }

		/// <summary>
		/// Value of variable $WAIT_RDISP
		/// </summary>
		public bool WaitRdisp { get; }

		/// <summary>
		/// Value of variable $XVRCFG
		/// </summary>
		public XvrcfgVariableType Xvrcfg { get; }

		/// <summary>
		/// Value of variable $ZABC_GRP
		/// </summary>
		public ZabcGrpVariableType[] ZabcGrp { get; }

		/// <summary>
		/// Value of variable $ZDT_ACTVSPT
		/// </summary>
		public ZdtActvsptVariableType ZdtActvspt { get; }

		/// <summary>
		/// Value of variable $ZDT_DCSCHG
		/// </summary>
		public ZdtDcschgVariableType ZdtDcschg { get; }

		/// <summary>
		/// Value of variable $ZIP_CFG
		/// </summary>
		public ZipCfgVariableType ZipCfg { get; }

		/// <summary>
		/// Value of variable $ZMPCF_G
		/// </summary>
		public ZmpcfGrpVariableType[] ZmpcfG { get; }

		/// <summary>
		/// Value of variable $ZMP_GRP
		/// </summary>
		public ZmposGrpVariableType[] ZmpGrp { get; }

		/// <summary>
		/// Value of variable $ZPCFG
		/// </summary>
		public ZpCfgVariableType Zpcfg { get; }

		/// <summary>
		/// Value of variable $ZP_CYLINDER
		/// </summary>
		public ZpCylinderVariableType[] ZpCylinder { get; }

		/// <summary>
		/// Value of variable $ZP_GRP
		/// </summary>
		public ZpGrpVariableType[] ZpGrp { get; }

		/// <summary>
		/// Value of variable $ZP_SPHERE
		/// </summary>
		public ZpSphereVariableType[] ZpSphere { get; }

		/// <summary>
		/// Value of variable $ZZZ
		/// </summary>
		public int Zzz { get; }
	}
}
