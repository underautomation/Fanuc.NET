//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $CURRENT_POS
	/// </summary>
	public class CurrentPosVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $POSXF
		/// </summary>
		public CartesianPositionVariable Posxf { get; }

		/// <summary>
		/// Value of variable $EXT1
		/// </summary>
		public double Ext1 { get; }

		/// <summary>
		/// Value of variable $EXT2
		/// </summary>
		public double Ext2 { get; }

		/// <summary>
		/// Value of variable $EXT3
		/// </summary>
		public double Ext3 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
