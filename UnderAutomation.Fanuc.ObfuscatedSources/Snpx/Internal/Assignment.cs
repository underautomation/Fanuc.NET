//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Represents an SNPX memory assignment mapping a named element to a memory offset.
	/// </summary>
	public class Assignment {


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

		/// <summary>
		/// Gets the memory offset for this assignment. Negative if cleared.
		/// </summary>
		public int Offset { get; }

		/// <summary>
		/// Gets a value indicating whether this assignment has been cleared.
		/// </summary>
		public bool IsAssignmentCleared { get; }

		/// <summary>
		/// Gets the display name of this assignment.
		/// </summary>
		public string Name { get; }
	}
}
