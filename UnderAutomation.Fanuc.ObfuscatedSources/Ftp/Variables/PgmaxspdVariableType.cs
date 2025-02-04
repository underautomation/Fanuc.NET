//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PGMAXSPD_T
	/// </summary>
	public class PgmaxspdVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CART_SPEED
		/// </summary>
		public double CartSpeed { get; }

		/// <summary>
		/// Value of variable $JNT_SPEED
		/// </summary>
		public double[] JntSpeed { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
