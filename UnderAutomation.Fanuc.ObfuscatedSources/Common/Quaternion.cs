//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Quaternion that represents an orientation (Qw + Qx.i + Qy.j + Qz.k).
	/// Use <xref href="UnderAutomation.Fanuc.Common.XYZWPRPosition.GetQuaternion" data-throw-if-not-resolved="false"></xref> and <xref href="UnderAutomation.Fanuc.Common.XYZWPRPosition.SetQuaternion(UnderAutomation.Fanuc.Common.Quaternion)" data-throw-if-not-resolved="false"></xref> to convert from and to W, P, R angles.
	/// </summary>
	public class Quaternion {

		/// <summary>
		/// Creates the identity quaternion (no rotation)
		/// </summary>
		public Quaternion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a quaternion from its components
		/// </summary>
		/// <param name="qw">Scalar part</param>
		/// <param name="qx">X component of the vector part</param>
		/// <param name="qy">Y component of the vector part</param>
		/// <param name="qz">Z component of the vector part</param>
		public Quaternion(double qw, double qx, double qy, double qz)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns this quaternion with a norm of 1
		/// </summary>
		public Quaternion Normalize()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the conjugate of this quaternion. For a rotation, it is the inverse rotation.
		/// </summary>
		public Quaternion Conjugate()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the product this x other: the rotation other applied after the rotation this, in the frame of this.
		/// </summary>
		/// <param name="other">Right operand</param>
		public Quaternion Multiply(Quaternion other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Dot product of the two quaternions
		/// </summary>
		/// <param name="other">Other quaternion</param>
		public double Dot(Quaternion other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Angle of the rotation between the two orientations, in degrees (0 to 180)
		/// </summary>
		/// <param name="other">Other orientation</param>
		public double AngleTo(Quaternion other)
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
		public static Quaternion Slerp(Quaternion start, Quaternion end, double t)
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
		public static Quaternion FromAxisAngle(double x, double y, double z, double angle)
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
		/// Creates a quaternion from a rotation matrix (3x3, or 4x4 homogeneous matrix)
		/// </summary>
		/// <param name="matrix">Rotation matrix</param>
		public static Quaternion FromRotationMatrix(double[,] matrix)
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
		/// Scalar part
		/// </summary>
		public double Qw { get; set; }

		/// <summary>
		/// X component of the vector part
		/// </summary>
		public double Qx { get; set; }

		/// <summary>
		/// Y component of the vector part
		/// </summary>
		public double Qy { get; set; }

		/// <summary>
		/// Z component of the vector part
		/// </summary>
		public double Qz { get; set; }

		/// <summary>
		/// Norm of the quaternion (1 for a rotation)
		/// </summary>
		public double Norm { get; }
	}
}
