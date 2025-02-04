//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VIS_LOGREG_T
	/// </summary>
	public class VisLogregVariableType : GenericVariableType, IGenericVariableType {


		public VisLogregVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $LOG_SREG
		/// </summary>
		public int LogSreg { get; }

		/// <summary>
		/// Value of variable $LOG_NREG
		/// </summary>
		public int LogNreg { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
