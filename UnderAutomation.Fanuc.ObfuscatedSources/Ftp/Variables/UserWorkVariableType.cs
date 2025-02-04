//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type USER_WORK_T
	/// </summary>
	public class UserWorkVariableType : GenericVariableType, IGenericVariableType {


		public UserWorkVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TASK_ID
		/// </summary>
		public short[] TaskId { get; }

		/// <summary>
		/// Value of variable $WAIT_USRADV
		/// </summary>
		public int[] WaitUsradv { get; }

		/// <summary>
		/// Value of variable $ADV_DB_ID
		/// </summary>
		public int[] AdvDbId { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
