//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Snpx.Internal {

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


		protected override Position ReadFromClient(int offset)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public Position ReadWorldPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public Position ReadWorldPosition(int group)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public Position ReadUserFramePosition(int userFrame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public Position ReadUserFramePosition(int userFrame, int group)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
