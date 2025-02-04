//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DMR_GRP_T
	/// </summary>
	public class DmrGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MASTER_DONE
		/// </summary>
		public bool MasterDone { get; }

		/// <summary>
		/// Value of variable $OT_MINUS
		/// </summary>
		public bool[] OtMinus { get; }

		/// <summary>
		/// Value of variable $OT_PLUS
		/// </summary>
		public bool[] OtPlus { get; }

		/// <summary>
		/// Value of variable $MASTER_COUN
		/// </summary>
		public int[] MasterCoun { get; }

		/// <summary>
		/// Value of variable $REF_DONE
		/// </summary>
		public bool RefDone { get; }

		/// <summary>
		/// Value of variable $REF_POS
		/// </summary>
		public double[] RefPos { get; }

		/// <summary>
		/// Value of variable $REF_COUNT
		/// </summary>
		public int[] RefCount { get; }

		/// <summary>
		/// Value of variable $BCKLSH_SIGN
		/// </summary>
		public bool[] BcklshSign { get; }

		/// <summary>
		/// Value of variable $EACHMST_DON
		/// </summary>
		public int[] EachmstDon { get; }

		/// <summary>
		/// Value of variable $SPC_COUNT
		/// </summary>
		public int[] SpcCount { get; }

		/// <summary>
		/// Value of variable $SPC_MOVE
		/// </summary>
		public bool[] SpcMove { get; }

		/// <summary>
		/// Value of variable $ADAPT_INER
		/// </summary>
		public short[] AdaptIner { get; }

		/// <summary>
		/// Value of variable $ADAPT_FRIC
		/// </summary>
		public short[] AdaptFric { get; }

		/// <summary>
		/// Value of variable $ADAPT_COL_P
		/// </summary>
		public short[] AdaptColP { get; }

		/// <summary>
		/// Value of variable $ADAPT_COL_M
		/// </summary>
		public short[] AdaptColM { get; }

		/// <summary>
		/// Value of variable $ADAPT_GRAV
		/// </summary>
		public short[] AdaptGrav { get; }

		/// <summary>
		/// Value of variable $SPC_ST_HIST
		/// </summary>
		public short[] SpcStHist { get; }

		/// <summary>
		/// Value of variable $DSP_ST_HIST
		/// </summary>
		public int[] DspStHist { get; }

		/// <summary>
		/// Value of variable $SHIFT_ERROR
		/// </summary>
		public int ShiftError { get; }

		/// <summary>
		/// Value of variable $SPC_CNT_HIS
		/// </summary>
		public int[] SpcCntHis { get; }

		/// <summary>
		/// Value of variable $MCH_PLS_HIS
		/// </summary>
		public int[] MchPlsHis { get; }

		/// <summary>
		/// Value of variable $ARM_PARAM
		/// </summary>
		public double[] ArmParam { get; }

		/// <summary>
		/// Value of variable $MASTER_ANG
		/// </summary>
		public double MasterAng { get; }

		/// <summary>
		/// Value of variable $DSP_ST_HIS2
		/// </summary>
		public int[] DspStHis2 { get; }

		/// <summary>
		/// Value of variable $CLDET_CNT
		/// </summary>
		public int[] CldetCnt { get; }

		/// <summary>
		/// Value of variable $CALIB_MODE
		/// </summary>
		public int CalibMode { get; }

		/// <summary>
		/// Value of variable $GEAR_PARAM
		/// </summary>
		public double[] GearParam { get; }

		/// <summary>
		/// Value of variable $GEAR_PARAM2
		/// </summary>
		public double[] GearParam2 { get; }

		/// <summary>
		/// Value of variable $SPRING_PAM
		/// </summary>
		public double[] SpringPam { get; }

		/// <summary>
		/// Value of variable $GRAV_MAST
		/// </summary>
		public int GravMast { get; }

		/// <summary>
		/// Value of variable $REL_SHF_ERR
		/// </summary>
		public DmrShferrVariableType[] RelShfErr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
