//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DRYRUN_T
	/// </summary>
	public class DryrunVariableType : GenericVariableType, IGenericVariableType {


		public DryrunVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DRYRUN_ENB
		/// </summary>
		public bool DryrunEnb { get; }

		/// <summary>
		/// Value of variable $NUM_PORT
		/// </summary>
		public int NumPort { get; }

		/// <summary>
		/// Value of variable $NUM_SUB
		/// </summary>
		public int NumSub { get; }

		/// <summary>
		/// Value of variable $STATE
		/// </summary>
		public int State { get; }

		/// <summary>
		/// Value of variable $TCOL_SYSPT
		/// </summary>
		public int TcolSyspt { get; }

		/// <summary>
		/// Value of variable $PMC_SYSPT
		/// </summary>
		public int PmcSyspt { get; }

		/// <summary>
		/// Value of variable $GRP_MASK
		/// </summary>
		public int GrpMask { get; }

		/// <summary>
		/// Value of variable $STEP_MOTION
		/// </summary>
		public int StepMotion { get; }

		/// <summary>
		/// Value of variable $LOG_INFO
		/// </summary>
		public int LogInfo { get; }

		/// <summary>
		/// Value of variable $TCOL_SAVE
		/// </summary>
		public int TcolSave { get; }

		/// <summary>
		/// Value of variable $FLTR_EMPTY
		/// </summary>
		public bool FltrEmpty { get; }

		/// <summary>
		/// Value of variable $PROD_START
		/// </summary>
		public bool ProdStart { get; }

		/// <summary>
		/// Value of variable $ESTOP_DSBL
		/// </summary>
		public bool EstopDsbl { get; }

		/// <summary>
		/// Value of variable $POW_RECOV
		/// </summary>
		public bool PowRecov { get; }

		/// <summary>
		/// Value of variable $OPR_DSBL
		/// </summary>
		public bool OprDsbl { get; }

		/// <summary>
		/// Value of variable $SAW_PROG
		/// </summary>
		public string SawProg { get; }

		/// <summary>
		/// Value of variable $INIT_PROG
		/// </summary>
		public string InitProg { get; }

		/// <summary>
		/// Value of variable $RESUME_TYPE
		/// </summary>
		public int ResumeType { get; }

		/// <summary>
		/// Value of variable $DIST_DIFF
		/// </summary>
		public double DistDiff { get; }

		/// <summary>
		/// Value of variable $ORNT_DIFF
		/// </summary>
		public double OrntDiff { get; }

		/// <summary>
		/// Value of variable $DIST_REC
		/// </summary>
		public double DistRec { get; }

		/// <summary>
		/// Value of variable $ORNT_REC
		/// </summary>
		public double OrntRec { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
