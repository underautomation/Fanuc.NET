//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Data;
using Common;

namespace Rmi.TpInstructions {
	/// <summary>
	/// Instruction for an incremental circular motion (C in TP), Cartesian delta representation.
	/// Pass to <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SendTpInstruction(UnderAutomation.Fanuc.Rmi.TpInstructions.RmiInstructionBase)" data-throw-if-not-resolved="false"></xref>.
	/// </summary>
	public class CircularRelativeTpInstruction : CartesianMotionTpInstructionBase {


		public CircularRelativeTpInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Speed unit (mm/s, inch/min, or time).
		/// </summary>
		public RmiLinearSpeedType SpeedType { get; set; }

		/// <summary>
		/// Via-point delta that defines the arc.
		/// </summary>
		public CartesianPositionWithUserFrame Via { get; set; }

		/// <summary>
		/// When <code>true</code>, enables wrist-joint mode for this motion.
		/// </summary>
		public bool WristJoint { get; set; }

		/// <summary>
		/// When <code>true</code>, enables coordinated motion (MROT).
		/// </summary>
		public bool Mrot { get; set; }

		/// <summary>
		/// When <code>true</code>, disables blending with the next instruction.
		/// </summary>
		public bool NoBlend { get; set; }
	}
}
