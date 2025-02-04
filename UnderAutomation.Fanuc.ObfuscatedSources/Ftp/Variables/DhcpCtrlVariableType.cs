//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DHCP_CTRL_T
	/// </summary>
	public class DhcpCtrlVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $IPUSE
		/// </summary>
		public bool Ipuse { get; }

		/// <summary>
		/// Value of variable $RETRATE
		/// </summary>
		public int Retrate { get; }

		/// <summary>
		/// Value of variable $SETHOST
		/// </summary>
		public bool Sethost { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
