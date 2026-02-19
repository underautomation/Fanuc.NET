//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;
using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Represents a parsed Fanuc variable file containing one or more variables
	/// </summary>
	public class GenericVariableFile : IGenericVariableType, IFanucContent {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets a variable by name (case-insensitive)
		/// </summary>
		public GenericVariable GetField(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Generates a .va file and writes it to the specified path
		/// </summary>
		public void GenerateVa(string pathToVa)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Generates a .va file and writes it to the specified stream
		/// </summary>
		public void GenerateVa(Stream stream)
		{
			// Source is hidden, a Source licence is needed to access internal code...
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


		public string GeneratedVa()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public GenericVariableFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Variables declared in this file
		/// </summary>
		public GenericVariable[] Variables { get; }

		/// <summary>
		/// File name
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Parent container
		/// </summary>
		public IGenericVariableType Parent { get; set; }

		IGenericVariableType[] IGenericVariableType.Fields => Variables;
	}
}
