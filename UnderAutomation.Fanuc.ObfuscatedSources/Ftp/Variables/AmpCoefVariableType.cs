//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AMP_COEF_T
	/// </summary>
	public class AmpCoefVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $COEF_A
		/// </summary>
		public double[] CoefA { get; }

		/// <summary>
		/// Value of variable $COEF_C
		/// </summary>
		public double CoefC { get; }

		/// <summary>
		/// Value of variable $MASK
		/// </summary>
		public int Mask { get; }

		/// <summary>
		/// Value of variable $DUAL_MASK
		/// </summary>
		public int DualMask { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
