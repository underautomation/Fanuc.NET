//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $PULCO_IDATA
	/// </summary>
	public class PulcoIdataVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ADDRESS
		/// </summary>
		public int Address { get; }

		/// <summary>
		/// Value of variable $DATA
		/// </summary>
		public int[] Data { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
