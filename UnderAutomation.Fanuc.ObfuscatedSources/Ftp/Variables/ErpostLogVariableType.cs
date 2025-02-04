//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ERPOST_LOG_T
	/// </summary>
	public class ErpostLogVariableType : GenericVariableType, IGenericVariableType {


		public ErpostLogVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $LOG_ENB
		/// </summary>
		public int LogEnb { get; }

		/// <summary>
		/// Value of variable $LOG_COUNT
		/// </summary>
		public int LogCount { get; }

		/// <summary>
		/// Value of variable $ALM_LIST
		/// </summary>
		public LogAlarmVariableType[] AlmList { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
