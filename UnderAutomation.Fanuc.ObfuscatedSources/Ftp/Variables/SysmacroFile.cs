//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file sysmacro.va
	/// </summary>
	public class SysmacroFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public SysmacroFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MACROLDUIMT
		/// </summary>
		public bool Macrolduimt { get; }

		/// <summary>
		/// Value of variable $MACROMAXDRI
		/// </summary>
		public int Macromaxdri { get; }

		/// <summary>
		/// Value of variable $MACROTABLE
		/// </summary>
		public MnMcrTableVariableType[] Macrotable { get; }

		/// <summary>
		/// Value of variable $MACRO_MAXNU
		/// </summary>
		public int MacroMaxnu { get; }

		/// <summary>
		/// Value of variable $MACRSOPENBL
		/// </summary>
		public MnMcrSopVariableType Macrsopenbl { get; }

		/// <summary>
		/// Value of variable $MACRSPDIMSK
		/// </summary>
		public int Macrspdimsk { get; }

		/// <summary>
		/// Value of variable $MACRSPSUMSK
		/// </summary>
		public int Macrspsumsk { get; }

		/// <summary>
		/// Value of variable $MACRTPDSBEX
		/// </summary>
		public bool Macrtpdsbex { get; }

		/// <summary>
		/// Value of variable $MACRUOPENBL
		/// </summary>
		public MnMcrUopVariableType Macruopenbl { get; }
	}
}
