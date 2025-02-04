//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PLID_SV_T
	/// </summary>
	public class PlidSvVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CUR_SCRN
		/// </summary>
		public byte CurScrn { get; }

		/// <summary>
		/// Value of variable $CUR_GROUP
		/// </summary>
		public byte CurGroup { get; }

		/// <summary>
		/// Value of variable $SAVE_DONE
		/// </summary>
		public bool SaveDone { get; }

		/// <summary>
		/// Value of variable $NO_RECOVER
		/// </summary>
		public bool NoRecover { get; }

		/// <summary>
		/// Value of variable $RESULT_SAV
		/// </summary>
		public double[] ResultSav { get; }

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public double Payload { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_X
		/// </summary>
		public double PayloadX { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_Y
		/// </summary>
		public double PayloadY { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_Z
		/// </summary>
		public double PayloadZ { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IX
		/// </summary>
		public double PayloadIx { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IY
		/// </summary>
		public double PayloadIy { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IZ
		/// </summary>
		public double PayloadIz { get; }

		/// <summary>
		/// Value of variable $ARMLOAD1
		/// </summary>
		public double Armload1 { get; }

		/// <summary>
		/// Value of variable $ARMLOAD2
		/// </summary>
		public double Armload2 { get; }

		/// <summary>
		/// Value of variable $DO_DEFAULT
		/// </summary>
		public bool DoDefault { get; }

		/// <summary>
		/// Value of variable $MOV_POS1
		/// </summary>
		public double[] MovPos1 { get; }

		/// <summary>
		/// Value of variable $MOV_POS2
		/// </summary>
		public double[] MovPos2 { get; }

		/// <summary>
		/// Value of variable $SPEED_HIGH
		/// </summary>
		public int SpeedHigh { get; }

		/// <summary>
		/// Value of variable $SPEED_LOW
		/// </summary>
		public int SpeedLow { get; }

		/// <summary>
		/// Value of variable $ACCEL_HIGH
		/// </summary>
		public int AccelHigh { get; }

		/// <summary>
		/// Value of variable $ACCEL_LOW
		/// </summary>
		public int AccelLow { get; }

		/// <summary>
		/// Value of variable $DO_DEF_POS
		/// </summary>
		public bool DoDefPos { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
