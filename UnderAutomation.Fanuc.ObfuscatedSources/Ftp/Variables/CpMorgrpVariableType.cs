//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CP_MORGRP_T
	/// </summary>
	public class CpMorgrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CHNS_EMPTY
		/// </summary>
		public bool ChnsEmpty { get; }

		/// <summary>
		/// Value of variable $GTF_EMPTY
		/// </summary>
		public bool GtfEmpty { get; }

		/// <summary>
		/// Value of variable $CHK_T1_SPD
		/// </summary>
		public bool ChkT1Spd { get; }

		/// <summary>
		/// Value of variable $T1_FPSPD
		/// </summary>
		public double T1Fpspd { get; }

		/// <summary>
		/// Value of variable $T1_TCPSPD
		/// </summary>
		public double T1Tcpspd { get; }

		/// <summary>
		/// Value of variable $SPEED
		/// </summary>
		public double Speed { get; }

		/// <summary>
		/// Value of variable $T1SPDLIM
		/// </summary>
		public double T1spdlim { get; }

		/// <summary>
		/// Value of variable $SPEEDTOL
		/// </summary>
		public double Speedtol { get; }

		/// <summary>
		/// Value of variable $JNT_VEL
		/// </summary>
		public double[] JntVel { get; }

		/// <summary>
		/// Value of variable $JNT_ACC
		/// </summary>
		public double[] JntAcc { get; }

		/// <summary>
		/// Value of variable $JNT_JRK
		/// </summary>
		public double[] JntJrk { get; }

		/// <summary>
		/// Value of variable $SEGFRACTION
		/// </summary>
		public double Segfraction { get; }

		/// <summary>
		/// Value of variable $RSTRT_LINE
		/// </summary>
		public int RstrtLine { get; }

		/// <summary>
		/// Value of variable $RSTRT_PVF
		/// </summary>
		public int RstrtPvf { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
