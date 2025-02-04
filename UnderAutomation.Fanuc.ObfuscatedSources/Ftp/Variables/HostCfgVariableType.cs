//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HOST_CFG_T
	/// </summary>
	public class HostCfgVariableType : GenericVariableType, IGenericVariableType {


		public HostCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $COMMENT
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Value of variable $PROTOCOL
		/// </summary>
		public string Protocol { get; }

		/// <summary>
		/// Value of variable $PORT
		/// </summary>
		public string Port { get; }

		/// <summary>
		/// Value of variable $OPER
		/// </summary>
		public int Oper { get; }

		/// <summary>
		/// Value of variable $STATE
		/// </summary>
		public int State { get; }

		/// <summary>
		/// Value of variable $MODE
		/// </summary>
		public string Mode { get; }

		/// <summary>
		/// Value of variable $REMOTE
		/// </summary>
		public string Remote { get; }

		/// <summary>
		/// Value of variable $REPERRS
		/// </summary>
		public bool Reperrs { get; }

		/// <summary>
		/// Value of variable $TIMEOUT
		/// </summary>
		public int Timeout { get; }

		/// <summary>
		/// Value of variable $PATH
		/// </summary>
		public string Path { get; }

		/// <summary>
		/// Value of variable $STRT_PATH
		/// </summary>
		public string StrtPath { get; }

		/// <summary>
		/// Value of variable $STRT_REMOTE
		/// </summary>
		public string StrtRemote { get; }

		/// <summary>
		/// Value of variable $USERNAME
		/// </summary>
		public string Username { get; }

		/// <summary>
		/// Value of variable $PWRD_TIMOUT
		/// </summary>
		public int PwrdTimout { get; }

		/// <summary>
		/// Value of variable $SERVER_PORT
		/// </summary>
		public int ServerPort { get; }

		/// <summary>
		/// Value of variable $USE_VIS_PRT
		/// </summary>
		public bool UseVisPrt { get; }

		/// <summary>
		/// Value of variable $USE_UDP
		/// </summary>
		public bool UseUdp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
