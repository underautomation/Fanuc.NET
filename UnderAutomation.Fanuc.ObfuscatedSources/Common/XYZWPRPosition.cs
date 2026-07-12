//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Cartesian position X, Y, Z with W, P, R rotations
	/// </summary>
	public class XYZWPRPosition : XYZPosition {

		/// <summary>
		/// Default constructor
		/// </summary>
		public XYZWPRPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructor with position and rotations
		/// </summary>
		public XYZWPRPosition(double x, double y, double z, double w, double p, double r)
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
		/// W rotation in degrees (Rx)
		/// </summary>
		public double W { get; set; }

		/// <summary>
		/// P rotation in degrees (Ry)
		/// </summary>
		public double P { get; set; }

		/// <summary>
		/// R rotation in degrees (Rz)
		/// </summary>
		public double R { get; set; }
	}
}
