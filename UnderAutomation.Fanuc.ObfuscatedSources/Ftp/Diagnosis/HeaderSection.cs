//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Diagnosis {
	/// <summary>
	/// Header information of a diagnostic file
	/// </summary>
	public class HeaderSection {


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


		public HeaderSection()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Failsafe number
		/// </summary>
		public string FNumber { get; }

		/// <summary>
		/// Controller version
		/// </summary>
		public string Version { get; }

		/// <summary>
		/// Firmware version
		/// </summary>
		public string VersionFirmware { get; }

		/// <summary>
		/// Firmware release date
		/// </summary>
		public DateTime VersionDate { get; }

		/// <summary>
		/// Current controller time
		/// </summary>
		public DateTime Date { get; }
	}
}
