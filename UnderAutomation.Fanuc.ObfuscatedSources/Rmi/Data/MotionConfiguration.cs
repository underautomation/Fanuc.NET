//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Motion configuration including frame/tool numbers and turn/flip bits.
	/// </summary>
	public class MotionConfiguration {


		public MotionConfiguration()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Active UTOOL number.
		/// </summary>
		public byte UToolNumber { get; set; }

		/// <summary>
		/// Active UFRAME number.
		/// </summary>
		public byte UFrameNumber { get; set; }

		/// <summary>
		/// FRONT bit (0/1).
		/// </summary>
		public byte Front { get; set; }

		/// <summary>
		/// UP bit (0/1).
		/// </summary>
		public byte Up { get; set; }

		/// <summary>
		/// LEFT bit (0/1).
		/// </summary>
		public byte Left { get; set; }

		/// <summary>
		/// FLIP bit (0/1).
		/// </summary>
		public byte Flip { get; set; }

		/// <summary>
		/// Turn 4.
		/// </summary>
		public byte Turn4 { get; set; }

		/// <summary>
		/// Turn 5.
		/// </summary>
		public byte Turn5 { get; set; }

		/// <summary>
		/// Turn 6.
		/// </summary>
		public byte Turn6 { get; set; }
	}
}
