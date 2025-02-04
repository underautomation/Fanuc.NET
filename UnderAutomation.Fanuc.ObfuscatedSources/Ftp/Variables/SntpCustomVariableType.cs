//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SNTP_CUSTOM_
	/// </summary>
	public class SntpCustomVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $START_MONTH
		/// </summary>
		public int StartMonth { get; }

		/// <summary>
		/// Value of variable $START_DATE
		/// </summary>
		public int StartDate { get; }

		/// <summary>
		/// Value of variable $START_HOUR
		/// </summary>
		public int StartHour { get; }

		/// <summary>
		/// Value of variable $END_MONTH
		/// </summary>
		public int EndMonth { get; }

		/// <summary>
		/// Value of variable $END_DATE
		/// </summary>
		public int EndDate { get; }

		/// <summary>
		/// Value of variable $END_HOUR
		/// </summary>
		public int EndHour { get; }

		/// <summary>
		/// Value of variable $LOCAL_TIME
		/// </summary>
		public bool LocalTime { get; }

		/// <summary>
		/// Value of variable $NORTH_HEM
		/// </summary>
		public bool NorthHem { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
