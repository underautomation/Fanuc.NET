//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SYSTEM_TIMER
	/// </summary>
	public class SystemTimerVariableType : GenericVariableType, IGenericVariableType {


		public SystemTimerVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable PWR_TOT
		/// </summary>
		public int PwrTot { get; }

		/// <summary>
		/// Value of variable PWR_LAP
		/// </summary>
		public int PwrLap { get; }

		/// <summary>
		/// Value of variable SRV_TOT
		/// </summary>
		public int SrvTot { get; }

		/// <summary>
		/// Value of variable SRV_LAP
		/// </summary>
		public int SrvLap { get; }

		/// <summary>
		/// Value of variable RUN_FLG
		/// </summary>
		public int RunFlg { get; }

		/// <summary>
		/// Value of variable RUN_TOT
		/// </summary>
		public int RunTot { get; }

		/// <summary>
		/// Value of variable RUN_LAP
		/// </summary>
		public int RunLap { get; }

		/// <summary>
		/// Value of variable WIT_FLG
		/// </summary>
		public int WitFlg { get; }

		/// <summary>
		/// Value of variable WIT_TOT
		/// </summary>
		public int WitTot { get; }

		/// <summary>
		/// Value of variable WIT_LAP
		/// </summary>
		public int WitLap { get; }

		/// <summary>
		/// Value of variable SHM_TOT
		/// </summary>
		public int ShmTot { get; }

		/// <summary>
		/// Value of variable SHM_LAP
		/// </summary>
		public int ShmLap { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
