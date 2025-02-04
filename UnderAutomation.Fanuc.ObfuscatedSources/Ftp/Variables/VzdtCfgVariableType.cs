//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VZDT_CFG_T
	/// </summary>
	public class VzdtCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Value of variable $ALLOW_IMAGE
		/// </summary>
		public bool AllowImage { get; }

		/// <summary>
		/// Value of variable $PERIOD
		/// </summary>
		public short Period { get; }

		/// <summary>
		/// Value of variable $MSG_QSIZ
		/// </summary>
		public short MsgQsiz { get; }

		/// <summary>
		/// Value of variable $SIZE_LIM
		/// </summary>
		public int SizeLim { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
