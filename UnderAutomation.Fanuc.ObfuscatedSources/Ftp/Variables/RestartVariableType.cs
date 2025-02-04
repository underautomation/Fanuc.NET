//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type RESTART_T
	/// </summary>
	public class RestartVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $FLAG
		/// </summary>
		public bool Flag { get; }

		/// <summary>
		/// Value of variable $DSB_SIGNAL
		/// </summary>
		public int DsbSignal { get; }

		/// <summary>
		/// Value of variable $STARTUP_CND
		/// </summary>
		public int StartupCnd { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
