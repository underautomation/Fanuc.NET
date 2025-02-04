//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type COCFG_T
	/// </summary>
	public class CocfgVariableType : GenericVariableType, IGenericVariableType {


		public CocfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $GROUP_MASK
		/// </summary>
		public int GroupMask { get; }

		/// <summary>
		/// Value of variable $MB_CONFLICT
		/// </summary>
		public int MbConflict { get; }

		/// <summary>
		/// Value of variable $MB_REQUIRED
		/// </summary>
		public int MbRequired { get; }

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
