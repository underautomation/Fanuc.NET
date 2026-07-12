//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Data;

namespace Rmi.TpInstructions {
	/// <summary>
	/// Instruction for a spline motion with joint-angle representation.
	/// Pass to <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SendTpInstruction(UnderAutomation.Fanuc.Rmi.TpInstructions.RmiInstructionBase)" data-throw-if-not-resolved="false"></xref>.
	/// Requires MajorVersion &gt;= 7.
	/// </summary>
	public class SplineMotionJRepTpInstruction : JRepMotionTpInstructionBase {


		public SplineMotionJRepTpInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Speed unit (percent override or time).
		/// </summary>
		public RmiJointSpeedType SpeedType { get; set; }
	}
}
