//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Represents a generic variable value with optional child fields
	/// </summary>
	public class GenericValue : IGenericVariableType {


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


		public GenericValue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Parent value that contains this value
		/// </summary>
		public GenericValue Parent { get; }

		/// <summary>
		/// Kind of value (scalar, array, structure, or file)
		/// </summary>
		public virtual ValueKind Kind { get; }

		/// <summary>
		/// Child fields of this value
		/// </summary>
		public GenericField[] Fields { get; }

		/// <summary>
		/// Name of this value
		/// </summary>
		public virtual string Name { get; }

		/// <summary>
		/// Indicates whether this value is uninitialized
		/// </summary>
		public bool IsUninitialized { get; }

		/// <summary>
		/// String representation of the value
		/// </summary>
		public string Value { get; }

		/// <summary>
		/// Register name associated with this value
		/// </summary>
		public string RegisterName { get; }

		/// <summary>
		/// Fully qualified name including all parent names
		/// </summary>
		public string FullName { get; }

		IGenericVariableType IGenericVariableType.Parent => Parent;

		IGenericVariableType[] IGenericVariableType.Fields => Fields;
	}
}
