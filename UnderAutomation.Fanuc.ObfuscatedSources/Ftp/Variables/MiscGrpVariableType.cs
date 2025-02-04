//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MISC_GRP_T
	/// </summary>
	public class MiscGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $HPD_TRQ
		/// </summary>
		public double[] HpdTrq { get; }

		/// <summary>
		/// Value of variable $DSTB_MAX
		/// </summary>
		public short[] DstbMax { get; }

		/// <summary>
		/// Value of variable $DSTB_MIN
		/// </summary>
		public short[] DstbMin { get; }

		/// <summary>
		/// Value of variable $DSTB_MAXENB
		/// </summary>
		public bool[] DstbMaxenb { get; }

		/// <summary>
		/// Value of variable $DSTB_MINENB
		/// </summary>
		public bool[] DstbMinenb { get; }

		/// <summary>
		/// Value of variable $DSTB_EXCESS
		/// </summary>
		public bool DstbExcess { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
