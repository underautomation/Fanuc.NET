//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Snpx.Assignment;

namespace Snpx.Internal {
	/// <summary>
	/// Provides read/write access to I/O simulation status via SNPX.
	/// </summary>
	public class SimulationStatus : SnpxWritableAssignableElements<bool, SimulationData, SimulationStatusBatchAssignment> {


		protected override int GetAssignmentSize(SimulationData index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentName(SimulationData index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(SimulationData index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected override bool ReadFromClient(int offset, SimulationData index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the robot at the specified offset.
		/// </summary>
		protected override void WriteInClient(int offset, SimulationData index, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads the simulation status for the specified I/O type and index.
		/// </summary>
		/// <param name="type">The type of I/O.</param>
		/// <param name="index">The 1-based I/O index.</param>
		/// <returns>True if the I/O is simulated, false otherwise.</returns>
		public bool Read(SimulationType type, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the simulation status for the specified I/O type and index.
		/// </summary>
		/// <param name="type">The type of I/O.</param>
		/// <param name="index">The 1-based I/O index.</param>
		/// <param name="value">True to enable simulation, false to disable.</param>
		public void Write(SimulationType type, int index, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
