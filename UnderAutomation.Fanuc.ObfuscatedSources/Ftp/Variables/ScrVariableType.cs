//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SCR_T
	/// </summary>
	public class ScrVariableType : GenericVariableType, IGenericVariableType {


		public ScrVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ITP_TIME
		/// </summary>
		public byte ItpTime { get; }

		/// <summary>
		/// Value of variable $NUM_GROUP
		/// </summary>
		public byte NumGroup { get; }

		/// <summary>
		/// Value of variable $NUM_TOT_AXS
		/// </summary>
		public byte NumTotAxs { get; }

		/// <summary>
		/// Value of variable $NUM_DSP_AXS
		/// </summary>
		public byte NumDspAxs { get; }

		/// <summary>
		/// Value of variable $JOGLIM
		/// </summary>
		public int Joglim { get; }

		/// <summary>
		/// Value of variable $FINE_PCNT
		/// </summary>
		public int FinePcnt { get; }

		/// <summary>
		/// Value of variable $COND_TIME
		/// </summary>
		public int CondTime { get; }

		/// <summary>
		/// Value of variable $MAXNUMTASK
		/// </summary>
		public int Maxnumtask { get; }

		/// <summary>
		/// Value of variable $KEPT_MIRLIM
		/// </summary>
		public int KeptMirlim { get; }

		/// <summary>
		/// Value of variable $MAXPREMTN
		/// </summary>
		public int Maxpremtn { get; }

		/// <summary>
		/// Value of variable $MAXPREAPL
		/// </summary>
		public int Maxpreapl { get; }

		/// <summary>
		/// Value of variable $PRE_EXE_ENB
		/// </summary>
		public bool PreExeEnb { get; }

		/// <summary>
		/// Value of variable $NUM_SYS_MIR
		/// </summary>
		public int NumSysMir { get; }

		/// <summary>
		/// Value of variable $NUM_PG_MIR
		/// </summary>
		public int NumPgMir { get; }

		/// <summary>
		/// Value of variable $BRKHOLD_ENB
		/// </summary>
		public bool BrkholdEnb { get; }

		/// <summary>
		/// Value of variable $ENC_AXIS
		/// </summary>
		public int[] EncAxis { get; }

		/// <summary>
		/// Value of variable $ENC_TYPE
		/// </summary>
		public int[] EncType { get; }

		/// <summary>
		/// Value of variable $NUM_GP_MADE
		/// </summary>
		public byte NumGpMade { get; }

		/// <summary>
		/// Value of variable $NUM_RLIBSOC
		/// </summary>
		public byte NumRlibsoc { get; }

		/// <summary>
		/// Value of variable $NUM_MOTNSOC
		/// </summary>
		public byte NumMotnsoc { get; }

		/// <summary>
		/// Value of variable $DUMMY164
		/// </summary>
		public byte Dummy164 { get; }

		/// <summary>
		/// Value of variable $SV_CODE_OPT
		/// </summary>
		public int SvCodeOpt { get; }

		/// <summary>
		/// Value of variable $SFSPD_OVRD
		/// </summary>
		public int[] SfspdOvrd { get; }

		/// <summary>
		/// Value of variable $COLDOVRD
		/// </summary>
		public int Coldovrd { get; }

		/// <summary>
		/// Value of variable $COORDOVRD
		/// </summary>
		public int Coordovrd { get; }

		/// <summary>
		/// Value of variable $TPENBLEOVRD
		/// </summary>
		public int Tpenbleovrd { get; }

		/// <summary>
		/// Value of variable $FENCEOVRD
		/// </summary>
		public int Fenceovrd { get; }

		/// <summary>
		/// Value of variable $JOGOVLIM
		/// </summary>
		public int Jogovlim { get; }

		/// <summary>
		/// Value of variable $SFJOGOVLIM
		/// </summary>
		public int Sfjogovlim { get; }

		/// <summary>
		/// Value of variable $RUNOVLIM
		/// </summary>
		public int Runovlim { get; }

		/// <summary>
		/// Value of variable $SFRUNOVLIM
		/// </summary>
		public int Sfrunovlim { get; }

		/// <summary>
		/// Value of variable $MAXNUMUFRAM
		/// </summary>
		public int Maxnumufram { get; }

		/// <summary>
		/// Value of variable $MAXNUMUTOOL
		/// </summary>
		public int Maxnumutool { get; }

		/// <summary>
		/// Value of variable $LCHDLY_TIME
		/// </summary>
		public int LchdlyTime { get; }

		/// <summary>
		/// Value of variable $RECOV_OVRD
		/// </summary>
		public bool RecovOvrd { get; }

		/// <summary>
		/// Value of variable $JOGWST_MODE
		/// </summary>
		public bool JogwstMode { get; }

		/// <summary>
		/// Value of variable $JOGLIMROT
		/// </summary>
		public int Joglimrot { get; }

		/// <summary>
		/// Value of variable $MOTN_PC_RUN
		/// </summary>
		public byte[] MotnPcRun { get; }

		/// <summary>
		/// Value of variable $RESETINVERT
		/// </summary>
		public bool Resetinvert { get; }

		/// <summary>
		/// Value of variable $OFSTINCVAL
		/// </summary>
		public int Ofstincval { get; }

		/// <summary>
		/// Value of variable $FWDENBLOVRD
		/// </summary>
		public int Fwdenblovrd { get; }

		/// <summary>
		/// Value of variable $TPMOTNENABL
		/// </summary>
		public int Tpmotnenabl { get; }

		/// <summary>
		/// Value of variable $PREV_CTRL
		/// </summary>
		public bool PrevCtrl { get; }

		/// <summary>
		/// Value of variable $MAX_PRE_FDO
		/// </summary>
		public int MaxPreFdo { get; }

		/// <summary>
		/// Value of variable $PRE_MB_CMP
		/// </summary>
		public bool PreMbCmp { get; }

		/// <summary>
		/// Value of variable $MB_DSBL_MSK
		/// </summary>
		public int MbDsblMsk { get; }

		/// <summary>
		/// Value of variable $MB_DSB_MSK2
		/// </summary>
		public int MbDsbMsk2 { get; }

		/// <summary>
		/// Value of variable $SVSTAT
		/// </summary>
		public int Svstat { get; }

		/// <summary>
		/// Value of variable $UPDATE_TIME
		/// </summary>
		public int UpdateTime { get; }

		/// <summary>
		/// Value of variable $JG_DSBL_MSK
		/// </summary>
		public int JgDsblMsk { get; }

		/// <summary>
		/// Value of variable $NUM_PG_AMR
		/// </summary>
		public int NumPgAmr { get; }

		/// <summary>
		/// Value of variable $MB_LD_MSK
		/// </summary>
		public int MbLdMsk { get; }

		/// <summary>
		/// Value of variable $MOTN_LD_MSK
		/// </summary>
		public int MotnLdMsk { get; }

		/// <summary>
		/// Value of variable $MOTN_LD_MK2
		/// </summary>
		public int MotnLdMk2 { get; }

		/// <summary>
		/// Value of variable $AMP_TYPE
		/// </summary>
		public byte[] AmpType { get; }

		/// <summary>
		/// Value of variable $CAP_AMP_DIS
		/// </summary>
		public double[] CapAmpDis { get; }

		/// <summary>
		/// Value of variable $HBK_MAP_ENB
		/// </summary>
		public bool HbkMapEnb { get; }

		/// <summary>
		/// Value of variable $HBK_IO_TYPE
		/// </summary>
		public short HbkIoType { get; }

		/// <summary>
		/// Value of variable $HBK_IO_IDX
		/// </summary>
		public short HbkIoIdx { get; }

		/// <summary>
		/// Value of variable $PPA_MAP_ENB
		/// </summary>
		public bool PpaMapEnb { get; }

		/// <summary>
		/// Value of variable $PPA_IO_TYPE
		/// </summary>
		public short PpaIoType { get; }

		/// <summary>
		/// Value of variable $PPA_IO_IDX
		/// </summary>
		public short PpaIoIdx { get; }

		/// <summary>
		/// Value of variable $MOTN_LD_IDX
		/// </summary>
		public byte[] MotnLdIdx { get; }

		/// <summary>
		/// Value of variable $DVC_DBG
		/// </summary>
		public int DvcDbg { get; }

		/// <summary>
		/// Value of variable $DVC_ENB
		/// </summary>
		public bool DvcEnb { get; }

		/// <summary>
		/// Value of variable $DVC_MODE
		/// </summary>
		public int DvcMode { get; }

		/// <summary>
		/// Value of variable $DVC_MODE1
		/// </summary>
		public int DvcMode1 { get; }

		/// <summary>
		/// Value of variable $DVC_MODE2
		/// </summary>
		public int DvcMode2 { get; }

		/// <summary>
		/// Value of variable $DVC_MODE3
		/// </summary>
		public int DvcMode3 { get; }

		/// <summary>
		/// Value of variable $DVC_C_RATIO
		/// </summary>
		public double DvcCRatio { get; }

		/// <summary>
		/// Value of variable $INTASK_OVRU
		/// </summary>
		public int IntaskOvru { get; }

		/// <summary>
		/// Value of variable $DSP_TYPE
		/// </summary>
		public int DspType { get; }

		/// <summary>
		/// Value of variable $CABINET_TYP
		/// </summary>
		public int CabinetTyp { get; }

		/// <summary>
		/// Value of variable $NE_MODE
		/// </summary>
		public int NeMode { get; }

		/// <summary>
		/// Value of variable $PG_DSBL_MSK
		/// </summary>
		public int PgDsblMsk { get; }

		/// <summary>
		/// Value of variable $JOG_AUX_ENB
		/// </summary>
		public bool JogAuxEnb { get; }

		/// <summary>
		/// Value of variable $SUBCPU
		/// </summary>
		public bool Subcpu { get; }

		/// <summary>
		/// Value of variable $NE_SIN_RESO
		/// </summary>
		public int NeSinReso { get; }

		/// <summary>
		/// Value of variable $UPDATE_MAP1
		/// </summary>
		public int UpdateMap1 { get; }

		/// <summary>
		/// Value of variable $UPDATE_MAP2
		/// </summary>
		public int UpdateMap2 { get; }

		/// <summary>
		/// Value of variable $UPDATE_FLAG
		/// </summary>
		public int[] UpdateFlag { get; }

		/// <summary>
		/// Value of variable $HW_C1_TIME1
		/// </summary>
		public short HwC1Time1 { get; }

		/// <summary>
		/// Value of variable $HW_C1_TIME2
		/// </summary>
		public short HwC1Time2 { get; }

		/// <summary>
		/// Value of variable $ATR
		/// </summary>
		public int[] Atr { get; }

		/// <summary>
		/// Value of variable $UNITTYPE
		/// </summary>
		public byte[] Unittype { get; }

		/// <summary>
		/// Value of variable $ATRATTRIB
		/// </summary>
		public byte[] Atrattrib { get; }

		/// <summary>
		/// Value of variable $NE_CYCLE
		/// </summary>
		public int NeCycle { get; }

		/// <summary>
		/// Value of variable $NECA_OVRUN
		/// </summary>
		public int NecaOvrun { get; }

		/// <summary>
		/// Value of variable $FLTR_2_FIX
		/// </summary>
		public int Fltr2Fix { get; }

		/// <summary>
		/// Value of variable $STARTUP_CND
		/// </summary>
		public int StartupCnd { get; }

		/// <summary>
		/// Value of variable $DSB_SIGNAL
		/// </summary>
		public int DsbSignal { get; }

		/// <summary>
		/// Value of variable $LPCOND_TIME
		/// </summary>
		public int LpcondTime { get; }

		/// <summary>
		/// Value of variable $CHK_CH_SCTM
		/// </summary>
		public int ChkChSctm { get; }

		/// <summary>
		/// Value of variable $F_ATR
		/// </summary>
		public int[] FAtr { get; }

		/// <summary>
		/// Value of variable $F_UNITTYPE
		/// </summary>
		public byte[] FUnittype { get; }

		/// <summary>
		/// Value of variable $F_ATRATTRIB
		/// </summary>
		public byte[] FAtrattrib { get; }

		/// <summary>
		/// Value of variable $FSSB_STAT
		/// </summary>
		public int[] FssbStat { get; }

		/// <summary>
		/// Value of variable $CHAIN_TIME
		/// </summary>
		public int ChainTime { get; }

		/// <summary>
		/// Value of variable $CHAIN_STAT
		/// </summary>
		public int ChainStat { get; }

		/// <summary>
		/// Value of variable $CHAIN_RSDN
		/// </summary>
		public bool ChainRsdn { get; }

		/// <summary>
		/// Value of variable $DSP_MAP_ENB
		/// </summary>
		public bool DspMapEnb { get; }

		/// <summary>
		/// Value of variable $IDX_TBL_MSK
		/// </summary>
		public int IdxTblMsk { get; }

		/// <summary>
		/// Value of variable $PROC_CTRL
		/// </summary>
		public int ProcCtrl { get; }

		/// <summary>
		/// Value of variable $TEMPER_LIMS
		/// </summary>
		public int[] TemperLims { get; }

		/// <summary>
		/// Value of variable $FSSB1
		/// </summary>
		public int[] Fssb1 { get; }

		/// <summary>
		/// Value of variable $FSSB2
		/// </summary>
		public int[] Fssb2 { get; }

		/// <summary>
		/// Value of variable $FSSBDIAGENB
		/// </summary>
		public bool Fssbdiagenb { get; }

		/// <summary>
		/// Value of variable $RAILACC_ENB
		/// </summary>
		public bool RailaccEnb { get; }

		/// <summary>
		/// Value of variable $SMCR_LOADED
		/// </summary>
		public byte SmcrLoaded { get; }

		/// <summary>
		/// Value of variable $DUMMY165
		/// </summary>
		public byte Dummy165 { get; }

		/// <summary>
		/// Value of variable $DSP_TYPE2
		/// </summary>
		public int DspType2 { get; }

		/// <summary>
		/// Value of variable $PRC_DSP
		/// </summary>
		public bool[] PrcDsp { get; }

		/// <summary>
		/// Value of variable $PRC_CD_ID
		/// </summary>
		public string PrcCdId { get; }

		/// <summary>
		/// Value of variable $MOTN_FUNC
		/// </summary>
		public int[] MotnFunc { get; }

		/// <summary>
		/// Value of variable $INTRINS_TP
		/// </summary>
		public bool IntrinsTp { get; }

		/// <summary>
		/// Value of variable $DIAG_FUNC
		/// </summary>
		public int DiagFunc { get; }

		/// <summary>
		/// Value of variable $TRANS_NUM
		/// </summary>
		public short[] TransNum { get; }

		/// <summary>
		/// Value of variable $TRANS_MAX
		/// </summary>
		public double[] TransMax { get; }

		/// <summary>
		/// Value of variable $TRANS_WARN
		/// </summary>
		public double[] TransWarn { get; }

		/// <summary>
		/// Value of variable $CBLCUR_MAX
		/// </summary>
		public double[] CblcurMax { get; }

		/// <summary>
		/// Value of variable $CBLCUR_A
		/// </summary>
		public double[] CblcurA { get; }

		/// <summary>
		/// Value of variable $CBLCUR_B
		/// </summary>
		public double[] CblcurB { get; }

		/// <summary>
		/// Value of variable $CBLCUR_WARN
		/// </summary>
		public double[] CblcurWarn { get; }

		/// <summary>
		/// Value of variable $DAC_TRANS
		/// </summary>
		public double[] DacTrans { get; }

		/// <summary>
		/// Value of variable $DAC_CBLCUR
		/// </summary>
		public double[] DacCblcur { get; }

		/// <summary>
		/// Value of variable $CLDET_PT
		/// </summary>
		public short CldetPt { get; }

		/// <summary>
		/// Value of variable $CLDET_AXS
		/// </summary>
		public short[] CldetAxs { get; }

		/// <summary>
		/// Value of variable $CLDET_TIME
		/// </summary>
		public int[] CldetTime { get; }

		/// <summary>
		/// Value of variable $CE_RIA_SW
		/// </summary>
		public int CeRiaSw { get; }

		/// <summary>
		/// Value of variable $SAFE_SPD
		/// </summary>
		public double SafeSpd { get; }

		/// <summary>
		/// Value of variable $SAFE_ROTSPD
		/// </summary>
		public double SafeRotspd { get; }

		/// <summary>
		/// Value of variable $T2_LOCK_ENB
		/// </summary>
		public int T2LockEnb { get; }

		/// <summary>
		/// Value of variable $DSB_MOINIT
		/// </summary>
		public bool DsbMoinit { get; }

		/// <summary>
		/// Value of variable $MAX_DF_LEN
		/// </summary>
		public int MaxDfLen { get; }

		/// <summary>
		/// Value of variable $MPDT_TIMLMT
		/// </summary>
		public int MpdtTimlmt { get; }

		/// <summary>
		/// Value of variable $FAST_HRDYON
		/// </summary>
		public bool FastHrdyon { get; }

		/// <summary>
		/// Value of variable $ORG_PTH_RSM
		/// </summary>
		public bool OrgPthRsm { get; }

		/// <summary>
		/// Value of variable $DAC_LMT
		/// </summary>
		public int DacLmt { get; }

		/// <summary>
		/// Value of variable $MULSELENB
		/// </summary>
		public bool Mulselenb { get; }

		/// <summary>
		/// Value of variable $UPDATE_MAP3
		/// </summary>
		public short[] UpdateMap3 { get; }

		/// <summary>
		/// Value of variable $JCOLDOVRD
		/// </summary>
		public int Jcoldovrd { get; }

		/// <summary>
		/// Value of variable $JTPENBOVRD
		/// </summary>
		public int Jtpenbovrd { get; }

		/// <summary>
		/// Value of variable $JFENCEOVRD
		/// </summary>
		public int Jfenceovrd { get; }

		/// <summary>
		/// Value of variable $FAN_ALMLVL
		/// </summary>
		public int FanAlmlvl { get; }

		/// <summary>
		/// Value of variable $FAN_WRNLVL
		/// </summary>
		public int FanWrnlvl { get; }

		/// <summary>
		/// Value of variable $HARDTYP_MAP
		/// </summary>
		public int HardtypMap { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public short[] CompSw { get; }

		/// <summary>
		/// Value of variable $FANSTOP_TIM
		/// </summary>
		public int FanstopTim { get; }

		/// <summary>
		/// Value of variable $BRK_ECO_ENB
		/// </summary>
		public bool BrkEcoEnb { get; }

		/// <summary>
		/// Value of variable $AUTATR_STAT
		/// </summary>
		public int AutatrStat { get; }

		/// <summary>
		/// Value of variable $AUTO_SBRIDX
		/// </summary>
		public int AutoSbridx { get; }

		/// <summary>
		/// Value of variable $AUTO_DSPIDX
		/// </summary>
		public int AutoDspidx { get; }

		/// <summary>
		/// Value of variable $AUTO_ATRIDX
		/// </summary>
		public int[] AutoAtridx { get; }

		/// <summary>
		/// Value of variable $AUTO_AMPINF
		/// </summary>
		public short[] AutoAmpinf { get; }

		/// <summary>
		/// Value of variable $AUTO_AMPCUR
		/// </summary>
		public short[] AutoAmpcur { get; }

		/// <summary>
		/// Value of variable $REGTYPE
		/// </summary>
		public int Regtype { get; }

		/// <summary>
		/// Value of variable $NVDT_ENABLE
		/// </summary>
		public bool NvdtEnable { get; }

		/// <summary>
		/// Value of variable $ENC_DAL_NO
		/// </summary>
		public int EncDalNo { get; }

		/// <summary>
		/// Value of variable $PFL_C1_TIME
		/// </summary>
		public int[] PflC1Time { get; }

		/// <summary>
		/// Value of variable $MCURCHK
		/// </summary>
		public bool Mcurchk { get; }

		/// <summary>
		/// Value of variable $FAN_ALMLVL2
		/// </summary>
		public int[] FanAlmlvl2 { get; }

		/// <summary>
		/// Value of variable $FAN_WRNLVL2
		/// </summary>
		public int[] FanWrnlvl2 { get; }

		/// <summary>
		/// Value of variable $CMD_INF_CYC
		/// </summary>
		public int CmdInfCyc { get; }

		/// <summary>
		/// Value of variable $NONAX_ATR
		/// </summary>
		public int NonaxAtr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
