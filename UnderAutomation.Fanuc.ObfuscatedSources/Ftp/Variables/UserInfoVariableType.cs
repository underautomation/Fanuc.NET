//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type USER_INFO_T
	/// </summary>
	public class UserInfoVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $USR_PROG
		/// </summary>
		public string UsrProg { get; }

		/// <summary>
		/// Value of variable $TASK_ID
		/// </summary>
		public short TaskId { get; }

		/// <summary>
		/// Value of variable $USR_POSIDX
		/// </summary>
		public short UsrPosidx { get; }

		/// <summary>
		/// Value of variable $USR_PR_USE
		/// </summary>
		public bool UsrPrUse { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
