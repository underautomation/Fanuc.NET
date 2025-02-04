//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DNS_CFG_T
	/// </summary>
	public class DnsCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PRIMAR_IP
		/// </summary>
		public string PrimarIp { get; }

		/// <summary>
		/// Value of variable $ALTERN_IP
		/// </summary>
		public string AlternIp { get; }

		/// <summary>
		/// Value of variable $RETRIES
		/// </summary>
		public int Retries { get; }

		/// <summary>
		/// Value of variable $WAIT_TIME
		/// </summary>
		public int WaitTime { get; }

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
