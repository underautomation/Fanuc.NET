//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Stream Motion packet types for PC to Robot communication
	/// </summary>
	public enum PacketTypeToRobot : uint {

		/// <summary>
		/// Start streaming motion
		/// </summary>
		Start = 0,

		/// <summary>
		/// Motion command packet
		/// </summary>
		Command = 1,

		/// <summary>
		/// Stop streaming motion
		/// </summary>
		Stop = 2,

		/// <summary>
		/// Request threshold information
		/// </summary>
		Request = 3,
	}
}
