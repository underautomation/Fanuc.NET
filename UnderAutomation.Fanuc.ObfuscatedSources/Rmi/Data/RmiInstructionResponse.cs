//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.TpInstructions;
using System;

namespace Rmi.Data {
	/// <summary>
	/// Response returned immediately when a motion instruction is queued. The <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionResponse.Status" data-throw-if-not-resolved="false"></xref> property
	/// and <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiResponseBase.ErrorId" data-throw-if-not-resolved="false"></xref> are updated in the background as the controller processes the instruction.
	/// Use <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionResponse.WaitForCompletion(System.Int32)" data-throw-if-not-resolved="false"></xref> to block until the instruction reaches a terminal state.
	/// </summary>
	public class RmiInstructionResponse : RmiResponseBase {

		/// <summary>
		/// Blocks the calling thread until the instruction reaches a terminal state
		/// (<xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.Completed" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.Error" data-throw-if-not-resolved="false"></xref>),
		/// or until <code class="paramref">timeoutMs</code> milliseconds have elapsed.
		/// Pass -1 (or omit) to wait indefinitely.
		/// </summary>
		/// <param name="timeoutMs">Maximum time to wait in milliseconds, or -1 to wait indefinitely.</param>
		/// <returns>True when the instruction reached a terminal state; false on timeout.</returns>
		public bool WaitForCompletion(int timeoutMs = -1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RmiInstructionResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sequence identifier assigned to this instruction. 0 until the instruction has been dispatched to the controller.
		/// </summary>
		public int SequenceId { get; }

		/// <summary>
		/// Current execution state of the instruction.
		/// </summary>
		public RmiInstructionStatus Status { get; }

		/// <summary>
		/// Sent instruction
		/// </summary>
		public RmiInstructionBase Instruction { get; }

		/// <summary>
		/// Fired each time <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionResponse.Status" data-throw-if-not-resolved="false"></xref> changes. The argument is the new status value.
		/// This event may be raised from a background thread.
		/// </summary>
		public event Action<RmiInstructionStatus> StatusChanged;
	}
}
