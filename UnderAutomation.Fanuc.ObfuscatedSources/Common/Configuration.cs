//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Fanuc arm configuration
	/// </summary>
	public class Configuration {

		/// <summary>
		/// Wrist configuration
		/// </summary>
		public WristFlip WristFlip { get; set; }

		/// <summary>
		/// Arm up/down configuration
		/// </summary>
		public ArmUpDown ArmUpDown { get; set; }

		/// <summary>
		/// Arm left/right configuration
		/// </summary>
		public ArmLeftRight ArmLeftRight { get; set; }

		/// <summary>
		/// Arm back/front configuration
		/// </summary>
		public ArmFrontBack ArmFrontBack { get; set; }

		/// <summary>
		/// Turn number of axis 1 (1:180° to 539°, 0:-179° to 179°, -1:-539° to 180°)
		/// </summary>
		public int TurnAxis1 { get; set; }

		/// <summary>
		/// Turn number of axis 2 (1:180° to 539°, 0:-179° to 179°, -1:-539° to 180°)
		/// </summary>
		public int TurnAxis2 { get; set; }

		/// <summary>
		/// Turn number of axis 3 (1:180° to 539°, 0:-179° to 179°, -1:-539° to 180°)
		/// </summary>
		public int TurnAxis3 { get; set; }

		/// <summary>
		/// Conventionnal string representation for Fanuc configuration, like : "F U T, 0, 0, 0" or "R, 0, 0, 0"
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Parse a Fanuc configuration string representation, like : "N U T, 0, 0, 0" or "R, 0, 0, 0"
		/// </summary>
		public void FromString(string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
