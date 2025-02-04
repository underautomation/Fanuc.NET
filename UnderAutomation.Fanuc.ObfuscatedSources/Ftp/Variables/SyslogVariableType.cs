//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SYSLOG_T
	/// </summary>
	public class SyslogVariableType : GenericVariableType, IGenericVariableType {


		public SyslogVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $SIZE
		/// </summary>
		public int Size { get; }

		/// <summary>
		/// Value of variable $MODE
		/// </summary>
		public int Mode { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable $ADDRESS
		/// </summary>
		public int Address { get; }

		/// <summary>
		/// Value of variable $DATA_SIZE
		/// </summary>
		public int DataSize { get; }

		/// <summary>
		/// Value of variable $COMP_VALUE
		/// </summary>
		public int CompValue { get; }

		/// <summary>
		/// Value of variable $STOP_MODE
		/// </summary>
		public int StopMode { get; }

		/// <summary>
		/// Value of variable $CURR_VALUE
		/// </summary>
		public int CurrValue { get; }

		/// <summary>
		/// Value of variable $FLOG_ID_LO
		/// </summary>
		public int FlogIdLo { get; }

		/// <summary>
		/// Value of variable $FLOG_ID_HI
		/// </summary>
		public int FlogIdHi { get; }

		/// <summary>
		/// Value of variable $FLOG_ID_IN
		/// </summary>
		public bool FlogIdIn { get; }

		/// <summary>
		/// Value of variable $FILE_OUT
		/// </summary>
		public bool FileOut { get; }

		/// <summary>
		/// Value of variable $FILE_NAME
		/// </summary>
		public string FileName { get; }

		/// <summary>
		/// Value of variable $ID
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
