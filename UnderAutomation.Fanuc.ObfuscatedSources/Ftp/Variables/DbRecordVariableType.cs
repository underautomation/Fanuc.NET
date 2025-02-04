//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DB_RECORD_T
	/// </summary>
	public class DbRecordVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CPOS
		/// </summary>
		public XYZPosition Cpos { get; }

		/// <summary>
		/// Value of variable $LPOS
		/// </summary>
		public XYZPosition Lpos { get; }

		/// <summary>
		/// Value of variable $DPOS_DST
		/// </summary>
		public double DposDst { get; }

		/// <summary>
		/// Value of variable $LDPOS_DST
		/// </summary>
		public double LdposDst { get; }

		/// <summary>
		/// Value of variable $LINE_NUM
		/// </summary>
		public int LineNum { get; }

		/// <summary>
		/// Value of variable $ONCE_DC
		/// </summary>
		public bool OnceDc { get; }

		/// <summary>
		/// Value of variable $CROSS
		/// </summary>
		public int Cross { get; }

		/// <summary>
		/// Value of variable $TASK_ID
		/// </summary>
		public int TaskId { get; }

		/// <summary>
		/// Value of variable $ENABLED_TIM
		/// </summary>
		public int EnabledTim { get; }

		/// <summary>
		/// Value of variable $TRIGGER_TIM
		/// </summary>
		public int TriggerTim { get; }

		/// <summary>
		/// Value of variable $PAUSED_TIME
		/// </summary>
		public int PausedTime { get; }

		/// <summary>
		/// Value of variable $RETURNED_TI
		/// </summary>
		public int ReturnedTi { get; }

		/// <summary>
		/// Value of variable $MMR_STATUS
		/// </summary>
		public string MmrStatus { get; }

		/// <summary>
		/// Value of variable $CRE_NEWMON
		/// </summary>
		public bool CreNewmon { get; }

		/// <summary>
		/// Value of variable $SIGNAL_ACT
		/// </summary>
		public bool SignalAct { get; }

		/// <summary>
		/// Value of variable $LAST_ACT
		/// </summary>
		public bool LastAct { get; }

		/// <summary>
		/// Value of variable $PD
		/// </summary>
		public XYZPosition Pd { get; }

		/// <summary>
		/// Value of variable $PC
		/// </summary>
		public XYZPosition Pc { get; }

		/// <summary>
		/// Value of variable $PN_AT
		/// </summary>
		public XYZPosition PnAt { get; }

		/// <summary>
		/// Value of variable $PD2
		/// </summary>
		public double Pd2 { get; }

		/// <summary>
		/// Value of variable $PC2
		/// </summary>
		public double Pc2 { get; }

		/// <summary>
		/// Value of variable $PT
		/// </summary>
		public double Pt { get; }

		/// <summary>
		/// Value of variable $PD_DOT_PC
		/// </summary>
		public double PdDotPc { get; }

		/// <summary>
		/// Value of variable $LINE_DST
		/// </summary>
		public double LineDst { get; }

		/// <summary>
		/// Value of variable $P_NUM
		/// </summary>
		public int PNum { get; }

		/// <summary>
		/// Value of variable $GO_AWAY
		/// </summary>
		public bool GoAway { get; }

		/// <summary>
		/// Value of variable $MOTION_COMP
		/// </summary>
		public bool MotionComp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
