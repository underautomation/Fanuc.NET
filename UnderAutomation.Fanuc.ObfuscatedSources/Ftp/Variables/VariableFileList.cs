//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections;

namespace Ftp.Variables {

	public class VariableFileList : Collection<GenericVariableFile>, IList<GenericVariableFile>, ICollection<GenericVariableFile>, IList, ICollection, IReadOnlyList<GenericVariableFile>, IReadOnlyCollection<GenericVariableFile>, IEnumerable<GenericVariableFile>, IEnumerable, IGenericVariableType {


		protected override void InsertItem(int index, GenericVariableFile item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public VariableFileList()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Name of the structure
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Parent of this structure
		/// </summary>
		public IGenericVariableType Parent { get; set; }

		IGenericVariableType[] IGenericVariableType.Fields { get; }
	}
}
