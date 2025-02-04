//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file cellio.va
	/// </summary>
	public class CellioFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public CellioFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CELL_OPTION
		/// </summary>
		public bool CellOption { get; }

		/// <summary>
		/// Value of variable $CELL_SETUP
		/// </summary>
		public CellsetVariableType CellSetup { get; }

		/// <summary>
		/// Value of variable $CLMLIO
		/// </summary>
		public ClmlioVariableType[] Clmlio { get; }

		/// <summary>
		/// Value of variable $STYLE_COMNT
		/// </summary>
		public string[] StyleComnt { get; }

		/// <summary>
		/// Value of variable $STYLE_COUNT
		/// </summary>
		public int StyleCount { get; }

		/// <summary>
		/// Value of variable $STYLE_ENAB
		/// </summary>
		public bool[] StyleEnab { get; }

		/// <summary>
		/// Value of variable $STYLE_MENU
		/// </summary>
		public int StyleMenu { get; }

		/// <summary>
		/// Value of variable $STYLE_NAME
		/// </summary>
		public string[] StyleName { get; }
	}
}
