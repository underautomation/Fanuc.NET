//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TSCFG_T
	/// </summary>
	public class TscfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $GRP_MASK
		/// </summary>
		public int GrpMask { get; }

		/// <summary>
		/// Value of variable $MODE_MASK
		/// </summary>
		public int ModeMask { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable $OPT_VAL
		/// </summary>
		public double OptVal { get; }

		/// <summary>
		/// Value of variable $SIZE
		/// </summary>
		public int Size { get; }

		/// <summary>
		/// Value of variable $FNAME_TYPE
		/// </summary>
		public short FnameType { get; }

		/// <summary>
		/// Value of variable $PROC
		/// </summary>
		public bool Proc { get; }

		/// <summary>
		/// Value of variable $OUTPUT
		/// </summary>
		public bool Output { get; }

		/// <summary>
		/// Value of variable $OUTPUT_DONE
		/// </summary>
		public bool OutputDone { get; }

		/// <summary>
		/// Value of variable $AXS_MSK_ENB
		/// </summary>
		public bool AxsMskEnb { get; }

		/// <summary>
		/// Value of variable $AXIS_MASK
		/// </summary>
		public short[] AxisMask { get; }

		/// <summary>
		/// Value of variable $CUR_RECTIME
		/// </summary>
		public int CurRectime { get; }

		/// <summary>
		/// Value of variable $TOT_CHN_NUM
		/// </summary>
		public int TotChnNum { get; }

		/// <summary>
		/// Value of variable $MINFREQ_US
		/// </summary>
		public int MinfreqUs { get; }

		/// <summary>
		/// Value of variable $SETFREQ_POW
		/// </summary>
		public int SetfreqPow { get; }

		/// <summary>
		/// Value of variable $LPARAM
		/// </summary>
		public int[] Lparam { get; }

		/// <summary>
		/// Value of variable $FPARAM
		/// </summary>
		public double[] Fparam { get; }

		/// <summary>
		/// Value of variable $PATH_NAM
		/// </summary>
		public string PathNam { get; }

		/// <summary>
		/// Value of variable $DUMMY19
		/// </summary>
		public byte Dummy19 { get; }

		/// <summary>
		/// Value of variable $DUMMY20
		/// </summary>
		public byte Dummy20 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
