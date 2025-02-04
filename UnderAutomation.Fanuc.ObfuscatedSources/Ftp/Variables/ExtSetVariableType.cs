//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type EXT_SET_T
	/// </summary>
	public class ExtSetVariableType : GenericVariableType, IGenericVariableType {


		public ExtSetVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $DI_TYPE
		/// </summary>
		public int DiType { get; }

		/// <summary>
		/// Value of variable $DI_NUM
		/// </summary>
		public int DiNum { get; }

		/// <summary>
		/// Value of variable $DO_TYPE
		/// </summary>
		public int DoType { get; }

		/// <summary>
		/// Value of variable $DO_NUM
		/// </summary>
		public int DoNum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
