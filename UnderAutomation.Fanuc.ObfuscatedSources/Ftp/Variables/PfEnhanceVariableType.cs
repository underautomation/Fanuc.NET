//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PF_ENHANCE_T
	/// </summary>
	public class PfEnhanceVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $STATE
		/// </summary>
		public int State { get; }

		/// <summary>
		/// Value of variable $HRS_INTV
		/// </summary>
		public double HrsIntv { get; }

		/// <summary>
		/// Value of variable $RM_CFG
		/// </summary>
		public int RmCfg { get; }

		/// <summary>
		/// Value of variable $GRP_MASK
		/// </summary>
		public int GrpMask { get; }

		/// <summary>
		/// Value of variable $SPD_OVRD
		/// </summary>
		public int SpdOvrd { get; }

		/// <summary>
		/// Value of variable $PG_PREFIX
		/// </summary>
		public string PgPrefix { get; }

		/// <summary>
		/// Value of variable $MAX_LINES
		/// </summary>
		public int MaxLines { get; }

		/// <summary>
		/// Value of variable $OVC_LIM
		/// </summary>
		public int OvcLim { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
