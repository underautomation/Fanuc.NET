//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CP_T1_GRP_T
	/// </summary>
	public class CpT1GrpVariableType : GenericVariableType, IGenericVariableType {


		public CpT1GrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $PRED_SF_ACC
		/// </summary>
		public double PredSfAcc { get; }

		/// <summary>
		/// Value of variable $PRED_SF_JRK
		/// </summary>
		public double PredSfJrk { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
