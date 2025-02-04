//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public abstract class SnpxElements<TValue, TIndex> {


		protected SnpxClientBase _client;


		public abstract TValue Read(TIndex index);
	}
}
