//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ABSPOS_GRP_T
	/// </summary>
	public class AbsposGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PARAM
		/// </summary>
		public double[] Param { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
