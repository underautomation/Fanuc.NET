//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.Rmi.TpInstructions {
	/// <summary>
	/// Instruction for a <code>CALL program</code> instruction.
	/// Pass to <see cref="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SendTpInstruction(UnderAutomation.Fanuc.Rmi.TpInstructions.RmiInstructionBase)"/>.
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
