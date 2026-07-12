//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rmi.Data {
	/// <summary>
	/// Result of reading a numeric register.
	/// </summary>
	public class RmiNumericRegisterValueResponse : RmiResponseBase {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RmiNumericRegisterValueResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Register number.
		/// </summary>
		public int RegisterNumber { get; set; }

		/// <summary>
		/// Register value.
		/// </summary>
		public NumericRegister Value { get; set; }
	}
}
