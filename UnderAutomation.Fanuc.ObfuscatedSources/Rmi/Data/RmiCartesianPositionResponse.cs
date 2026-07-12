//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rmi.Data {
	/// <summary>
	/// Result of reading the current Cartesian position.
	/// </summary>
	public class RmiCartesianPositionResponse : RmiTimedResponse {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RmiCartesianPositionResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Current TCP position including configuration and active frame/tool numbers.
		/// </summary>
		public CartesianPositionWithUserFrame Position { get; set; }
	}
}
