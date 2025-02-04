//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCSS_CNSTCY_
	/// </summary>
	public class DcssCnstcyVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SIG1_TYPE
		/// </summary>
		public int Sig1Type { get; }

		/// <summary>
		/// Value of variable $SIG1_IDX
		/// </summary>
		public int Sig1Idx { get; }

		/// <summary>
		/// Value of variable $SIG2_TYPE
		/// </summary>
		public int Sig2Type { get; }

		/// <summary>
		/// Value of variable $SIG2_IDX
		/// </summary>
		public int Sig2Idx { get; }

		/// <summary>
		/// Value of variable $NOT_OPE
		/// </summary>
		public int NotOpe { get; }

		/// <summary>
		/// Value of variable $TIME
		/// </summary>
		public int Time { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
