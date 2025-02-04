//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ENETMODE_T
	/// </summary>
	public class EnetmodeVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $FULL_DUPLEX
		/// </summary>
		public bool FullDuplex { get; }

		/// <summary>
		/// Value of variable $SPEED
		/// </summary>
		public int Speed { get; }

		/// <summary>
		/// Value of variable $ACD_ENABLE
		/// </summary>
		public bool AcdEnable { get; }

		/// <summary>
		/// Value of variable $THROTTLE
		/// </summary>
		public bool Throttle { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
