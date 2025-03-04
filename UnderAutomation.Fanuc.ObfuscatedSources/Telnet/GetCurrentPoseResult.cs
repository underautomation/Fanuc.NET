//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Telnet {

	public class GetCurrentPoseResult : Result {

		/// <summary>
		/// Lors de l'implémentation, retourner true si la trame est supposée terminé d'être reçue
		/// </summary>
		protected override bool FromResult(string data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public GetCurrentPoseResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Group number of the current pose.
		/// </summary>
		public int Group { get; }

		/// <summary>
		/// Cartesian position value of the current pose.
		/// </summary>
		public CartesianPosition Position { get; }
	}
}
