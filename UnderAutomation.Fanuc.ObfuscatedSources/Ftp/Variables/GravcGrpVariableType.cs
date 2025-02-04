//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type GRAVC_GRP_T
	/// </summary>
	public class GravcGrpVariableType : GenericVariableType, IGenericVariableType {


		public GravcGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MODE_SW
		/// </summary>
		public int ModeSw { get; }

		/// <summary>
		/// Value of variable $SPCONS
		/// </summary>
		public double[] Spcons { get; }

		/// <summary>
		/// Value of variable $DEBUG1
		/// </summary>
		public int Debug1 { get; }

		/// <summary>
		/// Value of variable $DEBUG2
		/// </summary>
		public double[] Debug2 { get; }

		/// <summary>
		/// Value of variable $GRV_STATUS
		/// </summary>
		public int GrvStatus { get; }

		/// <summary>
		/// Value of variable $BKUP_NO116
		/// </summary>
		public short[] BkupNo116 { get; }

		/// <summary>
		/// Value of variable $POFF_NO116
		/// </summary>
		public short[] PoffNo116 { get; }

		/// <summary>
		/// Value of variable $GRVCMP_SW
		/// </summary>
		public int GrvcmpSw { get; }

		/// <summary>
		/// Value of variable $GRVMST_LOOP
		/// </summary>
		public int GrvmstLoop { get; }

		/// <summary>
		/// Value of variable $MST_SMT_LEN
		/// </summary>
		public int MstSmtLen { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
