//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Snpx.Internal {

	public abstract class SnpxWritableAssignableIndexableElements<TValue, TAssignment> : SnpxWritableAssignableElements<TValue, int, TAssignment> where TAssignment : BatchAssignment<TValue, int>, new() {


		public TAssignment CreateBatchAssignment(int startIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
