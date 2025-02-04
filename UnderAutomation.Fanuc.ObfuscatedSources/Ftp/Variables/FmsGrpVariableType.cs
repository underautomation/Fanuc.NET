//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FMS_GRP_T
	/// </summary>
	public class FmsGrpVariableType : GenericVariableType, IGenericVariableType {


		public FmsGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $REM_LIFE
		/// </summary>
		public double[] RemLife { get; }

		/// <summary>
		/// Value of variable $NT_LIFE
		/// </summary>
		public double[] NtLife { get; }

		/// <summary>
		/// Value of variable $T_LIFE
		/// </summary>
		public double[] TLife { get; }

		/// <summary>
		/// Value of variable $CLDET_ANG
		/// </summary>
		public double[] CldetAng { get; }

		/// <summary>
		/// Value of variable $NT_LIFE_0
		/// </summary>
		public double[] NtLife0 { get; }

		/// <summary>
		/// Value of variable $T_LIFE_TEMP
		/// </summary>
		public double[] TLifeTemp { get; }

		/// <summary>
		/// Value of variable $REM_LIFE_0
		/// </summary>
		public double[] RemLife0 { get; }

		/// <summary>
		/// Value of variable $GRP_CL_TIME
		/// </summary>
		public int GrpClTime { get; }

		/// <summary>
		/// Value of variable $PCCOMER_CNT
		/// </summary>
		public int[] PccomerCnt { get; }

		/// <summary>
		/// Value of variable $FB_COMP_CNT
		/// </summary>
		public int[] FbCompCnt { get; }

		/// <summary>
		/// Value of variable $CMAL_DETECT
		/// </summary>
		public bool[] CmalDetect { get; }

		/// <summary>
		/// Value of variable $CLDET_PT
		/// </summary>
		public short CldetPt { get; }

		/// <summary>
		/// Value of variable $PS_DTY_STR_
		/// </summary>
		public short PsDtyStr { get; }

		/// <summary>
		/// Value of variable $DTY_STR_T
		/// </summary>
		public int DtyStrT { get; }

		/// <summary>
		/// Value of variable $DTY_END_T
		/// </summary>
		public int DtyEndT { get; }

		/// <summary>
		/// Value of variable $CLDET_CNT
		/// </summary>
		public int[] CldetCnt { get; }

		/// <summary>
		/// Value of variable $CLHIST
		/// </summary>
		public ClhistVariableType[] Clhist { get; }

		/// <summary>
		/// Value of variable $T_LIFE_MS
		/// </summary>
		public int[] TLifeMs { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
