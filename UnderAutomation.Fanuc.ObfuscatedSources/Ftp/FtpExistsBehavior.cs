//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp {
	/// <summary>
	/// Defines the behavior for handling files that already exist
	/// </summary>
	public enum FtpExistsBehavior {

		/// <summary>
		/// Do not check if the file exists. A bit faster than the other options. Only use this if you are SURE that the file does not exist on the server.
		/// Otherwise it can cause the UploadFile method to hang due to filesize mismatch.
		/// </summary>
		NoCheck = 0,

		/// <summary>
		/// Skip the file if it exists, without any more checks.
		/// </summary>
		Skip = 1,

		/// <summary>
		/// Overwrite the file if it exists.
		/// </summary>
		Overwrite = 2,

		/// <summary>
		/// Append to the file if it exists, by checking the length and adding the missing data.
		/// </summary>
		Append = 3,

		/// <summary>
		/// Append to the file, but don't check if it exists and add missing data.   This might be required if you don't have permissions on the server to list files in the folder.
		/// Only use this if you are SURE that the file does not exist on the server otherwise it can cause the UploadFile method to hang due to filesize mismatch.
		/// </summary>
		AppendNoCheck = 4,
	}
}
