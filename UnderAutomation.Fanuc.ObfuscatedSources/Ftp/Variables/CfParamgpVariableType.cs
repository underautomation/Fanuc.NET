//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CF_PARAMGP_T
	/// </summary>
	public class CfParamgpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $WARNMESSENB
		/// </summary>
		public bool Warnmessenb { get; }

		/// <summary>
		/// Value of variable $CHKJNTLIM
		/// </summary>
		public bool Chkjntlim { get; }

		/// <summary>
		/// Value of variable $CNSTNT_CORN
		/// </summary>
		public bool CnstntCorn { get; }

		/// <summary>
		/// Value of variable $TIMEFLTRENB
		/// </summary>
		public bool Timefltrenb { get; }

		/// <summary>
		/// Value of variable $TRATIO_TB
		/// </summary>
		public double[] TratioTb { get; }

		/// <summary>
		/// Value of variable $ACCTIME_TB1
		/// </summary>
		public double[] AcctimeTb1 { get; }

		/// <summary>
		/// Value of variable $ACCTIME_TB2
		/// </summary>
		public double[] AcctimeTb2 { get; }

		/// <summary>
		/// Value of variable $ORIENT_TYPE
		/// </summary>
		public int OrientType { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $RTSPD_SF
		/// </summary>
		public double RtspdSf { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
