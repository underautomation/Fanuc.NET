//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ON_PATH_T
	/// </summary>
	public class OnPathVariableType : GenericVariableType, IGenericVariableType {


		public OnPathVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public bool Status { get; }

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
