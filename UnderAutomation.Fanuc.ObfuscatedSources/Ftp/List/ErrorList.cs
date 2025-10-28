//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.List {

	public class ErrorList : IFanucContent {

		/// <summary>
		/// Return active alarms among the list of all error items
		/// </summary>
		public ErrallSectionItem[] FilterActiveAlarms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public ErrorList()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// File name (ERRALL.LS)
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// List of all error items (active and history)
		/// </summary>
		public ErrallSectionItem[] Items { get; }
	}
}
