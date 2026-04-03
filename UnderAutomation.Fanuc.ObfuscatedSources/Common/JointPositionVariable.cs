//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Represents a joint position variable parsed from a Fanuc variable file
	/// </summary>
	public class JointPositionVariable : JointsPosition {

		/// <summary>
		/// Default constructor.
		/// </summary>
		public JointPositionVariable()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a joint position variable from a group number and joint position values.
		/// </summary>
		/// <param name="group">Motion group number.</param>
		/// <param name="position">Joint position values to copy.</param>
		public JointPositionVariable(int group, JointsPosition position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Parses a joint position from its string representation
		/// </summary>
		public static JointPositionVariable Parse(string value)
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
		/// Motion group number
		/// </summary>
		public int Group { get; set; }
	}
}
