//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MIX_BG_T
	/// </summary>
	public class MixBgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PROG_NAME
		/// </summary>
		public string ProgName { get; }

		/// <summary>
		/// Value of variable $MODE
		/// </summary>
		public int Mode { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable $MODIFY_TIME
		/// </summary>
		public int ModifyTime { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
