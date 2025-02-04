//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CRCFG_T
	/// </summary>
	public class CrcfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $GROUP_MASK
		/// </summary>
		public int GroupMask { get; }

		/// <summary>
		/// Value of variable $MB_CONFLICT
		/// </summary>
		public int MbConflict { get; }

		/// <summary>
		/// Value of variable $MB_REQUIRED
		/// </summary>
		public int MbRequired { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $PGDEBUG
		/// </summary>
		public int Pgdebug { get; }

		/// <summary>
		/// Value of variable $CR_ENHANCED
		/// </summary>
		public bool CrEnhanced { get; }

		/// <summary>
		/// Value of variable $LGORN_ENBL
		/// </summary>
		public bool LgornEnbl { get; }

		/// <summary>
		/// Value of variable $BLEND_ENB
		/// </summary>
		public bool BlendEnb { get; }

		/// <summary>
		/// Value of variable $MAX_ARC_ANG
		/// </summary>
		public double MaxArcAng { get; }

		/// <summary>
		/// Value of variable $RSM_RSPD_LM
		/// </summary>
		public double RsmRspdLm { get; }

		/// <summary>
		/// Value of variable $LGORN_METH
		/// </summary>
		public int LgornMeth { get; }

		/// <summary>
		/// Value of variable $LGORN_DBG
		/// </summary>
		public bool LgornDbg { get; }

		/// <summary>
		/// Value of variable $LGORN_RAD
		/// </summary>
		public int LgornRad { get; }

		/// <summary>
		/// Value of variable $LGORN_AZ_SP
		/// </summary>
		public int LgornAzSp { get; }

		/// <summary>
		/// Value of variable $LGORN_ELTOL
		/// </summary>
		public int LgornEltol { get; }

		/// <summary>
		/// Value of variable $ROTSPDFCTR
		/// </summary>
		public double Rotspdfctr { get; }

		/// <summary>
		/// Value of variable $MAX_FP_SPD
		/// </summary>
		public double MaxFpSpd { get; }

		/// <summary>
		/// Value of variable $SMCRC_RADI
		/// </summary>
		public double SmcrcRadi { get; }

		/// <summary>
		/// Value of variable $SMCRC_RADO
		/// </summary>
		public double SmcrcRado { get; }

		/// <summary>
		/// Value of variable $SMCRC_ARC
		/// </summary>
		public double SmcrcArc { get; }

		/// <summary>
		/// Value of variable $ARCANGLIM
		/// </summary>
		public double Arcanglim { get; }

		/// <summary>
		/// Value of variable $MAXORNTCHG
		/// </summary>
		public double Maxorntchg { get; }

		/// <summary>
		/// Value of variable $MAXSGRATIO
		/// </summary>
		public double Maxsgratio { get; }

		/// <summary>
		/// Value of variable $CHKBMP
		/// </summary>
		public int Chkbmp { get; }

		/// <summary>
		/// Value of variable $RSM_TYP
		/// </summary>
		public int RsmTyp { get; }

		/// <summary>
		/// Value of variable $CHK_MSK
		/// </summary>
		public int ChkMsk { get; }

		/// <summary>
		/// Value of variable $AES_SINGTOL
		/// </summary>
		public double AesSingtol { get; }

		/// <summary>
		/// Value of variable $SW_ORNTBASE
		/// </summary>
		public int SwOrntbase { get; }

		/// <summary>
		/// Value of variable $XYZWPR_TOL
		/// </summary>
		public double[] XyzwprTol { get; }

		/// <summary>
		/// Value of variable $ANG_TOL
		/// </summary>
		public double[] AngTol { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
