//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MISC_SCD_T
	/// </summary>
	public class MiscScdVariableType : GenericVariableType, IGenericVariableType {


		public MiscScdVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DSTB_MAX_A
		/// </summary>
		public double[] DstbMaxA { get; }

		/// <summary>
		/// Value of variable $DSTB_MIN_A
		/// </summary>
		public double[] DstbMinA { get; }

		/// <summary>
		/// Value of variable $DSTB_MAXENB
		/// </summary>
		public bool[] DstbMaxenb { get; }

		/// <summary>
		/// Value of variable $DSTB_MINENB
		/// </summary>
		public bool[] DstbMinenb { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
