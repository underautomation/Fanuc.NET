//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type REQ_DATA_T
	/// </summary>
	public class ReqDataVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ERR_TYPE
		/// </summary>
		public int ErrType { get; }

		/// <summary>
		/// Value of variable $ERR_GRP
		/// </summary>
		public int ErrGrp { get; }

		/// <summary>
		/// Value of variable $ERR_AXIS
		/// </summary>
		public int ErrAxis { get; }

		/// <summary>
		/// Value of variable $AXIS_TYPE
		/// </summary>
		public bool AxisType { get; }

		/// <summary>
		/// Value of variable $ERROR_DIST
		/// </summary>
		public double ErrorDist { get; }

		/// <summary>
		/// Value of variable $ERR_TIME
		/// </summary>
		public int ErrTime { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
