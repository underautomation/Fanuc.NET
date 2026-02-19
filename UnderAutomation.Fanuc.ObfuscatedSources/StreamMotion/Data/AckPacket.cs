//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Acknowledgment packet received from the robot in response to a Request packet
	/// Contains threshold data for motion limits
	/// </summary>
	public class AckPacket {

		/// <summary>
		/// Returns a string representation
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


		public AckPacket()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Packet type (always Ack=3)
		/// </summary>
		public PacketTypeFromRobot PacketType { get; }

		/// <summary>
		/// Protocol version number
		/// </summary>
		public uint VersionNumber { get; }

		/// <summary>
		/// Axis number (1-9)
		/// </summary>
		public uint AxisNumber { get; }

		/// <summary>
		/// Type of threshold data
		/// </summary>
		public ThresholdType ThresholdType { get; }

		/// <summary>
		/// Maximum Cartesian program speed of the robot (mm/s)
		/// </summary>
		public uint MaxCartesianSpeed { get; }

		/// <summary>
		/// Unknown field (reserved for future use)
		/// </summary>
		public uint Unknown0 { get; }

		/// <summary>
		/// Threshold values at various velocity percentages (no load)
		/// Index 0 = 5% of Vmax, Index 1 = 10%, ..., Index 19 = 100%
		/// </summary>
		public float[] ThresholdsNoLoad { get; }

		/// <summary>
		/// Threshold values at various velocity percentages (maximum load)
		/// Index 0 = 5% of Vmax, Index 1 = 10%, ..., Index 19 = 100%
		/// </summary>
		public float[] ThresholdsMaxLoad { get; }
	}
}
