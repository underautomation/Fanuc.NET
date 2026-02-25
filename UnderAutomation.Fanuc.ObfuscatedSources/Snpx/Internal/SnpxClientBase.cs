//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Snpx.Internal {
	/// <summary>
	/// Base class for Snpx internal and public client
	/// </summary>
	public class SnpxClientBase {

		/// <summary>
		/// Checks the actual connection status via an active socket polling
		/// </summary>
		/// <returns>True if the connection is still open after checking via polling</returns>
		public bool PollAndGetUpdatedConnectedState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected void ConnectInternal(string ip, int port = 60008)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnect from the robot
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Clear all active alarms
		/// </summary>
		public void ClearAlarms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Set boolean variable without assignments.
		/// </summary>
		/// <param name="name">Variable name.</param>
		/// <param name="value">Boolean value to set.</param>
		public void SetVariable(string name, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Set integer variable without assignments.
		/// </summary>
		/// <param name="name">Variable name.</param>
		/// <param name="value">Integer value to set.</param>
		public void SetVariable(string name, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Set double variable without assignments.
		/// </summary>
		/// <param name="name">Variable name.</param>
		/// <param name="value">Double value to set.</param>
		public void SetVariable(string name, double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Set string variable without assignments.
		/// </summary>
		/// <param name="name">Variable name.</param>
		/// <param name="value">String value to set.</param>
		public void SetVariable(string name, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Clear all assignments
		/// </summary>
		public void ClearAssignments()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets all current assignments.
		/// </summary>
		/// <returns>An array of all active assignments.</returns>
		public Assignment[] GetAssignments()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// IP address of the connected robot.
		/// </summary>
		public string Ip { get; }

		/// <summary>
		/// Number registers R[] as floating point values
		/// </summary>
		public NumericRegisters NumericRegisters { get; }

		/// <summary>
		/// Number registers R[] as 32-bit integer values
		/// </summary>
		public NumericRegistersInt32 NumericRegistersInt32 { get; }

		/// <summary>
		/// Number registers R[] as 16-bit integer values
		/// </summary>
		public NumericRegistersInt16 NumericRegistersInt16 { get; }

		/// <summary>
		/// Position registers
		/// </summary>
		public PositionRegisters PositionRegisters { get; }

		/// <summary>
		/// String registers
		/// </summary>
		public StringRegisters StringRegisters { get; }

		/// <summary>
		/// Integer variables
		/// </summary>
		public IntegerSystemVariables IntegerSystemVariables { get; }

		/// <summary>
		/// Real variables
		/// </summary>
		public RealSystemVariables RealSystemVariables { get; }

		/// <summary>
		/// Position variables
		/// </summary>
		public PositionSystemVariables PositionSystemVariables { get; }

		/// <summary>
		/// String variables
		/// </summary>
		public StringSystemVariables StringSystemVariables { get; }

		/// <summary>
		/// List of all digital signal accessors (SDI, SDO, RDI, RDO, ...)
		/// </summary>
		public DigitalSignals[] DigitalSignals { get; }

		/// <summary>
		/// Safety Digital Inputs
		/// </summary>
		public DigitalSignals SDI { get; }

		/// <summary>
		/// Safety Digital Outputs
		/// </summary>
		public DigitalSignals SDO { get; }

		/// <summary>
		/// Remote Digital Inputs
		/// </summary>
		public DigitalSignals RDI { get; }

		/// <summary>
		/// Remote Digital Outputs
		/// </summary>
		public DigitalSignals RDO { get; }

		/// <summary>
		/// User Inputs
		/// </summary>
		public DigitalSignals UI { get; }

		/// <summary>
		/// User Outputs
		/// </summary>
		public DigitalSignals UO { get; }

		/// <summary>
		/// System Inputs
		/// </summary>
		public DigitalSignals SI { get; }

		/// <summary>
		/// System Outputs
		/// </summary>
		public DigitalSignals SO { get; }

		/// <summary>
		/// Weld Inputs
		/// </summary>
		public DigitalSignals WI { get; }

		/// <summary>
		/// Weld Outputs
		/// </summary>
		public DigitalSignals WO { get; }

		/// <summary>
		/// Weld System Inputs
		/// </summary>
		public DigitalSignals WSI { get; }

		/// <summary>
		/// Programmable Machine Controller Constants
		/// </summary>
		public DigitalSignals PMC_K { get; }

		/// <summary>
		/// Programmable Machine Controller Relays
		/// </summary>
		public DigitalSignals PMC_R { get; }

		/// <summary>
		/// List of all Numeric IOs accessors (GI, GO, AI, AO, ...)
		/// </summary>
		public NumericIO[] NumericIOs { get; }

		/// <summary>
		/// Group Inputs
		/// </summary>
		public NumericIO GI { get; }

		/// <summary>
		/// Group Outputs
		/// </summary>
		public NumericIO GO { get; }

		/// <summary>
		/// Analog Inputs
		/// </summary>
		public NumericIO AI { get; }

		/// <summary>
		/// Analog Outputs
		/// </summary>
		public NumericIO AO { get; }

		/// <summary>
		/// Programmable Machine Controller Data
		/// </summary>
		public NumericIO PMC_D { get; }

		/// <summary>
		/// Flags
		/// </summary>
		public Flags Flags { get; }

		/// <summary>
		/// Current position in world or user frame
		/// </summary>
		public CurrentPosition CurrentPosition { get; }

		/// <summary>
		/// Current active alarms
		/// </summary>
		public AlarmAccess ActiveAlarm { get; }

		/// <summary>
		/// Alarm history
		/// </summary>
		public AlarmAccess AlarmHistory { get; }

		/// <summary>
		/// Controller language (default is English)
		/// </summary>
		public Languages Language { get; set; }

		/// <summary>
		/// Indicates if the SNPX underlying TCP client is connected to the robot
		/// </summary>
		public bool Connected { get; }
	}
}
