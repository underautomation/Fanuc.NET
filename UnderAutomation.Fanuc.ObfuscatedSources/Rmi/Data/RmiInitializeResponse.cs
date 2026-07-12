//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Rmi.Data {
	/// <summary>
	/// Response to the Initialize command, which starts the RMI motion program on the controller.
	/// </summary>
	public class RmiInitializeResponse : RmiResponseBase {


		public RmiInitializeResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Motion group mask echoed back by the controller.
		/// <code>null</code> when the controller does not return this field (single-group systems or MajorVersion &lt; 2).
		/// </summary>
		public byte? GroupMask { get; set; }
	}
}
