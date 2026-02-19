//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Represents one frame in the task's call stack.
	/// </summary>
	public class TaskHistoryData {


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


		public TaskHistoryData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Depth of the routine in the call stack.
		/// </summary>
		public int RoutineDepth { get; set; }

		/// <summary>
		/// Name of the routine.
		/// </summary>
		public string RoutineName { get; set; }

		/// <summary>
		/// Line number currently being executed.
		/// </summary>
		public int LineNumber { get; set; }

		/// <summary>
		/// Name of the program containing the routine.
		/// </summary>
		public string ProgramName { get; set; }

		/// <summary>
		/// Type of the program (TP, Karel, etc.).
		/// </summary>
		public ProgramType ProgramType { get; set; }
	}
}
