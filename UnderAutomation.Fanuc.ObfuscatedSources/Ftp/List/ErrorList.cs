//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.List {

	public class ErrorList : IFanucContent {


		public ErrorList()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// File name
		/// </summary>
		public string Name { get; }


		public ErrallSectionItem[] Items { get; }
	}
}
