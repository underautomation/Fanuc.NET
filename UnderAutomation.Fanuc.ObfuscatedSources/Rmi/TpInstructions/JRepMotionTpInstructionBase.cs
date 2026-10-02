//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.Common;

namespace UnderAutomation.Fanuc.Rmi.TpInstructions {
	/// <summary>
	/// Extends <see cref="UnderAutomation.Fanuc.Rmi.TpInstructions.FullMotionTpInstructionBase"/> with a joint-angle target.
	/// Base class for all joint-representation motion instruction types.
	/// </summary>
	public abstract class JRepMotionTpInstructionBase : FullMotionTpInstructionBase {


		protected JRepMotionTpInstructionBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Target joint angles in degrees.
		/// </summary>
		public JointsPosition Joints { get; set; }
	}
}
