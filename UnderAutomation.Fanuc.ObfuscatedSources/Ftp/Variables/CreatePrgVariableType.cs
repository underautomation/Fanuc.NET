//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $CREATE_PRG
	/// </summary>
	public class CreatePrgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $AXIS_FLAG
		/// </summary>
		public bool[] AxisFlag { get; }

		/// <summary>
		/// Value of variable $NUM_AXS_REP
		/// </summary>
		public int NumAxsRep { get; }

		/// <summary>
		/// Value of variable $SWING_ANG
		/// </summary>
		public double[] SwingAng { get; }

		/// <summary>
		/// Value of variable $NUM_MS_POSE
		/// </summary>
		public int NumMsPose { get; }

		/// <summary>
		/// Value of variable $BASE_POSE
		/// </summary>
		public double[] BasePose { get; }

		/// <summary>
		/// Value of variable $EVALUE_IDX
		/// </summary>
		public double[] EvalueIdx { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
