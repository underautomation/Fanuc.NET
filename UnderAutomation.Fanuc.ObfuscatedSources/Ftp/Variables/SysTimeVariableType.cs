//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SYS_TIME_T
	/// </summary>
	public class SysTimeVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MINUTE
		/// </summary>
		public int Minute { get; }

		/// <summary>
		/// Value of variable $HOUR
		/// </summary>
		public int Hour { get; }

		/// <summary>
		/// Value of variable $DAY
		/// </summary>
		public int Day { get; }

		/// <summary>
		/// Value of variable $MONTH
		/// </summary>
		public int Month { get; }

		/// <summary>
		/// Value of variable $DOW
		/// </summary>
		public int Dow { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
