//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type UI_MENHIS_T
	/// </summary>
	public class UiMenhisVariableType : GenericVariableType, IGenericVariableType {


		public UiMenhisVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $HIST_HEAD
		/// </summary>
		public short HistHead { get; }

		/// <summary>
		/// Value of variable $HIST_ENTRY
		/// </summary>
		public string[] HistEntry { get; }

		/// <summary>
		/// Value of variable $DUMMY2
		/// </summary>
		public byte Dummy2 { get; }

		/// <summary>
		/// Value of variable $DUMMY3
		/// </summary>
		public byte Dummy3 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
