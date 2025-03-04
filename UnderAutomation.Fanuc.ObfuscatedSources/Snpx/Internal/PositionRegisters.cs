//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;

namespace Snpx.Internal {

	public class PositionRegisters : SnpxWritableAssignableElements<Position, int> {


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


		protected override Position ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override void WriteInClient(int offset, Position value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Write(int index, JointsPosition jointsPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Write(int index, ExtendedCartesianPosition extendedCartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Write(int index, CartesianPosition cartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected override int AssignmentSize => default;
	}
}
