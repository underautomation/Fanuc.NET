//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ENC_STAT_T
	/// </summary>
	public class EncStatVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENC_COUNT
		/// </summary>
		public int EncCount { get; }

		/// <summary>
		/// Value of variable $ENC_ROS_TIK
		/// </summary>
		public int EncRosTik { get; }

		/// <summary>
		/// Value of variable $ENC_RATE
		/// </summary>
		public int EncRate { get; }

		/// <summary>
		/// Value of variable $ENC_AVERAGE
		/// </summary>
		public int EncAverage { get; }

		/// <summary>
		/// Value of variable $ENC_ENABLE
		/// </summary>
		public bool EncEnable { get; }

		/// <summary>
		/// Value of variable $ENC_DSPSTAT
		/// </summary>
		public int EncDspstat { get; }

		/// <summary>
		/// Value of variable $ENC_SPCSTAT
		/// </summary>
		public int EncSpcstat { get; }

		/// <summary>
		/// Value of variable $ENC_SIM_ON
		/// </summary>
		public bool EncSimOn { get; }

		/// <summary>
		/// Value of variable $ENC_SIM_SPD
		/// </summary>
		public int EncSimSpd { get; }

		/// <summary>
		/// Value of variable $ENC_VALUE
		/// </summary>
		public int EncValue { get; }

		/// <summary>
		/// Value of variable $ENC_HEAD
		/// </summary>
		public int EncHead { get; }

		/// <summary>
		/// Value of variable $ENC_MULTIPL
		/// </summary>
		public int EncMultipl { get; }

		/// <summary>
		/// Value of variable $ENC_THRESH
		/// </summary>
		public int EncThresh { get; }

		/// <summary>
		/// Value of variable $ENC_EXISTS
		/// </summary>
		public bool EncExists { get; }

		/// <summary>
		/// Value of variable $ENC_HSDI
		/// </summary>
		public bool EncHsdi { get; }

		/// <summary>
		/// Value of variable $ENC_ABSCNT
		/// </summary>
		public int EncAbscnt { get; }

		/// <summary>
		/// Value of variable $INCTRAVDIST
		/// </summary>
		public int Inctravdist { get; }

		/// <summary>
		/// Value of variable $INCTRAVCNTS
		/// </summary>
		public int Inctravcnts { get; }

		/// <summary>
		/// Value of variable $INCTRAV_DO
		/// </summary>
		public int InctravDo { get; }

		/// <summary>
		/// Value of variable $CONVSPD_GO
		/// </summary>
		public int ConvspdGo { get; }

		/// <summary>
		/// Value of variable $INCTRAVRES
		/// </summary>
		public bool Inctravres { get; }

		/// <summary>
		/// Value of variable $ENC_BUFFER
		/// </summary>
		public int[] EncBuffer { get; }

		/// <summary>
		/// Value of variable $ENC_ATR_AXS
		/// </summary>
		public int EncAtrAxs { get; }

		/// <summary>
		/// Value of variable $SC_GRP_NUM
		/// </summary>
		public int ScGrpNum { get; }

		/// <summary>
		/// Value of variable $ENC_COMERCT
		/// </summary>
		public int EncComerct { get; }

		/// <summary>
		/// Value of variable $ENC_FBCMPCT
		/// </summary>
		public int EncFbcmpct { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
