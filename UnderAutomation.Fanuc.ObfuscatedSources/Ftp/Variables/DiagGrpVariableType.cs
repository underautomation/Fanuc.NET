//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DIAG_GRP_T
	/// </summary>
	public class DiagGrpVariableType : GenericVariableType, IGenericVariableType {


		public DiagGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $VAL_SET
		/// </summary>
		public int ValSet { get; }

		/// <summary>
		/// Value of variable $TACC
		/// </summary>
		public double[] Tacc { get; }

		/// <summary>
		/// Value of variable $TACC_LIM1
		/// </summary>
		public double[] TaccLim1 { get; }

		/// <summary>
		/// Value of variable $TACC_LIM2
		/// </summary>
		public double[] TaccLim2 { get; }

		/// <summary>
		/// Value of variable $RRATE_LOAD
		/// </summary>
		public double[] RrateLoad { get; }

		/// <summary>
		/// Value of variable $VER
		/// </summary>
		public string Ver { get; }

		/// <summary>
		/// Value of variable $ANSWER
		/// </summary>
		public int Answer { get; }

		/// <summary>
		/// Value of variable $RCC_ANS
		/// </summary>
		public int RccAns { get; }

		/// <summary>
		/// Value of variable $ADJ_RTRQ
		/// </summary>
		public AdjRtrqVariableType[] AdjRtrq { get; }

		/// <summary>
		/// Value of variable $ADJ_OHTRQ
		/// </summary>
		public double[] AdjOhtrq { get; }

		/// <summary>
		/// Value of variable $COPPER
		/// </summary>
		public double[] Copper { get; }

		/// <summary>
		/// Value of variable $IRON
		/// </summary>
		public double[] Iron { get; }

		/// <summary>
		/// Value of variable $BRK_PWR
		/// </summary>
		public double[] BrkPwr { get; }

		/// <summary>
		/// Value of variable $CABLE_ACT
		/// </summary>
		public double[] CableAct { get; }

		/// <summary>
		/// Value of variable $CABLE_BASE
		/// </summary>
		public double[] CableBase { get; }

		/// <summary>
		/// Value of variable $CABLE_LENG
		/// </summary>
		public double[] CableLeng { get; }

		/// <summary>
		/// Value of variable $CAB_NUM
		/// </summary>
		public int CabNum { get; }

		/// <summary>
		/// Value of variable $CTRL_CAB
		/// </summary>
		public CtrlCabVariableType[] CtrlCab { get; }

		/// <summary>
		/// Value of variable $TRQCNS
		/// </summary>
		public double[] Trqcns { get; }

		/// <summary>
		/// Value of variable $TRQDWN
		/// </summary>
		public double[] Trqdwn { get; }

		/// <summary>
		/// Value of variable $MSBAS
		/// </summary>
		public double[] Msbas { get; }

		/// <summary>
		/// Value of variable $MAXTRQ
		/// </summary>
		public double[] Maxtrq { get; }

		/// <summary>
		/// Value of variable $RRATE
		/// </summary>
		public double[] Rrate { get; }

		/// <summary>
		/// Value of variable $LIFECALC
		/// </summary>
		public int[] Lifecalc { get; }

		/// <summary>
		/// Value of variable $L10
		/// </summary>
		public int[] L10 { get; }

		/// <summary>
		/// Value of variable $N0
		/// </summary>
		public double[] N0 { get; }

		/// <summary>
		/// Value of variable $T0
		/// </summary>
		public double[] T0 { get; }

		/// <summary>
		/// Value of variable $CUR_L10
		/// </summary>
		public double[] CurL10 { get; }

		/// <summary>
		/// Value of variable $TCP_TYPE
		/// </summary>
		public int TcpType { get; }

		/// <summary>
		/// Value of variable $CUR_TCP
		/// </summary>
		public CartesianPositionVariable CurTcp { get; }

		/// <summary>
		/// Value of variable $MOTN_STYLE
		/// </summary>
		public int MotnStyle { get; }

		/// <summary>
		/// Value of variable $FLAG
		/// </summary>
		public int Flag { get; }

		/// <summary>
		/// Value of variable $CUR_OVC
		/// </summary>
		public double[] CurOvc { get; }

		/// <summary>
		/// Value of variable $CUR_HEAT
		/// </summary>
		public double[] CurHeat { get; }

		/// <summary>
		/// Value of variable $SUPPORT_TYP
		/// </summary>
		public int[] SupportTyp { get; }

		/// <summary>
		/// Value of variable $ALL_SUPPORT
		/// </summary>
		public int AllSupport { get; }

		/// <summary>
		/// Value of variable $CUR_TCP_X
		/// </summary>
		public double CurTcpX { get; }

		/// <summary>
		/// Value of variable $CUR_TCP_Y
		/// </summary>
		public double CurTcpY { get; }

		/// <summary>
		/// Value of variable $CUR_TCP_Z
		/// </summary>
		public double CurTcpZ { get; }

		/// <summary>
		/// Value of variable $CUR_TCP_W
		/// </summary>
		public double CurTcpW { get; }

		/// <summary>
		/// Value of variable $CUR_TCP_P
		/// </summary>
		public double CurTcpP { get; }

		/// <summary>
		/// Value of variable $CUR_TCP_R
		/// </summary>
		public double CurTcpR { get; }

		/// <summary>
		/// Value of variable $CUR_SPEED
		/// </summary>
		public double CurSpeed { get; }

		/// <summary>
		/// Value of variable $XZ_ARM
		/// </summary>
		public double[] XzArm { get; }

		/// <summary>
		/// Value of variable $Y2_ARM
		/// </summary>
		public double[] Y2Arm { get; }

		/// <summary>
		/// Value of variable $COS_TPRESS
		/// </summary>
		public double[] CosTpress { get; }

		/// <summary>
		/// Value of variable $TAN_INC
		/// </summary>
		public double[] TanInc { get; }

		/// <summary>
		/// Value of variable $CUR_JSPD
		/// </summary>
		public double[] CurJspd { get; }

		/// <summary>
		/// Value of variable $IRON_H
		/// </summary>
		public double[] IronH { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
