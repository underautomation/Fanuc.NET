//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DHCP_INT_T
	/// </summary>
	public class DhcpIntVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $LEASESTRTIM
		/// </summary>
		public int Leasestrtim { get; }

		/// <summary>
		/// Value of variable $LEASESTART
		/// </summary>
		public string Leasestart { get; }

		/// <summary>
		/// Value of variable $LEASEENDTIM
		/// </summary>
		public int Leaseendtim { get; }

		/// <summary>
		/// Value of variable $LEASEEND
		/// </summary>
		public string Leaseend { get; }

		/// <summary>
		/// Value of variable $IPADD
		/// </summary>
		public string Ipadd { get; }

		/// <summary>
		/// Value of variable $ROUTERIP
		/// </summary>
		public string Routerip { get; }

		/// <summary>
		/// Value of variable $SNMASK
		/// </summary>
		public string Snmask { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public string Status { get; }

		/// <summary>
		/// Value of variable $STATNUM
		/// </summary>
		public int Statnum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
