//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MSK_CE_GRP_T
	/// </summary>
	public class MskCeGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $T1_USERCART
		/// </summary>
		public double T1Usercart { get; }

		/// <summary>
		/// Value of variable $T1_USERJNT
		/// </summary>
		public double[] T1Userjnt { get; }

		/// <summary>
		/// Value of variable $T1_CARTVEL
		/// </summary>
		public double T1Cartvel { get; }

		/// <summary>
		/// Value of variable $T1_JNTVEL
		/// </summary>
		public double[] T1Jntvel { get; }

		/// <summary>
		/// Value of variable $T1_WARNING
		/// </summary>
		public bool T1Warning { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
