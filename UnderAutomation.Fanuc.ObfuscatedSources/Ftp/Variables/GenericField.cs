//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Represents a named field within a variable structure
	/// </summary>
	public class GenericField : GenericValue, IGenericVariableType {


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


		public GenericField()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Access modifier of the field (e.g. RW, RO)
		/// </summary>
		public virtual string Access { get; }

		/// <summary>
		/// Data type name of the field
		/// </summary>
		public virtual string Type { get; set; }

		/// <summary>
		/// Indicates whether this field is a register
		/// </summary>
		public virtual bool IsRegister { get; }

		/// <summary>
		/// Maximum string length if the field type is STRING
		/// </summary>
		public virtual int StringLength { get; }

		/// <summary>
		/// First dimension size of the array, or first index of an array element
		/// </summary>
		public int Dimension1 { get; }

		/// <summary>
		/// Second dimension size of the array, or second index of an array element
		/// </summary>
		public int Dimension2 { get; }
	}
}
