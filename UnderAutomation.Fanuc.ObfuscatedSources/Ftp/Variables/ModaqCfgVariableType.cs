//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MODAQ_CFG_T
	/// </summary>
	public class ModaqCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ON_LINE
		/// </summary>
		public bool OnLine { get; }

		/// <summary>
		/// Value of variable $MF_FLAG
		/// </summary>
		public int MfFlag { get; }

		/// <summary>
		/// Value of variable $MI_FLAG
		/// </summary>
		public int MiFlag { get; }

		/// <summary>
		/// Value of variable $GRP_NUM
		/// </summary>
		public int GrpNum { get; }

		/// <summary>
		/// Value of variable $STARTLOG
		/// </summary>
		public int Startlog { get; }

		/// <summary>
		/// Value of variable $ENDLOG
		/// </summary>
		public int Endlog { get; }

		/// <summary>
		/// Value of variable $LN_MASK
		/// </summary>
		public int LnMask { get; }

		/// <summary>
		/// Value of variable $SUPPORT
		/// </summary>
		public int Support { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
