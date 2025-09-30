//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Identifies the top-level message kind sent to the controller.
	/// Must be the first key according to the RMI protocol.
	/// </summary>
	public enum RmiMessageKind {

		/// <summary>
		/// Communication packet (FRC_Connect / FRC_Disconnect).
		/// </summary>
		Communication = 0,

		/// <summary>
		/// Administrative command (e.g., FRC_Initialize, FRC_Reset).
		/// </summary>
		Command = 1,

		/// <summary>
		/// Instruction that appends a new TP line to the RMI_MOVE program.
		/// </summary>
		Instruction = 2,
	}
}
