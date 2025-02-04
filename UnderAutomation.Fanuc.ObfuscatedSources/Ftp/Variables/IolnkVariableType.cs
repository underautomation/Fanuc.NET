//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type IOLNK_T
	/// </summary>
	public class IolnkVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $RACK
		/// </summary>
		public byte Rack { get; }

		/// <summary>
		/// Value of variable $SLOT
		/// </summary>
		public byte Slot { get; }

		/// <summary>
		/// Value of variable $INPUT_N
		/// </summary>
		public short InputN { get; }

		/// <summary>
		/// Value of variable $OUTPUT_N
		/// </summary>
		public short OutputN { get; }

		/// <summary>
		/// Value of variable $OPTION
		/// </summary>
		public short Option { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
