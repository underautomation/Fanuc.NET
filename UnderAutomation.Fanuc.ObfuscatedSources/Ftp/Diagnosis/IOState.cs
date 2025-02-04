//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using Ftp.Internal;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Status of all controller inputs and outputs
	/// </summary>
	public class IOState : IFanucContent {

		/// <summary>
		/// Status of all controller inputs and outputs
		/// </summary>
		public IOStatus[] States { get; }

		/// <summary>
		/// File name : iostate.dg
		/// </summary>
		public string Name { get; }
	}
}
