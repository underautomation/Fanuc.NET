//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Termination of a motion: stop at the target, overlap with the next motion, or corner region of a given size
	/// </summary>
	public class Termination {

		/// <summary>
		/// The robot stops at the target position
		/// </summary>
		public static Termination Stop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// The next motion starts during the deceleration of this one
		/// </summary>
		/// <param name="percent">From 0 to 100: part of the deceleration during which both motions are combined. 100 gives the smoothest motion.</param>
		public static Termination Overlap(double percent)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Corner region: the corner is replaced by a smooth curve at constant speed. Only between Cartesian motions.
		/// </summary>
		/// <param name="distance">Distance from the target position where the curve starts and ends, in mm. It is limited to half of the length of each motion.</param>
		public static Termination Corner(double distance)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
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
		/// Type of termination
		/// </summary>
		public TerminationType Type { get; }

		/// <summary>
		/// Overlap in percent (0 to 100), or corner distance in mm. 0 for a stop.
		/// </summary>
		public double Value { get; }
	}
}
