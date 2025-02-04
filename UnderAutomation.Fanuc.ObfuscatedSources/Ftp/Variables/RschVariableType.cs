//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type RSCH_T
	/// </summary>
	public class RschVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $OLD_SPEC_SW
		/// </summary>
		public bool OldSpecSw { get; }

		/// <summary>
		/// Value of variable $FREEFROMSIZ
		/// </summary>
		public int Freefromsiz { get; }

		/// <summary>
		/// Value of variable $TARGET_DIR
		/// </summary>
		public string TargetDir { get; }

		/// <summary>
		/// Value of variable $UPDT_MAP
		/// </summary>
		public int UpdtMap { get; }

		/// <summary>
		/// Value of variable $REPTSK_ENB
		/// </summary>
		public bool ReptskEnb { get; }

		/// <summary>
		/// Value of variable $EXP_ENB
		/// </summary>
		public bool ExpEnb { get; }

		/// <summary>
		/// Value of variable $EXP_DIR
		/// </summary>
		public string ExpDir { get; }

		/// <summary>
		/// Value of variable $DEFAULT_DEV
		/// </summary>
		public bool DefaultDev { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
