//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $CAMERA
	/// </summary>
	public class CameraVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $VISION_TYPE
		/// </summary>
		public byte VisionType { get; }

		/// <summary>
		/// Value of variable $CAMERA_TYPE
		/// </summary>
		public byte CameraType { get; }

		/// <summary>
		/// Value of variable $CAMERA_PORT
		/// </summary>
		public byte CameraPort { get; }

		/// <summary>
		/// Value of variable $DETECT_TYPE
		/// </summary>
		public byte DetectType { get; }

		/// <summary>
		/// Value of variable $DRIVE_TYPE
		/// </summary>
		public byte DriveType { get; }

		/// <summary>
		/// Value of variable $SET_VTCP
		/// </summary>
		public byte SetVtcp { get; }

		/// <summary>
		/// Value of variable $DEBUG_CODE
		/// </summary>
		public byte DebugCode { get; }

		/// <summary>
		/// Value of variable $DMY_UBYTE
		/// </summary>
		public byte DmyUbyte { get; }

		/// <summary>
		/// Value of variable $CAMERA_NAME
		/// </summary>
		public string CameraName { get; }

		/// <summary>
		/// Value of variable $TOOL_TYPE
		/// </summary>
		public int ToolType { get; }

		/// <summary>
		/// Value of variable $DISTORTION1
		/// </summary>
		public double Distortion1 { get; }

		/// <summary>
		/// Value of variable $DISTORTION2
		/// </summary>
		public double Distortion2 { get; }

		/// <summary>
		/// Value of variable $DISP_SCALE
		/// </summary>
		public int DispScale { get; }

		/// <summary>
		/// Value of variable $DISP_LUT
		/// </summary>
		public bool DispLut { get; }

		/// <summary>
		/// Value of variable $OUTPUT_BMP
		/// </summary>
		public bool OutputBmp { get; }

		/// <summary>
		/// Value of variable $HANDEYE
		/// </summary>
		public bool Handeye { get; }

		/// <summary>
		/// Value of variable $EXPOS_TIME
		/// </summary>
		public int ExposTime { get; }

		/// <summary>
		/// Value of variable $NUM_MUL_EXP
		/// </summary>
		public int NumMulExp { get; }

		/// <summary>
		/// Value of variable $NUM_MEP_USB
		/// </summary>
		public int NumMepUsb { get; }

		/// <summary>
		/// Value of variable $TRIM_RATIO
		/// </summary>
		public double TrimRatio { get; }

		/// <summary>
		/// Value of variable $FOCAL_DIST
		/// </summary>
		public double FocalDist { get; }

		/// <summary>
		/// Value of variable $GD_SPACING
		/// </summary>
		public double GdSpacing { get; }

		/// <summary>
		/// Value of variable $TRGT_DIST
		/// </summary>
		public double TrgtDist { get; }

		/// <summary>
		/// Value of variable $TRGT_W
		/// </summary>
		public double TrgtW { get; }

		/// <summary>
		/// Value of variable $TRGT_P
		/// </summary>
		public double TrgtP { get; }

		/// <summary>
		/// Value of variable $TRGT_R
		/// </summary>
		public double TrgtR { get; }

		/// <summary>
		/// Value of variable $NUM_RETRY
		/// </summary>
		public int NumRetry { get; }

		/// <summary>
		/// Value of variable $UTOOL
		/// </summary>
		public double[] Utool { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
