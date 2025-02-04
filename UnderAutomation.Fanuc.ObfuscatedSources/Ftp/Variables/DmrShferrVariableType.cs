//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DMR_SHFERR_T
	/// </summary>
	public class DmrShferrVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $OFFSET
		/// </summary>
		public int[] Offset { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
