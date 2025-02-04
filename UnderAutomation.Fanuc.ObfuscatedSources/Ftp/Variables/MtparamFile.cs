//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file mtparam.va
	/// </summary>
	public class MtparamFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable DEF_ITM
		/// </summary>
		public int[] DefItm { get; }

		/// <summary>
		/// Value of variable INTL_ACT
		/// </summary>
		public int[] IntlAct { get; }

		/// <summary>
		/// Value of variable INTL_RUN
		/// </summary>
		public int[] IntlRun { get; }

		/// <summary>
		/// Value of variable DUE_ONCE
		/// </summary>
		public int[] DueOnce { get; }

		/// <summary>
		/// Value of variable DEF_ITM2
		/// </summary>
		public int[] DefItm2 { get; }

		/// <summary>
		/// Value of variable INTL_ACT2
		/// </summary>
		public int[] IntlAct2 { get; }

		/// <summary>
		/// Value of variable INTL_RUN2
		/// </summary>
		public int[] IntlRun2 { get; }

		/// <summary>
		/// Value of variable DUE_ONCE2
		/// </summary>
		public int[] DueOnce2 { get; }

		/// <summary>
		/// Value of variable DEF_ITM_I
		/// </summary>
		public int[] DefItmI { get; }

		/// <summary>
		/// Value of variable INTL_ACT_I
		/// </summary>
		public int[] IntlActI { get; }

		/// <summary>
		/// Value of variable INTL_RUN_I
		/// </summary>
		public int[] IntlRunI { get; }

		/// <summary>
		/// Value of variable DUE_ONCE_I
		/// </summary>
		public int[] DueOnceI { get; }

		/// <summary>
		/// Value of variable INTELL_GRS
		/// </summary>
		public int IntellGrs { get; }

		/// <summary>
		/// Value of variable COULOMB_N
		/// </summary>
		public double[] CoulombN { get; }

		/// <summary>
		/// Value of variable COULOMB_N0
		/// </summary>
		public double[] CoulombN0 { get; }

		/// <summary>
		/// Value of variable VISCOSITY
		/// </summary>
		public double[] Viscosity { get; }

		/// <summary>
		/// Value of variable A_MOTOR
		/// </summary>
		public double[] AMotor { get; }

		/// <summary>
		/// Value of variable A_FRICTION
		/// </summary>
		public double[] AFriction { get; }

		/// <summary>
		/// Value of variable A_DISSIP
		/// </summary>
		public double[] ADissip { get; }

		/// <summary>
		/// Value of variable A_OTHER1
		/// </summary>
		public double[] AOther1 { get; }

		/// <summary>
		/// Value of variable A_OTHER2
		/// </summary>
		public double[] AOther2 { get; }

		/// <summary>
		/// Value of variable A_OTHER3
		/// </summary>
		public double[] AOther3 { get; }

		/// <summary>
		/// Value of variable A_OTHER4
		/// </summary>
		public double[] AOther4 { get; }

		/// <summary>
		/// Value of variable A_OTHER5
		/// </summary>
		public double[] AOther5 { get; }

		/// <summary>
		/// Value of variable A_OTHER6
		/// </summary>
		public double[] AOther6 { get; }

		/// <summary>
		/// Value of variable A_EXPONENT
		/// </summary>
		public double[] AExponent { get; }

		/// <summary>
		/// Value of variable DISTANCE
		/// </summary>
		public double[] Distance { get; }

		/// <summary>
		/// Value of variable MAX_V_MOTOR
		/// </summary>
		public double[] MaxVMotor { get; }

		/// <summary>
		/// Value of variable COEFF_OFF
		/// </summary>
		public double[] CoeffOff { get; }

		/// <summary>
		/// Value of variable SG_RATE
		/// </summary>
		public double[] SgRate { get; }

		/// <summary>
		/// Value of variable T_GRS_LIM
		/// </summary>
		public double[] TGrsLim { get; }

		/// <summary>
		/// Value of variable FORMULA_ID
		/// </summary>
		public int[] FormulaId { get; }

		/// <summary>
		/// Value of variable T_GRS_THRE
		/// </summary>
		public double[] TGrsThre { get; }

		/// <summary>
		/// Value of variable GRS_LIFE
		/// </summary>
		public double[] GrsLife { get; }

		/// <summary>
		/// Value of variable WEIGHT_1
		/// </summary>
		public double[] Weight1 { get; }

		/// <summary>
		/// Value of variable WEIGHT_2
		/// </summary>
		public double[] Weight2 { get; }

		/// <summary>
		/// Value of variable WEIGHT_3
		/// </summary>
		public double[] Weight3 { get; }

		/// <summary>
		/// Value of variable WEIGHT_4
		/// </summary>
		public double[] Weight4 { get; }

		/// <summary>
		/// Value of variable WEIGHT_5
		/// </summary>
		public double[] Weight5 { get; }

		/// <summary>
		/// Value of variable THETA_1
		/// </summary>
		public double[] Theta1 { get; }

		/// <summary>
		/// Value of variable THETA_2
		/// </summary>
		public double[] Theta2 { get; }

		/// <summary>
		/// Value of variable THETA_3
		/// </summary>
		public double[] Theta3 { get; }

		/// <summary>
		/// Value of variable THETA_4
		/// </summary>
		public double[] Theta4 { get; }

		/// <summary>
		/// Value of variable THETA_5
		/// </summary>
		public double[] Theta5 { get; }

		/// <summary>
		/// Value of variable LIMIT
		/// </summary>
		public double[] Limit { get; }
	}
}
