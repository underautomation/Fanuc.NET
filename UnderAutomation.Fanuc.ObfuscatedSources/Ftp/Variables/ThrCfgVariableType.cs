//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type THR_CFG_T
	/// </summary>
	public class ThrCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $MAX_IO_SCAN
		/// </summary>
		public int MaxIoScan { get; }

		/// <summary>
		/// Value of variable $MIN_SCAN_TI
		/// </summary>
		public int MinScanTi { get; }

		/// <summary>
		/// Value of variable $SCAN_TIME
		/// </summary>
		public int ScanTime { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
