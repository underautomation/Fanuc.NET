//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type COLLECT_T
	/// </summary>
	public class CollectVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MULTI_PROG
		/// </summary>
		public bool MultiProg { get; }

		/// <summary>
		/// Value of variable $ALLOW_PROC
		/// </summary>
		public bool AllowProc { get; }

		/// <summary>
		/// Value of variable $FSTCHILDREN
		/// </summary>
		public bool Fstchildren { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
