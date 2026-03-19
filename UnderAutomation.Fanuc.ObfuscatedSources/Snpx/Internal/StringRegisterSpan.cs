//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Defines a span within a string register, specifying the register index, start position, and length.
	/// </summary>
	public class StringRegisterSpan {

		/// <summary>
		/// Creates a new instance with default values.
		/// </summary>
		public StringRegisterSpan()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new instance with the specified register index, string length, and optional start index.
		/// </summary>
		/// <param name="registerIndex">The register index (1-based).</param>
		/// <param name="stringLength">The number of characters (must be even, &gt;= 2).</param>
		/// <param name="stringStartIndex">The start index within the string (must be even, &gt;= 0).</param>
		public StringRegisterSpan(int registerIndex, int stringLength, int stringStartIndex = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Register index, starts from 1
		/// </summary>
		public int RegisterIndex { get; set; }

		/// <summary>
		/// String start index of the string to manipulate. Default : 0 (beginning of the string). Must be even and non-negative.
		/// </summary>
		public int StringStartIndex { get; set; }

		/// <summary>
		/// Number of characters to return, should be an even number. Default : 80. Must be even, &gt;= 2.
		/// </summary>
		public int StringLength { get; set; }
	}
}
