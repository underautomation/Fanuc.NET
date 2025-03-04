//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Represents a single task's state.
	/// </summary>
	public class TaskState {


		public TaskState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public int Number { get; set; }


		public string Name { get; set; }


		public TaskStatus Status { get; set; }


		public TaskHistoryData[] History { get; set; }
	}
}
