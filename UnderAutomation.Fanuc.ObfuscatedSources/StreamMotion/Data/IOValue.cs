//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// State of 16 consecutive I/O read by Stream Motion
	/// </summary>
	public class IOValue {

		/// <summary>
		/// Number of I/O read in one range
		/// </summary>
		public const int RangeSize = 16;

		/// <summary>
		/// Returns the state of one I/O of the range
		/// </summary>
		/// <param name="index">I/O index, between <xref href="UnderAutomation.Fanuc.StreamMotion.Data.IOValue.Index" data-throw-if-not-resolved="false"></xref> and <xref href="UnderAutomation.Fanuc.StreamMotion.Data.IOValue.Index" data-throw-if-not-resolved="false"></xref> + 15</param>
		public bool GetState(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


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

		/// <summary>
		/// I/O type
		/// </summary>
		public IOType Type { get; }

		/// <summary>
		/// Index of the first I/O of the range
		/// </summary>
		public int Index { get; }

		/// <summary>
		/// State of the 16 I/O. Bit 0 is the I/O at <xref href="UnderAutomation.Fanuc.StreamMotion.Data.IOValue.Index" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public int Value { get; }

		/// <summary>
		/// Number of status received since this value was read. -1 if it was never read.
		/// </summary>
		public int Age { get; }
	}
}
