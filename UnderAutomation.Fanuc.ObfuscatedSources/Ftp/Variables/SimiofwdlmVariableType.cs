//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SIMIOFWDLM_T
	/// </summary>
	public class SimiofwdlmVariableType : GenericVariableType, IGenericVariableType {


		public SimiofwdlmVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $UNLOCK_TIME
		/// </summary>
		public double UnlockTime { get; }

		/// <summary>
		/// Value of variable $UNLOCKEDTIM
		/// </summary>
		public int Unlockedtim { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
