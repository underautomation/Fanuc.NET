//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBCPARAM_T
	/// </summary>
	public class TbcparamVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MC_MAX_TRQ
		/// </summary>
		public double McMaxTrq { get; }

		/// <summary>
		/// Value of variable $MAX_TRQ_MGN
		/// </summary>
		public double MaxTrqMgn { get; }

		/// <summary>
		/// Value of variable $MC_GRAV_MGN
		/// </summary>
		public double McGravMgn { get; }

		/// <summary>
		/// Value of variable $MC_STAL_MGN
		/// </summary>
		public double McStalMgn { get; }

		/// <summary>
		/// Value of variable $MC_BRK_MGN
		/// </summary>
		public double McBrkMgn { get; }

		/// <summary>
		/// Value of variable $MC_NOLD_MGN
		/// </summary>
		public double McNoldMgn { get; }

		/// <summary>
		/// Value of variable $SHORTMO_LIM
		/// </summary>
		public double ShortmoLim { get; }

		/// <summary>
		/// Value of variable $SHORTMO_MGN
		/// </summary>
		public double ShortmoMgn { get; }

		/// <summary>
		/// Value of variable $MC_NOLD_TRQ
		/// </summary>
		public double McNoldTrq { get; }

		/// <summary>
		/// Value of variable $J_LIN
		/// </summary>
		public double JLin { get; }

		/// <summary>
		/// Value of variable $SPL1
		/// </summary>
		public double Spl1 { get; }

		/// <summary>
		/// Value of variable $SPL2
		/// </summary>
		public double Spl2 { get; }

		/// <summary>
		/// Value of variable $SPL3
		/// </summary>
		public double Spl3 { get; }

		/// <summary>
		/// Value of variable $SPL4
		/// </summary>
		public double Spl4 { get; }

		/// <summary>
		/// Value of variable $SPL5
		/// </summary>
		public double Spl5 { get; }

		/// <summary>
		/// Value of variable $SPL6
		/// </summary>
		public double Spl6 { get; }

		/// <summary>
		/// Value of variable $SPL7
		/// </summary>
		public double Spl7 { get; }

		/// <summary>
		/// Value of variable $SPL8
		/// </summary>
		public double Spl8 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
