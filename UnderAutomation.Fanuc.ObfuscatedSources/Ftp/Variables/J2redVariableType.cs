//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type J2RED_T
	/// </summary>
	public class J2redVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $EXD_RTQ
		/// </summary>
		public double ExdRtq { get; }

		/// <summary>
		/// Value of variable $EXD_ITP
		/// </summary>
		public int ExdItp { get; }

		/// <summary>
		/// Value of variable $EXD_PRG
		/// </summary>
		public short ExdPrg { get; }

		/// <summary>
		/// Value of variable $EXD_LINE
		/// </summary>
		public short ExdLine { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
