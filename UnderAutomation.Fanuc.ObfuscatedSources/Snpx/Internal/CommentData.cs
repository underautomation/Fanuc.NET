//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Specifies the data type, index, and string length for reading or writing a comment via SNPX.
	/// </summary>
	public class CommentData {

		/// <summary>
		/// Creates a new instance with default values.
		/// </summary>
		public CommentData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new instance with the specified type, index, and optional string length.
		/// </summary>
		/// <param name="type">The type of data to read the comment for.</param>
		/// <param name="index">The 1-based index of the element.</param>
		/// <param name="stringLength">The number of characters (must be even, &gt;= 2). Default is 16.</param>
		public CommentData(CommentType type, int index, int stringLength = 16)
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
		/// The type of data to read the comment for.
		/// </summary>
		public CommentType Type { get; set; }

		/// <summary>
		/// The 1-based index of the element. Must be &gt;= 1.
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// Number of characters to read/write. Must be even, &gt;= 2. Default is 16.
		/// </summary>
		public int StringLength { get; set; }
	}
}
