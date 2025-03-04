//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Telnet {

	public class TaskInformationResult : Result {

		/// <summary>
		/// Parses the result data and populates the properties of the class.
		/// </summary>
		/// <param name="data">The result data as a string.</param>
		/// <returns>True if parsing is successful; otherwise, false.</returns>
		protected override bool FromResult(string data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public TaskInformationResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the name of the task.
		/// </summary>
		public string TaskName { get; }

		/// <summary>
		/// Gets the task number.
		/// </summary>
		public int TaskNumber { get; }

		/// <summary>
		/// Gets the task status as a string.
		/// </summary>
		public string TaskStatusStr { get; }

		/// <summary>
		/// Gets the task status.
		/// </summary>
		public TaskStatus TaskStatus { get; }

		/// <summary>
		/// Gets the name of the routine.
		/// </summary>
		public string RoutineName { get; }

		/// <summary>
		/// Gets the current line number.
		/// </summary>
		public int CurrentLine { get; }

		/// <summary>
		/// Gets the type of the program.
		/// </summary>
		public ProgramType ProgramType { get; }

		/// <summary>
		/// Gets the hold conditions.
		/// </summary>
		public string HoldConditions { get; }

		/// <summary>
		/// Gets a value indicating whether the task is invisible.
		/// </summary>
		public bool InvisibleTask { get; }

		/// <summary>
		/// Gets a value indicating whether the task is a system task.
		/// </summary>
		public bool SystemTask { get; }
	}
}
