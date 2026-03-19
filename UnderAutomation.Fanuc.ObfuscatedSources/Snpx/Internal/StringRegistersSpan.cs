//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Snpx.Assignment;

namespace Snpx.Internal {
	/// <summary>
	/// Provides access to string registers (SR[]) with control over start index and length via SNPX.
	/// </summary>
	public class StringRegistersSpan : SnpxWritableAssignableElements<string, StringRegisterSpan, StringRegistersSpanBatchAssignment> {


		protected override int GetAssignmentSize(StringRegisterSpan index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentName(StringRegisterSpan index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(StringRegisterSpan index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected override string ReadFromClient(int offset, StringRegisterSpan index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the robot at the specified offset.
		/// </summary>
		protected override void WriteInClient(int offset, StringRegisterSpan index, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads a substring from the specified string register.
		/// </summary>
		/// <param name="registerIndex">The register index (1-based).</param>
		/// <param name="stringLength">The number of characters to read (must be even, &gt;= 2).</param>
		/// <param name="stringStartIndex">The start index within the string (must be even, &gt;= 0).</param>
		/// <returns>The string value read from the register.</returns>
		public string Read(int registerIndex, int stringLength, int stringStartIndex = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a string value to the specified string register span.
		/// </summary>
		/// <param name="registerIndex">The register index (1-based).</param>
		/// <param name="value">The string value to write.</param>
		/// <param name="stringLength">The number of characters to write (must be even, &gt;= 2).</param>
		/// <param name="stringStartIndex">The start index within the string (must be even, &gt;= 0).</param>
		public void Write(int registerIndex, string value, int stringLength, int stringStartIndex = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
