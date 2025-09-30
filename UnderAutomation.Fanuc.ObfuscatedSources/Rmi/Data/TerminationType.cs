//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Termination type for motion.
	/// </summary>
	public enum TerminationType {

		/// <summary>
		/// FINE termination; precise stop.
		/// </summary>
		Fine = 0,

		/// <summary>
		/// Continuous termination; blend motions (1-100).
		/// </summary>
		Cnt = 1,

		/// <summary>
		/// Constant path mode (requires option).
		/// </summary>
		Cr = 2,
	}
}
