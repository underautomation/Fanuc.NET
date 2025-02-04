//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file sysservo.va
	/// </summary>
	public class SysservoFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public SysservoFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $SBR
		/// </summary>
		public SbrVariableType[] Sbr { get; }

		/// <summary>
		/// Value of variable $SBR2
		/// </summary>
		public Sbr2VariableType[] Sbr2 { get; }
	}
}
