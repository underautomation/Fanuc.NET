//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Snpx.Internal {
	/// <summary>
	/// Abstract base class for writable assignable elements accessed by integer index.
	/// </summary>
	public abstract class SnpxWritableAssignableIndexableElements<TValue, TAssignment> : SnpxWritableAssignableElements<TValue, int, TAssignment> where TAssignment : BatchAssignment<TValue, int>, new() {

		/// <summary>
		/// Creates a batch assignment for a range of consecutive indices.
		/// </summary>
		/// <param name="startIndex">The starting index.</param>
		/// <param name="count">The number of consecutive elements.</param>
		/// <returns>A batch assignment for the specified range.</returns>
		public TAssignment CreateBatchAssignment(int startIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
