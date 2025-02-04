//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MFRQ_GRP_T
	/// </summary>
	public class MfrqGrpVariableType : GenericVariableType, IGenericVariableType {


		public MfrqGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ACT_AXIS
		/// </summary>
		public int ActAxis { get; }

		/// <summary>
		/// Value of variable $UPD_DATE
		/// </summary>
		public string[] UpdDate { get; }

		/// <summary>
		/// Value of variable $AVE_PSD
		/// </summary>
		public double[] AvePsd { get; }

		/// <summary>
		/// Value of variable $FREQ_CNT
		/// </summary>
		public int[] FreqCnt { get; }

		/// <summary>
		/// Value of variable $LAST_DATE
		/// </summary>
		public int[] LastDate { get; }

		/// <summary>
		/// Value of variable $RUN_TASK
		/// </summary>
		public string[] RunTask { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
