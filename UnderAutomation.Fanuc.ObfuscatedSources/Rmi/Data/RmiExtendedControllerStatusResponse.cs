//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Rmi.Data {
	/// <summary>
	/// Extended controller status returned by FRC_GetExtStatus.
	/// </summary>
	public class RmiExtendedControllerStatusResponse : RmiResponseBase {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RmiExtendedControllerStatusResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Last reported error code text, or null when no error is active.
		/// </summary>
		public string ErrorCode { get; set; }

		/// <summary>
		/// Whether the robot is currently executing a motion.
		/// </summary>
		public bool InMotion { get; set; }

		/// <summary>
		/// Active control mode string (e.g. "AUTO"), or null when unavailable.
		/// </summary>
		public string ControlMode { get; set; }

		/// <summary>
		/// Whether the servo drives are powered on.
		/// </summary>
		public bool DrivesPowered { get; set; }

		/// <summary>
		/// General speed override percentage.
		/// </summary>
		public int GenOverride { get; set; }

		/// <summary>
		/// Speed clamp limit in mm/s, or null when not configured.
		/// </summary>
		public double? SpeedClampLimit { get; set; }
	}
}
