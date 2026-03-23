//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace Cgtp {
	/// <summary>
	/// Represents an error returned by the FANUC COMET RPC interface.
	/// </summary>
	public class CgtpException : Exception, ISerializable {

		/// <summary>
		/// Constructs a new <xref href="UnderAutomation.Fanuc.Cgtp.CgtpException" data-throw-if-not-resolved="false"></xref> with a message.
		/// </summary>
		public CgtpException(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructs a new <xref href="UnderAutomation.Fanuc.Cgtp.CgtpException" data-throw-if-not-resolved="false"></xref> with a message and inner exception.
		/// </summary>
		public CgtpException(string message, Exception inner)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructs a new <xref href="UnderAutomation.Fanuc.Cgtp.CgtpException" data-throw-if-not-resolved="false"></xref> with the RPC status code.
		/// </summary>
		public CgtpException(int status)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// The RPC status code returned by the controller when available.
		/// </summary>
		public int Status { get; }
	}
}
