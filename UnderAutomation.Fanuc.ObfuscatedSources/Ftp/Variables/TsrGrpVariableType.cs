//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TSR_GRP_T
	/// </summary>
	public class TsrGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MR_MAX_TRQ
		/// </summary>
		public double[] MrMaxTrq { get; }

		/// <summary>
		/// Value of variable $MR_STAL_TRQ
		/// </summary>
		public double[] MrStalTrq { get; }

		/// <summary>
		/// Value of variable $MR_BRK_TRQ
		/// </summary>
		public double[] MrBrkTrq { get; }

		/// <summary>
		/// Value of variable $MR_BRK_VEL
		/// </summary>
		public double[] MrBrkVel { get; }

		/// <summary>
		/// Value of variable $MR_NOLD_VEL
		/// </summary>
		public double[] MrNoldVel { get; }

		/// <summary>
		/// Value of variable $MA_LOAD_TRQ
		/// </summary>
		public double[] MaLoadTrq { get; }

		/// <summary>
		/// Value of variable $MD_LOAD_TRQ
		/// </summary>
		public double[] MdLoadTrq { get; }

		/// <summary>
		/// Value of variable $MA_GRAV_MGN
		/// </summary>
		public double[] MaGravMgn { get; }

		/// <summary>
		/// Value of variable $MA_STAL_MGN
		/// </summary>
		public double[] MaStalMgn { get; }

		/// <summary>
		/// Value of variable $MA_BRK_MGN
		/// </summary>
		public double[] MaBrkMgn { get; }

		/// <summary>
		/// Value of variable $MD_GRAV_MGN
		/// </summary>
		public double[] MdGravMgn { get; }

		/// <summary>
		/// Value of variable $MD_STAL_MGN
		/// </summary>
		public double[] MdStalMgn { get; }

		/// <summary>
		/// Value of variable $MD_BRK_MGN
		/// </summary>
		public double[] MdBrkMgn { get; }

		/// <summary>
		/// Value of variable $MJ_ACC_MGN
		/// </summary>
		public double[] MjAccMgn { get; }

		/// <summary>
		/// Value of variable $MC_ACC_MGN
		/// </summary>
		public double[] McAccMgn { get; }

		/// <summary>
		/// Value of variable $MC_STAL_MGN
		/// </summary>
		public double[] McStalMgn { get; }

		/// <summary>
		/// Value of variable $MC_BRK_MGN
		/// </summary>
		public double[] McBrkMgn { get; }

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
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
