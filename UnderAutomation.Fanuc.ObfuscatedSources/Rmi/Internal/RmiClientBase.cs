//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Data;
using System;

namespace Rmi.Internal {
	/// <summary>
	/// High level Remote Motion Interface (RMI) client for FANUC controllers.
	/// This client speaks the ASCII JSON-like protocol over TCP as described in the RMI Operator's Manual.
	/// Supports connection bootstrap on port 16001 and all documented admin commands and TP instruction packets.
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
		/// Connect to the controller on the bootstrap port (16001), request the working port, then switch to it.
		/// </summary>
		protected void ConnectInternal(string host, int port, int readTimeoutMs, int writeTimeoutMs)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnect from the controller by sending FRC_Disconnect on the working port.
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Send the initialize command to create and start RMI_MOVE. Must be called before sending instruction packets.
		/// </summary>
		public int Initialize()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Abort RMI_MOVE.
		/// </summary>
		public void Abort()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Pause RMI_MOVE.
		/// </summary>
		public void Pause()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Resume RMI_MOVE.
		/// </summary>
		public void Continue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reset controller errors and exit HOLD state.
		/// </summary>
		public void Reset()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read the most recent error text.
		/// </summary>
		public ControllerErrorText ReadError()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set current UFRAME and UTOOL numbers.
		/// </summary>
		public void SetUFrameUTool(byte uframe, byte utool)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get controller status and RMI state.
		/// </summary>
		public ControllerStatus GetStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read a UFRAME.
		/// </summary>
		public IndexedFrame ReadUFrame(byte number)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write a UFRAME.
		/// </summary>
		public void WriteUFrame(byte number, Frame frame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read a UTOOL.
		/// </summary>
		public IndexedFrame ReadUTool(byte number)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write a UTOOL.
		/// </summary>
		public void WriteUTool(byte number, Frame frame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read a digital input port value.
		/// </summary>
		public DigitalInputValue ReadDIN(short portNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write a digital output port value.
		/// </summary>
		public void WriteDOUT(short portNumber, OnOff value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read current Cartesian position.
		/// </summary>
		public CartesianPosition ReadCartesianPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read current joint angles.
		/// </summary>
		public JointAnglesSample ReadJointAngles()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set program override (1-100).
		/// </summary>
		public void SetOverride(byte value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get current UFRAME/UTOOL numbers.
		/// </summary>
		public UFrameUToolNumbers GetUFrameUTool()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read a position register.
		/// </summary>
		public PositionRegisterData ReadPositionRegister(short number)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write a position register.
		/// </summary>
		public void WritePositionRegister(short number, MotionConfiguration cfg, Frame frame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read current TCP speed.
		/// </summary>
		public TcpSpeed ReadTcpSpeed()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add WAIT DI[x] = ON/OFF.
		/// </summary>
		public RmiSequenceResponse WaitDin(int sequenceId, short portNumber, OnOff value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add UFRAME_NUM = n.
		/// </summary>
		public RmiSequenceResponse SetUFrameInstruction(int sequenceId, byte frameNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add UTOOL_NUM = n.
		/// </summary>
		public RmiSequenceResponse SetUToolInstruction(int sequenceId, byte toolNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add WAIT t (sec).
		/// </summary>
		public RmiSequenceResponse WaitTime(int sequenceId, double seconds)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add PAYLOAD[n].
		/// </summary>
		public RmiSequenceResponse SetPayload(int sequenceId, byte scheduleNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a linear motion.
		/// </summary>
		public RmiSequenceResponse LinearMotion(int sequenceId, MotionConfiguration config, Frame position, SpeedType speedType, short speed, TerminationType termType, byte termValue, byte? acc, short? offsetPr, short? visionPr, bool wristJoint, bool mrot, string lcbType, short? lcbValue, PortType? portType, short? portNumber, OnOff? portValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add an incremental linear motion.
		/// </summary>
		public RmiSequenceResponse LinearRelative(int sequenceId, MotionConfiguration config, Frame delta, SpeedType speedType, short speed, TerminationType termType, byte termValue, byte? acc, short? offsetPr, short? visionPr, bool wristJoint, bool mrot, string lcbType, short? lcbValue, PortType? portType, short? portNumber, OnOff? portValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a joint motion.
		/// </summary>
		public RmiSequenceResponse JointMotion(int sequenceId, MotionConfiguration config, Frame position, SpeedType speedType, short speed, TerminationType termType, byte termValue, byte? acc, short? offsetPr, short? visionPr, bool mrot, string lcbType, short? lcbValue, PortType? portType, short? portNumber, OnOff? portValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add an incremental joint motion.
		/// </summary>
		public RmiSequenceResponse JointRelative(int sequenceId, MotionConfiguration config, Frame delta, SpeedType speedType, short speed, TerminationType termType, byte termValue, byte? acc, short? offsetPr, short? visionPr, bool mrot, string lcbType, short? lcbValue, PortType? portType, short? portNumber, OnOff? portValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a circular motion (via and destination).
		/// </summary>
		public RmiSequenceResponse CircularMotion(int sequenceId, MotionConfiguration config, Frame position, MotionConfiguration viaConfig, Frame viaPosition, SpeedType speedType, short speed, TerminationType termType, byte termValue, byte? acc, short? offsetPr, short? visionPr, bool wristJoint, bool mrot, string lcbType, short? lcbValue, PortType? portType, short? portNumber, OnOff? portValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add an incremental circular motion.
		/// </summary>
		public RmiSequenceResponse CircularRelative(int sequenceId, MotionConfiguration config, Frame delta, MotionConfiguration viaConfig, Frame viaDelta, SpeedType speedType, short speed, TerminationType termType, byte termValue, byte? acc, short? offsetPr, short? visionPr, bool wristJoint, bool mrot, string lcbType, short? lcbValue, PortType? portType, short? portNumber, OnOff? portValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a joint-motion with joint representation.
		/// </summary>
		public RmiSequenceResponse JointMotionJRep(int sequenceId, JointAngles joints, SpeedType speedType, short speed, TerminationType termType, byte termValue, byte? acc, short? offsetPr, short? visionPr, bool mrot, string lcbType, short? lcbValue, PortType? portType, short? portNumber, OnOff? portValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add an incremental joint-motion with joint representation.
		/// </summary>
		public RmiSequenceResponse JointRelativeJRep(int sequenceId, JointAngles deltaJoints, SpeedType speedType, short speed, TerminationType termType, byte termValue, byte? acc, short? offsetPr, short? visionPr, bool mrot, string lcbType, short? lcbValue, PortType? portType, short? portNumber, OnOff? portValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Dispose and disconnect
		/// </summary>
		public void Dispose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the read timeout for TCP operations (milliseconds).
		/// </summary>
		public int ReadTimeoutMs { get; }

		/// <summary>
		/// Gets or sets the write timeout for TCP operations (milliseconds).
		/// </summary>
		public int WriteTimeoutMs { get; }

		/// <summary>
		/// Indicates that the client is currently connected to the controller working port.
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Controller protocol major version reported during FRC_Connect.
		/// </summary>
		public short MajorVersion { get; }

		/// <summary>
		/// Controller protocol minor version reported during FRC_Connect.
		/// </summary>
		public short MinorVersion { get; }

		/// <summary>
		/// Working port returned by the controller; all commands use this port after connection.
		/// </summary>
		public int WorkingPort { get; }
	}
}
