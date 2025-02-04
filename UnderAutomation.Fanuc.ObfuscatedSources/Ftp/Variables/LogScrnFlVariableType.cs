//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type LOG_SCRN_FL_
	/// </summary>
	public class LogScrnFlVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $SP_ID
		/// </summary>
		public int SpId { get; }

		/// <summary>
		/// Value of variable $SCRN_ID
		/// </summary>
		public int ScrnId { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
