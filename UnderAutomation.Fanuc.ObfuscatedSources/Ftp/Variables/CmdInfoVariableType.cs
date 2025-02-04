//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CMD_INFO_T
	/// </summary>
	public class CmdInfoVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TRQ_CMD
		/// </summary>
		public double[] TrqCmd { get; }

		/// <summary>
		/// Value of variable $JNT_POS
		/// </summary>
		public double[] JntPos { get; }

		/// <summary>
		/// Value of variable $CART_POS
		/// </summary>
		public double[] CartPos { get; }

		/// <summary>
		/// Value of variable $CART_POS_UF
		/// </summary>
		public double[] CartPosUf { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
