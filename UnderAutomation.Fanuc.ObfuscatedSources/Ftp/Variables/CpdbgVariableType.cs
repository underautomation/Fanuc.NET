//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CPDBG_T
	/// </summary>
	public class CpdbgVariableType : GenericVariableType, IGenericVariableType {


		public CpdbgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $OUTPUT
		/// </summary>
		public bool Output { get; }

		/// <summary>
		/// Value of variable $CPIDEBUG
		/// </summary>
		public CpidebugVariableType Cpidebug { get; }

		/// <summary>
		/// Value of variable $CPPDEBUG
		/// </summary>
		public CpidebugVariableType Cppdebug { get; }

		/// <summary>
		/// Value of variable $MIDEBUG
		/// </summary>
		public CpidebugVariableType Midebug { get; }

		/// <summary>
		/// Value of variable $MPDEBUG
		/// </summary>
		public CpidebugVariableType Mpdebug { get; }

		/// <summary>
		/// Value of variable $MGDEBUG
		/// </summary>
		public CpidebugVariableType Mgdebug { get; }

		/// <summary>
		/// Value of variable $MFDEBUG
		/// </summary>
		public CpidebugVariableType Mfdebug { get; }

		/// <summary>
		/// Value of variable $SIMQSTOP
		/// </summary>
		public bool Simqstop { get; }

		/// <summary>
		/// Value of variable $KEEP
		/// </summary>
		public bool Keep { get; }

		/// <summary>
		/// Value of variable $PATH
		/// </summary>
		public string Path { get; }

		/// <summary>
		/// Value of variable $EXTRA1
		/// </summary>
		public int Extra1 { get; }

		/// <summary>
		/// Value of variable $EXTRA2
		/// </summary>
		public int Extra2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
