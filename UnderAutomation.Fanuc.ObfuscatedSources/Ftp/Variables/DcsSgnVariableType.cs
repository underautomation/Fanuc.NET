//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCS_SGN_T
	/// </summary>
	public class DcsSgnVariableType : GenericVariableType, IGenericVariableType {


		public DcsSgnVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CURR_SIGNAT
		/// </summary>
		public int CurrSignat { get; }

		/// <summary>
		/// Value of variable $CURR_DATE
		/// </summary>
		public string CurrDate { get; }

		/// <summary>
		/// Value of variable $PREV_SIGNAT
		/// </summary>
		public int PrevSignat { get; }

		/// <summary>
		/// Value of variable $PREV_DATE
		/// </summary>
		public string PrevDate { get; }

		/// <summary>
		/// Value of variable $ANNUNC_TYP
		/// </summary>
		public int AnnuncTyp { get; }

		/// <summary>
		/// Value of variable $ANNUNC_IDX
		/// </summary>
		public int AnnuncIdx { get; }

		/// <summary>
		/// Value of variable $CUR_TIME
		/// </summary>
		public int[] CurTime { get; }

		/// <summary>
		/// Value of variable $LATCH_TIME
		/// </summary>
		public int[] LatchTime { get; }

		/// <summary>
		/// Value of variable $CUR_CRC
		/// </summary>
		public int[] CurCrc { get; }

		/// <summary>
		/// Value of variable $LATCH_CRC
		/// </summary>
		public int[] LatchCrc { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
