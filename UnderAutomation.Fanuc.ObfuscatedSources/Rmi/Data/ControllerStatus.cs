//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Status snapshot returned by FRC_GetStatus.
	/// </summary>
	public class ControllerStatus : RmiResponseBase {


		public ControllerStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Servo ready state (1 = ready).
		/// </summary>
		public byte ServoReady { get; set; }

		/// <summary>
		/// Teach pendant mode (0 = disabled/AUTO, 1 = enabled/TEACH).
		/// </summary>
		public byte TPMode { get; set; }

		/// <summary>
		/// RMI motion runtime state (1 = running).
		/// </summary>
		public byte RMIMotionStatus { get; set; }

		/// <summary>
		/// RMI_MOVE program status (1 = aborted).
		/// </summary>
		public byte ProgramStatus { get; set; }

		/// <summary>
		/// Single step mode flag (1 = on).
		/// </summary>
		public byte SingleStepMode { get; set; }

		/// <summary>
		/// Number of UTOOLs configured.
		/// </summary>
		public byte NumberUTool { get; set; }

		/// <summary>
		/// Next valid SequenceID when sequence checking is enabled.
		/// </summary>
		public int NextSequenceId { get; set; }

		/// <summary>
		/// Number of UFRAMEs configured.
		/// </summary>
		public byte NumberUFrame { get; set; }
	}
}
