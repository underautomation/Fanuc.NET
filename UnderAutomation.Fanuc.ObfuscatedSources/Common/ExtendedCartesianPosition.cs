//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Cartesian position with extended axes (E1, E2, E3)
	/// </summary>
	public class ExtendedCartesianPosition : CartesianPosition {

		/// <summary>
		/// Default constructor
		/// </summary>
		public ExtendedCartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructor with position, rotations, and extended axes
		/// </summary>
		public ExtendedCartesianPosition(double x, double y, double z, double w, double p, double r, double e1, double e2, double e3)
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
		/// Extended axis 1 value
		/// </summary>
		public double E1 { get; set; }

		/// <summary>
		/// Extended axis 2 value
		/// </summary>
		public double E2 { get; set; }

		/// <summary>
		/// Extended axis 3 value
		/// </summary>
		public double E3 { get; set; }
	}
}
