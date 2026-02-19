//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Base class for responses with a controller <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiTimedResponse.TimeTag" data-throw-if-not-resolved="false"></xref> value.
	/// </summary>
	public class RmiTimedResponse : RmiResponseBase {


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


		public RmiTimedResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Controller time tick for the data sample.
		/// </summary>
		public int TimeTag { get; set; }
	}
}
