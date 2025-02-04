//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PING_T
	/// </summary>
	public class PingVariableType : GenericVariableType, IGenericVariableType {


		public PingVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TIMEOUT
		/// </summary>
		public int Timeout { get; }

		/// <summary>
		/// Value of variable $DATALEN
		/// </summary>
		public int Datalen { get; }

		/// <summary>
		/// Value of variable $NPACKETS
		/// </summary>
		public int Npackets { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public bool Debug { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
