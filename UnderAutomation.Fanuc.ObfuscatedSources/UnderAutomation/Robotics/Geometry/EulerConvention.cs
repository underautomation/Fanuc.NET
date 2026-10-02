//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Geometry {
	/// <summary>
	/// Convention of three Euler angles (a, b, c) that describe an orientation. Angles are in degrees.
	/// </summary>
	public enum EulerConvention {

		/// <summary>
		/// Rotation a around the fixed X axis, then b around the fixed Y axis, then c around the fixed Z axis: R = Rz(c) * Ry(b) * Rx(a).
		/// </summary>
		FixedXYZ = 0,

		/// <summary>
		/// Rotation a around X, then b around the new Y axis, then c around the new Z axis: R = Rx(a) * Ry(b) * Rz(c).
		/// </summary>
		MobileXYZ = 1,

		/// <summary>
		/// Rotation a around Z, then b around the new Y axis, then c around the new X axis: R = Rz(a) * Ry(b) * Rx(c).
		/// It is the same orientation as <see cref="UnderAutomation.Robotics.Geometry.EulerConvention.FixedXYZ"/> with the angles in reverse order.
		/// </summary>
		MobileZYX = 2,

		/// <summary>
		/// Rotation a around Z, then b around the new Y axis, then c around the new Z axis: R = Rz(a) * Ry(b) * Rz(c).
		/// </summary>
		MobileZYZ = 3,
	}
}
