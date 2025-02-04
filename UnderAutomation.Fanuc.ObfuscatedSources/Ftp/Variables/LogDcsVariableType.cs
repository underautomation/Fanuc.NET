//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type LOG_DCS_T
	/// </summary>
	public class LogDcsVariableType : GenericVariableType, IGenericVariableType {


		public LogDcsVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public int Enable { get; }

		/// <summary>
		/// Value of variable $SPD_TOL
		/// </summary>
		public double SpdTol { get; }

		/// <summary>
		/// Value of variable $OUTPUT_TYP
		/// </summary>
		public int OutputTyp { get; }

		/// <summary>
		/// Value of variable $OUTPUT_IDX
		/// </summary>
		public int OutputIdx { get; }

		/// <summary>
		/// Value of variable $GRP_NUM
		/// </summary>
		public int GrpNum { get; }

		/// <summary>
		/// Value of variable $POS_TYP
		/// </summary>
		public int PosTyp { get; }

		/// <summary>
		/// Value of variable $AXIS_NUM
		/// </summary>
		public int AxisNum { get; }

		/// <summary>
		/// Value of variable $STOP_READY
		/// </summary>
		public bool StopReady { get; }

		/// <summary>
		/// Value of variable $STOP
		/// </summary>
		public StopVariableType Stop { get; }

		/// <summary>
		/// Value of variable $ESTOP
		/// </summary>
		public StopVariableType Estop { get; }

		/// <summary>
		/// Value of variable $CSTOP
		/// </summary>
		public StopVariableType Cstop { get; }

		/// <summary>
		/// Value of variable $ESTOP_DIFF
		/// </summary>
		public StopVariableType EstopDiff { get; }

		/// <summary>
		/// Value of variable $CSTOP_DIFF
		/// </summary>
		public StopVariableType CstopDiff { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
