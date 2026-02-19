//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Contains the position for each robots
	/// </summary>
	public class CurrentPosition : IFanucContent {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public CurrentPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Position of each robots handled by this controller
		/// </summary>
		public GroupPosition[] GroupsPosition { get; }

		/// <summary>
		/// File name : curpos.dg
		/// </summary>
		public string Name { get; }
	}
}
