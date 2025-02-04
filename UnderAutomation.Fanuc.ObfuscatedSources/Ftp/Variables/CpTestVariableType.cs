//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $CP_TEST
	/// </summary>
	public class CpTestVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE_TEST
		/// </summary>
		public bool EnableTest { get; }

		/// <summary>
		/// Value of variable $NUM_LINES
		/// </summary>
		public int NumLines { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
