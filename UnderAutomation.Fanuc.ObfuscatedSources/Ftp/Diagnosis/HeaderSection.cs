//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Diagnosis {
	/// <summary>
	/// Header information of a diagnostic file
	/// </summary>
	public class HeaderSection {

		/// <summary>
		/// Failsafe number
		/// </summary>
		public string FNumber { get; }

		/// <summary>
		/// COntroller version
		/// </summary>
		public string Version { get; }

		/// <summary>
		/// Firmware version
		/// </summary>
		public string VersionFirmware { get; }

		/// <summary>
		/// Firmawre release date
		/// </summary>
		public DateTime VersionDate { get; }

		/// <summary>
		/// Current controller time
		/// </summary>
		public DateTime Date { get; }
	}
}
