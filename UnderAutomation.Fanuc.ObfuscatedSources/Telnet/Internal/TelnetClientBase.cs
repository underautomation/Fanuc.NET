//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Telnet;
using System;

namespace Telnet.Internal {
	/// <summary>
	/// Base class for Telnet KCL client
	/// </summary>
	public abstract class TelnetClientBase {

		/// <summary>
		/// Connect robot IP address or host name
		/// </summary>
		public string IP { get; }


		public TpCoordinates TpCoordinates { get; }

		/// <summary>
		/// Is Telnet client connected
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Disconnect Telnet client from robot
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Occurs when raw data is received.
		/// </summary>
		public event EventHandler<RawDataReceivedEventArgs> RawDataReceived;

		/// <summary>
		/// Occurs when TP coordinates are received.
		/// </summary>
		public event EventHandler<TpCoordinatesReceivedEventArgs> TpCoordinatesReceived;

		/// <summary>
		/// Occurs when a message is received.
		/// </summary>
		public event EventHandler<MessageReceivedEventArgs> MessageReceived;

		/// <summary>
		/// Occurs when an error occurs in the KCL client.
		/// </summary>
		public event EventHandler<KclClientErrorEventArgs> ErrorOccured;

		/// <summary>
		/// Occurs when a command is sent.
		/// </summary>
		public event EventHandler<CommandSentEventArgs> CommandSent;

		/// <summary>
		/// Occurs when a KCL command is received.
		/// </summary>
		public event EventHandler<KclCommandReceived> CommandReceived;

