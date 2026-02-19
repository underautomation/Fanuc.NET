//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Implements IFanucContent to hold a collection of task states.
	/// </summary>
	public class ProgramStates : IFanucContent {


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


		public ProgramStates()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Array of task states currently on the controller.
		/// </summary>
		public TaskState[] TaskStates { get; set; }

		/// <summary>
		/// File name: prgstate.dg
		/// </summary>
		public string Name { get; }
	}
}
