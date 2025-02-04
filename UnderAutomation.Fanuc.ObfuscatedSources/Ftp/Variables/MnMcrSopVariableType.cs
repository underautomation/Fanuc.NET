//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MN_MCR_SOP_T
	/// </summary>
	public class MnMcrSopVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SOP_EMGOP
		/// </summary>
		public bool SopEmgop { get; }

		/// <summary>
		/// Value of variable $SOP_RESET
		/// </summary>
		public bool SopReset { get; }

		/// <summary>
		/// Value of variable $SOP_REMOTE
		/// </summary>
		public bool SopRemote { get; }

		/// <summary>
		/// Value of variable $SOP_HOLD
		/// </summary>
		public bool SopHold { get; }

		/// <summary>
		/// Value of variable $SOP_USER1
		/// </summary>
		public bool SopUser1 { get; }

		/// <summary>
		/// Value of variable $SOP_USER2
		/// </summary>
		public bool SopUser2 { get; }

		/// <summary>
		/// Value of variable $SOP_START
		/// </summary>
		public bool SopStart { get; }

		/// <summary>
		/// Value of variable $SOP_PDI8
		/// </summary>
		public bool SopPdi8 { get; }

		/// <summary>
		/// Value of variable $SOP_PDI9
		/// </summary>
		public bool SopPdi9 { get; }

		/// <summary>
		/// Value of variable $SOP_PDIA
		/// </summary>
		public bool SopPdia { get; }

		/// <summary>
		/// Value of variable $SOP_PDIB
		/// </summary>
		public bool SopPdib { get; }

		/// <summary>
		/// Value of variable $SOP_PDIC
		/// </summary>
		public bool SopPdic { get; }

		/// <summary>
		/// Value of variable $SOP_TPDSC
		/// </summary>
		public bool SopTpdsc { get; }

		/// <summary>
		/// Value of variable $SOP_TPREL
		/// </summary>
		public bool SopTprel { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
