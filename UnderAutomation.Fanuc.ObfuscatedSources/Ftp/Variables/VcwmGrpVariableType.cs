//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VCWM_GRP_T
	/// </summary>
	public class VcwmGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Value of variable $STATUS_FLAG
		/// </summary>
		public int StatusFlag { get; }

		/// <summary>
		/// Value of variable $DEBUG_MODE
		/// </summary>
		public int DebugMode { get; }

		/// <summary>
		/// Value of variable $GROUP_NUM
		/// </summary>
		public byte GroupNum { get; }

		/// <summary>
		/// Value of variable $MENU_CODE
		/// </summary>
		public byte MenuCode { get; }

		/// <summary>
		/// Value of variable $NUM_MEP
		/// </summary>
		public byte NumMep { get; }

		/// <summary>
		/// Value of variable $NUM_RETRY
		/// </summary>
		public byte NumRetry { get; }

		/// <summary>
		/// Value of variable $NUM_MEP_USB
		/// </summary>
		public int NumMepUsb { get; }

		/// <summary>
		/// Value of variable $EXPOS_TIME
		/// </summary>
		public int ExposTime { get; }

		/// <summary>
		/// Value of variable $TRIM_RATIO
		/// </summary>
		public double TrimRatio { get; }

		/// <summary>
		/// Value of variable $CAMERA_NAME
		/// </summary>
		public string CameraName { get; }

		/// <summary>
		/// Value of variable $TOOL_TYPE
		/// </summary>
		public int ToolType { get; }

		/// <summary>
		/// Value of variable $FOCAL_DIST
		/// </summary>
		public double FocalDist { get; }

		/// <summary>
		/// Value of variable $GRID_SPACIN
		/// </summary>
		public double GridSpacin { get; }

		/// <summary>
		/// Value of variable $SWING_ANG_D
		/// </summary>
		public double[] SwingAngD { get; }

		/// <summary>
		/// Value of variable $UTOOL
		/// </summary>
		public double[] Utool { get; }

		/// <summary>
		/// Value of variable $UPPER_LIM_S
		/// </summary>
		public double UpperLimS { get; }

		/// <summary>
		/// Value of variable $BASE_ANG_D
		/// </summary>
		public double[] BaseAngD { get; }

		/// <summary>
		/// Value of variable $ANG_RANGE_D
		/// </summary>
		public double[] AngRangeD { get; }

		/// <summary>
		/// Value of variable $INI_POS_JNT
		/// </summary>
		public double[] IniPosJnt { get; }

		/// <summary>
		/// Value of variable $REF_POS_JNT
		/// </summary>
		public double[] RefPosJnt { get; }

		/// <summary>
		/// Value of variable $ORG_MST_CT
		/// </summary>
		public int[] OrgMstCt { get; }

		/// <summary>
		/// Value of variable $COMPE_ANG_D
		/// </summary>
		public double[] CompeAngD { get; }

		/// <summary>
		/// Value of variable $NEW_MST_CT
		/// </summary>
		public int[] NewMstCt { get; }

		/// <summary>
		/// Value of variable $MASTER_TIME
		/// </summary>
		public int MasterTime { get; }

		/// <summary>
		/// Value of variable $EVAL_INDEX
		/// </summary>
		public double EvalIndex { get; }

		/// <summary>
		/// Value of variable $MEAN_RES_ER
		/// </summary>
		public double MeanResEr { get; }

		/// <summary>
		/// Value of variable $MAX_RES_ER
		/// </summary>
		public double MaxResEr { get; }

		/// <summary>
		/// Value of variable $TRGT_POS_ER
		/// </summary>
		public double[] TrgtPosEr { get; }

		/// <summary>
		/// Value of variable $WORST_MP
		/// </summary>
		public int WorstMp { get; }

		/// <summary>
		/// Value of variable $MOVE_XYZ
		/// </summary>
		public double MoveXyz { get; }

		/// <summary>
		/// Value of variable $MOVE_R_DEG
		/// </summary>
		public double MoveRDeg { get; }

		/// <summary>
		/// Value of variable $LOG_PORT
		/// </summary>
		public int LogPort { get; }

		/// <summary>
		/// Value of variable $MAX_LOOP
		/// </summary>
		public int MaxLoop { get; }

		/// <summary>
		/// Value of variable $VFB_TOL
		/// </summary>
		public double VfbTol { get; }

		/// <summary>
		/// Value of variable $VS_SPEED
		/// </summary>
		public double VsSpeed { get; }

		/// <summary>
		/// Value of variable $MAX_RDELAY
		/// </summary>
		public int MaxRdelay { get; }

		/// <summary>
		/// Value of variable $POS_THRES
		/// </summary>
		public double PosThres { get; }

		/// <summary>
		/// Value of variable $TILT_ANG_D
		/// </summary>
		public double TiltAngD { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
