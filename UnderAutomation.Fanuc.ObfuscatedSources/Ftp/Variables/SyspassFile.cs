//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file syspass.va
	/// </summary>
	public class SyspassFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $PASSNAME
		/// </summary>
		public PassnameVariableType[] Passname { get; }

		/// <summary>
		/// Value of variable $PASSSUPER
		/// </summary>
		public PassnameVariableType Passsuper { get; }

		/// <summary>
		/// Value of variable $PASSWORD
		/// </summary>
		public PasswordVariableType Password { get; }
	}
}
