//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Robot status flags from state packet
	/// </summary>
	[Flags]
public enum RobotStatusFlags : byte {

		/// <summary>
		/// No flags set
		/// </summary>
		None = 0,

		/// <summary>
		/// Robot is ready to receive command packets
		/// </summary>
		ReadyForCommands = 1,

		/// <summary>
		/// Robot has received at least one command packet
		/// </summary>
		CommandReceived = 2,

		/// <summary>
		/// System ready (SYSRDY)
		/// </summary>
		SystemReady = 4,

		/// <summary>
		/// Robot is in motion
		/// </summary>
		InMotion = 8,
	}
}
