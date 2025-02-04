//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AAVM_GRP_T
	/// </summary>
	public class AavmGrpVariableType : GenericVariableType, IGenericVariableType {


		public AavmGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Value of variable $METHOD_SEL
		/// </summary>
		public int MethodSel { get; }

		/// <summary>
		/// Value of variable $FOCAL_DIST
		/// </summary>
		public double FocalDist { get; }

		/// <summary>
		/// Value of variable $GD_SPACING
		/// </summary>
		public double GdSpacing { get; }

		/// <summary>
		/// Value of variable $OFFSET_P
		/// </summary>
		public double OffsetP { get; }

		/// <summary>
		/// Value of variable $VTCP_DES
		/// </summary>
		public double[] VtcpDes { get; }

		/// <summary>
		/// Value of variable $PSSHFENB
		/// </summary>
		public bool Psshfenb { get; }

		/// <summary>
		/// Value of variable $PS_SHIFT
		/// </summary>
		public double[] PsShift { get; }

		/// <summary>
		/// Value of variable $PS_SHIFTJ
		/// </summary>
		public double PsShiftj { get; }

		/// <summary>
		/// Value of variable $TAGT_DES
		/// </summary>
		public double[] TagtDes { get; }

		/// <summary>
		/// Value of variable $TAGT_DES2
		/// </summary>
		public double[] TagtDes2 { get; }

		/// <summary>
		/// Value of variable $MAST_AXIS
		/// </summary>
		public double[] MastAxis { get; }

		/// <summary>
		/// Value of variable $MAST_AXIS2
		/// </summary>
		public double[] MastAxis2 { get; }

		/// <summary>
		/// Value of variable $VFB_MAT
		/// </summary>
		public double[] VfbMat { get; }

		/// <summary>
		/// Value of variable $NUM_POS
		/// </summary>
		public int NumPos { get; }

		/// <summary>
		/// Value of variable $NUM_POS2
		/// </summary>
		public int NumPos2 { get; }

		/// <summary>
		/// Value of variable $MST_POS_X
		/// </summary>
		public double[] MstPosX { get; }

		/// <summary>
		/// Value of variable $MST_POS_Y
		/// </summary>
		public double[] MstPosY { get; }

		/// <summary>
		/// Value of variable $MST_POS_Z
		/// </summary>
		public double[] MstPosZ { get; }

		/// <summary>
		/// Value of variable $MST_POS_W
		/// </summary>
		public double[] MstPosW { get; }

		/// <summary>
		/// Value of variable $MST_POS_P
		/// </summary>
		public double[] MstPosP { get; }

		/// <summary>
		/// Value of variable $MST_POS_R
		/// </summary>
		public double[] MstPosR { get; }

		/// <summary>
		/// Value of variable $LIM_RES_ER
		/// </summary>
		public double LimResEr { get; }

		/// <summary>
		/// Value of variable $LIM_VTCP_X
		/// </summary>
		public double LimVtcpX { get; }

		/// <summary>
		/// Value of variable $LIM_VTCP_Z
		/// </summary>
		public double LimVtcpZ { get; }

		/// <summary>
		/// Value of variable $LIM_TAGT_X
		/// </summary>
		public double LimTagtX { get; }

		/// <summary>
		/// Value of variable $LIM_TAGT_Z
		/// </summary>
		public double LimTagtZ { get; }

		/// <summary>
		/// Value of variable $VS_SPEED
		/// </summary>
		public double VsSpeed { get; }

		/// <summary>
		/// Value of variable $MAX_RDELAY
		/// </summary>
		public int MaxRdelay { get; }

		/// <summary>
		/// Value of variable $VFA_TOL_1P
		/// </summary>
		public double VfaTol1p { get; }

		/// <summary>
		/// Value of variable $VFD_TOL
		/// </summary>
		public double VfdTol { get; }

		/// <summary>
		/// Value of variable $VFD_TOL_1P
		/// </summary>
		public double VfdTol1p { get; }

		/// <summary>
		/// Value of variable $BACKLASH
		/// </summary>
		public double Backlash { get; }

		/// <summary>
		/// Value of variable $LIMIT_DX
		/// </summary>
		public double LimitDx { get; }

		/// <summary>
		/// Value of variable $LIMIT_DY
		/// </summary>
		public double LimitDy { get; }

		/// <summary>
		/// Value of variable $LIMIT_DZ
		/// </summary>
		public double LimitDz { get; }

		/// <summary>
		/// Value of variable $LIMIT_DW
		/// </summary>
		public double LimitDw { get; }

		/// <summary>
		/// Value of variable $LIMIT_DP
		/// </summary>
		public double LimitDp { get; }

		/// <summary>
		/// Value of variable $LIMIT_DR
		/// </summary>
		public double LimitDr { get; }

		/// <summary>
		/// Value of variable $TRGVT
		/// </summary>
		public double Trgvt { get; }

		/// <summary>
		/// Value of variable $TRGHZ
		/// </summary>
		public double Trghz { get; }

		/// <summary>
		/// Value of variable $TRGDIST
		/// </summary>
		public double Trgdist { get; }

		/// <summary>
		/// Value of variable $TRGW
		/// </summary>
		public double Trgw { get; }

		/// <summary>
		/// Value of variable $TRGP
		/// </summary>
		public double Trgp { get; }

		/// <summary>
		/// Value of variable $TRGR
		/// </summary>
		public double Trgr { get; }

		/// <summary>
		/// Value of variable $LENS_CENT_X
		/// </summary>
		public double LensCentX { get; }

		/// <summary>
		/// Value of variable $LENS_CENT_Y
		/// </summary>
		public double LensCentY { get; }

		/// <summary>
		/// Value of variable $DISTORT
		/// </summary>
		public double[] Distort { get; }

		/// <summary>
		/// Value of variable $CAMCLBDATE
		/// </summary>
		public string Camclbdate { get; }

		/// <summary>
		/// Value of variable $CAMERA_NAME
		/// </summary>
		public string CameraName { get; }

		/// <summary>
		/// Value of variable $TOOL_TYPE
		/// </summary>
		public int ToolType { get; }

		/// <summary>
		/// Value of variable $CAMERA_TYPE
		/// </summary>
		public int CameraType { get; }

		/// <summary>
		/// Value of variable $EXPOSURE
		/// </summary>
		public int Exposure { get; }

		/// <summary>
		/// Value of variable $NUM_MUL_EXP
		/// </summary>
		public int NumMulExp { get; }

		/// <summary>
		/// Value of variable $NUM_DOVIS
		/// </summary>
		public int NumDovis { get; }

		/// <summary>
		/// Value of variable $CMP_GC_W
		/// </summary>
		public double CmpGcW { get; }

		/// <summary>
		/// Value of variable $CMP_GC_P
		/// </summary>
		public double CmpGcP { get; }

		/// <summary>
		/// Value of variable $USER_ENB
		/// </summary>
		public bool UserEnb { get; }

		/// <summary>
		/// Value of variable $LIM_RES_ER2
		/// </summary>
		public double LimResEr2 { get; }

		/// <summary>
		/// Value of variable $LIM_VTCP_X2
		/// </summary>
		public double LimVtcpX2 { get; }

		/// <summary>
		/// Value of variable $LIM_VTCP_Z2
		/// </summary>
		public double LimVtcpZ2 { get; }

		/// <summary>
		/// Value of variable $PRE_ANG
		/// </summary>
		public double PreAng { get; }

		/// <summary>
		/// Value of variable $PRE_ANG_J7
		/// </summary>
		public double[] PreAngJ7 { get; }

		/// <summary>
		/// Value of variable $MST_POS_J7
		/// </summary>
		public double[] MstPosJ7 { get; }

		/// <summary>
		/// Value of variable $TRIM_RATIO
		/// </summary>
		public double TrimRatio { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
