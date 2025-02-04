//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ALM_IF_T
	/// </summary>
	public class AlmIfVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $LAST_ALM
		/// </summary>
		public string LastAlm { get; }

		/// <summary>
		/// Value of variable $LAST_UALM
		/// </summary>
		public string LastUalm { get; }

		/// <summary>
		/// Value of variable $KALM_MAX
		/// </summary>
		public int KalmMax { get; }

		/// <summary>
		/// Value of variable $LDEBUG
		/// </summary>
		public int[] Ldebug { get; }

		/// <summary>
		/// Value of variable $PROG_STAT
		/// </summary>
		public string ProgStat { get; }

		/// <summary>
		/// Value of variable $CURR_PROG
		/// </summary>
		public string CurrProg { get; }

		/// <summary>
		/// Value of variable $CURR_LINE
		/// </summary>
		public int CurrLine { get; }

		/// <summary>
		/// Value of variable $CURR_STAT
		/// </summary>
		public string CurrStat { get; }

		/// <summary>
		/// Value of variable $LAST_CAUSE
		/// </summary>
		public string LastCause { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
