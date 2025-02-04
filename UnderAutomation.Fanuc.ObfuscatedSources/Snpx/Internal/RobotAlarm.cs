//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Snpx.Internal {

	public class RobotAlarm : IEquatable<RobotAlarm> {


		public AlarmCategory Category { get; set; }


		public short Number { get; set; }


		public AlarmCategory CauseCategory { get; set; }


		public short CauseNumber { get; set; }


		public AlarmSeverity Severity { get; set; }


		public DateTime Time { get; set; }


		public static RobotAlarm FromBytes(byte[] bytes, int start = 0)
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
	}
}
