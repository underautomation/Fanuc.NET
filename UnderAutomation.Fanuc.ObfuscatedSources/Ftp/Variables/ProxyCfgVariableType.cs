//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PROXY_CFG_T
	/// </summary>
	public class ProxyCfgVariableType : GenericVariableType, IGenericVariableType {


		public ProxyCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $LIST_PORT
		/// </summary>
		public int ListPort { get; }

		/// <summary>
		/// Value of variable $PROXY_ENB
		/// </summary>
		public int ProxyEnb { get; }

		/// <summary>
		/// Value of variable $PROXY_SRV
		/// </summary>
		public string ProxySrv { get; }

		/// <summary>
		/// Value of variable $PROXY_PORT
		/// </summary>
		public int ProxyPort { get; }

		/// <summary>
		/// Value of variable $DIRECT_1
		/// </summary>
		public string Direct1 { get; }

		/// <summary>
		/// Value of variable $DIRECT_2
		/// </summary>
		public string Direct2 { get; }

		/// <summary>
		/// Value of variable $DIRECT_3
		/// </summary>
		public string Direct3 { get; }

		/// <summary>
		/// Value of variable $DIRECT_4
		/// </summary>
		public string Direct4 { get; }

		/// <summary>
		/// Value of variable $DIRECT_5
		/// </summary>
		public string Direct5 { get; }

		/// <summary>
		/// Value of variable $DIRECT_6
		/// </summary>
		public string Direct6 { get; }

		/// <summary>
		/// Value of variable $DIRECT_7
		/// </summary>
		public string Direct7 { get; }

		/// <summary>
		/// Value of variable $DIRECT_8
		/// </summary>
		public string Direct8 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
