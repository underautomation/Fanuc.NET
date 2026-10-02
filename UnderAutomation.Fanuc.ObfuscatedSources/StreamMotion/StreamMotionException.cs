//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace UnderAutomation.Fanuc.StreamMotion {
	/// <summary>
	/// Error raised by the Stream Motion client
	/// </summary>
	public class StreamMotionException : Exception, ISerializable {

		/// <summary>
		/// Creates a Stream Motion exception
		/// </summary>
		/// <param name="error">Kind of error</param>
		/// <param name="message">Error message</param>
		public StreamMotionException(StreamMotionError error, string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a Stream Motion exception with an inner exception
		/// </summary>
		/// <param name="error">Kind of error</param>
		/// <param name="message">Error message</param>
		/// <param name="inner">Inner exception</param>
		public StreamMotionException(StreamMotionError error, string message, Exception inner)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Kind of error
		/// </summary>
		public StreamMotionError Error { get; }
	}
}
