//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Represents a position register that can hold either a Cartesian or joint position
	/// </summary>
	public class PositionRegister {

		/// <summary>
		/// Default constructor
		/// </summary>
		public PositionRegister()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a position register from joint and Cartesian position values
		/// </summary>
		public PositionRegister(JointPositionVariable jointsPosition, CartesianPositionVariable cartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Parses a position register from its string representation
		/// </summary>
		public static PositionRegister Parse(string value)
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
		/// Joint position value, if available
		/// </summary>
		public JointPositionVariable JointsPosition { get; set; }

		/// <summary>
		/// Cartesian position value, if available
		/// </summary>
		public CartesianPositionVariable CartesianPosition { get; set; }
	}
}
