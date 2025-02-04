//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file palreg.va
	/// </summary>
	public class PalregFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public PalregFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $PALREGNUM
		/// </summary>
		public int Palregnum { get; }

		/// <summary>
		/// Value of variable $PALREG
		/// </summary>
		public byte[] Palreg { get; }
	}
}
