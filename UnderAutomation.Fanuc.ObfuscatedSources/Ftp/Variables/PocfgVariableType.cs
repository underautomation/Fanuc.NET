//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type POCFG_T
	/// </summary>
	public class PocfgVariableType : GenericVariableType, IGenericVariableType {


		public PocfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $PODEBUG
		/// </summary>
		public int Podebug { get; }

		/// <summary>
		/// Value of variable $OVERRUN_TOL
		/// </summary>
		public int[] OverrunTol { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
