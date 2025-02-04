//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ZMPOS_GRP_T
	/// </summary>
	public class ZmposGrpVariableType : GenericVariableType, IGenericVariableType {


		public ZmposGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $M_POS_ENB
		/// </summary>
		public int MPosEnb { get; }

		/// <summary>
		/// Value of variable $CMCMD_SCL
		/// </summary>
		public int CmcmdScl { get; }

		/// <summary>
		/// Value of variable $CART_MCMD
		/// </summary>
		public double[] CartMcmd { get; }

		/// <summary>
		/// Value of variable $P_ACT
		/// </summary>
		public CartesianPositionVariable PAct { get; }

		/// <summary>
		/// Value of variable $J_ACT
		/// </summary>
		public double[] JAct { get; }

		/// <summary>
		/// Value of variable $P_DES
		/// </summary>
		public CartesianPositionVariable PDes { get; }

		/// <summary>
		/// Value of variable $J_DES
		/// </summary>
		public double[] JDes { get; }

		/// <summary>
		/// Value of variable $P_DES2
		/// </summary>
		public CartesianPositionVariable PDes2 { get; }

		/// <summary>
		/// Value of variable $J_DES2
		/// </summary>
		public double[] JDes2 { get; }

		/// <summary>
		/// Value of variable $P_ACT_UF
		/// </summary>
		public double[] PActUf { get; }

		/// <summary>
		/// Value of variable $P_DES_UF
		/// </summary>
		public double[] PDesUf { get; }

		/// <summary>
		/// Value of variable $UXWPR_ENB
		/// </summary>
		public int UxwprEnb { get; }

		/// <summary>
		/// Value of variable $UXEUL_ENB
		/// </summary>
		public int UxeulEnb { get; }

		/// <summary>
		/// Value of variable $UXWPR_ACT
		/// </summary>
		public double[] UxwprAct { get; }

		/// <summary>
		/// Value of variable $UXWPR_DES
		/// </summary>
		public double[] UxwprDes { get; }

		/// <summary>
		/// Value of variable $UXEUL_ACT
		/// </summary>
		public double[] UxeulAct { get; }

		/// <summary>
		/// Value of variable $UXEUL_DES
		/// </summary>
		public double[] UxeulDes { get; }

		/// <summary>
		/// Value of variable $P_AFTFLT
		/// </summary>
		public CartesianPositionVariable PAftflt { get; }

		/// <summary>
		/// Value of variable $J_AFTFLT
		/// </summary>
		public double[] JAftflt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
