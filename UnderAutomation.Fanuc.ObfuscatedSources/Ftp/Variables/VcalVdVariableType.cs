//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VCAL_VD_T
	/// </summary>
	public class VcalVdVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable VPROG_NAME
		/// </summary>
		public string VprogName { get; }

		/// <summary>
		/// Value of variable CAMERA_NAME
		/// </summary>
		public string CameraName { get; }

		/// <summary>
		/// Value of variable TOOL_TYPE
		/// </summary>
		public int ToolType { get; }

		/// <summary>
		/// Value of variable DETECT_TYPE
		/// </summary>
		public int DetectType { get; }

		/// <summary>
		/// Value of variable EXPO_TIME
		/// </summary>
		public int ExpoTime { get; }

		/// <summary>
		/// Value of variable NUM_MUL_EXPO
		/// </summary>
		public int NumMulExpo { get; }

		/// <summary>
		/// Value of variable NUM_MEP_USB
		/// </summary>
		public int NumMepUsb { get; }

		/// <summary>
		/// Value of variable VIS_XYZ
		/// </summary>
		public CartesianPositionVariable VisXyz { get; }

		/// <summary>
		/// Value of variable LOG_PORT
		/// </summary>
		public int LogPort { get; }

		/// <summary>
		/// Value of variable FOCAL_DIST
		/// </summary>
		public double FocalDist { get; }

		/// <summary>
		/// Value of variable GRID_SPACING
		/// </summary>
		public double GridSpacing { get; }

		/// <summary>
		/// Value of variable DISTORT
		/// </summary>
		public double[] Distort { get; }

		/// <summary>
		/// Value of variable OVRRD_FOCUS
		/// </summary>
		public bool OvrrdFocus { get; }

		/// <summary>
		/// Value of variable NUM_RETRY
		/// </summary>
		public int NumRetry { get; }

		/// <summary>
		/// Value of variable TRIM_RATIO
		/// </summary>
		public double TrimRatio { get; }

		/// <summary>
		/// Value of variable FDOT_T
		/// </summary>
		public FdotVariableType FdotT { get; }

		/// <summary>
		/// Value of variable LED_TYPE
		/// </summary>
		public int LedType { get; }

		/// <summary>
		/// Value of variable LED_INTENSIT
		/// </summary>
		public int LedIntensit { get; }

		/// <summary>
		/// Value of variable $DUMMY18
		/// </summary>
		public byte Dummy18 { get; }

		/// <summary>
		/// Value of variable $DUMMY19
		/// </summary>
		public byte Dummy19 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
