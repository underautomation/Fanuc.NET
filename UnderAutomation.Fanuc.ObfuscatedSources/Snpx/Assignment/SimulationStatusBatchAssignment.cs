//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.Snpx.Internal;
using System;

namespace UnderAutomation.Fanuc.Snpx.Assignment {
	/// <summary>
	/// Batch assignment for reading multiple I/O simulation statuses at once.
	/// </summary>
	public class SimulationStatusBatchAssignment : BatchAssignment<bool, SimulationData> {

		/// <summary>
		/// Initializes a new instance of the <see cref="UnderAutomation.Fanuc.Snpx.Assignment.SimulationStatusBatchAssignment"/> class.
		/// </summary>
		public SimulationStatusBatchAssignment()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads all simulation statuses assigned in this batch.
		/// </summary>
		/// <returns>An array of boolean values indicating simulation state.</returns>
		public override bool[] Read()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
