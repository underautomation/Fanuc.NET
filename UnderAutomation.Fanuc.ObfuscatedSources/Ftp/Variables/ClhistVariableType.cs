//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CLHIST_T
	/// </summary>
	public class ClhistVariableType : GenericVariableType, IGenericVariableType {


		public ClhistVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CLDET_AXS
		/// </summary>
		public short CldetAxs { get; }

		/// <summary>
		/// Value of variable $PS_CLDET_TI
		/// </summary>
		public short PsCldetTi { get; }

		/// <summary>
		/// Value of variable $CLDET_TIME
		/// </summary>
		public int CldetTime { get; }

		/// <summary>
		/// Value of variable $JPOS_CMD
		/// </summary>
		public double[] JposCmd { get; }

		/// <summary>
		/// Value of variable $JPOS_FB
		/// </summary>
		public double[] JposFb { get; }

		/// <summary>
		/// Value of variable $VEL_FB
		/// </summary>
		public double[] VelFb { get; }

		/// <summary>
		/// Value of variable $CL_OVR
		/// </summary>
		public int ClOvr { get; }

		/// <summary>
		/// Value of variable $CL_FRMZ
		/// </summary>
		public int ClFrmz { get; }

		/// <summary>
		/// Value of variable $CLDEPT_IDX
		/// </summary>
		public int CldeptIdx { get; }

		/// <summary>
		/// Value of variable $CLNAME
		/// </summary>
		public string Clname { get; }

		/// <summary>
		/// Value of variable $CLCURLINE
		/// </summary>
		public int Clcurline { get; }

		/// <summary>
		/// Value of variable $WNT_CNT
		/// </summary>
		public int WntCnt { get; }

		/// <summary>
		/// Value of variable $STCK_CNT
		/// </summary>
		public int StckCnt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
