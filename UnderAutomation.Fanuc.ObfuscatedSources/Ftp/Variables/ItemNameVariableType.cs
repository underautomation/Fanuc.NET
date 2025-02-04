//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ITEM_NAME_T
	/// </summary>
	public class ItemNameVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ITEM_NAME
		/// </summary>
		public string ItemName { get; }

		/// <summary>
		/// Value of variable $ON_LABEL
		/// </summary>
		public string OnLabel { get; }

		/// <summary>
		/// Value of variable $OFF_LABEL
		/// </summary>
		public string OffLabel { get; }

		/// <summary>
		/// Value of variable $UNIT
		/// </summary>
		public string Unit { get; }

		/// <summary>
		/// Value of variable $ITEM_ENTITY
		/// </summary>
		public int ItemEntity { get; }

		/// <summary>
		/// Value of variable $ITEM_TYPE
		/// </summary>
		public int ItemType { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
