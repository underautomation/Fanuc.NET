//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.List {
	/// <summary>
	/// Represents a single error item from the ERRALL error log
	/// </summary>
	public class ErrallSectionItem {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public ErrallSectionItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Error entry identifier
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Raw text of the error entry
		/// </summary>
		public string Text { get; }

		/// <summary>
		/// Parsed error code (e.g. "SRVO-001")
		/// </summary>
		public string ErrorCode { get; }

		/// <summary>
		/// Error message description
		/// </summary>
		public string Message { get; }

		/// <summary>
		/// Date and time when the error occurred
		/// </summary>
		public DateTime OccurringTime { get; }

		/// <summary>
		/// Indicates whether this entry is a RESET marker
		/// </summary>
		public bool IsReset { get; }
	}
}
