//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AAVM_WRK_T
	/// </summary>
	public class AavmWrkVariableType : GenericVariableType, IGenericVariableType {


		public AavmWrkVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $EXPOSURE
		/// </summary>
		public int Exposure { get; }

		/// <summary>
		/// Value of variable $CAMCLBDATE
		/// </summary>
		public string Camclbdate { get; }

		/// <summary>
		/// Value of variable $TRGVT
		/// </summary>
		public double Trgvt { get; }

		/// <summary>
		/// Value of variable $TRGHZ
		/// </summary>
		public double Trghz { get; }

		/// <summary>
		/// Value of variable $TRGDIST
		/// </summary>
		public double Trgdist { get; }

		/// <summary>
		/// Value of variable $TRGW
		/// </summary>
		public double Trgw { get; }

		/// <summary>
		/// Value of variable $TRGP
		/// </summary>
		public double Trgp { get; }

		/// <summary>
		/// Value of variable $TRGR
		/// </summary>
		public double Trgr { get; }

		/// <summary>
		/// Value of variable $LENS_CENT_X
		/// </summary>
		public double LensCentX { get; }

		/// <summary>
		/// Value of variable $LENS_CENT_Y
		/// </summary>
		public double LensCentY { get; }

		/// <summary>
		/// Value of variable $DISTORT
		/// </summary>
		public double[] Distort { get; }

		/// <summary>
		/// Value of variable $CMP_GC_P
		/// </summary>
		public double CmpGcP { get; }

		/// <summary>
		/// Value of variable $UTNUM
		/// </summary>
		public int Utnum { get; }

		/// <summary>
		/// Value of variable $PRE_MAST_CT
		/// </summary>
		public int[] PreMastCt { get; }

		/// <summary>
		/// Value of variable $PRE_GRV_MST
		/// </summary>
		public int PreGrvMst { get; }

		/// <summary>
		/// Value of variable $NEW_MAST_CT
		/// </summary>
		public int[] NewMastCt { get; }

		/// <summary>
		/// Value of variable $NEW_GRV_MST
		/// </summary>
		public int NewGrvMst { get; }

		/// <summary>
		/// Value of variable $STAT_RUN
		/// </summary>
		public int StatRun { get; }

		/// <summary>
		/// Value of variable $RES_ERR
		/// </summary>
		public double ResErr { get; }

		/// <summary>
		/// Value of variable $VTCP_ERR
		/// </summary>
		public double[] VtcpErr { get; }

		/// <summary>
		/// Value of variable $TRGT_ERR
		/// </summary>
		public double[] TrgtErr { get; }

		/// <summary>
		/// Value of variable $RES_ERR2
		/// </summary>
		public double ResErr2 { get; }

		/// <summary>
		/// Value of variable $VTCP_ERR2
		/// </summary>
		public double[] VtcpErr2 { get; }

		/// <summary>
		/// Value of variable $RSM_MAST_CT
		/// </summary>
		public int[] RsmMastCt { get; }

		/// <summary>
		/// Value of variable $STAT_START
		/// </summary>
		public int StatStart { get; }

		/// <summary>
		/// Value of variable $STAT_END
		/// </summary>
		public int StatEnd { get; }

		/// <summary>
		/// Value of variable $STAT_ORGBK
		/// </summary>
		public int StatOrgbk { get; }

		/// <summary>
		/// Value of variable $STAT_RSMBK
		/// </summary>
		public int StatRsmbk { get; }

		/// <summary>
		/// Value of variable $STAT_ORGRES
		/// </summary>
		public int StatOrgres { get; }

		/// <summary>
		/// Value of variable $STAT_UPDT
		/// </summary>
		public int StatUpdt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
