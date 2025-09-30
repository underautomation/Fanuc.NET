//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Result of reading TCP speed.
	/// </summary>
	public class TcpSpeed : RmiTimedResponse {


		public TcpSpeed()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Current tool center point speed.
		/// </summary>
		public double Speed { get; set; }
	}
}
