//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CO_PARAMGP_T
	/// </summary>
	public class CoParamgpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $OPT_TIME
		/// </summary>
		public int OptTime { get; }

		/// <summary>
		/// Value of variable $OPT_ACC
		/// </summary>
		public bool OptAcc { get; }

		/// <summary>
		/// Value of variable $JACC_RRATIO
		/// </summary>
		public double JaccRratio { get; }

		/// <summary>
		/// Value of variable $CACC_RRATIO
		/// </summary>
		public double CaccRratio { get; }

		/// <summary>
		/// Value of variable $JTIME_RATIO
		/// </summary>
		public double JtimeRatio { get; }

		/// <summary>
		/// Value of variable $CTIME_RATIO
		/// </summary>
		public double CtimeRatio { get; }

		/// <summary>
		/// Value of variable $JVARDMAX
		/// </summary>
		public int Jvardmax { get; }

		/// <summary>
		/// Value of variable $CVARDMAX
		/// </summary>
		public int Cvardmax { get; }

		/// <summary>
		/// Value of variable $WARNMESSENB
		/// </summary>
		public bool Warnmessenb { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $TBA_MGN
		/// </summary>
		public double TbaMgn { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
