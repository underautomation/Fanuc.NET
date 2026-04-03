//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Represents a numeric register value that can be either integer or real.
	/// </summary>
	public class NumericRegister {

		/// <summary>
		/// Default constructor.
		/// </summary>
		public NumericRegister()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a numeric register with an integer value.
		/// </summary>
		public NumericRegister(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a numeric register with a real (double) value.
		/// </summary>
		public NumericRegister(double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indicates whether the register holds an integer value (true) or a real value (false)
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
