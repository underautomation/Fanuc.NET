//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ALMDG_T
	/// </summary>
	public class AlmdgVariableType : GenericVariableType, IGenericVariableType {


		public AlmdgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DEBUG1
		/// </summary>
		public int Debug1 { get; }

		/// <summary>
		/// Value of variable $DEBUG2
		/// </summary>
		public int Debug2 { get; }

		/// <summary>
		/// Value of variable $DEBUG3
		/// </summary>
		public int Debug3 { get; }

		/// <summary>
		/// Value of variable $CONT_TYPE
		/// </summary>
		public int ContType { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
