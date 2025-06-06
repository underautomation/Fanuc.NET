//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Text.RegularExpressions;

namespace Telnet {

	public abstract class SetValueResult : Result {


		protected static Regex ValueRegex;


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected SetValueResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Former value before the command
		/// </summary>
		public string FormerValue { get; protected set; }


		public string NewValue { get; protected set; }
	}
}
