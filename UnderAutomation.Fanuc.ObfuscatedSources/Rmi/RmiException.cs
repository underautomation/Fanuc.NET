//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace Rmi {
	/// <summary>
	/// Represents an error reported by the FANUC RMI controller or thrown by the client runtime.
	/// </summary>
	public class RmiException : Exception, ISerializable {

		/// <summary>
		/// Constructs a new <xref href="UnderAutomation.Fanuc.Rmi.RmiException" data-throw-if-not-resolved="false"></xref> with a message.
		/// </summary>
		public RmiException(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructs a new <xref href="UnderAutomation.Fanuc.Rmi.RmiException" data-throw-if-not-resolved="false"></xref> with a message and an inner exception.
		/// </summary>
		public RmiException(string message, Exception inner)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructs a new <xref href="UnderAutomation.Fanuc.Rmi.RmiException" data-throw-if-not-resolved="false"></xref> with an error id coming from the controller.
		/// </summary>
		public RmiException(int errorId, string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the controller error id when available (0 means no error id was attached).
		/// </summary>
		public int ErrorId { get; }
	}
}
