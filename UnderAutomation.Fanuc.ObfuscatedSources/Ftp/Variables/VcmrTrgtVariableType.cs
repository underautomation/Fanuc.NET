//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VCMR_TRGT_T
	/// </summary>
	public class VcmrTrgtVariableType : GenericVariableType, IGenericVariableType {


		public VcmrTrgtVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TARGET_PNT
		/// </summary>
		public double[] TargetPnt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
