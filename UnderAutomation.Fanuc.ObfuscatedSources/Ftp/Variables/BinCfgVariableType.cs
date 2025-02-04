//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type BIN_CFG_T
	/// </summary>
	public class BinCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENTRIES
		/// </summary>
		public int Entries { get; }

		/// <summary>
		/// Value of variable $Q0FP
		/// </summary>
		public int Q0fp { get; }

		/// <summary>
		/// Value of variable $Q0NP
		/// </summary>
		public int Q0np { get; }

		/// <summary>
		/// Value of variable $Q1FP
		/// </summary>
		public int Q1fp { get; }

		/// <summary>
		/// Value of variable $Q1NP
		/// </summary>
		public int Q1np { get; }

		/// <summary>
		/// Value of variable $Q2FP
		/// </summary>
		public int Q2fp { get; }

		/// <summary>
		/// Value of variable $Q2NP
		/// </summary>
		public int Q2np { get; }

		/// <summary>
		/// Value of variable $PPPP
		/// </summary>
		public int Pppp { get; }

		/// <summary>
		/// Value of variable $CNETP
		/// </summary>
		public int Cnetp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
