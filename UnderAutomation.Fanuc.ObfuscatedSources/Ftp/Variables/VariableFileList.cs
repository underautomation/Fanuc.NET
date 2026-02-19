//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections;

namespace Ftp.Variables {
	/// <summary>
	/// Collection of variable files that aggregates all variables from the controller
	/// </summary>
	public class VariableFileList : Collection<GenericVariableFile>, IList<GenericVariableFile>, ICollection<GenericVariableFile>, IEnumerable<GenericVariableFile>, IList, ICollection, IEnumerable, IGenericVariableType {


		protected override void InsertItem(int index, GenericVariableFile item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public VariableFileList()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Name of this variable file list
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Parent container
		/// </summary>
		public IGenericVariableType Parent { get; set; }

		IGenericVariableType[] IGenericVariableType.Fields { get; }
	}
}
