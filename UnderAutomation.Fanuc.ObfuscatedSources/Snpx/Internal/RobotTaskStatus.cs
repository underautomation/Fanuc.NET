//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;

namespace Snpx.Internal {
	/// <summary>
	/// Represents the status of a running task on the robot controller.
	/// </summary>
	public class RobotTaskStatus : IEquatable<RobotTaskStatus> {

		/// <summary>
		/// Determines whether the specified <xref href="UnderAutomation.Fanuc.Snpx.Internal.RobotTaskStatus" data-throw-if-not-resolved="false"></xref> is equal to this instance.
		/// </summary>
		/// <param name="other">The task status to compare with.</param>
		/// <returns>true if the task statuses are equal; otherwise, false.</returns>
		public bool Equals(RobotTaskStatus other)
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

		/// <summary>
		/// Creates a <xref href="UnderAutomation.Fanuc.Snpx.Internal.RobotTaskStatus" data-throw-if-not-resolved="false"></xref> from a byte array.
		/// </summary>
		/// <param name="bytes">The byte array containing task status data.</param>
		/// <param name="language">The controller language for string decoding.</param>
		/// <param name="start">The starting offset in the byte array.</param>
		/// <returns>A <xref href="UnderAutomation.Fanuc.Snpx.Internal.RobotTaskStatus" data-throw-if-not-resolved="false"></xref> parsed from the byte data, or null if bytes is null.</returns>
		public static RobotTaskStatus FromBytes(byte[] bytes, Languages language, int start = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RobotTaskStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the name of the program being executed.
		/// </summary>
		public string ProgramName { get; set; }

		/// <summary>
		/// Gets or sets the current line number in the program.
		/// </summary>
		public short LineNumber { get; set; }

		/// <summary>
		/// Gets or sets the current execution state of the task.
		/// </summary>
		public RobotTaskState State { get; set; }

		/// <summary>
		/// Gets or sets the name of the calling program.
		/// </summary>
		public string Caller { get; set; }
	}
}
