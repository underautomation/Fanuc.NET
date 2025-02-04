//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;
using Ftp.Internal;

namespace Ftp.Variables {

	public class GenericVariableFile : IGenericVariableType, IFanucContent {


		public GenericVariable[] Variables { get; }

		/// <summary>
		/// Name of the structure
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Parent of this structure
		/// </summary>
		public IGenericVariableType Parent { get; set; }


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public GenericVariable GetField(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public void GenerateVa(string pathToVa)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void GenerateVa(Stream stream)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public string GeneratedVa()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		IGenericVariableType[] IGenericVariableType.Fields => Variables;
	}
}
