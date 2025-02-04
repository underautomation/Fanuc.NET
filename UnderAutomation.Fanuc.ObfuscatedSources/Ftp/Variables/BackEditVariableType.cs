//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type BACK_EDIT_T
	/// </summary>
	public class BackEditVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PROGRAM
		/// </summary>
		public string Program { get; }

		/// <summary>
		/// Value of variable $SRC_NAME
		/// </summary>
		public string SrcName { get; }

		/// <summary>
		/// Value of variable $EPT_IDX
		/// </summary>
		public short EptIdx { get; }

		/// <summary>
		/// Value of variable $OPEN_ID
		/// </summary>
		public short OpenId { get; }

		/// <summary>
		/// Value of variable $DELETE_OK
		/// </summary>
		public bool DeleteOk { get; }

		/// <summary>
		/// Value of variable $USED_TP_CRT
		/// </summary>
		public short UsedTpCrt { get; }

		/// <summary>
		/// Value of variable $BACKUP_NAME
		/// </summary>
		public string BackupName { get; }

		/// <summary>
		/// Value of variable $REPLACING
		/// </summary>
		public bool Replacing { get; }

		/// <summary>
		/// Value of variable $BCK_COMMENT
		/// </summary>
		public string BckComment { get; }

		/// <summary>
		/// Value of variable $D_REPLACING
		/// </summary>
		public short DReplacing { get; }

		/// <summary>
		/// Value of variable $SEL_PROGRAM
		/// </summary>
		public string SelProgram { get; }

		/// <summary>
		/// Value of variable $DUMMY12
		/// </summary>
		public byte Dummy12 { get; }

		/// <summary>
		/// Value of variable $DUMMY13
		/// </summary>
		public byte Dummy13 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
