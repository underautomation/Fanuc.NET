//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PROTOENT_T
	/// </summary>
	public class ProtoentVariableType : GenericVariableType, IGenericVariableType {


		public ProtoentVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $P_NAME
		/// </summary>
		public string PName { get; }

		/// <summary>
		/// Value of variable $P_PROTO
		/// </summary>
		public int PProto { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
