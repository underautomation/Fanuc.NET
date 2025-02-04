//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FDR_GRP_T
	/// </summary>
	public class FdrGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $VEL_MOD
		/// </summary>
		public int[] VelMod { get; }

		/// <summary>
		/// Value of variable $VEL_CNT
		/// </summary>
		public int[] VelCnt { get; }

		/// <summary>
		/// Value of variable $REM_LIFE2
		/// </summary>
		public double[] RemLife2 { get; }

		/// <summary>
		/// Value of variable $OVM_RATE
		/// </summary>
		public double[] OvmRate { get; }

		/// <summary>
		/// Value of variable $OVA_RATE
		/// </summary>
		public double[] OvaRate { get; }

		/// <summary>
		/// Value of variable $TROV_RATE
		/// </summary>
		public double[] TrovRate { get; }

		/// <summary>
		/// Value of variable $DTAV_RATE
		/// </summary>
		public double[] DtavRate { get; }

		/// <summary>
		/// Value of variable $DTMX_RATE
		/// </summary>
		public double[] DtmxRate { get; }

		/// <summary>
		/// Value of variable $DTMIN_RATE
		/// </summary>
		public double[] DtminRate { get; }

		/// <summary>
		/// Value of variable $MOT_RATE
		/// </summary>
		public double[] MotRate { get; }

		/// <summary>
		/// Value of variable $DIAG_INDX_R
		/// </summary>
		public double[] DiagIndxR { get; }

		/// <summary>
		/// Value of variable $DIAG_INDX_I
		/// </summary>
		public int[] DiagIndxI { get; }

		/// <summary>
		/// Value of variable $DG_MAXT
		/// </summary>
		public double[] DgMaxt { get; }

		/// <summary>
		/// Value of variable $DG_T0
		/// </summary>
		public double[] DgT0 { get; }

		/// <summary>
		/// Value of variable $RATED_TRQ
		/// </summary>
		public double[] RatedTrq { get; }

		/// <summary>
		/// Value of variable $DRIVE_TYPE
		/// </summary>
		public double[] DriveType { get; }

		/// <summary>
		/// Value of variable $GEAR_RATIO2
		/// </summary>
		public double[] GearRatio2 { get; }

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
		/// Value of variable $Z_MCMD
		/// </summary>
		public int[] ZMcmd { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
