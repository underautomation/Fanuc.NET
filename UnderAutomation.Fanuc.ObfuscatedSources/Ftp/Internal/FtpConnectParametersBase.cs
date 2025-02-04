//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Internal {
	/// <summary>
	/// Parameters to connect to Fanuc controller FTP server
	/// </summary>
	public class FtpConnectParametersBase {

		/// <summary>
		/// FTP user
		/// </summary>
		public string FtpUser { get; set; }

		/// <summary>
		/// FTP password associated to the user
		/// </summary>
		public string FtpPassword { get; set; }
	}
}
