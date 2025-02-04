//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file sysframe.va
	/// </summary>
	public class SysframeFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public SysframeFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CELL_FLOOR
		/// </summary>
		public CartesianPositionVariable CellFloor { get; }

		/// <summary>
		/// Value of variable $CELL_GRP
		/// </summary>
		public CellGrpVariableType[] CellGrp { get; }

		/// <summary>
		/// Value of variable $MNUFRAME
		/// </summary>
		public CartesianPositionVariable[,] Mnuframe { get; }

		/// <summary>
		/// Value of variable $MNUFRAMENUM
		/// </summary>
		public byte[] Mnuframenum { get; }

		/// <summary>
		/// Value of variable $MNUTOOL
		/// </summary>
		public CartesianPositionVariable[,] Mnutool { get; }

		/// <summary>
		/// Value of variable $MNUTOOLNUM
		/// </summary>
		public byte[] Mnutoolnum { get; }
	}
}
