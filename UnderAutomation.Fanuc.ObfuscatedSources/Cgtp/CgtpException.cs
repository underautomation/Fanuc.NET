//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace Cgtp {
	/// <summary>
	/// Represents an error returned by the FANUC controller via CGTP.
	/// </summary>
	public class CgtpException : Exception, ISerializable {

		/// <summary>
		/// The RPC status code returned by the controller when available.
		/// </summary>
		public int Status { get; }
	}
}
