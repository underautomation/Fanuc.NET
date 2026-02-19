//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Defines whether an alarm is active or historical.
	/// </summary>
	public enum AlarmType {

		/// <summary>
		/// Currently active alarm.
		/// </summary>
		Active = 10,

		/// <summary>
		/// Historical alarm from the alarm log.
		/// </summary>
		History = 9,
	}
}
