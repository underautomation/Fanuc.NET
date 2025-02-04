//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FSAC_LST_T
	/// </summary>
	public class FsacLstVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CLNT_NAME
		/// </summary>
		public string ClntName { get; }

		/// <summary>
		/// Value of variable $IP_ADDRESS
		/// </summary>
		public string IpAddress { get; }

		/// <summary>
		/// Value of variable $ACCESS_LVL
		/// </summary>
		public int AccessLvl { get; }

		/// <summary>
		/// Value of variable $APPS
		/// </summary>
		public int Apps { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
