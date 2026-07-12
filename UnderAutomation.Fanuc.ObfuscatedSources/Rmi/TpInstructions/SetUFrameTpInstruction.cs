//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.TpInstructions {
	/// <summary>
	/// Instruction for a <code>UFRAME_NUM = n</code> assignment.
	/// Pass to <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SendTpInstruction(UnderAutomation.Fanuc.Rmi.TpInstructions.RmiInstructionBase)" data-throw-if-not-resolved="false"></xref>.
	/// </summary>
	public class SetUFrameTpInstruction : RmiInstructionBase {


		public SetUFrameTpInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// User frame number to activate.
		/// </summary>
		public byte FrameNumber { get; set; }
	}
}
