//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;
using Snpx.Assignment;

namespace Snpx.Internal {

	public class PositionSystemVariables : SnpxWritableAssignableElements<Position, string, PositionSystemVariablesBatchAssignment> {


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


		protected override Position ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override void WriteInClient(int offset, Position value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Write(string variable, JointsPosition jointsPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Write(string variable, ExtendedCartesianPosition extendedCartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Write(string variable, CartesianPosition cartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public Position Read(string index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
