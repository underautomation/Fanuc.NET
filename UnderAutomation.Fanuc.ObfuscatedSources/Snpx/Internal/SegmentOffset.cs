//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public enum SegmentOffset {

		/// <summary>
		/// Digital I/O
		/// </summary>
		SDIO = 0,

		/// <summary>
		/// Robot I/O
		/// </summary>
		RDIO = 5000,

		/// <summary>
		/// UI and UO
		/// </summary>
		UOP = 6000,

		/// <summary>
		/// SI and SO
		/// </summary>
		SOP = 7000,

		/// <summary>
		/// Weld I/O
		/// </summary>
		WIO = 8000,

		/// <summary>
		/// Wire Stick I/O
		/// </summary>
		WSI = 8400,

		/// <summary>
		/// PMC Keep Relay
		/// </summary>
		PMC_K = 10000,

		/// <summary>
		/// PMC Internal Relay
		/// </summary>
		PMC_R = 11000,

		/// <summary>
		/// Group I/O
		/// </summary>
		GIO = 0,

		/// <summary>
		/// Analog I/O
		/// </summary>
		AIO = 1000,

		/// <summary>
		/// PMC Data table
		/// </summary>
		PMC_D = 10000,
	}
}
