//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CLMLIO_T
	/// </summary>
	public class ClmlioVariableType : GenericVariableType, IGenericVariableType {


		public ClmlioVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TYPE
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Value of variable $INDEX
		/// </summary>
		public int Index { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
