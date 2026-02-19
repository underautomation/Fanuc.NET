//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Represents a single task's state.
	/// </summary>
	public class TaskState {


		public override string ToString()
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


		public TaskState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Task number.
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// Task name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Current execution status of the task.
		/// </summary>
		public TaskStatus Status { get; set; }

		/// <summary>
		/// Call stack history frames for the task.
		/// </summary>
		public TaskHistoryData[] History { get; set; }
	}
}
