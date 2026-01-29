//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Stream Motion packet types for Robot to PC communication
	/// </summary>
	public enum PacketTypeFromRobot : uint {

		/// <summary>
		/// Robot state/status packet
		/// </summary>
		State = 0,

		/// <summary>
		/// Acknowledgment packet (response to Request)
		/// </summary>
		Ack = 3,
	}
}
