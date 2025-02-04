//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;
using System.IO;

namespace Ftp.Variables {

	public class VariableReader : FileReader<GenericVariableFile>, IFileReader<GenericVariableFile>, IFileReader {


		public static readonly VariableReader<AavmmainFile> AavmmainFile;


		public static readonly VariableReader<BicsetupFile> BicsetupFile;


		public static readonly VariableReader<CbparamFile> CbparamFile;


		public static readonly VariableReader<CellioFile> CellioFile;


		public static readonly VariableReader<ComsetFile> ComsetFile;


		public static readonly VariableReader<DiocfgsvFile> DiocfgsvFile;


		public static readonly VariableReader<GemdataFile> GemdataFile;


		public static readonly VariableReader<HtcolrecFile> HtcolrecFile;


		public static readonly VariableReader<HttpkclFile> HttpkclFile;


		public static readonly VariableReader<IrcCounterFile> IrcCounterFile;


		public static readonly VariableReader<IrcMsgFile> IrcMsgFile;


		public static readonly VariableReader<IrcStatusFile> IrcStatusFile;


		public static readonly VariableReader<IrcStlabelFile> IrcStlabelFile;


		public static readonly VariableReader<KlactionFile> KlactionFile;


		public static readonly VariableReader<MixlogicFile> MixlogicFile;


		public static readonly VariableReader<MtparamFile> MtparamFile;


		public static readonly VariableReader<NumregFile> NumregFile;


		public static readonly VariableReader<PalregFile> PalregFile;


		public static readonly VariableReader<PosregFile> PosregFile;


		public static readonly VariableReader<StrregFile> StrregFile;


		public static readonly VariableReader<SwiupdtFile> SwiupdtFile;


		public static readonly VariableReader<SycldintFile> SycldintFile;


		public static readonly VariableReader<SymotnFile> SymotnFile;


		public static readonly VariableReader<SynosaveFile> SynosaveFile;


		public static readonly VariableReader<SysframeFile> SysframeFile;


		public static readonly VariableReader<SysfsacFile> SysfsacFile;


		public static readonly VariableReader<SyshostFile> SyshostFile;


		public static readonly VariableReader<SysmacroFile> SysmacroFile;


		public static readonly VariableReader<SysmastFile> SysmastFile;


		public static readonly VariableReader<SyspassFile> SyspassFile;


		public static readonly VariableReader<SysservoFile> SysservoFile;


		public static readonly VariableReader<SystemFile> SystemFile;


		public static readonly VariableReader<SysuifFile> SysuifFile;


		public static readonly VariableReader<TpsnapFile> TpsnapFile;


		public static readonly VariableReader<VcmrinitFile> VcmrinitFile;

		/// <summary>
		/// Read and decode the file stream
		/// </summary>
		public override GenericVariableFile ReadFile(Stream fileStream, string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static GenericVariableFile ReadVariableFile(string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static GenericVariableFile ReadVariableFile(Stream fileStream, string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public static GenericVariable[] ParseVariableFile(Stream stream)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
