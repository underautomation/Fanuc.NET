//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MRR2_GRP_T
	/// </summary>
	public class Mrr2GrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ARM_PARAM
		/// </summary>
		public double[] ArmParam { get; }

		/// <summary>
		/// Value of variable $CALIB_MODE
		/// </summary>
		public int CalibMode { get; }

		/// <summary>
		/// Value of variable $GEAR_PARAM
		/// </summary>
		public double[] GearParam { get; }

		/// <summary>
		/// Value of variable $GEAR_PARAM2
		/// </summary>
		public double[] GearParam2 { get; }

		/// <summary>
		/// Value of variable $SPRING_PAM
		/// </summary>
		public double[] SpringPam { get; }

		/// <summary>
		/// Value of variable $RLIBSW01
		/// </summary>
		public int Rlibsw01 { get; }

		/// <summary>
		/// Value of variable $RLIBSW02
		/// </summary>
		public int Rlibsw02 { get; }

		/// <summary>
		/// Value of variable $ABC_FLAG
		/// </summary>
		public int AbcFlag { get; }

		/// <summary>
		/// Value of variable $MD_J2SECT
		/// </summary>
		public double[] MdJ2sect { get; }

		/// <summary>
		/// Value of variable $MD_J3SECT
		/// </summary>
		public double[] MdJ3sect { get; }

		/// <summary>
		/// Value of variable $MD_J1SPCONS
		/// </summary>
		public double[] MdJ1spcons { get; }

		/// <summary>
		/// Value of variable $MD_J2SPCONS
		/// </summary>
		public double[] MdJ2spcons { get; }

		/// <summary>
		/// Value of variable $MD_J3SPCONS
		/// </summary>
		public double[] MdJ3spcons { get; }

		/// <summary>
		/// Value of variable $MD_CUR_K
		/// </summary>
		public double[] MdCurK { get; }

		/// <summary>
		/// Value of variable $MD_CUR_J2
		/// </summary>
		public int MdCurJ2 { get; }

		/// <summary>
		/// Value of variable $MD_CUR_J3
		/// </summary>
		public int MdCurJ3 { get; }

		/// <summary>
		/// Value of variable $SV_OFF_TIM2
		/// </summary>
		public int[] SvOffTim2 { get; }

		/// <summary>
		/// Value of variable $CSKPLIM_ENB
		/// </summary>
		public bool CskplimEnb { get; }

		/// <summary>
		/// Value of variable $CSKPLIM_LIN
		/// </summary>
		public int CskplimLin { get; }

		/// <summary>
		/// Value of variable $CSKPLIM_JNT
		/// </summary>
		public int[] CskplimJnt { get; }

		/// <summary>
		/// Value of variable $QSKPLIM_ENB
		/// </summary>
		public bool QskplimEnb { get; }

		/// <summary>
		/// Value of variable $QSKPLIM_LIN
		/// </summary>
		public int QskplimLin { get; }

		/// <summary>
		/// Value of variable $QSKPLIM_JNT
		/// </summary>
		public int[] QskplimJnt { get; }

		/// <summary>
		/// Value of variable $EXT_AZIM
		/// </summary>
		public double[] ExtAzim { get; }

		/// <summary>
		/// Value of variable $EXT_ELEV
		/// </summary>
		public double[] ExtElev { get; }

		/// <summary>
		/// Value of variable $SERVOCMPTOL
		/// </summary>
		public int[] Servocmptol { get; }

		/// <summary>
		/// Value of variable $AXISINERTIL
		/// </summary>
		public int[] Axisinertil { get; }

		/// <summary>
		/// Value of variable $ARMLOAD
		/// </summary>
		public ArmloadVariableType[] Armload { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_X
		/// </summary>
		public ArmloadPVariableType[] ArmloadX { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_Y
		/// </summary>
		public ArmloadPVariableType[] ArmloadY { get; }

		/// <summary>
		/// Value of variable $ARMLOAD_Z
		/// </summary>
		public ArmloadPVariableType[] ArmloadZ { get; }

		/// <summary>
		/// Value of variable $SMGRSTTIM
		/// </summary>
		public int[] Smgrsttim { get; }

		/// <summary>
		/// Value of variable $JGFL_SCL_EX
		/// </summary>
		public double JgflSclEx { get; }

		/// <summary>
		/// Value of variable $EXTSPH_I
		/// </summary>
		public int[] ExtsphI { get; }

		/// <summary>
		/// Value of variable $EXTSPH_R
		/// </summary>
		public double[] ExtsphR { get; }

		/// <summary>
		/// Value of variable $CARTERRLIM
		/// </summary>
		public double[] Carterrlim { get; }

		/// <summary>
		/// Value of variable $SCARA_LEAD
		/// </summary>
		public double ScaraLead { get; }

		/// <summary>
		/// Value of variable $GRATIO_NUM
		/// </summary>
		public int[] GratioNum { get; }

		/// <summary>
		/// Value of variable $GRATIO_DIV
		/// </summary>
		public int[] GratioDiv { get; }

		/// <summary>
		/// Value of variable $J23UPLIM_DF
		/// </summary>
		public double J23uplimDf { get; }

		/// <summary>
		/// Value of variable $J23LWLIM_DF
		/// </summary>
		public double J23lwlimDf { get; }

		/// <summary>
		/// Value of variable $VELLIM_INRT
		/// </summary>
		public bool VellimInrt { get; }

		/// <summary>
		/// Value of variable $INRT_BL1
		/// </summary>
		public double[] InrtBl1 { get; }

		/// <summary>
		/// Value of variable $INRT_BL2
		/// </summary>
		public double[] InrtBl2 { get; }

		/// <summary>
		/// Value of variable $JVELLIM_BL1
		/// </summary>
		public double[] JvellimBl1 { get; }

		/// <summary>
		/// Value of variable $JVELLIM_BL2
		/// </summary>
		public double[] JvellimBl2 { get; }

		/// <summary>
		/// Value of variable $MECH_TYPE2
		/// </summary>
		public int MechType2 { get; }

		/// <summary>
		/// Value of variable $RTSA_RLIB
		/// </summary>
		public bool RtsaRlib { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
