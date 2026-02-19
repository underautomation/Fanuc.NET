//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Kinematics {
	/// <summary>
	/// Category of kinematics model for a robot arm.
	/// </summary>
	public enum KinematicsCategory {

		/// <summary>
		/// Invalid or unsupported kinematics configuration.
		/// </summary>
		Invalid = 0,

		/// <summary>
		/// CRX collaborative robot kinematics.
		/// </summary>
		Crx = 1,

		/// <summary>
		/// OPW (ortho-parallel wrist) kinematics for standard industrial robots.
		/// </summary>
		Opw = 2,
	}
}
