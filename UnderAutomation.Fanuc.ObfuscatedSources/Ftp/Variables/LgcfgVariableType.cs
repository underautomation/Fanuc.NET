//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type LGCFG_T
	/// </summary>
	public class LgcfgVariableType : GenericVariableType, IGenericVariableType {


		public LgcfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $LG_SIZE
		/// </summary>
		public int LgSize { get; }

		/// <summary>
		/// Value of variable $EV_SIZE
		/// </summary>
		public int EvSize { get; }

		/// <summary>
		/// Value of variable $MR_SIZE
		/// </summary>
		public int MrSize { get; }

		/// <summary>
		/// Value of variable $SG_SIZE
		/// </summary>
		public int SgSize { get; }

		/// <summary>
		/// Value of variable $FD_SIZE
		/// </summary>
		public int FdSize { get; }

		/// <summary>
		/// Value of variable $MI_SIZE
		/// </summary>
		public int MiSize { get; }

		/// <summary>
		/// Value of variable $ER_SIZE
		/// </summary>
		public int ErSize { get; }

		/// <summary>
		/// Value of variable $MP_SIZE
		/// </summary>
		public int MpSize { get; }

		/// <summary>
		/// Value of variable $MG_SIZE
		/// </summary>
		public int MgSize { get; }

		/// <summary>
		/// Value of variable $PE_SIZE
		/// </summary>
		public int PeSize { get; }

		/// <summary>
		/// Value of variable $SV_SIZE
		/// </summary>
		public int SvSize { get; }

		/// <summary>
		/// Value of variable $LG_MODE
		/// </summary>
		public int LgMode { get; }

		/// <summary>
		/// Value of variable $EV_MODE
		/// </summary>
		public int EvMode { get; }

		/// <summary>
		/// Value of variable $MR_MODE
		/// </summary>
		public int MrMode { get; }

		/// <summary>
		/// Value of variable $SG_MODE
		/// </summary>
		public int SgMode { get; }

		/// <summary>
		/// Value of variable $FD_MODE
		/// </summary>
		public int FdMode { get; }

		/// <summary>
		/// Value of variable $PE_MODE
		/// </summary>
		public int PeMode { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public int CompSw { get; }

		/// <summary>
		/// Value of variable $TOL_ROT_CMD
		/// </summary>
		public double TolRotCmd { get; }

		/// <summary>
		/// Value of variable $TOL_LIN_CMD
		/// </summary>
		public double TolLinCmd { get; }

		/// <summary>
		/// Value of variable $TOL_ROT_FB
		/// </summary>
		public double TolRotFb { get; }

		/// <summary>
		/// Value of variable $TOL_LIN_FB
		/// </summary>
		public double TolLinFb { get; }

		/// <summary>
		/// Value of variable $LG_PATH
		/// </summary>
		public string LgPath { get; }

		/// <summary>
		/// Value of variable $LG_FILE
		/// </summary>
		public string LgFile { get; }

		/// <summary>
		/// Value of variable $EV_FILE
		/// </summary>
		public string EvFile { get; }

		/// <summary>
		/// Value of variable $MR_FILE
		/// </summary>
		public string MrFile { get; }

		/// <summary>
		/// Value of variable $SG_FILE
		/// </summary>
		public string SgFile { get; }

		/// <summary>
		/// Value of variable $FD_FILE
		/// </summary>
		public string FdFile { get; }

		/// <summary>
		/// Value of variable $MI_FILE
		/// </summary>
		public string MiFile { get; }

		/// <summary>
		/// Value of variable $ER_FILE
		/// </summary>
		public string ErFile { get; }

		/// <summary>
		/// Value of variable $MP_FILE
		/// </summary>
		public string MpFile { get; }

		/// <summary>
		/// Value of variable $PE_FILE
		/// </summary>
		public string PeFile { get; }

		/// <summary>
		/// Value of variable $SV_FILE
		/// </summary>
		public string SvFile { get; }

		/// <summary>
		/// Value of variable $LG_ZIPDUMP
		/// </summary>
		public int LgZipdump { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
