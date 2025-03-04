//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {

	public abstract class Result {

		/// <summary>
		/// Lors de l'implémentation, retourner true si la trame est supposée terminé d'être reçue
		/// </summary>
		protected abstract bool FromResult(string data);


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indique que les réponses ont été terminée d'être reçues
		/// </summary>
		protected virtual void EndReceive()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected Result()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public string ErrorText { get; }


		public bool Succeed { get; }


		public string KclCommand { get; }
	}
}
