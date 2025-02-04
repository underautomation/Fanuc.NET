//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Interface for a structure that contains variables
	/// </summary>
	public interface IGenericVariableType {

		/// <summary>
		/// Fields inside this structure
		/// </summary>
		IGenericVariableType[] Fields { get; }

		/// <summary>
		/// Name of the structure
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Parent of this structure
		/// </summary>
		IGenericVariableType Parent { get; }
	}
}
