//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file diocfgsv.va
	/// </summary>
	public class DiocfgsvFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public DiocfgsvFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable CFG_FILE_VER
		/// </summary>
		public int CfgFileVer { get; }

		/// <summary>
		/// Value of variable ASG_LOG_PT
		/// </summary>
		public byte[] AsgLogPt { get; }

		/// <summary>
		/// Value of variable ASG_LOG_PN
		/// </summary>
		public short[] AsgLogPn { get; }

		/// <summary>
		/// Value of variable ASG_N_PTS
		/// </summary>
		public short[] AsgNPts { get; }

		/// <summary>
		/// Value of variable ASG_RACK_NO
		/// </summary>
		public byte[] AsgRackNo { get; }

		/// <summary>
		/// Value of variable ASG_SLOT_NO
		/// </summary>
		public byte[] AsgSlotNo { get; }

		/// <summary>
		/// Value of variable ASG_PHY_PT
		/// </summary>
		public byte[] AsgPhyPt { get; }

		/// <summary>
		/// Value of variable ASG_PHY_PN
		/// </summary>
		public short[] AsgPhyPn { get; }

		/// <summary>
		/// Value of variable NAME_LOG_PT
		/// </summary>
		public byte[] NameLogPt { get; }

		/// <summary>
		/// Value of variable NAME_LOG_PN
		/// </summary>
		public short[] NameLogPn { get; }

		/// <summary>
		/// Value of variable NAME_NAME
		/// </summary>
		public string[] NameName { get; }

		/// <summary>
		/// Value of variable NAME_NAME2
		/// </summary>
		public string[] NameName2 { get; }

		/// <summary>
		/// Value of variable MODE_LOG_PT
		/// </summary>
		public byte[] ModeLogPt { get; }

		/// <summary>
		/// Value of variable MODE_FRST_PN
		/// </summary>
		public short[] ModeFrstPn { get; }

		/// <summary>
		/// Value of variable MODE_LAST_PN
		/// </summary>
		public short[] ModeLastPn { get; }

		/// <summary>
		/// Value of variable MODE_MODE
		/// </summary>
		public byte[] ModeMode { get; }

		/// <summary>
		/// Value of variable AIS_RACK_NO
		/// </summary>
		public byte[] AisRackNo { get; }

		/// <summary>
		/// Value of variable AIS_SLOT_NO
		/// </summary>
		public byte[] AisSlotNo { get; }

		/// <summary>
		/// Value of variable AIS_SEQUENCE
		/// </summary>
		public string[] AisSequence { get; }

		/// <summary>
		/// Value of variable DEV_RACK
		/// </summary>
		public short[] DevRack { get; }

		/// <summary>
		/// Value of variable DEV_SLOT
		/// </summary>
		public short[] DevSlot { get; }

		/// <summary>
		/// Value of variable DEV_MOD_ID
		/// </summary>
		public short[] DevModId { get; }

		/// <summary>
		/// Value of variable DEV_DATA_TYPE
		/// </summary>
		public short[] DevDataType { get; }

		/// <summary>
		/// Value of variable DEV_PARAM1
		/// </summary>
		public short[] DevParam1 { get; }

		/// <summary>
		/// Value of variable DEV_PARAM2
		/// </summary>
		public short[] DevParam2 { get; }

		/// <summary>
		/// Value of variable DEV_COMMENT
		/// </summary>
		public string[] DevComment { get; }
	}
}
