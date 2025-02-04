//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PSLGTEMP_T
	/// </summary>
	public class PslgtempVariableType : GenericVariableType, IGenericVariableType {


		public PslgtempVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DAT_TYP
		/// </summary>
		public int DatTyp { get; }

		/// <summary>
		/// Value of variable $JNUM
		/// </summary>
		public int Jnum { get; }

		/// <summary>
		/// Value of variable $DO_REC
		/// </summary>
		public int DoRec { get; }

		/// <summary>
		/// Value of variable $FIL_MP
		/// </summary>
		public int FilMp { get; }

		/// <summary>
		/// Value of variable $FIL_VEL
		/// </summary>
		public int FilVel { get; }

		/// <summary>
		/// Value of variable $RST_TQMON
		/// </summary>
		public int RstTqmon { get; }

		/// <summary>
		/// Value of variable $PNO
		/// </summary>
		public string Pno { get; }

		/// <summary>
		/// Value of variable $C_RESULT
		/// </summary>
		public int[] CResult { get; }

		/// <summary>
		/// Value of variable $V_RESULT
		/// </summary>
		public int[] VResult { get; }

		/// <summary>
		/// Value of variable $CV_RESULT
		/// </summary>
		public int[] CvResult { get; }

		/// <summary>
		/// Value of variable $CP_FILE
		/// </summary>
		public int[] CpFile { get; }

		/// <summary>
		/// Value of variable $CM_FILE
		/// </summary>
		public int[] CmFile { get; }

		/// <summary>
		/// Value of variable $V1P_FILE
		/// </summary>
		public int[] V1pFile { get; }

		/// <summary>
		/// Value of variable $V1M_FILE
		/// </summary>
		public int[] V1mFile { get; }

		/// <summary>
		/// Value of variable $V2P_FILE
		/// </summary>
		public int[] V2pFile { get; }

		/// <summary>
		/// Value of variable $V2M_FILE
		/// </summary>
		public int[] V2mFile { get; }

		/// <summary>
		/// Value of variable $V3P_FILE
		/// </summary>
		public int[] V3pFile { get; }

		/// <summary>
		/// Value of variable $V3M_FILE
		/// </summary>
		public int[] V3mFile { get; }

		/// <summary>
		/// Value of variable $V4P_FILE
		/// </summary>
		public int[] V4pFile { get; }

		/// <summary>
		/// Value of variable $V4M_FILE
		/// </summary>
		public int[] V4mFile { get; }

		/// <summary>
		/// Value of variable $CUR_1
		/// </summary>
		public double[] Cur1 { get; }

		/// <summary>
		/// Value of variable $CUR_2
		/// </summary>
		public double[] Cur2 { get; }

		/// <summary>
		/// Value of variable $CUR_T
		/// </summary>
		public double[] CurT { get; }

		/// <summary>
		/// Value of variable $MINCUR_T
		/// </summary>
		public double[] MincurT { get; }

		/// <summary>
		/// Value of variable $VIB11
		/// </summary>
		public int[] Vib11 { get; }

		/// <summary>
		/// Value of variable $VIB12
		/// </summary>
		public int[] Vib12 { get; }

		/// <summary>
		/// Value of variable $VIB21
		/// </summary>
		public int[] Vib21 { get; }

		/// <summary>
		/// Value of variable $VIB22
		/// </summary>
		public int[] Vib22 { get; }

		/// <summary>
		/// Value of variable $VIB31
		/// </summary>
		public int[] Vib31 { get; }

		/// <summary>
		/// Value of variable $VIB32
		/// </summary>
		public int[] Vib32 { get; }

		/// <summary>
		/// Value of variable $VIB41
		/// </summary>
		public int[] Vib41 { get; }

		/// <summary>
		/// Value of variable $VIB42
		/// </summary>
		public int[] Vib42 { get; }

		/// <summary>
		/// Value of variable $VIB_T
		/// </summary>
		public int[] VibT { get; }

		/// <summary>
		/// Value of variable $CL_RESULT
		/// </summary>
		public int[] ClResult { get; }

		/// <summary>
		/// Value of variable $CUR_3
		/// </summary>
		public double[] Cur3 { get; }

		/// <summary>
		/// Value of variable $CUR_4
		/// </summary>
		public double[] Cur4 { get; }

		/// <summary>
		/// Value of variable $CUR_T2
		/// </summary>
		public double[] CurT2 { get; }

		/// <summary>
		/// Value of variable $MINCUR_T2
		/// </summary>
		public double[] MincurT2 { get; }

		/// <summary>
		/// Value of variable $PLUS_TORQUE
		/// </summary>
		public double[] PlusTorque { get; }

		/// <summary>
		/// Value of variable $MINUS_TORQU
		/// </summary>
		public double[] MinusTorqu { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
