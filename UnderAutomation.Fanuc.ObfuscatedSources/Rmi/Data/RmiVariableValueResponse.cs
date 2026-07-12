//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Result of reading a system variable.
	/// </summary>
	public class RmiVariableValueResponse : RmiResponseBase {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RmiVariableValueResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Variable name, including the leading <code>$</code> character.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Whether the variable holds a floating-point value.
		/// </summary>
		public bool IsInteger { get; set; }

		/// <summary>
		/// Gets or sets the value as an integer. Internally stored as a double.
		/// </summary>
		public int IntegerValue { get; set; }

		/// <summary>
		/// Gets or sets the value as a double-precision floating-point number.
		/// </summary>
		public double RealValue { get; set; }
	}
}
