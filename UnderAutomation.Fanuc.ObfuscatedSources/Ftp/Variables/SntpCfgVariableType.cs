//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SNTP_CFG_T
	/// </summary>
	public class SntpCfgVariableType : GenericVariableType, IGenericVariableType {


		public SntpCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $SERVER
		/// </summary>
		public string Server { get; }

		/// <summary>
		/// Value of variable $TIME_WIN
		/// </summary>
		public int TimeWin { get; }

		/// <summary>
		/// Value of variable $TZ_INDEX
		/// </summary>
		public int TzIndex { get; }

		/// <summary>
		/// Value of variable $TZ_OFFSET
		/// </summary>
		public int TzOffset { get; }

		/// <summary>
		/// Value of variable $CUR_OFFSET
		/// </summary>
		public int CurOffset { get; }

		/// <summary>
		/// Value of variable $DST
		/// </summary>
		public bool Dst { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
