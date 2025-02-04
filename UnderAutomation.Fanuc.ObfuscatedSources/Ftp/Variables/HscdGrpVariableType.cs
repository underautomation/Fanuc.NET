//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HSCD_GRP_T
	/// </summary>
	public class HscdGrpVariableType : GenericVariableType, IGenericVariableType {


		public HscdGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $COL_DET_OFF
		/// </summary>
		public bool ColDetOff { get; }

		/// <summary>
		/// Value of variable $HSCD_PRM_ID
		/// </summary>
		public string HscdPrmId { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
