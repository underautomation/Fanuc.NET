//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TP_THR_TABLE
	/// </summary>
	public class TpThrTableVariableType : GenericVariableType, IGenericVariableType {


		public TpThrTableVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $THR_ENB
		/// </summary>
		public bool ThrEnb { get; }

		/// <summary>
		/// Value of variable $DI_NO
		/// </summary>
		public int DiNo { get; }

		/// <summary>
		/// Value of variable $DO_NO
		/// </summary>
		public int DoNo { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
