//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Kinematics {
	/// <summary>
	/// Interface defining the Denavit-Hartenberg parameters for a 6-axis robot arm.
	/// </summary>
	public interface IDhParameters {

		/// <summary>
		/// DH parameter D4 (mm).
		/// </summary>
		double D4 { get; }

		/// <summary>
		/// DH parameter D5 (mm).
		/// </summary>
		double D5 { get; }

		/// <summary>
		/// DH parameter D6 (mm).
		/// </summary>
		double D6 { get; }

		/// <summary>
		/// DH parameter A1 (mm).
		/// </summary>
		double A1 { get; }

		/// <summary>
		/// DH parameter A2 (mm).
		/// </summary>
		double A2 { get; }

		/// <summary>
		/// DH parameter A3 (mm).
		/// </summary>
		double A3 { get; }
	}
}
