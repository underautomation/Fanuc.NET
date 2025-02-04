//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PF_CFG_T
	/// </summary>
	public class PfCfgVariableType : GenericVariableType, IGenericVariableType {


		public PfCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $PROG_NAME
		/// </summary>
		public string ProgName { get; }

		/// <summary>
		/// Value of variable $CUR_GROUP
		/// </summary>
		public int CurGroup { get; }

		/// <summary>
		/// Value of variable $RAN_GROUPS
		/// </summary>
		public int RanGroups { get; }

		/// <summary>
		/// Value of variable $START_TYPE
		/// </summary>
		public int StartType { get; }

		/// <summary>
		/// Value of variable $TOTAL_TIME
		/// </summary>
		public double TotalTime { get; }

		/// <summary>
		/// Value of variable $TOTAL_PWR
		/// </summary>
		public double TotalPwr { get; }

		/// <summary>
		/// Value of variable $INS_PWR
		/// </summary>
		public double InsPwr { get; }

		/// <summary>
		/// Value of variable $REGEN_PWR
		/// </summary>
		public double RegenPwr { get; }

		/// <summary>
		/// Value of variable $INS_REGEN
		/// </summary>
		public double InsRegen { get; }

		/// <summary>
		/// Value of variable $EXE_DATE
		/// </summary>
		public string ExeDate { get; }

		/// <summary>
		/// Value of variable $DATA_TYPE
		/// </summary>
		public int DataType { get; }

		/// <summary>
		/// Value of variable $RES_NAME
		/// </summary>
		public string ResName { get; }

		/// <summary>
		/// Value of variable $MONTR_RATE
		/// </summary>
		public int MontrRate { get; }

		/// <summary>
		/// Value of variable $D_PWR_SUP
		/// </summary>
		public int DPwrSup { get; }

		/// <summary>
		/// Value of variable $D_PWR_REG
		/// </summary>
		public int DPwrReg { get; }

		/// <summary>
		/// Value of variable $RV_LIM1
		/// </summary>
		public int RvLim1 { get; }

		/// <summary>
		/// Value of variable $RV_LIM2
		/// </summary>
		public int RvLim2 { get; }

		/// <summary>
		/// Value of variable $DEGREE
		/// </summary>
		public int Degree { get; }

		/// <summary>
		/// Value of variable $REFRESH
		/// </summary>
		public int Refresh { get; }

		/// <summary>
		/// Value of variable $OVERRIDE
		/// </summary>
		public int Override { get; }

		/// <summary>
		/// Value of variable $RV_HRS_DAY
		/// </summary>
		public double RvHrsDay { get; }

		/// <summary>
		/// Value of variable $RV_DAYS_YR
		/// </summary>
		public int RvDaysYr { get; }

		/// <summary>
		/// Value of variable $MAXSIZE
		/// </summary>
		public int Maxsize { get; }

		/// <summary>
		/// Value of variable $SUMMARY
		/// </summary>
		public PfDataVariableType[] Summary { get; }

		/// <summary>
		/// Value of variable $CONFIG_SET
		/// </summary>
		public int ConfigSet { get; }

		/// <summary>
		/// Value of variable $SUPPORT
		/// </summary>
		public int Support { get; }

		/// <summary>
		/// Value of variable $LAST_RUN
		/// </summary>
		public int LastRun { get; }

		/// <summary>
		/// Value of variable $REC_STYLE
		/// </summary>
		public int RecStyle { get; }

		/// <summary>
		/// Value of variable $CMPR_ENB
		/// </summary>
		public bool CmprEnb { get; }

		/// <summary>
		/// Value of variable $CMPR_DEV
		/// </summary>
		public string CmprDev { get; }

		/// <summary>
		/// Value of variable $CMPR_DIR
		/// </summary>
		public string CmprDir { get; }

		/// <summary>
		/// Value of variable $CMPR_SUPPOR
		/// </summary>
		public int CmprSuppor { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
