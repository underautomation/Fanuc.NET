//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public abstract class ExtendedPacketBase : PacketBase {


		public override byte PacketNumber { get; set; }


		public override byte TotalPacketNumber { get; set; }


		public ServiceRequestCode ServiceRequestCode { get; set; }


		public SegmentSelector SegmentSelector { get; set; }


		public override byte[] Payload { get; set; }


		public override byte[] ActualPayload => default;


		public ExtendedPacketBase() : base(default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
