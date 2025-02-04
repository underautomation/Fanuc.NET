//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HOSTENT_T
	/// </summary>
	public class HostentVariableType : GenericVariableType, IGenericVariableType {


		public HostentVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $H_NAME
		/// </summary>
		public string HName { get; }

		/// <summary>
		/// Value of variable $H_ADDRTYPE
		/// </summary>
		public int HAddrtype { get; }

		/// <summary>
		/// Value of variable $H_LENGTH
		/// </summary>
		public int HLength { get; }

		/// <summary>
		/// Value of variable $H_ADDR
		/// </summary>
		public string HAddr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
