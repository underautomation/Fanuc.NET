//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBJ_ACC_T
	/// </summary>
	public class TbjAccVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ACC_LEN1
		/// </summary>
		public int AccLen1 { get; }

		/// <summary>
		/// Value of variable $ACC_LEN2
		/// </summary>
		public int AccLen2 { get; }

		/// <summary>
		/// Value of variable $DEC_LEN1
		/// </summary>
		public int DecLen1 { get; }

		/// <summary>
		/// Value of variable $DEC_LEN2
		/// </summary>
		public int DecLen2 { get; }

		/// <summary>
		/// Value of variable $ACCEL_RATIO
		/// </summary>
		public double AccelRatio { get; }

		/// <summary>
		/// Value of variable $DECEL_RATIO
		/// </summary>
		public double DecelRatio { get; }

		/// <summary>
		/// Value of variable $SLOW_AXIS
		/// </summary>
		public int SlowAxis { get; }

		/// <summary>
		/// Value of variable $F1ACC_I
		/// </summary>
		public int F1accI { get; }

		/// <summary>
		/// Value of variable $F2ACC_I
		/// </summary>
		public int F2accI { get; }

		/// <summary>
		/// Value of variable $F1DEC_I
		/// </summary>
		public int F1decI { get; }

		/// <summary>
		/// Value of variable $F2DEC_I
		/// </summary>
		public int F2decI { get; }

		/// <summary>
		/// Value of variable $MOVE_TIME
		/// </summary>
		public double MoveTime { get; }

		/// <summary>
		/// Value of variable $S_INERTIA
		/// </summary>
		public double[] SInertia { get; }

		/// <summary>
		/// Value of variable $D_INERTIA
		/// </summary>
		public double[] DInertia { get; }

		/// <summary>
		/// Value of variable $TORQUE_ACC
		/// </summary>
		public double[] TorqueAcc { get; }

		/// <summary>
		/// Value of variable $TORQUE_DEC
		/// </summary>
		public double[] TorqueDec { get; }

		/// <summary>
		/// Value of variable $DISPLACEMNT
		/// </summary>
		public double[] Displacemnt { get; }

		/// <summary>
		/// Value of variable $ACCTIME
		/// </summary>
		public double[] Acctime { get; }

		/// <summary>
		/// Value of variable $DECTIME
		/// </summary>
		public double[] Dectime { get; }

		/// <summary>
		/// Value of variable $VEL_MAX_ACC
		/// </summary>
		public double[] VelMaxAcc { get; }

		/// <summary>
		/// Value of variable $VEL_MAX_DEC
		/// </summary>
		public double[] VelMaxDec { get; }

		/// <summary>
		/// Value of variable $VEL_TCV_ACC
		/// </summary>
		public double[] VelTcvAcc { get; }

		/// <summary>
		/// Value of variable $VEL_TCV_DEC
		/// </summary>
		public double[] VelTcvDec { get; }

		/// <summary>
		/// Value of variable $TRQ_TCV_ACC
		/// </summary>
		public double[] TrqTcvAcc { get; }

		/// <summary>
		/// Value of variable $TRQ_TCV_DEC
		/// </summary>
		public double[] TrqTcvDec { get; }

		/// <summary>
		/// Value of variable $TRQSTAT_ACC
		/// </summary>
		public int[] TrqstatAcc { get; }

		/// <summary>
		/// Value of variable $TRQSTAT_DEC
		/// </summary>
		public int[] TrqstatDec { get; }

		/// <summary>
		/// Value of variable $J_STAT_ACC
		/// </summary>
		public int[] JStatAcc { get; }

		/// <summary>
		/// Value of variable $J_STAT_DEC
		/// </summary>
		public int[] JStatDec { get; }

		/// <summary>
		/// Value of variable $M_STAT_ACC
		/// </summary>
		public int MStatAcc { get; }

		/// <summary>
		/// Value of variable $M_STAT_DEC
		/// </summary>
		public int MStatDec { get; }

		/// <summary>
		/// Value of variable $J_MODE
		/// </summary>
		public int JMode { get; }

		/// <summary>
		/// Value of variable $DT_ACC
		/// </summary>
		public double[] DtAcc { get; }

		/// <summary>
		/// Value of variable $DT_DEC
		/// </summary>
		public double[] DtDec { get; }

		/// <summary>
		/// Value of variable $ACC2_STP
		/// </summary>
		public int[] Acc2Stp { get; }

		/// <summary>
		/// Value of variable $DEC2_STP
		/// </summary>
		public int[] Dec2Stp { get; }

		/// <summary>
		/// Value of variable $AT_MODE
		/// </summary>
		public int AtMode { get; }

		/// <summary>
		/// Value of variable $AT_AXS
		/// </summary>
		public int[] AtAxs { get; }

		/// <summary>
		/// Value of variable $AC_ACC
		/// </summary>
		public double[] AcAcc { get; }

		/// <summary>
		/// Value of variable $AC_DEC
		/// </summary>
		public double[] AcDec { get; }

		/// <summary>
		/// Value of variable $JK_ACC
		/// </summary>
		public double[] JkAcc { get; }

		/// <summary>
		/// Value of variable $JK_DEC
		/// </summary>
		public double[] JkDec { get; }

		/// <summary>
		/// Value of variable $VK1
		/// </summary>
		public double Vk1 { get; }

		/// <summary>
		/// Value of variable $VK2
		/// </summary>
		public double Vk2 { get; }

		/// <summary>
		/// Value of variable $VK3
		/// </summary>
		public double Vk3 { get; }

		/// <summary>
		/// Value of variable $JJ0
		/// </summary>
		public double Jj0 { get; }

		/// <summary>
		/// Value of variable $JJ1
		/// </summary>
		public double Jj1 { get; }

		/// <summary>
		/// Value of variable $JJ2
		/// </summary>
		public double Jj2 { get; }

		/// <summary>
		/// Value of variable $JJ3
		/// </summary>
		public double Jj3 { get; }

		/// <summary>
		/// Value of variable $AA1
		/// </summary>
		public double Aa1 { get; }

		/// <summary>
		/// Value of variable $AA2
		/// </summary>
		public double Aa2 { get; }

		/// <summary>
		/// Value of variable $AA3
		/// </summary>
		public double Aa3 { get; }

		/// <summary>
		/// Value of variable $AA4
		/// </summary>
		public double Aa4 { get; }

		/// <summary>
		/// Value of variable $AA5
		/// </summary>
		public double Aa5 { get; }

		/// <summary>
		/// Value of variable $TRQ_N1_ACC
		/// </summary>
		public double[] TrqN1Acc { get; }

		/// <summary>
		/// Value of variable $TRQ_N1_DEC
		/// </summary>
		public double[] TrqN1Dec { get; }

		/// <summary>
		/// Value of variable $VEL_MAX
		/// </summary>
		public double[] VelMax { get; }

		/// <summary>
		/// Value of variable $LINE_NUM
		/// </summary>
		public int LineNum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
