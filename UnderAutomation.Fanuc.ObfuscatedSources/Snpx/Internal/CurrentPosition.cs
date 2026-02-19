//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Snpx.Internal {
	/// <summary>
	/// Provides access to the current robot position via SNPX.
	/// </summary>
	public class CurrentPosition : SnpxAssignableElements<Position, CurrentPositionRequest> {


		protected override string GetAssignmentName(CurrentPositionRequest index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(CurrentPositionRequest index)
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
		/// Reads the current world position of the robot.
		/// </summary>
		/// <returns>The current position in world coordinates.</returns>
		public Position ReadWorldPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current world position of the specified motion group.
		/// </summary>
		/// <param name="group">The motion group number.</param>
		/// <returns>The current position in world coordinates.</returns>
		public Position ReadWorldPosition(int group)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current position in the specified user frame.
		/// </summary>
		/// <param name="userFrame">The user frame number.</param>
		/// <returns>The current position in the user frame.</returns>
		public Position ReadUserFramePosition(int userFrame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the current position in the specified user frame and motion group.
		/// </summary>
		/// <param name="userFrame">The user frame number.</param>
		/// <param name="group">The motion group number.</param>
		/// <returns>The current position in the user frame.</returns>
		public Position ReadUserFramePosition(int userFrame, int group)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
