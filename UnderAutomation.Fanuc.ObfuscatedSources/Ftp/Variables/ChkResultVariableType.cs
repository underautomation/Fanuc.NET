//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $CHK_RESULT
	/// </summary>
	public class ChkResultVariableType : GenericVariableType, IGenericVariableType {


		public ChkResultVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $EVALUE_IDX
		/// </summary>
		public double EvalueIdx { get; }

		/// <summary>
		/// Value of variable $MAX_MS_ERR
		/// </summary>
		public double MaxMsErr { get; }

		/// <summary>
		/// Value of variable $MEAN_MS_ERR
		/// </summary>
		public double MeanMsErr { get; }

		/// <summary>
		/// Value of variable $WORST_POSE
		/// </summary>
		public int WorstPose { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
