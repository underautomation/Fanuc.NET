//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Complete position information of a group
	/// </summary>
	public class GroupPosition {


		public GroupPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Group ID
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Joint positions : the position of each robot angles
		/// </summary>
		public JointsPosition JointsPosition { get; }

		/// <summary>
		/// Position of each tools in each user frames
		/// </summary>
		public CartesianPositionWithUserFrame[] UserFramePositions { get; }

		/// <summary>
		/// Position of each tools in world coordinates
		/// </summary>
		public CartesianPositionWithTool[] WorldPositions { get; }
	}
}
