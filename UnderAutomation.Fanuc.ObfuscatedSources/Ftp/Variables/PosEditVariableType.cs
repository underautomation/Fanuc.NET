//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type POS_EDIT_T
	/// </summary>
	public class PosEditVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $LOCK_POSNUM
		/// </summary>
		public bool LockPosnum { get; }

		/// <summary>
		/// Value of variable $HIDE_MENU
		/// </summary>
		public bool HideMenu { get; }

		/// <summary>
		/// Value of variable $HIDE_POSNUM
		/// </summary>
		public bool HidePosnum { get; }

		/// <summary>
		/// Value of variable $AUTO_RENUM
		/// </summary>
		public bool AutoRenum { get; }

		/// <summary>
		/// Value of variable $COPY_POSDAT
		/// </summary>
		public bool CopyPosdat { get; }

		/// <summary>
		/// Value of variable $AUTO_RENUM2
		/// </summary>
		public bool AutoRenum2 { get; }

		/// <summary>
		/// Value of variable $RMV_MANRENM
		/// </summary>
		public bool RmvManrenm { get; }

		/// <summary>
		/// Value of variable $COPY_POSTYP
		/// </summary>
		public int CopyPostyp { get; }

		/// <summary>
		/// Value of variable $CPRUT_ENB
		/// </summary>
		public bool CprutEnb { get; }

		/// <summary>
		/// Value of variable $CONF_TOUCH
		/// </summary>
		public bool ConfTouch { get; }

		/// <summary>
		/// Value of variable $GUN_TOUCH
		/// </summary>
		public bool GunTouch { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
