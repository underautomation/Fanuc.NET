//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type USR_EV_CFG_T
	/// </summary>
	public class UsrEvCfgVariableType : GenericVariableType, IGenericVariableType {


		public UsrEvCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $OWNER_NAME
		/// </summary>
		public string OwnerName { get; }

		/// <summary>
		/// Value of variable $SRC_DIR
		/// </summary>
		public string SrcDir { get; }

		/// <summary>
		/// Value of variable $DST_DIR
		/// </summary>
		public string DstDir { get; }

		/// <summary>
		/// Value of variable $MAX_TMPFILE
		/// </summary>
		public int MaxTmpfile { get; }

		/// <summary>
		/// Value of variable $MIN_FREESPC
		/// </summary>
		public int MinFreespc { get; }

		/// <summary>
		/// Value of variable $OPTIONS
		/// </summary>
		public int Options { get; }

		/// <summary>
		/// Value of variable $RESERVED1
		/// </summary>
		public int Reserved1 { get; }

		/// <summary>
		/// Value of variable $RESERVED2
		/// </summary>
		public int Reserved2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
