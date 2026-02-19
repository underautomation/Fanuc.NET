//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Result of an I/O read operation
	/// </summary>
	public class IOReadResult {

		/// <summary>
		/// Returns a string representation
		/// </summary>
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


		public IOReadResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Type of I/O that was read
		/// </summary>
		public IOType Type { get; }

		/// <summary>
		/// Index of the I/O
		/// </summary>
		public ushort Index { get; }

		/// <summary>
		/// Mask applied to the read
		/// </summary>
		public ushort Mask { get; }

		/// <summary>
		/// Value read from the I/O
		/// </summary>
		public ushort Value { get; }
	}
}
