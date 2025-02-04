//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TPVWVAR_T
	/// </summary>
	public class TpvwvarVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TPVIEW_ENB
		/// </summary>
		public bool TpviewEnb { get; }

		/// <summary>
		/// Value of variable $PREV_RTN
		/// </summary>
		public bool PrevRtn { get; }

		/// <summary>
		/// Value of variable $EDIT_RTN
		/// </summary>
		public bool EditRtn { get; }

		/// <summary>
		/// Value of variable $VSHWRK
		/// </summary>
		public short Vshwrk { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public short Debug { get; }

		/// <summary>
		/// Value of variable $DISPLAY
		/// </summary>
		public int Display { get; }

		/// <summary>
		/// Value of variable $INDENT1
		/// </summary>
		public short Indent1 { get; }

		/// <summary>
		/// Value of variable $INDENT2
		/// </summary>
		public short Indent2 { get; }

		/// <summary>
		/// Value of variable $HEAD1
		/// </summary>
		public string Head1 { get; }

		/// <summary>
		/// Value of variable $HEAD2
		/// </summary>
		public string Head2 { get; }

		/// <summary>
		/// Value of variable $EDIT_KEY
		/// </summary>
		public short EditKey { get; }

		/// <summary>
		/// Value of variable $TCPSPD_KEY
		/// </summary>
		public short TcpspdKey { get; }

		/// <summary>
		/// Value of variable $JMPCALL_ENB
		/// </summary>
		public bool JmpcallEnb { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
