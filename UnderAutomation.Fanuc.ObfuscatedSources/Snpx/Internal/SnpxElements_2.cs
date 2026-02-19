//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Abstract base class for accessing SNPX elements by index.
	/// </summary>
	public abstract class SnpxElements<TValue, TIndex> {

		/// <summary>
		/// The underlying SNPX client.
		/// </summary>
		protected SnpxClientBase _client;

		/// <summary>
		/// Reads the value at the specified index.
		/// </summary>
		/// <param name="index">The index to read from.</param>
		/// <returns>The value at the index.</returns>
		public abstract TValue Read(TIndex index);
	}
}
