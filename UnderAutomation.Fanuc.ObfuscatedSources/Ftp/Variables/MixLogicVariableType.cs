//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MIX_LOGIC_T
	/// </summary>
	public class MixLogicVariableType : GenericVariableType, IGenericVariableType {


		public MixLogicVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $USE_FLG
		/// </summary>
		public bool UseFlg { get; }

		/// <summary>
		/// Value of variable $USE_MKR
		/// </summary>
		public bool UseMkr { get; }

		/// <summary>
		/// Value of variable $USE_TCOL
		/// </summary>
		public bool UseTcol { get; }

		/// <summary>
		/// Value of variable $USE_TCOLSIM
		/// </summary>
		public bool UseTcolsim { get; }

		/// <summary>
		/// Value of variable $NUM_FLG
		/// </summary>
		public int NumFlg { get; }

		/// <summary>
		/// Value of variable $NUM_MKR
		/// </summary>
		public int NumMkr { get; }

		/// <summary>
		/// Value of variable $NUM_BG
		/// </summary>
		public int NumBg { get; }

		/// <summary>
		/// Value of variable $NUM_SCAN
		/// </summary>
		public int NumScan { get; }

		/// <summary>
		/// Value of variable $MAXNUM_SCAN
		/// </summary>
		public int MaxnumScan { get; }

		/// <summary>
		/// Value of variable $MINNUM_SCAN
		/// </summary>
		public int MinnumScan { get; }

		/// <summary>
		/// Value of variable $ITEM_COUNT
		/// </summary>
		public int ItemCount { get; }

		/// <summary>
		/// Value of variable $PROC_TIME
		/// </summary>
		public int ProcTime { get; }

		/// <summary>
		/// Value of variable $MAX_TMR_VAL
		/// </summary>
		public int MaxTmrVal { get; }

		/// <summary>
		/// Value of variable $TCOL_LINE
		/// </summary>
		public TcolLineVariableType TcolLine { get; }

		/// <summary>
		/// Value of variable $TCOL_ENB
		/// </summary>
		public bool TcolEnb { get; }

		/// <summary>
		/// Value of variable $TCOL_SIM
		/// </summary>
		public bool TcolSim { get; }

		/// <summary>
		/// Value of variable $TCOL_STAT
		/// </summary>
		public bool TcolStat { get; }

		/// <summary>
		/// Value of variable $SAVE_IDX
		/// </summary>
		public int SaveIdx { get; }

		/// <summary>
		/// Value of variable $SAVE_LINE
		/// </summary>
		public TcolLineVariableType SaveLine { get; }

		/// <summary>
		/// Value of variable $TCOL_WARN
		/// </summary>
		public bool TcolWarn { get; }

		/// <summary>
		/// Value of variable $BG_HITEM
		/// </summary>
		public int BgHitem { get; }

		/// <summary>
		/// Value of variable $INST_CHK
		/// </summary>
		public bool InstChk { get; }

		/// <summary>
		/// Value of variable $SPEC_TIME
		/// </summary>
		public int SpecTime { get; }

		/// <summary>
		/// Value of variable $MAX_PRTIME
		/// </summary>
		public int MaxPrtime { get; }

		/// <summary>
		/// Value of variable $MIN_PRTIME
		/// </summary>
		public int MinPrtime { get; }

		/// <summary>
		/// Value of variable $TCOL_OPT
		/// </summary>
		public int TcolOpt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
