//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UNDO_CFG_T
	/// </summary>
	public class UndoCfgVariableType : GenericVariableType, IGenericVariableType {


		public UndoCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $UNDO_ENB
		/// </summary>
		public bool UndoEnb { get; }

		/// <summary>
		/// Value of variable $WARN_ENB
		/// </summary>
		public bool WarnEnb { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
