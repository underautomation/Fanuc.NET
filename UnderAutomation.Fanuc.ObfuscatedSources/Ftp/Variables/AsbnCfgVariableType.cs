//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ASBN_CFG_T
	/// </summary>
	public class AsbnCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CNV_JNT_POS
		/// </summary>
		public bool CnvJntPos { get; }

		/// <summary>
		/// Value of variable $DATA_CMNTS
		/// </summary>
		public short DataCmnts { get; }

		/// <summary>
		/// Value of variable $FLAGS
		/// </summary>
		public short Flags { get; }

		/// <summary>
		/// Value of variable $POS_CHECK
		/// </summary>
		public bool PosCheck { get; }

		/// <summary>
		/// Value of variable $CHECK_OPTN
		/// </summary>
		public int CheckOptn { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
