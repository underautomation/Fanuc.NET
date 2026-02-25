//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Snpx.Assignment;

namespace Snpx.Internal {
	/// <summary>
	/// Provides access to numeric registers as 32 bits integer (R[]) on the robot via SNPX.
	/// </summary>
	public class NumericRegistersInt32 : NumericRegistersBase<int, NumericRegistersInt32BatchAssignment> {

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected override int ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the robot at the specified offset.
		/// </summary>
		protected override void WriteInClient(int offset, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a batch assignment for reading multiple numeric registers.
		/// </summary>
		/// <param name="startIndex">The starting register index.</param>
		/// <param name="count">The number of consecutive registers.</param>
		/// <returns>A batch assignment for the specified range.</returns>
		public NumericRegistersInt32BatchAssignment CreateBatchAssignment(int startIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
