//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// A digital port status
	/// </summary>
	public class IOStatus {

		/// <summary>
		/// String representation like : DIN[1]=True
		/// </summary>
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


		public IOStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Digital port type
		/// </summary>
		public DigitalPorts Port { get; }

		/// <summary>
		/// Digital port ID
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Digital port value
		/// </summary>
		public bool Value { get; }

		/// <summary>
		/// IO Name
		/// </summary>
		public string Name { get; }
	}
}
