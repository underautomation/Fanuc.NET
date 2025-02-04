//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TX_T
	/// </summary>
	public class TxVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CONNECTED
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Value of variable $WDOG_ENABLE
		/// </summary>
		public bool WdogEnable { get; }

		/// <summary>
		/// Value of variable $WDOG_ERPOST
		/// </summary>
		public bool WdogErpost { get; }

		/// <summary>
		/// Value of variable $WDOG_TIMER
		/// </summary>
		public int WdogTimer { get; }

		/// <summary>
		/// Value of variable $UPDATE_MAX
		/// </summary>
		public int UpdateMax { get; }

		/// <summary>
		/// Value of variable $COMM_MODE
		/// </summary>
		public byte CommMode { get; }

		/// <summary>
		/// Value of variable $SPEED
		/// </summary>
		public byte Speed { get; }

		/// <summary>
		/// Value of variable $TLNT_TIMER
		/// </summary>
		public int TlntTimer { get; }

		/// <summary>
		/// Value of variable $IPADDR
		/// </summary>
		public int Ipaddr { get; }

		/// <summary>
		/// Value of variable $INPUT_PORT
		/// </summary>
		public int InputPort { get; }

		/// <summary>
		/// Value of variable $SLOW_TIMER
		/// </summary>
		public int SlowTimer { get; }

		/// <summary>
		/// Value of variable $VERSION
		/// </summary>
		public string Version { get; }

		/// <summary>
		/// Value of variable $COREVERSION
		/// </summary>
		public string Coreversion { get; }

		/// <summary>
		/// Value of variable $CONFIG_FLAG
		/// </summary>
		public int ConfigFlag { get; }

		/// <summary>
		/// Value of variable $TOUCH_ENB
		/// </summary>
		public bool TouchEnb { get; }

		/// <summary>
		/// Value of variable $TP3D
		/// </summary>
		public bool Tp3d { get; }

		/// <summary>
		/// Value of variable $HAPTIC_DEV
		/// </summary>
		public int HapticDev { get; }

		/// <summary>
		/// Value of variable $HTCG_PORT
		/// </summary>
		public int HtcgPort { get; }

		/// <summary>
		/// Value of variable $HTTC_PORT
		/// </summary>
		public int HttcPort { get; }

		/// <summary>
		/// Value of variable $VERT_RES
		/// </summary>
		public int VertRes { get; }

		/// <summary>
		/// Value of variable $HORZ_RES
		/// </summary>
		public int HorzRes { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
