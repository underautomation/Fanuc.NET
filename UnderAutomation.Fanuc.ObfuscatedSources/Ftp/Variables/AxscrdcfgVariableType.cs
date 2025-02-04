//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AXSCRDCFG_T
	/// </summary>
	public class AxscrdcfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CARD_EXIST
		/// </summary>
		public bool CardExist { get; }

		/// <summary>
		/// Value of variable $FSSB_TYPE
		/// </summary>
		public int FssbType { get; }

		/// <summary>
		/// Value of variable $CHKBD_SEL
		/// </summary>
		public int ChkbdSel { get; }

		/// <summary>
		/// Value of variable $DIAG_REG
		/// </summary>
		public int[] DiagReg { get; }

		/// <summary>
		/// Value of variable $SLOT_NUM
		/// </summary>
		public int SlotNum { get; }

		/// <summary>
		/// Value of variable $SLOT_PREV
		/// </summary>
		public int SlotPrev { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int[] Debug { get; }

		/// <summary>
		/// Value of variable $CARD_ID
		/// </summary>
		public int CardId { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
