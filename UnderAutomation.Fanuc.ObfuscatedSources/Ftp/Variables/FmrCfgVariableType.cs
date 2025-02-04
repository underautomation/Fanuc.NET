//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FMR_CFG_T
	/// </summary>
	public class FmrCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TROV_MAX
		/// </summary>
		public byte[] TrovMax { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
