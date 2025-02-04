//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ZDT_DCSCHG_T
	/// </summary>
	public class ZdtDcschgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $DCSCHG_ENB
		/// </summary>
		public bool DcschgEnb { get; }

		/// <summary>
		/// Value of variable $LOGIN_IDX
		/// </summary>
		public int LoginIdx { get; }

		/// <summary>
		/// Value of variable $LAST_SIGNAT
		/// </summary>
		public int LastSignat { get; }

		/// <summary>
		/// Value of variable $LST_TIME
		/// </summary>
		public int LstTime { get; }

		/// <summary>
		/// Value of variable $DCS_FUNCT
		/// </summary>
		public int DcsFunct { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
