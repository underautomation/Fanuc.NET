//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PRGNS_CFG_T
	/// </summary>
	public class PrgnsCfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ALGO_VER
		/// </summary>
		public double AlgoVer { get; }

		/// <summary>
		/// Value of variable $NYQ_FREQ
		/// </summary>
		public double NyqFreq { get; }

		/// <summary>
		/// Value of variable $WIN_TYPE
		/// </summary>
		public int WinType { get; }

		/// <summary>
		/// Value of variable $WIN_SIZE
		/// </summary>
		public int WinSize { get; }

		/// <summary>
		/// Value of variable $OVERLAP
		/// </summary>
		public int Overlap { get; }

		/// <summary>
		/// Value of variable $FREQ_LIM
		/// </summary>
		public double FreqLim { get; }

		/// <summary>
		/// Value of variable $MIN_NUM
		/// </summary>
		public int MinNum { get; }

		/// <summary>
		/// Value of variable $CREATED
		/// </summary>
		public int Created { get; }

		/// <summary>
		/// Value of variable $VERIFY
		/// </summary>
		public int Verify { get; }

		/// <summary>
		/// Value of variable $PROGNAME
		/// </summary>
		public string Progname { get; }

		/// <summary>
		/// Value of variable $CREATE_GP
		/// </summary>
		public int CreateGp { get; }

		/// <summary>
		/// Value of variable $STATUS_GP
		/// </summary>
		public int StatusGp { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $MAILTIME
		/// </summary>
		public int Mailtime { get; }

		/// <summary>
		/// Value of variable $MAILEVENT
		/// </summary>
		public int Mailevent { get; }

		/// <summary>
		/// Value of variable $LASTMAIL
		/// </summary>
		public int Lastmail { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
