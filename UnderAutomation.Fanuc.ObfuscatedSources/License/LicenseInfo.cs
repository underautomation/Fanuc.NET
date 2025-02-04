//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace License {
	/// <summary>
	/// Information about a license key
	/// </summary>
	public sealed class LicenseInfo {

		/// <summary>
		/// Create a new LicenseInfo instance to retrieve informations about a pair of identifier/key
		/// This class should not be used to register your product. Please use static function RegisterLicense to specify your license.
		/// </summary>
		/// <param name="licenseIdentifier">The name of your organization (null for trial version)</param>
		/// <param name="licenseKey">The key, associated to the identifier, supplied by UnderAutomation (null for trial version)</param>
		public LicenseInfo(string licenseIdentifier, string licenseKey)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// A human description of the license
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// The license key supplied by UnderAutomation (null for trial period)
		/// </summary>
		public string LicenseKey { get; }

		/// <summary>
		/// Commercial name of this .NET Software library
		/// </summary>
		public string Product { get; }

		/// <summary>
		/// Remaining days of the trial period. Null if the product is licensed. It could be negative if the trial period is ended since several days.
		/// </summary>
		public int? EvaluationDaysLeft { get; }

		/// <summary>
		/// The date the trial period starts. If the product is licensed, the date of the library first use.
		/// </summary>
		public DateTime EvaluationStartDate { get; }

		/// <summary>
		/// Name of your organisation
		/// </summary>
		public string Licensee { get; }

		/// <summary>
		/// The date the product will expire. Null if the product is licensed.
		/// </summary>
		public DateTime? TrialPeriodExpirationDate { get; }

		/// <summary>
		/// The current license state
		/// </summary>
		public LicenseState State { get; }

		/// <summary>
		/// The date this version of the product was released.
		/// </summary>
		public DateTime ProductReleaseDate { get; }

		/// <summary>
		/// Number of maintenance years included in your license
		/// </summary>
		public int MaintenanceYears { get; }

		/// <summary>
		/// The date you get the license
		/// </summary>
		public DateTime? LicenseIssuedDate { get; }

		/// <summary>
		/// The date your maintenance contract end and you no longer can use this license with newer versions.
		/// </summary>
		public DateTime? MaintenanceExpirationDate { get; }
	}
}
