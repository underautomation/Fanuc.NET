//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VRTD_FILT_T
	/// </summary>
	public class VrtdFiltVariableType : GenericVariableType, IGenericVariableType {


		public VrtdFiltVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Value of variable $MODE
		/// </summary>
		public byte Mode { get; }

		/// <summary>
		/// Value of variable $DUMMY4
		/// </summary>
		public byte Dummy4 { get; }

		/// <summary>
		/// Value of variable $TOOL_TYPE
		/// </summary>
		public short ToolType { get; }

		/// <summary>
		/// Value of variable $WORDS
		/// </summary>
		public string Words { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
