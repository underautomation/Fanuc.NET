//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DBG_ERRLOG_T
	/// </summary>
	public class DbgErrlogVariableType : GenericVariableType, IGenericVariableType {


		public DbgErrlogVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $NUM_ERRORS
		/// </summary>
		public int NumErrors { get; }

		/// <summary>
		/// Value of variable $ERROR_IDS
		/// </summary>
		public int[] ErrorIds { get; }

		/// <summary>
		/// Value of variable $RUN_ONCE
		/// </summary>
		public byte RunOnce { get; }

		/// <summary>
		/// Value of variable $SYSLOGSTOP
		/// </summary>
		public byte Syslogstop { get; }

		/// <summary>
		/// Value of variable $SYSLOGERRID
		/// </summary>
		public short Syslogerrid { get; }

		/// <summary>
		/// Value of variable $PREV_MODE
		/// </summary>
		public int PrevMode { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
