//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {

	public abstract class Result {


		public string ErrorText;


		public bool Succeed { get; }


		public string KclCommand;


		protected abstract bool FromResult(string data);
	}
}
