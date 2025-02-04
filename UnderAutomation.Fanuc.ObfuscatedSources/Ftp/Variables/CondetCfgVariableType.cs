//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CONDET_CFG_T
	/// </summary>
	public class CondetCfgVariableType : GenericVariableType, IGenericVariableType {


		public CondetCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public int Enable { get; }

		/// <summary>
		/// Value of variable $STATE
		/// </summary>
		public int State { get; }

		/// <summary>
		/// Value of variable $SERVER_NAME
		/// </summary>
		public string ServerName { get; }

		/// <summary>
		/// Value of variable $PORT
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Value of variable $MODE
		/// </summary>
		public int Mode { get; }

		/// <summary>
		/// Value of variable $PROTOCOL
		/// </summary>
		public int Protocol { get; }

		/// <summary>
		/// Value of variable $PEER_NAME
		/// </summary>
		public string PeerName { get; }

		/// <summary>
		/// Value of variable $EXT_MASK
		/// </summary>
		public int ExtMask { get; }

		/// <summary>
		/// Value of variable $EXT_USED
		/// </summary>
		public int ExtUsed { get; }

		/// <summary>
		/// Value of variable $EXT_DATA
		/// </summary>
		public CondetDataVariableType[] ExtData { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
