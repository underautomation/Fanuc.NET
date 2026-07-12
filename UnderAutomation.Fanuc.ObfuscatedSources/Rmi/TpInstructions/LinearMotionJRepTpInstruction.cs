//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Data;
using System;

namespace Rmi.TpInstructions {
	/// <summary>
	/// Instruction for a linear motion (L in TP), joint-angle representation.
	/// Pass to <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SendTpInstruction(UnderAutomation.Fanuc.Rmi.TpInstructions.RmiInstructionBase)" data-throw-if-not-resolved="false"></xref>.
	/// </summary>
	public class LinearMotionJRepTpInstruction : JRepMotionTpInstructionBase {


		public LinearMotionJRepTpInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Speed unit (mm/s, inch/min, or time).
		/// </summary>
		public RmiLinearSpeedType SpeedType { get; set; }

		/// <summary>
		/// When <code>true</code>, enables wrist-joint mode for this motion.
		/// </summary>
		public bool WristJoint { get; set; }

		/// <summary>
		/// When <code>true</code>, enables coordinated motion (MROT).
		/// </summary>
		public bool Mrot { get; set; }

		/// <summary>
		/// When <code>true</code>, disables blending with the next instruction. Requires MajorVersion &gt;= 5.
		/// </summary>
		public bool NoBlend { get; set; }

		/// <summary>
		/// Acceleration limit value. <code>null</code> uses the controller default. Requires MajorVersion &gt;= 5 and the R921 option.
		/// </summary>
		public int? Alim { get; set; }

		/// <summary>
		/// Acceleration limit register number. <code>null</code> disables register-based limit. Requires MajorVersion &gt;= 5 and the R921 option.
		/// </summary>
		public short? AlimReg { get; set; }
	}
}
