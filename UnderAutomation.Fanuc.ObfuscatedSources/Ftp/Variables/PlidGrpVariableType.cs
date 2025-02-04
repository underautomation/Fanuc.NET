//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PLID_GRP_T
	/// </summary>
	public class PlidGrpVariableType : GenericVariableType, IGenericVariableType {


		public PlidGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $PI_ENB
		/// </summary>
		public int PiEnb { get; }

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public double Payload { get; }

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
		/// Value of variable $ARMLOAD1
		/// </summary>
		public double Armload1 { get; }

		/// <summary>
		/// Value of variable $ARMLOAD2
		/// </summary>
		public double Armload2 { get; }

		/// <summary>
		/// Value of variable $ARMLOAD3
		/// </summary>
		public double Armload3 { get; }

		/// <summary>
		/// Value of variable $ROB_TYPE
		/// </summary>
		public int RobType { get; }

		/// <summary>
		/// Value of variable $DATA_NUM
		/// </summary>
		public int DataNum { get; }

		/// <summary>
		/// Value of variable $SPEED_HIGH
		/// </summary>
		public int SpeedHigh { get; }

		/// <summary>
		/// Value of variable $SPEED_LOW
		/// </summary>
		public int SpeedLow { get; }

		/// <summary>
		/// Value of variable $DEFSPD_HIGH
		/// </summary>
		public int DefspdHigh { get; }

		/// <summary>
		/// Value of variable $DEFSPD_LOW
		/// </summary>
		public int DefspdLow { get; }

		/// <summary>
		/// Value of variable $ACCEL_HIGH
		/// </summary>
		public int AccelHigh { get; }

		/// <summary>
		/// Value of variable $ACCEL_LOW
		/// </summary>
		public int AccelLow { get; }

		/// <summary>
		/// Value of variable $DEFACC_HIGH
		/// </summary>
		public int DefaccHigh { get; }

		/// <summary>
		/// Value of variable $DEFACC_LOW
		/// </summary>
		public int DefaccLow { get; }

		/// <summary>
		/// Value of variable $SAMPLE_TIME
		/// </summary>
		public int SampleTime { get; }

		/// <summary>
		/// Value of variable $SAMPLE_HIGH
		/// </summary>
		public int SampleHigh { get; }

		/// <summary>
		/// Value of variable $SAMPLE_LOW
		/// </summary>
		public int SampleLow { get; }

		/// <summary>
		/// Value of variable $MOV_AXIS
		/// </summary>
		public bool[] MovAxis { get; }

		/// <summary>
		/// Value of variable $MOV_POS1
		/// </summary>
		public double[] MovPos1 { get; }

		/// <summary>
		/// Value of variable $MOV_POS2
		/// </summary>
		public double[] MovPos2 { get; }

		/// <summary>
		/// Value of variable $MOV_DEF1
		/// </summary>
		public double[] MovDef1 { get; }

		/// <summary>
		/// Value of variable $MOV_DEF2
		/// </summary>
		public double[] MovDef2 { get; }

		/// <summary>
		/// Value of variable $ROT_INERTIA
		/// </summary>
		public double[] RotInertia { get; }

		/// <summary>
		/// Value of variable $MAX_VEL_HI
		/// </summary>
		public double[] MaxVelHi { get; }

		/// <summary>
		/// Value of variable $MIN_VEL_HI
		/// </summary>
		public double[] MinVelHi { get; }

		/// <summary>
		/// Value of variable $MAX_ACC_HI
		/// </summary>
		public double[] MaxAccHi { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_HI
		/// </summary>
		public double[] MinAccHi { get; }

		/// <summary>
		/// Value of variable $MAX_VEL_LOW
		/// </summary>
		public double[] MaxVelLow { get; }

		/// <summary>
		/// Value of variable $MIN_VEL_LOW
		/// </summary>
		public double[] MinVelLow { get; }

		/// <summary>
		/// Value of variable $MAX_ACC_LOW
		/// </summary>
		public double[] MaxAccLow { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_LOW
		/// </summary>
		public double[] MinAccLow { get; }

		/// <summary>
		/// Value of variable $GAMMA
		/// </summary>
		public double[] Gamma { get; }

		/// <summary>
		/// Value of variable $STOP_DATA
		/// </summary>
		public int StopData { get; }

		/// <summary>
		/// Value of variable $GETDATA_FIN
		/// </summary>
		public int GetdataFin { get; }

		/// <summary>
		/// Value of variable $ID_RESULT
		/// </summary>
		public double[] IdResult { get; }

		/// <summary>
		/// Value of variable $CALIBRATE
		/// </summary>
		public int Calibrate { get; }

		/// <summary>
		/// Value of variable $PI_DEBUG
		/// </summary>
		public int PiDebug { get; }

		/// <summary>
		/// Value of variable $HIDAT_V_MAX
		/// </summary>
		public double[] HidatVMax { get; }

		/// <summary>
		/// Value of variable $HIDAT_V_MEA
		/// </summary>
		public double[] HidatVMea { get; }

		/// <summary>
		/// Value of variable $HIDAT_A_MAX
		/// </summary>
		public double[] HidatAMax { get; }

		/// <summary>
		/// Value of variable $HIDAT_A_MEA
		/// </summary>
		public double[] HidatAMea { get; }

		/// <summary>
		/// Value of variable $LWDAT_V_MAX
		/// </summary>
		public double[] LwdatVMax { get; }

		/// <summary>
		/// Value of variable $LWDAT_V_MEA
		/// </summary>
		public double[] LwdatVMea { get; }

		/// <summary>
		/// Value of variable $LWDAT_A_MAX
		/// </summary>
		public double[] LwdatAMax { get; }

		/// <summary>
		/// Value of variable $LWDAT_A_MEA
		/// </summary>
		public double[] LwdatAMea { get; }

		/// <summary>
		/// Value of variable $CALC_TYPE
		/// </summary>
		public int CalcType { get; }

		/// <summary>
		/// Value of variable $MTN_CALCTYP
		/// </summary>
		public int MtnCalctyp { get; }

		/// <summary>
		/// Value of variable $CHKER_VER
		/// </summary>
		public string ChkerVer { get; }

		/// <summary>
		/// Value of variable $PDCK_RB_TYP
		/// </summary>
		public int PdckRbTyp { get; }

		/// <summary>
		/// Value of variable $I_FACTOR
		/// </summary>
		public double[] IFactor { get; }

		/// <summary>
		/// Value of variable $MAX_PAYLOAD
		/// </summary>
		public double MaxPayload { get; }

		/// <summary>
		/// Value of variable $MAX_INERTIA
		/// </summary>
		public double[] MaxInertia { get; }

		/// <summary>
		/// Value of variable $MAX_MOMENT
		/// </summary>
		public double[] MaxMoment { get; }

		/// <summary>
		/// Value of variable $COMB_LOAD
		/// </summary>
		public double[] CombLoad { get; }

		/// <summary>
		/// Value of variable $MAX_PLD_CAL
		/// </summary>
		public MaxPldCalVariableType MaxPldCal { get; }

		/// <summary>
		/// Value of variable $J3D_PLD_CAL
		/// </summary>
		public J3dPldCalVariableType[] J3dPldCal { get; }

		/// <summary>
		/// Value of variable $IM_SRCH_DT
		/// </summary>
		public double ImSrchDt { get; }

		/// <summary>
		/// Value of variable $WARN_DISP
		/// </summary>
		public int WarnDisp { get; }

		/// <summary>
		/// Value of variable $WARN_LEVEL
		/// </summary>
		public double WarnLevel { get; }

		/// <summary>
		/// Value of variable $OVER_LEVEL
		/// </summary>
		public double OverLevel { get; }

		/// <summary>
		/// Value of variable $CALC_RESULT
		/// </summary>
		public CalcResultVariableType CalcResult { get; }

		/// <summary>
		/// Value of variable $PAMSWFLG
		/// </summary>
		public int Pamswflg { get; }

		/// <summary>
		/// Value of variable $AMLD_SCRN
		/// </summary>
		public byte AmldScrn { get; }

		/// <summary>
		/// Value of variable $DUMMY100
		/// </summary>
		public byte Dummy100 { get; }

		/// <summary>
		/// Value of variable $MOV_POS3
		/// </summary>
		public double[] MovPos3 { get; }

		/// <summary>
		/// Value of variable $MOV_POS4
		/// </summary>
		public double[] MovPos4 { get; }

		/// <summary>
		/// Value of variable $MOV_DEF3
		/// </summary>
		public double[] MovDef3 { get; }

		/// <summary>
		/// Value of variable $MOV_DEF4
		/// </summary>
		public double[] MovDef4 { get; }

		/// <summary>
		/// Value of variable $PI3A_ENB
		/// </summary>
		public int Pi3aEnb { get; }

		/// <summary>
		/// Value of variable $METHOD
		/// </summary>
		public int Method { get; }

		/// <summary>
		/// Value of variable $PI3A_TYP
		/// </summary>
		public int Pi3aTyp { get; }

		/// <summary>
		/// Value of variable $PI3A_AXS
		/// </summary>
		public int[] Pi3aAxs { get; }

		/// <summary>
		/// Value of variable $FIXED_AX
		/// </summary>
		public int FixedAx { get; }

		/// <summary>
		/// Value of variable $PERIOD
		/// </summary>
		public int Period { get; }

		/// <summary>
		/// Value of variable $SAMPLE_3A
		/// </summary>
		public int Sample3a { get; }

		/// <summary>
		/// Value of variable $REF_POS
		/// </summary>
		public double[] RefPos { get; }

		/// <summary>
		/// Value of variable $DEF_REF
		/// </summary>
		public double[] DefRef { get; }

		/// <summary>
		/// Value of variable $AMPL1
		/// </summary>
		public double[] Ampl1 { get; }

		/// <summary>
		/// Value of variable $AMPL2
		/// </summary>
		public double[] Ampl2 { get; }

		/// <summary>
		/// Value of variable $DEF_AMPL2
		/// </summary>
		public double[] DefAmpl2 { get; }

		/// <summary>
		/// Value of variable $LIM_AMPL
		/// </summary>
		public double[] LimAmpl { get; }

		/// <summary>
		/// Value of variable $LOOP1
		/// </summary>
		public int[] Loop1 { get; }

		/// <summary>
		/// Value of variable $LOOP2
		/// </summary>
		public int[] Loop2 { get; }

		/// <summary>
		/// Value of variable $APPR_LEN
		/// </summary>
		public int ApprLen { get; }

		/// <summary>
		/// Value of variable $FLT_LEN1
		/// </summary>
		public int[] FltLen1 { get; }

		/// <summary>
		/// Value of variable $FLT_LEN2
		/// </summary>
		public int[] FltLen2 { get; }

		/// <summary>
		/// Value of variable $ROT_INRT_3A
		/// </summary>
		public double[] RotInrt3a { get; }

		/// <summary>
		/// Value of variable $COND_DEF
		/// </summary>
		public double[] CondDef { get; }

		/// <summary>
		/// Value of variable $COND_NUM
		/// </summary>
		public double[] CondNum { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_X
		/// </summary>
		public ArmldPosVariableType[] ArmloadX { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_Y
		/// </summary>
		public ArmldPosVariableType[] ArmloadY { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_Z
		/// </summary>
		public ArmldPosVariableType[] ArmloadZ { get; }

		/// <summary>
		/// Value of variable $RANG_MGN
		/// </summary>
		public double RangMgn { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
