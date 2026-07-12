//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.TpInstructions {
	/// <summary>
	/// Instruction for a <code>CALL program</code> instruction.
	/// Pass to <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SendTpInstruction(UnderAutomation.Fanuc.Rmi.TpInstructions.RmiInstructionBase)" data-throw-if-not-resolved="false"></xref>.
	/// Requires MajorVersion &gt;= 4.
	/// </summary>
	public class CallProgramTpInstruction : RmiInstructionBase {


		public CallProgramTpInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Name of the TP program to call.
		/// </summary>
		public string ProgramName { get; set; }
	}
}
