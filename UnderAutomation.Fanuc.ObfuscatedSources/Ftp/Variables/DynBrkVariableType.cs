//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DYN_BRK_T
	/// </summary>
	public class DynBrkVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $DI_IDX
		/// </summary>
		public short DiIdx { get; }

		/// <summary>
		/// Value of variable $DO_IDX
		/// </summary>
		public short DoIdx { get; }

		/// <summary>
		/// Value of variable $BRK_MSK
		/// </summary>
		public short BrkMsk { get; }

		/// <summary>
		/// Value of variable $FLTR_IF
		/// </summary>
		public short FltrIf { get; }

		/// <summary>
		/// Value of variable $USE_OPDI
		/// </summary>
		public bool UseOpdi { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
