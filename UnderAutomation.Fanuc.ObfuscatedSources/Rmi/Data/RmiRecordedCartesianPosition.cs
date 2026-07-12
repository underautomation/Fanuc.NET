//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rmi.Data {
	/// <summary>
	/// Cartesian position received from the controller via the RMI Position Record menu (TouchUp).
	/// </summary>
	public class RmiRecordedCartesianPosition {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RmiRecordedCartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Position identifier assigned by the controller.
		/// </summary>
		public ushort PositionId { get; set; }

		/// <summary>
		/// Recorded Cartesian position including arm configuration and active frame/tool numbers.
		/// </summary>
		public CartesianPositionWithUserFrame Position { get; set; }
	}
}
