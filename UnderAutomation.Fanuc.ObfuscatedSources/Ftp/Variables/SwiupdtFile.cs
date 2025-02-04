//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file swiupdt.va
	/// </summary>
	public class SwiupdtFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public SwiupdtFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable RUN_ONCE
		/// </summary>
		public int RunOnce { get; }
	}
}
