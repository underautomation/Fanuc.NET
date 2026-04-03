//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Cgtp {
	/// <summary>
	/// Data types that can be returned when reading a controller variable.
	/// </summary>
	public enum CgtpVariableType {

		/// <summary>
		/// Cartesian position (X, Y, Z, W, P, R with configuration).
		/// </summary>
		CartesianPosition = 2,

		/// <summary>
		/// Joint position (J1..J9).
		/// </summary>
		JointPosition = 9,

		/// <summary>
		/// 32-bit integer value.
		/// </summary>
		Integer = 16,

		/// <summary>
		/// Double-precision floating-point value.
		/// </summary>
		Real = 17,

		/// <summary>
		/// Boolean value (TRUE or FALSE).
		/// </summary>
		Boolean = 18,

		/// <summary>
		/// 3D vector (X, Y, Z).
		/// </summary>
		Vector = 19,

		/// <summary>
		/// 16-bit short integer value.
		/// </summary>
		Short = 23,

		/// <summary>
		/// 8-bit byte value.
		/// </summary>
		Byte = 24,

		/// <summary>
		/// Robot configuration string.
		/// </summary>
		Config = 28,

		/// <summary>
		/// Numeric value that can be either integer or real.
		/// </summary>
		Numeric = 38,

		/// <summary>
		/// XYZWPR position type.
		/// </summary>
		XYZWPR = 256,

		/// <summary>
		/// Full position type.
		/// </summary>
		POSITION = 257,

		/// <summary>
		/// Extended XYZWPR position with additional axes.
		/// </summary>
		XYZWPRExt = 262,

		/// <summary>
		/// String value. The actual type code encodes the maximum string length.
		/// </summary>
		String = 7936,

		/// <summary>
		/// Joint position with up to 9 axes.
		/// </summary>
		JointPose9 = 8601,
	}
}
