//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SMTP_CTRL_T
	/// </summary>
	public class SmtpCtrlVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $SERVER
		/// </summary>
		public string Server { get; }

		/// <summary>
		/// Value of variable $PORT
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Value of variable $TIMEOUT
		/// </summary>
		public int Timeout { get; }

		/// <summary>
		/// Value of variable $CC_ADDR
		/// </summary>
		public string CcAddr { get; }

		/// <summary>
		/// Value of variable $FROM_ADDR
		/// </summary>
		public string FromAddr { get; }

		/// <summary>
		/// Value of variable $RT_ADDR
		/// </summary>
		public string RtAddr { get; }

		/// <summary>
		/// Value of variable $POST_DLVR
		/// </summary>
		public bool PostDlvr { get; }

		/// <summary>
		/// Value of variable $SPARE
		/// </summary>
		public int Spare { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
