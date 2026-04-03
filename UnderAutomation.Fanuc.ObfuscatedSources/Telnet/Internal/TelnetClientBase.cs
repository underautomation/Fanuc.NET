//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common.Kcl;
using Common;
using Telnet;
using System;

namespace Telnet.Internal {
	/// <summary>
	/// Base class for Telnet KCL client
	/// </summary>
	public abstract class TelnetClientBase : KclClientBase {

		/// <summary>
		/// Checks the actual connection status via an active socket polling
		/// </summary>
		/// <returns>True if the connection is still open after checking via polling</returns>
		public bool PollAndGetUpdatedConnectedState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Disconnect Telnet client from robot
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sends a KCL command and returns the parsed result.
		/// </summary>
		protected override T SendKcl<T>(string command) where T : Result, new()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sends a KCL command in Unsafe mode. When used through the CGTP KCL client, success or failure cannot be determined from the result.
		/// </summary>
		protected override T SendKclUnsafe<T>(string command) where T : Result, new()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected TelnetClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect robot IP address or host name
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Controller language (default is English)
		/// </summary>
		public Languages Language { get; set; }

		/// <summary>
		/// Gets the current Teach Pendant coordinate system.
		/// </summary>
		public TpCoordinates TpCoordinates { get; }

		/// <summary>
		/// Is Telnet client connected
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Occurs when raw data is received.
		/// </summary>
		public event EventHandler<RawDataReceivedEventArgs> RawDataReceived;

		/// <summary>
		/// Occurs when data is received and its content can successfully be parsed as a string message.
		/// </summary>
		public event EventHandler<RawDataReceivedEventArgs> StringDataReceived;

		/// <summary>
		/// Occurs when TP coordinates are received.
		/// </summary>
		public event EventHandler<TpCoordinatesReceivedEventArgs> TpCoordinatesReceived;

		/// <summary>
		/// Occurs when a message is received.
		/// </summary>
		public event EventHandler<MessageReceivedEventArgs> MessageReceived;

		/// <summary>
		/// Occurs when an error occurs in the KCL client.
		/// </summary>
		public event EventHandler<KclClientErrorEventArgs> ErrorOccured;

		/// <summary>
		/// Occurs when a command is sent.
		/// </summary>
		public event EventHandler<CommandSentEventArgs> CommandSent;

		/// <summary>
		/// Occurs when a KCL command is received.
		/// </summary>
		public event EventHandler<KclCommandReceived> CommandReceived;
	}
}
