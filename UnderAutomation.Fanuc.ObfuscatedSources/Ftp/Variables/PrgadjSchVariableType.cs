//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PRGADJ_SCH_T
	/// </summary>
	public class PrgadjSchVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PROG_NAME
		/// </summary>
		public string ProgName { get; }

		/// <summary>
		/// Value of variable $LINE_STRT
		/// </summary>
		public int LineStrt { get; }

		/// <summary>
		/// Value of variable $LINE_END
		/// </summary>
		public int LineEnd { get; }

		/// <summary>
		/// Value of variable $BEGIN_LINE
		/// </summary>
		public int BeginLine { get; }

		/// <summary>
		/// Value of variable $LAST_LINE
		/// </summary>
		public int LastLine { get; }

		/// <summary>
		/// Value of variable $LAST_POSNUM
		/// </summary>
		public int LastPosnum { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable $UNITS
		/// </summary>
		public int Units { get; }

		/// <summary>
		/// Value of variable $FRAME_NAME
		/// </summary>
		public int FrameName { get; }

		/// <summary>
		/// Value of variable $X_ADJ
		/// </summary>
		public double XAdj { get; }

		/// <summary>
		/// Value of variable $Y_ADJ
		/// </summary>
		public double YAdj { get; }

		/// <summary>
		/// Value of variable $Z_ADJ
		/// </summary>
		public double ZAdj { get; }

		/// <summary>
		/// Value of variable $W_ADJ
		/// </summary>
		public double WAdj { get; }

		/// <summary>
		/// Value of variable $P_ADJ
		/// </summary>
		public double PAdj { get; }

		/// <summary>
		/// Value of variable $R_ADJ
		/// </summary>
		public double RAdj { get; }

		/// <summary>
		/// Value of variable $Y_OPT_ADJ
		/// </summary>
		public int YOptAdj { get; }

		/// <summary>
		/// Value of variable $LIN_SPD_ADJ
		/// </summary>
		public int LinSpdAdj { get; }

		/// <summary>
		/// Value of variable $JT_SPD_ADJ
		/// </summary>
		public int JtSpdAdj { get; }

		/// <summary>
		/// Value of variable $GROUP_ADJ
		/// </summary>
		public int GroupAdj { get; }

		/// <summary>
		/// Value of variable $GRP_PARTEN
		/// </summary>
		public bool[] GrpParten { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
