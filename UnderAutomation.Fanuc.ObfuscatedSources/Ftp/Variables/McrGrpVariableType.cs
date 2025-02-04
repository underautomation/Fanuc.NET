//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MCR_GRP_T
	/// </summary>
	public class McrGrpVariableType : GenericVariableType, IGenericVariableType {


		public McrGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CALIBRATE
		/// </summary>
		public bool Calibrate { get; }

		/// <summary>
		/// Value of variable $CRC_RSM_TOL
		/// </summary>
		public double CrcRsmTol { get; }

		/// <summary>
		/// Value of variable $HOLD
		/// </summary>
		public bool Hold { get; }

		/// <summary>
		/// Value of variable $HARD_HOLD
		/// </summary>
		public bool HardHold { get; }

		/// <summary>
		/// Value of variable $MACHINELOCK
		/// </summary>
		public bool Machinelock { get; }

		/// <summary>
		/// Value of variable $MASTER
		/// </summary>
		public bool Master { get; }

		/// <summary>
		/// Value of variable $PRGOVERRIDE
		/// </summary>
		public double Prgoverride { get; }

		/// <summary>
		/// Value of variable $DRY_RUN_SPD
		/// </summary>
		public double DryRunSpd { get; }

		/// <summary>
		/// Value of variable $DRYRUN_JSPD
		/// </summary>
		public double DryrunJspd { get; }

		/// <summary>
		/// Value of variable $DRY_JOG_OVR
		/// </summary>
		public double DryJogOvr { get; }

		/// <summary>
		/// Value of variable $RSM_SPEED
		/// </summary>
		public double RsmSpeed { get; }

		/// <summary>
		/// Value of variable $RSM_MOTYPE
		/// </summary>
		public int RsmMotype { get; }

		/// <summary>
		/// Value of variable $RSM_TERMTYP
		/// </summary>
		public int RsmTermtyp { get; }

		/// <summary>
		/// Value of variable $JNT_PRC_ENB
		/// </summary>
		public bool JntPrcEnb { get; }

		/// <summary>
		/// Value of variable $SOFT_ALARM
		/// </summary>
		public bool SoftAlarm { get; }

		/// <summary>
		/// Value of variable $SYN_ADJ_MOD
		/// </summary>
		public bool SynAdjMod { get; }

		/// <summary>
		/// Value of variable $SYN_ADJ_SEL
		/// </summary>
		public bool SynAdjSel { get; }

		/// <summary>
		/// Value of variable $TURN_ON_SRV
		/// </summary>
		public bool TurnOnSrv { get; }

		/// <summary>
		/// Value of variable $RSM_OFFSET
		/// </summary>
		public double RsmOffset { get; }

		/// <summary>
		/// Value of variable $SET_REF
		/// </summary>
		public bool SetRef { get; }

		/// <summary>
		/// Value of variable $MASTER_TYPE
		/// </summary>
		public short MasterType { get; }

		/// <summary>
		/// Value of variable $INTR_DEBUG
		/// </summary>
		public int IntrDebug { get; }

		/// <summary>
		/// Value of variable $PLAN_DEBUG
		/// </summary>
		public int PlanDebug { get; }

		/// <summary>
		/// Value of variable $CHK_JNT_SPD
		/// </summary>
		public bool[] ChkJntSpd { get; }

		/// <summary>
		/// Value of variable $DSP_UPD_BLK
		/// </summary>
		public byte[] DspUpdBlk { get; }

		/// <summary>
		/// Value of variable $DUMMY66
		/// </summary>
		public byte Dummy66 { get; }

		/// <summary>
		/// Value of variable $DSP_UPDATE
		/// </summary>
		public byte[] DspUpdate { get; }

		/// <summary>
		/// Value of variable $DUMMY67
		/// </summary>
		public byte Dummy67 { get; }

		/// <summary>
		/// Value of variable $SERVO_DISBL
		/// </summary>
		public bool[] ServoDisbl { get; }

		/// <summary>
		/// Value of variable $INTPLOCKHOL
		/// </summary>
		public bool Intplockhol { get; }

		/// <summary>
		/// Value of variable $QCK_STP_ENB
		/// </summary>
		public bool QckStpEnb { get; }

		/// <summary>
		/// Value of variable $OTF_SPEED
		/// </summary>
		public double OtfSpeed { get; }

		/// <summary>
		/// Value of variable $OTF_ORG_SPD
		/// </summary>
		public double OtfOrgSpd { get; }

		/// <summary>
		/// Value of variable $OTF_SPD_CHG
		/// </summary>
		public int OtfSpdChg { get; }

		/// <summary>
		/// Value of variable $OTF_SPD_UPD
		/// </summary>
		public bool OtfSpdUpd { get; }

		/// <summary>
		/// Value of variable $TSMOD_ON
		/// </summary>
		public bool TsmodOn { get; }

		/// <summary>
		/// Value of variable $UOP_IMSTP
		/// </summary>
		public bool UopImstp { get; }

		/// <summary>
		/// Value of variable $LCH_EDM_ENB
		/// </summary>
		public bool LchEdmEnb { get; }

		/// <summary>
		/// Value of variable $EACHMST_SEL
		/// </summary>
		public bool[] EachmstSel { get; }

		/// <summary>
		/// Value of variable $FJOG_ENB
		/// </summary>
		public bool FjogEnb { get; }

		/// <summary>
		/// Value of variable $SFLT_ENB
		/// </summary>
		public bool[] SfltEnb { get; }

		/// <summary>
		/// Value of variable $SFLT_VAL
		/// </summary>
		public int[] SfltVal { get; }

		/// <summary>
		/// Value of variable $SFLT_FUP
		/// </summary>
		public bool SfltFup { get; }

		/// <summary>
		/// Value of variable $RSM_ORIENT
		/// </summary>
		public int RsmOrient { get; }

		/// <summary>
		/// Value of variable $RSM_CMD_PTH
		/// </summary>
		public bool RsmCmdPth { get; }

		/// <summary>
		/// Value of variable $POS_ESTBLSH
		/// </summary>
		public bool PosEstblsh { get; }

		/// <summary>
		/// Value of variable $POS_CAN_REQ
		/// </summary>
		public bool PosCanReq { get; }

		/// <summary>
		/// Value of variable $SRVO_Q_STOP
		/// </summary>
		public byte SrvoQStop { get; }

		/// <summary>
		/// Value of variable $DUMMY68
		/// </summary>
		public byte Dummy68 { get; }

		/// <summary>
		/// Value of variable $PG_ORG_RSM
		/// </summary>
		public bool PgOrgRsm { get; }

		/// <summary>
		/// Value of variable $FLTR_FLUSH
		/// </summary>
		public byte FltrFlush { get; }

		/// <summary>
		/// Value of variable $DUMMY69
		/// </summary>
		public byte Dummy69 { get; }

		/// <summary>
		/// Value of variable $FORCEUPDATE
		/// </summary>
		public int Forceupdate { get; }

		/// <summary>
		/// Value of variable $LCKD_CALDON
		/// </summary>
		public bool LckdCaldon { get; }

		/// <summary>
		/// Value of variable $FLTR_DEBUG1
		/// </summary>
		public int FltrDebug1 { get; }

		/// <summary>
		/// Value of variable $FLTR_DEBUG2
		/// </summary>
		public int FltrDebug2 { get; }

		/// <summary>
		/// Value of variable $FLTR_DEBUG3
		/// </summary>
		public int FltrDebug3 { get; }

		/// <summary>
		/// Value of variable $FLTR_DEBUG4
		/// </summary>
		public int FltrDebug4 { get; }

		/// <summary>
		/// Value of variable $FLTR_FUNC
		/// </summary>
		public int FltrFunc { get; }

		/// <summary>
		/// Value of variable $FRCEBRKREL
		/// </summary>
		public int Frcebrkrel { get; }

		/// <summary>
		/// Value of variable $HOLD2
		/// </summary>
		public int Hold2 { get; }

		/// <summary>
		/// Value of variable $HARD_HOLD2
		/// </summary>
		public int HardHold2 { get; }

		/// <summary>
		/// Value of variable $QSTOP_ECC
		/// </summary>
		public bool QstopEcc { get; }

		/// <summary>
		/// Value of variable $MPDT_ENB
		/// </summary>
		public bool[] MpdtEnb { get; }

		/// <summary>
		/// Value of variable $MPDT_START
		/// </summary>
		public bool[] MpdtStart { get; }

		/// <summary>
		/// Value of variable $MPDT_STATUS
		/// </summary>
		public int[] MpdtStatus { get; }

		/// <summary>
		/// Value of variable $MPDT_DONE
		/// </summary>
		public bool[] MpdtDone { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
