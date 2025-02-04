//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file posreg.va
	/// </summary>
	public class PosregFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $POSREG
		/// </summary>
		public CartesianPositionVariable[,] Posreg { get; }

		/// <summary>
		/// Value of variable $MAXPREGNUM
		/// </summary>
		public int Maxpregnum { get; }
	}
}
