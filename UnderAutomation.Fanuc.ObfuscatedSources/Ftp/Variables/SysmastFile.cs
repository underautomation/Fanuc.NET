//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file sysmast.va
	/// </summary>
	public class SysmastFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public SysmastFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DMR_GRP
		/// </summary>
		public DmrGrpVariableType[] DmrGrp { get; }

		/// <summary>
		/// Value of variable $FMS_GRP
		/// </summary>
		public FmsGrpVariableType[] FmsGrp { get; }

		/// <summary>
		/// Value of variable $PLCL_GRP
		/// </summary>
		public PlclGrpVariableType[] PlclGrp { get; }
	}
}
