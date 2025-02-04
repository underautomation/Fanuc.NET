//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCSS_LS_T
	/// </summary>
	public class DcssLsVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $STOOUT_IDX
		/// </summary>
		public int StooutIdx { get; }

		/// <summary>
		/// Value of variable $STOFB_IDX
		/// </summary>
		public int StofbIdx { get; }

		/// <summary>
		/// Value of variable $STOFB_CH
		/// </summary>
		public int StofbCh { get; }

		/// <summary>
		/// Value of variable $FENCE_TYPE
		/// </summary>
		public int FenceType { get; }

		/// <summary>
		/// Value of variable $FENCE_IDX
		/// </summary>
		public int FenceIdx { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
