//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MFRQ_CFG_T
	/// </summary>
	public class MfrqCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $HRS_RUN
		/// </summary>
		public double HrsRun { get; }

		/// <summary>
		/// Value of variable $STATE
		/// </summary>
		public int State { get; }

		/// <summary>
		/// Value of variable $ACT_GRP
		/// </summary>
		public int ActGrp { get; }

		/// <summary>
		/// Value of variable $FREQ_LIM
		/// </summary>
		public double FreqLim { get; }

		/// <summary>
		/// Value of variable $WIN_SIZE
		/// </summary>
		public int WinSize { get; }

		/// <summary>
		/// Value of variable $OVERLAP
		/// </summary>
		public int Overlap { get; }

		/// <summary>
		/// Value of variable $FLAG
		/// </summary>
		public int Flag { get; }

		/// <summary>
		/// Value of variable $SPD_OVRD
		/// </summary>
		public int SpdOvrd { get; }

		/// <summary>
		/// Value of variable $PG_PREFIX
		/// </summary>
		public string PgPrefix { get; }

		/// <summary>
		/// Value of variable $MODE
		/// </summary>
		public int Mode { get; }

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
