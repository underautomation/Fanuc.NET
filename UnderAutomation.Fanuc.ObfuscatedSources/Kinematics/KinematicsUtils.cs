//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Kinematics {
	/// <summary>
	/// Kinematics utilities
	/// </summary>
	public static class KinematicsUtils {

		/// <summary>
		/// Compute FK for given joint angles (deg) and DH parameters
		/// </summary>
		public static CartesianPosition ForwardKinematics(JointsPosition jointAnglesDeg, DhParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Compute FK for given joint angles (rad) and DH parameters
		/// </summary>
		public static CartesianPosition ForwardKinematics(double[] jointAnglesRad, DhParameters dhParameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Compute all inverse kinematics solutions for a desired end effector pose.
		/// </summary>
		/// <param name="position">Target Cartesian position.</param>
		/// <param name="parameters">DH parameters of the robot.</param>
		/// <returns>An array of joint angle solutions.</returns>
		public static JointsPosition[] InverseKinematics(CartesianPosition position, DhParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Multiply two 4x4 homogeneous transformation matrices.
		/// </summary>
		/// <param name="A">Left matrix.</param>
		/// <param name="B">Right matrix.</param>
		/// <returns>The product matrix A * B.</returns>
		public static double[,] Mul(double[,] A, double[,] B)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
