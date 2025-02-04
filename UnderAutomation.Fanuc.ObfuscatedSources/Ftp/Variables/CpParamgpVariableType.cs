//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CP_PARAMGP_T
	/// </summary>
	public class CpParamgpVariableType : GenericVariableType, IGenericVariableType {


		public CpParamgpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $WARNMESSENB
		/// </summary>
		public bool Warnmessenb { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $ENB
		/// </summary>
		public bool Enb { get; }

		/// <summary>
		/// Value of variable $NUM_CHN
		/// </summary>
		public int NumChn { get; }

		/// <summary>
		/// Value of variable $NUM_JBFSET
		/// </summary>
		public int NumJbfset { get; }

		/// <summary>
		/// Value of variable $NUM_JBF
		/// </summary>
		public int NumJbf { get; }

		/// <summary>
		/// Value of variable $EXT_NUM_JBF
		/// </summary>
		public int ExtNumJbf { get; }

		/// <summary>
		/// Value of variable $JBF_SIZE
		/// </summary>
		public int JbfSize { get; }

		/// <summary>
		/// Value of variable $EXT_JBF_SIZ
		/// </summary>
		public int ExtJbfSiz { get; }

		/// <summary>
		/// Value of variable $NUM_TF
		/// </summary>
		public int NumTf { get; }

		/// <summary>
		/// Value of variable $TF_SIZE
		/// </summary>
		public int TfSize { get; }

		/// <summary>
		/// Value of variable $EXT_TF_SIZE
		/// </summary>
		public int ExtTfSize { get; }

		/// <summary>
		/// Value of variable $NUM_RSINFO
		/// </summary>
		public int NumRsinfo { get; }

		/// <summary>
		/// Value of variable $JNT_VEL_LIM
		/// </summary>
		public double[] JntVelLim { get; }

		/// <summary>
		/// Value of variable $JNT_ACC_LIM
		/// </summary>
		public double[] JntAccLim { get; }

		/// <summary>
		/// Value of variable $JNT_JRK_LIM
		/// </summary>
		public double[] JntJrkLim { get; }

		/// <summary>
		/// Value of variable $T1SEGFL_SF
		/// </summary>
		public double T1segflSf { get; }

		/// <summary>
		/// Value of variable $T1GTFL_SF
		/// </summary>
		public double T1gtflSf { get; }

		/// <summary>
		/// Value of variable $CRCMP_SWITC
		/// </summary>
		public int CrcmpSwitc { get; }

		/// <summary>
		/// Value of variable $ACCLIM_SF
		/// </summary>
		public double AcclimSf { get; }

		/// <summary>
		/// Value of variable $JRKLIM_SF
		/// </summary>
		public double JrklimSf { get; }

		/// <summary>
		/// Value of variable $PSPD_SWITCH
		/// </summary>
		public int PspdSwitch { get; }

		/// <summary>
		/// Value of variable $MAX_PSPD
		/// </summary>
		public int MaxPspd { get; }

		/// <summary>
		/// Value of variable $MIN_PSPD
		/// </summary>
		public int MinPspd { get; }

		/// <summary>
		/// Value of variable $PSPDACC_SF
		/// </summary>
		public double PspdaccSf { get; }

		/// <summary>
		/// Value of variable $PSPDJRK_SF
		/// </summary>
		public double PspdjrkSf { get; }

		/// <summary>
		/// Value of variable $CDCOMP_SW
		/// </summary>
		public int CdcompSw { get; }

		/// <summary>
		/// Value of variable $CDACC_SF
		/// </summary>
		public double CdaccSf { get; }

		/// <summary>
		/// Value of variable $CDJRK_SF
		/// </summary>
		public double CdjrkSf { get; }

		/// <summary>
		/// Value of variable $CDDELTATOL
		/// </summary>
		public double Cddeltatol { get; }

		/// <summary>
		/// Value of variable $CDDISTSF
		/// </summary>
		public double Cddistsf { get; }

		/// <summary>
		/// Value of variable $CDANGTOL
		/// </summary>
		public double Cdangtol { get; }

		/// <summary>
		/// Value of variable $CDDEVTOL
		/// </summary>
		public double Cddevtol { get; }

		/// <summary>
		/// Value of variable $CHKJNTLIM
		/// </summary>
		public bool Chkjntlim { get; }

		/// <summary>
		/// Value of variable $FDANG_TOL
		/// </summary>
		public double FdangTol { get; }

		/// <summary>
		/// Value of variable $FDLIN_TOL
		/// </summary>
		public double FdlinTol { get; }

		/// <summary>
		/// Value of variable $JNTJBF_ENB
		/// </summary>
		public bool JntjbfEnb { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public int CompSw { get; }

		/// <summary>
		/// Value of variable $EXTRA_INT
		/// </summary>
		public int[] ExtraInt { get; }

		/// <summary>
		/// Value of variable $EXTRA_FLT
		/// </summary>
		public double[] ExtraFlt { get; }

		/// <summary>
		/// Value of variable $CP_TEST
		/// </summary>
		public CpTestVariableType CpTest { get; }

		/// <summary>
		/// Value of variable $T1_VSCALE
		/// </summary>
		public int T1Vscale { get; }

		/// <summary>
		/// Value of variable $T1_ASCALE
		/// </summary>
		public int T1Ascale { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
