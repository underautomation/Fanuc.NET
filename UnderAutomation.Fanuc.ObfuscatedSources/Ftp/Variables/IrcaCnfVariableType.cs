//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type IRCA_CNF_T
	/// </summary>
	public class IrcaCnfVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $INCYC_MEAS
		/// </summary>
		public int IncycMeas { get; }

		/// <summary>
		/// Value of variable $CYC_CT_MEAS
		/// </summary>
		public int CycCtMeas { get; }

		/// <summary>
		/// Value of variable $CYC_CT_IN_T
		/// </summary>
		public int CycCtInT { get; }

		/// <summary>
		/// Value of variable $CYC_CT_IN_I
		/// </summary>
		public int CycCtInI { get; }

		/// <summary>
		/// Value of variable $REG_INDEX
		/// </summary>
		public int RegIndex { get; }

		/// <summary>
		/// Value of variable $MAX_DAY_HIS
		/// </summary>
		public int MaxDayHis { get; }

		/// <summary>
		/// Value of variable $HIST_INTVAL
		/// </summary>
		public int HistIntval { get; }

		/// <summary>
		/// Value of variable $REP_INTVAL
		/// </summary>
		public int RepIntval { get; }

		/// <summary>
		/// Value of variable $AVE_TIME
		/// </summary>
		public int AveTime { get; }

		/// <summary>
		/// Value of variable $BUFF_INTVAL
		/// </summary>
		public int BuffIntval { get; }

		/// <summary>
		/// Value of variable $SCAN_INTVAL
		/// </summary>
		public int ScanIntval { get; }

		/// <summary>
		/// Value of variable $CLEAR_HIST
		/// </summary>
		public bool ClearHist { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
