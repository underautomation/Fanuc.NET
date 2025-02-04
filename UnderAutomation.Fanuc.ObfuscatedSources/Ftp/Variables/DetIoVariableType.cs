//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DET_IO_T
	/// </summary>
	public class DetIoVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $IO_TYPE
		/// </summary>
		public int IoType { get; }

		/// <summary>
		/// Value of variable $IO_PORT
		/// </summary>
		public int IoPort { get; }

		/// <summary>
		/// Value of variable $STYLE
		/// </summary>
		public int Style { get; }

		/// <summary>
		/// Value of variable $LIMIT
		/// </summary>
		public int Limit { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
