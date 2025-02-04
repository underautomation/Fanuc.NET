//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type OVRD_SETUP_T
	/// </summary>
	public class OvrdSetupVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $OVRD_NUM
		/// </summary>
		public int OvrdNum { get; }

		/// <summary>
		/// Value of variable $OVERRIDE
		/// </summary>
		public int[] Override { get; }

		/// <summary>
		/// Value of variable $OVRD_NUM_S
		/// </summary>
		public int OvrdNumS { get; }

		/// <summary>
		/// Value of variable $OVERRIDE_S
		/// </summary>
		public int[] OverrideS { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
