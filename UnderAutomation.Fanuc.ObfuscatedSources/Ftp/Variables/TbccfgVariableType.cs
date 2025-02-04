//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBCCFG_T
	/// </summary>
	public class TbccfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $GROUP_MASK
		/// </summary>
		public int GroupMask { get; }

		/// <summary>
		/// Value of variable $MB_CONFLICT
		/// </summary>
		public int MbConflict { get; }

		/// <summary>
		/// Value of variable $MB_REQUIRED
		/// </summary>
		public int MbRequired { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $TBC_STAT
		/// </summary>
		public int[] TbcStat { get; }

		/// <summary>
		/// Value of variable $TC
		/// </summary>
		public TbcAccVariableType[] Tc { get; }

		/// <summary>
		/// Value of variable $TBC_DEBUG
		/// </summary>
		public int TbcDebug { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
