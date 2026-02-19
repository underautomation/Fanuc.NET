//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Represents the severity level of a robot alarm.
	/// </summary>
	public enum AlarmSeverity : short {

		/// <summary>
		/// No severity.
		/// </summary>
		NONE = 128,

		/// <summary>
		/// Warning level alarm.
		/// </summary>
		WARN = 0,

		/// <summary>
		/// Local pause level alarm.
		/// </summary>
		PAUSE_L = 2,

		/// <summary>
		/// Global pause level alarm.
		/// </summary>
		PAUSE_G = 34,

		/// <summary>
		/// Local stop level alarm.
		/// </summary>
		STOP_L = 6,

		/// <summary>
		/// Global stop level alarm.
		/// </summary>
		STOP_G = 38,

		/// <summary>
		/// Servo error alarm.
		/// </summary>
		SERVO = 54,

		/// <summary>
		/// Local abort level alarm.
		/// </summary>
		ABORT_L = 11,

		/// <summary>
		/// Global abort level alarm.
		/// </summary>
		ABORT_G = 45,

		/// <summary>
		/// Servo error level 2 alarm.
		/// </summary>
		SERVO2 = 58,

		/// <summary>
		/// System level alarm.
		/// </summary>
		SYSTEM = 122,
	}
}
