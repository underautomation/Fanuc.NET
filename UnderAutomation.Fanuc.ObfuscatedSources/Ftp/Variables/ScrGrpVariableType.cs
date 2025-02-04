//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SCR_GRP_T
	/// </summary>
	public class ScrGrpVariableType : GenericVariableType, IGenericVariableType {


		public ScrGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ARM_TYPE
		/// </summary>
		public byte ArmType { get; }

		/// <summary>
		/// Value of variable $DUMMY127
		/// </summary>
		public byte Dummy127 { get; }

		/// <summary>
		/// Value of variable $ARM_TYPE_B
		/// </summary>
		public int ArmTypeB { get; }

		/// <summary>
		/// Value of variable $NUM_AXES
		/// </summary>
		public byte NumAxes { get; }

		/// <summary>
		/// Value of variable $NUM_ROB_AXS
		/// </summary>
		public byte NumRobAxs { get; }

		/// <summary>
		/// Value of variable $NUM_RED_AXS
		/// </summary>
		public byte NumRedAxs { get; }

		/// <summary>
		/// Value of variable $WRST_AXIS_S
		/// </summary>
		public byte WrstAxisS { get; }

		/// <summary>
		/// Value of variable $WRST_AXIS_E
		/// </summary>
		public byte WrstAxisE { get; }

		/// <summary>
		/// Value of variable $SYNC_M_AXIS
		/// </summary>
		public byte SyncMAxis { get; }

		/// <summary>
		/// Value of variable $SYNC_S_AXIS
		/// </summary>
		public byte SyncSAxis { get; }

		/// <summary>
		/// Value of variable $WRIST_TYPE
		/// </summary>
		public byte WristType { get; }

		/// <summary>
		/// Value of variable $HW_STRT_AXS
		/// </summary>
		public int HwStrtAxs { get; }

		/// <summary>
		/// Value of variable $AXISORDER
		/// </summary>
		public byte[] Axisorder { get; }

		/// <summary>
		/// Value of variable $DUMMY128
		/// </summary>
		public byte Dummy128 { get; }

		/// <summary>
		/// Value of variable $BRK_NUMBER
		/// </summary>
		public byte[] BrkNumber { get; }

		/// <summary>
		/// Value of variable $DUMMY129
		/// </summary>
		public byte Dummy129 { get; }

		/// <summary>
		/// Value of variable $DD_MOTOR
		/// </summary>
		public bool[] DdMotor { get; }

		/// <summary>
		/// Value of variable $ROTARY_AXS
		/// </summary>
		public bool[] RotaryAxs { get; }

		/// <summary>
		/// Value of variable $LOADRATIO
		/// </summary>
		public double[] Loadratio { get; }

		/// <summary>
		/// Value of variable $CONFIG_MASK
		/// </summary>
		public Configuration ConfigMask { get; }

		/// <summary>
		/// Value of variable $LINK_LENGTH
		/// </summary>
		public double[] LinkLength { get; }

		/// <summary>
		/// Value of variable $EXT_ORDER
		/// </summary>
		public byte[] ExtOrder { get; }

		/// <summary>
		/// Value of variable $DUMMY130
		/// </summary>
		public byte Dummy130 { get; }

		/// <summary>
		/// Value of variable $EXT_XYZ_MAP
		/// </summary>
		public byte[] ExtXyzMap { get; }

		/// <summary>
		/// Value of variable $DUMMY131
		/// </summary>
		public byte Dummy131 { get; }

		/// <summary>
		/// Value of variable $EXT_OFFSET
		/// </summary>
		public double[] ExtOffset { get; }

		/// <summary>
		/// Value of variable $EXT_LENGTH
		/// </summary>
		public double[] ExtLength { get; }

		/// <summary>
		/// Value of variable $ROBOT_ID
		/// </summary>
		public string RobotId { get; }

		/// <summary>
		/// Value of variable $ROBOT_MODEL
		/// </summary>
		public string RobotModel { get; }

		/// <summary>
		/// Value of variable $ROBOT_FILE
		/// </summary>
		public string RobotFile { get; }

		/// <summary>
		/// Value of variable $ROBOT_INT
		/// </summary>
		public int RobotInt { get; }

		/// <summary>
		/// Value of variable $SV_CODE_ID
		/// </summary>
		public string SvCodeId { get; }

		/// <summary>
		/// Value of variable $JOGLIM_JNT
		/// </summary>
		public int[] JoglimJnt { get; }

		/// <summary>
		/// Value of variable $COORD_MASK
		/// </summary>
		public short CoordMask { get; }

		/// <summary>
		/// Value of variable $OP_BRK_NUM
		/// </summary>
		public byte[] OpBrkNum { get; }

		/// <summary>
		/// Value of variable $DUMMY132
		/// </summary>
		public byte Dummy132 { get; }

		/// <summary>
		/// Value of variable $USE_TBJNT
		/// </summary>
		public bool UseTbjnt { get; }

		/// <summary>
		/// Value of variable $USE_TBCART
		/// </summary>
		public bool UseTbcart { get; }

		/// <summary>
		/// Value of variable $NUM_DUAL
		/// </summary>
		public byte NumDual { get; }

		/// <summary>
		/// Value of variable $DUMMY133
		/// </summary>
		public byte Dummy133 { get; }

		/// <summary>
		/// Value of variable $TURN_AXIS
		/// </summary>
		public int[] TurnAxis { get; }

		/// <summary>
		/// Value of variable $AXS_AMP_NUM
		/// </summary>
		public byte[] AxsAmpNum { get; }

		/// <summary>
		/// Value of variable $FLEXTOOLTYP
		/// </summary>
		public byte Flextooltyp { get; }

		/// <summary>
		/// Value of variable $AXS_XYZ_MAP
		/// </summary>
		public byte[] AxsXyzMap { get; }

		/// <summary>
		/// Value of variable $DUMMY134
		/// </summary>
		public byte Dummy134 { get; }

		/// <summary>
		/// Value of variable $OFST
		/// </summary>
		public AxOfsVariableType[] Ofst { get; }

		/// <summary>
		/// Value of variable $KINEM_ENB
		/// </summary>
		public byte KinemEnb { get; }

		/// <summary>
		/// Value of variable $DUMMY135
		/// </summary>
		public byte Dummy135 { get; }

		/// <summary>
		/// Value of variable $UPDATE_MAP
		/// </summary>
		public int UpdateMap { get; }

		/// <summary>
		/// Value of variable $TORQCTRL
		/// </summary>
		public int Torqctrl { get; }

		/// <summary>
		/// Value of variable $DSP_NUM
		/// </summary>
		public byte[] DspNum { get; }

		/// <summary>
		/// Value of variable $DUMMY136
		/// </summary>
		public byte Dummy136 { get; }

		/// <summary>
		/// Value of variable $M_POS_ENB
		/// </summary>
		public bool MPosEnb { get; }

		/// <summary>
		/// Value of variable $M_DST_ENB
		/// </summary>
		public bool MDstEnb { get; }

		/// <summary>
		/// Value of variable $MOVE_DST
		/// </summary>
		public double MoveDst { get; }

		/// <summary>
		/// Value of variable $MCH_POS_X
		/// </summary>
		public double MchPosX { get; }

		/// <summary>
		/// Value of variable $MCH_POS_Y
		/// </summary>
		public double MchPosY { get; }

		/// <summary>
		/// Value of variable $MCH_POS_Z
		/// </summary>
		public double MchPosZ { get; }

		/// <summary>
		/// Value of variable $MCH_POS_W
		/// </summary>
		public double MchPosW { get; }

		/// <summary>
		/// Value of variable $MCH_POS_P
		/// </summary>
		public double MchPosP { get; }

		/// <summary>
		/// Value of variable $MCH_POS_R
		/// </summary>
		public double MchPosR { get; }

		/// <summary>
		/// Value of variable $MCH_ANG
		/// </summary>
		public double[] MchAng { get; }

		/// <summary>
		/// Value of variable $MCH_SPD
		/// </summary>
		public double MchSpd { get; }

		/// <summary>
		/// Value of variable $DST_MIR_P
		/// </summary>
		public int DstMirP { get; }

		/// <summary>
		/// Value of variable $DPOS_DST
		/// </summary>
		public double DposDst { get; }

		/// <summary>
		/// Value of variable $DST_POS_X
		/// </summary>
		public double DstPosX { get; }

		/// <summary>
		/// Value of variable $DST_POS_Y
		/// </summary>
		public double DstPosY { get; }

		/// <summary>
		/// Value of variable $DST_POS_Z
		/// </summary>
		public double DstPosZ { get; }

		/// <summary>
		/// Value of variable $DSP_ERCNT
		/// </summary>
		public short[] DspErcnt { get; }

		/// <summary>
		/// Value of variable $DEST_DATA_P
		/// </summary>
		public int[] DestDataP { get; }

		/// <summary>
		/// Value of variable $ROBOT_FUNC
		/// </summary>
		public int RobotFunc { get; }

		/// <summary>
		/// Value of variable $PROC_AXS
		/// </summary>
		public bool[] ProcAxs { get; }

		/// <summary>
		/// Value of variable $DAC_MODE
		/// </summary>
		public int DacMode { get; }

		/// <summary>
		/// Value of variable $DAC_AXMODE
		/// </summary>
		public int[] DacAxmode { get; }

		/// <summary>
		/// Value of variable $DAC_RATE1
		/// </summary>
		public double[] DacRate1 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE2
		/// </summary>
		public double[] DacRate2 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE3
		/// </summary>
		public double[] DacRate3 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE4
		/// </summary>
		public double[] DacRate4 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE5
		/// </summary>
		public double[] DacRate5 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE6
		/// </summary>
		public double[] DacRate6 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE7
		/// </summary>
		public double[] DacRate7 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE8
		/// </summary>
		public double[] DacRate8 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE9
		/// </summary>
		public double[] DacRate9 { get; }

		/// <summary>
		/// Value of variable $DAC_RATE10
		/// </summary>
		public double[] DacRate10 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT1
		/// </summary>
		public double[] DacLmt1 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT2
		/// </summary>
		public double[] DacLmt2 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT3
		/// </summary>
		public double[] DacLmt3 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT4
		/// </summary>
		public double[] DacLmt4 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT5
		/// </summary>
		public double[] DacLmt5 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT6
		/// </summary>
		public double[] DacLmt6 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT7
		/// </summary>
		public double[] DacLmt7 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT8
		/// </summary>
		public double[] DacLmt8 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT9
		/// </summary>
		public double[] DacLmt9 { get; }

		/// <summary>
		/// Value of variable $DAC_LMT10
		/// </summary>
		public double[] DacLmt10 { get; }

		/// <summary>
		/// Value of variable $DAC_FLT_LEN
		/// </summary>
		public int DacFltLen { get; }

		/// <summary>
		/// Value of variable $DAC_DEBUG
		/// </summary>
		public int[] DacDebug { get; }

		/// <summary>
		/// Value of variable $FUNC_SW
		/// </summary>
		public int[] FuncSw { get; }

		/// <summary>
		/// Value of variable $FUNC_VAL
		/// </summary>
		public double[] FuncVal { get; }

		/// <summary>
		/// Value of variable $ABC_ENB
		/// </summary>
		public bool AbcEnb { get; }

		/// <summary>
		/// Value of variable $HBK_ENBL
		/// </summary>
		public bool HbkEnbl { get; }

		/// <summary>
		/// Value of variable $MV_DIAG
		/// </summary>
		public double[] MvDiag { get; }

		/// <summary>
		/// Value of variable $ABC_MODE1
		/// </summary>
		public double AbcMode1 { get; }

		/// <summary>
		/// Value of variable $ABC_MODE2
		/// </summary>
		public double AbcMode2 { get; }

		/// <summary>
		/// Value of variable $ABC_MODE3
		/// </summary>
		public double AbcMode3 { get; }

		/// <summary>
		/// Value of variable $ABC_MODE4
		/// </summary>
		public double AbcMode4 { get; }

		/// <summary>
		/// Value of variable $ABC_MODE5
		/// </summary>
		public double AbcMode5 { get; }

		/// <summary>
		/// Value of variable $ABC_MODE6
		/// </summary>
		public double AbcMode6 { get; }

		/// <summary>
		/// Value of variable $ABC_MODE7
		/// </summary>
		public double AbcMode7 { get; }

		/// <summary>
		/// Value of variable $ABC_MODE8
		/// </summary>
		public double AbcMode8 { get; }

		/// <summary>
		/// Value of variable $ABC_MODE9
		/// </summary>
		public double AbcMode9 { get; }

		/// <summary>
		/// Value of variable $SAFE_JNTSPD
		/// </summary>
		public double[] SafeJntspd { get; }

		/// <summary>
		/// Value of variable $ROBOT_LABEL
		/// </summary>
		public string RobotLabel { get; }

		/// <summary>
		/// Value of variable $DSP_NUM_FLG
		/// </summary>
		public int DspNumFlg { get; }

		/// <summary>
		/// Value of variable $GROUP_NUM
		/// </summary>
		public int GroupNum { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public short[] CompSw { get; }

		/// <summary>
		/// Value of variable $AMB_TEMP
		/// </summary>
		public double AmbTemp { get; }

		/// <summary>
		/// Value of variable $DSP_STRT_AX
		/// </summary>
		public int DspStrtAx { get; }

		/// <summary>
		/// Value of variable $TOT_SBR_NUM
		/// </summary>
		public int TotSbrNum { get; }

		/// <summary>
		/// Value of variable $TOT_DSP_NUM
		/// </summary>
		public int TotDspNum { get; }

		/// <summary>
		/// Value of variable $TOT_ATR_NUM
		/// </summary>
		public int TotAtrNum { get; }

		/// <summary>
		/// Value of variable $TANDEM_SUB
		/// </summary>
		public short[] TandemSub { get; }

		/// <summary>
		/// Value of variable $DSP_ORDER
		/// </summary>
		public short[] DspOrder { get; }

		/// <summary>
		/// Value of variable $ATR_ORDER
		/// </summary>
		public short[] AtrOrder { get; }

		/// <summary>
		/// Value of variable $AMPINF_ORDR
		/// </summary>
		public short[] AmpinfOrdr { get; }

		/// <summary>
		/// Value of variable $AMPCUR_ORDR
		/// </summary>
		public short[] AmpcurOrdr { get; }

		/// <summary>
		/// Value of variable $FIX_ORNT_WR
		/// </summary>
		public bool FixOrntWr { get; }

		/// <summary>
		/// Value of variable $JNT_VEL_LIM
		/// </summary>
		public double[] JntVelLim { get; }

		/// <summary>
		/// Value of variable $JNT_ACC_LIM
		/// </summary>
		public double[] JntAccLim { get; }

		/// <summary>
		/// Value of variable $JOGLIMROT
		/// </summary>
		public int Joglimrot { get; }

		/// <summary>
		/// Value of variable $ROBOT_NAME
		/// </summary>
		public string RobotName { get; }

		/// <summary>
		/// Value of variable $AXIS_CAT
		/// </summary>
		public short[] AxisCat { get; }

		/// <summary>
		/// Value of variable $DUMMY137
		/// </summary>
		public byte Dummy137 { get; }

		/// <summary>
		/// Value of variable $DUMMY138
		/// </summary>
		public byte Dummy138 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
