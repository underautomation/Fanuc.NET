//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public interface IPacket {


		MessageType MessageType { get; }


		byte[] Header { get; }


		byte[] ExtraPayload { get; }


		byte[] GetBytes()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
