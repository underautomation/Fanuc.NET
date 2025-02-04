//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ER_NOAUTO_T
	/// </summary>
	public class ErNoautoVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NOAUTO_ENB
		/// </summary>
		public bool NoautoEnb { get; }

		/// <summary>
		/// Value of variable $NOAUTO_NUM
		/// </summary>
		public short NoautoNum { get; }

		/// <summary>
		/// Value of variable $PS_NOAUTO_C
		/// </summary>
		public short PsNoautoC { get; }

		/// <summary>
		/// Value of variable $NOAUTO_CODE
		/// </summary>
		public int[] NoautoCode { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
