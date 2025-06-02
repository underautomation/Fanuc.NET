//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Base class for Snpx internal and public client
	/// </summary>
	public class SnpxClientBase {


		protected void ConnectInternal(string ip, int port = 60008)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void ClearAlarms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void ClearAssignments()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public Assignment[] GetAssignments()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public string Ip { get; }

		/// <summary>
		/// Number registers
		/// </summary>
		public NumericRegisters NumericRegisters { get; }

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
		/// Current position in world or user frame
		/// </summary>
		public CurrentPosition CurrentPosition { get; }


		public bool Connected { get; }
	}
}
