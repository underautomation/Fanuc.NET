//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace License {
	/// <summary>
	/// States that can take a license
	/// </summary>
	public enum LicenseState {

		/// <summary>
		/// No license has been provided
		/// </summary>
		None = -1,

		/// <summary>
		/// The pair License Identifier and License Key are incompatible, you cannot use the library
		/// </summary>
		Invalid = 0,

		/// <summary>
		/// The library is in a trial period, you can use the library
		/// </summary>
		Trial = 1,

		/// <summary>
		/// The library is in an extra trial period, you can use the library
		/// </summary>
		ExtraTrial = 2,

		/// <summary>
		/// The trial period as expired, you no more can use the library
		/// </summary>
		Expired = 3,

		/// <summary>
		/// Your license does not allow you to use such a recent release. Please buy maintenance to use this version
		/// </summary>
		MaintenanceNeeded = 4,

		/// <summary>
		/// Congratulations, the library is licensed.
		/// </summary>
		Licensed = 5,
	}
}
