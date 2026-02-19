//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Snpx.Assignment;

namespace Snpx.Internal {
	/// <summary>
	/// Provides access to string registers (SR[]) on the robot via SNPX.
	/// </summary>
	public class StringRegisters : SnpxWritableAssignableIndexableElements<string, StringRegistersBatchAssignment> {


		protected override string GetAssignmentName(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected override string ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the robot at the specified offset.
		/// </summary>
		protected override void WriteInClient(int offset, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a batch assignment for reading multiple string registers.
		/// </summary>
		/// <param name="startIndex">The starting register index.</param>
		/// <param name="count">The number of consecutive registers.</param>
		/// <returns>A batch assignment for the specified range.</returns>
		public StringRegistersBatchAssignment CreateBatchAssignment(int startIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
