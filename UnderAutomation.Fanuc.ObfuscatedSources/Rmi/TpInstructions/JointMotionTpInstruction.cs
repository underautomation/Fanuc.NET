//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Data;

namespace Rmi.TpInstructions {
	/// <summary>
	/// Instruction for a joint motion (J in TP), Cartesian target representation.
	/// Pass to <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SendTpInstruction(UnderAutomation.Fanuc.Rmi.TpInstructions.RmiInstructionBase)" data-throw-if-not-resolved="false"></xref>.
	/// </summary>
	public class JointMotionTpInstruction : CartesianMotionTpInstructionBase {


		public JointMotionTpInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Speed unit (percent override or time).
		/// </summary>
		public RmiJointSpeedType SpeedType { get; set; }

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
