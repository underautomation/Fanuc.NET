//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CHG_PRI_T
	/// </summary>
	public class ChgPriVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TASK_ID
		/// </summary>
		public int TaskId { get; }

		/// <summary>
		/// Value of variable $PRIORITY
		/// </summary>
		public int Priority { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
