//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.Ftp.Internal {
	/// <summary>
	/// Parameters to connect to Fanuc controller FTP server
	/// </summary>
	public class FtpConnectParametersBase {


		public FtpConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// FTP user. The rights depend on the user and on the password settings of the controller: for example, without a user
		/// the controller logs in at the OPERATOR level and can refuse the upload of a program.
		/// </summary>
		public string FtpUser { get; set; }

		/// <summary>
		/// FTP password associated to the user
		/// </summary>
		public string FtpPassword { get; set; }

		/// <summary>
		/// FTP connection timeout in milliseconds, default : 30000 (30 seconds)
		/// </summary>
		public int FtpTimeoutMs { get; set; }
	}
}
