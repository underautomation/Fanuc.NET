//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rmi.TpInstructions {
	/// <summary>
	/// Extends <xref href="UnderAutomation.Fanuc.Rmi.TpInstructions.FullMotionTpInstructionBase" data-throw-if-not-resolved="false"></xref> with a Cartesian target position.
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
