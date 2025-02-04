//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type EFF_AXIS_T
	/// </summary>
	public class EffAxisVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NUM
		/// </summary>
		public int Num { get; }

		/// <summary>
		/// Value of variable $COEFF
		/// </summary>
		public double Coeff { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
