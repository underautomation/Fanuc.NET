//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VCRSM_CFG_T
	/// </summary>
	public class VcrsmCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $STEP_NUM
		/// </summary>
		public int StepNum { get; }

		/// <summary>
		/// Value of variable $IS_STARTED
		/// </summary>
		public bool IsStarted { get; }

		/// <summary>
		/// Value of variable $CUR_PROG
		/// </summary>
		public string CurProg { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
