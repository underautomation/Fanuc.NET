//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MN_MCR_TABLE
	/// </summary>
	public class MnMcrTableVariableType : GenericVariableType, IGenericVariableType {


		public MnMcrTableVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MACRO_NAME
		/// </summary>
		public string MacroName { get; }

		/// <summary>
		/// Value of variable $PROG_NAME
		/// </summary>
		public string ProgName { get; }

		/// <summary>
		/// Value of variable $EPT_INDEX
		/// </summary>
		public short EptIndex { get; }

		/// <summary>
		/// Value of variable $OPEN_ID
		/// </summary>
		public short OpenId { get; }

		/// <summary>
		/// Value of variable $ASSIGN_TYPE
		/// </summary>
		public int AssignType { get; }

		/// <summary>
		/// Value of variable $ASSIGN_ID
		/// </summary>
		public int AssignId { get; }

		/// <summary>
		/// Value of variable $MON_NO
		/// </summary>
		public int MonNo { get; }

		/// <summary>
		/// Value of variable $PREV_SUBTYP
		/// </summary>
		public byte PrevSubtyp { get; }

		/// <summary>
		/// Value of variable $USER_WORK
		/// </summary>
		public byte UserWork { get; }

		/// <summary>
		/// Value of variable $SYS_LEV_MSK
		/// </summary>
		public byte SysLevMsk { get; }

		/// <summary>
		/// Value of variable $MCR_RTN
		/// </summary>
		public byte McrRtn { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
