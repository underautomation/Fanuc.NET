//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Result of reading a digital input.
	/// </summary>
	public class DigitalInputValue : RmiResponseBase {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public DigitalInputValue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Port number.
		/// </summary>
		public short PortNumber { get; set; }

		/// <summary>
		/// Port value (0 = OFF, 1 = ON).
		/// </summary>
		public byte PortValue { get; set; }
	}
}
