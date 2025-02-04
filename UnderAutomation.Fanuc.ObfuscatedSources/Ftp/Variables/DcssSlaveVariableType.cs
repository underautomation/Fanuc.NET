//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCSS_SLAVE_T
	/// </summary>
	public class DcssSlaveVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $INPUT_BYTE
		/// </summary>
		public int InputByte { get; }

		/// <summary>
		/// Value of variable $OUTPUT_BYTE
		/// </summary>
		public int OutputByte { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
