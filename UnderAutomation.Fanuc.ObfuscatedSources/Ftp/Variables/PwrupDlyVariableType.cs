//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PWRUP_DLY_T
	/// </summary>
	public class PwrupDlyVariableType : GenericVariableType, IGenericVariableType {


		public PwrupDlyVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DELAY_TIME
		/// </summary>
		public int DelayTime { get; }

		/// <summary>
		/// Value of variable $SY_READY
		/// </summary>
		public bool SyReady { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
