//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Geometry {
	/// <summary>
	/// Orientation in space, stored as a unit quaternion (Qw + Qx.i + Qy.j + Qz.k).
	/// It can be created from and converted to Euler angles, a rotation vector, an axis and an angle, or a rotation matrix.
	/// </summary>
	public sealed class Orientation {

		/// <summary>
		/// Creates the identity orientation (no rotation)
		/// </summary>
		public Orientation()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates an orientation from a quaternion. The quaternion is normalized.
		/// </summary>
		/// <param name="qw">Scalar part</param>
		/// <param name="qx">X component of the vector part</param>
		/// <param name="qy">Y component of the vector part</param>
		/// <param name="qz">Z component of the vector part</param>
		public static Orientation FromQuaternion(double qw, double qx, double qy, double qz)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates an orientation from three Euler angles
		/// </summary>
		/// <param name="a">First angle in degrees</param>
		/// <param name="b">Second angle in degrees</param>
		/// <param name="c">Third angle in degrees</param>
		/// <param name="convention">Convention of the angles</param>
		public static Orientation FromEuler(double a, double b, double c, EulerConvention convention)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the three Euler angles [a, b, c] of this orientation, in degrees.
		/// For <see cref="UnderAutomation.Robotics.Geometry.EulerConvention.MobileZYZ"/>, b is between 0 and 180. For the other conventions, b is between -90 and 90.
		/// When the orientation is singular (b = 0 or 180 for ZYZ, b = -90 or 90 for the others), only a combination of a and c is defined:
		/// a is set to 0 for <see cref="UnderAutomation.Robotics.Geometry.EulerConvention.FixedXYZ"/>, and c is set to 0 for the other conventions.
		/// </summary>
		/// <param name="convention">Convention of the angles</param>
		public double[] ToEuler(EulerConvention convention)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a rotation around an axis
		/// </summary>
		/// <param name="x">X component of the axis</param>
		/// <param name="y">Y component of the axis</param>
		/// <param name="z">Z component of the axis</param>
		/// <param name="angle">Rotation angle in degrees</param>
		public static Orientation FromAxisAngle(double x, double y, double z, double angle)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the rotation axis and angle: [x, y, z, angle in degrees]. The axis is a unit vector and the angle is between 0 and 180.
		/// </summary>
		public double[] ToAxisAngle()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates an orientation from a rotation vector: its direction is the rotation axis and its norm is the angle in degrees
		/// </summary>
		/// <param name="x">X component</param>
		/// <param name="y">Y component</param>
		/// <param name="z">Z component</param>
		public static Orientation FromRotationVector(double x, double y, double z)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the rotation vector [x, y, z] of this orientation: its direction is the rotation axis and its norm is the angle in degrees (0 to 180)
		/// </summary>
		public double[] ToRotationVector()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates an orientation from a rotation matrix (3x3, or 4x4 homogeneous matrix)
		/// </summary>
		/// <param name="matrix">Rotation matrix</param>
		public static Orientation FromRotationMatrix(double[,] matrix)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the 3x3 rotation matrix of this orientation
		/// </summary>
		public double[,] ToRotationMatrix()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the composition this x other: the orientation <code class="paramref">other</code>, expressed in the frame of this orientation, converted to the reference frame
		/// </summary>
		/// <param name="other">Right operand</param>
		public Orientation Multiply(Orientation other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the inverse rotation
		/// </summary>
		public Orientation Inverse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Angle of the rotation between the two orientations, in degrees (0 to 180)
		/// </summary>
		/// <param name="other">Other orientation</param>
		public double AngleTo(Orientation other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Spherical linear interpolation between two orientations, on the shortest way
		/// </summary>
		/// <param name="start">Orientation for t = 0</param>
		/// <param name="end">Orientation for t = 1</param>
		/// <param name="t">Interpolation parameter, usually between 0 and 1</param>
		public static Orientation Slerp(Orientation start, Orientation end, double t)
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
		/// Two orientations are equal when their quaternions are equal or opposite (q and -q give the same orientation)
		/// </summary>
		/// <param name="obj">Other object</param>
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
		/// Scalar part of the unit quaternion
		/// </summary>
		public double Qw { get; }

		/// <summary>
		/// X component of the vector part of the unit quaternion
		/// </summary>
		public double Qx { get; }

		/// <summary>
		/// Y component of the vector part of the unit quaternion
		/// </summary>
		public double Qy { get; }

		/// <summary>
		/// Z component of the vector part of the unit quaternion
		/// </summary>
		public double Qz { get; }
	}
}
