//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;

namespace Snpx.Internal {

	public class RobotAlarm : IEquatable<RobotAlarm> {


		public static RobotAlarm FromBytes(byte[] bytes, Languages language, int start = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public bool Equals(RobotAlarm other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RobotAlarm()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Alarm Category
		/// </summary>
		public AlarmId Id { get; set; }

		/// <summary>
		/// Alarm Number
		/// </summary>
		public short Number { get; set; }

		/// <summary>
		/// Cause Category
		/// </summary>
		public AlarmId CauseId { get; set; }

		/// <summary>
		/// Cause Number
		/// </summary>
		public short CauseNumber { get; set; }

		/// <summary>
		/// Alarm Severity
		/// </summary>
		public AlarmSeverity Severity { get; set; }

		/// <summary>
		/// Occurrence Time
		/// </summary>
		public DateTime Time { get; set; }

		/// <summary>
		/// Error Message
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Cause message
		/// </summary>
		public string CauseMessage { get; set; }

		/// <summary>
		/// Severity message
		/// </summary>
		public string SeverityMessage { get; set; }
	}
}
