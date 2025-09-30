//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// RMI communication verbs.
	/// </summary>
	public enum CommunicationVerb {

		/// <summary>
		/// Request permission and the working data port from the controller.
		/// </summary>
		FRC_Connect = 0,

		/// <summary>
		/// Gracefully end an RMI session on the working data port.
		/// </summary>
		FRC_Disconnect = 1,

		/// <summary>
		/// Sent by controller on idle timeout to close the session.
		/// </summary>
		FRC_Terminate = 2,

		/// <summary>
		/// Sent by controller when a system fault pauses TP program.
		/// </summary>
		FRC_SystemFault = 3,
	}
}
