//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file mixlogic.va
	/// </summary>
	public class MixlogicFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $DRYRUN
		/// </summary>
		public DryrunVariableType Dryrun { get; }

		/// <summary>
		/// Value of variable $DRYRUN_PORT
		/// </summary>
		public DryrunPortVariableType[] DryrunPort { get; }

		/// <summary>
		/// Value of variable $DRYRUN_SUB
		/// </summary>
		public string[] DryrunSub { get; }

		/// <summary>
		/// Value of variable $MIX_BG
		/// </summary>
		public MixBgVariableType[] MixBg { get; }

		/// <summary>
		/// Value of variable $MIX_LOGIC
		/// </summary>
		public MixLogicVariableType MixLogic { get; }

		/// <summary>
		/// Value of variable $MIX_MKR
		/// </summary>
		public MixMkrVariableType[] MixMkr { get; }

		/// <summary>
		/// Value of variable $ON_PATH
		/// </summary>
		public OnPathVariableType OnPath { get; }
	}
}
