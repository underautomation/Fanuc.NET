//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Fanuc cartesian position and rotations
	/// </summary>
	public class CartesianPosition : XYZPosition {

		/// <summary>
		/// Default constructor
		/// </summary>
		public CartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructor with position and rotations
		/// </summary>
		public CartesianPosition(double x, double y, double z, double w, double p, double r)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public CartesianPosition(double x, double y, double z, double w, double p, double r, Configuration configuration)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public CartesianPosition(XYZPosition position, double w, double p, double r)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public CartesianPosition(CartesianPosition position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Convert position to a homogeneous rotation and translation 4x4 matrix
		/// </summary>
		public double[,] ToHomogeneousMatrix()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Create a CartesianPosition with unknow configuration from a homogeneous rotation and translation 4x4 matrix
		/// </summary>
		/// <param name="R">Homogeneous 4x4 matrix</param>
		public static CartesianPosition FromHomogeneousMatrix(double[,] R)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Normalize an angle to the range ]-180, 180]
		/// </summary>
		public static double NormalizeAngle(double angle)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Normalize the W, P, R angles to the range ]-180, 180]
		/// </summary>
		public static void NormalizeAngles(CartesianPosition pose)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Check if two Cartesian positions are near each other within specified tolerances
		/// </summary>
		public static bool IsNear(CartesianPosition a, CartesianPosition b, double mmTolerance, double degreesTolerance)
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

		/// <summary>
		/// Position configuration
		/// </summary>
		public Configuration Configuration { get; }
	}
}
