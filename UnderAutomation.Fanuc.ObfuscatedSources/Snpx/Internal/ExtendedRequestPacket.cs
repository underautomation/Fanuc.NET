//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public class ExtendedRequestPacket : ExtendedPacketBase, IRequestPacket, IPacket {


		public ExtendedRequestPacket()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public ushort Index { get; set; }


		public ushort Count { get; set; }
	}
}
