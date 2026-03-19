//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Snpx.Assignment;

namespace Snpx.Internal {
	/// <summary>
	/// Provides read/write access to comments of registers, I/O signals and other data via SNPX.
	/// </summary>
	public class Comments : SnpxWritableAssignableElements<string, CommentData, CommentBatchAssignment> {


		protected override int GetAssignmentSize(CommentData index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentName(CommentData index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(CommentData index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected override string ReadFromClient(int offset, CommentData index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the robot at the specified offset.
		/// </summary>
		protected override void WriteInClient(int offset, CommentData index, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads the comment for the specified data type and index.
		/// </summary>
		/// <param name="type">The type of data.</param>
		/// <param name="index">The 1-based element index.</param>
		/// <param name="stringLength">The number of characters to read (must be even, &gt;= 2). Default is 16.</param>
		/// <returns>The comment string.</returns>
		public string Read(CommentType type, int index, int stringLength = 16)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a comment for the specified data type and index.
		/// </summary>
		/// <param name="type">The type of data.</param>
		/// <param name="index">The 1-based element index.</param>
		/// <param name="value">The comment string to write.</param>
		/// <param name="stringLength">The number of characters to write (must be even, &gt;= 2). Default is 16.</param>
		public void Write(CommentType type, int index, string value, int stringLength = 16)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
