//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public abstract class PacketBase {


		public const int HEADER_LENGTH = 56;


		protected static ushort _ToUInt16(byte b1, byte b0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected static uint _ToUInt32(byte b3, byte b2, byte b1, byte b0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected static void _ToBytes(ushort value, out byte b1, out byte b0)
		{
			b1 = default;
			b0 = default;
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected static void _ToBytes(uint value, out byte b3, out byte b2, out byte b1, out byte b0)
		{
			b3 = default;
			b2 = default;
			b1 = default;
			b0 = default;
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public static int ExtraLengthFromHeaderBuffer(byte[] buffer)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public PacketBase(byte[] buffer = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public byte[] GetBytes()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public byte[] Header { get; protected set; }


		public PacketType PacketType { get; set; }


		protected byte _SequenceNumber { get; set; }


		public virtual ushort ExtraLength { get; protected set; }


		public uint Unknown_8 { get; set; }


		public uint Unknown_16 { get; set; }


		public byte Second { get; set; }


		public byte Minute { get; set; }


		public byte Hour { get; set; }


		protected byte _SequenceNumber2 { get; set; }


		public MessageType MessageType { get; set; }


		public uint MailboxSource { get; set; }


		public uint MailboxDestination { get; set; }


		public virtual byte PacketNumber { get; set; }


		public virtual byte TotalPacketNumber { get; set; }


		public byte SequenceNumber { get; set; }


		public virtual byte[] ExtraPayload { get; set; }


		public abstract byte[] Payload { get; set; }


		public abstract byte[] ActualPayload { get; }
	}
}
