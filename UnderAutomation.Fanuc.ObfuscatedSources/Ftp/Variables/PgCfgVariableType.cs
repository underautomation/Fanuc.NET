//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PG_CFG_T
	/// </summary>
	public class PgCfgVariableType : GenericVariableType, IGenericVariableType {


		public PgCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $SUBTASKNUM
		/// </summary>
		public int Subtasknum { get; }

		/// <summary>
		/// Value of variable $NUM_TASKS
		/// </summary>
		public int NumTasks { get; }

		/// <summary>
		/// Value of variable $JMPWAIT_UPR
		/// </summary>
		public int JmpwaitUpr { get; }

		/// <summary>
		/// Value of variable $JMPWAIT_LOW
		/// </summary>
		public int JmpwaitLow { get; }

		/// <summary>
		/// Value of variable $FAST_MODE
		/// </summary>
		public int FastMode { get; }

		/// <summary>
		/// Value of variable $RCVFAIL_CNT
		/// </summary>
		public int RcvfailCnt { get; }

		/// <summary>
		/// Value of variable $WAITREL_CFG
		/// </summary>
		public int WaitrelCfg { get; }

		/// <summary>
		/// Value of variable $ACC_CTRL
		/// </summary>
		public int AccCtrl { get; }

		/// <summary>
		/// Value of variable $CNT_CTRL
		/// </summary>
		public int CntCtrl { get; }

		/// <summary>
		/// Value of variable $IGNR_PLS
		/// </summary>
		public int IgnrPls { get; }

		/// <summary>
		/// Value of variable $DBTB_STPTYP
		/// </summary>
		public int DbtbStptyp { get; }

		/// <summary>
		/// Value of variable $BWD_CFG
		/// </summary>
		public int BwdCfg { get; }

		/// <summary>
		/// Value of variable $RESUME_CFG
		/// </summary>
		public int ResumeCfg { get; }

		/// <summary>
		/// Value of variable $IGPAUS_PRI
		/// </summary>
		public int IgpausPri { get; }

		/// <summary>
		/// Value of variable $MTNLN_CFG
		/// </summary>
		public int MtnlnCfg { get; }

		/// <summary>
		/// Value of variable $PAUS_RTN
		/// </summary>
		public int PausRtn { get; }

		/// <summary>
		/// Value of variable $NOMOTN_PR
		/// </summary>
		public bool NomotnPr { get; }

		/// <summary>
		/// Value of variable $SPEED_UP
		/// </summary>
		public int SpeedUp { get; }

		/// <summary>
		/// Value of variable $SHADOW_STK
		/// </summary>
		public int ShadowStk { get; }

		/// <summary>
		/// Value of variable $RESERVE1
		/// </summary>
		public int Reserve1 { get; }

		/// <summary>
		/// Value of variable $RESERVE2
		/// </summary>
		public int Reserve2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
