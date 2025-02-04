//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Snpx.Internal {

	public class DigitalSignals : SnpxElements<bool, int> {


		public override bool Read(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public bool[] Read(int firstIndex, ushort count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public void Write(int index, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Write(int firstIndex, bool[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public SegmentSelector SegmentSelector { get; }


		public SegmentOffset SegmentOffset { get; }


		public SegmentName SegmentName { get; }
	}
}
