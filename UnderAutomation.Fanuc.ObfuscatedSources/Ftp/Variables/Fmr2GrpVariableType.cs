//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FMR2_GRP_T
	/// </summary>
	public class Fmr2GrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $VEL_ROT
		/// </summary>
		public double VelRot { get; }

		/// <summary>
		/// Value of variable $VEL_LIN
		/// </summary>
		public double VelLin { get; }

		/// <summary>
		/// Value of variable $VEL_MOD
		/// </summary>
		public int[] VelMod { get; }

		/// <summary>
		/// Value of variable $K_LIFE
		/// </summary>
		public double[] KLife { get; }

		/// <summary>
		/// Value of variable $NTR_LIFE
		/// </summary>
		public double[] NtrLife { get; }

		/// <summary>
		/// Value of variable $EFF_RATE
		/// </summary>
		public double[] EffRate { get; }

		/// <summary>
		/// Value of variable $ROT_INRT
		/// </summary>
		public double[] RotInrt { get; }

		/// <summary>
		/// Value of variable $TROV_MAX
		/// </summary>
		public double[] TrovMax { get; }

		/// <summary>
		/// Value of variable $T_LIFE_0
		/// </summary>
		public double TLife0 { get; }

		/// <summary>
		/// Value of variable $RATED_TRQ
		/// </summary>
		public double[] RatedTrq { get; }

		/// <summary>
		/// Value of variable $LIMIT_FUNC
		/// </summary>
		public int LimitFunc { get; }

		/// <summary>
		/// Value of variable $ACC_LMT
		/// </summary>
		public double[] AccLmt { get; }

		/// <summary>
		/// Value of variable $DRIVE_TYPE
		/// </summary>
		public double[] DriveType { get; }

		/// <summary>
		/// Value of variable $GEAR_RATIO2
		/// </summary>
		public double[] GearRatio2 { get; }

		/// <summary>
		/// Value of variable $DGCLFR
		/// </summary>
		public double[] Dgclfr { get; }

		/// <summary>
		/// Value of variable $DGDYFR
		/// </summary>
		public double[] Dgdyfr { get; }

		/// <summary>
		/// Value of variable $DGLDEC
		/// </summary>
		public double[] Dgldec { get; }

		/// <summary>
		/// Value of variable $DG5T0
		/// </summary>
		public double[] Dg5t0 { get; }

		/// <summary>
		/// Value of variable $DG_MAXT
		/// </summary>
		public double[] DgMaxt { get; }

		/// <summary>
		/// Value of variable $DG_T0
		/// </summary>
		public double[] DgT0 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
