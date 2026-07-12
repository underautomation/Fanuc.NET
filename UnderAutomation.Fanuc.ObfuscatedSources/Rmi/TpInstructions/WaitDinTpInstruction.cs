//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Data;

namespace Rmi.TpInstructions {
	/// <summary>
	/// Instruction for a <code>WAIT DI[n] = value</code> condition.
	/// Pass to <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SendTpInstruction(UnderAutomation.Fanuc.Rmi.TpInstructions.RmiInstructionBase)" data-throw-if-not-resolved="false"></xref>.
	/// </summary>
	public class WaitDinTpInstruction : RmiInstructionBase {


		public WaitDinTpInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Digital input port number to wait on.
		/// </summary>
		public short PortNumber { get; set; }

		/// <summary>
		/// Expected port state that releases the wait.
		/// </summary>
		public RmiOnOff Value { get; set; }
	}
}
