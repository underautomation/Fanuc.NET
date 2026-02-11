//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file posreg.va
	/// </summary>
	public class PosregFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public PosregFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $POSREG
		/// </summary>
		public PositionRegister[,] Posreg { get; }

		/// <summary>
		/// Value of variable $MAXPREGNUM
		/// </summary>
		public int Maxpregnum { get; }
	}
}
