//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type KARELMON_T
	/// </summary>
	public class KarelmonVariableType : GenericVariableType, IGenericVariableType {


		public KarelmonVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $XREF_ONCE
		/// </summary>
		public bool XrefOnce { get; }

		/// <summary>
		/// Value of variable $WATCH_VAR
		/// </summary>
		public bool WatchVar { get; }

		/// <summary>
		/// Value of variable $PROG_NAME
		/// </summary>
		public string ProgName { get; }

		/// <summary>
		/// Value of variable $FIELD_NAME
		/// </summary>
		public string FieldName { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
