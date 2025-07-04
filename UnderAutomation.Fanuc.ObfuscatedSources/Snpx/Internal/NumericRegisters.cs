//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Snpx.Assignment;

namespace Snpx.Internal {

	public class NumericRegisters : SnpxWritableAssignableElements<float, int, NumericRegistersBatchAssignment> {


		protected override string GetAssignmentName(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override float ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override void WriteInClient(int offset, float value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public NumericRegistersBatchAssignment CreateBatchAssignment(int startIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
