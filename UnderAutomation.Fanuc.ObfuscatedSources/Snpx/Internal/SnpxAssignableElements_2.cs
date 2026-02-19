//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Abstract base class for SNPX elements that support memory assignment for efficient access.
	/// </summary>
	public abstract class SnpxAssignableElements<TValue, TIndex> : SnpxElements<TValue, TIndex> {

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected abstract TValue ReadFromClient(int offset);

		/// <summary>
		/// Reads the value at the specified index.
		/// </summary>
		/// <param name="index">The index to read from.</param>
		/// <returns>The value at the index.</returns>
		public override TValue Read(TIndex index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected abstract string GetAssignmentTarget(TIndex index);


		protected abstract string GetAssignmentName(TIndex index);

		/// <summary>
		/// Gets or creates an assignment for the specified index.
		/// </summary>
		/// <param name="index">The index to get or create an assignment for.</param>
		/// <returns>The existing or newly created assignment.</returns>
		public Assignment<TIndex> GetOrCreateAssignment(TIndex index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected abstract int AssignmentSize { get; }
	}
}
