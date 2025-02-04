//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type RSPACE_T
	/// </summary>
	public class RspaceVariableType : GenericVariableType, IGenericVariableType {


		public RspaceVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $COMMENT
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Value of variable $USAGE
		/// </summary>
		public int Usage { get; }

		/// <summary>
		/// Value of variable $ENABLED
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Value of variable $IN_EXTERIOR
		/// </summary>
		public bool InExterior { get; }

		/// <summary>
		/// Value of variable $ENTRY
		/// </summary>
		public bool Entry { get; }

		/// <summary>
		/// Value of variable $ENT_SIGN_ON
		/// </summary>
		public bool EntSignOn { get; }

		/// <summary>
		/// Value of variable $PRIORITY
		/// </summary>
		public bool Priority { get; }

		/// <summary>
		/// Value of variable $PRIORWRK
		/// </summary>
		public bool Priorwrk { get; }

		/// <summary>
		/// Value of variable $DOUT_TYPE
		/// </summary>
		public int DoutType { get; }

		/// <summary>
		/// Value of variable $DOUT_INDX
		/// </summary>
		public int DoutIndx { get; }

		/// <summary>
		/// Value of variable $DIN_TYPE
		/// </summary>
		public int DinType { get; }

		/// <summary>
		/// Value of variable $DIN_INDX
		/// </summary>
		public int DinIndx { get; }

		/// <summary>
		/// Value of variable $FRIEND_GRP
		/// </summary>
		public byte FriendGrp { get; }

		/// <summary>
		/// Value of variable $UFRAM_NUM
		/// </summary>
		public byte UframNum { get; }

		/// <summary>
		/// Value of variable $UTOOL_NUM
		/// </summary>
		public byte UtoolNum { get; }

		/// <summary>
		/// Value of variable $MYHOLD
		/// </summary>
		public byte Myhold { get; }

		/// <summary>
		/// Value of variable $LENGTH_VTEX
		/// </summary>
		public int LengthVtex { get; }

		/// <summary>
		/// Value of variable $FIRST_VTEX
		/// </summary>
		public double[] FirstVtex { get; }

		/// <summary>
		/// Value of variable $SECND_VTEX
		/// </summary>
		public double[] SecndVtex { get; }

		/// <summary>
		/// Value of variable $UFINV_POST
		/// </summary>
		public CartesianPositionVariable UfinvPost { get; }

		/// <summary>
		/// Value of variable $MARGIN
		/// </summary>
		public double Margin { get; }

		/// <summary>
		/// Value of variable $WAITING
		/// </summary>
		public int Waiting { get; }

		/// <summary>
		/// Value of variable $FIRST_VTX2
		/// </summary>
		public double[] FirstVtx2 { get; }

		/// <summary>
		/// Value of variable $SECND_VTX2
		/// </summary>
		public double[] SecndVtx2 { get; }

		/// <summary>
		/// Value of variable $G2ENTRY
		/// </summary>
		public bool G2entry { get; }

		/// <summary>
		/// Value of variable $G1ENT_INTR
		/// </summary>
		public bool G1entIntr { get; }

		/// <summary>
		/// Value of variable $G2ENT_INTR
		/// </summary>
		public bool G2entIntr { get; }

		/// <summary>
		/// Value of variable $PRE_UFRAM
		/// </summary>
		public int PreUfram { get; }

		/// <summary>
		/// Value of variable $NO_USE_DI
		/// </summary>
		public bool NoUseDi { get; }

		/// <summary>
		/// Value of variable $HOLD_REQ
		/// </summary>
		public bool HoldReq { get; }

		/// <summary>
		/// Value of variable $CSPACE_NUM
		/// </summary>
		public int CspaceNum { get; }

		/// <summary>
		/// Value of variable $CUR_TCP
		/// </summary>
		public double[] CurTcp { get; }

		/// <summary>
		/// Value of variable $PRE_TCP
		/// </summary>
		public double[] PreTcp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
