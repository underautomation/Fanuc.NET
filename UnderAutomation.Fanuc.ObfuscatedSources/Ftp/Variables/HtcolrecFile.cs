//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file htcolrec.va
	/// </summary>
	public class HtcolrecFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public HtcolrecFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable COL_REC
		/// </summary>
		public bool ColRec { get; }

		/// <summary>
		/// Value of variable COL_RECOV
		/// </summary>
		public AutoColRecVariableType ColRecov { get; }

		/// <summary>
		/// Value of variable COL_DBG
		/// </summary>
		public bool ColDbg { get; }

		/// <summary>
		/// Value of variable ABORT_DELAY
		/// </summary>
		public int AbortDelay { get; }
	}
}
