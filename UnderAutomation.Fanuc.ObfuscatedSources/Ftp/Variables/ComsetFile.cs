//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file comset.va
	/// </summary>
	public class ComsetFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public ComsetFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable SEARCHCASE
		/// </summary>
		public bool Searchcase { get; }

		/// <summary>
		/// Value of variable IFC
		/// </summary>
		public int Ifc { get; }

		/// <summary>
		/// Value of variable URL
		/// </summary>
		public string Url { get; }

		/// <summary>
		/// Value of variable RESPFILE
		/// </summary>
		public string Respfile { get; }

		/// <summary>
		/// Value of variable SCOMMENT
		/// </summary>
		public string Scomment { get; }

		/// <summary>
		/// Value of variable SINDX
		/// </summary>
		public string Sindx { get; }

		/// <summary>
		/// Value of variable SREALFLAG
		/// </summary>
		public string Srealflag { get; }

		/// <summary>
		/// Value of variable SFC
		/// </summary>
		public string Sfc { get; }

		/// <summary>
		/// Value of variable SVALUE
		/// </summary>
		public string Svalue { get; }

		/// <summary>
		/// Value of variable SCOPYSTR
		/// </summary>
		public string Scopystr { get; }

		/// <summary>
		/// Value of variable N_STATUS
		/// </summary>
		public int NStatus { get; }

		/// <summary>
		/// Value of variable ICOMMENT_LEN
		/// </summary>
		public int IcommentLen { get; }

		/// <summary>
		/// Value of variable IRETSIZE
		/// </summary>
		public int Iretsize { get; }

		/// <summary>
		/// Value of variable FRVRC
		/// </summary>
		public bool Frvrc { get; }

		/// <summary>
		/// Value of variable SEARCHFILE
		/// </summary>
		public string Searchfile { get; }

		/// <summary>
		/// Value of variable SEARCHCANCEL
		/// </summary>
		public bool Searchcancel { get; }

		/// <summary>
		/// Value of variable REG_ALMFC
		/// </summary>
		public int RegAlmfc { get; }

		/// <summary>
		/// Value of variable PREG_ALMFC
		/// </summary>
		public int PregAlmfc { get; }

		/// <summary>
		/// Value of variable DI_ALMFC
		/// </summary>
		public int DiAlmfc { get; }

		/// <summary>
		/// Value of variable DO_ALMFC
		/// </summary>
		public int DoAlmfc { get; }

		/// <summary>
		/// Value of variable FLAG_ALMFC
		/// </summary>
		public int FlagAlmfc { get; }
	}
}
