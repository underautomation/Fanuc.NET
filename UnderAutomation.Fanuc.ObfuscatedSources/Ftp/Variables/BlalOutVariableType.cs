//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type BLAL_OUT_T
	/// </summary>
	public class BlalOutVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $DO_INDEX
		/// </summary>
		public short DoIndex { get; }

		/// <summary>
		/// Value of variable $PS_BATALM_O
		/// </summary>
		public short PsBatalmO { get; }

		/// <summary>
		/// Value of variable $BATALM_OR
		/// </summary>
		public bool BatalmOr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
