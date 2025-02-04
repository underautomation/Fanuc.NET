//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CONDET_DATA_
	/// </summary>
	public class CondetDataVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $STYLE
		/// </summary>
		public int Style { get; }

		/// <summary>
		/// Value of variable $PROG_NAME
		/// </summary>
		public string ProgName { get; }

		/// <summary>
		/// Value of variable $VAR_NAME
		/// </summary>
		public string VarName { get; }

		/// <summary>
		/// Value of variable $REG_NUM
		/// </summary>
		public int RegNum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
