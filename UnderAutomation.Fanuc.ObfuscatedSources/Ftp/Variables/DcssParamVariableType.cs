//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCSS_PARAM_T
	/// </summary>
	public class DcssParamVariableType : GenericVariableType, IGenericVariableType {


		public DcssParamVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DOCHK_ENB
		/// </summary>
		public int DochkEnb { get; }

		/// <summary>
		/// Value of variable $PMCS_ENB
		/// </summary>
		public int PmcsEnb { get; }

		/// <summary>
		/// Value of variable $LS_STOP
		/// </summary>
		public int LsStop { get; }

		/// <summary>
		/// Value of variable $LS_FENCE
		/// </summary>
		public int LsFence { get; }

		/// <summary>
		/// Value of variable $HOTSWP_TIME
		/// </summary>
		public int HotswpTime { get; }

		/// <summary>
		/// Value of variable $MODE_SELECT
		/// </summary>
		public int ModeSelect { get; }

		/// <summary>
		/// Value of variable $MODE_TYPE
		/// </summary>
		public int ModeType { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
