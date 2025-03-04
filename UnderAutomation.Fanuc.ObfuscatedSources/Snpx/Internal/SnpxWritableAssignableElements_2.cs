//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public abstract class SnpxWritableAssignableElements<TValue, TIndex> : SnpxAssignableElements<TValue, TIndex> {


		protected abstract void WriteInClient(int offset, TValue value);

		/// <summary>
		/// Write value at a certain index
		/// </summary>
		public void Write(TIndex index, TValue value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
