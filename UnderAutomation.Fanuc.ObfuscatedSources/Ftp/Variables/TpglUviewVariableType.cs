//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TPGL_UVIEW_T
	/// </summary>
	public class TpglUviewVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $GIF
		/// </summary>
		public string Gif { get; }

		/// <summary>
		/// Value of variable $VIEW
		/// </summary>
		public ViewVariableType View { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
