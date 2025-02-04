//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type IO_UOP_CFG_T
	/// </summary>
	public class IoUopCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $UOP_TYPE
		/// </summary>
		public int UopType { get; }

		/// <summary>
		/// Value of variable $IN_RACK
		/// </summary>
		public int InRack { get; }

		/// <summary>
		/// Value of variable $IN_SLOT
		/// </summary>
		public int InSlot { get; }

		/// <summary>
		/// Value of variable $IN_STRTPT
		/// </summary>
		public int InStrtpt { get; }

		/// <summary>
		/// Value of variable $OUT_RACK
		/// </summary>
		public int OutRack { get; }

		/// <summary>
		/// Value of variable $OUT_SLOT
		/// </summary>
		public int OutSlot { get; }

		/// <summary>
		/// Value of variable $OUT_STRTPT
		/// </summary>
		public int OutStrtpt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
