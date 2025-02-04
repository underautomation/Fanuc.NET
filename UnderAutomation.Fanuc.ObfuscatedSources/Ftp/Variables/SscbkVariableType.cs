//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SSCBK_T
	/// </summary>
	public class SscbkVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $FROMMX
		/// </summary>
		public int Frommx { get; }

		/// <summary>
		/// Value of variable $CMOSMX
		/// </summary>
		public int Cmosmx { get; }

		/// <summary>
		/// Value of variable $STARTMD
		/// </summary>
		public byte Startmd { get; }

		/// <summary>
		/// Value of variable $CLFLAG
		/// </summary>
		public byte Clflag { get; }

		/// <summary>
		/// Value of variable $SMDX
		/// </summary>
		public byte Smdx { get; }

		/// <summary>
		/// Value of variable $HERR
		/// </summary>
		public byte Herr { get; }

		/// <summary>
		/// Value of variable $IFPOINT
		/// </summary>
		public int Ifpoint { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
