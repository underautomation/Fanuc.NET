//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Robot position with joints and cartesian representations
	/// </summary>
	public class Position {

		/// <summary>
		/// Default constructor
		/// </summary>
		public Position()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructor with user frame, tool, joints and cartesian position
		/// </summary>
		public Position(short userFrame, short userTool, JointsPosition jointsPosition, ExtendedCartesianPosition cartesianPosition)
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
		/// User frame index
		/// </summary>
		public short UserFrame { get; set; }

		/// <summary>
		/// User tool index
		/// </summary>
		public short UserTool { get; set; }

		/// <summary>
		/// Joint values in degrees
		/// </summary>
		public JointsPosition JointsPosition { get; set; }

		/// <summary>
		/// Cartesian position with extended axes
		/// </summary>
		public ExtendedCartesianPosition CartesianPosition { get; set; }
	}
}
