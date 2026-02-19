//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using Snpx.Assignment;

namespace Snpx.Internal {
	/// <summary>
	/// Provides access to position registers (PR[]) on the robot via SNPX.
	/// </summary>
	public class PositionRegisters : SnpxWritableAssignableIndexableElements<Position, PositionRegistersBatchAssignment> {


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
		/// Writes a joints position to the specified position register.
		/// </summary>
		/// <param name="index">The register index.</param>
		/// <param name="jointsPosition">The joints position to write.</param>
		public void Write(int index, JointsPosition jointsPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes an extended Cartesian position to the specified position register.
		/// </summary>
		/// <param name="index">The register index.</param>
		/// <param name="extendedCartesianPosition">The extended Cartesian position to write.</param>
		public void Write(int index, ExtendedCartesianPosition extendedCartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes a Cartesian position to the specified position register.
		/// </summary>
		/// <param name="index">The register index.</param>
		/// <param name="cartesianPosition">The Cartesian position to write.</param>
		public void Write(int index, CartesianPosition cartesianPosition)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a batch assignment for reading multiple position registers.
		/// </summary>
		/// <param name="startIndex">The starting register index.</param>
		/// <param name="count">The number of consecutive registers.</param>
		/// <returns>A batch assignment for the specified range.</returns>
		public PositionRegistersBatchAssignment CreateBatchAssignment(int startIndex, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the position at the specified register index.
		/// </summary>
		/// <param name="index">The register index.</param>
		/// <returns>The position value.</returns>
		public Position Read(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
