//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBC_GRP_T
	/// </summary>
	public class TbcGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TBC_ACCEL1
		/// </summary>
		public short TbcAccel1 { get; }

		/// <summary>
		/// Value of variable $TBC_ACCEL2
		/// </summary>
		public short TbcAccel2 { get; }

		/// <summary>
		/// Value of variable $TBC_PATH1
		/// </summary>
		public short TbcPath1 { get; }

		/// <summary>
		/// Value of variable $TBC_PATH2
		/// </summary>
		public short TbcPath2 { get; }

		/// <summary>
		/// Value of variable $PATH_RATIO
		/// </summary>
		public double PathRatio { get; }

		/// <summary>
		/// Value of variable $TBC_PARAM
		/// </summary>
		public TbcparamVariableType[] TbcParam { get; }

		/// <summary>
		/// Value of variable $CNT_SCALE
		/// </summary>
		public double CntScale { get; }

		/// <summary>
		/// Value of variable $SHORTMO_SCL
		/// </summary>
		public double ShortmoScl { get; }

		/// <summary>
		/// Value of variable $MIN_ACC_UCA
		/// </summary>
		public int MinAccUca { get; }

		/// <summary>
		/// Value of variable $MIN_CAT_UMA
		/// </summary>
		public int MinCatUma { get; }

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
		/// Value of variable $J2L_UPR_ANG
		/// </summary>
		public double J2lUprAng { get; }

		/// <summary>
		/// Value of variable $J2L_LWR_ANG
		/// </summary>
		public double J2lLwrAng { get; }

		/// <summary>
		/// Value of variable $J2L_UPR_MGN
		/// </summary>
		public double J2lUprMgn { get; }

		/// <summary>
		/// Value of variable $J2L_LWR_MGN
		/// </summary>
		public double J2lLwrMgn { get; }

		/// <summary>
		/// Value of variable $R_F2LSHRT
		/// </summary>
		public double RF2lshrt { get; }

		/// <summary>
		/// Value of variable $R_F2LLONG
		/// </summary>
		public double RF2llong { get; }

		/// <summary>
		/// Value of variable $MIN_F2LSHRT
		/// </summary>
		public int MinF2lshrt { get; }

		/// <summary>
		/// Value of variable $MIN_F2LLONG
		/// </summary>
		public int MinF2llong { get; }

		/// <summary>
		/// Value of variable $MIN_ACRL_S
		/// </summary>
		public double MinAcrlS { get; }

		/// <summary>
		/// Value of variable $MIN_ACRL_L
		/// </summary>
		public double MinAcrlL { get; }

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
		/// Value of variable $FLEXL
		/// </summary>
		public double[] Flexl { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
