//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CP_MCRGRP_T
	/// </summary>
	public class CpMcrgrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $RSM_JBF_PCT
		/// </summary>
		public int RsmJbfPct { get; }

		/// <summary>
		/// Value of variable $RSM_DEC_PCT
		/// </summary>
		public int RsmDecPct { get; }

		/// <summary>
		/// Value of variable $RSM_OFS_PCT
		/// </summary>
		public int RsmOfsPct { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
