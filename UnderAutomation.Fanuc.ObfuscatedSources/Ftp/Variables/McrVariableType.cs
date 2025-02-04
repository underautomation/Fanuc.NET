//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MCR_T
	/// </summary>
	public class McrVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENBL
		/// </summary>
		public bool Enbl { get; }

		/// <summary>
		/// Value of variable $SFSPD
		/// </summary>
		public bool Sfspd { get; }

		/// <summary>
		/// Value of variable $BRK_OUT_ENB
		/// </summary>
		public bool BrkOutEnb { get; }

		/// <summary>
		/// Value of variable $BRK_OUTPUT
		/// </summary>
		public bool[] BrkOutput { get; }

		/// <summary>
		/// Value of variable $OT_RELEASE
		/// </summary>
		public bool OtRelease { get; }

		/// <summary>
		/// Value of variable $DRY_RUN
		/// </summary>
		public bool DryRun { get; }

		/// <summary>
		/// Value of variable $GENOVERRIDE
		/// </summary>
		public int Genoverride { get; }

		/// <summary>
		/// Value of variable $FLTR_DEBUG
		/// </summary>
		public int FltrDebug { get; }

		/// <summary>
		/// Value of variable $MMGR_DEBUG
		/// </summary>
		public int MmgrDebug { get; }

		/// <summary>
		/// Value of variable $MJOG_DEBUG
		/// </summary>
		public int MjogDebug { get; }

		/// <summary>
		/// Value of variable $OTF_PRG_ID
		/// </summary>
		public int OtfPrgId { get; }

		/// <summary>
		/// Value of variable $OTF_LIN_NO
		/// </summary>
		public int OtfLinNo { get; }

		/// <summary>
		/// Value of variable $OTF_OFST
		/// </summary>
		public int OtfOfst { get; }

		/// <summary>
		/// Value of variable $SPC_RESET
		/// </summary>
		public bool SpcReset { get; }

		/// <summary>
		/// Value of variable $MO_WARN_ENB
		/// </summary>
		public bool MoWarnEnb { get; }

		/// <summary>
		/// Value of variable $CLD_RELEASE
		/// </summary>
		public bool CldRelease { get; }

		/// <summary>
		/// Value of variable $OVRDSLOW
		/// </summary>
		public int Ovrdslow { get; }

		/// <summary>
		/// Value of variable $OVRDFAST
		/// </summary>
		public int Ovrdfast { get; }

		/// <summary>
		/// Value of variable $FAST_RATE
		/// </summary>
		public int FastRate { get; }

		/// <summary>
		/// Value of variable $SLOW_RATE
		/// </summary>
		public int SlowRate { get; }

		/// <summary>
		/// Value of variable $SLOW_MAX
		/// </summary>
		public int SlowMax { get; }

		/// <summary>
		/// Value of variable $CHAIN_RESET
		/// </summary>
		public bool ChainReset { get; }

		/// <summary>
		/// Value of variable $SHFT_RST_PR
		/// </summary>
		public bool ShftRstPr { get; }

		/// <summary>
		/// Value of variable $ACTOVERRIDE
		/// </summary>
		public int Actoverride { get; }

		/// <summary>
		/// Value of variable $JOGOVERRIDE
		/// </summary>
		public int Jogoverride { get; }

		/// <summary>
		/// Value of variable $OVR_ZERO
		/// </summary>
		public bool OvrZero { get; }

		/// <summary>
		/// Value of variable $OVRZERO_ENB
		/// </summary>
		public bool OvrzeroEnb { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
