//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UEGRP_T
	/// </summary>
	public class UegrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ERR_COUNT
		/// </summary>
		public int ErrCount { get; }

		/// <summary>
		/// Value of variable $PROGMTN_FLG
		/// </summary>
		public bool ProgmtnFlg { get; }

		/// <summary>
		/// Value of variable $CURR_POS
		/// </summary>
		public double[] CurrPos { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
