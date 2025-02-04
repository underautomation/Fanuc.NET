//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace License {
	/// <summary>
	/// Exception thrown while using the product if the license is not valid.
	/// </summary>
	public class InvalidLicenseException : Exception, ISerializable {

		/// <summary>
		/// The license that causes this exception
		/// </summary>
		public LicenseInfo LicenseInfo { get; }
	}
}
