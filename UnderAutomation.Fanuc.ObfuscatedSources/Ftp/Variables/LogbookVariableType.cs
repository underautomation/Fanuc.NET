//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type LOGBOOK_T
	/// </summary>
	public class LogbookVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NUM_ER_ITM
		/// </summary>
		public int NumErItm { get; }

		/// <summary>
		/// Value of variable $NUM_ER_TYP
		/// </summary>
		public int NumErTyp { get; }

		/// <summary>
		/// Value of variable $NUM_REC_TYP
		/// </summary>
		public int NumRecTyp { get; }

		/// <summary>
		/// Value of variable $NUM_SCRN_FL
		/// </summary>
		public int NumScrnFl { get; }

		/// <summary>
		/// Value of variable $NUM_DIO
		/// </summary>
		public int NumDio { get; }

		/// <summary>
		/// Value of variable $SRAM_MARGIN
		/// </summary>
		public int SramMargin { get; }

		/// <summary>
		/// Value of variable $DRAM_MARGIN
		/// </summary>
		public int DramMargin { get; }

		/// <summary>
		/// Value of variable $OPTION
		/// </summary>
		public int Option { get; }

		/// <summary>
		/// Value of variable $LOG_ER
		/// </summary>
		public int LogEr { get; }

		/// <summary>
		/// Value of variable $LOG_ENT
		/// </summary>
		public int LogEnt { get; }

		/// <summary>
		/// Value of variable $LOG_SEL
		/// </summary>
		public int LogSel { get; }

		/// <summary>
		/// Value of variable $LOG_WIN
		/// </summary>
		public int LogWin { get; }

		/// <summary>
		/// Value of variable $LOG_MENU
		/// </summary>
		public int LogMenu { get; }

		/// <summary>
		/// Value of variable $LOG_JGMU
		/// </summary>
		public int LogJgmu { get; }

		/// <summary>
		/// Value of variable $LOG_MNCHG
		/// </summary>
		public int LogMnchg { get; }

		/// <summary>
		/// Value of variable $LOG_FNKEY
		/// </summary>
		public int LogFnkey { get; }

		/// <summary>
		/// Value of variable $LOG_JGKY
		/// </summary>
		public int LogJgky { get; }

		/// <summary>
		/// Value of variable $LOG_PRGKEY
		/// </summary>
		public int LogPrgkey { get; }

		/// <summary>
		/// Value of variable $LOG_UFKY
		/// </summary>
		public int LogUfky { get; }

		/// <summary>
		/// Value of variable $LOG_OVRKY
		/// </summary>
		public int LogOvrky { get; }

		/// <summary>
		/// Value of variable $LOG_FWDKY
		/// </summary>
		public int LogFwdky { get; }

		/// <summary>
		/// Value of variable $LOG_HLDKY
		/// </summary>
		public int LogHldky { get; }

		/// <summary>
		/// Value of variable $LOG_STPKY
		/// </summary>
		public int LogStpky { get; }

		/// <summary>
		/// Value of variable $LOG_PRVKY
		/// </summary>
		public int LogPrvky { get; }

		/// <summary>
		/// Value of variable $LOG_ENTKY
		/// </summary>
		public int LogEntky { get; }

		/// <summary>
		/// Value of variable $LOG_ITMKY
		/// </summary>
		public int LogItmky { get; }

		/// <summary>
		/// Value of variable $LOG_RSTKY
		/// </summary>
		public int LogRstky { get; }

		/// <summary>
		/// Value of variable $LOG_HELPKY
		/// </summary>
		public int LogHelpky { get; }

		/// <summary>
		/// Value of variable $LOG_OVR
		/// </summary>
		public int LogOvr { get; }

		/// <summary>
		/// Value of variable $LOG_CRD
		/// </summary>
		public int LogCrd { get; }

		/// <summary>
		/// Value of variable $LOG_STEP
		/// </summary>
		public int LogStep { get; }

		/// <summary>
		/// Value of variable $LOG_GRP
		/// </summary>
		public int LogGrp { get; }

		/// <summary>
		/// Value of variable $LOG_SGRP
		/// </summary>
		public int LogSgrp { get; }

		/// <summary>
		/// Value of variable $LOG_UF
		/// </summary>
		public int LogUf { get; }

		/// <summary>
		/// Value of variable $LOG_UT
		/// </summary>
		public int LogUt { get; }

		/// <summary>
		/// Value of variable $LOG_FILE
		/// </summary>
		public int LogFile { get; }

		/// <summary>
		/// Value of variable $LOG_WTRLS
		/// </summary>
		public int LogWtrls { get; }

		/// <summary>
		/// Value of variable $LOG_PGCHG
		/// </summary>
		public int LogPgchg { get; }

		/// <summary>
		/// Value of variable $LOG_SETPOS
		/// </summary>
		public int LogSetpos { get; }

		/// <summary>
		/// Value of variable $LOG_TPKY
		/// </summary>
		public int LogTpky { get; }

		/// <summary>
		/// Value of variable $LOG_DIO
		/// </summary>
		public int LogDio { get; }

		/// <summary>
		/// Value of variable $LOG_STMD
		/// </summary>
		public int LogStmd { get; }

		/// <summary>
		/// Value of variable $LOG_FOCUS
		/// </summary>
		public int LogFocus { get; }

		/// <summary>
		/// Value of variable $LOG_PRGEXE
		/// </summary>
		public int LogPrgexe { get; }

		/// <summary>
		/// Value of variable $LOG_TUIKEY
		/// </summary>
		public int LogTuikey { get; }

		/// <summary>
		/// Value of variable $IMG_ENT
		/// </summary>
		public bool ImgEnt { get; }

		/// <summary>
		/// Value of variable $IMG_SEL
		/// </summary>
		public bool ImgSel { get; }

		/// <summary>
		/// Value of variable $IMG_WIN
		/// </summary>
		public bool ImgWin { get; }

		/// <summary>
		/// Value of variable $IMG_FNKY
		/// </summary>
		public bool ImgFnky { get; }

		/// <summary>
		/// Value of variable $SAVE_FILE
		/// </summary>
		public string SaveFile { get; }

		/// <summary>
		/// Value of variable $SCRN_FL
		/// </summary>
		public bool ScrnFl { get; }

		/// <summary>
		/// Value of variable $SCRN_NO_ENT
		/// </summary>
		public bool ScrnNoEnt { get; }

		/// <summary>
		/// Value of variable $ANALOG_TOL
		/// </summary>
		public int AnalogTol { get; }

		/// <summary>
		/// Value of variable $AVAILABLE
		/// </summary>
		public int Available { get; }

		/// <summary>
		/// Value of variable $CLEAR_ENB
		/// </summary>
		public bool ClearEnb { get; }

		/// <summary>
		/// Value of variable $DCS_HI1
		/// </summary>
		public int DcsHi1 { get; }

		/// <summary>
		/// Value of variable $DCS_HI2
		/// </summary>
		public int DcsHi2 { get; }

		/// <summary>
		/// Value of variable $DCS_HO1
		/// </summary>
		public int DcsHo1 { get; }

		/// <summary>
		/// Value of variable $DCS_HO2
		/// </summary>
		public int DcsHo2 { get; }

		/// <summary>
		/// Value of variable $DCS_SI
		/// </summary>
		public int DcsSi { get; }

		/// <summary>
		/// Value of variable $DCS_SO1
		/// </summary>
		public int DcsSo1 { get; }

		/// <summary>
		/// Value of variable $DCS_SO2
		/// </summary>
		public int DcsSo2 { get; }

		/// <summary>
		/// Value of variable $DCS_OPTION
		/// </summary>
		public int DcsOption { get; }

		/// <summary>
		/// Value of variable $IGNR_SAVE
		/// </summary>
		public int IgnrSave { get; }

		/// <summary>
		/// Value of variable $FNKEY_FLTR
		/// </summary>
		public int FnkeyFltr { get; }

		/// <summary>
		/// Value of variable $DCS_DEV
		/// </summary>
		public int DcsDev { get; }

		/// <summary>
		/// Value of variable $LOG_CLLB
		/// </summary>
		public int LogCllb { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
