//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Result of reading cartesian position.
	/// </summary>
	public class CartesianPosition : RmiTimedResponse {


		public CartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Active configuration at sampling time.
		/// </summary>
		public MotionConfiguration Configuration { get; set; }

		/// <summary>
		/// Cartesian TCP position.
		/// </summary>
		public Frame Position { get; set; }
	}
}
