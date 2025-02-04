//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SYSLOG_SAV_T
	/// </summary>
	public class SyslogSavVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SAVE_BLCKS
		/// </summary>
		public int SaveBlcks { get; }

		/// <summary>
		/// Value of variable $SAVE_TASKS
		/// </summary>
		public int SaveTasks { get; }

		/// <summary>
		/// Value of variable $SAVE_D_CPU
		/// </summary>
		public int SaveDCpu { get; }

		/// <summary>
		/// Value of variable $SAVE_D_SIZ
		/// </summary>
		public int SaveDSiz { get; }

		/// <summary>
		/// Value of variable $SAVE_D_ADD
		/// </summary>
		public int SaveDAdd { get; }

		/// <summary>
		/// Value of variable $FILE_OUT
		/// </summary>
		public bool FileOut { get; }

		/// <summary>
		/// Value of variable $FILE_NAME
		/// </summary>
		public string FileName { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
