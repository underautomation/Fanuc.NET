//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PASSWORD_T
	/// </summary>
	public class PasswordVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TIME_OUT
		/// </summary>
		public short[] TimeOut { get; }

		/// <summary>
		/// Value of variable $CURR_LEVEL
		/// </summary>
		public short[] CurrLevel { get; }

		/// <summary>
		/// Value of variable $CURR_USER
		/// </summary>
		public short[] CurrUser { get; }

		/// <summary>
		/// Value of variable $NUM_USERS
		/// </summary>
		public short NumUsers { get; }

		/// <summary>
		/// Value of variable $STOP_TPCHG
		/// </summary>
		public short StopTpchg { get; }

		/// <summary>
		/// Value of variable $LOG_EVENTS
		/// </summary>
		public bool LogEvents { get; }

		/// <summary>
		/// Value of variable $LEVELS
		/// </summary>
		public int[] Levels { get; }

		/// <summary>
		/// Value of variable $COUNT_DOWN
		/// </summary>
		public int[] CountDown { get; }

		/// <summary>
		/// Value of variable $ENB_PCMPWD
		/// </summary>
		public bool EnbPcmpwd { get; }

		/// <summary>
		/// Value of variable $DVPCM_LOGIN
		/// </summary>
		public int DvpcmLogin { get; }

		/// <summary>
		/// Value of variable $PCM_LOGIN
		/// </summary>
		public short[] PcmLogin { get; }

		/// <summary>
		/// Value of variable $ENB_LVCHK
		/// </summary>
		public bool EnbLvchk { get; }

		/// <summary>
		/// Value of variable $ENB_FULLMN
		/// </summary>
		public bool EnbFullmn { get; }

		/// <summary>
		/// Value of variable $ENB_TIMEXT
		/// </summary>
		public bool EnbTimext { get; }

		/// <summary>
		/// Value of variable $ENB_CNTDWN
		/// </summary>
		public bool EnbCntdwn { get; }

		/// <summary>
		/// Value of variable $ENB_MENU
		/// </summary>
		public bool EnbMenu { get; }

		/// <summary>
		/// Value of variable $AUTOLOGIN
		/// </summary>
		public bool Autologin { get; }

		/// <summary>
		/// Value of variable $ENB_CFG_DSP
		/// </summary>
		public bool EnbCfgDsp { get; }

		/// <summary>
		/// Value of variable $ENB_RLS_DSP
		/// </summary>
		public bool EnbRlsDsp { get; }

		/// <summary>
		/// Value of variable $ULOG_EVENTS
		/// </summary>
		public bool UlogEvents { get; }

		/// <summary>
		/// Value of variable $BURYBANMENU
		/// </summary>
		public bool Burybanmenu { get; }

		/// <summary>
		/// Value of variable $ENB_GILOGIN
		/// </summary>
		public bool EnbGilogin { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
