//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rmi.Data {
	/// <summary>
	/// Position register data paired with its register number.
	/// </summary>
	public class RmiPositionRegisterDataResponse : RmiResponseBase {


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


		public RmiPositionRegisterDataResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Register number
		/// </summary>
		public short RegisterNumber { get; set; }

		/// <summary>
		/// Position register value.
		/// </summary>
		public CartesianPositionWithUserFrame CartesianPosition { get; set; }
	}
}
