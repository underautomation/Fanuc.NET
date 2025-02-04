//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file bicsetup.va
	/// </summary>
	public class BicsetupFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable BIC_NAME
		/// </summary>
		public string BicName { get; }
	}
}
