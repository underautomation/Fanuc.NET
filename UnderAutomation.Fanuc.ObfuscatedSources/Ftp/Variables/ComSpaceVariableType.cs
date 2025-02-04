//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type COM_SPACE_T
	/// </summary>
	public class ComSpaceVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $USE_MLT_CTN
		/// </summary>
		public bool UseMltCtn { get; }

		/// <summary>
		/// Value of variable $H_PRIORITY
		/// </summary>
		public bool HPriority { get; }

		/// <summary>
		/// Value of variable $IN_CONTROL
		/// </summary>
		public bool InControl { get; }

		/// <summary>
		/// Value of variable $IN_SPACE_GP
		/// </summary>
		public int InSpaceGp { get; }

		/// <summary>
		/// Value of variable $WT_SPACE_GP
		/// </summary>
		public short WtSpaceGp { get; }

		/// <summary>
		/// Value of variable $USE_GP
		/// </summary>
		public short UseGp { get; }

		/// <summary>
		/// Value of variable $DEADLOCK_GP
		/// </summary>
		public int DeadlockGp { get; }

		/// <summary>
		/// Value of variable $DELAY_CNT1
		/// </summary>
		public short DelayCnt1 { get; }

		/// <summary>
		/// Value of variable $DELAY_CNT2
		/// </summary>
		public short DelayCnt2 { get; }

		/// <summary>
		/// Value of variable $GP_STATUS
		/// </summary>
		public GpStatusVariableType[] GpStatus { get; }

		/// <summary>
		/// Value of variable $DOUT1_TYPE
		/// </summary>
		public int Dout1Type { get; }

		/// <summary>
		/// Value of variable $DOUT1_INDX
		/// </summary>
		public int Dout1Indx { get; }

		/// <summary>
		/// Value of variable $DOUT2_TYPE
		/// </summary>
		public int Dout2Type { get; }

		/// <summary>
		/// Value of variable $DOUT2_INDX
		/// </summary>
		public int Dout2Indx { get; }

		/// <summary>
		/// Value of variable $DOUT3_TYPE
		/// </summary>
		public int Dout3Type { get; }

		/// <summary>
		/// Value of variable $DOUT3_INDX
		/// </summary>
		public int Dout3Indx { get; }

		/// <summary>
		/// Value of variable $DIN1_TYPE
		/// </summary>
		public int Din1Type { get; }

		/// <summary>
		/// Value of variable $DIN1_INDX
		/// </summary>
		public int Din1Indx { get; }

		/// <summary>
		/// Value of variable $DIN2_TYPE
		/// </summary>
		public int Din2Type { get; }

		/// <summary>
		/// Value of variable $DIN2_INDX
		/// </summary>
		public int Din2Indx { get; }

		/// <summary>
		/// Value of variable $EXT1
		/// </summary>
		public int Ext1 { get; }

		/// <summary>
		/// Value of variable $EXT2
		/// </summary>
		public int Ext2 { get; }

		/// <summary>
		/// Value of variable $V1
		/// </summary>
		public double[] V1 { get; }

		/// <summary>
		/// Value of variable $V2
		/// </summary>
		public double[] V2 { get; }

		/// <summary>
		/// Value of variable $V3
		/// </summary>
		public double[] V3 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
