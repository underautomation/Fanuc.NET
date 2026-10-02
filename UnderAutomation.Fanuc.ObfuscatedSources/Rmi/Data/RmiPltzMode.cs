//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.Rmi.Data {
	/// <summary>
	/// Palletizing motion mode passed to <see cref="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.Initialize(System.Nullable{System.Byte},System.Nullable{System.Boolean},System.Nullable{UnderAutomation.Fanuc.Rmi.Data.RmiPltzMode})"/>.
	/// Requires MajorVersion &gt;= 7.
	/// </summary>
	public enum RmiPltzMode {

		/// <summary>
		/// Zero-approach descent.
		/// </summary>
		ZeroDown = 0,

		/// <summary>
		/// Zero-approach ascent.
		/// </summary>
		ZeroUp = 1,

		/// <summary>
		/// Palletizing-spine descent.
		/// </summary>
		PspiDown = 2,

		/// <summary>
		/// Palletizing-spine ascent.
		/// </summary>
		PspiUp = 3,

		/// <summary>
		/// Multi-spine descent.
		/// </summary>
		MspiDown = 4,

		/// <summary>
		/// Multi-spine ascent.
		/// </summary>
		MspiUp = 5,
	}
}
