//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $RESUME_OFST
	/// </summary>
	public class ResumeOfstVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $RO_ENABLE
		/// </summary>
		public bool RoEnable { get; }

		/// <summary>
		/// Value of variable $RO_MAX_ITP
		/// </summary>
		public int RoMaxItp { get; }

		/// <summary>
		/// Value of variable $RO_NOM_DIST
		/// </summary>
		public double RoNomDist { get; }

		/// <summary>
		/// Value of variable $RO_NOM_SPD
		/// </summary>
		public double RoNomSpd { get; }

		/// <summary>
		/// Value of variable $RO_MODE_SW
		/// </summary>
		public int RoModeSw { get; }

		/// <summary>
		/// Value of variable $RO_TUNE_PAM
		/// </summary>
		public double RoTunePam { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
