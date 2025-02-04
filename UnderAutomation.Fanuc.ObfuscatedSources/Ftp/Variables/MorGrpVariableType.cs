//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MOR_GRP_T
	/// </summary>
	public class MorGrpVariableType : GenericVariableType, IGenericVariableType {


		public MorGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $NILPOS
		/// </summary>
		public CartesianPositionVariable Nilpos { get; }

		/// <summary>
		/// Value of variable $OVERRUN_CNT
		/// </summary>
		public int OverrunCnt { get; }

		/// <summary>
		/// Value of variable $CURRENT_POS
		/// </summary>
		public CurrentPosVariableType CurrentPos { get; }

		/// <summary>
		/// Value of variable $SEGMOVEDIST
		/// </summary>
		public double Segmovedist { get; }

		/// <summary>
		/// Value of variable $SEGMOVETIME
		/// </summary>
		public double Segmovetime { get; }

		/// <summary>
		/// Value of variable $SEGFRACTION
		/// </summary>
		public double Segfraction { get; }

		/// <summary>
		/// Value of variable $PATH_NODE
		/// </summary>
		public int PathNode { get; }

		/// <summary>
		/// Value of variable $CUR_SEG_ID
		/// </summary>
		public int CurSegId { get; }

		/// <summary>
		/// Value of variable $CURRENTLINE
		/// </summary>
		public int Currentline { get; }

		/// <summary>
		/// Value of variable $CUR_PROG_ID
		/// </summary>
		public int CurProgId { get; }

		/// <summary>
		/// Value of variable $LINE_OFFSET
		/// </summary>
		public int LineOffset { get; }

		/// <summary>
		/// Value of variable $APC_DONE
		/// </summary>
		public bool ApcDone { get; }

		/// <summary>
		/// Value of variable $ATPERCH
		/// </summary>
		public bool Atperch { get; }

		/// <summary>
		/// Value of variable $CUR_ACCTIME
		/// </summary>
		public int CurAcctime { get; }

		/// <summary>
		/// Value of variable $CAL_DONE
		/// </summary>
		public bool CalDone { get; }

		/// <summary>
		/// Value of variable $FILTER_EMPT
		/// </summary>
		public bool FilterEmpt { get; }

		/// <summary>
		/// Value of variable $FLTR_NC_EMP
		/// </summary>
		public bool FltrNcEmp { get; }

		/// <summary>
		/// Value of variable $SERVO_READY
		/// </summary>
		public bool ServoReady { get; }

		/// <summary>
		/// Value of variable $SYN_ERR_CNT
		/// </summary>
		public int SynErrCnt { get; }

		/// <summary>
		/// Value of variable $APC_COUNTER
		/// </summary>
		public int[] ApcCounter { get; }

		/// <summary>
		/// Value of variable $IN_POSITION
		/// </summary>
		public bool[] InPosition { get; }

		/// <summary>
		/// Value of variable $CURRENT_ANG
		/// </summary>
		public double[] CurrentAng { get; }

		/// <summary>
		/// Value of variable $DSP_STAT
		/// </summary>
		public int[] DspStat { get; }

		/// <summary>
		/// Value of variable $ERROR_CNT
		/// </summary>
		public int[] ErrorCnt { get; }

		/// <summary>
		/// Value of variable $TORQUE
		/// </summary>
		public short[] Torque { get; }

		/// <summary>
		/// Value of variable $MAX_TORQUE
		/// </summary>
		public short[] MaxTorque { get; }

		/// <summary>
		/// Value of variable $CUR_TORQUE
		/// </summary>
		public short[] CurTorque { get; }

		/// <summary>
		/// Value of variable $MACHINE_PLS
		/// </summary>
		public int[] MachinePls { get; }

		/// <summary>
		/// Value of variable $SPC_STAT
		/// </summary>
		public short[] SpcStat { get; }

		/// <summary>
		/// Value of variable $LINE_ER_CNT
		/// </summary>
		public short[] LineErCnt { get; }

		/// <summary>
		/// Value of variable $MOTION_CMND
		/// </summary>
		public int[] MotionCmnd { get; }

		/// <summary>
		/// Value of variable $CUR_AXS_ACC
		/// </summary>
		public int[] CurAxsAcc { get; }

		/// <summary>
		/// Value of variable $CUR_DIS_TRQ
		/// </summary>
		public short[] CurDisTrq { get; }

		/// <summary>
		/// Value of variable $MIN_DIS_TRQ
		/// </summary>
		public short[] MinDisTrq { get; }

		/// <summary>
		/// Value of variable $MAX_DIS_TRQ
		/// </summary>
		public short[] MaxDisTrq { get; }

		/// <summary>
		/// Value of variable $JOGGED
		/// </summary>
		public bool Jogged { get; }

		/// <summary>
		/// Value of variable $CURPTHACC
		/// </summary>
		public int Curpthacc { get; }

		/// <summary>
		/// Value of variable $CURTIMEACC
		/// </summary>
		public int Curtimeacc { get; }

		/// <summary>
		/// Value of variable $CARTFLTREMP
		/// </summary>
		public bool Cartfltremp { get; }

		/// <summary>
		/// Value of variable $FILTER_TYPE
		/// </summary>
		public short FilterType { get; }

		/// <summary>
		/// Value of variable $DVC_AXES
		/// </summary>
		public int DvcAxes { get; }

		/// <summary>
		/// Value of variable $DVC_DELAY
		/// </summary>
		public int DvcDelay { get; }

		/// <summary>
		/// Value of variable $DVC_REDUCE
		/// </summary>
		public double DvcReduce { get; }

		/// <summary>
		/// Value of variable $ERROR_CNT2
		/// </summary>
		public int[] ErrorCnt2 { get; }

		/// <summary>
		/// Value of variable $ERROR_CNT3
		/// </summary>
		public int[] ErrorCnt3 { get; }

		/// <summary>
		/// Value of variable $TORSION_CNT
		/// </summary>
		public int[] TorsionCnt { get; }

		/// <summary>
		/// Value of variable $TEMPERATURE
		/// </summary>
		public int[] Temperature { get; }

		/// <summary>
		/// Value of variable $DISCHG_VLT
		/// </summary>
		public int[] DischgVlt { get; }

		/// <summary>
		/// Value of variable $DISCHG_MNTR
		/// </summary>
		public int[] DischgMntr { get; }

		/// <summary>
		/// Value of variable $ANSBACK_SIG
		/// </summary>
		public int[] AnsbackSig { get; }

		/// <summary>
		/// Value of variable $IGNORE_ALM
		/// </summary>
		public bool IgnoreAlm { get; }

		/// <summary>
		/// Value of variable $MAX_DISCHG
		/// </summary>
		public int[] MaxDischg { get; }

		/// <summary>
		/// Value of variable $OVC_VALUE
		/// </summary>
		public double[] OvcValue { get; }

		/// <summary>
		/// Value of variable $MAX_ERROR
		/// </summary>
		public int[] MaxError { get; }

		/// <summary>
		/// Value of variable $FB_COMP_CNT
		/// </summary>
		public int[] FbCompCnt { get; }

		/// <summary>
		/// Value of variable $PCCOMER_CNT
		/// </summary>
		public int[] PccomerCnt { get; }

		/// <summary>
		/// Value of variable $ERR_VALUE
		/// </summary>
		public double[] ErrValue { get; }

		/// <summary>
		/// Value of variable $TUNE
		/// </summary>
		public TuneVariableType[] Tune { get; }

		/// <summary>
		/// Value of variable $TUNE_VAL
		/// </summary>
		public int TuneVal { get; }

		/// <summary>
		/// Value of variable $OGDST_RATIO
		/// </summary>
		public double OgdstRatio { get; }

		/// <summary>
		/// Value of variable $WHILEQSTOP
		/// </summary>
		public bool Whileqstop { get; }

		/// <summary>
		/// Value of variable $DSP_STAT2
		/// </summary>
		public int[] DspStat2 { get; }

		/// <summary>
		/// Value of variable $SV_INT_DATA
		/// </summary>
		public short[] SvIntData { get; }

		/// <summary>
		/// Value of variable $DAC_STAT
		/// </summary>
		public short[] DacStat { get; }

		/// <summary>
		/// Value of variable $DAC_RATE
		/// </summary>
		public double[] DacRate { get; }

		/// <summary>
		/// Value of variable $MS_DIAG
		/// </summary>
		public double[] MsDiag { get; }

		/// <summary>
		/// Value of variable $NE_MCMD
		/// </summary>
		public int[] NeMcmd { get; }

		/// <summary>
		/// Value of variable $BZAL_DETECT
		/// </summary>
		public bool[] BzalDetect { get; }

		/// <summary>
		/// Value of variable $TORQUE_CMD
		/// </summary>
		public short[] TorqueCmd { get; }

		/// <summary>
		/// Value of variable $PSY_TMO_CTR
		/// </summary>
		public int PsyTmoCtr { get; }

		/// <summary>
		/// Value of variable $Q_CURRENT
		/// </summary>
		public double[] QCurrent { get; }

		/// <summary>
		/// Value of variable $SV_INT_DAT2
		/// </summary>
		public int[] SvIntDat2 { get; }

		/// <summary>
		/// Value of variable $SV_INT_DAT3
		/// </summary>
		public int[] SvIntDat3 { get; }

		/// <summary>
		/// Value of variable $SV_INT_DAT4
		/// </summary>
		public int[] SvIntDat4 { get; }

		/// <summary>
		/// Value of variable $SV_INT_DAT5
		/// </summary>
		public int[] SvIntDat5 { get; }

		/// <summary>
		/// Value of variable $SV_INT_DAT6
		/// </summary>
		public int[] SvIntDat6 { get; }

		/// <summary>
		/// Value of variable $PULCO_IDATA
		/// </summary>
		public PulcoIdataVariableType PulcoIdata { get; }

		/// <summary>
		/// Value of variable $CUR_NOM_ANG
		/// </summary>
		public double[] CurNomAng { get; }

		/// <summary>
		/// Value of variable $MOVE_CNT
		/// </summary>
		public int MoveCnt { get; }

		/// <summary>
		/// Value of variable $STILL_CNT
		/// </summary>
		public int StillCnt { get; }

		/// <summary>
		/// Value of variable $MV_ST_RESET
		/// </summary>
		public bool MvStReset { get; }

		/// <summary>
		/// Value of variable $ROB_MOVE
		/// </summary>
		public bool RobMove { get; }

		/// <summary>
		/// Value of variable $MVST_ENB
		/// </summary>
		public bool MvstEnb { get; }

		/// <summary>
		/// Value of variable $AMP_ALARM
		/// </summary>
		public int[] AmpAlarm { get; }

		/// <summary>
		/// Value of variable $JOG_MOTION
		/// </summary>
		public bool JogMotion { get; }

		/// <summary>
		/// Value of variable $CUR_PROGNAM
		/// </summary>
		public string CurPrognam { get; }

		/// <summary>
		/// Value of variable $CUR_TCP
		/// </summary>
		public CartesianPositionVariable CurTcp { get; }

		/// <summary>
		/// Value of variable $MCH_PLS_GRV
		/// </summary>
		public int[] MchPlsGrv { get; }

		/// <summary>
		/// Value of variable $OVC_MNTR
		/// </summary>
		public double[] OvcMntr { get; }

		/// <summary>
		/// Value of variable $OVC2_MNTR
		/// </summary>
		public double[] Ovc2Mntr { get; }

		/// <summary>
		/// Value of variable $SERVO_ERR
		/// </summary>
		public int[] ServoErr { get; }

		/// <summary>
		/// Value of variable $MAXSERVOCMP
		/// </summary>
		public int[] Maxservocmp { get; }

		/// <summary>
		/// Value of variable $AFTFLTRANG
		/// </summary>
		public double[] Aftfltrang { get; }

		/// <summary>
		/// Value of variable $DISTRQ_ORG
		/// </summary>
		public short[] DistrqOrg { get; }

		/// <summary>
		/// Value of variable $SV_CMND_ANG
		/// </summary>
		public double[] SvCmndAng { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
