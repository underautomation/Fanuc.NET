//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Internal {

	public class RmiConnectParametersBase {


		public const int DEFAULT_PORT = 16001;


		public const int DEFAULT_READ_TIMEOUT_MS = 3000;


		public const int DEFAULT_WRITE_TIMEOUT_MS = 3000;


		public RmiConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public int Port { get; set; }


		public int ReadTimeoutMs { get; set; }


		public int WriteTimeoutMs { get; set; }
	}
}
