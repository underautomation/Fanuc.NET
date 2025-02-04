//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {

	public class GenericValue : IGenericVariableType {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public GenericValue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public GenericValue Parent { get; }


		public virtual ValueKind Kind { get; }


		public GenericField[] Fields { get; }

		/// <summary>
		/// Name of the structure
		/// </summary>
		public virtual string Name { get; }


		public bool IsUninitialized { get; }


		public string Value { get; }


		public string RegisterName { get; }


		public string FullName { get; }

		IGenericVariableType IGenericVariableType.Parent => Parent;

		IGenericVariableType[] IGenericVariableType.Fields => Fields;
	}
}
