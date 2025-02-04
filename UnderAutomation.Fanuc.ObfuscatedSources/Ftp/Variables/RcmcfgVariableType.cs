//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type RCMCFG_T
	/// </summary>
	public class RcmcfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $RCM_ENABLE
		/// </summary>
		public bool RcmEnable { get; }

		/// <summary>
		/// Value of variable $QSIZE
		/// </summary>
		public int Qsize { get; }

		/// <summary>
		/// Value of variable $TIMER
		/// </summary>
		public int Timer { get; }

		/// <summary>
		/// Value of variable $STATUS_TIME
		/// </summary>
		public int StatusTime { get; }

		/// <summary>
		/// Value of variable $MAILSERV
		/// </summary>
		public string Mailserv { get; }

		/// <summary>
		/// Value of variable $PLANT
		/// </summary>
		public string Plant { get; }

		/// <summary>
		/// Value of variable $LINE
		/// </summary>
		public string Line { get; }

		/// <summary>
		/// Value of variable $CLUSTER
		/// </summary>
		public string Cluster { get; }

		/// <summary>
		/// Value of variable $TOADDR
		/// </summary>
		public string Toaddr { get; }

		/// <summary>
		/// Value of variable $CCADDR
		/// </summary>
		public string Ccaddr { get; }

		/// <summary>
		/// Value of variable $FRADDR
		/// </summary>
		public string Fraddr { get; }

		/// <summary>
		/// Value of variable $SUBJECT
		/// </summary>
		public string Subject { get; }

		/// <summary>
		/// Value of variable $STATUS_ENB
		/// </summary>
		public bool StatusEnb { get; }

		/// <summary>
		/// Value of variable $ALARM_ENB
		/// </summary>
		public bool AlarmEnb { get; }

		/// <summary>
		/// Value of variable $TPLOG_ENB
		/// </summary>
		public bool TplogEnb { get; }

		/// <summary>
		/// Value of variable $VARLOG_ENB
		/// </summary>
		public bool VarlogEnb { get; }

		/// <summary>
		/// Value of variable $MOTION_ENB
		/// </summary>
		public bool MotionEnb { get; }

		/// <summary>
		/// Value of variable $SYSTEM_ENB
		/// </summary>
		public bool SystemEnb { get; }

		/// <summary>
		/// Value of variable $APPL_ENB
		/// </summary>
		public bool ApplEnb { get; }

		/// <summary>
		/// Value of variable $PASS_ENB
		/// </summary>
		public bool PassEnb { get; }

		/// <summary>
		/// Value of variable $COMM_ENB
		/// </summary>
		public bool CommEnb { get; }

		/// <summary>
		/// Value of variable $PORT
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Value of variable $STAT_SUBJ
		/// </summary>
		public string StatSubj { get; }

		/// <summary>
		/// Value of variable $ALERTADDR
		/// </summary>
		public string Alertaddr { get; }

		/// <summary>
		/// Value of variable $ALERTURL
		/// </summary>
		public string Alerturl { get; }

		/// <summary>
		/// Value of variable $STAT_ATTACH
		/// </summary>
		public string StatAttach { get; }

		/// <summary>
		/// Value of variable $ERR_THROT
		/// </summary>
		public int ErrThrot { get; }

		/// <summary>
		/// Value of variable $USR_THROT
		/// </summary>
		public int UsrThrot { get; }

		/// <summary>
		/// Value of variable $SIZE_THROT
		/// </summary>
		public int SizeThrot { get; }

		/// <summary>
		/// Value of variable $VARCHG_TIME
		/// </summary>
		public int VarchgTime { get; }

		/// <summary>
		/// Value of variable $VARCHG_MAX
		/// </summary>
		public int VarchgMax { get; }

		/// <summary>
		/// Value of variable $WS_URL
		/// </summary>
		public string WsUrl { get; }

		/// <summary>
		/// Value of variable $WS_MODE
		/// </summary>
		public bool WsMode { get; }

		/// <summary>
		/// Value of variable $WS_UID
		/// </summary>
		public string WsUid { get; }

		/// <summary>
		/// Value of variable $WS_USER
		/// </summary>
		public string WsUser { get; }

		/// <summary>
		/// Value of variable $LAST_ERR
		/// </summary>
		public int LastErr { get; }

		/// <summary>
		/// Value of variable $SND_MAXTRY
		/// </summary>
		public int SndMaxtry { get; }

		/// <summary>
		/// Value of variable $SND_DELAY
		/// </summary>
		public int SndDelay { get; }

		/// <summary>
		/// Value of variable $WS_QSIZE
		/// </summary>
		public int WsQsize { get; }

		/// <summary>
		/// Value of variable $WS_PERSIST
		/// </summary>
		public bool WsPersist { get; }

		/// <summary>
		/// Value of variable $WS_TIMER
		/// </summary>
		public int WsTimer { get; }

		/// <summary>
		/// Value of variable $ROS_QSIZE
		/// </summary>
		public int RosQsize { get; }

		/// <summary>
		/// Value of variable $CLK_TIMER
		/// </summary>
		public int ClkTimer { get; }

		/// <summary>
		/// Value of variable $MEM_TIMER
		/// </summary>
		public int MemTimer { get; }

		/// <summary>
		/// Value of variable $USEXMLCFG
		/// </summary>
		public bool Usexmlcfg { get; }

		/// <summary>
		/// Value of variable $MSGFRMT
		/// </summary>
		public int Msgfrmt { get; }

		/// <summary>
		/// Value of variable $TCP_TIMEOUT
		/// </summary>
		public int TcpTimeout { get; }

		/// <summary>
		/// Value of variable $PING_RETRY
		/// </summary>
		public int PingRetry { get; }

		/// <summary>
		/// Value of variable $OPTION
		/// </summary>
		public int Option { get; }

		/// <summary>
		/// Value of variable $PING
		/// </summary>
		public bool Ping { get; }

		/// <summary>
		/// Value of variable $PING_TIMER
		/// </summary>
		public int PingTimer { get; }

		/// <summary>
		/// Value of variable $CSTAT_ENB
		/// </summary>
		public bool CstatEnb { get; }

		/// <summary>
		/// Value of variable $RETRY_AUTH
		/// </summary>
		public bool RetryAuth { get; }

		/// <summary>
		/// Value of variable $TP_UPDTIME
		/// </summary>
		public int TpUpdtime { get; }

		/// <summary>
		/// Value of variable $PCOUNT
		/// </summary>
		public int Pcount { get; }

		/// <summary>
		/// Value of variable $PINFO
		/// </summary>
		public PinfoVariableType[] Pinfo { get; }

		/// <summary>
		/// Value of variable $VCOUNT
		/// </summary>
		public int Vcount { get; }

		/// <summary>
		/// Value of variable $TP_RMTIME
		/// </summary>
		public int TpRmtime { get; }

		/// <summary>
		/// Value of variable $ACC_TIMER
		/// </summary>
		public int AccTimer { get; }

		/// <summary>
		/// Value of variable $ACC_SNAP
		/// </summary>
		public int AccSnap { get; }

		/// <summary>
		/// Value of variable $DUMMY1
		/// </summary>
		public int Dummy1 { get; }

		/// <summary>
		/// Value of variable $DUMMY2
		/// </summary>
		public int Dummy2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
