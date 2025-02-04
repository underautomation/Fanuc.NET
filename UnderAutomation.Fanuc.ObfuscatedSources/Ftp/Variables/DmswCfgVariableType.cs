//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DMSW_CFG_T
	/// </summary>
	public class DmswCfgVariableType : GenericVariableType, IGenericVariableType {


		public DmswCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $KEYIMAGE
		/// </summary>
		public int Keyimage { get; }

		/// <summary>
		/// Value of variable $TMS_DSB
		/// </summary>
		public bool TmsDsb { get; }

		/// <summary>
		/// Value of variable $TMS_STAT
		/// </summary>
		public int TmsStat { get; }

		/// <summary>
		/// Value of variable $TMS_INPUT
		/// </summary>
		public int TmsInput { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
