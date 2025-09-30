//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Position register data paired with its register number.
	/// </summary>
	public class PositionRegisterData : RmiResponseBase {


		public PositionRegisterData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Register number.
		/// </summary>
		public short RegisterNumber { get; set; }

		/// <summary>
		/// Configuration saved in the position register.
		/// </summary>
		public MotionConfiguration Configuration { get; set; }

		/// <summary>
		/// Position saved in the position register.
		/// </summary>
		public Frame Position { get; set; }
	}
}
