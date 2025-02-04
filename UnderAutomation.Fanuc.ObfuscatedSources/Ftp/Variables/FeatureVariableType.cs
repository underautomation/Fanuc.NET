//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FEATURE_T
	/// </summary>
	public class FeatureVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NAM
		/// </summary>
		public string[] Nam { get; }

		/// <summary>
		/// Value of variable $MOD
		/// </summary>
		public string[] Mod { get; }

		/// <summary>
		/// Value of variable $VER
		/// </summary>
		public string[] Ver { get; }

		/// <summary>
		/// Value of variable $MEC
		/// </summary>
		public string[] Mec { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
