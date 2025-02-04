//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FSSB_CFG_T
	/// </summary>
	public class FssbCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $FSSB_LINE
		/// </summary>
		public int[] FssbLine { get; }

		/// <summary>
		/// Value of variable $EX_FSSBLINE
		/// </summary>
		public int[] ExFssbline { get; }

		/// <summary>
		/// Value of variable $FSSB1_AXES
		/// </summary>
		public int Fssb1Axes { get; }

		/// <summary>
		/// Value of variable $FSSB3_AXES
		/// </summary>
		public int Fssb3Axes { get; }

		/// <summary>
		/// Value of variable $FSSB5_AXES
		/// </summary>
		public int Fssb5Axes { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
