//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SHELL_COMM_T
	/// </summary>
	public class ShellCommVariableType : GenericVariableType, IGenericVariableType {


		public ShellCommVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $FUNC
		/// </summary>
		public int Func { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable $PARM1
		/// </summary>
		public int Parm1 { get; }

		/// <summary>
		/// Value of variable $PARM2
		/// </summary>
		public int Parm2 { get; }

		/// <summary>
		/// Value of variable $PARM3
		/// </summary>
		public int Parm3 { get; }

		/// <summary>
		/// Value of variable $PARM4
		/// </summary>
		public int Parm4 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
