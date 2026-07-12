//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Rmi.Data;
using Common;
using Rmi.TpInstructions;

namespace Rmi.Internal {
	/// <summary>
	/// High-level Remote Motion Interface (RMI) client for FANUC controllers.
	/// Manages the connection lifecycle, all administrative commands, and the full set of
	/// motion instruction packets over the RMI TCP protocol.
	/// </summary>
	public abstract class RmiClientBase : IDisposable {

		/// <summary>
		/// Creates a new instance of the RMI client.
		/// </summary>
		public RmiClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to the controller: perform the bootstrap handshake on the given port,
		/// obtain the working port, then switch to it for all subsequent commands.
		/// </summary>
		protected void ConnectInternal(string host, int port, int readTimeoutMs = 2000)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnect from the controller by sending the disconnect command on the working port.
		/// Safe to call even when already disconnected.
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initialize RMI and start the motion program. Must be called before sending any motion instructions.
		/// It also Resets <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.LastSequenceId" data-throw-if-not-resolved="false"></xref> and empty the instruction buffer <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.Instructions" data-throw-if-not-resolved="false"></xref>
		/// </summary>
		/// <param name="groupMask">Bitmask of motion groups to activate (bit N enables group N+1).
		/// Required for multi-group controllers. <code>null</code> activates the default single group.
		/// Requires MajorVersion &gt;= 2.</param>
		/// <param name="rtsa">Real-time singularity avoidance: <code>true</code> to enable, <code>false</code> to disable.
		/// <code>null</code> uses the controller default. Requires MajorVersion &gt;= 6 and the R792 option.</param>
		/// <param name="pltzMode">Palletizing motion mode. <code>null</code> uses the controller default. Requires MajorVersion &gt;= 7.</param>
		public void Initialize(byte? groupMask = null, bool? rtsa = null, RmiPltzMode? pltzMode = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Abort the running motion program. Note that a Reset() will be called automatically if the controller is in the HOLD state.
		/// </summary>
		public void Abort()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Pause the running motion program.
		/// </summary>
		public void Pause()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Resume a paused motion program.
		/// </summary>
		public void Continue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reset controller errors and exit the HOLD state.
		/// </summary>
		public void Reset()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read the most recent controller error text. Up to 5 consecutive errors can be requested.
		/// </summary>
		/// <param name="count">Number of recent errors to retrieve (1–5). Defaults to 1.</param>
		public RmiControllerErrorTextResponse ReadError(byte? count = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the current UFRAME and UTOOL numbers.
		/// </summary>
		/// <param name="group">Optional motion group number.</param>
		public RmiUFrameUToolNumbersResponse GetUFrameUTool(byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the current UFRAME and UTOOL numbers.
		/// </summary>
		/// <param name="uframe">UFRAME number.</param>
		/// <param name="utool">UTOOL number.</param>
		/// <param name="group">Optional motion group number.</param>
		public void SetUFrameUTool(byte uframe, byte utool, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the current controller and RMI motion status.
		/// </summary>
		public RmiControllerStatusResponse GetStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Calls internally <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.GetStatus" data-throw-if-not-resolved="false"></xref> and set <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.LastSequenceId" data-throw-if-not-resolved="false"></xref> only if $RMI_CFG.$Chk_seqID = FALSE. It also set <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.CheckSequenceId" data-throw-if-not-resolved="false"></xref> to $RMI_CFG.$Chk_seqID.
		/// </summary>
		public RmiControllerStatusResponse AutoSetNextSequenceId()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get extended controller status including drive power state and speed clamp.
		/// </summary>
		public RmiExtendedControllerStatusResponse GetExtendedStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read the UFRAME at the given index.
		/// </summary>
		/// <param name="number">UFRAME number.</param>
		/// <param name="group">Optional motion group number.</param>
		public RmiIndexedFrameResponse ReadUFrame(byte number, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write the UFRAME at the given index.
		/// </summary>
		/// <param name="number">UFRAME number.</param>
		/// <param name="position">New Cartesian frame values.</param>
		/// <param name="group">Optional motion group number.</param>
		public void WriteUFrame(byte number, XYZWPRPosition position, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read the UTOOL at the given index.
		/// </summary>
		/// <param name="number">UTOOL number.</param>
		/// <param name="group">Optional motion group number.</param>
		public RmiIndexedFrameResponse ReadUTool(byte number, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write the UTOOL at the given index.
		/// </summary>
		/// <param name="number">UTOOL number.</param>
		/// <param name="position">New Cartesian frame values.</param>
		/// <param name="group">Optional motion group number.</param>
		public void WriteUTool(byte number, XYZWPRPosition position, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read a digital input port value.
		/// </summary>
		public RmiDigitalInputValueResponse ReadDIN(short portNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write a digital output port value.
		/// </summary>
		public void WriteDOUT(short portNumber, RmiOnOff value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read a generic IO port (DI, DO, AI, AO, GO, RO, FLAG, RI, UI, UO).
		/// </summary>
		/// <param name="portType">Type of IO port.</param>
		/// <param name="portNumber">Port number.</param>
		public RmiIoPortValueResponse ReadIOPort(RmiIoPortType portType, int portNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write a generic IO port (AO, GO, DO, RO, FLAG).
		/// </summary>
		/// <param name="portType">Type of IO port.</param>
		/// <param name="portNumber">Port number.</param>
		/// <param name="value">Value to write.</param>
		public void WriteIOPort(RmiIoPortType portType, int portNumber, double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read current Cartesian TCP position.
		/// </summary>
		/// <param name="group">Optional motion group number.</param>
		public RmiCartesianPositionResponse ReadCartesianPosition(byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read current joint angles.
		/// </summary>
		/// <param name="group">Optional motion group number.</param>
		public RmiJointAnglesSampleResponse ReadJointAngles(byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the program speed override (1–100 %).
		/// </summary>
		public void SetOverride(byte value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read a position register
		/// </summary>
		/// <param name="number">Register number</param>
		/// <param name="group">Optional motion group number.</param>
		public RmiPositionRegisterDataResponse ReadPositionRegister(short number, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write a Cartesian position register
		/// </summary>
		/// <param name="number">Register number</param>
		/// <param name="target">Position including configuration and active frame/tool numbers.</param>
		/// <param name="group">Optional motion group number.</param>
		public void WritePositionRegisterCartesian(short number, CartesianPositionWithUserFrame target, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read a numeric register
		/// </summary>
		/// <param name="number">Register number</param>
		public RmiNumericRegisterValueResponse ReadNumericRegister(int number)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write an integer value to a numeric register
		/// </summary>
		/// <param name="number">Register number</param>
		/// <param name="value">Integer value to write.</param>
		public void WriteNumericRegisterAsInteger(int number, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write a float value to a numeric register
		/// </summary>
		/// <param name="number">Register number</param>
		/// <param name="value">Float value to write.</param>
		public void WriteNumericRegisterAsDouble(int number, double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read a system variable by name (name must include the leading <code>$</code> character).
		/// </summary>
		public RmiVariableValueResponse ReadVariable(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write an integer value to a system variable (name must include the leading <code>$</code>).
		/// </summary>
		public void WriteVariableAsInteger(string name, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write a float value to a system variable (name must include the leading <code>$</code>).
		/// </summary>
		public void WriteVariableAsDouble(string name, double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read the current TCP speed in mm/s.
		/// </summary>
		public RmiTcpSpeedResponse ReadTcpSpeed()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Immediately apply a payload schedule to the active group (command, not an instruction).
		/// </summary>
		/// <param name="scheduleNumber">Payload schedule number.</param>
		/// <param name="group">Optional motion group number.</param>
		public void SetPayloadSchedule(byte scheduleNumber, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Define payload mass, center of gravity, and optionally inertia for a payload schedule.
		/// </summary>
		/// <param name="p">Payload parameters (user units: meters for offsets, kg for mass, kg·m² for inertia).</param>
		public void SetPayloadValue(RmiSetPayloadParameters p)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Define payload mass, center of gravity, and optionally inertia for a payload schedule.
		/// </summary>
		/// <param name="scheduleNumber">Schedule number.</param>
		/// <param name="massKg">Payload mass in kg.</param>
		/// <param name="cgXm">Center-of-gravity X offset in meters.</param>
		/// <param name="cgYm">Center-of-gravity Y offset in meters.</param>
		/// <param name="cgZm">Center-of-gravity Z offset in meters.</param>
		/// <param name="inertiaXkgm2">Inertia around X in kg·m² (optional).</param>
		/// <param name="inertiaYkgm2">Inertia around Y in kg·m² (optional).</param>
		/// <param name="inertiaZkgm2">Inertia around Z in kg·m² (optional).</param>
		/// <param name="group">Optional motion group number.</param>
		public void SetPayloadValue(byte scheduleNumber, float massKg, float cgXm, float cgYm, float cgZm, float? inertiaXkgm2 = null, float? inertiaYkgm2 = null, float? inertiaZkgm2 = null, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Define payload compensation parameters for a payload schedule.
		/// </summary>
		/// <param name="p">Payload compensation parameters (user units: meters for offsets, kg for mass, kg·m² for inertia).</param>
		public void SetPayloadCompensation(RmiSetPayloadCompensationParameters p)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Define payload compensation parameters for a payload schedule.
		/// </summary>
		/// <param name="scheduleNumber">Schedule number.</param>
		/// <param name="massKg">Payload mass in kg.</param>
		/// <param name="cgXm">Center-of-gravity X offset in meters.</param>
		/// <param name="cgYm">Center-of-gravity Y offset in meters.</param>
		/// <param name="cgZm">Center-of-gravity Z offset in meters.</param>
		/// <param name="inertiaXkgm2">Inertia around X in kg.m².</param>
		/// <param name="inertiaYkgm2">Inertia around Y in kg.m².</param>
		/// <param name="inertiaZkgm2">Inertia around Z in kg.m².</param>
		/// <param name="group">Optional motion group number.</param>
		public void SetPayloadCompensation(byte scheduleNumber, float massKg, float cgXm, float cgYm, float cgZm, float inertiaXkgm2, float inertiaYkgm2, float inertiaZkgm2, byte? group = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Removes all instructions with a terminal status (<xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.Completed" data-throw-if-not-resolved="false"></xref>
		/// or <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.Error" data-throw-if-not-resolved="false"></xref>) from the tracked instruction list.
		/// Instructions that are still pending or in progress are not affected.
		/// </summary>
		public void ClearCompletedInstructions()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Cancels and removes all instructions that are still in the local client buffer
		/// (<xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.LocalQueued" data-throw-if-not-resolved="false"></xref>). These instructions have not been sent
		/// to the controller yet. Each cancelled instruction is marked with an error so that any
		/// thread blocked on <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionResponse.WaitForCompletion(System.Int32)" data-throw-if-not-resolved="false"></xref> is unblocked.
		/// Instructions already sent to the controller are not affected.
		/// </summary>
		public void ClearLocalQueuedInstructions()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Serializes the instruction to the RMI wire format and queues it on the controller.
		/// Returns an <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionResponse" data-throw-if-not-resolved="false"></xref> that tracks execution.
		/// </summary>
		/// <param name="instruction">Instruction to send. Must not be <code>null</code>.</param>
		public RmiInstructionResponse SendTpInstruction(RmiInstructionBase instruction)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Disconnect from the controller and release resources.
		/// </summary>
		public void Dispose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Indicates that the client is currently connected to the controller working port.
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Controller protocol major version reported during the connection handshake.
		/// </summary>
		public short MajorVersion { get; }

		/// <summary>
		/// Controller protocol minor version reported during the connection handshake.
		/// </summary>
		public short MinorVersion { get; }

		/// <summary>
		/// Working port returned by the controller; all commands use this port after connection.
		/// </summary>
		public int WorkingPort { get; }

		/// <summary>
		/// Sequence ID used for the last instruction sent to the controller. Reset to 0 by <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.Initialize(System.Nullable%7bSystem.Byte%7d%2cSystem.Nullable%7bSystem.Boolean%7d%2cSystem.Nullable%7bUnderAutomation.Fanuc.Rmi.Data.RmiPltzMode%7d)" data-throw-if-not-resolved="false"></xref>.. Modified by <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.AutoSetNextSequenceId" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public int LastSequenceId { get; }

		/// <summary>
		/// Indicates whether the controller checks for consecutive sequence IDs in motion instructions ($RMI_CFG.$Chk_seqID). Modified by <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.AutoSetNextSequenceId" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public bool CheckSequenceId { get; set; }

		/// <summary>
		/// Indicates that the controller has entered the HOLD state and will not accept new TP instructions
		/// until <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.Reset" data-throw-if-not-resolved="false"></xref> is called.
		/// 
		/// <p>
		/// The HOLD state is entered in two situations:
		/// </p>
		/// <ul><li>
		/// An invalid sequence ID was detected (error RMIT-029, error code 2556957). RMI checks that sequence IDs are
		/// consecutive. If a gap is found, RMI rejects the instruction and enters HOLD. The controller continues
		/// executing the TP instructions already queued but blocks all new ones. Use <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.AutoSetNextSequenceId" data-throw-if-not-resolved="false"></xref>
		/// to recover the correct sequence ID, then call <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.Reset" data-throw-if-not-resolved="false"></xref> before resuming.
		/// </li><li>
		/// An invalid motion instruction was received (error RMIT-024, error code 2556952), for example a motion
		/// option that is not loaded on the controller. RMI returns an error for that instruction, puts the
		/// controller in HOLD, and continues executing any instructions already in the TP program queue. Call
		/// <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.Reset" data-throw-if-not-resolved="false"></xref> once the problem is corrected, then resume sending instructions.
		/// </li></ul>
		/// <p>
		/// All instructions sent while in the HOLD state are ignored by the controller and returned with an error code.
		/// This flag is cleared automatically when <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.Reset" data-throw-if-not-resolved="false"></xref> succeeds.
		/// </p>
		/// </summary>
		public bool IsInHoldState { get; }

		/// <summary>
		/// RMI connection parameters used during Connect().
		/// </summary>
		public int ReadTimeoutMs { get; }

		/// <summary>
		/// All instructions submitted since the last <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.Initialize(System.Nullable%7bSystem.Byte%7d%2cSystem.Nullable%7bSystem.Boolean%7d%2cSystem.Nullable%7bUnderAutomation.Fanuc.Rmi.Data.RmiPltzMode%7d)" data-throw-if-not-resolved="false"></xref> or explicit clear,
		/// in submission order. Includes instructions in all states: <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.LocalQueued" data-throw-if-not-resolved="false"></xref>,
		/// <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.ControllerQueued" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.Executing" data-throw-if-not-resolved="false"></xref>,
		/// <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.Completed" data-throw-if-not-resolved="false"></xref> and <xref href="UnderAutomation.Fanuc.Rmi.Data.RmiInstructionStatus.Error" data-throw-if-not-resolved="false"></xref>.
		/// Returns a snapshot array; the array is not updated after it is returned.
		/// </summary>
		public RmiInstructionResponse[] Instructions { get; }

		/// <summary>
		/// Fired when the controller closes the session (e.g. communication idle timeout).
		/// The client is automatically disconnected after this event fires.
		/// </summary>
		public event Action ConnectionTerminated;

		/// <summary>
		/// Fired when the controller reports a system fault on a given sequence.
		/// The argument is the SequenceID of the faulted instruction (0 when unknown).
		/// </summary>
		public event Action<int> SystemFaultReceived;

		/// <summary>
		/// Fired when the controller sends a Cartesian position via the RMI Position Record menu.
		/// </summary>
		public event Action<RmiRecordedCartesianPosition> RecordedCartesianPositionReceived;

		/// <summary>
		/// Fired when the controller sends a joint position via the RMI Position Record menu.
		/// </summary>
		public event Action<RmiRecordedJointPosition> RecordedJointPositionReceived;

		/// <summary>
		/// Fired when an unknown packet is received from the controller.
		/// </summary>
		public event Action<RmiResponseBase> UnknownPacketReceived;
	}
}
