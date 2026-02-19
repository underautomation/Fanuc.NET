//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Robot status from state packet
	/// </summary>
	public class RobotStatus {

		/// <summary>
		/// Returns a string representation of the status
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RobotStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Raw status byte
		/// </summary>
		public byte RawValue { get; }

		/// <summary>
		/// Status flags
		/// </summary>
		public RobotStatusFlags Flags { get; }

		/// <summary>
		/// Robot is ready to receive command packets
		/// </summary>
		public bool ReadyForCommands { get; }

		/// <summary>
		/// Robot has received at least one command packet
		/// </summary>
		public bool CommandReceived { get; }

		/// <summary>
		/// System ready (SYSRDY)
		/// </summary>
		public bool SystemReady { get; }

		/// <summary>
		/// Robot is in motion
		/// </summary>
		public bool InMotion { get; }
	}
}
