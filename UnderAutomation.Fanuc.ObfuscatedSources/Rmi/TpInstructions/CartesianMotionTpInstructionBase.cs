//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.Common;

namespace UnderAutomation.Fanuc.Rmi.TpInstructions {
	/// <summary>
	/// Extends <see cref="UnderAutomation.Fanuc.Rmi.TpInstructions.FullMotionTpInstructionBase"/> with a Cartesian target position.
	/// Base class for all Cartesian motion instruction types.
	/// </summary>
	public abstract class CartesianMotionTpInstructionBase : FullMotionTpInstructionBase {


		protected CartesianMotionTpInstructionBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Target Cartesian position, configuration, and active frame/tool numbers.
		/// </summary>
		public CartesianPositionWithUserFrame Target { get; set; }
	}
}
