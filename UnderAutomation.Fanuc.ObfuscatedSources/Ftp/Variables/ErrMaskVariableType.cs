//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ERR_MASK_T
	/// </summary>
	public class ErrMaskVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SSC_MASK1
		/// </summary>
		public int SscMask1 { get; }

		/// <summary>
		/// Value of variable $SSC_MASK2
		/// </summary>
		public int SscMask2 { get; }

		/// <summary>
		/// Value of variable $SSC_MASK3
		/// </summary>
		public int SscMask3 { get; }

		/// <summary>
		/// Value of variable $SSC_MASK4
		/// </summary>
		public int SscMask4 { get; }

		/// <summary>
		/// Value of variable $SEV_MASK
		/// </summary>
		public int SevMask { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
