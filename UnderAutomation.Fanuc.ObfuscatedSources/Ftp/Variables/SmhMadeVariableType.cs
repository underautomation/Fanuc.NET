//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SMH_MADE_T
	/// </summary>
	public class SmhMadeVariableType : GenericVariableType, IGenericVariableType {


		public SmhMadeVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MADE_TASKS
		/// </summary>
		public int MadeTasks { get; }

		/// <summary>
		/// Value of variable $MADE_GRUPS
		/// </summary>
		public int MadeGrups { get; }

		/// <summary>
		/// Value of variable $MADE_MIRS
		/// </summary>
		public int MadeMirs { get; }

		/// <summary>
		/// Value of variable $MADE_AMRS
		/// </summary>
		public int MadeAmrs { get; }

		/// <summary>
		/// Value of variable $MADE_MODE
		/// </summary>
		public int MadeMode { get; }

		/// <summary>
		/// Value of variable $MADE_STK
		/// </summary>
		public int MadeStk { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
