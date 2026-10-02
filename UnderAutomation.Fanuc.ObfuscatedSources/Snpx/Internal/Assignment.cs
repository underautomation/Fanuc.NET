//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.Snpx.Internal {
	/// <summary>
	/// Represents an SNPX assignment: an element of the robot that the SNPX client can read in one request.
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
		/// Gets the position of this assignment in the data of the SNPX client. Negative if cleared.
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
