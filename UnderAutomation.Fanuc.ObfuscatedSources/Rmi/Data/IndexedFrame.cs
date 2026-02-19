//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Frame data paired with an index (UFRAME or UTOOL).
	/// </summary>
	public class IndexedFrame : RmiResponseBase {


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


		public IndexedFrame()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Index (UFRAME or UTOOL number).
		/// </summary>
		public byte Index { get; set; }

		/// <summary>
		/// Frame data.
		/// </summary>
		public Frame Frame { get; set; }
	}
}
