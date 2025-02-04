//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HSCD_MNG_T
	/// </summary>
	public class HscdMngVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $COLL_MODE
		/// </summary>
		public bool CollMode { get; }

		/// <summary>
		/// Value of variable $THRESHOLD
		/// </summary>
		public int Threshold { get; }

		/// <summary>
		/// Value of variable $DO_ERR
		/// </summary>
		public int DoErr { get; }

		/// <summary>
		/// Value of variable $DO_ENABLE
		/// </summary>
		public int DoEnable { get; }

		/// <summary>
		/// Value of variable $MACRO_REG
		/// </summary>
		public int MacroReg { get; }

		/// <summary>
		/// Value of variable $STND_CD
		/// </summary>
		public int StndCd { get; }

		/// <summary>
		/// Value of variable $AUTO_RESET
		/// </summary>
		public int AutoReset { get; }

		/// <summary>
		/// Value of variable $UPD_GROUPS
		/// </summary>
		public int UpdGroups { get; }

		/// <summary>
		/// Value of variable $PARAM_VERID
		/// </summary>
		public string ParamVerid { get; }

		/// <summary>
		/// Value of variable $PARAM119
		/// </summary>
		public int[] Param119 { get; }

		/// <summary>
		/// Value of variable $PARAM120
		/// </summary>
		public int[] Param120 { get; }

		/// <summary>
		/// Value of variable $PARAM121
		/// </summary>
		public int[] Param121 { get; }

		/// <summary>
		/// Value of variable $PARAM122
		/// </summary>
		public int[] Param122 { get; }

		/// <summary>
		/// Value of variable $PARAM123
		/// </summary>
		public int[] Param123 { get; }

		/// <summary>
		/// Value of variable $PARAM124
		/// </summary>
		public int[] Param124 { get; }

		/// <summary>
		/// Value of variable $PARAM125
		/// </summary>
		public int[] Param125 { get; }

		/// <summary>
		/// Value of variable $ACT_RATIO
		/// </summary>
		public int ActRatio { get; }

		/// <summary>
		/// Value of variable $SAVED119
		/// </summary>
		public int[] Saved119 { get; }

		/// <summary>
		/// Value of variable $SAVED120
		/// </summary>
		public int[] Saved120 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
