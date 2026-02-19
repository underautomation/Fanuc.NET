//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Snpx.Internal {
	/// <summary>
	/// Provides access to robot alarms (active or historical) via SNPX.
	/// </summary>
	public class AlarmAccess : SnpxAssignableElements<RobotAlarm, int> {


		protected override string GetAssignmentName(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected override RobotAlarm ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
