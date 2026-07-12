//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Execution state of an RMI instruction in the pipeline.
	/// </summary>
	public enum RmiInstructionStatus {

		/// <summary>
		/// The instruction is held in the local client buffer and has not been sent to the controller yet.
		/// </summary>
		LocalQueued = 0,

		/// <summary>
		/// The instruction has been sent to the controller and is waiting in its 8-slot execution queue.
		/// </summary>
		ControllerQueued = 1,

		/// <summary>
		/// The controller is currently executing this instruction.
		/// </summary>
		Executing = 2,

		/// <summary>
		/// The instruction completed without error.
		/// </summary>
		Completed = 3,

		/// <summary>
		/// The instruction ended with a controller error or was cancelled. Check <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiResponseBase.ErrorId" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		Error = 4,
	}
}
