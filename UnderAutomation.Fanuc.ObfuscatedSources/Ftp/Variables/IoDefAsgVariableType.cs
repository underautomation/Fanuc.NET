//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type IO_DEF_ASG_T
	/// </summary>
	public class IoDefAsgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $LOG_TYPE
		/// </summary>
		public int LogType { get; }

		/// <summary>
		/// Value of variable $LOG_NO
		/// </summary>
		public int LogNo { get; }

		/// <summary>
		/// Value of variable $NUM_PORTS
		/// </summary>
		public int NumPorts { get; }

		/// <summary>
		/// Value of variable $RACK
		/// </summary>
		public int Rack { get; }

		/// <summary>
		/// Value of variable $SLOT
		/// </summary>
		public int Slot { get; }

		/// <summary>
		/// Value of variable $PHY_TYPE
		/// </summary>
		public int PhyType { get; }

		/// <summary>
		/// Value of variable $PHY_NO
		/// </summary>
		public int PhyNo { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
