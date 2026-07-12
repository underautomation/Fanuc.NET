//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;

namespace Rmi.Data {
	/// <summary>
	/// Status snapshot returned by FRC_GetStatus.
	/// </summary>
	public class RmiControllerStatusResponse : RmiResponseBase {


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


		public RmiControllerStatusResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// The robot controller is ready for motion
		/// </summary>
		public bool ServoReady { get; set; }

		/// <summary>
		/// Teach Pendant Enabled (Switch on position ON) The Remote Motion interface only works when the teach pendant is disabled
		/// </summary>
		public bool TPEnabled { get; set; }

		/// <summary>
		/// The Remote Motion Interface is running
		/// </summary>
		public bool RmiMotionStatus { get; set; }

		/// <summary>
		/// RMI_MOVE program status
		/// </summary>
		public TaskStatus ProgramStatus { get; set; }

		/// <summary>
		/// Single step mode
		/// </summary>
		public bool SingleStepMode { get; set; }

		/// <summary>
		/// Number of user tools available in the robot controller
		/// </summary>
		public byte NumberUTool { get; set; }

		/// <summary>
		/// The next valid sequence ID. This key is only valid if the system variable $RMI_CFG.$Chk_seqID = TRUE
		/// </summary>
		public int? NextSequenceId { get; set; }

		/// <summary>
		/// Number of user frames available in the robot controller
		/// </summary>
		public byte NumberUFrame { get; set; }

		/// <summary>
		/// The current speed override setting (1–100).
		/// </summary>
		public byte SpeedOverride { get; set; }

		/// <summary>
		/// Indicates the value of $RMI_CFG.$Chk_seqID, which is the configuration value that determines whether the controller checks valid incremented sequence IDs on incoming instructions.
		/// </summary>
		public bool CheckSequenceId { get; }
	}
}
