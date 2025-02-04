//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_CONFIG_T
	/// </summary>
	public class UiConfigVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NUM_MENUS
		/// </summary>
		public byte NumMenus { get; }

		/// <summary>
		/// Value of variable $NUM_CONNECT
		/// </summary>
		public byte NumConnect { get; }

		/// <summary>
		/// Value of variable $RECOVERMENU
		/// </summary>
		public byte Recovermenu { get; }

		/// <summary>
		/// Value of variable $COLOR_CRT
		/// </summary>
		public byte ColorCrt { get; }

		/// <summary>
		/// Value of variable $TOPMENU_IDX
		/// </summary>
		public byte TopmenuIdx { get; }

		/// <summary>
		/// Value of variable $MEM_LIMIT
		/// </summary>
		public short MemLimit { get; }

		/// <summary>
		/// Value of variable $DBGLVL
		/// </summary>
		public short Dbglvl { get; }

		/// <summary>
		/// Value of variable $POPUP_MASK
		/// </summary>
		public short PopupMask { get; }

		/// <summary>
		/// Value of variable $EXTSTATUS
		/// </summary>
		public byte[] Extstatus { get; }

		/// <summary>
		/// Value of variable $DUMMY73
		/// </summary>
		public byte Dummy73 { get; }

		/// <summary>
		/// Value of variable $MODE
		/// </summary>
		public byte[] Mode { get; }

		/// <summary>
		/// Value of variable $DUMMY74
		/// </summary>
		public byte Dummy74 { get; }

		/// <summary>
		/// Value of variable $FOCUS
		/// </summary>
		public byte[] Focus { get; }

		/// <summary>
		/// Value of variable $DUMMY75
		/// </summary>
		public byte Dummy75 { get; }

		/// <summary>
		/// Value of variable $CONFIG_CHAN
		/// </summary>
		public int[] ConfigChan { get; }

		/// <summary>
		/// Value of variable $TIMEOUT
		/// </summary>
		public short Timeout { get; }

		/// <summary>
		/// Value of variable $PIPESIZE
		/// </summary>
		public short Pipesize { get; }

		/// <summary>
		/// Value of variable $MWIN_LIMIT
		/// </summary>
		public short MwinLimit { get; }

		/// <summary>
		/// Value of variable $PANEMAP
		/// </summary>
		public short[] Panemap { get; }

		/// <summary>
		/// Value of variable $MENU_FAVS
		/// </summary>
		public string[] MenuFavs { get; }

		/// <summary>
		/// Value of variable $HLPMEN_DICT
		/// </summary>
		public string[] HlpmenDict { get; }

		/// <summary>
		/// Value of variable $HLPMEN_ELEM
		/// </summary>
		public short[] HlpmenElem { get; }

		/// <summary>
		/// Value of variable $HLPMEN_URL
		/// </summary>
		public string[] HlpmenUrl { get; }

		/// <summary>
		/// Value of variable $DSPMEN_MASK
		/// </summary>
		public int DspmenMask { get; }

		/// <summary>
		/// Value of variable $HMI_MASK
		/// </summary>
		public short HmiMask { get; }

		/// <summary>
		/// Value of variable $ROTIMEOUT
		/// </summary>
		public short[] Rotimeout { get; }

		/// <summary>
		/// Value of variable $READONLY
		/// </summary>
		public bool[] Readonly { get; }

		/// <summary>
		/// Value of variable $TOUCH_MASK
		/// </summary>
		public int TouchMask { get; }

		/// <summary>
		/// Value of variable $PROG_COMMON
		/// </summary>
		public string[] ProgCommon { get; }

		/// <summary>
		/// Value of variable $ALARM_MASK
		/// </summary>
		public int AlarmMask { get; }

		/// <summary>
		/// Value of variable $FILVEW_MASK
		/// </summary>
		public short FilvewMask { get; }

		/// <summary>
		/// Value of variable $ENB_MENUFAV
		/// </summary>
		public bool EnbMenufav { get; }

		/// <summary>
		/// Value of variable $ENB_USERFAV
		/// </summary>
		public bool EnbUserfav { get; }

		/// <summary>
		/// Value of variable $ENB_FCTNFAV
		/// </summary>
		public bool EnbFctnfav { get; }

		/// <summary>
		/// Value of variable $ENB_WIDE
		/// </summary>
		public bool[] EnbWide { get; }

		/// <summary>
		/// Value of variable $ICON_EDIT
		/// </summary>
		public bool[] IconEdit { get; }

		/// <summary>
		/// Value of variable $FCTN_TITLE
		/// </summary>
		public string FctnTitle { get; }

		/// <summary>
		/// Value of variable $ENB_COORDFV
		/// </summary>
		public bool EnbCoordfv { get; }

		/// <summary>
		/// Value of variable $LOCKMENUFAV
		/// </summary>
		public bool Lockmenufav { get; }

		/// <summary>
		/// Value of variable $LOCKUSERFAV
		/// </summary>
		public bool Lockuserfav { get; }

		/// <summary>
		/// Value of variable $ENB_WEBFORM
		/// </summary>
		public bool EnbWebform { get; }

		/// <summary>
		/// Value of variable $COORD_FAVS
		/// </summary>
		public int[] CoordFavs { get; }

		/// <summary>
		/// Value of variable $LOCKCOORDFV
		/// </summary>
		public bool Lockcoordfv { get; }

		/// <summary>
		/// Value of variable $BACKCOLOR
		/// </summary>
		public int Backcolor { get; }

		/// <summary>
		/// Value of variable $LOCKBGCOLOR
		/// </summary>
		public bool Lockbgcolor { get; }

		/// <summary>
		/// Value of variable $COLOR_INST
		/// </summary>
		public bool ColorInst { get; }

		/// <summary>
		/// Value of variable $IOSTAT_INST
		/// </summary>
		public bool IostatInst { get; }

		/// <summary>
		/// Value of variable $PMN_MAX_PKT
		/// </summary>
		public int PmnMaxPkt { get; }

		/// <summary>
		/// Value of variable $IHELP_TIMER
		/// </summary>
		public int IhelpTimer { get; }

		/// <summary>
		/// Value of variable $BLNK_TIMER
		/// </summary>
		public int BlnkTimer { get; }

		/// <summary>
		/// Value of variable $BLNK_ENABLE
		/// </summary>
		public bool BlnkEnable { get; }

		/// <summary>
		/// Value of variable $SIPMANUAL
		/// </summary>
		public int Sipmanual { get; }

		/// <summary>
		/// Value of variable $BLNK_ALARM
		/// </summary>
		public bool BlnkAlarm { get; }

		/// <summary>
		/// Value of variable $TOUCH_BEEP
		/// </summary>
		public bool TouchBeep { get; }

		/// <summary>
		/// Value of variable $ENB_TOPMENU
		/// </summary>
		public bool EnbTopmenu { get; }

		/// <summary>
		/// Value of variable $ENB_ICONEDT
		/// </summary>
		public bool[] EnbIconedt { get; }

		/// <summary>
		/// Value of variable $BLINK_ICON
		/// </summary>
		public int BlinkIcon { get; }

		/// <summary>
		/// Value of variable $JWDOG_TIMER
		/// </summary>
		public int JwdogTimer { get; }

		/// <summary>
		/// Value of variable $TOUCH_DSBL
		/// </summary>
		public bool TouchDsbl { get; }

		/// <summary>
		/// Value of variable $CGTP_TIMER
		/// </summary>
		public int CgtpTimer { get; }

		/// <summary>
		/// Value of variable $ITP_TIMER
		/// </summary>
		public int ItpTimer { get; }

		/// <summary>
		/// Value of variable $JCGTP_TIMER
		/// </summary>
		public int JcgtpTimer { get; }

		/// <summary>
		/// Value of variable $STYLE
		/// </summary>
		public byte Style { get; }

		/// <summary>
		/// Value of variable $IEDIT_STYLE
		/// </summary>
		public byte IeditStyle { get; }

		/// <summary>
		/// Value of variable $EDITOR_FKEY
		/// </summary>
		public byte EditorFkey { get; }

		/// <summary>
		/// Value of variable $IEDIT_HTML5
		/// </summary>
		public byte IeditHtml5 { get; }

		/// <summary>
		/// Value of variable $DSP_NAME
		/// </summary>
		public string DspName { get; }

		/// <summary>
		/// Value of variable $DIM_TIMER
		/// </summary>
		public int DimTimer { get; }

		/// <summary>
		/// Value of variable $DIM_BRIGHT
		/// </summary>
		public int DimBright { get; }

		/// <summary>
		/// Value of variable $ON_BRIGHT
		/// </summary>
		public int OnBright { get; }

		/// <summary>
		/// Value of variable $BLNK_TCH
		/// </summary>
		public int BlnkTch { get; }

		/// <summary>
		/// Value of variable $ENB_HTML5
		/// </summary>
		public int EnbHtml5 { get; }

		/// <summary>
		/// Value of variable $BT_DEVICE
		/// </summary>
		public int BtDevice { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
