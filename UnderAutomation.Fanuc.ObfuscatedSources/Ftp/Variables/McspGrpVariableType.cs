//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MCSP_GRP_T
	/// </summary>
	public class McspGrpVariableType : GenericVariableType, IGenericVariableType {


		public McspGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $JOGLIM_OVR
		/// </summary>
		public int JoglimOvr { get; }

		/// <summary>
		/// Value of variable $TRQLIM_FLG
		/// </summary>
		public bool TrqlimFlg { get; }

		/// <summary>
		/// Value of variable $SV_PTLIM
		/// </summary>
		public int[] SvPtlim { get; }

		/// <summary>
		/// Value of variable $ORG_PTLIM
		/// </summary>
		public int[] OrgPtlim { get; }

		/// <summary>
		/// Value of variable $ORG_RCLMC
		/// </summary>
		public int[] OrgRclmc { get; }

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
		public int[] Reserve3 { get; }

		/// <summary>
		/// Value of variable $RESERVE4
		/// </summary>
		public int[] Reserve4 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
