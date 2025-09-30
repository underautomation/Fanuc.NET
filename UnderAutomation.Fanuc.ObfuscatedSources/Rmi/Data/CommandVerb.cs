//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// RMI command verbs that do not add TP instructions.
	/// </summary>
	public enum CommandVerb {

		/// <summary>
		/// Initialize and start the RMI_MOVE program.
		/// </summary>
		FRC_Initialize = 0,

		/// <summary>
		/// Abort the running RMI_MOVE program.
		/// </summary>
		FRC_Abort = 1,

		/// <summary>
		/// Pause the running RMI_MOVE program.
		/// </summary>
		FRC_Pause = 2,

		/// <summary>
		/// Resume a paused RMI_MOVE program.
		/// </summary>
		FRC_Continue = 3,

		/// <summary>
		/// Reset controller errors and recover from HOLD / faults.
		/// </summary>
		FRC_Reset = 4,

		/// <summary>
		/// Read most recent controller error text.
		/// </summary>
		FRC_ReadError = 5,

		/// <summary>
		/// Set current UFRAME and UTOOL numbers.
		/// </summary>
		FRC_SetUFrameUTool = 6,

		/// <summary>
		/// Get controller status and RMI state.
		/// </summary>
		FRC_GetStatus = 7,

		/// <summary>
		/// Read a user frame definition.
		/// </summary>
		FRC_ReadUFrameData = 8,

		/// <summary>
		/// Write a user frame definition.
		/// </summary>
		FRC_WriteUFrameData = 9,

		/// <summary>
		/// Read a user tool definition.
		/// </summary>
		FRC_ReadUToolData = 10,

		/// <summary>
		/// Write a user tool definition.
		/// </summary>
		FRC_WriteUToolData = 11,

		/// <summary>
		/// Read a digital input port.
		/// </summary>
		FRC_ReadDIN = 12,

		/// <summary>
		/// Write a digital output port.
		/// </summary>
		FRC_WriteDOUT = 13,

		/// <summary>
		/// Read current Cartesian position.
		/// </summary>
		FRC_ReadCartesianPosition = 14,

		/// <summary>
		/// Read current joint angles.
		/// </summary>
		FRC_ReadJointAngles = 15,

		/// <summary>
		/// Set program override (1-100%).
		/// </summary>
		FRC_SetOverRide = 16,

		/// <summary>
		/// Get current UFRAME/UTOOL numbers.
		/// </summary>
		FRC_GetUFrameUTool = 17,

		/// <summary>
		/// Read a position register.
		/// </summary>
		FRC_ReadPositionRegister = 18,

		/// <summary>
		/// Write a position register.
		/// </summary>
		FRC_WritePositionRegister = 19,

		/// <summary>
		/// Read current TCP speed.
		/// </summary>
		FRC_ReadTCPSpeed = 20,
	}
}
