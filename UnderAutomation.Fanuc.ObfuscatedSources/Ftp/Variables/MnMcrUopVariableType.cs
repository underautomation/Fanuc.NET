//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MN_MCR_UOP_T
	/// </summary>
	public class MnMcrUopVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $UOP_ESTOP
		/// </summary>
		public bool UopEstop { get; }

		/// <summary>
		/// Value of variable $UOP_HOLD
		/// </summary>
		public bool UopHold { get; }

		/// <summary>
		/// Value of variable $UOP_SFSPD
		/// </summary>
		public bool UopSfspd { get; }

		/// <summary>
		/// Value of variable $UOP_CSTOP
		/// </summary>
		public bool UopCstop { get; }

		/// <summary>
		/// Value of variable $UOP_RESET
		/// </summary>
		public bool UopReset { get; }

		/// <summary>
		/// Value of variable $UOP_START
		/// </summary>
		public bool UopStart { get; }

		/// <summary>
		/// Value of variable $UOP_HOME
		/// </summary>
		public bool UopHome { get; }

		/// <summary>
		/// Value of variable $UOP_ENBL
		/// </summary>
		public bool UopEnbl { get; }

		/// <summary>
		/// Value of variable $UOP_RSR1
		/// </summary>
		public bool UopRsr1 { get; }

		/// <summary>
		/// Value of variable $UOP_RSR2
		/// </summary>
		public bool UopRsr2 { get; }

		/// <summary>
		/// Value of variable $UOP_RSR3
		/// </summary>
		public bool UopRsr3 { get; }

		/// <summary>
		/// Value of variable $UOP_RSR4
		/// </summary>
		public bool UopRsr4 { get; }

		/// <summary>
		/// Value of variable $UOP_RSR5
		/// </summary>
		public bool UopRsr5 { get; }

		/// <summary>
		/// Value of variable $UOP_RSR6
		/// </summary>
		public bool UopRsr6 { get; }

		/// <summary>
		/// Value of variable $UOP_RSR7
		/// </summary>
		public bool UopRsr7 { get; }

		/// <summary>
		/// Value of variable $UOP_RSR8
		/// </summary>
		public bool UopRsr8 { get; }

		/// <summary>
		/// Value of variable $UOP_PNSTRB
		/// </summary>
		public bool UopPnstrb { get; }

		/// <summary>
		/// Value of variable $UOP_PDSTRT
		/// </summary>
		public bool UopPdstrt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
