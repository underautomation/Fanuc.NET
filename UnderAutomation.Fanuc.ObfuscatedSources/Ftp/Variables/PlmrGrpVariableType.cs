//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PLMR_GRP_T
	/// </summary>
	public class PlmrGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PYLD_ENB
		/// </summary>
		public bool PyldEnb { get; }

		/// <summary>
		/// Value of variable $WMR_ENB
		/// </summary>
		public bool WmrEnb { get; }

		/// <summary>
		/// Value of variable $ANGLE
		/// </summary>
		public double Angle { get; }

		/// <summary>
		/// Value of variable $PLMR_AA
		/// </summary>
		public double PlmrAa { get; }

		/// <summary>
		/// Value of variable $PLMR_BB
		/// </summary>
		public double PlmrBb { get; }

		/// <summary>
		/// Value of variable $PLMR_CC
		/// </summary>
		public double PlmrCc { get; }

		/// <summary>
		/// Value of variable $PLMR_DD
		/// </summary>
		public double PlmrDd { get; }

		/// <summary>
		/// Value of variable $PLST_ANG
		/// </summary>
		public double[] PlstAng { get; }

		/// <summary>
		/// Value of variable $COMP_SW
		/// </summary>
		public int CompSw { get; }

		/// <summary>
		/// Value of variable $MAX_XY_LOC
		/// </summary>
		public double MaxXyLoc { get; }

		/// <summary>
		/// Value of variable $MAX_Z_LOC
		/// </summary>
		public double MaxZLoc { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
