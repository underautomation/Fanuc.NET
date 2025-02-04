//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PRGNS_PREF_T
	/// </summary>
	public class PrgnsPrefVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $GRIDLINES
		/// </summary>
		public int Gridlines { get; }

		/// <summary>
		/// Value of variable $BARS_NUM
		/// </summary>
		public int BarsNum { get; }

		/// <summary>
		/// Value of variable $STYLE
		/// </summary>
		public int Style { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
