//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {

	public class GenericVariable : GenericField, IGenericVariableType {


		public string Scope { get; }


		public string Storage { get; }


		public IGenericVariableType Parent { get; }
	}
}
