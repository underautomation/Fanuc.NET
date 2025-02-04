//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file httpkcl.va
	/// </summary>
	public class HttpkclFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public HttpkclFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable CMDS
		/// </summary>
		public string[] Cmds { get; }

		/// <summary>
		/// Value of variable URL
		/// </summary>
		public string Url { get; }

		/// <summary>
		/// Value of variable NEWCMD
		/// </summary>
		public string Newcmd { get; }

		/// <summary>
		/// Value of variable FIRST_TOKEN
		/// </summary>
		public string FirstToken { get; }

		/// <summary>
		/// Value of variable STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable FOUND
		/// </summary>
		public bool Found { get; }

		/// <summary>
		/// Value of variable ILL_FLG
		/// </summary>
		public bool IllFlg { get; }

		/// <summary>
		/// Value of variable I
		/// </summary>
		public int I { get; }
	}
}
