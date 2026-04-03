//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common.Files;
using System.IO;
using Cgtp;

namespace Cgtp.Internal {
	/// <summary>
	/// Provides methods to download and list files from the controller via HTTP.
	/// </summary>
	public class CgtpHttpClient : FileClientBase {

		/// <summary>
		/// Download a file from the controller and return its raw bytes.
		/// </summary>
		public byte[] DownloadAsBytes(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Download a file from the controller and return its content as a string.
		/// </summary>
		public string DownloadAsString(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Download a file from the controller and return a readable stream.
		/// Otherwise the raw binary response is returned.
		/// </summary>
		public Stream DownloadAsStream(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// List variable files available on the controller.
		/// </summary>
		public CgtpAsciiFileItem[] ListVariableFiles()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// List TP program files available on the controller.
		/// </summary>
		public CgtpAsciiFileItem[] ListTpPrograms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// List diagnostic and error files available on the controller.
		/// </summary>
		public CgtpFileItem[] ListDiagnosticFiles()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// List other files available on the controller.
		/// </summary>
		public CgtpFileItem[] ListOtherFiles()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the list of all variable file names available on the controller
		/// </summary>
		public override string[] EnumerateVariableFileNames()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// IP address of the controller
		/// </summary>
		public override string IP => default;

		/// <summary>
		/// Base path used to build the download URL. Default is "MD".
		/// </summary>
		public string BasePath { get; set; }
	}
}
