//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ZMPCF_GRP_T
	/// </summary>
	public class ZmpcfGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ZMP_ENB
		/// </summary>
		public int ZmpEnb { get; }

		/// <summary>
		/// Value of variable $ZMP_DMY_LNK
		/// </summary>
		public double[] ZmpDmyLnk { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
