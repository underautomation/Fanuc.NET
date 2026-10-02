//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Robotics.IO;

namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Digital signal change requested at a given time of a trajectory
	/// </summary>
	public class IOEvent {

		/// <summary>
		/// Creates an I/O event
		/// </summary>
		/// <param name="time">Time from the start of the trajectory, in seconds</param>
		/// <param name="signal">Signal to write</param>
		/// <param name="value">Value to write</param>
		public IOEvent(double time, DigitalSignal signal, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


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

		/// <summary>
		/// Time from the start of the trajectory, in seconds
		/// </summary>
		public double Time { get; }

		/// <summary>
		/// Signal to write
		/// </summary>
		public DigitalSignal Signal { get; }

		/// <summary>
		/// Value to write
		/// </summary>
		public bool Value { get; }
	}
}
