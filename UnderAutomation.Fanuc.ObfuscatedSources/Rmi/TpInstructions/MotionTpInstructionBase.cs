//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Data;

namespace Rmi.TpInstructions {
	/// <summary>
	/// Base class for all RMI motion instructions.
	/// Carries the three parameters that are mandatory on every motion instruction.
	/// </summary>
	public abstract class MotionTpInstructionBase : RmiInstructionBase {


		protected MotionTpInstructionBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Speed value whose unit is defined by the concrete subclass.
		/// </summary>
		public short Speed { get; set; }

		/// <summary>
		/// Termination type (FINE, CNT, or CR).
		/// </summary>
		public RmiTerminationType TermType { get; set; }

		/// <summary>
		/// Termination value (0 for FINE, 1-100 for CNT, radius for CR).
		/// </summary>
		public byte TermValue { get; set; }
	}
}
