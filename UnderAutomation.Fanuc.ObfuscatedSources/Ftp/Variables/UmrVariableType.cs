//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UMR_T
	/// </summary>
	public class UmrVariableType : GenericVariableType, IGenericVariableType {


		public UmrVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $GUPR_P
		/// </summary>
		public int GuprP { get; }

		/// <summary>
		/// Value of variable $GMRR_P
		/// </summary>
		public int GmrrP { get; }

		/// <summary>
		/// Value of variable $GUJR_P
		/// </summary>
		public int GujrP { get; }

		/// <summary>
		/// Value of variable $GMRR2_P
		/// </summary>
		public int Gmrr2P { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
