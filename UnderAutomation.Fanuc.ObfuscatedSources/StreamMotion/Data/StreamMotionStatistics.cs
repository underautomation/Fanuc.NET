//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.StreamMotion.Data {
	/// <summary>
	/// Communication statistics of a Stream Motion client, since the status output was started
	/// </summary>
	public class StreamMotionStatistics {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Number of status received from the robot
		/// </summary>
		public long StatusCount { get; }

		/// <summary>
		/// Number of status sent by the robot but not received (detected with the sequence numbers)
		/// </summary>
		public long LostStatusCount { get; }

		/// <summary>
		/// Number of positions sent to the robot
		/// </summary>
		public long CommandCount { get; }

		/// <summary>
		/// Number of extra positions sent to fill the robot buffer again after lost or late status
		/// </summary>
		public long CatchUpCommandCount { get; }

		/// <summary>
		/// Number of times the queue became empty while the robot was moving
		/// </summary>
		public long UnderrunCount { get; }

		/// <summary>
		/// Estimated number of positions waiting in the robot buffer
		/// </summary>
		public int EstimatedBufferLevel { get; }

		/// <summary>
		/// Mean time between two received status, measured with the PC clock, in seconds
		/// </summary>
		public double MeanStatusInterval { get; }

		/// <summary>
		/// Maximum time between two received status, measured with the PC clock, in seconds
		/// </summary>
		public double MaxStatusInterval { get; }

		/// <summary>
		/// Maximum time spent to process a status and send the positions, in seconds
		/// </summary>
		public double MaxProcessingTime { get; }
	}
}
