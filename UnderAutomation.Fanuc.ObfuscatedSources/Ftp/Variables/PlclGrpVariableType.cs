//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PLCL_GRP_T
	/// </summary>
	public class PlclGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $CALIB_STAT
		/// </summary>
		public int CalibStat { get; }

		/// <summary>
		/// Value of variable $TRQ_MGN
		/// </summary>
		public double[] TrqMgn { get; }

		/// <summary>
		/// Value of variable $LINK_M
		/// </summary>
		public double[] LinkM { get; }

		/// <summary>
		/// Value of variable $LINK_SX
		/// </summary>
		public double[] LinkSx { get; }

		/// <summary>
		/// Value of variable $LINK_SY
		/// </summary>
		public double[] LinkSy { get; }

		/// <summary>
		/// Value of variable $LINK_SZ
		/// </summary>
		public double[] LinkSz { get; }

		/// <summary>
		/// Value of variable $LINK_IX
		/// </summary>
		public double[] LinkIx { get; }

		/// <summary>
		/// Value of variable $LINK_IY
		/// </summary>
		public double[] LinkIy { get; }

		/// <summary>
		/// Value of variable $LINK_IZ
		/// </summary>
		public double[] LinkIz { get; }

		/// <summary>
		/// Value of variable $CALIB_3A
		/// </summary>
		public int Calib3a { get; }

		/// <summary>
		/// Value of variable $TQ_MGN3A
		/// </summary>
		public double[] TqMgn3a { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
