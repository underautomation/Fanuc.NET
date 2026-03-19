//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Specifies the I/O type and index for reading or writing simulation status via SNPX.
	/// </summary>
	public class SimulationData {

		/// <summary>
		/// Creates a new instance with default values.
		/// </summary>
		public SimulationData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new instance with the specified type and index.
		/// </summary>
		/// <param name="type">The type of I/O.</param>
		/// <param name="index">The 1-based index of the I/O.</param>
		public SimulationData(SimulationType type, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// The type of I/O.
		/// </summary>
		public SimulationType Type { get; set; }

		/// <summary>
		/// The 1-based index of the I/O. Must be &gt;= 1.
		/// </summary>
		public int Index { get; set; }
	}
}
