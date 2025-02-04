//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TORQCTRL_T
	/// </summary>
	public class TorqctrlVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $GRP_STT
		/// </summary>
		public bool[] GrpStt { get; }

		/// <summary>
		/// Value of variable $SBR_PAM21_V
		/// </summary>
		public int[] SbrPam21V { get; }

		/// <summary>
		/// Value of variable $SV_ERR_MOD
		/// </summary>
		public bool[] SvErrMod { get; }

		/// <summary>
		/// Value of variable $SV_ERR_CLR
		/// </summary>
		public bool[] SvErrClr { get; }

		/// <summary>
		/// Value of variable $ACTION
		/// </summary>
		public int Action { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
