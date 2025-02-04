//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MRR_GRP_T
	/// </summary>
	public class MrrGrpVariableType : GenericVariableType, IGenericVariableType {


		public MrrGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $BELT_ENABLE
		/// </summary>
		public bool BeltEnable { get; }

		/// <summary>
		/// Value of variable $CART_ACCEL1
		/// </summary>
		public short CartAccel1 { get; }

		/// <summary>
		/// Value of variable $CART_ACCEL2
		/// </summary>
		public short CartAccel2 { get; }

		/// <summary>
		/// Value of variable $CIRC_RATE
		/// </summary>
		public byte CircRate { get; }

		/// <summary>
		/// Value of variable $CONTAXISNUM
		/// </summary>
		public byte Contaxisnum { get; }

		/// <summary>
		/// Value of variable $PS_EXP_ENBL
		/// </summary>
		public short PsExpEnbl { get; }

		/// <summary>
		/// Value of variable $EXP_ENBL
		/// </summary>
		public bool ExpEnbl { get; }

		/// <summary>
		/// Value of variable $JOINT_RATE
		/// </summary>
		public byte JointRate { get; }

		/// <summary>
		/// Value of variable $LINEAR_RATE
		/// </summary>
		public byte LinearRate { get; }

		/// <summary>
		/// Value of variable $PATH_ACCEL1
		/// </summary>
		public short PathAccel1 { get; }

		/// <summary>
		/// Value of variable $PATH_ACCEL2
		/// </summary>
		public short PathAccel2 { get; }

		/// <summary>
		/// Value of variable $PATH_ACCEL3
		/// </summary>
		public short PathAccel3 { get; }

		/// <summary>
		/// Value of variable $PROCESS_SPD
		/// </summary>
		public double ProcessSpd { get; }

		/// <summary>
		/// Value of variable $PROC_SPDLIM
		/// </summary>
		public double ProcSpdlim { get; }

		/// <summary>
		/// Value of variable $CNT_ACC_MGN
		/// </summary>
		public double CntAccMgn { get; }

		/// <summary>
		/// Value of variable $DDACC_RATIO
		/// </summary>
		public double DdaccRatio { get; }

		/// <summary>
		/// Value of variable $FWP_TIME1
		/// </summary>
		public short FwpTime1 { get; }

		/// <summary>
		/// Value of variable $FWP_TIME2
		/// </summary>
		public short FwpTime2 { get; }

		/// <summary>
		/// Value of variable $ACCEL_RATIO
		/// </summary>
		public double AccelRatio { get; }

		/// <summary>
		/// Value of variable $DECEL_RATIO
		/// </summary>
		public double DecelRatio { get; }

		/// <summary>
		/// Value of variable $PPABN_ENBL
		/// </summary>
		public bool PpabnEnbl { get; }

		/// <summary>
		/// Value of variable $ROTSPEEDLIM
		/// </summary>
		public double Rotspeedlim { get; }

		/// <summary>
		/// Value of variable $SPEEDLIM
		/// </summary>
		public double Speedlim { get; }

		/// <summary>
		/// Value of variable $SPEEDLIMJNT
		/// </summary>
		public double Speedlimjnt { get; }

		/// <summary>
		/// Value of variable $DEF_MAXACCE
		/// </summary>
		public bool DefMaxacce { get; }

		/// <summary>
		/// Value of variable $USE_CAL
		/// </summary>
		public bool UseCal { get; }

		/// <summary>
		/// Value of variable $SPIN_CTRL
		/// </summary>
		public bool SpinCtrl { get; }

		/// <summary>
		/// Value of variable $SYN_ERR_LIM
		/// </summary>
		public int SynErrLim { get; }

		/// <summary>
		/// Value of variable $SYNC_GAIN
		/// </summary>
		public int SyncGain { get; }

		/// <summary>
		/// Value of variable $SYNC_OFFSET
		/// </summary>
		public int SyncOffset { get; }

		/// <summary>
		/// Value of variable $MOUNT_ANGLE
		/// </summary>
		public double MountAngle { get; }

		/// <summary>
		/// Value of variable $COLLINEAR
		/// </summary>
		public double Collinear { get; }

		/// <summary>
		/// Value of variable $COINCIDENT
		/// </summary>
		public double Coincident { get; }

		/// <summary>
		/// Value of variable $ACCEL_TIME1
		/// </summary>
		public short[] AccelTime1 { get; }

		/// <summary>
		/// Value of variable $ACCEL_TIME2
		/// </summary>
		public short[] AccelTime2 { get; }

		/// <summary>
		/// Value of variable $ENCSCALES
		/// </summary>
		public double[] Encscales { get; }

		/// <summary>
		/// Value of variable $EXP_ACCEL
		/// </summary>
		public short[] ExpAccel { get; }

		/// <summary>
		/// Value of variable $PS_INPOS_TI
		/// </summary>
		public short PsInposTi { get; }

		/// <summary>
		/// Value of variable $INPOS_TIME
		/// </summary>
		public int[] InposTime { get; }

		/// <summary>
		/// Value of variable $JNTVELLIM
		/// </summary>
		public double[] Jntvellim { get; }

		/// <summary>
		/// Value of variable $JNT23_UPLIM
		/// </summary>
		public double Jnt23Uplim { get; }

		/// <summary>
		/// Value of variable $JNT23_LOWLI
		/// </summary>
		public double Jnt23Lowli { get; }

		/// <summary>
		/// Value of variable $LOWERLIMS
		/// </summary>
		public double[] Lowerlims { get; }

		/// <summary>
		/// Value of variable $LOWERLIMSDF
		/// </summary>
		public double[] Lowerlimsdf { get; }

		/// <summary>
		/// Value of variable $MASTER_POS
		/// </summary>
		public double[] MasterPos { get; }

		/// <summary>
		/// Value of variable $MIN_ACCTIME
		/// </summary>
		public int[] MinAcctime { get; }

		/// <summary>
		/// Value of variable $MOSIGN
		/// </summary>
		public bool[] Mosign { get; }

		/// <summary>
		/// Value of variable $MOT_SPD_LIM
		/// </summary>
		public int[] MotSpdLim { get; }

		/// <summary>
		/// Value of variable $PERCH
		/// </summary>
		public double[] Perch { get; }

		/// <summary>
		/// Value of variable $MOVERRLIM
		/// </summary>
		public int[] Moverrlim { get; }

		/// <summary>
		/// Value of variable $PERCHTOL
		/// </summary>
		public double[] Perchtol { get; }

		/// <summary>
		/// Value of variable $STOPERLIM
		/// </summary>
		public int[] Stoperlim { get; }

		/// <summary>
		/// Value of variable $STOPTOL
		/// </summary>
		public int[] Stoptol { get; }

		/// <summary>
		/// Value of variable $SERVO_CTRL
		/// </summary>
		public short ServoCtrl { get; }

		/// <summary>
		/// Value of variable $PS_SV_OFF_A
		/// </summary>
		public short PsSvOffA { get; }

		/// <summary>
		/// Value of variable $SV_OFF_ALL
		/// </summary>
		public bool SvOffAll { get; }

		/// <summary>
		/// Value of variable $SV_OFF_ENB
		/// </summary>
		public bool[] SvOffEnb { get; }

		/// <summary>
		/// Value of variable $SV_OFF_TIME
		/// </summary>
		public int[] SvOffTime { get; }

		/// <summary>
		/// Value of variable $UPPERLIMS
		/// </summary>
		public double[] Upperlims { get; }

		/// <summary>
		/// Value of variable $UPPERLIMSDF
		/// </summary>
		public double[] Upperlimsdf { get; }

		/// <summary>
		/// Value of variable $TRKERRLIM
		/// </summary>
		public int Trkerrlim { get; }

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public short Payload { get; }

		/// <summary>
		/// Value of variable $PS_MAX_PAYL
		/// </summary>
		public short PsMaxPayl { get; }

		/// <summary>
		/// Value of variable $MAX_PAYLOAD
		/// </summary>
		public double MaxPayload { get; }

		/// <summary>
		/// Value of variable $AXISINERTIA
		/// </summary>
		public short[] Axisinertia { get; }

		/// <summary>
		/// Value of variable $AXISMOMENT
		/// </summary>
		public short[] Axismoment { get; }

		/// <summary>
		/// Value of variable $MAX_AMP_CUR
		/// </summary>
		public double[] MaxAmpCur { get; }

		/// <summary>
		/// Value of variable $ACCEL_PARAM
		/// </summary>
		public double[] AccelParam { get; }

		/// <summary>
		/// Value of variable $MAX_PTH_ACC
		/// </summary>
		public double MaxPthAcc { get; }

		/// <summary>
		/// Value of variable $MRRDUM2
		/// </summary>
		public short Mrrdum2 { get; }

		/// <summary>
		/// Value of variable $PS_BCKLSH_C
		/// </summary>
		public short PsBcklshC { get; }

		/// <summary>
		/// Value of variable $BCKLSH_COUN
		/// </summary>
		public int[] BcklshCoun { get; }

		/// <summary>
		/// Value of variable $MOVER_GAIN
		/// </summary>
		public double[] MoverGain { get; }

		/// <summary>
		/// Value of variable $MOVER_SCALE
		/// </summary>
		public double[] MoverScale { get; }

		/// <summary>
		/// Value of variable $MOVER_OFFST
		/// </summary>
		public int[] MoverOffst { get; }

		/// <summary>
		/// Value of variable $CLALM_TIME
		/// </summary>
		public int ClalmTime { get; }

		/// <summary>
		/// Value of variable $TSMOD_TIME
		/// </summary>
		public int TsmodTime { get; }

		/// <summary>
		/// Value of variable $CHKLIMTYP
		/// </summary>
		public int Chklimtyp { get; }

		/// <summary>
		/// Value of variable $SNGLRTY_STP
		/// </summary>
		public bool SnglrtyStp { get; }

		/// <summary>
		/// Value of variable $INPOS_TYPE
		/// </summary>
		public int InposType { get; }

		/// <summary>
		/// Value of variable $JOG_TIME_M
		/// </summary>
		public int JogTimeM { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_UMA
		/// </summary>
		public int MinAccUma { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_UCA
		/// </summary>
		public int MinAccUca { get; }

		/// <summary>
		/// Value of variable $ACC_SCL_UCA
		/// </summary>
		public double AccSclUca { get; }

		/// <summary>
		/// Value of variable $SLMT_J1_LW
		/// </summary>
		public double[] SlmtJ1Lw { get; }

		/// <summary>
		/// Value of variable $SLMT_J1_UP
		/// </summary>
		public double[] SlmtJ1Up { get; }

		/// <summary>
		/// Value of variable $SLMT_E1_LW
		/// </summary>
		public double[] SlmtE1Lw { get; }

		/// <summary>
		/// Value of variable $SLMT_E1_UP
		/// </summary>
		public double[] SlmtE1Up { get; }

		/// <summary>
		/// Value of variable $SLMT_J1_NUM
		/// </summary>
		public byte SlmtJ1Num { get; }

		/// <summary>
		/// Value of variable $SLMT_E1_NUM
		/// </summary>
		public byte SlmtE1Num { get; }

		/// <summary>
		/// Value of variable $PS_SPCCOUNT
		/// </summary>
		public short PsSpccount { get; }

		/// <summary>
		/// Value of variable $SPCCOUNTTOL
		/// </summary>
		public int[] Spccounttol { get; }

		/// <summary>
		/// Value of variable $SPCMOVETOL
		/// </summary>
		public int[] Spcmovetol { get; }

		/// <summary>
		/// Value of variable $SHORTMO_MGN
		/// </summary>
		public double ShortmoMgn { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_CMC
		/// </summary>
		public int MinAccCmc { get; }

		/// <summary>
		/// Value of variable $EXTACCRATIO
		/// </summary>
		public double Extaccratio { get; }

		/// <summary>
		/// Value of variable $CN_GEAR_N1
		/// </summary>
		public int CnGearN1 { get; }

		/// <summary>
		/// Value of variable $CN_GEAR_N2
		/// </summary>
		public int CnGearN2 { get; }

		/// <summary>
		/// Value of variable $SFLT_ERLIM
		/// </summary>
		public int[] SfltErlim { get; }

		/// <summary>
		/// Value of variable $SV_CTRL_TYP
		/// </summary>
		public short[] SvCtrlTyp { get; }

		/// <summary>
		/// Value of variable $PS_CARTMO_M
		/// </summary>
		public short PsCartmoM { get; }

		/// <summary>
		/// Value of variable $CARTMO_MGN
		/// </summary>
		public double CartmoMgn { get; }

		/// <summary>
		/// Value of variable $MIN_CAT_UMA
		/// </summary>
		public int MinCatUma { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_SHM
		/// </summary>
		public int MinAccShm { get; }

		/// <summary>
		/// Value of variable $GEAR_RATIO
		/// </summary>
		public double[] GearRatio { get; }

		/// <summary>
		/// Value of variable $EXP_JOG_ACC
		/// </summary>
		public short[] ExpJogAcc { get; }

		/// <summary>
		/// Value of variable $PS_ARMLOAD
		/// </summary>
		public short PsArmload { get; }

		/// <summary>
		/// Value of variable $ARMLOAD
		/// </summary>
		public double[] Armload { get; }

		/// <summary>
		/// Value of variable $ACC_PA_UMA
		/// </summary>
		public double AccPaUma { get; }

		/// <summary>
		/// Value of variable $ACC_PC_UMA
		/// </summary>
		public double AccPcUma { get; }

		/// <summary>
		/// Value of variable $AXIS_IM_SCL
		/// </summary>
		public short AxisImScl { get; }

		/// <summary>
		/// Value of variable $PS_MOT_LIM_
		/// </summary>
		public short PsMotLim { get; }

		/// <summary>
		/// Value of variable $MOT_LIM_STP
		/// </summary>
		public bool MotLimStp { get; }

		/// <summary>
		/// Value of variable $JG_FLTR_SCL
		/// </summary>
		public double JgFltrScl { get; }

		/// <summary>
		/// Value of variable $JOGACCRATIO
		/// </summary>
		public double[] Jogaccratio { get; }

		/// <summary>
		/// Value of variable $TORQUE_CONS
		/// </summary>
		public double[] TorqueCons { get; }

		/// <summary>
		/// Value of variable $MIN_PAYLOAD
		/// </summary>
		public double MinPayload { get; }

		/// <summary>
		/// Value of variable $DECOUP_MGN
		/// </summary>
		public double[] DecoupMgn { get; }

		/// <summary>
		/// Value of variable $DECP_MGN_WR
		/// </summary>
		public double[] DecpMgnWr { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_X
		/// </summary>
		public double PayloadX { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_Y
		/// </summary>
		public double PayloadY { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_Z
		/// </summary>
		public double PayloadZ { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IX
		/// </summary>
		public double PayloadIx { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IY
		/// </summary>
		public double PayloadIy { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IZ
		/// </summary>
		public double PayloadIz { get; }

		/// <summary>
		/// Value of variable $FFG_MGN_J2
		/// </summary>
		public double FfgMgnJ2 { get; }

		/// <summary>
		/// Value of variable $FFG_MGN_J3
		/// </summary>
		public double FfgMgnJ3 { get; }

		/// <summary>
		/// Value of variable $DVC_AC0_MAX
		/// </summary>
		public double[] DvcAc0Max { get; }

		/// <summary>
		/// Value of variable $DVC_AC1_MAX
		/// </summary>
		public double[] DvcAc1Max { get; }

		/// <summary>
		/// Value of variable $DVC_ACC_MAX
		/// </summary>
		public double[] DvcAccMax { get; }

		/// <summary>
		/// Value of variable $DVC_ACC_MIN
		/// </summary>
		public double[] DvcAccMin { get; }

		/// <summary>
		/// Value of variable $DVC_JRK_MAX
		/// </summary>
		public double[] DvcJrkMax { get; }

		/// <summary>
		/// Value of variable $DVC_JRK_MIN
		/// </summary>
		public double[] DvcJrkMin { get; }

		/// <summary>
		/// Value of variable $SV_DBL_SMT
		/// </summary>
		public bool SvDblSmt { get; }

		/// <summary>
		/// Value of variable $SV_MCMD_DLY
		/// </summary>
		public bool SvMcmdDly { get; }

		/// <summary>
		/// Value of variable $SV_GRV_X
		/// </summary>
		public double SvGrvX { get; }

		/// <summary>
		/// Value of variable $SV_GRV_Y
		/// </summary>
		public double SvGrvY { get; }

		/// <summary>
		/// Value of variable $SV_GRV_Z
		/// </summary>
		public double SvGrvZ { get; }

		/// <summary>
		/// Value of variable $SV_DH_D
		/// </summary>
		public double[] SvDhD { get; }

		/// <summary>
		/// Value of variable $SV_DH_A
		/// </summary>
		public double[] SvDhA { get; }

		/// <summary>
		/// Value of variable $SV_DH_COSA
		/// </summary>
		public double[] SvDhCosa { get; }

		/// <summary>
		/// Value of variable $SV_DH_SINA
		/// </summary>
		public double[] SvDhSina { get; }

		/// <summary>
		/// Value of variable $SV_LNK_M
		/// </summary>
		public double[] SvLnkM { get; }

		/// <summary>
		/// Value of variable $SV_LNK_X
		/// </summary>
		public double[] SvLnkX { get; }

		/// <summary>
		/// Value of variable $SV_LNK_Y
		/// </summary>
		public double[] SvLnkY { get; }

		/// <summary>
		/// Value of variable $SV_LNK_Z
		/// </summary>
		public double[] SvLnkZ { get; }

		/// <summary>
		/// Value of variable $SV_LNK_IX
		/// </summary>
		public double[] SvLnkIx { get; }

		/// <summary>
		/// Value of variable $SV_LNK_IY
		/// </summary>
		public double[] SvLnkIy { get; }

		/// <summary>
		/// Value of variable $SV_LNK_IZ
		/// </summary>
		public double[] SvLnkIz { get; }

		/// <summary>
		/// Value of variable $SV_Z_SIGN
		/// </summary>
		public bool[] SvZSign { get; }

		/// <summary>
		/// Value of variable $SV_DMY_LNK
		/// </summary>
		public bool[] SvDmyLnk { get; }

		/// <summary>
		/// Value of variable $SV_DH_COSTH
		/// </summary>
		public double[] SvDhCosth { get; }

		/// <summary>
		/// Value of variable $SV_DH_SINTH
		/// </summary>
		public double[] SvDhSinth { get; }

		/// <summary>
		/// Value of variable $SV_THET0
		/// </summary>
		public double[] SvThet0 { get; }

		/// <summary>
		/// Value of variable $LNK23Z
		/// </summary>
		public double Lnk23z { get; }

		/// <summary>
		/// Value of variable $LNK23X
		/// </summary>
		public double Lnk23x { get; }

		/// <summary>
		/// Value of variable $LNKCBZ
		/// </summary>
		public double Lnkcbz { get; }

		/// <summary>
		/// Value of variable $LNKCBX
		/// </summary>
		public double Lnkcbx { get; }

		/// <summary>
		/// Value of variable $CB_MASS
		/// </summary>
		public double CbMass { get; }

		/// <summary>
		/// Value of variable $CB_IX
		/// </summary>
		public double CbIx { get; }

		/// <summary>
		/// Value of variable $CB_IY
		/// </summary>
		public double CbIy { get; }

		/// <summary>
		/// Value of variable $CB_IZ
		/// </summary>
		public double CbIz { get; }

		/// <summary>
		/// Value of variable $LNKSBY
		/// </summary>
		public double Lnksby { get; }

		/// <summary>
		/// Value of variable $LNKSBX
		/// </summary>
		public double Lnksbx { get; }

		/// <summary>
		/// Value of variable $LNGTSB
		/// </summary>
		public double Lngtsb { get; }

		/// <summary>
		/// Value of variable $SPCNS
		/// </summary>
		public double Spcns { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_X
		/// </summary>
		public double[] ArmloadX { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_Y
		/// </summary>
		public double[] ArmloadY { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_Z
		/// </summary>
		public double[] ArmloadZ { get; }

		/// <summary>
		/// Value of variable $DUTY_ENB
		/// </summary>
		public bool[] DutyEnb { get; }

		/// <summary>
		/// Value of variable $DUTY_PARAM1
		/// </summary>
		public double[] DutyParam1 { get; }

		/// <summary>
		/// Value of variable $DUTY_PARAM2
		/// </summary>
		public double[] DutyParam2 { get; }

		/// <summary>
		/// Value of variable $QSTOP_TOL
		/// </summary>
		public double[] QstopTol { get; }

		/// <summary>
		/// Value of variable $NE_ENB
		/// </summary>
		public int NeEnb { get; }

		/// <summary>
		/// Value of variable $LINK_TYPE
		/// </summary>
		public int[] LinkType { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_NUM
		/// </summary>
		public int[] ArmloadNum { get; }

		/// <summary>
		/// Value of variable $DH_THETA0
		/// </summary>
		public double[] DhTheta0 { get; }

		/// <summary>
		/// Value of variable $DH_THETA
		/// </summary>
		public double[] DhTheta { get; }

		/// <summary>
		/// Value of variable $DH_D
		/// </summary>
		public double[] DhD { get; }

		/// <summary>
		/// Value of variable $DH_A
		/// </summary>
		public double[] DhA { get; }

		/// <summary>
		/// Value of variable $DH_ALPHA
		/// </summary>
		public double[] DhAlpha { get; }

		/// <summary>
		/// Value of variable $LINK_M
		/// </summary>
		public double[] LinkM { get; }

		/// <summary>
		/// Value of variable $LINK_SX
		/// </summary>
		public double[] LinkSx { get; }

		/// <summary>
		/// Value of variable $LINK_SY
		/// </summary>
		public double[] LinkSy { get; }

		/// <summary>
		/// Value of variable $LINK_SZ
		/// </summary>
		public double[] LinkSz { get; }

		/// <summary>
		/// Value of variable $LINK_IX
		/// </summary>
		public double[] LinkIx { get; }

		/// <summary>
		/// Value of variable $LINK_IY
		/// </summary>
		public double[] LinkIy { get; }

		/// <summary>
		/// Value of variable $LINK_IZ
		/// </summary>
		public double[] LinkIz { get; }

		/// <summary>
		/// Value of variable $DH_VD
		/// </summary>
		public double[] DhVd { get; }

		/// <summary>
		/// Value of variable $DH_VA
		/// </summary>
		public double[] DhVa { get; }

		/// <summary>
		/// Value of variable $DH_VALPHA
		/// </summary>
		public double[] DhValpha { get; }

		/// <summary>
		/// Value of variable $LINK_VM
		/// </summary>
		public double[] LinkVm { get; }

		/// <summary>
		/// Value of variable $LINK_VSX
		/// </summary>
		public double[] LinkVsx { get; }

		/// <summary>
		/// Value of variable $LINK_VSY
		/// </summary>
		public double[] LinkVsy { get; }

		/// <summary>
		/// Value of variable $LINK_VSZ
		/// </summary>
		public double[] LinkVsz { get; }

		/// <summary>
		/// Value of variable $LINK_VIX
		/// </summary>
		public double[] LinkVix { get; }

		/// <summary>
		/// Value of variable $LINK_VIY
		/// </summary>
		public double[] LinkViy { get; }

		/// <summary>
		/// Value of variable $LINK_VIZ
		/// </summary>
		public double[] LinkViz { get; }

		/// <summary>
		/// Value of variable $DH_HD
		/// </summary>
		public double[] DhHd { get; }

		/// <summary>
		/// Value of variable $DH_HA
		/// </summary>
		public double[] DhHa { get; }

		/// <summary>
		/// Value of variable $DH_HALPHA
		/// </summary>
		public double[] DhHalpha { get; }

		/// <summary>
		/// Value of variable $LINK_HM
		/// </summary>
		public double[] LinkHm { get; }

		/// <summary>
		/// Value of variable $LINK_HSX
		/// </summary>
		public double[] LinkHsx { get; }

		/// <summary>
		/// Value of variable $LINK_HSY
		/// </summary>
		public double[] LinkHsy { get; }

		/// <summary>
		/// Value of variable $LINK_HSZ
		/// </summary>
		public double[] LinkHsz { get; }

		/// <summary>
		/// Value of variable $LINK_HIX
		/// </summary>
		public double[] LinkHix { get; }

		/// <summary>
		/// Value of variable $LINK_HIY
		/// </summary>
		public double[] LinkHiy { get; }

		/// <summary>
		/// Value of variable $LINK_HIZ
		/// </summary>
		public double[] LinkHiz { get; }

		/// <summary>
		/// Value of variable $DH_OTHETA
		/// </summary>
		public double[] DhOtheta { get; }

		/// <summary>
		/// Value of variable $DH_OD
		/// </summary>
		public double[] DhOd { get; }

		/// <summary>
		/// Value of variable $DH_OA
		/// </summary>
		public double[] DhOa { get; }

		/// <summary>
		/// Value of variable $DH_OALPHA
		/// </summary>
		public double[] DhOalpha { get; }

		/// <summary>
		/// Value of variable $LINK_OM
		/// </summary>
		public double[] LinkOm { get; }

		/// <summary>
		/// Value of variable $LINK_OSX
		/// </summary>
		public double[] LinkOsx { get; }

		/// <summary>
		/// Value of variable $LINK_OSY
		/// </summary>
		public double[] LinkOsy { get; }

		/// <summary>
		/// Value of variable $LINK_OSZ
		/// </summary>
		public double[] LinkOsz { get; }

		/// <summary>
		/// Value of variable $LINK_OIX
		/// </summary>
		public double[] LinkOix { get; }

		/// <summary>
		/// Value of variable $LINK_OIY
		/// </summary>
		public double[] LinkOiy { get; }

		/// <summary>
		/// Value of variable $LINK_OIZ
		/// </summary>
		public double[] LinkOiz { get; }

		/// <summary>
		/// Value of variable $FLINK_BX
		/// </summary>
		public double[] FlinkBx { get; }

		/// <summary>
		/// Value of variable $FLINK_BY
		/// </summary>
		public double[] FlinkBy { get; }

		/// <summary>
		/// Value of variable $FLINK_BETA
		/// </summary>
		public double[] FlinkBeta { get; }

		/// <summary>
		/// Value of variable $SPBALANCE_K
		/// </summary>
		public double[] SpbalanceK { get; }

		/// <summary>
		/// Value of variable $SPLENGTH_0
		/// </summary>
		public double[] Splength0 { get; }

		/// <summary>
		/// Value of variable $SPACT_X
		/// </summary>
		public double[] SpactX { get; }

		/// <summary>
		/// Value of variable $SPACT_Y
		/// </summary>
		public double[] SpactY { get; }

		/// <summary>
		/// Value of variable $SPACT_Z
		/// </summary>
		public double[] SpactZ { get; }

		/// <summary>
		/// Value of variable $SPFULC_X
		/// </summary>
		public double[] SpfulcX { get; }

		/// <summary>
		/// Value of variable $SPFULC_Y
		/// </summary>
		public double[] SpfulcY { get; }

		/// <summary>
		/// Value of variable $SPFULC_Z
		/// </summary>
		public double[] SpfulcZ { get; }

		/// <summary>
		/// Value of variable $INTERACTION
		/// </summary>
		public InteractVariableType[] Interaction { get; }

		/// <summary>
		/// Value of variable $AUTO_SNGSTP
		/// </summary>
		public bool AutoSngstp { get; }

		/// <summary>
		/// Value of variable $T1T2_SNGSTP
		/// </summary>
		public bool T1t2Sngstp { get; }

		/// <summary>
		/// Value of variable $CART_2ND_TI
		/// </summary>
		public short Cart2ndTi { get; }

		/// <summary>
		/// Value of variable $JNT_2ND_TIM
		/// </summary>
		public short[] Jnt2ndTim { get; }

		/// <summary>
		/// Value of variable $LC_QSTP_ENB
		/// </summary>
		public bool LcQstpEnb { get; }

		/// <summary>
		/// Value of variable $CP_CUTOFFOV
		/// </summary>
		public short CpCutoffov { get; }

		/// <summary>
		/// Value of variable $CP_MINSEG
		/// </summary>
		public short CpMinseg { get; }

		/// <summary>
		/// Value of variable $MASTREV_ENB
		/// </summary>
		public bool MastrevEnb { get; }

		/// <summary>
		/// Value of variable $MASPOS_DIFF
		/// </summary>
		public double[] MasposDiff { get; }

		/// <summary>
		/// Value of variable $INTRAC_NUM
		/// </summary>
		public IntracNVariableType[] IntracNum { get; }

		/// <summary>
		/// Value of variable $INTRAC_DIV
		/// </summary>
		public IntracDVariableType[] IntracDiv { get; }

		/// <summary>
		/// Value of variable $OBS_DIST
		/// </summary>
		public double ObsDist { get; }

		/// <summary>
		/// Value of variable $SV_PARAM
		/// </summary>
		public double[] SvParam { get; }

		/// <summary>
		/// Value of variable $MIJNTCHKLMT
		/// </summary>
		public bool Mijntchklmt { get; }

		/// <summary>
		/// Value of variable $LCHWARN_ENB
		/// </summary>
		public bool LchwarnEnb { get; }

		/// <summary>
		/// Value of variable $ABC_PARAM
		/// </summary>
		public double[] AbcParam { get; }

		/// <summary>
		/// Value of variable $MECH_MASK
		/// </summary>
		public int MechMask { get; }

		/// <summary>
		/// Value of variable $MECH_TYPE
		/// </summary>
		public int MechType { get; }

		/// <summary>
		/// Value of variable $AXS_MAP_NUM
		/// </summary>
		public int AxsMapNum { get; }

		/// <summary>
		/// Value of variable $AXS_MAP
		/// </summary>
		public int[] AxsMap { get; }

		/// <summary>
		/// Value of variable $DH_EXTRA
		/// </summary>
		public DhExtraVariableType[] DhExtra { get; }

		/// <summary>
		/// Value of variable $AXS_COUPLE
		/// </summary>
		public short[] AxsCouple { get; }

		/// <summary>
		/// Value of variable $PS_ROBOT_CR
		/// </summary>
		public short PsRobotCr { get; }

		/// <summary>
		/// Value of variable $ROBOT_CRC
		/// </summary>
		public int RobotCrc { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
