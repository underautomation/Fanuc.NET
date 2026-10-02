//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.StreamMotion.Data {
	/// <summary>
	/// Arguments of the motion events
	/// </summary>
	public class MotionEventArgs : EventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Identifier of the motion, returned by Enqueue. 0 if there is no motion.
		/// </summary>
		public int MotionId { get; }
	}
}
