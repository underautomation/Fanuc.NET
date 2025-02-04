//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type POINFO_T
	/// </summary>
	public class PoinfoVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CUR_INDEX
		/// </summary>
		public int CurIndex { get; }

		/// <summary>
		/// Value of variable $INFO
		/// </summary>
		public short[] Info { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
