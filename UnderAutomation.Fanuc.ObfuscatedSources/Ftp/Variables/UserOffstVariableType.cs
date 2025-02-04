//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type USER_OFFST_T
	/// </summary>
	public class UserOffstVariableType : GenericVariableType, IGenericVariableType {


		public UserOffstVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TOOL_OFST
		/// </summary>
		public UserToolVariableType[] ToolOfst { get; }

		/// <summary>
		/// Value of variable $UFRAME_OFST
		/// </summary>
		public UserUframVariableType[] UframeOfst { get; }

		/// <summary>
		/// Value of variable $GUN_TIP_OFS
		/// </summary>
		public double[] GunTipOfs { get; }

		/// <summary>
		/// Value of variable $GUN_CYC_OFS
		/// </summary>
		public double[] GunCycOfs { get; }

		/// <summary>
		/// Value of variable $ENB_SUBNUM
		/// </summary>
		public bool[] EnbSubnum { get; }

		/// <summary>
		/// Value of variable $PRE_EXE_ADV
		/// </summary>
		public bool PreExeAdv { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
