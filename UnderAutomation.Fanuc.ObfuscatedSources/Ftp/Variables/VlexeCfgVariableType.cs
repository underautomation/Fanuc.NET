//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VLEXE_CFG_T
	/// </summary>
	public class VlexeCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Value of variable $DATE
		/// </summary>
		public int Date { get; }

		/// <summary>
		/// Value of variable $FLDR_INDEX
		/// </summary>
		public int FldrIndex { get; }

		/// <summary>
		/// Value of variable $FILE_INDEX
		/// </summary>
		public int FileIndex { get; }

		/// <summary>
		/// Value of variable $REC_INDEX
		/// </summary>
		public int RecIndex { get; }

		/// <summary>
		/// Value of variable $OUTPUT_IDX
		/// </summary>
		public bool OutputIdx { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
