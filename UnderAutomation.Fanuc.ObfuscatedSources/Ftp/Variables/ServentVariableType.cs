//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SERVENT_T
	/// </summary>
	public class ServentVariableType : GenericVariableType, IGenericVariableType {


		public ServentVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $S_NAME
		/// </summary>
		public string SName { get; }

		/// <summary>
		/// Value of variable $S_PORT
		/// </summary>
		public int SPort { get; }

		/// <summary>
		/// Value of variable $S_PROTO
		/// </summary>
		public string SProto { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
