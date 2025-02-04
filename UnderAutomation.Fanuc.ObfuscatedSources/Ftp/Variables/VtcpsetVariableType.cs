//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VTCPSET_T
	/// </summary>
	public class VtcpsetVariableType : GenericVariableType, IGenericVariableType {


		public VtcpsetVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable MOVE_DIST_XY
		/// </summary>
		public double MoveDistXy { get; }

		/// <summary>
		/// Value of variable MOVE_DIST_Z
		/// </summary>
		public double MoveDistZ { get; }

		/// <summary>
		/// Value of variable MOVE_DIST_R
		/// </summary>
		public double MoveDistR { get; }

		/// <summary>
		/// Value of variable MOVE_DIST_W
		/// </summary>
		public double MoveDistW { get; }

		/// <summary>
		/// Value of variable MOVE_DIST_P
		/// </summary>
		public double MoveDistP { get; }

		/// <summary>
		/// Value of variable MOVE_DIST_FW
		/// </summary>
		public double MoveDistFw { get; }

		/// <summary>
		/// Value of variable MOVE_DIST_FP
		/// </summary>
		public double MoveDistFp { get; }

		/// <summary>
		/// Value of variable DIV_NUM_Z
		/// </summary>
		public int DivNumZ { get; }

		/// <summary>
		/// Value of variable DIV_NUM_R
		/// </summary>
		public int DivNumR { get; }

		/// <summary>
		/// Value of variable DIV_NUM_WP
		/// </summary>
		public int DivNumWp { get; }

		/// <summary>
		/// Value of variable DIV_NUM_FWP
		/// </summary>
		public int DivNumFwp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
