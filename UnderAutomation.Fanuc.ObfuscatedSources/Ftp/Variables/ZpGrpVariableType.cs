//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ZP_GRP_T
	/// </summary>
	public class ZpGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $OPTIONS
		/// </summary>
		public int[] Options { get; }

		/// <summary>
		/// Value of variable $BREAK_TIME
		/// </summary>
		public int BreakTime { get; }

		/// <summary>
		/// Value of variable $WORK_SHIFT
		/// </summary>
		public int WorkShift { get; }

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $RV_LIFE
		/// </summary>
		public int[] RvLife { get; }

		/// <summary>
		/// Value of variable $SHIFT_OVC
		/// </summary>
		public double[] ShiftOvc { get; }

		/// <summary>
		/// Value of variable $PART_ID
		/// </summary>
		public int PartId { get; }

		/// <summary>
		/// Value of variable $OPTM_RATE
		/// </summary>
		public double[] OptmRate { get; }

		/// <summary>
		/// Value of variable $MAX_I_RATE
		/// </summary>
		public int MaxIRate { get; }

		/// <summary>
		/// Value of variable $MAX_DI_RATE
		/// </summary>
		public int MaxDiRate { get; }

		/// <summary>
		/// Value of variable $TRACE_ENV
		/// </summary>
		public double TraceEnv { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
