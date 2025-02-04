//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBC_ACC_T
	/// </summary>
	public class TbcAccVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ACC_LEN1
		/// </summary>
		public int AccLen1 { get; }

		/// <summary>
		/// Value of variable $ACC_LEN2
		/// </summary>
		public int AccLen2 { get; }

		/// <summary>
		/// Value of variable $ACCEL_RATIO
		/// </summary>
		public double AccelRatio { get; }

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
		/// Value of variable $J_STAT
		/// </summary>
		public int[] JStat { get; }

		/// <summary>
		/// Value of variable $M_STAT
		/// </summary>
		public int MStat { get; }

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
		/// Value of variable $AC_ACC
		/// </summary>
		public double AcAcc { get; }

		/// <summary>
		/// Value of variable $JK_ACC
		/// </summary>
		public double JkAcc { get; }

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
		/// Value of variable $AAL1
		/// </summary>
		public double Aal1 { get; }

		/// <summary>
		/// Value of variable $AAL2
		/// </summary>
		public double Aal2 { get; }

		/// <summary>
		/// Value of variable $AAL3
		/// </summary>
		public double Aal3 { get; }

		/// <summary>
		/// Value of variable $AAL4
		/// </summary>
		public double Aal4 { get; }

		/// <summary>
		/// Value of variable $AAL5
		/// </summary>
		public double Aal5 { get; }

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
