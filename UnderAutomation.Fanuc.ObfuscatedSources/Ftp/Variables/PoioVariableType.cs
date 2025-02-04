//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type POIO_T
	/// </summary>
	public class PoioVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SLEQ_NUM
		/// </summary>
		public int SleqNum { get; }

		/// <summary>
		/// Value of variable $IO_TYPE
		/// </summary>
		public int IoType { get; }

		/// <summary>
		/// Value of variable $IO_INDEX
		/// </summary>
		public int IoIndex { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
