//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Abstract base class for writable assignable SNPX elements.
	/// </summary>
	public abstract class SnpxWritableAssignableElements<TValue, TIndex, TAssignment> : SnpxAssignableElements<TValue, TIndex> where TAssignment : BatchAssignment<TValue, TIndex>, new() {

		/// <summary>
		/// Writes a value to the robot at the specified offset.
		/// </summary>
		protected abstract void WriteInClient(int offset, TValue value);

		/// <summary>
		/// Write value at a certain index.
		/// </summary>
		/// <param name="index">The element index.</param>
		/// <param name="value">The value to write.</param>
		public void Write(TIndex index, TValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a batch assignment for the specified indices.
		/// </summary>
		/// <param name="indexes">The indices to include in the batch.</param>
		/// <returns>A batch assignment for the specified indices.</returns>
		public TAssignment CreateBatchAssignment(TIndex[] indexes)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
