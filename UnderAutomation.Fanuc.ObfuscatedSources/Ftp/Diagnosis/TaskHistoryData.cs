//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Represents one frame in the task's call stack.
	/// </summary>
	public class TaskHistoryData {


		public TaskHistoryData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public int RoutineDepth { get; set; }


		public string RoutineName { get; set; }


		public int LineNumber { get; set; }


		public string ProgramName { get; set; }


		public ProgramType ProgramType { get; set; }
	}
}
