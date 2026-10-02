//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.Common {
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

		/// <summary>
		/// Convert position to a homogeneous rotation and translation 4x4 matrix
		/// </summary>
		public double[,] ToHomogeneousMatrix()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the orientation W, P, R as a quaternion
		/// </summary>
		public Quaternion GetQuaternion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the orientation W, P, R from a quaternion. Angles are between -180 and 180 degrees.
		/// </summary>
		/// <param name="quaternion">Orientation</param>
		public void SetQuaternion(Quaternion quaternion)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns the composition of this frame with another one: the pose <code class="paramref">other</code>, expressed in this frame, converted to the frame where this position is expressed.
		/// </summary>
		/// <param name="other">Pose expressed in this frame</param>
		public XYZWPRPosition Multiply(XYZWPRPosition other)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the inverse of this frame
		/// </summary>
		public XYZWPRPosition Inverse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a flange position to the position of the tool center point (TCP)
		/// </summary>
		/// <param name="tool">Tool frame, relative to the flange (for example a UTOOL value)</param>
		public XYZWPRPosition FlangeToTcp(XYZWPRPosition tool)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a position of the tool center point (TCP) to the flange position
		/// </summary>
		/// <param name="tool">Tool frame, relative to the flange (for example a UTOOL value)</param>
		public XYZWPRPosition TcpToFlange(XYZWPRPosition tool)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts this position, expressed in a user frame, to the world frame
		/// </summary>
		/// <param name="userFrame">User frame, relative to the world frame (for example a UFRAME value)</param>
		public XYZWPRPosition UserFrameToWorld(XYZWPRPosition userFrame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts this position, expressed in the world frame, to a user frame
		/// </summary>
		/// <param name="userFrame">User frame, relative to the world frame (for example a UFRAME value)</param>
		public XYZWPRPosition WorldToUserFrame(XYZWPRPosition userFrame)
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
