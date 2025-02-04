//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UPR_T
	/// </summary>
	public class UprVariableType : GenericVariableType, IGenericVariableType {


		public UprVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MOTYPE
		/// </summary>
		public int Motype { get; }

		/// <summary>
		/// Value of variable $TERMTYPE
		/// </summary>
		public int Termtype { get; }

		/// <summary>
		/// Value of variable $SEGTERMTYPE
		/// </summary>
		public int Segtermtype { get; }

		/// <summary>
		/// Value of variable $DECELTOL
		/// </summary>
		public double Deceltol { get; }

		/// <summary>
		/// Value of variable $USE_CONFIG
		/// </summary>
		public bool UseConfig { get; }

		/// <summary>
		/// Value of variable $USE_TURNS
		/// </summary>
		public bool UseTurns { get; }

		/// <summary>
		/// Value of variable $ORIENT_TYPE
		/// </summary>
		public int OrientType { get; }

		/// <summary>
		/// Value of variable $UFRAME
		/// </summary>
		public CartesianPositionVariable Uframe { get; }

		/// <summary>
		/// Value of variable $UTOOL
		/// </summary>
		public CartesianPositionVariable Utool { get; }

		/// <summary>
		/// Value of variable $SPEED
		/// </summary>
		public double Speed { get; }

		/// <summary>
		/// Value of variable $ROTSPEED
		/// </summary>
		public double Rotspeed { get; }

		/// <summary>
		/// Value of variable $CONTAXISVEL
		/// </summary>
		public double Contaxisvel { get; }

		/// <summary>
		/// Value of variable $CNSTNT_PATH
		/// </summary>
		public bool CnstntPath { get; }

		/// <summary>
		/// Value of variable $CNSTNTPTHJT
		/// </summary>
		public bool Cnstntpthjt { get; }

		/// <summary>
		/// Value of variable $SEG_TIME
		/// </summary>
		public int SegTime { get; }

		/// <summary>
		/// Value of variable $USE_CARTACC
		/// </summary>
		public bool UseCartacc { get; }

		/// <summary>
		/// Value of variable $USEMAXACCEL
		/// </summary>
		public bool Usemaxaccel { get; }

		/// <summary>
		/// Value of variable $USERELACCEL
		/// </summary>
		public bool Userelaccel { get; }

		/// <summary>
		/// Value of variable $USETIMESHFT
		/// </summary>
		public bool Usetimeshft { get; }

		/// <summary>
		/// Value of variable $USE_PATHACC
		/// </summary>
		public bool UsePathacc { get; }

		/// <summary>
		/// Value of variable $USE_SHORTMO
		/// </summary>
		public bool UseShortmo { get; }

		/// <summary>
		/// Value of variable $SM_PROFILE
		/// </summary>
		public int SmProfile { get; }

		/// <summary>
		/// Value of variable $TA_PROFILE
		/// </summary>
		public int TaProfile { get; }

		/// <summary>
		/// Value of variable $ACCEL_OVRD
		/// </summary>
		public int AccelOvrd { get; }

		/// <summary>
		/// Value of variable $TIME_SHIFT
		/// </summary>
		public int TimeShift { get; }

		/// <summary>
		/// Value of variable $ACCU_NUM
		/// </summary>
		public int AccuNum { get; }

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public double Payload { get; }

		/// <summary>
		/// Value of variable $DYN_I_COMP
		/// </summary>
		public bool DynIComp { get; }

		/// <summary>
		/// Value of variable $PATHRES_ENB
		/// </summary>
		public bool PathresEnb { get; }

		/// <summary>
		/// Value of variable $RESERVE1
		/// </summary>
		public int Reserve1 { get; }

		/// <summary>
		/// Value of variable $CNT_SHORTMO
		/// </summary>
		public bool CntShortmo { get; }

		/// <summary>
		/// Value of variable $EXT_SPEED
		/// </summary>
		public double ExtSpeed { get; }

		/// <summary>
		/// Value of variable $CNT_ACCEL1
		/// </summary>
		public short CntAccel1 { get; }

		/// <summary>
		/// Value of variable $CNT_ACCEL2
		/// </summary>
		public short CntAccel2 { get; }

		/// <summary>
		/// Value of variable $CRCCOMPENB
		/// </summary>
		public bool Crccompenb { get; }

		/// <summary>
		/// Value of variable $ASYMFLTRENB
		/// </summary>
		public bool Asymfltrenb { get; }

		/// <summary>
		/// Value of variable $USE_WJTURNS
		/// </summary>
		public bool UseWjturns { get; }

		/// <summary>
		/// Value of variable $EXT_INDEP
		/// </summary>
		public bool ExtIndep { get; }

		/// <summary>
		/// Value of variable $CARTFLTRENB
		/// </summary>
		public bool Cartfltrenb { get; }

		/// <summary>
		/// Value of variable $CNT_SPEEDUP
		/// </summary>
		public bool CntSpeedup { get; }

		/// <summary>
		/// Value of variable $CNT_DYN_ACC
		/// </summary>
		public bool CntDynAcc { get; }

		/// <summary>
		/// Value of variable $MAX_SPEED
		/// </summary>
		public bool MaxSpeed { get; }

		/// <summary>
		/// Value of variable $USERELPSPD
		/// </summary>
		public bool Userelpspd { get; }

		/// <summary>
		/// Value of variable $PSPD_OVRD
		/// </summary>
		public int PspdOvrd { get; }

		/// <summary>
		/// Value of variable $ORNT_MROT
		/// </summary>
		public bool OrntMrot { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
