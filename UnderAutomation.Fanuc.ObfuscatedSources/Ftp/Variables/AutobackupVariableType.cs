//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AUTOBACKUP_T
	/// </summary>
	public class AutobackupVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $DEVICE
		/// </summary>
		public string Device { get; }

		/// <summary>
		/// Value of variable $TIME
		/// </summary>
		public int[] Time { get; }

		/// <summary>
		/// Value of variable $DI_IDX
		/// </summary>
		public int DiIdx { get; }

		/// <summary>
		/// Value of variable $STARTUP_BCK
		/// </summary>
		public bool StartupBck { get; }

		/// <summary>
		/// Value of variable $INTERVAL
		/// </summary>
		public int Interval { get; }

		/// <summary>
		/// Value of variable $DISP_UNIT
		/// </summary>
		public int DispUnit { get; }

		/// <summary>
		/// Value of variable $BCK_DO_IDX
		/// </summary>
		public int BckDoIdx { get; }

		/// <summary>
		/// Value of variable $ERR_DO_IDX
		/// </summary>
		public int ErrDoIdx { get; }

		/// <summary>
		/// Value of variable $FR_FREE
		/// </summary>
		public int FrFree { get; }

		/// <summary>
		/// Value of variable $IN_PROGRESS
		/// </summary>
		public int InProgress { get; }

		/// <summary>
		/// Value of variable $REQ_BACKUP
		/// </summary>
		public int ReqBackup { get; }

		/// <summary>
		/// Value of variable $PRC_WAIT
		/// </summary>
		public int PrcWait { get; }

		/// <summary>
		/// Value of variable $AUTO_BACKUP
		/// </summary>
		public int AutoBackup { get; }

		/// <summary>
		/// Value of variable $POFF_COUNT
		/// </summary>
		public int PoffCount { get; }

		/// <summary>
		/// Value of variable $DEL_COUNT
		/// </summary>
		public int DelCount { get; }

		/// <summary>
		/// Value of variable $LOG_IDX
		/// </summary>
		public int LogIdx { get; }

		/// <summary>
		/// Value of variable $DEL_TIME
		/// </summary>
		public string[] DelTime { get; }

		/// <summary>
		/// Value of variable $DEL_FILE
		/// </summary>
		public string[] DelFile { get; }

		/// <summary>
		/// Value of variable $PROC_FILE
		/// </summary>
		public string ProcFile { get; }

		/// <summary>
		/// Value of variable $LAST_TIME
		/// </summary>
		public int LastTime { get; }

		/// <summary>
		/// Value of variable $ATB_COUNT
		/// </summary>
		public int AtbCount { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
