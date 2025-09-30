//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Current UFRAME and UTOOL numbers.
	/// </summary>
	public class UFrameUToolNumbers : RmiResponseBase {


		public UFrameUToolNumbers()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Current user frame number.
		/// </summary>
		public byte UFrameNumber { get; set; }

		/// <summary>
		/// Current user tool number.
		/// </summary>
		public byte UToolNumber { get; set; }
	}
}
