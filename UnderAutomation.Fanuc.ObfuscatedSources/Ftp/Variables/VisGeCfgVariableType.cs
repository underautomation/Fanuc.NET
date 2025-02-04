//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VIS_GE_CFG_T
	/// </summary>
	public class VisGeCfgVariableType : GenericVariableType, IGenericVariableType {


		public VisGeCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MAX_IMG_SZ
		/// </summary>
		public int MaxImgSz { get; }

		/// <summary>
		/// Value of variable $MAX_IMG_TM
		/// </summary>
		public int MaxImgTm { get; }

		/// <summary>
		/// Value of variable $MAX_CAM_RES
		/// </summary>
		public byte MaxCamRes { get; }

		/// <summary>
		/// Value of variable $NUM_RETRIES
		/// </summary>
		public byte NumRetries { get; }

		/// <summary>
		/// Value of variable $RETRY_DELAY
		/// </summary>
		public byte RetryDelay { get; }

		/// <summary>
		/// Value of variable $DBG_LEVEL
		/// </summary>
		public byte DbgLevel { get; }

		/// <summary>
		/// Value of variable $SPKT_DELAY
		/// </summary>
		public int SpktDelay { get; }

		/// <summary>
		/// Value of variable $CFG_FLAGS
		/// </summary>
		public int CfgFlags { get; }

		/// <summary>
		/// Value of variable $GIGE_NORESE
		/// </summary>
		public bool GigeNorese { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
