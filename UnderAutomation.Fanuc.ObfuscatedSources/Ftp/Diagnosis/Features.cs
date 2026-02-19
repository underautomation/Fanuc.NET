//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Diagnosis {
	/// <summary>
	/// Represents the collection of features available on the controller.
	/// </summary>
	public class Features {


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


		public Features()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// List of features
		/// </summary>
		public Feature[] FeaturesList { get; }

		/// <summary>
		/// Indicates if the robot has the TELNET feature enabled (TELN).
		/// </summary>
		public bool HasTelnet { get; }

		/// <summary>
		/// Indicates if the robot has the SNPX feature enabled (R553 or R651).
		/// </summary>
		public bool HasSnpx { get; }

		/// <summary>
		/// Indicates if the robot has the ASCII upload feature enabled : R507 ("ASCII Upload" on older controllers) or R796 ("ASCII Program Loader" on most recent controllers).
		/// </summary>
		public bool HasAsciiUpload { get; }
	}
}