		/// <summary>
		/// Aborts the specified running or paused task. If prog_ name is not specified, the default program Is used.
		/// Execution of the current program statement Is completed before the task aborts except for the current motion, DELAY, WAIT, Or READ statements, which are canceled.
		/// </summary>
		/// <param name="program">The name of any KAREL or TP program which is a task</param>
		/// <param name="force">Aborts all running or paused tasks</param>
		public DefaultResult Abort(string program, bool force)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Aborts all running or paused tasks.
		/// Execution of the current program statement Is completed before the task aborts except for the current motion, DELAY, WAIT, Or READ statements, which are canceled.
		/// </summary>
		/// <param name="force">Aborts all running or paused tasks</param>
		public DefaultResult AbortAll(bool force)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Clears all KAREL and teach pendant programs and variable data from memory.
		/// All cleared programs And variables (if they were saved with the SaveVars() command) can be reloaded into memory Using the Load() command.
		/// </summary>
		public DefaultResult ClearAll()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Clears the program data from memory for the specified or default program.
		/// </summary>
		/// <param name="program">The name of any KAREL or teach pendant program in memory</param>
		public DefaultResult ClearProgram(string program)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Clears the variable and type data associated with the specified or default program from memory.
		/// Variables And types that are referenced by a loaded program are Not cleared.
		/// </summary>
		/// <param name="program">The name of any KAREL or teach pendant program with variables</param>
		public DefaultResult ClearVars(string program)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Continues program execution of the specified task (or all paused tasks if program argument is null) that has been paused by a hold, pause, or test run operation.
		/// If the program Is aborted, the program execution Is started at the first executable line.
		/// When a task Is paused, the CYCLE START button on the operator panel has the same effect as the Continue() command.
		/// Continue is a motion command; therefore, the device from which it Is issued must have motion control.
		/// </summary>
		/// <param name="program">The name of any KAREL or teach pendant program which is a task. If null, it continues all paused tasks</param>
		public DefaultResult Continue(string program = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pauses the specified or default program that is being executed and holds motion at the current position (after a normal deceleration).
		/// Use the Continue() command Or the CYCLE START button On the Operator panel To resume program execution.
		/// </summary>
		/// <param name="program">The name of any KAREL or TP program. If null, it holds all executing programs</param>
		public DefaultResult Hold(string program = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pauses the specified running task. If program is not specified, the default program is used.
		/// Execution of the current motion segment and the current program statement is completed before the task is paused.
		/// Condition handlers remain active. If the condition handler action is NOPAUSE and the condition is satisfied, task execution resumes.
		/// If the statement is a WAIT FOR and the wait condition is satisfied while the task is paused, the statement following the WAIT FOR is executed immediately when the task is resumed.
		/// If the statement is a DELAY, timing will continue while the task is paused.
		/// If the delay time is finished while the task is paused, the statement following the DELAY is immediately executed when the task is resumed.
		/// If the statement is a READ, it will accept input even though the task is paused.
		/// The Continue() command resumes execution of a paused task.
		/// When a task is paused, the CYCLE START button on the operator panel has the same effect as the KCL&gt; CONTINUE command.
		/// </summary>
		/// <param name="program">the name of any KAREL or TP program which is a task. If null, it pauses all running tasks.</param>
		/// <param name="force">Pauses the task even if the NOPAUSE attribute is set</param>
		public DefaultResult Pause(string program = null, bool force = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Enables servo power after an error condition has shut off servo power, provided the cause of the error has been cleared.
		/// The command also clears the message line on the CRT/KB display. The error message remains displayed if the error condition still exists.
		/// The Reset() command has no effect on a program that is being executed. It has the same effect as the FAULT RESET button on the operator panel and the RESET function key on the teach pendant RESET screen.
		/// </summary>
		public DefaultResult Reset()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Executes the specified program. The program must be loaded in memory
		/// If no program is specified the default program is run. If uninitialized variables are encountered, program execution is paused.
		/// Execution begins at the first executable line.
		/// RUN is a motion command; therefore, the device from which it is issued must have motion control. If a RUN command is issued in a command file, it is executed as a NOWAIT command.
		/// Therefore, the statement following the RUN command will be executed immediately after the RUN command is issued without waiting for the program, specified by the RUN command, to end.        '''
		/// </summary>
		/// <param name="program">The name of any KAREL or TP program.</param>
		public DefaultResult Run(string program)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Assigns the specified value to a specified input or output port. SET PORT can be used  either physical Or simulated output ports, but only With simulated input ports.
		/// </summary>
		/// <param name="port">Port type</param>
		/// <param name="index">Port index</param>
		/// <param name="value">port value. For boolean ports, true is 1 and 0 is false</param>
		public DefaultResult SetPort(KCLPorts port, int index, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Assigns the specified value to the specified variable. You can assign constant values or variable values, but the value must be of the data type that has been declared for the variable.
		/// You can assign values to system variables with KCL write access, to program variables, or to standard and user-defined variables and fields. You can assign only one ARRAY element.
		/// Use brackets ([]) after the variable name to specify an element.
		/// Certain data types like positions and vectors might have more than one value specified.        '''
		/// </summary>
		/// <param name="name">A valid program variable</param>
		/// <param name="value">New value for variable or a program or system variable</param>
		/// <param name="program">The name of any KAREL or TP program.</param>
		public DefaultResult SetVariable(string name, string value, string program = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Assigns the specified value to the specified variable. You can assign constant values or variable values, but the value must be of the data type that has been declared for the variable.
		/// You can assign values to system variables with KCL write access, to program variables, or to standard and user-defined variables and fields. You can assign only one ARRAY element.
		/// Use brackets ([]) after the variable name to specify an element.
		/// Certain data types like positions and vectors might have more than one value specified.        '''
		/// </summary>
		/// <param name="name">A valid program variable</param>
		/// <param name="value">New value for variable or a program or system variable</param>
		/// <param name="program">The name of any KAREL or TP program.</param>
		public DefaultResult SetVariable(string name, int value, string program = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the position of the TCP relative to the current user frame of reference with an x, y, and z location in millimeters; w, p, and r orientation in degrees; and the current configuration string. Be sure the robot is calibrated.
		/// </summary>
		public DefaultResult GetCurrentPose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the status information of the specified or default program being executed.
		/// </summary>
		/// <param name="name">The name of any KAREL or TP program in memory</param>
		public DefaultResult GetProgramInformation(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the name, type, and value of the specified variable.
		/// You can display the values of system variables that allow KCL read access or the values of program variables.
		/// Use brackets ([]) after the variable name to specify a specific ARRAY element. If you do not specify a specific element the entire variable is displayed.        '''
		/// </summary>
		/// <param name="name">A valid program variable</param>
		/// <param name="program">The name of any KAREL or TP program</param>
		public GetVariableResult GetVariable(string name, string program = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Simulating I/O allows you to test a program that uses I/O. Simulating I/O does not actually send output signals or receive input signals.
		/// When simulating a port value, you can specify its initial simulated value or allow the initial value to be the same as the physical port value. If no value is specified, the current physical port value is used.        '''
		/// </summary>
		/// <param name="port">I/O port type</param>
		/// <param name="index">I/O port index</param>
		/// <param name="value">New value for the port</param>
		public DefaultResult Simulate(KCLPorts port, int index, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Skips execution of the current statement in the specified task.
		/// If programm is not specified, the default program is used.
		/// It has no effect when a task is running or when the system is in a READY state.
		/// Entire motion statements are skipped with this command. You cannot skip single motion segments.
		/// The Continue() command resumes execution of the paused task with the statement following the last skipped statement. END statements cannot be skipped.
		/// If you skip the last RETURN statement in a function routine, there is no way to return the value of the function to the calling program. Therefore, when executing the END statement of the routine, the task will abort.
		/// If you skip into a FOR loop, you have skipped the statement that initializes the loop counter. When the ENDFOR statement is executed the program will try to remove the loop counter from the stack. If the FOR loop was nested in another FOR loop, the loop counter for the previous FOR loop will be removed from the stack, causing potentially invalid results. If the FOR loop was not nested, a stack underflow error will occur, causing the task to abort.
		/// READ, MOVE, DELAY, WAIT FOR, and PULSE statements can be paused after they have begun execution. In these cases, when the task is resumed, execution of the paused statement must be finished before subsequent statements are executed. Subsequent skipped statements will not be executed.
		/// In particular, READ and WAIT FOR statements often require user intervention, such as entering data, before statement execution is completed.
		/// Step mode operation and step mode type have no effect on the Skip() command.
		/// </summary>
		/// <param name="program">The name of any KAREL or TP program which is a task</param>
		public object Skip(string program = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Discontinues simulation on all input or output port. When a port is unsimulated, the physical value replaces the simulated value.
		/// </summary>
		public object UnsimulateAll()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Discontinues simulation of the specified input or output port. When a port is unsimulated, the physical value replaces the simulated value.
		/// </summary>
		/// <param name="port">I/O port type</param>
		/// <param name="index">I/O port index to unsimulate</param>
		public object Unsimulate(KCLPorts port, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Return the task control data for the specified task. If prog_name is not specified, the default program is used
		/// </summary>
		/// <param name="prog_name">the name of any KAREL or TP program which is a task</param>
		public TaskInformationResult GetTaskInformation(string prog_name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
