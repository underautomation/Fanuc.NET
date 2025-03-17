//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;
using Ftp;

namespace Ftp.Internal {
	/// <summary>
	/// Methods to handle files on a Fanuc controller (upload, download, delete, enumerate, ...)
	/// </summary>
	public class FtpDirectFileHandling {

		/// <summary>
		/// Delegate to track upload progress. The value provided is in the range 0 to 100
		/// </summary>
		/// <param name="progress">The value provided is in the range 0 to 100</param>
		public delegate void OnProgressDelegate(double progress);

		/// <summary>
		/// Uploads the specified stream as a file onto the controller.
		/// High-level API that takes care of various edge cases internally.
		/// Supports very large files since it uploads data in chunks.
		/// It overwrites file if it already exists.
		/// </summary>
		/// <param name="fileStream">The full data of the file, as a stream</param>
		/// <param name="remotePath">The full or relative path to the file on the controller</param>
		/// <param name="createRemoteDir">Create the remote directory if it does not exist. Slows down upload due to additional checks required.</param>
		/// <param name="progress">Track upload progress. The value provided is in the range 0 to 100, indicating the percentage of the file transferred. If the progress is indeterminate, -1 is sent.</param>
		public bool UploadFileToController(Stream fileStream, string remotePath, bool createRemoteDir = false, FtpDirectFileHandling.OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads the specified byte array as a file onto the controller.
		/// High-level API that takes care of various edge cases internally.
		/// Supports very large files since it uploads data in chunks.
		/// It overwrites file if it already exists.
		/// </summary>
		/// <param name="fileData">The full data of the file, as a byte array</param>
		/// <param name="remotePath">The full or relative path to the file on the controller</param>
		/// <param name="createRemoteDir">Create the remote directory if it does not exist. Slows down upload due to additional checks required.</param>
		/// <param name="progress">Track upload progress. The value provided is in the range 0 to 100, indicating the percentage of the file transferred. If the progress is indeterminate, -1 is sent.</param>
		public bool UploadFileToController(byte[] fileData, string remotePath, bool createRemoteDir = false, FtpDirectFileHandling.OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads the specified file directly onto the controller.
		/// High-level API that takes care of various edge cases internally.
		/// Supports very large files since it uploads data in chunks.
		/// </summary>
		/// <param name="localPath">The full or relative path to the file on the local file system</param>
		/// <param name="remotePath">The full or relative path to the file on the controller</param>
		/// <param name="createRemoteDir">Create the remote directory if it does not exist. Slows down upload due to additional checks required.</param>
		/// <param name="progress">Track upload progress. The value provided is in the range 0 to 100, indicating the percentage of the file transferred. If the progress is indeterminate, -1 is sent.</param>
		/// <returns>If true then the file was uploaded, false otherwise.</returns>
		public bool UploadFileToController(string localPath, string remotePath, bool createRemoteDir = false, FtpDirectFileHandling.OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads the given file paths to a single folder on the controller.
		/// All files are placed directly into the given folder regardless of their path on the local filesystem.
		/// High-level API that takes care of various edge cases internally.
		/// Supports very large files since it uploads data in chunks.
		/// </summary>
		/// <param name="localPaths">The full or relative paths to the files on the local file system. Files can be from multiple folders.</param>
		/// <param name="remoteDir">The full or relative path to the directory that files will be uploaded on the controller</param>
		/// <returns>The list of files that were uploaded successfully</returns>
		public string[] UploadFilesToController(string[] localPaths, string remoteDir)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads the specified file and return the raw byte array.
		/// High-level API that takes care of various edge cases internally.
		/// Supports very large files since it downloads data in chunks.
		/// </summary>
		/// <param name="outBytes">The variable that will receive the bytes.</param>
		/// <param name="remotePath">The full or relative path to the file on the controller</param>
		/// <param name="progress">Track download progress. The value provided is in the range 0 to 100, indicating the percentage of the file transferred. If the progress is indeterminate, -1 is sent.</param>
		/// <returns>If true then the file was downloaded, false otherwise.</returns>
		public bool DownloadFileFromController(out byte[] outBytes, string remotePath, FtpDirectFileHandling.OnProgressDelegate progress = null)
		{
			outBytes = default;
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads the specified file into the specified stream.
		/// High-level API that takes care of various edge cases internally.
		/// Supports very large files since it downloads data in chunks.
		/// </summary>
		/// <param name="outStream">The stream that the file will be written to. Provide a new MemoryStream if you only want to read the file into memory.</param>
		/// <param name="remotePath">The full or relative path to the file on the controller</param>
		/// <param name="progress">Track download progress. The value provided is in the range 0 to 100, indicating the percentage of the file transferred. If the progress is indeterminate, -1 is sent.</param>
		/// <returns>If true then the file was downloaded, false otherwise.</returns>
		public bool DownloadFileFromController(Stream outStream, string remotePath, FtpDirectFileHandling.OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads the specified file onto the local file system.
		/// High-level API that takes care of various edge cases internally.
		/// Supports very large files since it downloads data in chunks.
		/// It overwrites the file if it already exists.
		/// </summary>
		/// <param name="localPath">The full or relative path to the file on the local file system</param>
		/// <param name="remotePath">The full or relative path to the file on the controller</param>
		/// <param name="progress">Provide an implementation of IProgress to track download progress. The value provided is in the range 0 to 100, indicating the percentage of the file transferred. If the progress is indeterminate, -1 is sent.</param>
		/// <returns>If true then the file was downloaded, false otherwise.</returns>
		public bool DownloadFileFromController(string localPath, string remotePath, FtpDirectFileHandling.OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads the specified files into a local single directory.
		/// High-level API that takes care of various edge cases internally.
		/// Supports very large files since it downloads data in chunks.
		/// </summary>
		/// <param name="localDir">The full or relative path to the directory that files will be downloaded into.</param>
		/// <param name="remotePaths">The full paths to the files on the controller</param>
		/// <returns>The list of all local files downloaded</returns>
		public string[] DownloadFilesFromController(string localDir, string[] remotePaths)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks if a file exists on the controller.
		/// </summary>
		/// <param name="path">The full or relative path to the file</param>
		/// <returns>True if the file exists</returns>
		public bool FileExists(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tests if the specified directory exists on the controller. This
		/// method works by trying to change the working directory to
		/// the path specified. If it succeeds, the directory is changed
		/// back to the old working directory and true is returned. False
		/// is returned otherwise and since the CWD failed it is assumed
		/// the working directory is still the same.
		/// </summary>
		/// <param name="path">The path of the directory</param>
		/// <returns>True if it exists, false otherwise.</returns>
		public bool DirectoryExists(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a directory on the controller. If the preceding
		/// directories do not exist, then they are created.
		/// </summary>
		/// <param name="path">The full or relative path to the new remote directory</param>
		public void CreateDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes the specified directory and all its contents.
		/// </summary>
		/// <param name="path">The full or relative path of the directory to delete</param>
		public void DeleteDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes a file on the controller
		/// </summary>
		/// <param name="path">The full or relative path to the file</param>
		public void DeleteFile(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets a file listing from the controller. Each <xref href="UnderAutomation.Fanuc.Ftp.FtpListItem" data-throw-if-not-resolved="false"></xref> object returned
		/// contains information about the file that was able to be retrieved.
		/// </summary>
		/// <param name="path">The path of the directory to list</param>
		/// <returns>An array of FtpListItem objects</returns>
		public FtpListItem[] GetListing(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns information about a file system object. Returns null if the controller response can't
		/// be parsed or the controller returns a failure completion code. The error for a failure
		/// is logged with FtpTrace. No exception is thrown on error because that would negate
		/// the usefulness of this method for checking for the existence of an object.
		/// </summary>
		/// <param name="path">The path of the file or folder</param>
		/// <returns>A FtpListItem object</returns>
		public FtpListItem GetObjectInfo(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Renames an object on the remote file system.
		/// Throws exceptions if the file does not exist, or if the destination file already exists.
		/// </summary>
		/// <param name="path">The full or relative path to the object</param>
		/// <param name="dest">The new full or relative path including the new name of the object</param>
		public void Rename(string path, string dest)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
