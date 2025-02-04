//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type EOATDATA_T
	/// </summary>
	public class EoatdataVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ID
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $ZONE
		/// </summary>
		public int Zone { get; }

		/// <summary>
		/// Value of variable $TYPE
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Value of variable $IO_UGRP_TYP
		/// </summary>
		public int IoUgrpTyp { get; }

		/// <summary>
		/// Value of variable $IO_UGRP_PRT
		/// </summary>
		public int IoUgrpPrt { get; }

		/// <summary>
		/// Value of variable $IO_UGRP_CND
		/// </summary>
		public int IoUgrpCnd { get; }

		/// <summary>
		/// Value of variable $IO_GRP_TYP
		/// </summary>
		public int IoGrpTyp { get; }

		/// <summary>
		/// Value of variable $IO_GRP_PRT
		/// </summary>
		public int IoGrpPrt { get; }

		/// <summary>
		/// Value of variable $IO_GRP_CND
		/// </summary>
		public int IoGrpCnd { get; }

		/// <summary>
		/// Value of variable $GROUP_NUM
		/// </summary>
		public int GroupNum { get; }

		/// <summary>
		/// Value of variable $AXIS_NUM
		/// </summary>
		public int AxisNum { get; }

		/// <summary>
		/// Value of variable $SV_SCHED
		/// </summary>
		public int SvSched { get; }

		/// <summary>
		/// Value of variable $MN_UGRP_TYP
		/// </summary>
		public int MnUgrpTyp { get; }

		/// <summary>
		/// Value of variable $MN_UGRP_PRT
		/// </summary>
		public int MnUgrpPrt { get; }

		/// <summary>
		/// Value of variable $MN_UGRP_CND
		/// </summary>
		public int MnUgrpCnd { get; }

		/// <summary>
		/// Value of variable $MN_GRP_TYP
		/// </summary>
		public int MnGrpTyp { get; }

		/// <summary>
		/// Value of variable $MN_GRP_PRT
		/// </summary>
		public int MnGrpPrt { get; }

		/// <summary>
		/// Value of variable $MN_GRP_CND
		/// </summary>
		public int MnGrpCnd { get; }

		/// <summary>
		/// Value of variable $UGRP_THRSH
		/// </summary>
		public double UgrpThrsh { get; }

		/// <summary>
		/// Value of variable $GRP_THRSH
		/// </summary>
		public double GrpThrsh { get; }

		/// <summary>
		/// Value of variable $MAINT_CYCLE
		/// </summary>
		public int MaintCycle { get; }

		/// <summary>
		/// Value of variable $MAINT_THRSH
		/// </summary>
		public double MaintThrsh { get; }

		/// <summary>
		/// Value of variable $UGRP_TIME
		/// </summary>
		public double UgrpTime { get; }

		/// <summary>
		/// Value of variable $GRP_TIME
		/// </summary>
		public double GrpTime { get; }

		/// <summary>
		/// Value of variable $DETECT_DLY
		/// </summary>
		public int DetectDly { get; }

		/// <summary>
		/// Value of variable $DROP_CNT
		/// </summary>
		public int DropCnt { get; }

		/// <summary>
		/// Value of variable $CYCLE_CNT
		/// </summary>
		public int CycleCnt { get; }

		/// <summary>
		/// Value of variable $DAY_THRSH
		/// </summary>
		public int DayThrsh { get; }

		/// <summary>
		/// Value of variable $HOUR_THRSH
		/// </summary>
		public int HourThrsh { get; }

		/// <summary>
		/// Value of variable $TOTAL_THRSH
		/// </summary>
		public int TotalThrsh { get; }

		/// <summary>
		/// Value of variable $GRP_TIMOUT
		/// </summary>
		public bool GrpTimout { get; }

		/// <summary>
		/// Value of variable $UGRP_TIMOUT
		/// </summary>
		public bool UgrpTimout { get; }

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
