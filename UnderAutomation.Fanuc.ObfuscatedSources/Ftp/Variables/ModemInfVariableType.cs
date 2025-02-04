//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MODEM_INF_T
	/// </summary>
	public class ModemInfVariableType : GenericVariableType, IGenericVariableType {


		public ModemInfVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MDM_INIT
		/// </summary>
		public string MdmInit { get; }

		/// <summary>
		/// Value of variable $MDM_INIT1
		/// </summary>
		public string MdmInit1 { get; }

		/// <summary>
		/// Value of variable $MDM_RESET
		/// </summary>
		public string MdmReset { get; }

		/// <summary>
		/// Value of variable $MDM_HANGUP
		/// </summary>
		public string MdmHangup { get; }

		/// <summary>
		/// Value of variable $MDM_DIAL
		/// </summary>
		public string MdmDial { get; }

		/// <summary>
		/// Value of variable $MDM_ANSWER
		/// </summary>
		public string MdmAnswer { get; }

		/// <summary>
		/// Value of variable $MDM_STATUS
		/// </summary>
		public string MdmStatus { get; }

		/// <summary>
		/// Value of variable $MDM_IDENT
		/// </summary>
		public string MdmIdent { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
