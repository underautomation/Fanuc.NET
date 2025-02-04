//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type WAIT_DATA_T
	/// </summary>
	public class WaitDataVariableType : GenericVariableType, IGenericVariableType {


		public WaitDataVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $PROG_NAME
		/// </summary>
		public string ProgName { get; }

		/// <summary>
		/// Value of variable $LINE_NUM
		/// </summary>
		public int LineNum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
