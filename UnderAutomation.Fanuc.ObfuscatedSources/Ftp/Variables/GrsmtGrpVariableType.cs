//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type GRSMT_GRP_T
	/// </summary>
	public class GrsmtGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $GRV_SW
		/// </summary>
		public int GrvSw { get; }

		/// <summary>
		/// Value of variable $GRV_PARAM
		/// </summary>
		public double GrvParam { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
