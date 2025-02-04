//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DRC_CFG_T
	/// </summary>
	public class DrcCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $HOST1
		/// </summary>
		public string Host1 { get; }

		/// <summary>
		/// Value of variable $HOST2
		/// </summary>
		public string Host2 { get; }

		/// <summary>
		/// Value of variable $HOST3
		/// </summary>
		public string Host3 { get; }

		/// <summary>
		/// Value of variable $HOST4
		/// </summary>
		public string Host4 { get; }

		/// <summary>
		/// Value of variable $HOST5
		/// </summary>
		public string Host5 { get; }

		/// <summary>
		/// Value of variable $EMAIL_ENABL
		/// </summary>
		public bool EmailEnabl { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
