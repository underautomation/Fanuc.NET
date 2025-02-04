//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type REDPROT_CFG_
	/// </summary>
	public class RedprotCfgVariableType : GenericVariableType, IGenericVariableType {


		public RedprotCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public int CompSw { get; }

		/// <summary>
		/// Value of variable $LVL2_PCT
		/// </summary>
		public double Lvl2Pct { get; }

		/// <summary>
		/// Value of variable $LVL2_SEV
		/// </summary>
		public int Lvl2Sev { get; }

		/// <summary>
		/// Value of variable $MIN_L10_CAP
		/// </summary>
		public double MinL10Cap { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
