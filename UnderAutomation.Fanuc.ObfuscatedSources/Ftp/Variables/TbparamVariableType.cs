//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBPARAM_T
	/// </summary>
	public class TbparamVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MR_MAX_TRQ
		/// </summary>
		public double MrMaxTrq { get; }

		/// <summary>
		/// Value of variable $MR_STAL_TRQ
		/// </summary>
		public double MrStalTrq { get; }

		/// <summary>
		/// Value of variable $MR_BRK_TRQ
		/// </summary>
		public double MrBrkTrq { get; }

		/// <summary>
		/// Value of variable $MR_BRK_VEL
		/// </summary>
		public double MrBrkVel { get; }

		/// <summary>
		/// Value of variable $MR_NOLD_VEL
		/// </summary>
		public double MrNoldVel { get; }

		/// <summary>
		/// Value of variable $MA_LOAD_TRQ
		/// </summary>
		public double MaLoadTrq { get; }

		/// <summary>
		/// Value of variable $MD_LOAD_TRQ
		/// </summary>
		public double MdLoadTrq { get; }

		/// <summary>
		/// Value of variable $MAX_TRQ_MGN
		/// </summary>
		public double MaxTrqMgn { get; }

		/// <summary>
		/// Value of variable $MA_GRAV_MGN
		/// </summary>
		public double MaGravMgn { get; }

		/// <summary>
		/// Value of variable $MA_STAL_MGN
		/// </summary>
		public double MaStalMgn { get; }

		/// <summary>
		/// Value of variable $MA_BRK_MGN
		/// </summary>
		public double MaBrkMgn { get; }

		/// <summary>
		/// Value of variable $MA_NOLD_MGN
		/// </summary>
		public double MaNoldMgn { get; }

		/// <summary>
		/// Value of variable $MD_GRAV_MGN
		/// </summary>
		public double MdGravMgn { get; }

		/// <summary>
		/// Value of variable $MD_STAL_MGN
		/// </summary>
		public double MdStalMgn { get; }

		/// <summary>
		/// Value of variable $MD_BRK_MGN
		/// </summary>
		public double MdBrkMgn { get; }

		/// <summary>
		/// Value of variable $MD_NOLD_MGN
		/// </summary>
		public double MdNoldMgn { get; }

		/// <summary>
		/// Value of variable $PTH_GRV_MGN
		/// </summary>
		public double PthGrvMgn { get; }

		/// <summary>
		/// Value of variable $PTH_STL_MGN
		/// </summary>
		public double PthStlMgn { get; }

		/// <summary>
		/// Value of variable $PTH_BRK_MGN
		/// </summary>
		public double PthBrkMgn { get; }

		/// <summary>
		/// Value of variable $PTH_NLD_MGN
		/// </summary>
		public double PthNldMgn { get; }

		/// <summary>
		/// Value of variable $DYN_FRC_MGN
		/// </summary>
		public double DynFrcMgn { get; }

		/// <summary>
		/// Value of variable $MR_NOLD_TRQ
		/// </summary>
		public double MrNoldTrq { get; }

		/// <summary>
		/// Value of variable $R_ACC_MGN
		/// </summary>
		public double RAccMgn { get; }

		/// <summary>
		/// Value of variable $R_DEC_MGN
		/// </summary>
		public double RDecMgn { get; }

		/// <summary>
		/// Value of variable $R_LONG_MGN
		/// </summary>
		public double RLongMgn { get; }

		/// <summary>
		/// Value of variable $J_ACC
		/// </summary>
		public double JAcc { get; }

		/// <summary>
		/// Value of variable $J_DEC
		/// </summary>
		public double JDec { get; }

		/// <summary>
		/// Value of variable $DT_MGN
		/// </summary>
		public double DtMgn { get; }

		/// <summary>
		/// Value of variable $SP1
		/// </summary>
		public double Sp1 { get; }

		/// <summary>
		/// Value of variable $SP2
		/// </summary>
		public double Sp2 { get; }

		/// <summary>
		/// Value of variable $SP3
		/// </summary>
		public double Sp3 { get; }

		/// <summary>
		/// Value of variable $SP4
		/// </summary>
		public double Sp4 { get; }

		/// <summary>
		/// Value of variable $SP5
		/// </summary>
		public double Sp5 { get; }

		/// <summary>
		/// Value of variable $SP6
		/// </summary>
		public double Sp6 { get; }

		/// <summary>
		/// Value of variable $SP7
		/// </summary>
		public double Sp7 { get; }

		/// <summary>
		/// Value of variable $SP8
		/// </summary>
		public double Sp8 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
