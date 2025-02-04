//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UECFG_T
	/// </summary>
	public class UecfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CHK_VERSION
		/// </summary>
		public int ChkVersion { get; }

		/// <summary>
		/// Value of variable $RSM_CHK_ENB
		/// </summary>
		public bool RsmChkEnb { get; }

		/// <summary>
		/// Value of variable $UNEXCEP_ENB
		/// </summary>
		public bool UnexcepEnb { get; }

		/// <summary>
		/// Value of variable $RSM_THRS_R
		/// </summary>
		public double RsmThrsR { get; }

		/// <summary>
		/// Value of variable $RSM_THRS_L
		/// </summary>
		public double RsmThrsL { get; }

		/// <summary>
		/// Value of variable $UNEX_THRS_R
		/// </summary>
		public double UnexThrsR { get; }

		/// <summary>
		/// Value of variable $UNEX_THRS_L
		/// </summary>
		public double UnexThrsL { get; }

		/// <summary>
		/// Value of variable $REQ_COUNT
		/// </summary>
		public int ReqCount { get; }

		/// <summary>
		/// Value of variable $REQ_DATA
		/// </summary>
		public ReqDataVariableType[] ReqData { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
