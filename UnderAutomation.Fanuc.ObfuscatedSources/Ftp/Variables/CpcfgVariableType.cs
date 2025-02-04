//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CPCFG_T
	/// </summary>
	public class CpcfgVariableType : GenericVariableType, IGenericVariableType {


		public CpcfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $GROUP_MASK
		/// </summary>
		public int GroupMask { get; }

		/// <summary>
		/// Value of variable $CP_DEBUG
		/// </summary>
		public int CpDebug { get; }

		/// <summary>
		/// Value of variable $CP_ENABLE
		/// </summary>
		public bool CpEnable { get; }

		/// <summary>
		/// Value of variable $COMP_SWITCH
		/// </summary>
		public int CompSwitch { get; }

		/// <summary>
		/// Value of variable $EXTRA_INT
		/// </summary>
		public int[] ExtraInt { get; }

		/// <summary>
		/// Value of variable $EXTRA_FLT
		/// </summary>
		public double[] ExtraFlt { get; }

		/// <summary>
		/// Value of variable $TF_MODE
		/// </summary>
		public int TfMode { get; }

		/// <summary>
		/// Value of variable $MD3ITPTOL
		/// </summary>
		public int Md3itptol { get; }

		/// <summary>
		/// Value of variable $RESUME_OFST
		/// </summary>
		public ResumeOfstVariableType ResumeOfst { get; }

		/// <summary>
		/// Value of variable $CP_HSTART
		/// </summary>
		public double CpHstart { get; }

		/// <summary>
		/// Value of variable $T1_HSTART
		/// </summary>
		public double T1Hstart { get; }

		/// <summary>
		/// Value of variable $TEST
		/// </summary>
		public int[] Test { get; }

		/// <summary>
		/// Value of variable $COMP_SW2
		/// </summary>
		public int CompSw2 { get; }

		/// <summary>
		/// Value of variable $COMP_SW3
		/// </summary>
		public int CompSw3 { get; }

		/// <summary>
		/// Value of variable $COMP_SW4
		/// </summary>
		public int CompSw4 { get; }

		/// <summary>
		/// Value of variable $CP_DYNT1
		/// </summary>
		public int CpDynt1 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
