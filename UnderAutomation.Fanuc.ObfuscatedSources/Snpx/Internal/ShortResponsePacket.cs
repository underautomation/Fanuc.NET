//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public class ShortResponsePacket : ShortPacketBase, IResponsePacket, IPacket {


		public override byte[] Payload { get; set; }


		public ShortResponsePacket(byte[] buffer)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
