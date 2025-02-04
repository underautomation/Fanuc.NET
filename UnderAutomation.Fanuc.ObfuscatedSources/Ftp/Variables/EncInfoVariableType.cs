//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ENC_INFO_T
	/// </summary>
	public class EncInfoVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SVON_TIME
		/// </summary>
		public short SvonTime { get; }

		/// <summary>
		/// Value of variable $DUMMY1
		/// </summary>
		public byte Dummy1 { get; }

		/// <summary>
		/// Value of variable $DUMMY2
		/// </summary>
		public byte Dummy2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
