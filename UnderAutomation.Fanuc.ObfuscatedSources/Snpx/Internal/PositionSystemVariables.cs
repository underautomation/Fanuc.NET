//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;
using Snpx.Assignment;

namespace Snpx.Internal {
	/// <summary>
	/// Provides access to position system variables on the robot via SNPX.
	/// </summary>
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

		/// <summary>
		/// Reads a value from the client at the specified memory offset.
		/// </summary>
		protected override Position ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the robot at the specified offset.
		/// </summary>
		protected override void WriteInClient(int offset, Position value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes a joints position to the specified system variable.
		/// </summary>
		/// <param name="variable">The system variable name.</param>
		/// <param name="jointsPosition">The joints position to write.</param>
		public void Write(string variable, JointsPosition jointsPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes an extended Cartesian position to the specified system variable.
		/// </summary>
		/// <param name="variable">The system variable name.</param>
		/// <param name="extendedCartesianPosition">The extended Cartesian position to write.</param>
		public void Write(string variable, ExtendedCartesianPosition extendedCartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes a Cartesian position to the specified system variable.
		/// </summary>
		/// <param name="variable">The system variable name.</param>
		/// <param name="cartesianPosition">The Cartesian position to write.</param>
		public void Write(string variable, CartesianPosition cartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads the position at the specified system variable.
		/// </summary>
		/// <param name="index">The system variable name.</param>
		/// <returns>The position value.</returns>
		public Position Read(string index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
