//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type REDPROT_GRP_
	/// </summary>
	public class RedprotGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PCT_REM
		/// </summary>
		public double[] PctRem { get; }

		/// <summary>
		/// Value of variable $RST_DATE
		/// </summary>
		public int[] RstDate { get; }

		/// <summary>
		/// Value of variable $RST_REM
		/// </summary>
		public double[] RstRem { get; }

		/// <summary>
		/// Value of variable $RED_RESET
		/// </summary>
		public bool[] RedReset { get; }

		/// <summary>
		/// Value of variable $LAST_PCT
		/// </summary>
		public double[] LastPct { get; }

		/// <summary>
		/// Value of variable $LAST_PROG
		/// </summary>
		public string LastProg { get; }

		/// <summary>
		/// Value of variable $LAST_LVL
		/// </summary>
		public int LastLvl { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
