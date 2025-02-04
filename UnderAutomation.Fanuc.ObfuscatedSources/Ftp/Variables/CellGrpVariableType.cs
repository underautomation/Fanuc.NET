//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CELL_GRP_T
	/// </summary>
	public class CellGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CELL_FRAME
		/// </summary>
		public CartesianPositionVariable CellFrame { get; }

		/// <summary>
		/// Value of variable $MOUNT_LOC
		/// </summary>
		public CartesianPositionVariable MountLoc { get; }

		/// <summary>
		/// Value of variable $CF_METHOD
		/// </summary>
		public int CfMethod { get; }

		/// <summary>
		/// Value of variable $CPY_SRC_IDX
		/// </summary>
		public int CpySrcIdx { get; }

		/// <summary>
		/// Value of variable $PLATFRM_OFS
		/// </summary>
		public CartesianPositionVariable PlatfrmOfs { get; }

		/// <summary>
		/// Value of variable $PLATFRM_DIM
		/// </summary>
		public VectorVariable PlatfrmDim { get; }

		/// <summary>
		/// Value of variable $BASE_OFFSET
		/// </summary>
		public CartesianPositionVariable BaseOffset { get; }

		/// <summary>
		/// Value of variable $BASE_DIM
		/// </summary>
		public VectorVariable BaseDim { get; }

		/// <summary>
		/// Value of variable $AUX_ORDER
		/// </summary>
		public int[] AuxOrder { get; }

		/// <summary>
		/// Value of variable $AUX_XYZ_MAP
		/// </summary>
		public int[] AuxXyzMap { get; }

		/// <summary>
		/// Value of variable $AUX_OFFSET
		/// </summary>
		public double[] AuxOffset { get; }

		/// <summary>
		/// Value of variable $AUX_LENGTH
		/// </summary>
		public double[] AuxLength { get; }

		/// <summary>
		/// Value of variable $ATTCH_GP_MS
		/// </summary>
		public int AttchGpMs { get; }

		/// <summary>
		/// Value of variable $AUTORAIL
		/// </summary>
		public int Autorail { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
