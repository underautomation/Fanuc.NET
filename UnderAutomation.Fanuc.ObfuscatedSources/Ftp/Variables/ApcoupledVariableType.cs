//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type APCOUPLED_T
	/// </summary>
	public class ApcoupledVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $APP_PROCES0
		/// </summary>
		public int AppProces0 { get; }

		/// <summary>
		/// Value of variable $APP_PROCES1
		/// </summary>
		public int AppProces1 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
