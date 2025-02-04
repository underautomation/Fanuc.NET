//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {
	/// <summary>
	/// Represents the status of a task.
	/// </summary>
	public enum TaskStatus {

		/// <summary>
		/// The task status is unknown.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The task is running.
		/// </summary>
		Running = 1,

		/// <summary>
		/// The task is paused.
		/// </summary>
		Paused = 2,

		/// <summary>
		/// The task is aborted.
		/// </summary>
		Aborted = 3,
	}
}
