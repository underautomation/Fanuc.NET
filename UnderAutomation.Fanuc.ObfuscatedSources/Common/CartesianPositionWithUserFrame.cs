//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// A cartesian tool position with a user frame ID
	/// </summary>
	public class CartesianPositionWithUserFrame : CartesianPositionWithTool {

		/// <summary>
		/// Default constructor
		/// </summary>
		public CartesianPositionWithUserFrame()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructor with position, rotations, tool and frame IDs
		/// </summary>
		public CartesianPositionWithUserFrame(double x, double y, double z, double w, double p, double r, int tool, int frame)
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
		/// Frame ID in the controller
		/// </summary>
		public int Frame { get; }
	}
}
