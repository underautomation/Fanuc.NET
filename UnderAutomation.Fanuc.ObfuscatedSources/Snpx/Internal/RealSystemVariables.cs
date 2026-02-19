//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Snpx.Assignment;

namespace Snpx.Internal {
	/// <summary>
	/// Provides access to real (float) system variables on the robot via SNPX.
	/// </summary>
	public class RealSystemVariables : SnpxWritableAssignableElements<float, string, RealSystemVariablesBatchAssignment> {


		protected override string GetAssignmentName(string index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(string index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected override float ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the robot at the specified offset.
		/// </summary>
		protected override void WriteInClient(int offset, float value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected override int AssignmentSize => default;
	}
}
