//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.IO {
	/// <summary>
	/// Digital signal of a robot controller, identified by a group and an index.
	/// The names of the groups and the valid indexes depend on the robot.
	/// </summary>
	public class DigitalSignal {

		/// <summary>
		/// Creates a digital signal
		/// </summary>
		/// <param name="group">Group of the signal, as defined by the robot</param>
		/// <param name="index">Index of the signal in its group</param>
		public DigitalSignal(string group, int index)
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
		/// Group of the signal, as defined by the robot
		/// </summary>
		public string Group { get; }

		/// <summary>
		/// Index of the signal in its group
		/// </summary>
		public int Index { get; }
	}
}
