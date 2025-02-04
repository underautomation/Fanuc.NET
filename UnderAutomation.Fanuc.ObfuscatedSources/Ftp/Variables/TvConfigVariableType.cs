//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TV_CONFIG_T
	/// </summary>
	public class TvConfigVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $DBGLVL
		/// </summary>
		public int Dbglvl { get; }

		/// <summary>
		/// Value of variable $DATATYPE
		/// </summary>
		public short[] Datatype { get; }

		/// <summary>
		/// Value of variable $TEMPINT
		/// </summary>
		public int[] Tempint { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
