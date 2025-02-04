//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file sysfsac.va
	/// </summary>
	public class SysfsacFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public SysfsacFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $FSAC_DEF_LV
		/// </summary>
		public int FsacDefLv { get; }

		/// <summary>
		/// Value of variable $FSAC_ENABLE
		/// </summary>
		public int FsacEnable { get; }

		/// <summary>
		/// Value of variable $FSAC_LIST
		/// </summary>
		public FsacLstVariableType[] FsacList { get; }
	}
}
