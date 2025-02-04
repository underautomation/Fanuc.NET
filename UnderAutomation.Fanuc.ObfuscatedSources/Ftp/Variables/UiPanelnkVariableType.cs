//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_PANELNK_T
	/// </summary>
	public class UiPanelnkVariableType : GenericVariableType, IGenericVariableType {


		public UiPanelnkVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $HELP_URL
		/// </summary>
		public string[] HelpUrl { get; }

		/// <summary>
		/// Value of variable $HLP_CONTEXT
		/// </summary>
		public int[] HlpContext { get; }

		/// <summary>
		/// Value of variable $HELP_FLAG
		/// </summary>
		public int[] HelpFlag { get; }

		/// <summary>
		/// Value of variable $RELV_INDEX
		/// </summary>
		public int RelvIndex { get; }

		/// <summary>
		/// Value of variable $RELV_URL
		/// </summary>
		public string[] RelvUrl { get; }

		/// <summary>
		/// Value of variable $RELV_MTEXT
		/// </summary>
		public string[] RelvMtext { get; }

		/// <summary>
		/// Value of variable $RELV_CONTEX
		/// </summary>
		public int[] RelvContex { get; }

		/// <summary>
		/// Value of variable $RELV_FLAGS
		/// </summary>
		public int[] RelvFlags { get; }

		/// <summary>
		/// Value of variable $RELV_SPID
		/// </summary>
		public int[] RelvSpid { get; }

		/// <summary>
		/// Value of variable $RELV_SCID
		/// </summary>
		public int[] RelvScid { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
