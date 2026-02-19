//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Abstract base class for typed variable structures
	/// </summary>
	public abstract class GenericVariableType : IGenericVariableType {

		/// <summary>
		/// Gets a field by name (case-insensitive)
		/// </summary>
		public GenericField GetField(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


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


		protected GenericVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Fields contained in this type
		/// </summary>
		public GenericField[] Fields { get; }

		/// <summary>
		/// Internal Fanuc type name
		/// </summary>
		public abstract string FanucInternalTypeName { get; }

		/// <summary>
		/// Parent container
		/// </summary>
		public IGenericVariableType Parent { get; }

		IGenericVariableType[] IGenericVariableType.Fields => Fields;

		string IGenericVariableType.Name => FanucInternalTypeName;
	}
}
