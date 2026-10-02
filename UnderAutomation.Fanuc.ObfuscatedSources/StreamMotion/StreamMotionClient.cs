//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.StreamMotion.Internal;

namespace UnderAutomation.Fanuc.StreamMotion {
	/// <summary>
	/// Stream Motion client for standalone use (J519 option): real-time control of the robot by sending a position every communication cycle.
	/// </summary>
	public class StreamMotionClient : StreamMotionClientBase, IDisposable {

		/// <summary>
		/// Creates a new Stream Motion client
		/// </summary>
		public StreamMotionClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to the robot. Call <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.StartMonitoring"/> next to receive the robot status.
		/// </summary>
		/// <param name="ip">IP address of the robot</param>
		/// <param name="parameters">Connection parameters. Default values are used when null.</param>
		public void Connect(string ip, StreamMotionConnectParametersBase parameters = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
