//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $MOUSE
	/// </summary>
	public class MouseVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ACTION
		/// </summary>
		public short Action { get; }

		/// <summary>
		/// Value of variable $BUTTON
		/// </summary>
		public short Button { get; }

		/// <summary>
		/// Value of variable $ROW
		/// </summary>
		public short Row { get; }

		/// <summary>
		/// Value of variable $COLUMN
		/// </summary>
		public short Column { get; }

		/// <summary>
		/// Value of variable $TIME
		/// </summary>
		public int Time { get; }

		/// <summary>
		/// Value of variable $RESERVED
		/// </summary>
		public int Reserved { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
