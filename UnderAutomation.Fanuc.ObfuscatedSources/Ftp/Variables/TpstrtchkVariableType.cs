//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TPSTRTCHK_T
	/// </summary>
	public class TpstrtchkVariableType : GenericVariableType, IGenericVariableType {


		public TpstrtchkVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $ALLOW_NAME
		/// </summary>
		public string AllowName { get; }

		/// <summary>
		/// Value of variable $ALLOW_LINE
		/// </summary>
		public int AllowLine { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
