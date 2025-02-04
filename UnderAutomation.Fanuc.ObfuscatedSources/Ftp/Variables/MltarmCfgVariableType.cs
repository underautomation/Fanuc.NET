//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MLTARM_CFG_T
	/// </summary>
	public class MltarmCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NUM_ARMS
		/// </summary>
		public int NumArms { get; }

		/// <summary>
		/// Value of variable $GROUP
		/// </summary>
		public int[] Group { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
