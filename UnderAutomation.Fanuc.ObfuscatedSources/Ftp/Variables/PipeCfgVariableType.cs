//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PIPE_CFG_T
	/// </summary>
	public class PipeCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SECTORS
		/// </summary>
		public int Sectors { get; }

		/// <summary>
		/// Value of variable $FORMATTER
		/// </summary>
		public int Formatter { get; }

		/// <summary>
		/// Value of variable $RECORDSIZE
		/// </summary>
		public short Recordsize { get; }

		/// <summary>
		/// Value of variable $MEMTYPE
		/// </summary>
		public byte Memtype { get; }

		/// <summary>
		/// Value of variable $FORMAT
		/// </summary>
		public byte Format { get; }

		/// <summary>
		/// Value of variable $AUXWORD
		/// </summary>
		public int Auxword { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
