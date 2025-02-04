//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TBC2_GRP_T
	/// </summary>
	public class Tbc2GrpVariableType : GenericVariableType, IGenericVariableType {


		public Tbc2GrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENB_FLIM
		/// </summary>
		public bool EnbFlim { get; }

		/// <summary>
		/// Value of variable $LIM_FTM1
		/// </summary>
		public int LimFtm1 { get; }

		/// <summary>
		/// Value of variable $LIM_FTM2
		/// </summary>
		public int LimFtm2 { get; }

		/// <summary>
		/// Value of variable $TDC_FLAG
		/// </summary>
		public bool TdcFlag { get; }

		/// <summary>
		/// Value of variable $TDC_MINF
		/// </summary>
		public int TdcMinf { get; }

		/// <summary>
		/// Value of variable $TDC_MINF2
		/// </summary>
		public int TdcMinf2 { get; }

		/// <summary>
		/// Value of variable $TDC_THDIST
		/// </summary>
		public double TdcThdist { get; }

		/// <summary>
		/// Value of variable $TDC_THSPEED
		/// </summary>
		public double TdcThspeed { get; }

		/// <summary>
		/// Value of variable $TDC_THROT
		/// </summary>
		public double TdcThrot { get; }

		/// <summary>
		/// Value of variable $RESERVE1
		/// </summary>
		public int Reserve1 { get; }

		/// <summary>
		/// Value of variable $RESERVE2
		/// </summary>
		public int Reserve2 { get; }

		/// <summary>
		/// Value of variable $RESERVE3
		/// </summary>
		public int Reserve3 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
