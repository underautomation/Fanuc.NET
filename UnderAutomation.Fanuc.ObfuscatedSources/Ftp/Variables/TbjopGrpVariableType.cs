//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBJOP_GRP_T
	/// </summary>
	public class TbjopGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $F2MGN
		/// </summary>
		public double F2mgn { get; }

		/// <summary>
		/// Value of variable $MINF2
		/// </summary>
		public double Minf2 { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public int CompSw { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
