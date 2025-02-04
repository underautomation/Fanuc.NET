//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBJ_GRP_T
	/// </summary>
	public class TbjGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TBJ_ACCEL1
		/// </summary>
		public short[] TbjAccel1 { get; }

		/// <summary>
		/// Value of variable $TBJ_ACCEL2
		/// </summary>
		public short[] TbjAccel2 { get; }

		/// <summary>
		/// Value of variable $ASYM_PARAM
		/// </summary>
		public double[] AsymParam { get; }

		/// <summary>
		/// Value of variable $TB_PARAM
		/// </summary>
		public TbparamVariableType[] TbParam { get; }

		/// <summary>
		/// Value of variable $SHORTMO_SCL
		/// </summary>
		public double ShortmoScl { get; }

		/// <summary>
		/// Value of variable $LONGMO_SCL
		/// </summary>
		public double LongmoScl { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_SHM
		/// </summary>
		public int MinAccShm { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_UMA
		/// </summary>
		public int MinAccUma { get; }

		/// <summary>
		/// Value of variable $SHORTMO_MGN
		/// </summary>
		public double ShortmoMgn { get; }

		/// <summary>
		/// Value of variable $LONGMO_MGN
		/// </summary>
		public double LongmoMgn { get; }

		/// <summary>
		/// Value of variable $MIN_CYC_ID
		/// </summary>
		public string MinCycId { get; }

		/// <summary>
		/// Value of variable $MIN_C_ID_E1
		/// </summary>
		public string MinCIdE1 { get; }

		/// <summary>
		/// Value of variable $MIN_C_ID_E2
		/// </summary>
		public string MinCIdE2 { get; }

		/// <summary>
		/// Value of variable $MIN_C_ID_E3
		/// </summary>
		public string MinCIdE3 { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_MGN
		/// </summary>
		public double PayloadMgn { get; }

		/// <summary>
		/// Value of variable $J2J_UPR_ANG
		/// </summary>
		public double J2jUprAng { get; }

		/// <summary>
		/// Value of variable $J2J_LWR_ANG
		/// </summary>
		public double J2jLwrAng { get; }

		/// <summary>
		/// Value of variable $J2J_UPR_MGN
		/// </summary>
		public double J2jUprMgn { get; }

		/// <summary>
		/// Value of variable $J2J_LWR_MGN
		/// </summary>
		public double J2jLwrMgn { get; }

		/// <summary>
		/// Value of variable $INERTIA_VIB
		/// </summary>
		public double[] InertiaVib { get; }

		/// <summary>
		/// Value of variable $INERTIA_VI2
		/// </summary>
		public double[] InertiaVi2 { get; }

		/// <summary>
		/// Value of variable $IV_UNIT
		/// </summary>
		public double IvUnit { get; }

		/// <summary>
		/// Value of variable $IV_UNIT2
		/// </summary>
		public double IvUnit2 { get; }

		/// <summary>
		/// Value of variable $R_F2JACC
		/// </summary>
		public double RF2jacc { get; }

		/// <summary>
		/// Value of variable $R_F2JDEC
		/// </summary>
		public double RF2jdec { get; }

		/// <summary>
		/// Value of variable $R_F2JLONG
		/// </summary>
		public double RF2jlong { get; }

		/// <summary>
		/// Value of variable $MIN_F2JACC
		/// </summary>
		public int MinF2jacc { get; }

		/// <summary>
		/// Value of variable $MIN_F2JDEC
		/// </summary>
		public int MinF2jdec { get; }

		/// <summary>
		/// Value of variable $MIN_F2JLONG
		/// </summary>
		public int MinF2jlong { get; }

		/// <summary>
		/// Value of variable $MIN_ACRJ_S
		/// </summary>
		public double MinAcrjS { get; }

		/// <summary>
		/// Value of variable $MIN_ACRJ_L
		/// </summary>
		public double MinAcrjL { get; }

		/// <summary>
		/// Value of variable $MIN_PAYLOAD
		/// </summary>
		public double MinPayload { get; }

		/// <summary>
		/// Value of variable $HVAL
		/// </summary>
		public double[] Hval { get; }

		/// <summary>
		/// Value of variable $HMGN
		/// </summary>
		public double[] Hmgn { get; }

		/// <summary>
		/// Value of variable $HAXS
		/// </summary>
		public short[] Haxs { get; }

		/// <summary>
		/// Value of variable $FLEX
		/// </summary>
		public double[] Flex { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
