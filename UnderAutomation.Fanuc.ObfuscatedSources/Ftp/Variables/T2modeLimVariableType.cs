//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type T2MODE_LIM_T
	/// </summary>
	public class T2modeLimVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $JOG_OPE
		/// </summary>
		public bool JogOpe { get; }

		/// <summary>
		/// Value of variable $TPP_EDIT
		/// </summary>
		public bool TppEdit { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
