//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type USR_EV_WRK_T
	/// </summary>
	public class UsrEvWrkVariableType : GenericVariableType, IGenericVariableType {


		public UsrEvWrkVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $WORK_NAME
		/// </summary>
		public string WorkName { get; }

		/// <summary>
		/// Value of variable $START_COPY
		/// </summary>
		public bool StartCopy { get; }

		/// <summary>
		/// Value of variable $NUM_IN_FIL
		/// </summary>
		public int NumInFil { get; }

		/// <summary>
		/// Value of variable $NUM_OUT_FIL
		/// </summary>
		public int NumOutFil { get; }

		/// <summary>
		/// Value of variable $WAIT_CTR
		/// </summary>
		public int WaitCtr { get; }

		/// <summary>
		/// Value of variable $WORK1
		/// </summary>
		public int Work1 { get; }

		/// <summary>
		/// Value of variable $WORK2
		/// </summary>
		public int Work2 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
