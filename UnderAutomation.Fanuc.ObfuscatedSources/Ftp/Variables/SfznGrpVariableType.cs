//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SFZN_GRP_T
	/// </summary>
	public class SfznGrpVariableType : GenericVariableType, IGenericVariableType {


		public SfznGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MIN_OVRD
		/// </summary>
		public double MinOvrd { get; }

		/// <summary>
		/// Value of variable $INT_ANG
		/// </summary>
		public double IntAng { get; }

		/// <summary>
		/// Value of variable $MIN_ANG
		/// </summary>
		public double MinAng { get; }

		/// <summary>
		/// Value of variable $FACE_SPD
		/// </summary>
		public double FaceSpd { get; }

		/// <summary>
		/// Value of variable $SAFE_SPD
		/// </summary>
		public double SafeSpd { get; }

		/// <summary>
		/// Value of variable $MIXED_SPD
		/// </summary>
		public double MixedSpd { get; }

		/// <summary>
		/// Value of variable $MIXED_ANG
		/// </summary>
		public double MixedAng { get; }

		/// <summary>
		/// Value of variable $MIN_DIST
		/// </summary>
		public double MinDist { get; }

		/// <summary>
		/// Value of variable $ROB_NAME
		/// </summary>
		public string RobName { get; }

		/// <summary>
		/// Value of variable $NEED_APP
		/// </summary>
		public int NeedApp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
