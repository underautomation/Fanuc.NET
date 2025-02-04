//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ITEM_BUFF_EL
	/// </summary>
	public class ItemBuffElVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TIME_STAMP
		/// </summary>
		public short TimeStamp { get; }

		/// <summary>
		/// Value of variable $ELAPS_TICK
		/// </summary>
		public short ElapsTick { get; }

		/// <summary>
		/// Value of variable $ON_TICK
		/// </summary>
		public short OnTick { get; }

		/// <summary>
		/// Value of variable $OFF_TICK
		/// </summary>
		public short OffTick { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
