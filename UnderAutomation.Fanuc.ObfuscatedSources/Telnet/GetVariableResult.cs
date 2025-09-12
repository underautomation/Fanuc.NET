//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {

	public class GetVariableResult : Result {

		/// <summary>
		/// During implementation, return true if it is assumed that the frame has finished being received.
		/// </summary>
		protected override bool FromResult(string data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// show variable termine toujours par une trame constitué uniquement de commande ANSI et d'espace. Cela arrête la réception des données. On décode donc à la fin les données accumulées
		/// </summary>
		protected override void EndReceive()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public GetVariableResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public string RawValue { get; }
	}
}
