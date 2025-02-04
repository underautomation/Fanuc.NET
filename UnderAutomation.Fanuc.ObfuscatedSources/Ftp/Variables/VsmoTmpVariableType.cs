//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VSMO_TMP_T
	/// </summary>
	public class VsmoTmpVariableType : GenericVariableType, IGenericVariableType {


		public VsmoTmpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $SNAP_STAT
		/// </summary>
		public int SnapStat { get; }

		/// <summary>
		/// Value of variable $SNAP_TIME_H
		/// </summary>
		public int SnapTimeH { get; }

		/// <summary>
		/// Value of variable $SNAP_TIME_L
		/// </summary>
		public int SnapTimeL { get; }

		/// <summary>
		/// Value of variable $PRV1_TIME_H
		/// </summary>
		public int Prv1TimeH { get; }

		/// <summary>
		/// Value of variable $PRV1_TIME_L
		/// </summary>
		public int Prv1TimeL { get; }

		/// <summary>
		/// Value of variable $PRV2_TIME_H
		/// </summary>
		public int Prv2TimeH { get; }

		/// <summary>
		/// Value of variable $PRV2_TIME_L
		/// </summary>
		public int Prv2TimeL { get; }

		/// <summary>
		/// Value of variable $PRV1_PLS
		/// </summary>
		public VsmoPlsVariableType[] Prv1Pls { get; }

		/// <summary>
		/// Value of variable $PRV2_PLS
		/// </summary>
		public VsmoPlsVariableType[] Prv2Pls { get; }

		/// <summary>
		/// Value of variable $ROBOT_GROUP
		/// </summary>
		public int RobotGroup { get; }

		/// <summary>
		/// Value of variable $SNAP_PLS
		/// </summary>
		public VsmoPlsVariableType SnapPls { get; }

		/// <summary>
		/// Value of variable $PRV_SNP_PLS
		/// </summary>
		public VsmoPlsVariableType PrvSnpPls { get; }

		/// <summary>
		/// Value of variable $PST_SNP_PLS
		/// </summary>
		public VsmoPlsVariableType PstSnpPls { get; }

		/// <summary>
		/// Value of variable $DIFF_TIME
		/// </summary>
		public double DiffTime { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
