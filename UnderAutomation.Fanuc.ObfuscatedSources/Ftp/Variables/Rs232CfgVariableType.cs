//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type RS232_CFG_T
	/// </summary>
	public class Rs232CfgVariableType : GenericVariableType, IGenericVariableType {


		public Rs232CfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $COMMENT
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Value of variable $DEVICEUSE
		/// </summary>
		public int Deviceuse { get; }

		/// <summary>
		/// Value of variable $SPEED
		/// </summary>
		public int Speed { get; }

		/// <summary>
		/// Value of variable $PARITY
		/// </summary>
		public int Parity { get; }

		/// <summary>
		/// Value of variable $STOPBITS
		/// </summary>
		public int Stopbits { get; }

		/// <summary>
		/// Value of variable $FLOWCONTROL
		/// </summary>
		public int Flowcontrol { get; }

		/// <summary>
		/// Value of variable $TIMEOUT
		/// </summary>
		public int Timeout { get; }

		/// <summary>
		/// Value of variable $CUSTOM
		/// </summary>
		public int Custom { get; }

		/// <summary>
		/// Value of variable $AUXTASK
		/// </summary>
		public int Auxtask { get; }

		/// <summary>
		/// Value of variable $INTERFACE
		/// </summary>
		public int Interface { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public string Status { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
