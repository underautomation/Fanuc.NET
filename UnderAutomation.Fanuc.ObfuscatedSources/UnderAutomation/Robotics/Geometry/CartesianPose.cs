//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Geometry {
	/// <summary>
	/// Cartesian pose: position X, Y, Z in mm, orientation, and optional values of external axes (mm or degrees).
	/// It can describe a position of the robot or a frame.
	/// </summary>
	public class CartesianPose {

		/// <summary>
		/// Creates a pose at the origin, without rotation and without external axes
		/// </summary>
		public CartesianPose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a pose from a position and an orientation, without external axes
		/// </summary>
		/// <param name="x">X in mm</param>
		/// <param name="y">Y in mm</param>
		/// <param name="z">Z in mm</param>
		/// <param name="orientation">Orientation (null for no rotation)</param>
		public CartesianPose(double x, double y, double z, Orientation orientation)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a pose from a position and three Euler angles, without external axes
		/// </summary>
		/// <param name="x">X in mm</param>
		/// <param name="y">Y in mm</param>
		/// <param name="z">Z in mm</param>
		/// <param name="a">First angle in degrees</param>
		/// <param name="b">Second angle in degrees</param>
		/// <param name="c">Third angle in degrees</param>
		/// <param name="convention">Convention of the angles</param>
		public static CartesianPose FromEuler(double x, double y, double z, double a, double b, double c, EulerConvention convention)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the composition of this frame with another pose: the pose <code class="paramref">other</code>, expressed in this frame, converted to the frame where this pose is expressed.
		/// The external axes of the result are the ones of <code class="paramref">other</code>.
		/// </summary>
		/// <param name="other">Pose expressed in this frame</param>
		public CartesianPose Multiply(CartesianPose other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the inverse of this frame. The result has no external axes.
		/// </summary>
		public CartesianPose Inverse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// X in mm
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Y in mm
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Z in mm
		/// </summary>
		public double Z { get; set; }

		/// <summary>
		/// Orientation. Setting null gives the identity orientation.
		/// </summary>
		public Orientation Orientation { get; set; }

		/// <summary>
		/// Values of the external axes, in mm or degrees. Empty when the pose has no external axes. Setting null gives an empty array.
		/// </summary>
		public double[] ExternalAxes { get; set; }
	}
}
