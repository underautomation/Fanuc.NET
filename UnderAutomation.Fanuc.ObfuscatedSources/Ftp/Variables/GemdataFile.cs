//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file gemdata.va
	/// </summary>
	public class GemdataFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public GemdataFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable ANSWER_DELAY
		/// </summary>
		public int AnswerDelay { get; }

		/// <summary>
		/// Value of variable DEBUG_MSG
		/// </summary>
		public bool DebugMsg { get; }

		/// <summary>
		/// Value of variable WAIT_ACT
		/// </summary>
		public int WaitAct { get; }

		/// <summary>
		/// Value of variable WAIT_TIME
		/// </summary>
		public int WaitTime { get; }
	}
}
