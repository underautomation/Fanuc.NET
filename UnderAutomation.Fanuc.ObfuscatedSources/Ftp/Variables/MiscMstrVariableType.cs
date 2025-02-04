//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MISC_MSTR_T
	/// </summary>
	public class MiscMstrVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $HPD_ENB
		/// </summary>
		public bool HpdEnb { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
