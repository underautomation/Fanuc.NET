//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PRGNS_ELEM_T
	/// </summary>
	public class PrgnsElemVariableType : GenericVariableType, IGenericVariableType {


		public PrgnsElemVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public int Enable { get; }

		/// <summary>
		/// Value of variable $FEASIBLE
		/// </summary>
		public int Feasible { get; }

		/// <summary>
		/// Value of variable $AXIS
		/// </summary>
		public short Axis { get; }

		/// <summary>
		/// Value of variable $ELEM_NUM
		/// </summary>
		public int ElemNum { get; }

		/// <summary>
		/// Value of variable $ROT_RATIO
		/// </summary>
		public double RotRatio { get; }

		/// <summary>
		/// Value of variable $MAX_FREQ
		/// </summary>
		public double MaxFreq { get; }

		/// <summary>
		/// Value of variable $THRE_REL
		/// </summary>
		public double ThreRel { get; }

		/// <summary>
		/// Value of variable $THRE_ABS
		/// </summary>
		public double ThreAbs { get; }

		/// <summary>
		/// Value of variable $DEGRAD_LVL
		/// </summary>
		public double DegradLvl { get; }

		/// <summary>
		/// Value of variable $DEGRAD_BASE
		/// </summary>
		public double DegradBase { get; }

		/// <summary>
		/// Value of variable $DEGRAD_RATE
		/// </summary>
		public double DegradRate { get; }

		/// <summary>
		/// Value of variable $UPD_DATE
		/// </summary>
		public string UpdDate { get; }

		/// <summary>
		/// Value of variable $BASE_DATE
		/// </summary>
		public string BaseDate { get; }

		/// <summary>
		/// Value of variable $RMS_TRQ
		/// </summary>
		public double RmsTrq { get; }

		/// <summary>
		/// Value of variable $MAX_DISTRQ
		/// </summary>
		public int MaxDistrq { get; }

		/// <summary>
		/// Value of variable $MAX_SPD
		/// </summary>
		public int MaxSpd { get; }

		/// <summary>
		/// Value of variable $LAST_DATE
		/// </summary>
		public int LastDate { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
