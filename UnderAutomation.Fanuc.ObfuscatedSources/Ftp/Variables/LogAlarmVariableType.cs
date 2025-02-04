//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type LOG_ALARM_T
	/// </summary>
	public class LogAlarmVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ALM_CODE
		/// </summary>
		public int AlmCode { get; }

		/// <summary>
		/// Value of variable $ALM_NUMBER
		/// </summary>
		public int AlmNumber { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
