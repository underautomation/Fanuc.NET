//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AUTO_COL_REC
	/// </summary>
	public class AutoColRecVariableType : GenericVariableType, IGenericVariableType {


		public AutoColRecVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable REG_INDEX
		/// </summary>
		public int RegIndex { get; }

		/// <summary>
		/// Value of variable DO_INDEX
		/// </summary>
		public int DoIndex { get; }

		/// <summary>
		/// Value of variable ERR_DO_INDEX
		/// </summary>
		public int ErrDoIndex { get; }

		/// <summary>
		/// Value of variable RECOVERY_TSK
		/// </summary>
		public string RecoveryTsk { get; }

		/// <summary>
		/// Value of variable ERR_DELAY
		/// </summary>
		public int ErrDelay { get; }

		/// <summary>
		/// Value of variable RESET_DELAY
		/// </summary>
		public int ResetDelay { get; }

		/// <summary>
		/// Value of variable USE_REC_TSK
		/// </summary>
		public bool UseRecTsk { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
