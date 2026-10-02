//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.StreamMotion {
	/// <summary>
	/// Kind of Stream Motion error
	/// </summary>
	public enum StreamMotionError {

		/// <summary>
		/// The client is not connected
		/// </summary>
		NotConnected = 0,

		/// <summary>
		/// The robot status output is not started (call StartMonitoring)
		/// </summary>
		NotMonitoring = 1,

		/// <summary>
		/// No status was received from the robot
		/// </summary>
		NoStatus = 2,

		/// <summary>
		/// The robot uses another protocol version than the one requested
		/// </summary>
		VersionMismatch = 3,

		/// <summary>
		/// The operation is not allowed while a session is active
		/// </summary>
		SessionActive = 4,

		/// <summary>
		/// Another source of positions is active
		/// </summary>
		SourceBusy = 5,

		/// <summary>
		/// The position format does not match the format of the session. A session uses only one format:
		/// call <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.Finish(System.Int32)"/> and use the other format in the next session.
		/// </summary>
		FormatMismatch = 6,

		/// <summary>
		/// The trajectory was sampled with a period that is not the communication cycle of the robot
		/// </summary>
		CycleTimeMismatch = 7,

		/// <summary>
		/// The first position of the trajectory is too far from the position where it starts
		/// </summary>
		StartMismatch = 8,

		/// <summary>
		/// The robot did not send its limits
		/// </summary>
		LimitsUnavailable = 9,

		/// <summary>
		/// The session ended before the end of the operation
		/// </summary>
		SessionEnded = 10,

		/// <summary>
		/// The callback did not give a position
		/// </summary>
		CallbackFailed = 11,

		/// <summary>
		/// Error during the communication with the robot
		/// </summary>
		CommunicationError = 12,

		/// <summary>
		/// The target tracking is not started (call StartTracking)
		/// </summary>
		NotTracking = 13,
	}
}
