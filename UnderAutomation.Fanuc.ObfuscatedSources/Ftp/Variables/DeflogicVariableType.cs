//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DEFLOGIC_T
	/// </summary>
	public class DeflogicVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $FUNC_TITLE
		/// </summary>
		public string FuncTitle { get; }

		/// <summary>
		/// Value of variable $TOTAL_NUM
		/// </summary>
		public byte TotalNum { get; }

		/// <summary>
		/// Value of variable $DUMMY2
		/// </summary>
		public byte Dummy2 { get; }

		/// <summary>
		/// Value of variable $DUMMY3
		/// </summary>
		public byte Dummy3 { get; }

		/// <summary>
		/// Value of variable $DUMMY4
		/// </summary>
		public byte Dummy4 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
