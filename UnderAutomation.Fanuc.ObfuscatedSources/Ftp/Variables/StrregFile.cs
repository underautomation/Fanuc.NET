//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file strreg.va
	/// </summary>
	public class StrregFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $STRREG
		/// </summary>
		public string[] Strreg { get; }

		/// <summary>
		/// Value of variable $MAXSREGNUM
		/// </summary>
		public int Maxsregnum { get; }
	}
}
