//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DTREC_T
	/// </summary>
	public class DtrecVariableType : GenericVariableType, IGenericVariableType {


		public DtrecVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DTREC_ENB
		/// </summary>
		public int DtrecEnb { get; }

		/// <summary>
		/// Value of variable $SAMPLE_ITP
		/// </summary>
		public int SampleItp { get; }

		/// <summary>
		/// Value of variable $BUF_SIZE
		/// </summary>
		public int BufSize { get; }

		/// <summary>
		/// Value of variable $FILE_SIZE
		/// </summary>
		public int FileSize { get; }

		/// <summary>
		/// Value of variable $DEVICE_NAM
		/// </summary>
		public string DeviceNam { get; }

		/// <summary>
		/// Value of variable $SUBBUF_SIZ
		/// </summary>
		public int SubbufSiz { get; }

		/// <summary>
		/// Value of variable $SPC_FILE
		/// </summary>
		public int SpcFile { get; }

		/// <summary>
		/// Value of variable $DTREC_ON
		/// </summary>
		public int DtrecOn { get; }

		/// <summary>
		/// Value of variable $DTSAV_ON
		/// </summary>
		public int DtsavOn { get; }

		/// <summary>
		/// Value of variable $FILE_ACCESS
		/// </summary>
		public int FileAccess { get; }

		/// <summary>
		/// Value of variable $PC_ACCESS
		/// </summary>
		public int PcAccess { get; }

		/// <summary>
		/// Value of variable $SYSTIME
		/// </summary>
		public int[] Systime { get; }

		/// <summary>
		/// Value of variable $DTSAV_ENB
		/// </summary>
		public int DtsavEnb { get; }

		/// <summary>
		/// Value of variable $ORDER
		/// </summary>
		public int Order { get; }

		/// <summary>
		/// Value of variable $DSB_BUFSIZ
		/// </summary>
		public int DsbBufsiz { get; }

		/// <summary>
		/// Value of variable $ENB_BUFSIZ
		/// </summary>
		public int EnbBufsiz { get; }

		/// <summary>
		/// Value of variable $OTTASK_MOD
		/// </summary>
		public int OttaskMod { get; }

		/// <summary>
		/// Value of variable $DP_ALM_ID
		/// </summary>
		public int DpAlmId { get; }

		/// <summary>
		/// Value of variable $DP_ALM_GRP
		/// </summary>
		public int DpAlmGrp { get; }

		/// <summary>
		/// Value of variable $DP_ALM_AXS
		/// </summary>
		public int DpAlmAxs { get; }

		/// <summary>
		/// Value of variable $DEF_MAXBUF
		/// </summary>
		public double DefMaxbuf { get; }

		/// <summary>
		/// Value of variable $SYSTIME_G0
		/// </summary>
		public int[] SystimeG0 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
