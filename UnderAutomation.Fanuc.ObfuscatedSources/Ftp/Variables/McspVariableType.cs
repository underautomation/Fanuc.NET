//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MCSP_T
	/// </summary>
	public class McspVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CLDPOP_ENB
		/// </summary>
		public bool CldpopEnb { get; }

		/// <summary>
		/// Value of variable $TRQLIM_ENB
		/// </summary>
		public bool TrqlimEnb { get; }

		/// <summary>
		/// Value of variable $JOGLIM_ENB
		/// </summary>
		public bool JoglimEnb { get; }

		/// <summary>
		/// Value of variable $CLDPOP_FLG
		/// </summary>
		public bool CldpopFlg { get; }

		/// <summary>
		/// Value of variable $CLDGRP_FLG
		/// </summary>
		public int CldgrpFlg { get; }

		/// <summary>
		/// Value of variable $CLDREL_FLG
		/// </summary>
		public bool CldrelFlg { get; }

		/// <summary>
		/// Value of variable $CLR_CLDFLG
		/// </summary>
		public bool ClrCldflg { get; }

		/// <summary>
		/// Value of variable $JOGLIM_FLG
		/// </summary>
		public bool JoglimFlg { get; }

		/// <summary>
		/// Value of variable $ORGJOG_OVR
		/// </summary>
		public int OrgjogOvr { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public int CompSw { get; }

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
