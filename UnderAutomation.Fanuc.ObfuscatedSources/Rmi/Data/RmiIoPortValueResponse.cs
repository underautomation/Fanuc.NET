//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Result of reading a generic IO port.
	/// </summary>
	public class RmiIoPortValueResponse : RmiResponseBase {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RmiIoPortValueResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Port type (DI, DO, AI, AO, GO, etc.).
		/// </summary>
		public RmiIoPortType PortType { get; set; }

		/// <summary>
		/// Port number.
		/// </summary>
		public int PortNumber { get; set; }

		/// <summary>
		/// Current port value.
		/// </summary>
		public double Value { get; set; }
	}
}
