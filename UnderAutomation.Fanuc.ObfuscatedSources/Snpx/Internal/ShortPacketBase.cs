//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public abstract class ShortPacketBase : PacketBase {


		public ShortPacketBase() : base(default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public ServiceRequestCode ServiceRequestCode { get; set; }


		public SegmentSelector SegmentSelector { get; set; }


		public override byte[] ActualPayload => default;
	}
}
