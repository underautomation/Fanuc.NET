//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Represents the execution state of a robot task.
	/// </summary>
	public enum RobotTaskState {

		/// <summary>
		/// Task is stopped.
		/// </summary>
		Stopped = 0,

		/// <summary>
		/// Task is paused.
		/// </summary>
		Paused = 1,

		/// <summary>
		/// Task is running.
		/// </summary>
		Running = 2,
	}
}
