//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Represents a Cartesian position variable parsed from a Fanuc variable file
	/// </summary>
	public class CartesianPositionVariable : CartesianPosition {

		/// <summary>
		/// Default constructor
		/// </summary>
		public CartesianPositionVariable()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a Cartesian position variable from Cartesian position values and a motion group number.
		/// </summary>
		/// <param name="group">Motion group number</param>
		/// <param name="position">Cartesian position values</param>
		public CartesianPositionVariable(int group, CartesianPosition position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Parses a Cartesian position from its string representation
		/// </summary>
		public static CartesianPositionVariable Parse(string value)
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
