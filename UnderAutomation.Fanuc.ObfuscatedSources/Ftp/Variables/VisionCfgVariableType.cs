//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VISION_CFG_T
	/// </summary>
	public class VisionCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $DATA_PATH
		/// </summary>
		public string DataPath { get; }

		/// <summary>
		/// Value of variable $DATA_CACHE
		/// </summary>
		public int DataCache { get; }

		/// <summary>
		/// Value of variable $LOG_PATH
		/// </summary>
		public string LogPath { get; }

		/// <summary>
		/// Value of variable $LOG_EXPATH
		/// </summary>
		public string LogExpath { get; }

		/// <summary>
		/// Value of variable $LOG_TIMEOUT
		/// </summary>
		public int LogTimeout { get; }

		/// <summary>
		/// Value of variable $MC_LIMIT
		/// </summary>
		public int McLimit { get; }

		/// <summary>
		/// Value of variable $FR_LIMIT
		/// </summary>
		public int FrLimit { get; }

		/// <summary>
		/// Value of variable $TD_LIMIT
		/// </summary>
		public int TdLimit { get; }

		/// <summary>
		/// Value of variable $DEBUG_MODE
		/// </summary>
		public int DebugMode { get; }

		/// <summary>
		/// Value of variable $HOST_NAME
		/// </summary>
		public string HostName { get; }

		/// <summary>
		/// Value of variable $COMM_PORT
		/// </summary>
		public int CommPort { get; }

		/// <summary>
		/// Value of variable $ROBOT_NAME
		/// </summary>
		public string RobotName { get; }

		/// <summary>
		/// Value of variable $FLAGS
		/// </summary>
		public int Flags { get; }

		/// <summary>
		/// Value of variable $FLAGS2
		/// </summary>
		public int Flags2 { get; }

		/// <summary>
		/// Value of variable $MAX_PAGES
		/// </summary>
		public int MaxPages { get; }

		/// <summary>
		/// Value of variable $MIN_VPOOL
		/// </summary>
		public int MinVpool { get; }

		/// <summary>
		/// Value of variable $VPOOL_SIZE
		/// </summary>
		public int VpoolSize { get; }

		/// <summary>
		/// Value of variable $VPOOL_SZCAL
		/// </summary>
		public int VpoolSzcal { get; }

		/// <summary>
		/// Value of variable $VPOOL_LIM
		/// </summary>
		public int VpoolLim { get; }

		/// <summary>
		/// Value of variable $VPOOL_WAIT
		/// </summary>
		public int VpoolWait { get; }

		/// <summary>
		/// Value of variable $TMPPOOL_LIM
		/// </summary>
		public int TmppoolLim { get; }

		/// <summary>
		/// Value of variable $FAILIMG_IDX
		/// </summary>
		public short FailimgIdx { get; }

		/// <summary>
		/// Value of variable $LOADIMG_IDX
		/// </summary>
		public short LoadimgIdx { get; }

		/// <summary>
		/// Value of variable $NUM_IMREGS
		/// </summary>
		public int NumImregs { get; }

		/// <summary>
		/// Value of variable $IMREG_SIZE
		/// </summary>
		public int ImregSize { get; }

		/// <summary>
		/// Value of variable $GPM_CANDMAX
		/// </summary>
		public int GpmCandmax { get; }

		/// <summary>
		/// Value of variable $NUM_ASYNBUF
		/// </summary>
		public int NumAsynbuf { get; }

		/// <summary>
		/// Value of variable $NUM_VRTDBUF
		/// </summary>
		public int NumVrtdbuf { get; }

		/// <summary>
		/// Value of variable $VRTDBUF_SIZ
		/// </summary>
		public int VrtdbufSiz { get; }

		/// <summary>
		/// Value of variable $TOLE_2D_Z
		/// </summary>
		public double Tole2dZ { get; }

		/// <summary>
		/// Value of variable $TOLE_2D_WP
		/// </summary>
		public double Tole2dWp { get; }

		/// <summary>
		/// Value of variable $PC_SETUP
		/// </summary>
		public bool PcSetup { get; }

		/// <summary>
		/// Value of variable $LOGQUE_MAX
		/// </summary>
		public int LogqueMax { get; }

		/// <summary>
		/// Value of variable $ECCU_RETRY
		/// </summary>
		public int EccuRetry { get; }

		/// <summary>
		/// Value of variable $VEMT_PATH
		/// </summary>
		public string VemtPath { get; }

		/// <summary>
		/// Value of variable $VEMT_LIMIT
		/// </summary>
		public int VemtLimit { get; }

		/// <summary>
		/// Value of variable $VIRCIMG_SIZ
		/// </summary>
		public int VircimgSiz { get; }

		/// <summary>
		/// Value of variable $NUM_VR
		/// </summary>
		public int NumVr { get; }

		/// <summary>
		/// Value of variable $VRTD_DELAY
		/// </summary>
		public int VrtdDelay { get; }

		/// <summary>
		/// Value of variable $MAX_NFOUND
		/// </summary>
		public int MaxNfound { get; }

		/// <summary>
		/// Value of variable $DIAGBUF_SIZ
		/// </summary>
		public int DiagbufSiz { get; }

		/// <summary>
		/// Value of variable $RPOS_XYZ_TH
		/// </summary>
		public double RposXyzTh { get; }

		/// <summary>
		/// Value of variable $RPOS_WPR_TH
		/// </summary>
		public double RposWprTh { get; }

		/// <summary>
		/// Value of variable $RPOS_ANG_TH
		/// </summary>
		public double RposAngTh { get; }

		/// <summary>
		/// Value of variable $ENB_VIRTCAM
		/// </summary>
		public bool EnbVirtcam { get; }

		/// <summary>
		/// Value of variable $IMDIAG_SIZ
		/// </summary>
		public int ImdiagSiz { get; }

		/// <summary>
		/// Value of variable $VRTD_TIMOUT
		/// </summary>
		public int VrtdTimout { get; }

		/// <summary>
		/// Value of variable $GRABBER_TYP
		/// </summary>
		public int GrabberTyp { get; }

		/// <summary>
		/// Value of variable $BASLERUSBCA
		/// </summary>
		public int Baslerusbca { get; }

		/// <summary>
		/// Value of variable $DEF_DSP_MOD
		/// </summary>
		public byte DefDspMod { get; }

		/// <summary>
		/// Value of variable $DUMMY50
		/// </summary>
		public byte Dummy50 { get; }

		/// <summary>
		/// Value of variable $DUMMY51
		/// </summary>
		public byte Dummy51 { get; }

		/// <summary>
		/// Value of variable $DUMMY52
		/// </summary>
		public byte Dummy52 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
