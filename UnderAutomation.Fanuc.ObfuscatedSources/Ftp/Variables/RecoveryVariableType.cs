//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $RECOVERY
	/// </summary>
	public class RecoveryVariableType : GenericVariableType, IGenericVariableType {


		public RecoveryVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ORG_MST_CT
		/// </summary>
		public int[] OrgMstCt { get; }

		/// <summary>
		/// Value of variable $ORG_UFRAME
		/// </summary>
		public double[] OrgUframe { get; }

		/// <summary>
		/// Value of variable $ORG_REF_POS
		/// </summary>
		public double[] OrgRefPos { get; }

		/// <summary>
		/// Value of variable $ORG_REF_CT
		/// </summary>
		public int[] OrgRefCt { get; }

		/// <summary>
		/// Value of variable $RCV_ANG_PAM
		/// </summary>
		public double[] RcvAngPam { get; }

		/// <summary>
		/// Value of variable $NEW_MST_CT
		/// </summary>
		public int[] NewMstCt { get; }

		/// <summary>
		/// Value of variable $NEW_UFRAME
		/// </summary>
		public double[] NewUframe { get; }

		/// <summary>
		/// Value of variable $NEW_REF_POS
		/// </summary>
		public double[] NewRefPos { get; }

		/// <summary>
		/// Value of variable $NEW_REF_CT
		/// </summary>
		public int[] NewRefCt { get; }

		/// <summary>
		/// Value of variable $EVALUE_IDX
		/// </summary>
		public double EvalueIdx { get; }

		/// <summary>
		/// Value of variable $MAX_RC_ERR
		/// </summary>
		public double MaxRcErr { get; }

		/// <summary>
		/// Value of variable $MEAN_RC_ERR
		/// </summary>
		public double MeanRcErr { get; }

		/// <summary>
		/// Value of variable $WORST_POSE
		/// </summary>
		public int WorstPose { get; }

		/// <summary>
		/// Value of variable $MASTER_TIME
		/// </summary>
		public int MasterTime { get; }

		/// <summary>
		/// Value of variable $DEBUG_MODE
		/// </summary>
		public int DebugMode { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
