//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file numreg.va
	/// </summary>
	public class NumregFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $NUMREG
		/// </summary>
		public double[] Numreg { get; }

		/// <summary>
		/// Value of variable $MAXREGNUM
		/// </summary>
		public int Maxregnum { get; }
	}
}
