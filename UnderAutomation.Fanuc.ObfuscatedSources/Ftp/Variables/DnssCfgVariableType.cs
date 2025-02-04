//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DNSS_CFG_T
	/// </summary>
	public class DnssCfgVariableType : GenericVariableType, IGenericVariableType {


		public DnssCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Value of variable $IFACE_NUM
		/// </summary>
		public short IfaceNum { get; }

		/// <summary>
		/// Value of variable $DBG_LEVEL
		/// </summary>
		public short DbgLevel { get; }

		/// <summary>
		/// Value of variable $DOM_NAME
		/// </summary>
		public string DomName { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
