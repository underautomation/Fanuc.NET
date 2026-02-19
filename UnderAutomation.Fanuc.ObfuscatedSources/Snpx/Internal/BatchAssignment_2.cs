//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Abstract base class for batch assignment operations that read multiple values at once.
	/// </summary>
	public abstract class BatchAssignment<TValue, TIndex> {

		/// <summary>
		/// The assignments included in this batch.
		/// </summary>
		public Assignment<TIndex>[] Assignments;

		/// <summary>
		/// The SNPX client used for communication.
		/// </summary>
		protected SnpxClientBase Client;

		/// <summary>
		/// Reads all values from the batch assignment.
		/// </summary>
		/// <returns>An array of values read from the robot.</returns>
		public abstract TValue[] Read();
	}
}
