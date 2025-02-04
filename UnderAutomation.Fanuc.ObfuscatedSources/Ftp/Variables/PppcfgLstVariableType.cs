//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PPPCFG_LST_T
	/// </summary>
	public class PppcfgLstVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ROBOTIP
		/// </summary>
		public string Robotip { get; }

		/// <summary>
		/// Value of variable $PEERIP
		/// </summary>
		public string Peerip { get; }

		/// <summary>
		/// Value of variable $NETMASK
		/// </summary>
		public string Netmask { get; }

		/// <summary>
		/// Value of variable $MRU
		/// </summary>
		public int Mru { get; }

		/// <summary>
		/// Value of variable $COMP
		/// </summary>
		public int Comp { get; }

		/// <summary>
		/// Value of variable $DEVTYPE
		/// </summary>
		public int Devtype { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
