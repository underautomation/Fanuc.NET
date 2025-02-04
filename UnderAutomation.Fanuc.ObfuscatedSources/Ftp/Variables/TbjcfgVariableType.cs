//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBJCFG_T
	/// </summary>
	public class TbjcfgVariableType : GenericVariableType, IGenericVariableType {


		public TbjcfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

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
		/// Value of variable $UPDATE_TIME
		/// </summary>
		public int UpdateTime { get; }

		/// <summary>
		/// Value of variable $TBJ_SELECT
		/// </summary>
		public int TbjSelect { get; }

		/// <summary>
		/// Value of variable $TBJ_STAT
		/// </summary>
		public int[] TbjStat { get; }

		/// <summary>
		/// Value of variable $TJ
		/// </summary>
		public TbjAccVariableType[] Tj { get; }

		/// <summary>
		/// Value of variable $JERK_CTRL
		/// </summary>
		public int JerkCtrl { get; }

		/// <summary>
		/// Value of variable $MOTN_INF
		/// </summary>
		public int MotnInf { get; }

		/// <summary>
		/// Value of variable $TBJ_DEBUG
		/// </summary>
		public int TbjDebug { get; }

		/// <summary>
		/// Value of variable $HAND_VB
		/// </summary>
		public double[] HandVb { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
