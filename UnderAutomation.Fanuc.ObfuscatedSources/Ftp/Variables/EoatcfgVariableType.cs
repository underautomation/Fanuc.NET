//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type EOATCFG_T
	/// </summary>
	public class EoatcfgVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CURR_CNT
		/// </summary>
		public int CurrCnt { get; }

		/// <summary>
		/// Value of variable $RQST_CNT
		/// </summary>
		public int RqstCnt { get; }

		/// <summary>
		/// Value of variable $ENB_MSG
		/// </summary>
		public bool EnbMsg { get; }

		/// <summary>
		/// Value of variable $THROTTLE
		/// </summary>
		public int Throttle { get; }

		/// <summary>
		/// Value of variable $THRO_NUM
		/// </summary>
		public double ThroNum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
