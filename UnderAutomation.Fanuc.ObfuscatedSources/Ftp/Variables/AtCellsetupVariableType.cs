//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AT_CELLSETUP
	/// </summary>
	public class AtCellsetupVariableType : GenericVariableType, IGenericVariableType {


		public AtCellsetupVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $HOME_IO_PRG
		/// </summary>
		public string HomeIoPrg { get; }

		/// <summary>
		/// Value of variable $HOME_MACRO
		/// </summary>
		public string HomeMacro { get; }

		/// <summary>
		/// Value of variable $REPR_MACRO
		/// </summary>
		public string ReprMacro { get; }

		/// <summary>
		/// Value of variable $PRODRUN_SPD
		/// </summary>
		public int ProdrunSpd { get; }

		/// <summary>
		/// Value of variable $PRODRSM_SPD
		/// </summary>
		public int ProdrsmSpd { get; }

		/// <summary>
		/// Value of variable $HMIO_MN_ENB
		/// </summary>
		public bool HmioMnEnb { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
