//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VCMR_GRP_T
	/// </summary>
	public class VcmrGrpVariableType : GenericVariableType, IGenericVariableType {


		public VcmrGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $STAT_FLAGS
		/// </summary>
		public int StatFlags { get; }

		/// <summary>
		/// Value of variable $MENU_CODE
		/// </summary>
		public int MenuCode { get; }

		/// <summary>
		/// Value of variable $GROUP_NUM
		/// </summary>
		public int GroupNum { get; }

		/// <summary>
		/// Value of variable $UTOOL_NUM
		/// </summary>
		public int UtoolNum { get; }

		/// <summary>
		/// Value of variable $CAMERA
		/// </summary>
		public CameraVariableType Camera { get; }

		/// <summary>
		/// Value of variable $TARGET_ID
		/// </summary>
		public VcmrTrgtVariableType[] TargetId { get; }

		/// <summary>
		/// Value of variable $CREATE_PRG
		/// </summary>
		public CreatePrgVariableType CreatePrg { get; }

		/// <summary>
		/// Value of variable $DATA_ID
		/// </summary>
		public int DataId { get; }

		/// <summary>
		/// Value of variable $CHK_RESULT
		/// </summary>
		public ChkResultVariableType ChkResult { get; }

		/// <summary>
		/// Value of variable $RECOVERY
		/// </summary>
		public RecoveryVariableType Recovery { get; }

		/// <summary>
		/// Value of variable $EXT_INT1
		/// </summary>
		public int ExtInt1 { get; }

		/// <summary>
		/// Value of variable $EXT_INT2
		/// </summary>
		public int ExtInt2 { get; }

		/// <summary>
		/// Value of variable $EXT_INT3
		/// </summary>
		public int ExtInt3 { get; }

		/// <summary>
		/// Value of variable $EXT_INT4
		/// </summary>
		public int ExtInt4 { get; }

		/// <summary>
		/// Value of variable $EXT_REAL1
		/// </summary>
		public double ExtReal1 { get; }

		/// <summary>
		/// Value of variable $EXT_REAL2
		/// </summary>
		public double ExtReal2 { get; }

		/// <summary>
		/// Value of variable $EXT_REAL3
		/// </summary>
		public double ExtReal3 { get; }

		/// <summary>
		/// Value of variable $EXT_REAL4
		/// </summary>
		public double ExtReal4 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
