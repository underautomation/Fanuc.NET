//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type IOSLAVE_T
	/// </summary>
	public class IoslaveVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $INPUT_N
		/// </summary>
		public short InputN { get; }

		/// <summary>
		/// Value of variable $OUTPUT_N
		/// </summary>
		public short OutputN { get; }

		/// <summary>
		/// Value of variable $INPUT_N2
		/// </summary>
		public short InputN2 { get; }

		/// <summary>
		/// Value of variable $OUTPUT_N2
		/// </summary>
		public short OutputN2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
