//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DRYRUN_PORT_
	/// </summary>
	public class DryrunPortVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TYPE
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Value of variable $FST_IDX
		/// </summary>
		public int FstIdx { get; }

		/// <summary>
		/// Value of variable $LST_IDX
		/// </summary>
		public int LstIdx { get; }

		/// <summary>
		/// Value of variable $STATIC_PORT
		/// </summary>
		public bool StaticPort { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
