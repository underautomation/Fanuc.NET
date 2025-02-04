//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MTCOM_CFG_T
	/// </summary>
	public class MtcomCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CNC_NO
		/// </summary>
		public int CncNo { get; }

		/// <summary>
		/// Value of variable $NORES_TIMEO
		/// </summary>
		public int NoresTimeo { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
