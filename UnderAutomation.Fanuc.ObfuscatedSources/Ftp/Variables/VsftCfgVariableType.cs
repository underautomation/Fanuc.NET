//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VSFT_CFG_T
	/// </summary>
	public class VsftCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $VISION_TYPE
		/// </summary>
		public int VisionType { get; }

		/// <summary>
		/// Value of variable $EXPOSURE
		/// </summary>
		public int Exposure { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
