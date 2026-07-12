//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Rmi.Data {
	/// <summary>
	/// Current UFRAME and UTOOL numbers, optionally scoped to a motion group.
	/// </summary>
	public class RmiUFrameUToolNumbersResponse : RmiResponseBase {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RmiUFrameUToolNumbersResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Current user frame number.
		/// </summary>
		public byte Frame { get; set; }

		/// <summary>
		/// Current user tool number.
		/// </summary>
		public byte Tool { get; set; }

		/// <summary>
		/// Motion group number, or null when not applicable.
		/// </summary>
		public byte? Group { get; set; }
	}
}
