//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PLID_CFG_T
	/// </summary>
	public class PlidCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $COMP_SWITCH
		/// </summary>
		public int CompSwitch { get; }

		/// <summary>
		/// Value of variable $EST_WO_MASS
		/// </summary>
		public bool EstWoMass { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
