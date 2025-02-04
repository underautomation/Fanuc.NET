//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Fanuc cartesian position and rotations
	/// </summary>
	public class CartesianPosition : XYZPosition {


		public CartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// W rotation in degrees
		/// </summary>
		public double W { get; set; }

		/// <summary>
		/// P rotation in degrees
		/// </summary>
		public double P { get; set; }

		/// <summary>
		/// R rotation in degrees
		/// </summary>
		public double R { get; set; }

		/// <summary>
		/// Position configuration
		/// </summary>
		public Configuration Configuration { get; }
	}
}
