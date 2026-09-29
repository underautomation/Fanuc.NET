//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace StreamMotion.Data {
	/// <summary>
	/// Arguments of the SetpointRequested event.
	/// Call <xref href="UnderAutomation.Fanuc.StreamMotion.Data.SetpointRequestEventArgs.SetJoints(UnderAutomation.Fanuc.Common.JointsPosition)" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.Fanuc.StreamMotion.Data.SetpointRequestEventArgs.SetCartesian(UnderAutomation.Fanuc.Common.XYZWPRPosition)" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.Fanuc.StreamMotion.Data.SetpointRequestEventArgs.Hold" data-throw-if-not-resolved="false"></xref> to give the next position to send.
	/// The object is only valid during the call of the event handler.
	/// </summary>
	public class SetpointRequestEventArgs : EventArgs {

		/// <summary>
		/// Gives the next joint position to send. The callback streaming must be in joint format.
		/// </summary>
		/// <param name="position">Joint position in degrees (mm for linear axes)</param>
		public void SetJoints(JointsPosition position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gives the next Cartesian position to send (flange center in the world frame). The callback streaming must be in Cartesian format.
		/// Extended axes values are used when the position is an <xref href="UnderAutomation.Fanuc.Common.ExtendedCartesianPosition" data-throw-if-not-resolved="false"></xref>, otherwise they are 0.
		/// </summary>
		/// <param name="position">Cartesian position</param>
		public void SetCartesian(XYZWPRPosition position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Keeps the last position. If the robot is moving, it stops smoothly.
		/// </summary>
		public void Hold()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Last status received from the robot
		/// </summary>
		public StreamMotionStatus Status { get; }

		/// <summary>
		/// Index of the requested position since the start of the callback streaming (starts at 0)
		/// </summary>
		public long CycleIndex { get; }

		/// <summary>
		/// Time of the requested position since the start of the callback streaming, in seconds (CycleIndex x cycle time)
		/// </summary>
		public double Time { get; }
	}
}
