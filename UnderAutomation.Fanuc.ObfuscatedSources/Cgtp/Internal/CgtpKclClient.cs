//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common.Kcl;

namespace Cgtp.Internal {
	/// <summary>
	/// KCL client implementation using the CGTP Web Server.
	/// Provides KCL commands over HTTP endpoints.
	/// </summary>
	public class CgtpKclClient : KclClientBase {

		/// <summary>
		/// Sends a custom KCL command in Unsafe mode. Success or failure cannot be determined from the result.
		/// </summary>
		/// <param name="command">Custom command to send</param>
		public CustomCommandResult SendCustomCommandUnsafe(string command)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sends a KCL command via the /kcl/ HTTP endpoint and parses the HTML response.
		/// </summary>
		protected override T SendKcl<T>(string command) where T : Result, new()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sends a KCL command in Unsafe mode via the CGTP RPC endpoint.
		/// In this mode, the command is always reported as successful because the endpoint does not return any status or error information.
		/// </summary>
		protected override T SendKclUnsafe<T>(string command) where T : Result, new()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indicates whether the KCL client is currently connected.
		/// </summary>
		public bool Enabled { get; }
	}
}
