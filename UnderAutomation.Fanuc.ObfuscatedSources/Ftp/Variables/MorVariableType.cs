//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MOR_T
	/// </summary>
	public class MorVariableType : GenericVariableType, IGenericVariableType {


		public MorVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $BRK_STATUS
		/// </summary>
		public int BrkStatus { get; }

		/// <summary>
		/// Value of variable $PG_MCTL
		/// </summary>
		public short PgMctl { get; }

		/// <summary>
		/// Value of variable $SMH_DONE
		/// </summary>
		public bool SmhDone { get; }

		/// <summary>
		/// Value of variable $REG_DIS_AMP
		/// </summary>
		public double[] RegDisAmp { get; }

		/// <summary>
		/// Value of variable $SAFETY_STAT
		/// </summary>
		public int SafetyStat { get; }

		/// <summary>
		/// Value of variable $CLASS1_STOP
		/// </summary>
		public int Class1Stop { get; }

		/// <summary>
		/// Value of variable $T1_SPD_OVRD
		/// </summary>
		public int T1SpdOvrd { get; }

		/// <summary>
		/// Value of variable $AMP_ID
		/// </summary>
		public AmpIdVariableType[] AmpId { get; }

		/// <summary>
		/// Value of variable $TRANS_CUR
		/// </summary>
		public double[] TransCur { get; }

		/// <summary>
		/// Value of variable $TRANS_ITP
		/// </summary>
		public double[] TransItp { get; }

		/// <summary>
		/// Value of variable $CBLCUR_CUR
		/// </summary>
		public double[] CblcurCur { get; }

		/// <summary>
		/// Value of variable $CBLCUR_ITP
		/// </summary>
		public double[] CblcurItp { get; }

		/// <summary>
		/// Value of variable $CBLCUR_THM
		/// </summary>
		public double[] CblcurThm { get; }

		/// <summary>
		/// Value of variable $AMP_SVM
		/// </summary>
		public string[] AmpSvm { get; }

		/// <summary>
		/// Value of variable $AMP_SVMSRL
		/// </summary>
		public string[] AmpSvmsrl { get; }

		/// <summary>
		/// Value of variable $AMP_PSM
		/// </summary>
		public string[] AmpPsm { get; }

		/// <summary>
		/// Value of variable $AMP_PSMSRL
		/// </summary>
		public string[] AmpPsmsrl { get; }

		/// <summary>
		/// Value of variable $AMP_MAXCUR
		/// </summary>
		public string[] AmpMaxcur { get; }

		/// <summary>
		/// Value of variable $AMP_SERIES
		/// </summary>
		public string[] AmpSeries { get; }

		/// <summary>
		/// Value of variable $AMP_SVMVER
		/// </summary>
		public string[] AmpSvmver { get; }

		/// <summary>
		/// Value of variable $AMP_PSMVER
		/// </summary>
		public string[] AmpPsmver { get; }

		/// <summary>
		/// Value of variable $FLTR_OVRN
		/// </summary>
		public FltrOvrnVariableType FltrOvrn { get; }

		/// <summary>
		/// Value of variable $FAN_ROTNUM
		/// </summary>
		public int[] FanRotnum { get; }

		/// <summary>
		/// Value of variable $DSPCODE_ID
		/// </summary>
		public short[] DspcodeId { get; }

		/// <summary>
		/// Value of variable $DSPCODE_VER
		/// </summary>
		public string[] DspcodeVer { get; }

		/// <summary>
		/// Value of variable $CMND_EXIST
		/// </summary>
		public int CmndExist { get; }

		/// <summary>
		/// Value of variable $SPC_CSTP_SW
		/// </summary>
		public int SpcCstpSw { get; }

		/// <summary>
		/// Value of variable $END_MOTION
		/// </summary>
		public bool EndMotion { get; }

		/// <summary>
		/// Value of variable $OVERRIDE
		/// </summary>
		public int Override { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
