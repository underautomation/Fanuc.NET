//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file aavmmain.va
	/// </summary>
	public class AavmmainFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable I
		/// </summary>
		public int I { get; }

		/// <summary>
		/// Value of variable ROB_GRP
		/// </summary>
		public int RobGrp { get; }

		/// <summary>
		/// Value of variable NUM_AXIS
		/// </summary>
		public int NumAxis { get; }

		/// <summary>
		/// Value of variable PRM
		/// </summary>
		public AavmGrpVariableType Prm { get; }

		/// <summary>
		/// Value of variable PS_ROB_GRP
		/// </summary>
		public int PsRobGrp { get; }

		/// <summary>
		/// Value of variable COND_NUM
		/// </summary>
		public double CondNum { get; }

		/// <summary>
		/// Value of variable RES_ERR
		/// </summary>
		public double ResErr { get; }

		/// <summary>
		/// Value of variable RES_ERR_STR
		/// </summary>
		public string ResErrStr { get; }

		/// <summary>
		/// Value of variable PARAM_NAME
		/// </summary>
		public string ParamName { get; }

		/// <summary>
		/// Value of variable DATA_TYPE
		/// </summary>
		public int DataType { get; }

		/// <summary>
		/// Value of variable DMY_INT
		/// </summary>
		public int DmyInt { get; }

		/// <summary>
		/// Value of variable DMY_REAL
		/// </summary>
		public double DmyReal { get; }

		/// <summary>
		/// Value of variable DMY_STR
		/// </summary>
		public string DmyStr { get; }

		/// <summary>
		/// Value of variable DMY_STR2
		/// </summary>
		public string DmyStr2 { get; }

		/// <summary>
		/// Value of variable DMY_STAT
		/// </summary>
		public int DmyStat { get; }

		/// <summary>
		/// Value of variable VFB_MAT
		/// </summary>
		public double[,] VfbMat { get; }

		/// <summary>
		/// Value of variable RES_ERR1
		/// </summary>
		public double ResErr1 { get; }

		/// <summary>
		/// Value of variable RES_ER1_THSD
		/// </summary>
		public double ResEr1Thsd { get; }

		/// <summary>
		/// Value of variable VTCP_X1_THSD
		/// </summary>
		public double VtcpX1Thsd { get; }

		/// <summary>
		/// Value of variable VTCP_Z1_THSD
		/// </summary>
		public double VtcpZ1Thsd { get; }

		/// <summary>
		/// Value of variable TAGT_X1_THSD
		/// </summary>
		public double TagtX1Thsd { get; }

		/// <summary>
		/// Value of variable TAGT_Z1_THSD
		/// </summary>
		public double TagtZ1Thsd { get; }

		/// <summary>
		/// Value of variable RES_ERR2
		/// </summary>
		public double ResErr2 { get; }

		/// <summary>
		/// Value of variable RES_ER2_THSD
		/// </summary>
		public double ResEr2Thsd { get; }

		/// <summary>
		/// Value of variable VTCP_X2_THSD
		/// </summary>
		public double VtcpX2Thsd { get; }

		/// <summary>
		/// Value of variable VTCP_Z2_THSD
		/// </summary>
		public double VtcpZ2Thsd { get; }

		/// <summary>
		/// Value of variable TAGT_X2_THSD
		/// </summary>
		public double TagtX2Thsd { get; }

		/// <summary>
		/// Value of variable TAGT_Z2_THSD
		/// </summary>
		public double TagtZ2Thsd { get; }

		/// <summary>
		/// Value of variable DEVICE
		/// </summary>
		public int Device { get; }

		/// <summary>
		/// Value of variable FILE_NAME
		/// </summary>
		public string FileName { get; }

		/// <summary>
		/// Value of variable LOG_PORT
		/// </summary>
		public int LogPort { get; }

		/// <summary>
		/// Value of variable AAVM_STEP
		/// </summary>
		public int AavmStep { get; }

		/// <summary>
		/// Value of variable MAST_COUN0
		/// </summary>
		public int[] MastCoun0 { get; }

		/// <summary>
		/// Value of variable MAST_COUN0_2
		/// </summary>
		public int[] MastCoun02 { get; }

		/// <summary>
		/// Value of variable EXT_MCT0
		/// </summary>
		public int[] ExtMct0 { get; }

		/// <summary>
		/// Value of variable JPOS_DATA
		/// </summary>
		public double[,] JposData { get; }

		/// <summary>
		/// Value of variable VTCP
		/// </summary>
		public CartesianPositionVariable Vtcp { get; }

		/// <summary>
		/// Value of variable VTCP0
		/// </summary>
		public CartesianPositionVariable Vtcp0 { get; }

		/// <summary>
		/// Value of variable TARGET
		/// </summary>
		public CartesianPositionVariable Target { get; }

		/// <summary>
		/// Value of variable TARGET0
		/// </summary>
		public CartesianPositionVariable Target0 { get; }

		/// <summary>
		/// Value of variable CMP_JPOS
		/// </summary>
		public double[] CmpJpos { get; }

		/// <summary>
		/// Value of variable MAST_AXIS
		/// </summary>
		public double[] MastAxis { get; }

		/// <summary>
		/// Value of variable TMP_AXIS
		/// </summary>
		public double[] TmpAxis { get; }

		/// <summary>
		/// Value of variable ER_VTCPX
		/// </summary>
		public double ErVtcpx { get; }

		/// <summary>
		/// Value of variable ER_VTCPZ
		/// </summary>
		public double ErVtcpz { get; }

		/// <summary>
		/// Value of variable ER_TARGTX
		/// </summary>
		public double ErTargtx { get; }

		/// <summary>
		/// Value of variable ER_TARGTY
		/// </summary>
		public double ErTargty { get; }

		/// <summary>
		/// Value of variable ER_TARGTZ
		/// </summary>
		public double ErTargtz { get; }

		/// <summary>
		/// Value of variable ER_VTCPX1
		/// </summary>
		public double ErVtcpx1 { get; }

		/// <summary>
		/// Value of variable ER_VTCPZ1
		/// </summary>
		public double ErVtcpz1 { get; }

		/// <summary>
		/// Value of variable ER_TARGTX1
		/// </summary>
		public double ErTargtx1 { get; }

		/// <summary>
		/// Value of variable ER_TARGTZ1
		/// </summary>
		public double ErTargtz1 { get; }

		/// <summary>
		/// Value of variable ER_VTCPX2
		/// </summary>
		public double ErVtcpx2 { get; }

		/// <summary>
		/// Value of variable ER_VTCPZ2
		/// </summary>
		public double ErVtcpz2 { get; }

		/// <summary>
		/// Value of variable ER_TARGTX2
		/// </summary>
		public double ErTargtx2 { get; }

		/// <summary>
		/// Value of variable ER_TARGTZ2
		/// </summary>
		public double ErTargtz2 { get; }

		/// <summary>
		/// Value of variable MEAS_POSE
		/// </summary>
		public CartesianPositionVariable[] MeasPose { get; }

		/// <summary>
		/// Value of variable DUAL_NUM
		/// </summary>
		public int DualNum { get; }

		/// <summary>
		/// Value of variable S_AXIS_NUM
		/// </summary>
		public int SAxisNum { get; }

		/// <summary>
		/// Value of variable TPP_RUN
		/// </summary>
		public bool TppRun { get; }

		/// <summary>
		/// Value of variable STEP_SU1
		/// </summary>
		public int StepSu1 { get; }

		/// <summary>
		/// Value of variable STEP_SU2
		/// </summary>
		public int StepSu2 { get; }

		/// <summary>
		/// Value of variable STEP_SU3
		/// </summary>
		public int StepSu3 { get; }

		/// <summary>
		/// Value of variable STEP_SU4
		/// </summary>
		public int StepSu4 { get; }

		/// <summary>
		/// Value of variable MIN_NUM_DOTS
		/// </summary>
		public int MinNumDots { get; }

		/// <summary>
		/// Value of variable PIX_SIZE_LOW
		/// </summary>
		public double PixSizeLow { get; }

		/// <summary>
		/// Value of variable PIX_SIZ_HIGH
		/// </summary>
		public double PixSizHigh { get; }

		/// <summary>
		/// Value of variable ASPECT_LOW
		/// </summary>
		public double AspectLow { get; }

		/// <summary>
		/// Value of variable IS_AUTOEXPO
		/// </summary>
		public bool IsAutoexpo { get; }

		/// <summary>
		/// Value of variable AE_CONT_LOW
		/// </summary>
		public int AeContLow { get; }

		/// <summary>
		/// Value of variable AE_CONT_AVE
		/// </summary>
		public int AeContAve { get; }

		/// <summary>
		/// Value of variable AE_NUM_RETRY
		/// </summary>
		public int AeNumRetry { get; }

		/// <summary>
		/// Value of variable AE_RADI_RATIO
		/// </summary>
		public double AeRadiRatio { get; }
	}
}
