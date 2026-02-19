//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;

namespace Snpx.Internal {
	/// <summary>
	/// Represents a robot alarm with its category, severity, time, and message.
	/// </summary>
	public class RobotAlarm : IEquatable<RobotAlarm> {

		/// <summary>
		/// Creates a <xref href="UnderAutomation.Fanuc.Snpx.Internal.RobotAlarm" data-throw-if-not-resolved="false"></xref> from a byte array.
		/// </summary>
		/// <param name="bytes">The byte array containing alarm data.</param>
		/// <param name="language">The controller language for string decoding.</param>
		/// <param name="start">The starting offset in the byte array.</param>
		/// <returns>A <xref href="UnderAutomation.Fanuc.Snpx.Internal.RobotAlarm" data-throw-if-not-resolved="false"></xref> parsed from the byte data, or null if bytes is null.</returns>
		public static RobotAlarm FromBytes(byte[] bytes, Languages language, int start = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the specified <xref href="UnderAutomation.Fanuc.Snpx.Internal.RobotAlarm" data-throw-if-not-resolved="false"></xref> is equal to this instance.
		/// </summary>
		/// <param name="other">The alarm to compare with.</param>
		/// <returns>true if the alarms are equal; otherwise, false.</returns>
		public bool Equals(RobotAlarm other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
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
