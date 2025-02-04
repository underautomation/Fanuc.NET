//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VARS_CONFIG_
	/// </summary>
	public class VarsConfigVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SHADOWRECS
		/// </summary>
		public int Shadowrecs { get; }

		/// <summary>
		/// Value of variable $SHAD_UNSCAN
		/// </summary>
		public int ShadUnscan { get; }

		/// <summary>
		/// Value of variable $SHADOWTIME
		/// </summary>
		public int Shadowtime { get; }

		/// <summary>
		/// Value of variable $SHADDGDET
		/// </summary>
		public int Shaddgdet { get; }

		/// <summary>
		/// Value of variable $LEGACY
		/// </summary>
		public bool Legacy { get; }

		/// <summary>
		/// Value of variable $DBGLVL
		/// </summary>
		public int Dbglvl { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
