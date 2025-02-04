//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type IRPROG_CFG_T
	/// </summary>
	public class IrprogCfgVariableType : GenericVariableType, IGenericVariableType {


		public IrprogCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CURR_URL
		/// </summary>
		public string CurrUrl { get; }

		/// <summary>
		/// Value of variable $ALL_MENUS
		/// </summary>
		public bool AllMenus { get; }

		/// <summary>
		/// Value of variable $VISI_PRG
		/// </summary>
		public int VisiPrg { get; }

		/// <summary>
		/// Value of variable $TABLET_UI
		/// </summary>
		public int TabletUi { get; }

		/// <summary>
		/// Value of variable $TABKY_DBG
		/// </summary>
		public bool TabkyDbg { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
