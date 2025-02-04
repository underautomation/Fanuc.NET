//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TXRAM_T
	/// </summary>
	public class TxramVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $REMOTE
		/// </summary>
		public bool Remote { get; }

		/// <summary>
		/// Value of variable $PC
		/// </summary>
		public bool Pc { get; }

		/// <summary>
		/// Value of variable $PCJOG
		/// </summary>
		public bool Pcjog { get; }

		/// <summary>
		/// Value of variable $CUR_IP_MEM
		/// </summary>
		public int CurIpMem { get; }

		/// <summary>
		/// Value of variable $MIN_IP_MEM
		/// </summary>
		public int MinIpMem { get; }

		/// <summary>
		/// Value of variable $IP_MEM_SIZE
		/// </summary>
		public int IpMemSize { get; }

		/// <summary>
		/// Value of variable $IPADDR
		/// </summary>
		public int Ipaddr { get; }

		/// <summary>
		/// Value of variable $PLUS_FLAG
		/// </summary>
		public int PlusFlag { get; }

		/// <summary>
		/// Value of variable $OS_VERSION
		/// </summary>
		public string OsVersion { get; }

		/// <summary>
		/// Value of variable $NETF_VER
		/// </summary>
		public string NetfVer { get; }

		/// <summary>
		/// Value of variable $IP_TW
		/// </summary>
		public int IpTw { get; }

		/// <summary>
		/// Value of variable $TABLET_TP
		/// </summary>
		public bool TabletTp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
