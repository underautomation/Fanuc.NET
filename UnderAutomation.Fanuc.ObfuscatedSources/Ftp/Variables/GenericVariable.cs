//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Represents a top-level variable declaration with scope and storage information
	/// </summary>
	public class GenericVariable : GenericField, IGenericVariableType {


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


		public GenericVariable()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Variable scope (e.g. PROG, SYS)
		/// </summary>
		public string Scope { get; }

		/// <summary>
		/// Storage type of the variable (e.g. CMOS, DRAM)
		/// </summary>
		public string Storage { get; }

		/// <summary>
		/// Parent container of this variable
		/// </summary>
		public IGenericVariableType Parent { get; }
	}
}
